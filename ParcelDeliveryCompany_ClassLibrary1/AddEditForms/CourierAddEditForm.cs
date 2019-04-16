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

namespace ParcelDeliveryCompanyApplication
{
    public partial class CourierAddEditForm : Form
    {
        private UserClass MainW;

        private UserClass MainWindowReference { get => MainW; set => MainW = value; }

        private FormMode current_mode;
        private int edit_id;

        enum FormMode {
            add = 0,
            edit = 1
        };

        public CourierAddEditForm()
        {
            InitializeComponent();
        }

        public CourierAddEditForm(UserClass MainWReference, int mode, int id_to_edit)
        {
            InitializeComponent();
            this.MainWindowReference = MainWReference;
            Toggle_Form_Mode((FormMode)mode);
            LoadVehicleList();

            if (this.current_mode == FormMode.edit)
            {
                this.edit_id = id_to_edit;
                Load_Edited_Courier_Data(this.edit_id);
            }
        }

        private void Toggle_Form_Mode(FormMode current_mode)
        {
            this.current_mode=current_mode;

            if (this.current_mode == FormMode.add)
            {
                this.Text = "Add new courier";
                this.accept_button.Text = "Add courier";
            }
            else if (this.current_mode == FormMode.edit)
            {
                this.Text = "Edit selected courier";
                this.accept_button.Text = "Save changes";
            }
        }

        internal void Load_Edited_Courier_Data(int id)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(MainWindowReference.GetConnectionString()))
                using (SqlCommand command = new SqlCommand("SELECT Id_pojazdu, Imie, Nazwisko, Data_urodzenia, PESEL FROM Kurier WHERE Id_kuriera = @id_kuriera", connection))
                {
                    command.Parameters.Add("@id_kuriera", SqlDbType.Int);
                    command.Parameters["@id_kuriera"].Value = id;
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        if (connection.State != ConnectionState.Open)
                            connection.Open();

                        adapter.Fill(dt);
                        foreach (DataRow row in dt.Rows)
                        {
                            vehicle_ListView.SelectedItems.Clear();
                            foreach(ListViewItem vehicle in vehicle_ListView.Items)
                            {
                                if (vehicle.Text.Equals(row[0].ToString()))
                                {
                                    int temp_id = vehicle.Index;
                                    vehicle_ListView.Items[temp_id].Selected = true;
                                    vehicle_ListView.HideSelection = false;
                                    vehicle_ListView.Focus();//Będzie widoczny na liście pojazd przypisany kurierowi
                                    break;
                                }
                            }
                            
                            firstName_textBox.Text = row[1].ToString();
                            lastName_textBox.Text = row[2].ToString();
                            birthDate_dateTimePicker.Text = Convert.ToDateTime(row[3]).ToShortDateString();
                            nationalIdNumber_textBox.Text = row[4].ToString();
                        }
                    }
                } 
            }
            catch (Exception)
            {
                MessageClass.DisplayMessage(505);
                this.Close();
                this.Dispose();
            }
        }

        internal void LoadVehicleList()
        {
            vehicle_ListView.Items.Clear();
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(MainW.GetConnectionString()))
                using (SqlCommand command = new SqlCommand("SELECT * FROM Vehicle_Details_View", connection))//"SELECT p.Id_pojazdu, tp.Typ_pojazdu FROM Pojazd p INNER JOIN Typ_pojazdu tp ON p.Id_typu_pojazdu=tp.Id_typu_pojazdu WHERE p.Id_typu_pojazdu = tp.Id_typu_pojazdu", connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    adapter.Fill(dt);
                    foreach (DataRow row in dt.Rows)
                    {
                        ListViewItem item = new ListViewItem(row[0].ToString());
                        item.SubItems.Add(row[1].ToString());
                        item.SubItems.Add(row[2].ToString());
                        item.SubItems.Add(row[3].ToString());
                        item.SubItems.Add(row[4].ToString());
                        vehicle_ListView.Items.Add(item);
                    }
                }
            }
            catch (SqlException)
            {
                MessageClass.DisplayMessage(411);
                this.Close();
                this.Dispose();
            }
            catch (Exception)
            {
                MessageClass.DisplayMessage(410);
                this.Close();
                this.Dispose();
            }
        }


        private void Accept_button_Click(object sender, EventArgs e)
        {
            if (this.current_mode == FormMode.add)
            {
                try
                {
                    if( Check_Input() == true)
                    {
                        //Add courier
                        using (SqlConnection connection = new SqlConnection(MainWindowReference.GetConnectionString()))
                        using (SqlCommand command = new SqlCommand("INSERT INTO Kurier VALUES (@id_pojazdu, @imie, @nazwisko, @data_urodzenia, @pesel)", connection))
                        {
                            command.Parameters.Add("@id_pojazdu", SqlDbType.Int);
                            command.Parameters.Add("@imie", SqlDbType.NVarChar);
                            command.Parameters.Add("@nazwisko", SqlDbType.NVarChar);
                            command.Parameters.Add("@data_urodzenia", SqlDbType.Date);
                            command.Parameters.Add("@pesel", SqlDbType.NVarChar);

                            command.Parameters["@id_pojazdu"].Value = Convert.ToInt32(vehicle_ListView.SelectedItems[0].Text);
                            command.Parameters["@imie"].Value = firstName_textBox.Text;
                            command.Parameters["@nazwisko"].Value = lastName_textBox.Text;
                            command.Parameters["@data_urodzenia"].Value = birthDate_dateTimePicker.Value.Date; //do przerobioenia - powoduje błąd
                            command.Parameters["@pesel"].Value = nationalIdNumber_textBox.Text;

                            connection.Open();
                            int result = command.ExecuteNonQuery();

                            if (result == 0)
                            {
                                MessageClass.DisplayMessage(508);
                            }
                            else if (result == 1)
                            {
                                MessageClass.DisplayMessage(509);
                            }
                        }
                        this.Close();
                        this.Dispose();
                    }
                    else
                    {
                        MessageClass.DisplayMessage(510);
                    }
                }
                catch(Exception /*ex*/)
                {
                    //MessageBox.Show(ex.Message);
                    MessageClass.DisplayMessage(506);
                    this.Close();
                    this.Dispose();
                }
            }
            else if (this.current_mode == FormMode.edit)
            {
                try
                {
                    if (Check_Input() == true)
                    {
                        using (SqlConnection connection = new SqlConnection(MainWindowReference.GetConnectionString()))
                        using (SqlCommand command = new SqlCommand("UPDATE Kurier SET Id_pojazdu = @id_pojazdu, Imie = @imie, Nazwisko = @nazwisko, Data_urodzenia = @data_urodzenia, PESEL = @pesel WHERE Id_kuriera = @id_kuriera", connection))
                        {
                            command.Parameters.Add("@id_pojazdu", SqlDbType.Int);
                            command.Parameters.Add("@imie", SqlDbType.NVarChar);
                            command.Parameters.Add("@nazwisko", SqlDbType.NVarChar);
                            command.Parameters.Add("@data_urodzenia", SqlDbType.Date);
                            command.Parameters.Add("@pesel", SqlDbType.NVarChar);
                            command.Parameters.Add("@id_kuriera", SqlDbType.Int);

                            command.Parameters["@id_pojazdu"].Value = Convert.ToInt32(vehicle_ListView.SelectedItems[0].Text);
                            command.Parameters["@imie"].Value = firstName_textBox.Text;
                            command.Parameters["@nazwisko"].Value = lastName_textBox.Text;
                            command.Parameters["@data_urodzenia"].Value = birthDate_dateTimePicker.Value.Date;
                            command.Parameters["@pesel"].Value = nationalIdNumber_textBox.Text;
                            command.Parameters["@id_kuriera"].Value = this.edit_id;

                            connection.Open();
                            int result = command.ExecuteNonQuery();

                            if (result == 0)
                            {
                                MessageClass.DisplayMessage(508);
                            }
                            else if (result == 1)
                            {
                                MessageClass.DisplayMessage(509);
                            }
                            this.Close();
                            this.Dispose();
                        }
                    }
                    else
                    {
                        MessageClass.DisplayMessage(510);
                    }
                }
                catch (Exception /*ex*/)
                {
                    //MessageBox.Show(ex.Message);
                    MessageClass.DisplayMessage(507);
                    this.Close();
                    this.Dispose();
                }
            }
        }   

        private bool Check_Input()
        {
            bool result = true;
            if (firstName_textBox.Text.Length==0 || firstName_textBox.Text.Trim().Length == 0)
            {
                result = false;
            }
            else if (lastName_textBox.Text.Length == 0 || lastName_textBox.Text.Trim().Length == 0)
            {
                result = false;
            }
            else if (lastName_textBox.Text.Length == 0 || lastName_textBox.Text.Trim().Length == 0)
            {
                result = false;
            }
            else if (nationalIdNumber_textBox.Text.Length == 0 || nationalIdNumber_textBox.Text.Trim().Length == 0)
            {
                result = false;
            }
            else if (vehicle_ListView.SelectedItems.Count != 1)
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

        private void Vehicle_ListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
