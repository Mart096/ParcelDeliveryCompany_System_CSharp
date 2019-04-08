using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.MapProviders;

namespace TestGmapProject01
{
    public partial class Form1 : Form
    {
        private List<PointLatLng> point_list1 = new List<PointLatLng>();
        private GMap.NET.WindowsForms.GMapOverlay markers = new GMap.NET.WindowsForms.GMapOverlay("markers");
        private GMapOverlay routes = new GMapOverlay("routes");
        

        public Form1()
        {
            InitializeComponent();
            //PointLatLng point1=new PointLatLng start
            //MapRoute mproute = new GMapRoute( ,"route1");
            
        }

        private void OnLoad(object sender, EventArgs e)
        {
            gMapControl1.MapProvider = GMap.NET.MapProviders.OpenStreetMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            gMapControl1.SetPositionByKeywords("Żołnierska 49, Szczecin, Poland");
            gMapControl1.IgnoreMarkerOnMouseWheel = true;
            //gMapControl1.SetPositionByKeywords("Warsaw, Poland");
        }

        private void ExampleMarkers(object sender, EventArgs e) 
        {
            //GMap.NET.WindowsForms.GMapOverlay markers = new GMap.NET.WindowsForms.GMapOverlay("markers");
            GMap.NET.WindowsForms.GMapMarker marker =
                new GMap.NET.WindowsForms.Markers.GMarkerGoogle(
                    new GMap.NET.PointLatLng(48.8617774, 2.349272),
                    GMap.NET.WindowsForms.Markers.GMarkerGoogleType.arrow);
            markers.Markers.Add(marker);
            gMapControl1.Overlays.Add(markers);
        }

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

            string[] tempString = { "ID", marker.Position.Lat.ToString(), marker.Position.Lng.ToString() };
            markersList1.Items.Add(new ListViewItem(tempString)); //dodanie informacji o markerze do listy

            markers.Markers.Add(marker);
            gMapControl1.Overlays.Remove(markers);//odświeżanie mapy tak aby nie tworzyć nowych punktów nad istniejącymi punktami
            gMapControl1.Overlays.Add(markers);
        }

        private void MarkerRoutes_button1_Click(object sender, EventArgs e)
        {
            //GMapOverlay routes = new GMapOverlay("routes");
            /*GMapRoute route = new GMapRoute(point_list1, "Route between points");
            route.Stroke = new Pen(Color.Blue, 3);
            route.Stroke = new Pen(Color.Red, 3);
            routes.Routes.Add(route);
            gMapControl1.Overlays.Remove(routes);//odświeżanie mapy tak aby nie tworzyć nowych punktów nad istniejącymi punktami
            gMapControl1.Overlays.Add(routes);*/ //pierwsza wersja - rysuje linie proste pomiędzy markerami

            for (int i = 0; i < point_list1.Count; i++)
            {
                
                if (i < point_list1.Count - 1)
                {
                    PointLatLng point1 = new PointLatLng(point_list1[i].Lat, point_list1[i].Lng);
                    PointLatLng point2 = new PointLatLng(point_list1[i + 1].Lat, point_list1[i + 1].Lng);

                    MapRoute route= GMap.NET.MapProviders.OpenStreetMapProvider.Instance.GetRoute(point1, point2, false, false, 15);
                    GMapRoute r = new GMapRoute(route.Points, "Route between set markers");

                    string[] tempString = {"id", "mark1 id", "mark2 id", point1.Lat.ToString(), point1.Lng.ToString(), point2.Lat.ToString(), point2.Lng.ToString() };
                    routesList1.Items.Add(new ListViewItem(tempString));
                    routes.Routes.Add(r);
                }
                else if (i== (point_list1.Count-1))
                {
                    PointLatLng point1 = new PointLatLng(point_list1[i].Lat, point_list1[i].Lng);
                    PointLatLng point2 = new PointLatLng(point_list1[0].Lat, point_list1[0].Lng);

                    MapRoute route = GMap.NET.MapProviders.OpenStreetMapProvider.Instance.GetRoute(point1, point2, false, false, 15);
                    GMapRoute r = new GMapRoute(route.Points, "Route between set markers");

                    string[] tempString = { "id", "mark1 id", "mark2 id", point1.Lat.ToString(), point1.Lng.ToString(), point2.Lat.ToString(), point2.Lng.ToString() };
                    routesList1.Items.Add(new ListViewItem(tempString));
                    routes.Routes.Add(r);
                }
            }
            gMapControl1.Overlays.Remove(routes);
            gMapControl1.Overlays.Add(routes);
        }

        private void clearAllRoutes_button_Click(object sender, EventArgs e)
        {
            routesList1.Items.Clear();
            gMapControl1.Overlays.Remove(routes);
            routes.Clear();
        }

        private void clearAllMarkRou_Button_Click(object sender, EventArgs e)
        {
            gMapControl1.Overlays.Remove(routes);
            gMapControl1.Overlays.Remove(markers);
            routesList1.Items.Clear(); //czyszczenie listy dróg
            markersList1.Items.Clear(); //czyszczenie listy markerów
            routes.Routes.Clear();
            markers.Markers.Clear();
            point_list1.Clear();
        }

        private void MarkerList1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (markersList1.SelectedItems.Count == 1)
            {
                //gMapControl1.Position = new PointLatLng( Convert.ToDouble(markersList1.SelectedItems[0].
                    //SubItems[0].Text), Convert.ToDouble(markersList1.SelectedItems[0].SubItems[1].Text)); //błąd w trakcie wykonywania
            }
            foreach (var item1 in markersList1.Items)
            {

            }
        }

        /*private void Examp_route2() 
        {
            PointLatLng start = new PointLatLng(-25.974134, 32.593042);
            PointLatLng end = new PointLatLng(-25.959048, 32.592827);
            MapRoute route = GMap.NET.MapProviders.GoogleMapProvider.Instance.GetRoute(start, end, false, false, 15);
            MapRoute rt1 = GMap.NET.MapProviders.OpenStreetMapProvider.Instance.GetRoute(start, end, false, false, 15);
        }*/



    }
}
