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

namespace TestSQLServerProject01
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
                this.edited_id = id;
                LoadLocation_to_Edit(edited_id);
            }
        }

        private void LoadLocationTypes()
        {
            locationTypes_listbox.Items.Clear();
            try
            {
                DataTable dt = new DataTable();
                using (SqlConnection connection = new SqlConnection(MainWindowReference.GetConnectionString()))
                using (SqlCommand command = new SqlCommand("SELECT Typ_budynku FROM Typ_budynku", connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    adapter.Fill(dt);
                    foreach (DataRow row in dt.Rows)
                    {
                        locationTypes_listbox.Items.Add(row[0].ToString());
                    }
                }
            }
            catch (Exception)
            {
                //ErrorMessageClass.DisplayErrorMessage(402);
            }
        }

        private void LoadCityList()
        {
            city_listbox.Items.Clear();
            try
            {
                DataTable dt = new DataTable();
                using (SqlConnection connection = new SqlConnection(MainWindowReference.GetConnectionString()))
                using (SqlCommand command = new SqlCommand("SELECT Nazwa_miasta FROM Miasto", connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    connection.Open();
                    adapter.Fill(dt);
                    foreach (DataRow row in dt.Rows)
                    {
                        city_listbox.Items.Add(row[0].ToString());
                    }
                }
            }
            catch (Exception)
            {
                //ErrorMessageClass.DisplayErrorMessage(402);
            }
        }

        //pobieeranie danych edytowanego punktu obslugi
        private void LoadLocation_to_Edit(int id)
        {
            DataTable dt = new DataTable();
            try
            {
                this.edited_id = id;
                using (SqlConnection connection = new SqlConnection(MainWindowReference.GetConnectionString()))
                using (SqlCommand command = new SqlCommand("SELECT * FROM Location_Detailed_View WHERE Id_punktu=@location_id", connection))
                {
                    command.Parameters.Add("@location_id", SqlDbType.Int);
                    command.Parameters["@location_id"].Value = id;
                    using (SqlDataAdapter dat_adapter = new SqlDataAdapter(command))
                    {
                        dat_adapter.Fill(dt);

                        foreach (String location_type in locationTypes_listbox.Items)
                        { 
                            if (location_type.Equals(dt.Rows[0].ItemArray[1].ToString()))
                            {
                                locationTypes_listbox.SelectedIndex = locationTypes_listbox.Items.IndexOf(location_type);
                                break;
                            }
                        }

                        foreach (String city_name in city_listbox.Items)
                        {
                            if (city_name.Equals(dt.Rows[0].ItemArray[2].ToString()))
                            {
                                city_listbox.SelectedIndex = city_listbox.Items.IndexOf(city_name);
                                break;
                            }
                        }

                        street_textbox.Text = dt.Rows[0].ItemArray[3].ToString();
                        houseNumber_numericUpDown.Value= Convert.ToInt32(dt.Rows[0].ItemArray[4].ToString());
                        postCode_textBox.Text = dt.Rows[0].ItemArray[5].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //ErrorMessageClass.DisplayErrorMessage(403);
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
                ErrorMessageClass.DisplayErrorMessage(401);
                this.Close();
                this.Dispose();
            }
        }

        private void Accept_button_Click(object sender, EventArgs e)
        {
            string insert_command = "INSERT INTO Punkt_obslugi VALUES (" +
                "(SELECT Id_typu_budynku FROM Typ_budynku WHERE Typ_budynku = @location_type), " +
                "(SELECT Id_miasta FROM Miasto WHERE Nazwa_miasta = @city_name), " +
                "@street_name, @house_number, @post_code);";
            string edit_command = "UPDATE Punkt_obslugi SET " +
                "Id_typu_budynku = (SELECT Id_typu_budynku FROM Typ_budynku WHERE Typ_budynku = @location_type), " +
                "Id_miasta = (SELECT Id_miasta FROM Miasto WHERE Nazwa_miasta = @city_name), " +
                "Ulica = @street_name, Numer_budynku = @house_number, Kod_pocztowy = @post_code " +
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
                        connection.Open();
                        command.Parameters.Add("@location_type", SqlDbType.NVarChar);
                        command.Parameters.Add("@city_name", SqlDbType.NVarChar);
                        command.Parameters.Add("@street_name", SqlDbType.NVarChar);
                        command.Parameters.Add("@house_number", SqlDbType.NVarChar);
                        command.Parameters.Add("@post_code", SqlDbType.NVarChar);

                        command.Parameters["@location_type"].Value = locationTypes_listbox.SelectedItems[0].ToString();
                        command.Parameters["@city_name"].Value = city_listbox.SelectedItems[0].ToString();
                        command.Parameters["@street_name"].Value = street_textbox.Text;
                        command.Parameters["@house_number"].Value = houseNumber_numericUpDown.Value;
                        command.Parameters["@post_code"].Value = postCode_textBox.Text;

                        if (current_mode == FormMode.edit)
                        {
                            command.Parameters.Add("@location_id", SqlDbType.NVarChar);
                            command.Parameters["@location_id"].Value = this.edited_id;
                        }

                        int result = command.ExecuteNonQuery();
                        if (result != 1)
                        {
                            throw (new Exception("Failed to add new vehicle!"));
                        }
                    }
                    this.Close();
                    this.Dispose();
                }
                catch (Exception)
                {
                    //ErrorMessageClass.DisplayErrorMessage(404);
                }
            }
            else
            {
                //ErrorMessageClass.DisplayErrorMessage(405); //"You must enter name and choose vehicle type to add new vehicle", "Some data has been left unspecified"
                this.Close();
                this.Dispose();
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

            if( locationTypes_listbox.SelectedItems.Count != 1 || city_listbox.SelectedItems.Count != 1)
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
    }
}
