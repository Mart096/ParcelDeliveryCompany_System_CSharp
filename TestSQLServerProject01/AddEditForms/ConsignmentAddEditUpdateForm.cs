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
    public partial class ConsignmentAddEditUpdateForm : Form
    {
        private UserClass mainW;
        public UserClass MainWindowReference { get => mainW; set => mainW = value; }

        FormMode current_mode = FormMode.add;
        private int edit_id;

        enum FormMode
        {
            add = 0,
            edit = 1
        };

        public ConsignmentAddEditUpdateForm()
        {
            InitializeComponent();
        }

        public ConsignmentAddEditUpdateForm(UserClass mW, int mode, int id_to_edit)
        {
            InitializeComponent();
            MainWindowReference = mW;
            customerAddEdit_controler.MainWindowReference = mW;

            Toggle_Form_Mode((FormMode)mode);
            Load_Orders_List();
            Load_Consignee_List();
            Load_PickupMethod_List();
            Load_ConsignmentType_List();

            if (this.current_mode == FormMode.edit)
            {
                this.edit_id = id_to_edit;
                Load_Edited_Consignment_Data(this.edit_id);
            }
        }


        private void Toggle_Form_Mode(FormMode mode)
        {
            this.current_mode = mode;

            if (this.current_mode == FormMode.add)
            {
                this.Text = "Add new consignment";
                this.accept_button.Text = "Add consignment";
            }
            else if (this.current_mode == FormMode.edit)
            {
                this.Text = "Edit selected consginment";
                this.accept_button.Text = "Save changes";
            }
        }

        internal void Load_Orders_List()
        {
            order_ListView.Items.Clear();
            try
            {
                DataTable dt = new DataTable();
                using (SqlConnection connection = new SqlConnection(MainWindowReference.GetConnectionString()))
                using (SqlCommand command = new SqlCommand("SELECT * FROM Orders_detailed_list_View", connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    adapter.Fill(dt);

                    foreach (DataRow row in dt.Rows)
                    {
                        ListViewItem item = new ListViewItem(row[0].ToString());
                        for (int i = 1; i < row.ItemArray.Count(); i++)
                        {
                            item.SubItems.Add(row[i].ToString());
                        }
                        order_ListView.Items.Add(item);
                    }
                }
            }
            catch (Exception)
            {
                ErrorMessageClass.DisplayErrorMessage(601);
            }
        }

        private void Load_Consignee_List()
        {
            consignee_ListView.Items.Clear();
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

                        for (int i=1; i<row.ItemArray.Count(); i++)
                        { 
                            item.SubItems.Add(row[i].ToString());
                        }
                        consignee_ListView.Items.Add(item);
                    }
                }
            }
            catch (Exception /*ex*/)
            {
                MessageBox.Show("Could not load consignees' list.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        internal void Load_PickupMethod_List()
        {
            pickupMethodlistView.Items.Clear();
            try
            {
                DataTable dt = new DataTable();
                using (SqlConnection connection = new SqlConnection(MainWindowReference.GetConnectionString()))
                using (SqlCommand command = new SqlCommand("SELECT * FROM Forma_odbioru", connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    adapter.Fill(dt);

                    foreach (DataRow row in dt.Rows)
                    {
                        ListViewItem item = new ListViewItem(row[0].ToString());

                        for (int i = 1; i < row.ItemArray.Count(); i++)
                        {
                            item.SubItems.Add(row[i].ToString());
                        }
                        pickupMethodlistView.Items.Add(item);
                    }
                }
            }
            catch (Exception /*ex*/)
            {
                MessageBox.Show("Could not load pickup methods' list.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        internal void Load_ConsignmentType_List()
        {
            consignmentType_ListView.Items.Clear();
            try
            {
                DataTable dt = new DataTable();
                using (SqlConnection connection = new SqlConnection(MainWindowReference.GetConnectionString()))
                using (SqlCommand command = new SqlCommand("SELECT * FROM Typ_przesylki", connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    adapter.Fill(dt);

                    foreach (DataRow row in dt.Rows)
                    {
                        ListViewItem item = new ListViewItem(row[0].ToString());

                        for (int i = 1; i < row.ItemArray.Count(); i++)
                        {
                            item.SubItems.Add(row[i].ToString());
                        }
                        consignmentType_ListView.Items.Add(item);
                    }
                }
            }
            catch (Exception /*ex*/)
            {
                MessageBox.Show("Could not load pickup consignment types' list.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Load_Edited_Consignment_Data(int edit_id)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(MainWindowReference.GetConnectionString()))
                using (SqlCommand command = new SqlCommand("SELECT * FROM Consignment_Edit_View WHERE Id_przesylki = @consignment_id", connection))
                {
                    command.Parameters.Add("@consignment_id", SqlDbType.Int);
                    command.Parameters["@consignment_id"].Value = edit_id;
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        if (connection.State != ConnectionState.Open)
                        {
                            connection.Open();
                        }
                        adapter.Fill(dt);
                        foreach (DataRow row in dt.Rows)
                        {
                            foreach (ListViewItem order in order_ListView.Items)
                            {
                                if (order.Text.Equals(row[1].ToString()))
                                {
                                    int temp_id = order.Index;
                                    order_ListView.Items[temp_id].Selected = true;
                                    order_ListView.Focus();
                                    break;
                                }
                            }

                            foreach (ListViewItem consignee in consignee_ListView.Items)
                            {
                                if (consignee.Text.Equals(row[2].ToString()))
                                {
                                    int temp_id = consignee.Index;
                                    consignee_ListView.Items[temp_id].Selected = true;
                                    consignee_ListView.Focus();
                                    break;
                                }
                            }

                            foreach (ListViewItem pickup_method in pickupMethodlistView.Items)
                            {
                                if (pickup_method.Text.Equals(row[3].ToString()))
                                {
                                    int temp_id = pickup_method.Index;
                                    pickupMethodlistView.Items[temp_id].Selected = true;
                                    pickupMethodlistView.Focus();
                                    break;
                                }
                            }

                            foreach (ListViewItem consignment_type in consignmentType_ListView.Items)
                            {
                                if (consignment_type.Text.Equals(row[4].ToString()))
                                {
                                    int temp_id = consignment_type.Index;
                                    consignmentType_ListView.Items[temp_id].Selected = true;
                                    consignmentType_ListView.Focus();
                                    break;
                                }
                            }
                        }
                    }
                }

            }
            catch (Exception)
            {
                //MessageBox.Show(ex.Message);
                ErrorMessageClass.DisplayErrorMessage(6056);
                this.Close();
                this.Dispose();
            }
        }

        internal bool Check_Input()
        {
            bool result = true;

            if (order_ListView.SelectedItems.Count != 1)
            {
                result = false;
            }

            if (consignee_ListView.SelectedItems.Count != 1 && addNewConsignee_checkbox.Checked == false)
            {
                result = false;
            }
            if (addNewConsignee_checkbox.Checked == true)
            {
                if (customerAddEdit_controler.Check_Input() == false)
                {
                    result = false;
                }
            }
            
            if(pickupMethodlistView.SelectedItems.Count !=1  || consignmentType_ListView.SelectedItems.Count != 1)
            {
                result = false;
            }

            return result;
        }

        private void Accept_button_Click(object sender, EventArgs e)
        {
            string operation_string;
            int pickup_state;
            if (Check_Input() == true)
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(MainWindowReference.GetConnectionString()))
                    {
                        int consignee_id;

                        if (addNewConsignee_checkbox.Checked == true /*&& newCity_checkbox.Checked == false*/)
                        {
                            consignee_id = customerAddEdit_controler.Insert_New_Sender(connection);//, city_listView.SelectedItems[0].Text);
                        }
                        else
                        {
                            consignee_id = Convert.ToInt32(consignee_ListView.SelectedItems[0].Text);
                        }
                        
                        operation_string = "INSERT INTO Przesylka VALUES(@order_id, @consignee_id, " +
                                "@pickup_state_id, @pickup_method_id, @consignment_type_id)";
                        pickup_state = 1;

                        if (this.current_mode == FormMode.edit)
                        {
                            operation_string = "UPDATE Przesylka SET Id_zlecenia = @order_id, " +
                                "Id_klienta = @consignee_id, Id_formy_odbioru = @pickup_method_id, " +
                                "Id_typu_przesylki = @consignment_type_id WHERE Id_przesylki = @consignment_id";
                        }
                            

                        using (SqlCommand command = new SqlCommand(operation_string, connection))
                        {
                            if (connection.State != ConnectionState.Open)
                            {
                                connection.Open();
                            }
                            command.Parameters.Add("@order_id", SqlDbType.Int);
                            command.Parameters.Add("@consignee_id", SqlDbType.Int);
                            command.Parameters.Add("@pickup_method_id", SqlDbType.Int);
                            command.Parameters.Add("@consignment_type_id", SqlDbType.Int);

                            command.Parameters["@order_id"].Value = Convert.ToInt32(order_ListView.SelectedItems[0].Text);
                            command.Parameters["@consignee_id"].Value = consignee_id;
                            command.Parameters["@pickup_method_id"].Value = Convert.ToInt32(pickupMethodlistView.SelectedItems[0].Text);
                            command.Parameters["@consignment_type_id"].Value = Convert.ToInt32(consignmentType_ListView.SelectedItems[0].Text);

                            if (this.current_mode == FormMode.add)
                            {
                                command.Parameters.Add("@pickup_state_id", SqlDbType.Int);
                                command.Parameters["@pickup_state_id"].Value = pickup_state;
                            }

                            if (this.current_mode == FormMode.edit)
                            {
                                command.Parameters.Add("@consignment_id", SqlDbType.Int);
                                command.Parameters["@consignment_id"].Value = this.edit_id;
                            }

                            int result = command.ExecuteNonQuery();

                            if (result == 0)
                            {
                                ErrorMessageClass.DisplayErrorMessage(6044);
                                MessageBox.Show("Query failed! Please, try again later.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else if (result > 1)
                            {
                                ErrorMessageClass.DisplayErrorMessage(6044);
                                MessageBox.Show("Query unexpected behaviour detected! Please contact your data base administrator and let them know about issue.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else if (result == 1 && this.current_mode == FormMode.add)
                                MessageBox.Show("New consignment added successfully!", "Success", MessageBoxButtons.OK);
                            else if (result == 1 && this.current_mode == FormMode.edit)
                                MessageBox.Show("Selected consignment has been updated successfully!", "Success", MessageBoxButtons.OK);
                        }

                    }
                    this.Close();
                    this.Dispose();
                }
                catch (Exception ex)
                {
                    if (this.current_mode == FormMode.add)
                        MessageBox.Show("Failed to save new order's details." + ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else if (this.current_mode == FormMode.edit)
                        MessageBox.Show("Failed to save changes to selected order.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Close();
                    this.Dispose();
                }
            }
            else
            {
                MessageBox.Show("Not all data was specified. Check your input for missing information.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
            private void Cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void AddNewConsignee_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (addNewConsignee_checkbox.Checked == true)
            {
                customerAddEdit_controler.Load_City_List();
                customerAddEdit_controler.Enabled = true;
                customerAddEdit_controler.Visible = true;
                consigneeListView_panel.Enabled = false;
                consigneeListView_panel.Visible = false;
            }
            else
            {
                customerAddEdit_controler.Enabled = false;
                customerAddEdit_controler.Visible = false;
                consigneeListView_panel.Enabled = true;
                consigneeListView_panel.Visible = true;
            }
        }

        private void ConsigneeSearch_button_Click(object sender, EventArgs e)
        {
            try
            {
                Load_Consignee_List();

                ListViewItem found_item = null;
                List<ListViewItem> items_arr = new List<ListViewItem>();
                int search_index=0;
                do
                {
                    found_item = null;
                    if (search_index < consignee_ListView.Items.Count)
                    {
                        found_item = consignee_ListView.FindItemWithText(searchConsignee_textBox.Text, true, search_index);
                    }

                    if (found_item != null)
                    {
                        items_arr.Add(found_item);
                        search_index = found_item.Index + 1;
                    }
                }
                while (found_item != null);

                consignee_ListView.Items.Clear();
                foreach (ListViewItem item in items_arr)
                {
                    if (item.SubItems[consigneeColumns_listbox.SelectedIndex].Text.Contains(searchConsignee_textBox.Text))
                    {
                        consignee_ListView.Items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message+"Error occured during an attemmpt to search for\nspecified items in consignees' list.");
            }
            
        }

        private void ClearFilter_button_Click(object sender, EventArgs e)
        {
            searchConsignee_textBox.Clear();
            consigneeColumns_listbox.SelectedItems.Clear();
            Load_Consignee_List();
        }

        private void ConsigneeColumns_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if((searchConsignee_textBox.Text.Length != 0 && searchConsignee_textBox.Text.Trim().Length != 0) && consigneeColumns_listbox.SelectedItems.Count == 1)
            {
                consigneeSearch_button.Enabled = true;
                clearFilter_button.Enabled = true;
            }
            else
            {
                consigneeSearch_button.Enabled = false;
                clearFilter_button.Enabled = false;
            }
        }

        private void SearchConsignee_textBox_TextChanged(object sender, EventArgs e)
        {
            if ((searchConsignee_textBox.Text.Length != 0 && searchConsignee_textBox.Text.Trim().Length != 0) && consigneeColumns_listbox.SelectedItems.Count == 1)
            {
                consigneeSearch_button.Enabled = true;
                clearFilter_button.Enabled = true;
            }
            else
            {
                consigneeSearch_button.Enabled = false;
                clearFilter_button.Enabled = false;
            }
        }
    }
}
