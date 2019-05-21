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
    public partial class OrderAddEditForm : Form
    {
        private UserClass mainW;
        public UserClass MainWindowReference { get => mainW; set => mainW = value; }

        FormMode current_mode=FormMode.add;
        private int edit_id;

        enum FormMode
        {
            add = 0,
            edit = 1
        };

        public OrderAddEditForm()
        {
            InitializeComponent();
        }

        public OrderAddEditForm(UserClass mW, int mode, int id_to_edit)
        {
            InitializeComponent();
            this.MainWindowReference = mW;
            Toggle_Form_Mode((FormMode)mode);
            Load_Courier_Data();
            Load_Sender_List();

            if (this.current_mode == FormMode.edit)
            {
                this.edit_id = id_to_edit;
                Load_Edited_Order_Data(this.edit_id);
            }
        }

        private void Load_Sender_List()
        {
            sender_ListView.Items.Clear();
            try
            {
                DataTable dt = new DataTable();
                using (SqlConnection connection = new SqlConnection(MainWindowReference.GetConnectionString()))
                using (SqlCommand command = new SqlCommand("SELECT * FROM Klient", connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    adapter.Fill(dt);

                    foreach (DataRow row in dt.Rows)
                    {
                        ListViewItem item = new ListViewItem(row[0].ToString());

                        foreach (object row_item in row.ItemArray)
                        {
                            if (row_item.ToString().Equals((row[0].ToString())))
                            {
                                //nic nie rób
                            }
                            else
                                item.SubItems.Add(row_item.ToString());
                        }
                        sender_ListView.Items.Add(item);
                    }
                }
            }
            catch (Exception /*ex*/)
            {
                MessageClass.DisplayMessage(801);//MessageBox.Show("Could not load senders/customers' list.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        internal void Load_Courier_Data()
        {
            courier_ListView.Items.Clear();
            try
            {
                DataTable dt = new DataTable();
                using (SqlConnection connection = new SqlConnection(MainWindowReference.GetConnectionString()))
                using (SqlCommand command = new SqlCommand("SELECT Id_kuriera, Id_pojazdu, Imie, Nazwisko  FROM Kurier", connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    adapter.Fill(dt);

                    foreach (DataRow row in dt.Rows)
                    {
                        ListViewItem item = new ListViewItem(row[0].ToString());

                        foreach (object row_item in row.ItemArray)
                        {
                            for (int i=1; i< row.ItemArray.Count(); i++)
                            {
                                item.SubItems.Add(row[i].ToString());
                            }
                        }
                        courier_ListView.Items.Add(item);
                    }
                }
            }
            catch (Exception)
            {
                MessageClass.DisplayMessage(501);
            }
        }

        internal void Load_Area_List()
        {
            newCityArea_listBox.Items.Clear();
            try
            {
                DataTable dt = new DataTable();
                using (SqlConnection connection = new SqlConnection(MainWindowReference.GetConnectionString()))
                using (SqlCommand command = new SqlCommand("SELECT Nazwa_strefy FROM Strefa", connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    adapter.Fill(dt);

                    foreach (DataRow row in dt.Rows)
                    {
                        newCityArea_listBox.Items.Add(row[0].ToString());
                    }
                }
            }
            catch (Exception)
            {
                MessageClass.DisplayMessage(901);
            }
        }

        internal void Load_City_List()
        {
            city_listView.Items.Clear();
            try
            {
                DataTable dt = new DataTable();
                using (SqlConnection connection = new SqlConnection(MainWindowReference.GetConnectionString()))
                using (SqlCommand command = new SqlCommand("SELECT * FROM City_Area_list_View", connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    adapter.Fill(dt);

                    foreach (DataRow row in dt.Rows)
                    {
                        ListViewItem item = new ListViewItem(row[0].ToString());
                        item.SubItems.Add(row[1].ToString());
                        city_listView.Items.Add(item);
                    }
                }
            }
            catch (Exception)
            {
                MessageClass.DisplayMessage(1001);
            }
        }

        private void Load_Edited_Order_Data(int edit_id)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(MainWindowReference.GetConnectionString()))
                using (SqlCommand command = new SqlCommand("SELECT Id_kuriera, Id_klienta, Data_zlecenia FROM Orders_detailed_list_view WHERE Id_zlecenia = @order_id", connection))
                {
                    command.Parameters.Add("@order_id", SqlDbType.Int);
                    command.Parameters["@order_id"].Value = edit_id;
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        if (connection.State != ConnectionState.Open)
                        {
                            connection.Open();
                        }
                        adapter.Fill(dt);
                        foreach (DataRow row in dt.Rows)
                        {
                            foreach (ListViewItem courier in courier_ListView.Items)
                            {
                                if (courier.Text.Equals(row[0].ToString()))
                                {
                                    int temp_id = courier.Index;
                                    courier_ListView.Items[temp_id].Selected = true;
                                    courier_ListView.HideSelection = false;
                                    courier_ListView.Focus();
                                    break;
                                }
                            }

                            foreach (ListViewItem sender in sender_ListView.Items)
                            {
                                if (sender.Text.Equals(row[1].ToString()))
                                {
                                    int temp_id = sender.Index;
                                    sender_ListView.Items[temp_id].Selected = true;
                                    sender_ListView.HideSelection = false;
                                    sender_ListView.Focus();
                                    break;
                                }
                            }

                            orderDate_dateTimePicker.Value = Convert.ToDateTime(row[2].ToString());
                        }
                    }
                }
                
            }
            catch (Exception)
            {
                MessageClass.DisplayMessage(603);
                this.Close();
                this.Dispose();
            }
        }

        private void Toggle_Form_Mode(FormMode mode)
        {
            this.current_mode = mode;

            if (this.current_mode == FormMode.add)
            {
                this.Text = "Add new order";
                this.accept_button.Text = "Add order";
            }
            else if (this.current_mode == FormMode.edit)
            {
                this.Text = "Edit selected order";
                this.accept_button.Text = "Save changes";
            }
        }

        private void Accept_button_Click(object sender, EventArgs e)
        {
            string operation_string;
            if(Check_Input() == true)
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(MainWindowReference.GetConnectionString()))
                    {
                        int sender_id;

                        if (addNewSender_checkbox.Checked == true && newCity_checkbox.Checked == false)
                        {
                            sender_id = Insert_New_Sender(connection, city_listView.SelectedItems[0].Text);
                        }
                        else if (addNewSender_checkbox.Checked == true && newCity_checkbox.Checked == true)
                        {
                            string added_city = Insert_New_City(connection);
                            sender_id = Insert_New_Sender(connection, added_city);
                        }
                        else
                        {
                            sender_id = Convert.ToInt32(sender_ListView.SelectedItems[0].Text);
                        }

                        //if (this.current_mode == FormMode.add)
                        operation_string = "INSERT INTO Zlecenie VALUES(@courier_id, @sender_id, @order_date)";
                        if (this.current_mode == FormMode.edit)
                            operation_string = "UPDATE Zlecenie SET Id_kuriera = @courier_id, Id_klienta = @sender_id, Data_zlecenia=@order_date WHERE Id_zlecenia = @order_id";

                        using (SqlCommand command = new SqlCommand(operation_string, connection))
                        {
                            if (connection.State != ConnectionState.Open)
                            {
                                connection.Open();
                            }
                            command.Parameters.Add("@courier_id", SqlDbType.Int);
                            command.Parameters.Add("@sender_id", SqlDbType.Int);
                            command.Parameters.Add("@order_date", SqlDbType.Date).Value=orderDate_dateTimePicker.Value.Date;

                            command.Parameters["@courier_id"].Value = courier_ListView.SelectedItems[0].Text;
                            command.Parameters["@sender_id"].Value = sender_id;
                            if (this.current_mode == FormMode.edit)
                            {
                                command.Parameters.Add("@order_id", SqlDbType.Int);
                                command.Parameters["@order_id"].Value = this.edit_id;
                            }

                            int result = command.ExecuteNonQuery();

                            if (result == 0)
                            {
                                MessageClass.DisplayMessage(604);
                                //MessageBox.Show("Query failed! Please, try again later.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else if (result > 1)
                            {
                                MessageClass.DisplayMessage(703);
                                //MessageBox.Show("Query unexpected behaviour detected! Please contact your data base administrator and let them know about issue.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else if (result == 1 && this.current_mode == FormMode.add)
                                MessageClass.DisplayMessage(605); //MessageBox.Show("New order added successfully!", "Success", MessageBoxButtons.OK);
                            else if (result == 1 && this.current_mode == FormMode.edit)
                                MessageClass.DisplayMessage(606); //MessageBox.Show("Selected order updated successfully!", "Success", MessageBoxButtons.OK);
                        }

                    }
                    this.Close();
                    this.Dispose();
                }
                catch (Exception /*ex*/)
                {
                    if (this.current_mode == FormMode.add)
                        MessageClass.DisplayMessage(607); //MessageBox.Show("Failed to save new order's details." + ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else if (this.current_mode == FormMode.edit)
                        MessageClass.DisplayMessage(608); //MessageBox.Show("Failed to save changes to selected order.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Close();
                    this.Dispose();
                }
            }
            else
            {
                MessageClass.DisplayMessage(1112);
                //MessageBox.Show("Not all data was specified. Check your input for missing information.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }    
        }

        private string Insert_New_City(SqlConnection connection)
        {
            try
            {
                string command2_string = "INSERT INTO Miasto OUTPUT INSERTED.Nazwa_miasta VALUES(@city_name, " +
                                "(SELECT Id_strefy FROM Strefa WHERE Nazwa_strefy = @area));";

                using (SqlCommand command02 = new SqlCommand(command2_string, connection))
                {
                    if (connection.State != ConnectionState.Open)
                    {
                        connection.Open();
                    }
                    command02.Parameters.Add("@city_name", SqlDbType.NVarChar);
                    command02.Parameters.Add("@area", SqlDbType.NVarChar);
                    command02.Parameters["@city_name"].Value = newCityName_textBox.Text;
                    command02.Parameters["@area"].Value = newCityArea_listBox.SelectedItems[0].ToString();

                    string added_city = (string)command02.ExecuteScalar();
                    return added_city;
                }
            }
            catch (Exception)
            {
                MessageClass.DisplayMessage(1002);//MessageBox.Show("Failed to add new city during insertion of new order.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return "-";
            }

        }

        private int Insert_New_Sender(SqlConnection connection, string city_name)
        {
            int sender_id = 0;
            string command_string = "INSERT INTO Klient OUTPUT INSERTED.Id_klienta VALUES " +
                                "(@firstname, @lastname, @street, (SELECT Id_miasta FROM Miasto WHERE Nazwa_miasta = @city_name), " +
                                "@house_number, @apartment_number, @postal_code, @phone_number);";
            try
            {
                using (SqlCommand command01 = new SqlCommand(command_string, connection))
                {
                    if (connection.State != ConnectionState.Open)
                    {
                        connection.Open();
                    }
                    command01.Parameters.Add("@firstname", SqlDbType.NVarChar);
                    command01.Parameters.Add("@lastname", SqlDbType.NVarChar);
                    command01.Parameters.Add("@street", SqlDbType.NVarChar);
                    command01.Parameters.Add("@city_name", SqlDbType.NVarChar);
                    command01.Parameters.Add("@house_number", SqlDbType.NChar);
                    command01.Parameters.Add("@apartment_number", SqlDbType.Int);
                    command01.Parameters.Add("@postal_code", SqlDbType.NChar);
                    command01.Parameters.Add("@phone_number", SqlDbType.Char);

                    command01.Parameters["@firstname"].Value = firstName_textBox.Text;
                    command01.Parameters["@lastname"].Value = lastName_textBox.Text;
                    command01.Parameters["@street"].Value = street_TextBox.Text;
                    command01.Parameters["@city_name"].Value = city_name;//city_listView.SelectedItems[0].ToString();
                    command01.Parameters["@house_number"].Value = houseNumber_textBox.Text;
                    command01.Parameters["@apartment_number"].Value = apartmentNum_numeric.Value;
                    command01.Parameters["@postal_code"].Value = postalCode_textbox.Text;
                    command01.Parameters["@phone_number"].Value = phoneNumber_textBox.Text;

                    //string sender_id_string = (string)command01.ExecuteScalar();
                    sender_id = Convert.ToInt32(command01.ExecuteScalar());
                    return sender_id;
                }
            }
            catch (Exception)
            {
                MessageClass.DisplayMessage(802); //MessageBox.Show("Failed to add new customer during insertion of new order.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return -1;
            }
        }

        private void Cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        internal bool Check_Input()
        {
            bool result = true;

            if(courier_ListView.SelectedItems.Count != 1)
            {
                result = false;
            }

            if (sender_ListView.SelectedItems.Count != 1 && addNewSender_checkbox.Checked == false)
            {
                result = false;
            }
            if (addNewSender_checkbox.Checked == true)
            {
                if ((firstName_textBox.Text.Length == 0 || firstName_textBox.Text.Trim().Length == 0) && 
                    (lastName_textBox.Text.Length == 0 || lastName_textBox.Text.Trim().Length == 0) &&
                    (street_TextBox.Text.Length == 0 || street_TextBox.Text.Trim().Length == 0) &&
                    (houseNumber_textBox.Text.Length == 0 || houseNumber_textBox.Text.Trim().Length == 0) &&
                    (postalCode_textbox.Text.Length == 0 || postalCode_textbox.Text.Trim().Length == 0) &&
                    (city_listView.SelectedItems.Count != 1)) 
                result = false;

                if(newCity_checkbox.Checked == true && (newCityName_textBox.Text.Length == 0 || newCityName_textBox.Text.Trim().Length == 0)
                    && (newCityArea_listBox.SelectedItems.Count != 1))
                {
                    result = false;
                }
            }

            return result;
        }

        private void AddNewSender_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (addNewSender_checkbox.Checked == true)
            {
                Load_City_List();
                panel1.Enabled = true;
                panel1.Visible = true;
                sender_ListView.Enabled = false;
                sender_ListView.Visible = false;
                selectedSender_label.Text = "New sender";
            }
            else
            {
                panel1.Enabled = false;
                panel1.Visible = false;
                sender_ListView.Enabled = true;
                sender_ListView.Visible = true;
                if (sender_ListView.SelectedItems.Count == 1)
                {
                    selectedSender_label.Text = sender_ListView.SelectedItems[0].Text;
                }
                else
                {
                    selectedSender_label.Text = "None";
                }
            }
        }

        private void NewCity_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (newCity_checkbox.Checked == true)
            {
                Load_Area_List();
                city_listView.Enabled = false;
                newCityName_textBox.Enabled = true;
                newCityName_textBox.Visible = true;
                newCityName_label.Visible = true;
                newCityArea_listBox.Enabled = true;
                newCityArea_listBox.Visible = true;
                newCityArea_label.Visible = true;
            }
            else
            {
                city_listView.Enabled = true;
                newCityName_textBox.Enabled = false;
                newCityName_textBox.Visible = false;
                newCityName_label.Visible = false;
                newCityArea_listBox.Enabled = false;
                newCityArea_listBox.Visible = false;
                newCityArea_label.Visible = false;
            }
        }

        private void Courier_ListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if(courier_ListView.SelectedItems.Count == 1)
            {
                selectedCourier_label.Text = courier_ListView.SelectedItems[0].Text;
            }
            else
            {
                selectedCourier_label.Text = "None";
            }
            
        }

        private void ListView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (sender_ListView.SelectedItems.Count == 1)
            {
                selectedSender_label.Text = sender_ListView.SelectedItems[0].Text;
            }
            else
            {
                selectedSender_label.Text = "None";
            }
        }

    }
}
