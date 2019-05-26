using ParcelDeliveryCompany_ClassLibrary1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParcelDeliveryCompany_ClassLibrary1
{
    public partial class LocationAddEditForm : Form
    {
        private UserClass mainW;
        private FormMode current_mode;
        private int edited_id;

        public UserClass MainWindowReference { get => mainW; set => mainW = value; }

        enum FormMode
        {
            add = 0,
            edit = 1
        };


        public LocationAddEditForm()
        {
            InitializeComponent();
        }

        public LocationAddEditForm(UserClass mW, int mode, int id)
        {
            InitializeComponent();
            this.MainWindowReference = mW;
            ToggleMode((FormMode)mode);
            LoadLocationTypes();
            LoadCityList();

            if (this.current_mode == FormMode.edit)
            {
                new_location_type_CheckBox.Enabled = false;
                this.edited_id = id;
                LoadLocation_to_Edit(edited_id);
            }
        }

        private void LoadLocationTypes()
        {
            //locationTypes_listbox.Items.Clear();
            location_type_listView.Items.Clear();

            try
            {
                DataTable dt = new DataTable();
                using (SqlConnection connection = new SqlConnection(MainWindowReference.GetConnectionString()))
                using (SqlCommand command = new SqlCommand("SELECT * FROM Typ_budynku", connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    adapter.Fill(dt);
                    foreach (DataRow row in dt.Rows)
                    {
                        ListViewItem item = new ListViewItem(row.ItemArray[0].ToString());
                        item.SubItems.Add(row.ItemArray[1].ToString());
                        //item.SubItems.Add(row.ItemArray[2].ToString());

                        location_type_listView.Items.Add(item);
                        //locationTypes_listbox.Items.Add(row[0].ToString());
                    }
                }
            }
            catch (Exception)
            {
                //ErrorMessageClass.DisplayErrorMessage(402);
                MessageClass.DisplayMessage(1301);
            }
        }

        private void LoadCityList()
        {
            //city_listbox.Items.Clear();
            city_listView.Items.Clear();

            try
            {
                DataTable dt = new DataTable();
                using (SqlConnection connection = new SqlConnection(MainWindowReference.GetConnectionString()))
                using (SqlCommand command = new SqlCommand("SELECT * FROM City_Details_View", connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    connection.Open();
                    adapter.Fill(dt);
                    foreach (DataRow row in dt.Rows)
                    {
                        //city_listbox.Items.Add(row[0].ToString());
                        ListViewItem item = new ListViewItem(row[0].ToString());
                        item.SubItems.Add(row[1].ToString());
                        item.SubItems.Add(row[2].ToString());
                        city_listView.Items.Add(item);
                    }
                }
            }
            catch (Exception)
            {
                //ErrorMessageClass.DisplayErrorMessage(402);
                MessageClass.DisplayMessage(1001);
            }
        }

        //pobieeranie danych edytowanego punktu obslugi
        private void LoadLocation_to_Edit(int id)
        {
            DataTable dt = new DataTable();
            try
            {
                string command_string = "SELECT * FROM Punkt_obslugi WHERE Id_punktu = @location_id";//"SELECT * FROM Location_Detailed_View WHERE Id_punktu=@location_id";
                this.edited_id = id;
                using (SqlConnection connection = new SqlConnection(MainWindowReference.GetConnectionString()))
                using (SqlCommand command = new SqlCommand(command_string, connection))
                {
                    command.Parameters.Add("@location_id", SqlDbType.Int);
                    command.Parameters["@location_id"].Value = id;
                    using (SqlDataAdapter dat_adapter = new SqlDataAdapter(command))
                    {
                        dat_adapter.Fill(dt);

                        foreach (ListViewItem location_type_item in location_type_listView.Items)
                        {
                            if (location_type_item.Text.Equals(dt.Rows[0].ItemArray[1].ToString()))
                            {
                                int temp_id = location_type_item.Index;
                                location_type_item.Selected = true; //= locationTypes_listbox.Items.IndexOf(location_type);
                                break;
                            }
                        }

                        /*foreach (String location_type in locationTypes_listbox.Items)
                        { 
                            if (location_type.Equals(dt.Rows[0].ItemArray[1].ToString()))
                            {
                                locationTypes_listbox.SelectedIndex = locationTypes_listbox.Items.IndexOf(location_type);
                                break;
                            }
                        }*/

                        foreach (ListViewItem city_item in city_listView.Items)
                        {
                            int city_id = Convert.ToInt32(city_item.Text);
                            if (city_item.Text.Equals(dt.Rows[0].ItemArray[2].ToString()))
                            {
                                city_listView.Items[city_item.Index].Selected = true;
                                //city_listbox.SelectedIndex = city_listbox.Items.IndexOf(city_name);
                                break;
                            }
                        }

                        /*foreach (String city_name in city_listbox.Items)
                        {
                            if (city_name.Equals(dt.Rows[0].ItemArray[2].ToString()))
                            {
                                city_listbox.SelectedIndex = city_listbox.Items.IndexOf(city_name);
                                break;
                            }
                        }*/

                        street_textbox.Text = dt.Rows[0].ItemArray[3].ToString();
                        houseNumber_numericUpDown.Value= Convert.ToInt32(dt.Rows[0].ItemArray[4].ToString());
                        postCode_textBox.Text = dt.Rows[0].ItemArray[5].ToString();
                    }
                }
            }
            catch (Exception /*ex*/)
            {
                MessageClass.DisplayMessage(1302);
                this.Close();
                this.Dispose();
            }
        }

        private void ToggleMode(FormMode mode)
        {
            this.current_mode = mode;
            if (mode == FormMode.add)
            {
                this.Text = "Add location";
                accept_button.Text = "Add new location";
            }
            else if (mode == FormMode.edit)
            {
                this.Text = "Edit location";
                accept_button.Text = "Accept changes";
            }
            else
            {
                MessageClass.DisplayMessage(1304);
                this.Close();
                this.Dispose();
            }
        }

        private void Accept_button_Click(object sender, EventArgs e)
        {
            string insert_command = "Dodaj_punkt_obslugi";/*"INSERT INTO Punkt_obslugi VALUES (" +
                "(SELECT Id_typu_budynku FROM Typ_budynku WHERE Typ_budynku = @Typ_budynku), " +
                "(SELECT Id_miasta FROM Miasto WHERE Nazwa_miasta = @Nazwa_miasta), " +
                "@Ulica, @Numer_budynku, @Kod_pocztowy);";*/
            string edit_command = "UPDATE Punkt_obslugi SET " +
                "Id_typu_budynku = (SELECT Id_typu_budynku FROM Typ_budynku WHERE Typ_budynku = @Typ_budynku), " +
                "Id_miasta = @Id_miasta, " + //(SELECT Id_miasta FROM Miasto WHERE Nazwa_miasta = @Nazwa_miasta), " +
                "Ulica = @Ulica, Numer_budynku = @Numer_budynku, Kod_pocztowy = @Kod_pocztowy " +
                "WHERE Id_punktu = @location_id;";
            if (Check_Input() == true)
            {
                try
                {
                    string command_to_execute= insert_command;
                    
                    if (current_mode == FormMode.edit)
                    {
                        command_to_execute = edit_command;
                    }
                    using (SqlConnection connection = new SqlConnection(MainWindowReference.GetConnectionString()))
                    using (SqlCommand command = new SqlCommand(command_to_execute, connection))
                    {
                        if (current_mode == FormMode.add)
                        {
                            command.CommandType = CommandType.StoredProcedure;
                        }

                        connection.Open();
                        command.Parameters.Add("@Typ_budynku", SqlDbType.NVarChar);
                        command.Parameters.Add("@Id_miasta", SqlDbType.Int);
                        command.Parameters.Add("@Ulica", SqlDbType.NVarChar);
                        command.Parameters.Add("@Numer_budynku", SqlDbType.NVarChar);
                        command.Parameters.Add("@Kod_pocztowy", SqlDbType.NVarChar);

                        if (new_location_type_CheckBox.Checked == true)
                        {
                            command.Parameters["@Typ_budynku"].Value = new_location_type_textBox.Text;
                        }
                        else
                        {
                            command.Parameters["@Typ_budynku"].Value = location_type_listView.SelectedItems[0].SubItems[1].Text;//locationTypes_listbox.SelectedItems[0].ToString();
                        }
                        command.Parameters["@Id_miasta"].Value = Convert.ToInt32(city_listView.SelectedItems[0].Text);
                        command.Parameters["@Ulica"].Value = street_textbox.Text;
                        command.Parameters["@Numer_budynku"].Value = houseNumber_numericUpDown.Value;
                        command.Parameters["@Kod_pocztowy"].Value = postCode_textBox.Text;

                        if (current_mode == FormMode.edit)
                        {
                            command.Parameters.Add("@location_id", SqlDbType.NVarChar);
                            command.Parameters["@location_id"].Value = this.edited_id;
                        }

                        int result = command.ExecuteNonQuery();
                        if (current_mode == FormMode.add && result != (-1))
                        {
                            MessageClass.DisplayMessage(703);
                        }
                        else if (current_mode == FormMode.edit && result != 1)
                        {
                            MessageClass.DisplayMessage(703);
                        }
                    }
                    /*this.Close();
                    this.Dispose();*/
                }
                catch (Exception /*ex*/)
                {
                    if(current_mode == FormMode.add)
                        MessageClass.DisplayMessage(1304);
                    if (current_mode == FormMode.edit)
                        MessageClass.DisplayMessage(1305);
                }
                this.Close();
                this.Dispose();
            }
            else
            {
                //ErrorMessageClass.DisplayErrorMessage(405); //"You must enter name and choose vehicle type to add new vehicle", "Some data has been left unspecified"
                MessageClass.DisplayMessage(1112);
            }
        }

        private void Cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private bool Check_Input()
        {
            bool result = true;

            if( city_listView.SelectedItems.Count != 1)
            {
                result = false;
            }

            if (new_location_type_CheckBox.Checked==false && location_type_listView.SelectedItems.Count != 1)
            {
                result = false;
            }
            else if(new_location_type_CheckBox.Checked == true && (new_location_type_textBox.Text.Length==0 || new_location_type_textBox.Text.Trim().Length == 0))
            {
                result = false;
            }

            if (
                (street_textbox.Text.Length == 0 || street_textbox.Text.Trim().Length == 0) || 
                (postCode_textBox.Text.Length == 0 || postCode_textBox.Text.Trim().Length == 0)
               )
            {
                result = false;
            }

            return result;
        }

        private void New_location_type_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (new_location_type_CheckBox.Checked == true)
            {
                location_type_listView.SelectedItems.Clear();
                location_type_listView.Visible = false;
                new_location_type_textBox.Visible = true;
            }
            else
            {
                location_type_listView.Visible = true;
                new_location_type_textBox.Visible = false;
            }
        }
    }
}
