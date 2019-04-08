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
    public partial class VehicleAddEditForm : Form
    {
        private UserClass MainW { get; set; }
        private FormMode current_mode;
        private int edited_id;

        enum FormMode
        {
            add = 0,
            edit = 1
        };

        public VehicleAddEditForm()
        {
            InitializeComponent();
        }

        public VehicleAddEditForm(UserClass mW, int mode, int id)
        {
            InitializeComponent();
            this.MainW = mW;
            ToggleMode((FormMode)mode);

            LoadVehicleTypes();

            if (this.current_mode == FormMode.edit)
            {
                LoadVehicle_to_Edit(id);
            }
        }

        private void LoadVehicleTypes()
        {
            vehicleTypes_listbox.Items.Clear();
            try
            {
                DataTable dt = new DataTable();
                using (SqlConnection connection = new SqlConnection(MainW.GetConnectionString()))
                using (SqlCommand command = new SqlCommand("SELECT Typ_pojazdu FROM Typ_pojazdu", connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    adapter.Fill(dt);
                    foreach (DataRow row in dt.Rows)
                    {
                        vehicleTypes_listbox.Items.Add(row[0].ToString());
                    }
                }
            }
            catch (Exception )
            {
                ErrorMessageClass.DisplayErrorMessage(402);
            }
        }

        private void LoadVehicle_to_Edit(int id)
        {
            DataTable dt = new DataTable();
            try
            {
                this.edited_id = id;
                using (SqlConnection connection = new SqlConnection(MainW.GetConnectionString()))
                using (SqlCommand command = new SqlCommand("SELECT Typ_pojazdu, Nazwa_marki, Nazwa_modelu, Rejestracja FROM Vehicle_Details_View WHERE Id_pojazdu=@Id", connection))//Typ_pojazdu WHERE Id_typu_pojazdu=(SELECT Id_typu_pojazdu FROM Pojazd WHERE Id_pojazdu=@Id)", connection))
                {
                    command.Parameters.Add("@Id", SqlDbType.Int);
                    command.Parameters["@Id"].Value = id;
                    using (SqlDataAdapter dat_adapter = new SqlDataAdapter(command))
                    {
                        dat_adapter.Fill(dt);

                        foreach (String vehicle_type in vehicleTypes_listbox.Items)
                        {    //sprawdź jakiego typu jest edytowany pojazd
                            if (vehicle_type.Equals(dt.Rows[0].ItemArray[0].ToString()))
                            {
                                vehicleTypes_listbox.SelectedIndex = vehicleTypes_listbox.Items.IndexOf(vehicle_type);
                                break;
                            }
                        }
                        vehicleBrandName_textbox.Text = dt.Rows[0].ItemArray[1].ToString();
                        vehicleModelName_textBox.Text = dt.Rows[0].ItemArray[2].ToString();
                        vehicleRegistrationPlate.Text = dt.Rows[0].ItemArray[3].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                ErrorMessageClass.DisplayErrorMessage(403);
                this.Close();
                this.Dispose();
            }
        }

        /// <summary>
        /// Allows form mode toggle.
        /// </summary>
        /// <param name="mode">0 to add new vehicle. 1 to edit vehicle.</param>
        private void ToggleMode(FormMode mode) {
            this.current_mode = mode;
            if (mode == FormMode.add)
            {
                this.Text = "Add vehicle";
                accept_button.Text = "Add new vehicle";
            }
            else if (mode == FormMode.edit)
            {
                this.Text = "Edit vehicle";
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
            /*if (this.current_mode == FormMode.add)
            {*/
            if (Check_Input() == true)//vehicleBrandName_textbox.Text.Length > 2 && vehicleTypes_listbox.SelectedItems.Count == 1)
            {
                try
                {
                    string execute_command = "INSERT INTO Pojazd VALUES((SELECT Id_typu_pojazdu FROM Typ_pojazdu WHERE Typ_pojazdu = @vehicle_type), @brand_name, @model_name, @registration_plate)";
                    if (current_mode == (FormMode.edit))
                    {
                        execute_command = "UPDATE Pojazd SET Id_typu_pojazdu = (SELECT Id_typu_pojazdu FROM Typ_pojazdu WHERE Typ_pojazdu = @vehicle_type), Nazwa_marki = @brand_name, Nazwa_modelu = @model_name, Rejestracja = @registration_plate" +
                        " WHERE Id_pojazdu = @Edited_id";
                    }
                    using (SqlConnection connection = new SqlConnection(MainW.GetConnectionString()))
                    using (SqlCommand command = new SqlCommand(execute_command, connection)) //"INSERT INTO Pojazd VALUES ((SELECT Id_typu_pojazdu FROM Typ_pojazdu WHERE Typ_pojazdu=@Typ_pojazdu))", connection))
                    {
                        connection.Open();
                        command.Parameters.Add("@vehicle_type", SqlDbType.NVarChar);
                        command.Parameters.Add("@brand_name", SqlDbType.NVarChar);
                        command.Parameters.Add("@model_name", SqlDbType.NVarChar);
                        command.Parameters.Add("@registration_plate", SqlDbType.NVarChar);
                        
                        command.Parameters["@vehicle_type"].Value = vehicleTypes_listbox.SelectedItem.ToString();
                        command.Parameters["@brand_name"].Value = vehicleBrandName_textbox.Text;
                        command.Parameters["@model_name"].Value = vehicleModelName_textBox.Text;
                        command.Parameters["@registration_plate"].Value = vehicleRegistrationPlate.Text;

                        if (current_mode == (FormMode.edit))
                        {
                            command.Parameters.Add("@Edited_id", SqlDbType.Int);
                            command.Parameters["@Edited_id"].Value = this.edited_id.ToString();
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
                    if(current_mode == FormMode.add)
                        ErrorMessageClass.DisplayErrorMessage(404);
                    else if (current_mode == FormMode.edit)
                        ErrorMessageClass.DisplayErrorMessage(406);
                }
            }
            else
            {
                if(current_mode == FormMode.add)
                    ErrorMessageClass.DisplayErrorMessage(405); //"You must enter name and choose vehicle type to add new vehicle", "Some data has been left unspecified"
                else if (current_mode == FormMode.edit)
                    ErrorMessageClass.DisplayErrorMessage(415);
            }
            //}
            /*else if (this.current_mode == FormMode.edit)
            {
                if (vehicleBrandName_textbox.Text.Length > 2 && vehicleTypes_listbox.SelectedItems.Count == 1)
                {
                    try
                    {
                        using (SqlConnection connection = new SqlConnection(MainW.GetConnectionString()))
                        using (SqlCommand command = new SqlCommand("UPDATE Pojazd SET Id_typu_pojazdu = (SELECT Id_typu_pojazdu FROM Typ_pojazdu WHERE Typ_pojazdu = @vehicle_type), Nazwa_marki = @brand_name, Nazwa_modelu = @model_name, Rejestracja = @registration_plate" +
                            " WHERE Id_pojazdu = @Edited_id", connection))
                        {
                            connection.Open();
                            command.Parameters.Add("@vehicle_type", SqlDbType.NVarChar);
                            command.Parameters.Add("@brand_name", SqlDbType.NVarChar);
                            command.Parameters.Add("@model_name", SqlDbType.NVarChar);
                            command.Parameters.Add("@registration_plate", SqlDbType.NVarChar);
                            command.Parameters.Add("@Edited_id", SqlDbType.Int);
                            command.Parameters["@vehicle_type"].Value = vehicleTypes_listbox.SelectedItem.ToString();
                            command.Parameters["@brand_name"].Value = vehicleBrandName_textbox.Text;
                            command.Parameters["@model_name"].Value = vehicleModelName_textBox.Text;
                            command.Parameters["@registration_plate"].Value = vehicleRegistrationPlate.Text;
                            command.Parameters["@Edited_id"].Value = this.edited_id.ToString();

                            int result = command.ExecuteNonQuery();
                            if (result != 1)
                            {
                                throw (new Exception("Failed to update selected vehicle's data!"));
                            }
                        }
                        this.Close();
                        this.Dispose();
                    }
                    catch (Exception)
                    {
                        ErrorMessageClass.DisplayErrorMessage(406);
                    }
                }
                else
                {
                    ErrorMessageClass.DisplayErrorMessage(415);
                }
            }*/
        }

        private bool Check_Input()
        {
            bool result = true;
            if ((vehicleBrandName_textbox.Text.Length == 0 || vehicleBrandName_textbox.Text.Trim().Length == 0 ) ||
                (vehicleModelName_textBox.Text.Length == 0 || vehicleModelName_textBox.Text.Trim().Length == 0) ||
                (vehicleRegistrationPlate.Text.Length == 0 || vehicleRegistrationPlate.Text.Trim().Length == 0))
            {
                result = false;
            }
            if (vehicleTypes_listbox.SelectedItems.Count != 1)
            {
                result = false;
            }
            return result;
        }

        private void Cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
