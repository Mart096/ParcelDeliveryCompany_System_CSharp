using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Diagnostics;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.MapProviders;
using System.Net.Http;
using System.Net;

namespace ParcelDeliveryCompany_ClassLibrary1
{
    public partial class MapControler : UserControl
    {
        private List<PointLatLng> point_list1 = new List<PointLatLng>(); //ogólna lista punktów na mapie, zawierająca współrzędne każdego punktu
        private GMap.NET.WindowsForms.GMapOverlay markers = new GMap.NET.WindowsForms.GMapOverlay("markers"); //zbiór markerów, wyświetlanych na mapie
        private GMapOverlay routes = new GMapOverlay("routes"); //zbiór dróg, rysowanych pomiędzy markerami
        private GMapOverlay temp_route = new GMapOverlay("Selected route"); //droga zaznaczona na liście

        //private GMapOverlay all_routes = new GMapOverlay("All routes"); //używane w szukaniu optymalnej drogi przy pomocy problemu komiwojażera, przechowuje wszystkie drogi pomiędzy markerami (na podstawie tych danych można obliczyć odległość pomiędzy markerami)
        
        public MapControler()
        {
            InitializeComponent();
        }

        private void OnLoad(object sender, EventArgs e)
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (compatible; MSIE 10.0; Windows NT 6.2; WOW64; Trident / 6.0)");
            //GMapProvider.WebProxy = WebRequest.GetSystemWebProxy();
            //GMapProvider.WebProxy.Credentials = CredentialCache.DefaultNetworkCredentials;            
            //WebClient web = new WebClient();
            /*using (WebClient web = new WebClient())
            {
                web.Headers["User-Agent"] =
                "Mozilla/4.0 (Compatible; Windows NT 5.1; MSIE 6.0) " +
                "(compatible; MSIE 6.0; Windows NT 5.1; " +
                ".NET CLR 1.1.4322; .NET CLR 2.0.50727)";
            }*/
            System.Net.ServicePointManager.DefaultConnectionLimit = 2;
            gMapControl1.CacheLocation = AppDomain.CurrentDomain.BaseDirectory+"\\maps_cache";
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerAndCache;
            gMapControl1.MapProvider = GMap.NET.MapProviders.OpenStreet4UMapProvider.Instance;
            //gMapControl1.
            //gMapControl1.MapProvider = GMap.NET.MapProviders.OpenStreetMapProvider.Instance;
            //GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerAndCache;
            gMapControl1.SetPositionByKeywords("Żołnierska 51, Szczecin, Poland");
            gMapControl1.IgnoreMarkerOnMouseWheel = true;
            //gMapControl1.SetPositionByKeywords("Warsaw, Poland");
        }

        /*private void ExampleMarkers(object sender, EventArgs e)
        {
            //GMap.NET.WindowsForms.GMapOverlay markers = new GMap.NET.WindowsForms.GMapOverlay("markers");
            GMap.NET.WindowsForms.GMapMarker marker =
                new GMap.NET.WindowsForms.Markers.GMarkerGoogle(
                    new GMap.NET.PointLatLng(48.8617774, 2.349272),
                    GMap.NET.WindowsForms.Markers.GMarkerGoogleType.arrow);
            markers.Markers.Add(marker);
            gMapControl1.Overlays.Add(markers);
        }*/

        private void ExampleRouteButton1_Click(object sender, EventArgs e)
        {
            GMapOverlay routes = new GMapOverlay("routes");
            List<PointLatLng> points = new List<PointLatLng>();
            points.Add(new PointLatLng(48.866383, 2.323575));
            points.Add(new PointLatLng(48.863868, 2.321554));
            points.Add(new PointLatLng(48.861017, 2.330030));
            GMapRoute route = new GMapRoute(points, "A walk in the park");
            route.Stroke = new Pen(Color.Red, 3);
            routes.Routes.Add(route);
            gMapControl1.Overlays.Add(routes);
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            gMapControl1.SetPositionByKeywords(SearchLocationTextBox1.Text);
            //gMapControl1.GetPositionByKeywords(SearchLocationTextBox1);
        }

        private void SearchLocTxtBox1_Click(object sender, EventArgs e)
        {
            if (SearchLocationTextBox1.Text == "Search for location...") { SearchLocationTextBox1.Text = ""; }
        }

        private void SearchLocTxtBox1_Leave(object sender, EventArgs e)
        {
            if (SearchLocationTextBox1.Text == "") { SearchLocationTextBox1.Text = "Search for location..."; }
        }

        private void SearchLocationTextBox1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void CurrentPosMarker_button1_Click(object sender, EventArgs e)
        {
            point_list1.Add(new PointLatLng(gMapControl1.Position.Lat, gMapControl1.Position.Lng));
            GMap.NET.WindowsForms.GMapMarker marker =
                new GMap.NET.WindowsForms.Markers.GMarkerGoogle(
                    new GMap.NET.PointLatLng(gMapControl1.Position.Lat, gMapControl1.Position.Lng),
                    GMap.NET.WindowsForms.Markers.GMarkerGoogleType.arrow);
            int top_id_number = 0;
            try
            {
                foreach (ListViewItem item in markersList1.Items)
                {
                    if(Convert.ToInt32(item.Text) > top_id_number)
                    {
                        top_id_number = Convert.ToInt32(item.Text);
                    }
                }
                //top_id_number += 1; // Convert.ToInt32(markersList1.Items[markersList1.Items.Count-1].Text);
            }
            catch
            {
                top_id_number = 1;
            }

            string[] tempString = { (top_id_number+1).ToString()/*(markersList1.Items.Count+1).ToString()*/, "Custom marker", marker.Position.Lat.ToString(), marker.Position.Lng.ToString() };
            markersList1.Items.Add(new ListViewItem(tempString)); //dodanie informacji o markerze do listy

            markers.Markers.Add(marker);
            gMapControl1.Overlays.Remove(markers);//odświeżanie mapy tak aby nie tworzyć nowych punktów nad istniejącymi punktami
            gMapControl1.Overlays.Add(markers);
            MarkerList1_CollectionChanged_Event();
        }

        private void MarkerRoutes_button1_Click(object sender, EventArgs e) // Rysuje drogi pomiędzy markerami w takiej kolejności, w której znajdują się na liście
        {
            //GMapOverlay routes = new GMapOverlay("routes");
            /*GMapRoute route = new GMapRoute(point_list1, "Route between points");
            route.Stroke = new Pen(Color.Blue, 3);
            route.Stroke = new Pen(Color.Red, 3);
            routes.Routes.Add(route);
            gMapControl1.Overlays.Remove(routes);//odświeżanie mapy tak aby nie tworzyć nowych punktów nad istniejącymi punktami
            gMapControl1.Overlays.Add(routes);*/ //pierwsza wersja - rysuje linie proste pomiędzy markerami
            try
            {
                ClearRoutesMethod();

                for (int i = 0; i < point_list1.Count; i++)
                {

                    if (i < point_list1.Count - 1)
                    {
                        PointLatLng point1 = new PointLatLng(point_list1[i].Lat, point_list1[i].Lng);
                        PointLatLng point2 = new PointLatLng(point_list1[i + 1].Lat, point_list1[i + 1].Lng);

                        MapRoute route = GMap.NET.MapProviders.OpenStreetMapProvider.Instance.GetRoute(point1, point2, false, false, 15);
                        GMapRoute r = new GMapRoute(route.Points, "Route between markers: " + markersList1.Items[i].Text + " -> " + markersList1.Items[i + 1].Text);

                        string[] tempString = { (i + 1).ToString(), markersList1.Items[i].Text, markersList1.Items[i+1].Text, point1.Lat.ToString(), point1.Lng.ToString(), point2.Lat.ToString(), point2.Lng.ToString() };
                        routesList1.Items.Add(new ListViewItem(tempString));
                        routes.Routes.Add(r);
                    }
                    else if (i == (point_list1.Count - 1))
                    {
                        PointLatLng point1 = new PointLatLng(point_list1[i].Lat, point_list1[i].Lng);
                        PointLatLng point2 = new PointLatLng(point_list1[0].Lat, point_list1[0].Lng);

                        MapRoute route = GMap.NET.MapProviders.OpenStreetMapProvider.Instance.GetRoute(point1, point2, false, false, 15);
                        GMapRoute r = new GMapRoute(route.Points, "Route between set markers");

                        string[] tempString = { (i + 1).ToString(), markersList1.Items[i].Text, markersList1.Items[0].Text, point1.Lat.ToString(), point1.Lng.ToString(), point2.Lat.ToString(), point2.Lng.ToString() };
                        routesList1.Items.Add(new ListViewItem(tempString));
                        routes.Routes.Add(r);
                    }
                }
                gMapControl1.Overlays.Remove(routes);
                gMapControl1.Overlays.Add(routes);
                gMapControl1.Zoom = gMapControl1.Zoom + 1;
                gMapControl1.Zoom = gMapControl1.Zoom - 1;
            }
            catch
            {
                MessageBox.Show("Failed to draw routes between markers!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void ClearAllRoutes_button_Click(object sender, EventArgs e)
        {
            ClearRoutesMethod();
        }

        private void ClearRoutesMethod() {
            routesList1.Items.Clear();//czyszczenie listy dróg
            gMapControl1.Overlays.Remove(routes);
            gMapControl1.Overlays.Remove(temp_route);
            routes.Routes.Clear();
            temp_route.Routes.Clear();
        }

        private void ClearMarkersMethod() {
            gMapControl1.Overlays.Remove(markers);
            markersList1.Items.Clear(); //czyszczenie listy markerów
            markers.Markers.Clear();
            point_list1.Clear();
            MarkerList1_CollectionChanged_Event();
        }

        private void ClearAllMarkRou_Button_Click(object sender, EventArgs e)
        {
            //gMapControl1.Overlays.Remove(routes);
            ////gMapControl1.Overlays.Remove(markers);
            //routesList1.Items.Clear(); //czyszczenie listy dróg
            ////markersList1.Items.Clear(); //czyszczenie listy markerów
            //routes.Routes.Clear();
            ////markers.Markers.Clear();
            ClearRoutesMethod();
            ////point_list1.Clear();
            ////markerList1_CollectionChanged_Event();
            ClearMarkersMethod();
        }

        private void MarkerList1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (markersList1.SelectedItems.Count == 1)
            {
                removeMarkerButton.Enabled = true;
                markerUp_button.Enabled = true;
                markerDown_button.Enabled = true;
                //wyśrodkowanie mapy na wskaźniku zaznaczonym na liście
                try
                {
                    //gMapControl1.Position = new PointLatLng( Convert.ToDouble(markersList1.SelectedItems[0].
                    //SubItems[0].Text), Convert.ToDouble(markersList1.SelectedItems[0].SubItems[1].Text)); //błąd w trakcie wykonywania
                    gMapControl1.Position = new PointLatLng(Convert.ToDouble(markersList1.SelectedItems[0].SubItems[2].Text), Convert.ToDouble(markersList1.SelectedItems[0].SubItems[3].Text));
                }
                catch (Exception 
                )
                {
                    MessageBox.Show("Failed to center map on selected marker.\n"/*+ex.Message*/, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                removeMarkerButton.Enabled = false;
                markerUp_button.Enabled = false;
                markerDown_button.Enabled = false;
            }
        }

        private void RemoveMarkerButton_Click(object sender, EventArgs e)
        {
            try
            {
                ListViewItem item_to_remove = markersList1.SelectedItems[0];
                int item_to_remove_id= markersList1.SelectedItems[0].Index;
                /*PointLatLng point_to_remove = new PointLatLng(Convert.ToDouble(item_to_remove.SubItems[2].Text), Convert.ToDouble(item_to_remove.SubItems[3].Text));
                GMapMarker marker_to_remove = new GMarkerGoogle(point_to_remove, GMarkerGoogleType.arrow);*/
                if (markersList1.Items.Contains(item_to_remove))
                {
                    markersList1.Items.Remove(item_to_remove);

                    //należy wykonać odświeżenie mapy
                    routesList1.Items.Clear();
                    gMapControl1.Overlays.Remove(routes);
                    routes.Clear();

                    gMapControl1.Overlays.Remove(markers);
                    markers.Markers.RemoveAt(item_to_remove_id);
                    /*for (int i = 0; i < markers.Markers.Count; i++) { //to też nie zawsze działa
                        GMapMarker mark = markers.Markers[i];
                        if (mark.Position.Lat==marker_to_remove.Position.Lat && mark.Position.Lng == marker_to_remove.Position.Lng)
                        {
                            MessageBox.Show("Removing marker...");
                            markers.Markers.Remove(mark);
                            break;
                        }
                    }*/
                    //markers.Markers.Remove(marker_to_remove); //to nie działa
                    gMapControl1.Overlays.Add(markers);

                    /*foreach (PointLatLng pt in point_list1) { //to też nie zawsze działa
                        if (pt.Lat == point_to_remove.Lat && pt.Lng == point_to_remove.Lng)
                        {
                            point_list1.Remove(pt);
                            break;
                        }
                        
                    }*/
                    point_list1.RemoveAt(item_to_remove_id);
                    //markers.Markers.//item_to_remove.SubItems[2].Text)
                }
                else
                {
                    throw new KeyNotFoundException();
                }
            }
            catch(Exception /*ex*/)
            {
                MessageBox.Show("Failed to remove selected marker.\n" /*+ ex.Message*/, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            MarkerList1_CollectionChanged_Event();
        }

        private void MarkerUp_button_Click(object sender, EventArgs e) // przesuwanie markera na górę listy (o jedną pozycję w dół z perskpektywy działania listy)
        {
            if (markersList1.SelectedItems.Count == 1)
            {
                ClearRoutesMethod();
                try
                {
                    //object temp_marker = new ListViewItem();
                    int selected_id = markersList1.SelectedItems[0].Index;
                    
                    if (selected_id>=1)
                    {
                        ListViewItem moved_item = new ListViewItem();
                        foreach(ListViewItem.ListViewSubItem subit in markersList1.SelectedItems[0].SubItems)
                        {
                            if (moved_item.SubItems[0].Text == "") { moved_item.SubItems[0].Text = subit.Text; }
                            else { moved_item.SubItems.Add(subit); }
                        }
                        PointLatLng temp_point = point_list1[selected_id];
                        point_list1[selected_id] = point_list1[selected_id - 1];
                        point_list1[selected_id - 1] = temp_point;

                        var temp_marker = markers.Markers[selected_id];
                        markers.Markers[selected_id] = markers.Markers[selected_id - 1];
                        markers.Markers[selected_id - 1] = temp_marker;

                        markersList1.Items.Insert(selected_id - 1, moved_item);
                        markersList1.Items.RemoveAt(markersList1.SelectedItems[0].Index);
                    }
                }
                catch (Exception /*ex*/)
                {
                    //ERROR!
                    MessageBox.Show("Failed to move marker up.\n"/*+ex.Message*/, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else
            {
                MessageBox.Show("Inappriopriate markers' count selected.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void MarkerDown_button_Click(object sender, EventArgs e) // przesuwanie markera w dół listy
        {
            if (markersList1.SelectedItems.Count == 1)
            {
                ClearRoutesMethod();
                try
                {
                    //object temp_marker = new ListViewItem();
                    int selected_id = markersList1.SelectedItems[0].Index;
                    int item_count = markersList1.Items.Count;

                    if (selected_id <item_count-1)
                    {
                        ListViewItem moved_item = new ListViewItem();
                        foreach (ListViewItem.ListViewSubItem subit in markersList1.SelectedItems[0].SubItems)
                        {
                            if (moved_item.SubItems[0].Text == "") { moved_item.SubItems[0].Text = subit.Text; }
                            else { moved_item.SubItems.Add(subit); }
                        }

                        //aktualizowanie listy point_list1 i kolejności markerów w markers
                        PointLatLng temp_point = point_list1[selected_id];
                        point_list1[selected_id] = point_list1[selected_id + 1];
                        point_list1[selected_id + 1] = temp_point;

                        var temp_marker = markers.Markers[selected_id];
                        markers.Markers[selected_id] = markers.Markers[selected_id + 1];
                        markers.Markers[selected_id + 1] = temp_marker;

                        markersList1.Items.Insert(selected_id + 2, moved_item);
                        markersList1.Items.RemoveAt(markersList1.SelectedItems[0].Index);
                    }
                }
                catch (Exception /*ex*/)
                {
                    //ERROR!
                    MessageBox.Show("Failed to move marker up.\n"/*+ex.Message*/, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else
            {
                MessageBox.Show("Inappriopriate markers' count selected.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void MarkerList1_CollectionChanged_Event() {
            if (markersList1.Items.Count == 2) {
                MarkerRoutes_button1.Enabled = true;
                travelingSalesmanRoute_button.Enabled = false;
            }
            else if (markersList1.Items.Count >= 3)
            {
                MarkerRoutes_button1.Enabled = true;
                travelingSalesmanRoute_button.Enabled = true;
            }
            else
            {
                MarkerRoutes_button1.Enabled = false;
                travelingSalesmanRoute_button.Enabled = false;
            }
        }

        private void TravelingSalesmanRoute_button_Click(object sender, EventArgs e)
        { //metoda odpowiedzialna za wyznaczanie ścieżki wykorzystując problem komiwojażera
            int points_count = point_list1.Count();
            double[,] route_distances = new double[points_count, points_count]; //przechowuje odległości pomiędzy markerami
            //long[,] routes_array=new long[factorial_count(points_count-1), points_count+1];
            List<int[]> routes_array = new List<int[]>(); //przechowuje możliwe kombinacje dróg
            List<int> possible_markers_list = new List<int>();
            double min_distance = 0;
            int best_route_id = 0;
            GMapOverlay all_routes = new GMapOverlay("All routes"); //używane w szukaniu optymalnej drogi przy pomocy problemu komiwojażera, przechowuje wszystkie drogi pomiędzy markerami (na podstawie tych danych można obliczyć odległość pomiędzy markerami)

            try
            {
                //obliczanie macierzy wag poszczególnych dróg na podstawie odległości pomiędzy markerami (nie jest to odległość bezpośrednia, tylko odległość przebyta po możliwych drogach na mapie)
                for (int i = 0; i < points_count; i++)
                {
                    //currentStatus_label.Text = "Calculating best route: " + (i + 1) + " of " + points_count;
                    for (int j = 0; j < points_count; j++)
                    {
                        if (i == j) //ten sam marker
                        {
                            /*PointLatLng point1 = new PointLatLng(point_list1[i].Lat, point_list1[i].Lng);
                            PointLatLng point2 = new PointLatLng(point_list1[j].Lat, point_list1[j].Lng);

                            MapRoute route = GMap.NET.MapProviders.OpenStreetMapProvider.Instance.GetRoute(point1, point2, false, false, 15);
                            GMapRoute r = new GMapRoute(route.Points, "No route on the same marker");
                            all_routes.Routes.Add(r);*/

                            route_distances[i, j] = 0;// r.Distance;
                        }
                        else if (i != j) //inny marker, sprawdzanie odległości
                        {
                            PointLatLng point1 = new PointLatLng(point_list1[i].Lat, point_list1[i].Lng);
                            PointLatLng point2 = new PointLatLng(point_list1[j].Lat, point_list1[j].Lng);

                            MapRoute route = GMap.NET.MapProviders.OpenStreetMapProvider.Instance.GetRoute(point1, point2, false, false, 15);
                            GMapRoute r = new GMapRoute(route.Points, "Possible best route from marker " + (i + 1) + " to marker " + (j + 1));
                            all_routes.Routes.Add(r);

                            route_distances[i, j] = r.Distance;
                        }
                    }
                    possible_markers_list.Add(i); //wypełnianie listy numerami markerów
                }
                possible_markers_list.Remove(0); //usuwamy pierwszy marker - traktujemy go jako punkt startowy/końcowy.

                //szukanie wszystkich kombinacji dróg 
                routes_array = TSP_find_routes(points_count, possible_markers_list, route_distances);

                //wyznaczanie najkrótszej drogi- UWAGA!!! Sprawdzanie najkrótszej drogi jest powtarzane dla najlepszych kandydatów z metody TSP_find_routes w celu optymalizacji zużywanej pamięci!
                for (int i = 0; i < routes_array.Count; i++)
                {
                    currentStatus_label.Text = "Calculating best route: " + (i + 1) + " of " + routes_array.Count;

                    int j = 0;
                    double temp_route_distance = 0;
                    while (j < routes_array[i].Length-1)
                    {
                        if (route_distances[routes_array[i][j], routes_array[i][j + 1]] == 0) { j++; continue; }
                        temp_route_distance += route_distances[routes_array[i][j], routes_array[i][j+1]];
                        j++;
                    }
                    if (i == 0)
                    {
                        min_distance = temp_route_distance;
                        best_route_id = i;
                    }
                    else if (i != 0 && temp_route_distance < min_distance)
                    {
                        min_distance = temp_route_distance;
                        best_route_id = i;
                    }      
                }

                //czyszczenie mapy z narysowanych dróg
                ClearRoutesMethod();

                //rysowanie najkrótszej drogi
                //GMapOverlay best_route = new GMapOverlay("Best routes");
                for (int i=0; i < routes_array[best_route_id].Length-1; i++)
                {
                    int point_one = routes_array[best_route_id][i];
                    int point_two = routes_array[best_route_id][i+1];

                    PointLatLng point1 = new PointLatLng(point_list1[point_one].Lat, point_list1[point_one].Lng);
                    PointLatLng point2 = new PointLatLng(point_list1[point_two].Lat, point_list1[point_two].Lng);

                    MapRoute route = GMap.NET.MapProviders.OpenStreetMapProvider.Instance.GetRoute(point1, point2, false, false, 15);
                    GMapRoute r = new GMapRoute(route.Points, "The best route from marker "+ point_one + " to marker " + point_two);
                    routes.Routes.Add(r);
                    string[] tempString = { (i+1).ToString(), (point_one+1).ToString(), (point_two+1).ToString(), point1.Lat.ToString(), point1.Lng.ToString(), point2.Lat.ToString(), point2.Lng.ToString() };
                    routesList1.Items.Add(new ListViewItem(tempString));
                }
                gMapControl1.Overlays.Add(routes);
                gMapControl1.Refresh();
                //routes.Routes[0].IsVisible = false;
            }
            catch(Exception /*ex*/)
            {
                MessageBox.Show("Could not calculate path.\n"/*+ex.Message*/, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                ClearRoutesMethod();
                
                gMapControl1.Refresh();
            }
            finally
            {
                //GC.Collect(); // to powinno pozostać w komentarzu
            }

        }

        private List<int[]> TSP_find_routes(int nodes_number, List<int> possible_numbers_list, double[,] route_distances) { // metoda inicjująca sprawdzanie wszystkich kombinacji dróg i wyznaczanie najkrótszej
            List<int[]> route_list = new List<int[]>();
            List<int> temp_list = new List<int> { 0 };


            var stopwatch = new Stopwatch(); //obliczanie czasu wykonywania metody
            stopwatch.Start();

            for (int j = 1; j < nodes_number; j++)
            {
                List<int[]> temp_routes = new List<int[]>();
                List<int> temp_list1 = new List<int>();//kopia listy temp_list
                List<int> possible_numbers_list1 = new List<int>(); // kopia listy possible_numbers_list

                temp_list1.AddRange(temp_list); //kopiowanie
                possible_numbers_list1.AddRange(possible_numbers_list); // kopiowanie

                temp_list1.Add(j);//dodanie pierwszego markera
                possible_numbers_list1.Remove(j);//usuwanie numeru dodanego markera


                temp_routes.AddRange(TSP_nodes(temp_list1, possible_numbers_list1, route_distances));

                //***********************
                //wyznaczanie najlepszych kandydatów na najkrótszą drogę. Może to przedłużać działanie algorytmu, 
                //ale zabieg jest konieczny aby uniknąć braku dostępnej pamięci
                double min_distance=0;
                int best_route_id=0;
                for (int i = 0; i < temp_routes.Count; i++)
                {
                    int k = 0;
                    double temp_route_distance = 0;
                    while (k < temp_routes[i].Length - 1)
                    {
                        if (route_distances[temp_routes[i][k], temp_routes[i][k + 1]] == 0) { k++; continue; }
                        temp_route_distance += route_distances[temp_routes[i][k], temp_routes[i][k + 1]];
                        k++;
                    }
                    if (i == 0) //pierwszy sprawdzany rekord
                    {
                        min_distance = temp_route_distance;
                        best_route_id = i;
                    }
                    else if (i != 0 && temp_route_distance < min_distance) //obecna droga nie jest pierwsza i jest krótsza niż poprzednie
                    {
                        min_distance = temp_route_distance;
                        best_route_id = i;
                    }
                }
                //*******************************

                //route_list.AddRange(temp_routes);
                route_list.Add(temp_routes[best_route_id]);

                
            }
            stopwatch.Stop(); //koniec liczenia czasu
            calculation_time.Text = "Calculation time: " + stopwatch.ElapsedMilliseconds.ToString(); //wyświetlenie czasu 

            return route_list;
        }

        private List<int[]> TSP_nodes(List<int> temp_list, List<int> possible_numbers_list, double[,] route_distances) { //metoda wywoływana rekurencyjnie 
            List<int[]> route_list = new List<int[]>();

            for (int i=0; i< possible_numbers_list.Count; i++)
            {

                List<int> temp_list1 = new List<int>();//kopia listy temp_list
                List<int> possible_numbers_list1 = new List<int>(); // kopia listy possible_numbers_list

                temp_list1.AddRange(temp_list); //kopiowanie
                possible_numbers_list1.AddRange(possible_numbers_list); // kopiowanie

                temp_list1.Add(possible_numbers_list[i]);//dodanie pierwszego markera
                possible_numbers_list1.Remove(possible_numbers_list[i]);//usuwanie numeru dodanego markera

                if (possible_numbers_list1.Count > 0) {
                    route_list.AddRange(TSP_nodes(temp_list1, possible_numbers_list1, route_distances));
                }
                else
                {
                    temp_list1.Add(0);
                    route_list.Add(temp_list1.ToArray());
                }

            }

            if (route_list.Count > 1)
            {
                //***********************
                //wyznaczanie najlepszych kandydatów na najkrótszą drogę. Może to przedłużać działanie algorytmu, 
                //ale zabieg jest konieczny aby uniknąć braku dostępnej pamięci
                //double temp
                double min_distance = 0;
                int best_route_id = 0;
                for (int i = 0; i < route_list.Count; i++)
                {
                    int k = 0;
                    double temp_route_distance = 0;
                    while (k < route_list[i].Length - 1)
                    {
                        if (route_distances[route_list[i][k], route_list[i][k + 1]] == 0) { k++; continue; }
                        temp_route_distance += route_distances[route_list[i][k], route_list[i][k + 1]];
                        k++;
                    }
                    if (i == 0) //pierwszy sprawdzany rekord
                    {
                        min_distance = temp_route_distance;
                        best_route_id = i;
                    }
                    else if (i != 0 && temp_route_distance < min_distance) //obecna droga nie jest pierwsza i jest krótsza niż poprzednie
                    {
                        min_distance = temp_route_distance;
                        best_route_id = i;
                    }
                }
                List<int[]> one_route_combination = new List<int[]>();
                one_route_combination.Add(route_list[best_route_id]);
                return one_route_combination;

                //*******************************
            }
            return route_list;
        }

        private void TravelingSalesmanAlternateRoute_button_Click(object sender, EventArgs e)
        {
            
        }

        public long Factorial_count(int number) {
            long factorial_result = 1;
            int i = 1;
            while (i<=number)
            {
                factorial_result *= i;
            }
            return factorial_result;
        }

        private void RoutesList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (routesList1.SelectedItems.Count == 1)
            {
                //wyśrodkowanie mapy po środku drogi wybranej na liście
                try
                {
                    this.temp_route.Routes.Clear();
                    gMapControl1.Overlays.Remove(this.temp_route); //usuwanie z mapy zaznaczonej drogi
                    gMapControl1.Overlays.Remove(routes);

                    //obliczanie odległości i wyznaczanie środka pomiędzy punktem początkowym i końcowym
                    double center_on_X = 0;
                    double center_on_y = 0;
                    if (routes.Routes[routesList1.SelectedItems[0].Index].From.Value.Lat > routes.Routes[routesList1.SelectedItems[0].Index].To.Value.Lat)
                        center_on_X = routes.Routes[routesList1.SelectedItems[0].Index].From.Value.Lat - (Math.Sqrt(Math.Pow(routes.Routes[routesList1.SelectedItems[0].Index].To.Value.Lat - routes.Routes[routesList1.SelectedItems[0].Index].From.Value.Lat, 2)) / 2);
                    else
                        center_on_X = routes.Routes[routesList1.SelectedItems[0].Index].From.Value.Lat + (Math.Sqrt(Math.Pow(routes.Routes[routesList1.SelectedItems[0].Index].To.Value.Lat - routes.Routes[routesList1.SelectedItems[0].Index].From.Value.Lat, 2)) / 2);

                    if(routes.Routes[routesList1.SelectedItems[0].Index].From.Value.Lng > routes.Routes[routesList1.SelectedItems[0].Index].To.Value.Lng)
                        center_on_y = routes.Routes[routesList1.SelectedItems[0].Index].From.Value.Lng - (Math.Sqrt(Math.Pow(routes.Routes[routesList1.SelectedItems[0].Index].To.Value.Lng - routes.Routes[routesList1.SelectedItems[0].Index].From.Value.Lng, 2)) / 2); 
                    else
                        center_on_y = routes.Routes[routesList1.SelectedItems[0].Index].From.Value.Lng + (Math.Sqrt(Math.Pow(routes.Routes[routesList1.SelectedItems[0].Index].To.Value.Lng - routes.Routes[routesList1.SelectedItems[0].Index].From.Value.Lng, 2)) / 2); 

                    gMapControl1.Position = new PointLatLng(center_on_X, center_on_y); //Convert.ToDouble(markersList1.SelectedItems[0].SubItems[2].Text), Convert.ToDouble(markersList1.SelectedItems[0].SubItems[3].Text));

                    //tworzenie tymczasowej drogi
                    GMapRoute temp_route_drawing = new GMapRoute(routes.Routes[routesList1.SelectedItems[0].Index].Points, routes.Routes[routesList1.SelectedItems[0].Index].Name.ToString());
                    //GMapOverlay temp_route_overlay = new GMapOverlay();
                    this.temp_route.Routes.Add(temp_route_drawing);
                    gMapControl1.Overlays.Add(this.temp_route);
                }
                catch (Exception /*ex*/)
                {
                    MessageBox.Show("Failed to center map on selected route.\n" /*+ ex.Message*/, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    gMapControl1.Overlays.Remove(this.temp_route);
                    gMapControl1.Overlays.Remove(routes);
                    gMapControl1.Overlays.Add(routes);
                }
                finally
                {
                    gMapControl1.Zoom = gMapControl1.Zoom + 1;
                    gMapControl1.Zoom = gMapControl1.Zoom - 1;
                    //gMapControl1.Refresh(); //porzucono tą metodę, ponieważ nie umożliwia osiągnięcie zamierzonego rezultatu - drogi pojawiają się na mapie w miejscu, w którym nie powinny
                }
            }
            else
            {
                gMapControl1.Overlays.Remove(this.temp_route);
                gMapControl1.Overlays.Remove(routes);
                gMapControl1.Overlays.Add(routes);
                gMapControl1.Zoom = gMapControl1.Zoom + 1;
                gMapControl1.Zoom = gMapControl1.Zoom - 1;
                //gMapControl1.Refresh();
            }
        }

        public void InsertConsignmentFromCourseMarkers(string placeKeywords, bool isCompanyPoint, string consignment_number)
        {
            GMap.NET.WindowsForms.Markers.GMarkerGoogleType markertype = new GMarkerGoogleType();
            if( isCompanyPoint == true) //wybór wyglądu znacznika w zależności od typu (tzn. punkt firmy będzie oznaczony niebieską pinezką, a miejsce dostawy przesyłki na zielono)
            {
                markertype = GMarkerGoogleType.blue_pushpin;
            }
            else
            {
                markertype = GMarkerGoogleType.green_big_go;
            }

            PointLatLng point_to_add = new PointLatLng();
            gMapControl1.SetPositionByKeywords(placeKeywords); //pobieranie współrzędnych miejsca, w którym marker zostanie umieszczony
            point_to_add.Lat = gMapControl1.Position.Lat;
            point_to_add.Lng = gMapControl1.Position.Lng;
            //point_to_add= gMap

            point_list1.Add(point_to_add);//new PointLatLng(gMapControl1.Position.Lat, gMapControl1.Position.Lng));
            GMap.NET.WindowsForms.GMapMarker marker =
                new GMap.NET.WindowsForms.Markers.GMarkerGoogle(
                    new GMap.NET.PointLatLng(point_to_add.Lat, point_to_add.Lng), //(gMapControl1.Position.Lat, gMapControl1.Position.Lng),
                    markertype);

            int next_id = 1;
            if(markersList1.Items.Count > 0)
            {
                try
                {
                    next_id = Convert.ToInt32(markersList1.Items[markersList1.Items.Count - 1].Text) + 1;
                }
                catch (Exception)
                {
                    next_id = 1;
                }
            }
            
            string[] tempString = { next_id.ToString(), consignment_number, marker.Position.Lat.ToString(), marker.Position.Lng.ToString() };
            markersList1.Items.Add(new ListViewItem(tempString)); //dodanie informacji o markerze do listy

            markers.Markers.Add(marker);
            gMapControl1.Overlays.Remove(markers);//odświeżanie mapy tak aby nie tworzyć nowych punktów nad istniejącymi punktami
            gMapControl1.Overlays.Add(markers);
            MarkerList1_CollectionChanged_Event();
        }

        public void InsertCourseBetweenPointsMarkers(string startPlaceKeywords, string endPlaceKeywords)
        {
            GMap.NET.WindowsForms.Markers.GMarkerGoogleType markertype = new GMarkerGoogleType();
            markertype = GMarkerGoogleType.blue_pushpin;

            PointLatLng startPoint_to_add = new PointLatLng();
            PointLatLng endPoint_to_add = new PointLatLng();

            //start marker
            gMapControl1.SetPositionByKeywords(startPlaceKeywords);
            startPoint_to_add.Lat = gMapControl1.Position.Lat; startPoint_to_add.Lng = gMapControl1.Position.Lng;

            gMapControl1.SetPositionByKeywords(endPlaceKeywords);
            endPoint_to_add.Lat = gMapControl1.Position.Lat; endPoint_to_add.Lng = gMapControl1.Position.Lng;

            point_list1.Add(startPoint_to_add);
            point_list1.Add(endPoint_to_add);

            GMap.NET.WindowsForms.GMapMarker marker1 =
                new GMap.NET.WindowsForms.Markers.GMarkerGoogle(
                    new GMap.NET.PointLatLng(startPoint_to_add.Lat, startPoint_to_add.Lng), //(gMapControl1.Position.Lat, gMapControl1.Position.Lng),
                    markertype);
            GMap.NET.WindowsForms.GMapMarker marker2 =
                new GMap.NET.WindowsForms.Markers.GMarkerGoogle(
                    new GMap.NET.PointLatLng(endPoint_to_add.Lat, endPoint_to_add.Lng), //(gMapControl1.Position.Lat, gMapControl1.Position.Lng),
                    markertype);

            int next_id = 1;
            if (markersList1.Items.Count > 0)
            {
                try
                {
                    next_id = Convert.ToInt32(markersList1.Items[markersList1.Items.Count - 1].Text) + 1;
                }
                catch (Exception)
                {
                    next_id = 1;
                }
            }

            string[] tempString1 = { next_id.ToString(), "Start point", marker1.Position.Lat.ToString(), marker1.Position.Lng.ToString() };
            next_id += 1;
            string[] tempString2 = { next_id.ToString(), "End point", marker2.Position.Lat.ToString(), marker2.Position.Lng.ToString() };
            markersList1.Items.Add(new ListViewItem(tempString1)); //dodanie informacji o markerze do listy
            markersList1.Items.Add(new ListViewItem(tempString2)); //dodanie informacji o markerze do listy

            markers.Markers.Add(marker1);
            markers.Markers.Add(marker2);
            gMapControl1.Overlays.Remove(markers);//odświeżanie mapy tak aby nie tworzyć nowych punktów nad istniejącymi punktami
            gMapControl1.Overlays.Add(markers);
            MarkerList1_CollectionChanged_Event();

            /*gMapControl1.GetPositionByKeywords(startPlaceKeywords, out startPoint_to_add);
            point_list1.Add(startPoint_to_add);

            gMapControl1.GetPositionByKeywords(endPlaceKeywords, out endPoint_to_add);
            point_list1.Add(endPoint_to_add);*/
        }

        private void ZoomIn_button_Click(object sender, EventArgs e)
        {
            try
            {
                gMapControl1.Zoom += 1;
            }
            catch
            {

            }
        }

        private void ZoomOut_button_Click(object sender, EventArgs e)
        {
            try
            {
                gMapControl1.Zoom -= 1;
            }
            catch
            {

            }
        }

        private void CalculateTime_Start()
        {

        }

        private void CalculateTime_End()
        {

        }

        private void change_provider_button_Click(object sender, EventArgs e)
        {
            if (providers_listBox.SelectedItems.Count == 1)
            {
                if (providers_listBox.SelectedItems[0].Equals("OpenStreetMapProvider"))
                {
                    gMapControl1.MapProvider = GMap.NET.MapProviders.OpenStreetMapProvider.Instance;
                }
                else if (providers_listBox.SelectedItems[0].Equals("OpenStreet4UMapProvider"))
                {
                    gMapControl1.MapProvider = GMap.NET.MapProviders.OpenStreet4UMapProvider.Instance;
                }
                else if (providers_listBox.SelectedItems[0].Equals("OpenCycleMapProvider"))
                {
                    gMapControl1.MapProvider = GMap.NET.MapProviders.OpenCycleMapProvider.Instance;
                }
            }
        }
    }
}
