//using ParcelDeliveryCompany_ClassLibrary1;
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
                new_vehicle_type_checkBox.Enabled = false;
                LoadVehicle_to_Edit(id);
            }
        }

        private void LoadVehicleTypes()
        {
            //vehicleTypes_listbox.Items.Clear();
            vehicleTypes_listView.Items.Clear();
            try
            {
                DataTable dt = new DataTable();
                using (SqlConnection connection = new SqlConnection(MainW.GetConnectionString()))
                using (SqlCommand command = new SqlCommand("SELECT * FROM Typ_pojazdu", connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    adapter.Fill(dt);
                    foreach (DataRow row in dt.Rows)
                    {
                        //vehicleTypes_listbox.Items.Add(row[0].ToString());
                        ListViewItem new_item = new ListViewItem(row.ItemArray[0].ToString());
                        new_item.SubItems.Add(row.ItemArray[1].ToString());
                        vehicleTypes_listView.Items.Add(new_item);
                    }
                }
            }
            catch (Exception )
            {
                MessageClass.DisplayMessage(402);
            }
        }

        private void LoadVehicle_to_Edit(int id)
        {
            DataTable dt = new DataTable();
            try
            {
                
                string command1 = "SELECT Typ_pojazdu, Nazwa_marki, Nazwa_modelu, Rejestracja FROM Vehicle_Details_View WHERE Id_pojazdu=@Id";
                this.edited_id = id;
                using (SqlConnection connection = new SqlConnection(MainW.GetConnectionString()))
                using (SqlCommand command = new SqlCommand(command1, connection))//Typ_pojazdu WHERE Id_typu_pojazdu=(SELECT Id_typu_pojazdu FROM Pojazd WHERE Id_pojazdu=@Id)", connection))
                {
                    command.Parameters.Add("@Id", SqlDbType.Int);
                    command.Parameters["@Id"].Value = id;
                    using (SqlDataAdapter dat_adapter = new SqlDataAdapter(command))
                    {
                        dat_adapter.Fill(dt);

                        foreach (ListViewItem vehicle_type in vehicleTypes_listView.Items) //String vehicle_type in vehicleTypes_listbox.Items)
                        {    //sprawdź jakiego typu jest edytowany pojazd
                            if (vehicle_type.SubItems[1].Text.Equals(dt.Rows[0].ItemArray[0].ToString())) //vehicle_type.Equals(dt.Rows[0].ItemArray[0].ToString()))
                            {
                                //vehicleTypes_listbox.SelectedIndex = vehicleTypes_listbox.Items.IndexOf(vehicle_type);
                                vehicleTypes_listView.Items[vehicle_type.Index].Selected = true;
                                break;
                            }
                        }
                        vehicleBrandName_textbox.Text = dt.Rows[0].ItemArray[1].ToString();
                        vehicleModelName_textBox.Text = dt.Rows[0].ItemArray[2].ToString();
                        vehicleRegistrationPlate.Text = dt.Rows[0].ItemArray[3].ToString();
                    }
                }
            }
            catch (Exception /*ex*/)
            {
                //MessageBox.Show(ex.Message);
                MessageClass.DisplayMessage(403);
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
                MessageClass.DisplayMessage(401);
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
                    string execute_command = "Dodaj_pojazd";//"INSERT INTO Pojazd VALUES(@Typ_pojazdu_id, @Nazwa_marki, @Nazwa_modelu, @Rejestracja)"; //"INSERT INTO Pojazd VALUES((SELECT Id_typu_pojazdu FROM Typ_pojazdu WHERE Typ_pojazdu = @Typ_pojazdu), @Nazwa_marki, @Nazwa_modelu, @Rejestracja)";
                    if (current_mode == (FormMode.edit))
                    {
                        execute_command = "UPDATE Pojazd SET Id_typu_pojazdu = @Typ_pojazdu_id, Nazwa_marki = @Nazwa_marki, Nazwa_modelu = @Nazwa_modelu, Rejestracja = @Rejestracja" +
                        " WHERE Id_pojazdu = @Edited_id";
                        /*"UPDATE Pojazd SET Id_typu_pojazdu = (SELECT Id_typu_pojazdu FROM Typ_pojazdu WHERE Typ_pojazdu = @Typ_pojazdu), Nazwa_marki = @Nazwa_marki, Nazwa_modelu = @Nazwa_modelu, Rejestracja = @Rejestracja" +
                        " WHERE Id_pojazdu = @Edited_id";*/
                    }
                    using (SqlConnection connection = new SqlConnection(MainW.GetConnectionString()))
                    using (SqlCommand command = new SqlCommand(execute_command, connection)) //"INSERT INTO Pojazd VALUES ((SELECT Id_typu_pojazdu FROM Typ_pojazdu WHERE Typ_pojazdu=@Typ_pojazdu))", connection))
                    {
                        connection.Open();

                        if (current_mode == FormMode.add)
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            if (new_vehicle_type_checkBox.Checked == true)
                            {
                                command.Parameters.AddWithValue("@Typ_pojazdu", new_vehicle_type_textBox.Text);
                            }
                            else
                            {
                                command.Parameters.AddWithValue("@Typ_pojazdu", vehicleTypes_listView.SelectedItems[0].SubItems[1].Text);
                            }
                        }
                        //command.Parameters.Add("@Typ_pojazdu", SqlDbType.NVarChar);
                        //command.Parameters.Add("@Typ_pojazdu_id", SqlDbType.Int);
                        command.Parameters.Add("@Nazwa_marki", SqlDbType.NVarChar);
                        command.Parameters.Add("@Nazwa_modelu", SqlDbType.NVarChar);
                        command.Parameters.Add("@Rejestracja", SqlDbType.NVarChar);
                        
                        //command.Parameters["@Typ_pojazdu"].Value = vehicleTypes_listbox.SelectedItem.ToString();
                        //command.Parameters["@Typ_pojazdu_id"].Value = Get_Vehicle_Type_Id(vehicleTypes_listbox.SelectedItem.ToString());
                        command.Parameters["@Nazwa_marki"].Value = vehicleBrandName_textbox.Text;
                        command.Parameters["@Nazwa_modelu"].Value = vehicleModelName_textBox.Text;
                        command.Parameters["@Rejestracja"].Value = vehicleRegistrationPlate.Text;

                        if (current_mode == (FormMode.edit))
                        {
                            command.Parameters.AddWithValue("@Typ_pojazdu_id", vehicleTypes_listView.SelectedItems[0].Text);
                            command.Parameters.Add("@Edited_id", SqlDbType.Int);
                            command.Parameters["@Edited_id"].Value = this.edited_id.ToString();
                        }

                        int result = command.ExecuteNonQuery();

                        if (current_mode==FormMode.add && result!=(-1))
                        {
                            throw (new Exception("Failed to add new vehicle"));
                        }
                        else if (current_mode==FormMode.edit && result != 1)
                        {
                            throw (new Exception("Failed to edit selected vehicle!"));
                        }
                    }
                    this.Close();
                    this.Dispose();
                }
                catch (Exception)
                {
                    if(current_mode == FormMode.add)
                        MessageClass.DisplayMessage(404);
                    else if (current_mode == FormMode.edit)
                        MessageClass.DisplayMessage(406);
                }
            }
            else
            {
                if(current_mode == FormMode.add)
                    MessageClass.DisplayMessage(405); //"You must enter name and choose vehicle type to add new vehicle", "Some data has been left unspecified"
                else if (current_mode == FormMode.edit)
                    MessageClass.DisplayMessage(415);
            }
            //}
            /*else if (this.current_mode == FormMode.edit)
            {
                if (vehicleBrandName_textbox.Text.Length > 2 && vehicleTypes_listbox.SelectedItems.Count == 1)
                {
                    try
                    {
                        using (SqlConnection connection = new SqlConnection(MainW.GetConnectionString()))
                        using (SqlCommand command = new SqlCommand("UPDATE Pojazd SET Id_typu_pojazdu = (SELECT Id_typu_pojazdu FROM Typ_pojazdu WHERE Typ_pojazdu = @Typ_pojazdu), Nazwa_marki = @Nazwa_marki, Nazwa_modelu = @Nazwa_modelu, Rejestracja = @Rejestracja" +
                            " WHERE Id_pojazdu = @Edited_id", connection))
                        {
                            connection.Open();
                            command.Parameters.Add("@Typ_pojazdu", SqlDbType.NVarChar);
                            command.Parameters.Add("@Nazwa_marki", SqlDbType.NVarChar);
                            command.Parameters.Add("@Nazwa_modelu", SqlDbType.NVarChar);
                            command.Parameters.Add("@Rejestracja", SqlDbType.NVarChar);
                            command.Parameters.Add("@Edited_id", SqlDbType.Int);
                            command.Parameters["@Typ_pojazdu"].Value = vehicleTypes_listbox.SelectedItem.ToString();
                            command.Parameters["@Nazwa_marki"].Value = vehicleBrandName_textbox.Text;
                            command.Parameters["@Nazwa_modelu"].Value = vehicleModelName_textBox.Text;
                            command.Parameters["@Rejestracja"].Value = vehicleRegistrationPlate.Text;
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

        private int Get_Vehicle_Type_Id(string type_name)
        {
            string get_veh_type_id_sp = "Znajdz_lub_stworz";
            try
            {
                using (SqlConnection connection = new SqlConnection(MainW.GetConnectionString()))
                using (SqlCommand command = new SqlCommand(get_veh_type_id_sp, connection)) //"INSERT INTO Pojazd VALUES ((SELECT Id_typu_pojazdu FROM Typ_pojazdu WHERE Typ_pojazdu=@Typ_pojazdu))", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("@Nazwa_tabeli", SqlDbType.NVarChar).Value = "Typ_pojazdu";
                    command.Parameters.Add("@Nazwa_przedmiotu", SqlDbType.NVarChar).Value = type_name;
                    var return_param = command.Parameters.Add("@ReturnVal", SqlDbType.Int); //wykonywanie procedury zwracającej wartość wymaga użycia dodatkowej zmiennej, aby otrzymać wynik
                    return_param.Direction = ParameterDirection.ReturnValue;

                    connection.Open();
                    command.ExecuteNonQuery();
                    int result = (int)return_param.Value;
                    return result;
                }
            }
            catch(Exception /*ex*/)
            {
                //MessageBox.Show(ex.Message);
                this.Close();
                this.Dispose();
            }
            return 0;
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
            if (new_vehicle_type_checkBox.Checked==false && vehicleTypes_listView.SelectedItems.Count != 1)
            {
                result = false;
            }
            else if (new_vehicle_type_checkBox.Checked==true && (new_vehicle_type_textBox.Text.Length==0 || new_vehicle_type_textBox.Text.Trim().Length==0))
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

        private void New_vehicle_type_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (new_vehicle_type_checkBox.Checked == true)
            {
                vehicleTypes_listView.SelectedItems.Clear();
                vehicleTypes_listView.Visible = false;
                new_vehicle_type_textBox.Visible = true;
            }
            else
            {
                vehicleTypes_listView.Visible = true;
                new_vehicle_type_textBox.Visible = false;
            }
        }
    }
}
