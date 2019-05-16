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
    public partial class PickupRequestAddEditForm : Form
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

        public PickupRequestAddEditForm()
        {
            InitializeComponent();
        }

        public PickupRequestAddEditForm(UserClass mW, int mode, int edited_id)
        {
            InitializeComponent();
            this.MainWindowReference = mW;
            ToggleMode((FormMode)mode);
            Load_List_Data();

            if(current_mode == FormMode.edit)
            {
                this.edited_id = edited_id;
                Load_Edited_Item(edited_id);
            }

        }

        private void Load_List_Data()
        {
            courier_ListView.Items.Clear();
            orders_ListView.Items.Clear();

            try
            {            
                DataTable dt = new DataTable();
                DataTable dt1 = new DataTable();
                using (SqlConnection connection = new SqlConnection(MainWindowReference.GetConnectionString()))
                using (SqlCommand command = new SqlCommand("SELECT Id_kuriera, Id_pojazdu, Imie, Nazwisko  FROM Kurier", connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    adapter.Fill(dt);

                    //wczytywanie listy kurierów
                    foreach (DataRow row in dt.Rows)
                    {
                        ListViewItem item = new ListViewItem(row[0].ToString());

                        foreach (object row_item in row.ItemArray)
                        {
                            for (int i = 1; i < row.ItemArray.Count(); i++)
                            {
                                item.SubItems.Add(row[i].ToString());
                            }
                        }
                        courier_ListView.Items.Add(item);
                    }

                    //wczytywyanie listy zamówień
                    adapter.SelectCommand.CommandText = "SELECT * FROM Orders_detailed_list_View";
                    adapter.Fill(dt1);

                    foreach (DataRow row in dt1.Rows)
                    {
                        ListViewItem item = new ListViewItem(row[0].ToString());
                        for (int i = 1; i < row.ItemArray.Count(); i++)
                        {
                            item.SubItems.Add(row[i].ToString());
                        }
                        orders_ListView.Items.Add(item);
                    }

                }
            }
            catch (Exception)
            {
                MessageClass.DisplayMessage(1501); //MessageBox.Show("Could not load couriers or orders' list.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
                this.Dispose();
            }
        }

        

        private void Load_Edited_Item(int edited_id)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(MainWindowReference.GetConnectionString()))
                using (SqlCommand command = new SqlCommand("SELECT * FROM Zgloszenia_odbioru WHERE Id_zgloszenia_odbioru = @item_id", connection)) // Consignment_Edit_View WHERE Id_przesylki = @item_id", connection))
                {
                    command.Parameters.Add("@item_id", SqlDbType.Int);
                    command.Parameters["@item_id"].Value = edited_id;
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        if (connection.State != ConnectionState.Open)
                        {
                            connection.Open();
                        }
                        adapter.Fill(dt);
                        foreach (DataRow row in dt.Rows)
                        {
                            foreach (ListViewItem order in orders_ListView.Items)
                            {
                                if (order.Text.Equals(row[1].ToString()))
                                {
                                    int temp_id = order.Index;
                                    orders_ListView.Items[temp_id].Selected = true;
                                    orders_ListView.Focus();
                                    break;
                                }
                            }

                            foreach (ListViewItem courier in courier_ListView.Items)
                            {
                                if (courier.Text.Equals(row[4].ToString()))
                                {
                                    int temp_id = courier.Index;
                                    courier_ListView.Items[temp_id].Selected = true;
                                    courier_ListView.Focus();
                                    break;
                                }
                            }

                            dateTimePicker1.Value = Convert.ToDateTime(row[2].ToString());
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageClass.DisplayMessage(1502);//MessageBox.Show("Could not load selected pickup request's data.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
                this.Dispose();
            }
        }

        private void ToggleMode(FormMode current_mode)
        {
            this.current_mode = (FormMode)current_mode;
            if (current_mode == FormMode.add)
            {
                this.Text = "Add new pickup request";
                accept_button.Text = "Add pickup request";
            }
            else if (current_mode == FormMode.edit)
            {
                this.Text = "Edit pickup request";
                accept_button.Text = "Save changes";
            }
        }

        private void Accept_button_Click(object sender, EventArgs e)
        {
            if (Check_Input() == true)
            {
                
                try
                {
                    string insert_command = "INSERT INTO Zgloszenia_odbioru VALUES (@order_id, @pckreq_date, @pckreq_state_id, @courier_id);";
                    string update_command = "UPDATE Zgloszenia_odbioru SET Id_zlecenia = @order_id, Data_zlecenia_odbioru = @pckreq_date, Id_kuriera = @courier_id WHERE Id_zgloszenia_odbioru = @item_id;";

                    string executed_command = insert_command;
                    if (current_mode == FormMode.edit)
                    {
                        executed_command = update_command;
                    }
                    using (SqlConnection connection = new SqlConnection(MainWindowReference.GetConnectionString()))
                    using (SqlCommand command = new SqlCommand(executed_command, connection))
                    {
                        command.Parameters.Add("@order_id", SqlDbType.Int);
                        command.Parameters.Add("@pckreq_date", SqlDbType.DateTime);
                        command.Parameters.Add("@pckreq_state_id", SqlDbType.Int);
                        command.Parameters.Add("@courier_id", SqlDbType.Int);

                        command.Parameters["@order_id"].Value = orders_ListView.SelectedItems[0].Text;
                        command.Parameters["@pckreq_date"].Value = dateTimePicker1.Value;
                        command.Parameters["@pckreq_state_id"].Value = 1;
                        command.Parameters["@courier_id"].Value = courier_ListView.SelectedItems[0].Text;

                        if (current_mode == FormMode.edit)
                        {
                            command.Parameters.Add("@item_id", SqlDbType.Int);
                            command.Parameters["@item_id"].Value = edited_id;
                        }

                        if (connection.State != ConnectionState.Open)
                        {
                            connection.Open();
                        }

                        int result = command.ExecuteNonQuery();

                        if (result == 0)
                        {
                            if (current_mode == FormMode.add)
                                MessageClass.DisplayMessage(1503); //MessageBox.Show("Failed to add new pickup request.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            if (current_mode == FormMode.edit)
                                MessageClass.DisplayMessage(1504); //MessageBox.Show("Failed to save changes to seleceted pickup request.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        if (result == 1)
                        {
                            if (current_mode == FormMode.add)
                                MessageClass.DisplayMessage(1505); //MessageBox.Show("New pickup request has been added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            if (current_mode == FormMode.edit)
                                MessageClass.DisplayMessage(1506); //MessageBox.Show("Changes to seleceted pickup request has been saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch
                {
                    if (current_mode == FormMode.add)
                        MessageClass.DisplayMessage(1507); //MessageBox.Show("Failed to add new pickup request. Error occured!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (current_mode == FormMode.edit)
                        MessageClass.DisplayMessage(1508); //MessageBox.Show("Failed to save changes to selected pickup request. Error occured!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                this.Close();
                this.Dispose();
            }
            else
            {
                MessageClass.DisplayMessage(1509); 
            }
        }

        private bool Check_Input()
        {
            bool result = true;

            if (orders_ListView.SelectedItems.Count != 1 || courier_ListView.SelectedItems.Count != 1)
                result = false;

            return result;
        }

        private void Cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
