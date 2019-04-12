using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ParcelDeliveryCompany_ClassLibrary1;

namespace ParcelDeliveryCompanyApplication
{
    public partial class DictionaryManagementControler : UserControl
    {
        private UserClass MainW;
        //private String server_name;
        //private String db_name;
        private DictionariesNames current_selection;

        public UserClass MainWindowReference { get => MainW; set => MainW = value; }

        private enum ListControlEnable
        {
            disabled = 0,
            enabled = 1
        };

        enum DictionariesNames
        {
            none = 0,
            vehicle_type = 1,
            area = 2,
            location_type = 3,
            weight_category = 4,
            size_category = 5,
            properties = 6,
            pickup_state = 7,
            pickup_method = 8,
            consignment_type = 9,
            pickup_request_state = 10,
            complaint_report_state = 11
        };

        public DictionaryManagementControler()
        {
            InitializeComponent();
            current_selection = DictionariesNames.none;
        }

        public DictionaryManagementControler(UserClass mainForm)
        {
            InitializeComponent();
            //MainW = mainForm;
            MainWindowReference=mainForm;
            current_selection = DictionariesNames.none;
        }

        private void VehicleType_button_Click(object sender, EventArgs e)
        {
            DictionarySelectButtonOperations(DictionariesNames.vehicle_type);
        }

        private void Area__button_Click(object sender, EventArgs e)
        {
            DictionarySelectButtonOperations(DictionariesNames.area);
            /*ClearDictionaryListViewItems();
            DataTable query_result = new DataTable();
            try
            {
                //zapytanie o rekordy z tabeli Typ_pojazdu
                using (SqlConnection connection = new SqlConnection(MainW.ConnectionString))
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Strefa", connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    adapter.Fill(query_result); //pobranie danych z bazy danych
                    foreach (DataRow dr in query_result.Rows) //wypełnianie okna danymi otrzymanymi po zapytaniu
                    {
                        ListViewItem item = new ListViewItem(dr[0].ToString()); //pierwsza kolumna - ID
                        item.SubItems.Add(dr[1].ToString()); //druga kolumna - nazwa
                        dictionary_listView.Items.Add(item);
                    }
                }
                SetCurrentDictionary(DictionariesNames.vehicle_type);
            }
            catch (Exception ex)
            {
                ErrorMessageClass.DisplayErrorMessage(201, ex);
                ToggleListAndButtons(ListControlEnable.disabled);
            }*/
        }

        private void LocationType__button_Click(object sender, EventArgs e)
        {
            DictionarySelectButtonOperations(DictionariesNames.location_type);
        }

        private void WeightCategory_button_Click(object sender, EventArgs e)
        {
            DictionarySelectButtonOperations(DictionariesNames.weight_category);
        }

        private void SizeCategory_button_Click(object sender, EventArgs e)
        {
            DictionarySelectButtonOperations(DictionariesNames.size_category);
        }

        private void Properties_button_Click(object sender, EventArgs e)
        {
            DictionarySelectButtonOperations(DictionariesNames.properties);
        }

        private void PickupState_button_Click(object sender, EventArgs e)
        {
            DictionarySelectButtonOperations(DictionariesNames.pickup_state);
        }

        private void PickupMethod_button_Click(object sender, EventArgs e)
        {
            DictionarySelectButtonOperations(DictionariesNames.pickup_method);
        }

        private void ConsignmentType_button_Click(object sender, EventArgs e) //typ przesyłki
        {
            DictionarySelectButtonOperations(DictionariesNames.consignment_type);
        }

        private void PickupRequestState_button_Click(object sender, EventArgs e)
        {
            DictionarySelectButtonOperations(DictionariesNames.pickup_request_state);
        }

        private void ComplaintReportState_button_Click(object sender, EventArgs e)
        {
            DictionarySelectButtonOperations(DictionariesNames.complaint_report_state);
        }

        /*internal void MainWReference(MainForm mainW)
        {
            this.MainW1 = mainW;
        }*/

        private void ToggleListAndButtons(ListControlEnable choice)
        {
            if (choice == ListControlEnable.enabled)
            {
                dictionary_listView.Enabled = true;
                addNewRecord_button.Enabled = true;
                //findRecord_button.Enabled = true;
                search_textBox.Enabled = true;
                dictionaryColumns_listbox.Enabled = true;
                refresh_button.Enabled = true;
            }
            else if (choice == ListControlEnable.disabled)
            {
                dictionary_listView.Enabled = false;
                addNewRecord_button.Enabled = false;
                //findRecord_button.Enabled = false;
                search_textBox.Enabled = false;
                dictionaryColumns_listbox.Enabled = false;
                refresh_button.Enabled = false;
            }
        }

        private void SetCurrentDictionary(DictionariesNames chosen_dict)
        {
            if (chosen_dict == DictionariesNames.vehicle_type)
            {
                this.current_selection = DictionariesNames.vehicle_type;
                currentSelection_label.Text = "Vehicle type";
                //ToggleListAndButtons(ListControlEnable.enabled);
                dictionary_listView.Columns[1].Text = "Vehicle type";
            }
            else if (chosen_dict == DictionariesNames.area)
            {
                this.current_selection = DictionariesNames.area;
                currentSelection_label.Text = "Area";
                //ToggleListAndButtons(ListControlEnable.enabled);
                dictionary_listView.Columns[1].Text = "Area";
            }
            else if (chosen_dict == DictionariesNames.location_type)
            {
                this.current_selection = DictionariesNames.location_type;
                currentSelection_label.Text = "Company point type";
                //ToggleListAndButtons(ListControlEnable.enabled);
                dictionary_listView.Columns[1].Text = "Company point type";
            }
            else if (chosen_dict == DictionariesNames.weight_category)
            {
                this.current_selection = DictionariesNames.weight_category;
                currentSelection_label.Text = "Weight category";
                //ToggleListAndButtons(ListControlEnable.enabled);
                dictionary_listView.Columns[1].Text = "Weight category";
            }
            else if (chosen_dict == DictionariesNames.size_category)
            {
                this.current_selection = DictionariesNames.size_category;
                currentSelection_label.Text = "Size category";
                //ToggleListAndButtons(ListControlEnable.enabled);
                dictionary_listView.Columns[1].Text = "Size category";
            }
            else if (chosen_dict == DictionariesNames.properties)
            {
                this.current_selection = DictionariesNames.properties;
                currentSelection_label.Text = "Properties";
                //ToggleListAndButtons(ListControlEnable.enabled);
                dictionary_listView.Columns[1].Text = "Properties";
            }
            else if (chosen_dict == DictionariesNames.pickup_state)
            {
                this.current_selection = DictionariesNames.pickup_state;
                currentSelection_label.Text = "Pickup state";
                //ToggleListAndButtons(ListControlEnable.enabled);
                dictionary_listView.Columns[1].Text = "Pickup state";
            }
            else if (chosen_dict == DictionariesNames.pickup_method)
            {
                this.current_selection = DictionariesNames.pickup_method;
                currentSelection_label.Text = "Pickup method";
                //ToggleListAndButtons(ListControlEnable.enabled);
                dictionary_listView.Columns[1].Text = "Pickup method";
            }
            else if (chosen_dict == DictionariesNames.consignment_type)
            {
                this.current_selection = DictionariesNames.consignment_type;
                currentSelection_label.Text = "Consignment type";
                //ToggleListAndButtons(ListControlEnable.enabled);
                dictionary_listView.Columns[1].Text = "Consignment type";
            }
            else if (chosen_dict == DictionariesNames.pickup_request_state)
            {
                this.current_selection = DictionariesNames.pickup_request_state;
                currentSelection_label.Text = "Pickup request state";
                //ToggleListAndButtons(ListControlEnable.enabled);
                dictionary_listView.Columns[1].Text = "Pickup request state";
            }
            else if (chosen_dict == DictionariesNames.complaint_report_state)
            {
                this.current_selection = DictionariesNames.complaint_report_state;
                currentSelection_label.Text = "Complaint request";
                //ToggleListAndButtons(ListControlEnable.enabled);
                dictionary_listView.Columns[1].Text = "Complaint request";
            }
            else
            {
                this.current_selection = DictionariesNames.none;
                currentSelection_label.Text = "Name";
                //ToggleListAndButtons(ListControlEnable.disabled);
                dictionary_listView.Columns[1].Text = "Name";
            }
        }

        private void DictionarySelectButtonOperations(DictionariesNames select_dictionary)
        {
            ClearDictionaryListViewItems();
            DataTable query_result = new DataTable();
            String query_string = "";
            SetCurrentDictionary(select_dictionary);

            try
            {
                //zapytanie o rekordy z tabeli Typ_pojazdu
                using (SqlConnection connection = new SqlConnection(MainWindowReference.GetConnectionString())) //MainW.Connection01)
                {
                    if (current_selection == DictionariesNames.vehicle_type) query_string = "SELECT* FROM Typ_pojazdu";
                    else if (current_selection == DictionariesNames.area) query_string = "SELECT* FROM Strefa";
                    else if (current_selection == DictionariesNames.location_type) query_string = "SELECT * FROM Typ_budynku"; // Typ_punktu";
                    else if (current_selection == DictionariesNames.weight_category) query_string = "SELECT * FROM Kategoria_wagowa";
                    else if (current_selection == DictionariesNames.size_category) query_string = "SELECT* FROM Gabaryty";
                    else if (current_selection == DictionariesNames.properties) query_string = "SELECT* FROM Cecha";
                    else if (current_selection == DictionariesNames.pickup_state) query_string = "SELECT* FROM Stan_odbioru";
                    else if (current_selection == DictionariesNames.pickup_method) query_string = "SELECT* FROM Forma_odbioru";
                    else if (current_selection == DictionariesNames.consignment_type) query_string = "SELECT* FROM Typ_przesylki";
                    else if (current_selection == DictionariesNames.pickup_request_state) query_string = "SELECT* FROM Stan_zgloszenia_odbioru";
                    else if (current_selection == DictionariesNames.complaint_report_state) query_string = "SELECT* FROM Stan_reklamacji";
                    using (SqlCommand cmd = new SqlCommand(query_string, connection))
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(query_result); //pobranie danych z bazy danych
                        foreach (DataRow dr in query_result.Rows) //wypełnianie okna danymi otrzymanymi po zapytaniu
                        {
                            ListViewItem item = new ListViewItem(dr[0].ToString()); //pierwsza kolumna - ID
                            item.SubItems.Add(dr[1].ToString()); //druga kolumna - nazwa
                            dictionary_listView.Items.Add(item);
                        }
                    }
                }
                ToggleListAndButtons(ListControlEnable.enabled);
            }
            catch (Exception ex)
            {
                MessageClass.DisplayMessage(201, ex);
                SetCurrentDictionary(DictionariesNames.none);
                ToggleListAndButtons(ListControlEnable.disabled);
            }
        }

        private void AddNewRecord_button_Click(object sender, EventArgs e)
        {
            if (current_selection != DictionariesNames.none)
            {
                DictionaryAddRecordForm newrecordform = new DictionaryAddRecordForm(this.MainWindowReference, Convert.ToInt32(this.current_selection));
                newrecordform.ShowDialog();
                DictionarySelectButtonOperations(current_selection);//odświeżenie listy, aby zobaczyć nowy rekord (jeżeli ten został dodany)
            }
            else
            {
                MessageClass.DisplayMessage(203);
            }

        }

        /*private void FindRecord_button_Click(object sender, EventArgs e)
        {

        }*/

        private void Search_button_Click(object sender, EventArgs e)
        {
            try
            {
                DictionarySelectButtonOperations(current_selection);

                ListViewItem found_item = null;
                List<ListViewItem> items_arr = new List<ListViewItem>();
                int search_index = 0;
                do
                {
                    found_item = null;
                    if (search_index < this.dictionary_listView.Items.Count)
                    {
                        found_item = dictionary_listView.FindItemWithText(search_textBox.Text, true, search_index);
                    }

                    if (found_item != null)
                    {
                        items_arr.Add(found_item);
                        search_index = found_item.Index + 1;
                    }
                }
                while (found_item != null);

                dictionary_listView.Items.Clear();
                foreach (ListViewItem item in items_arr)
                {
                    if (item.SubItems[dictionaryColumns_listbox.SelectedIndex].Text.Contains(search_textBox.Text))
                    {
                        dictionary_listView.Items.Add(item);
                    }
                }
            }
            catch (Exception /*ex*/)
            {
                //MessageBox.Show(ex.Message + "Error occured during an attemmpt to search for\nspecified items in customers' list.");
                MessageClass.DisplayMessage(204);
            }

        }

        private void ClearFilter_button_Click(object sender, EventArgs e)
        {
            search_textBox.Clear();
            dictionaryColumns_listbox.SelectedItems.Clear();
            DictionarySelectButtonOperations(current_selection);
        }

        private void DictionaryColumns_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((search_textBox.Text.Length != 0 && search_textBox.Text.Trim().Length != 0) && dictionaryColumns_listbox.SelectedItems.Count == 1)
            {
                search_button.Enabled = true;
                clearFilter_button.Enabled = true;
            }
            else
            {
                search_button.Enabled = false;
                clearFilter_button.Enabled = false;
            }
        }

        private void Search_textBox_TextChanged(object sender, EventArgs e)
        {
            if ((search_textBox.Text.Length != 0 && search_textBox.Text.Trim().Length != 0) && dictionaryColumns_listbox.SelectedItems.Count == 1)
            {
                search_button.Enabled = true;
                clearFilter_button.Enabled = true;
            }
            else
            {
                search_button.Enabled = false;
                clearFilter_button.Enabled = false;
            }
        }

        private void Refresh_button_Click(object sender, EventArgs e)
        {
            DictionarySelectButtonOperations(current_selection);
        }

        private void ClearDictionaryListViewItems()
        {
            dictionary_listView.Items.Clear();
        }

        private void dictionary_listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(dictionary_listView.SelectedItems.Count == 1)
            {
                editRecord_button.Enabled = true;
            }
            else
            {
                editRecord_button.Enabled = false;
            }
        }

        private void editRecord_button_Click(object sender, EventArgs e)
        {
            try
            {


                if (current_selection != DictionariesNames.none)
                {
                    DictionaryAddRecordForm editRecordform = new DictionaryAddRecordForm(this.MainWindowReference, Convert.ToInt32(this.current_selection), Convert.ToInt32(dictionary_listView.SelectedItems[0].Text));
                    editRecordform.ShowDialog();
                    DictionarySelectButtonOperations(current_selection);//odświeżenie listy, aby zobaczyć nowy rekord (jeżeli ten został dodany)
                }
                else
                {
                    MessageClass.DisplayMessage(203);
                }
            }
            catch (Exception)
            {
                //MessageBox.Show("Failed to initialize dictionary item edit form. Error occured!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageClass.DisplayMessage(205);
            }
        }
    }
}
