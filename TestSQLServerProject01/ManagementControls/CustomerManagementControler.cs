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
using static ParcelDeliveryCompany_ClassLibrary1.UserClass;

namespace TestSQLServerProject01
{
    public partial class CustomerManagementControler : UserControl
    {
        private UserClass mainW;
        public UserClass MainWindowReference { get => mainW; set => mainW = value; }

        public CustomerManagementControler()
        {
            InitializeComponent();
        }

        internal void Load_Customer_List()
        {
            customer_ListView.Items.Clear();
            try
            {
                DataTable dt = new DataTable();
                using (SqlConnection connection = new SqlConnection(MainWindowReference.GetConnectionString()))
                using (SqlCommand command = new SqlCommand("SELECT * FROM Customers_View", connection))
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
                        customer_ListView.Items.Add(item);
                    }
                }
            }
            catch (Exception /*ex*/)
            {
                MessageClass.DisplayMessage(802); //MessageBox.Show("Could not load customers' list.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CustomerSearch_button_Click(object sender, EventArgs e)
        {
            try
            {
                Load_Customer_List();

                ListViewItem found_item = null;
                List<ListViewItem> items_arr = new List<ListViewItem>();
                int search_index = 0;
                do
                {
                    found_item = null;
                    if (search_index < customer_ListView.Items.Count)
                    {
                        found_item = customer_ListView.FindItemWithText(searchCustomer_textBox.Text, true, search_index);
                    }

                    if (found_item != null)
                    {
                        items_arr.Add(found_item);
                        search_index = found_item.Index + 1;
                    }
                }
                while (found_item != null);

                customer_ListView.Items.Clear();
                foreach (ListViewItem item in items_arr)
                {
                    if (item.SubItems[customerColumns_listbox.SelectedIndex].Text.Contains(searchCustomer_textBox.Text))
                    {
                        customer_ListView.Items.Add(item);
                    }
                }
            }
            catch (Exception /*ex*/)
            {
                //MessageBox.Show(/*ex.Message + */"Error occured during an attemmpt to search for\nspecified items in customers' list.");
                MessageClass.DisplayMessage(803);
            }

        }

        private void ClearFilter_button_Click(object sender, EventArgs e)
        {
            searchCustomer_textBox.Clear();
            customerColumns_listbox.SelectedItems.Clear();
            Load_Customer_List();
        }

        private void CustomerColumns_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((searchCustomer_textBox.Text.Length != 0 && searchCustomer_textBox.Text.Trim().Length != 0) && customerColumns_listbox.SelectedItems.Count == 1)
            {
                customerSearch_button.Enabled = true;
                customerFilter_button.Enabled = true;
            }
            else
            {
                customerSearch_button.Enabled = false;
                customerFilter_button.Enabled = false;
            }
        }

        private void SearchCustomer_textBox_TextChanged(object sender, EventArgs e)
        {
            if ((searchCustomer_textBox.Text.Length != 0 && searchCustomer_textBox.Text.Trim().Length != 0) && customerColumns_listbox.SelectedItems.Count == 1)
            {
                customerSearch_button.Enabled = true;
                customerFilter_button.Enabled = true;
            }
            else
            {
                customerSearch_button.Enabled = false;
                customerFilter_button.Enabled = false;
            }
        }

        private void Addnew_button_Click(object sender, EventArgs e)
        {
            try
            {
                CustomerAddEditForm new_customer_form = new CustomerAddEditForm(MainWindowReference, 0, 0);
                new_customer_form.ShowDialog();
            }
            catch
            {
                //MessageBox.Show("Failed to initialize customer add/edit form.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageClass.DisplayMessage(804);
            }
            Load_Customer_List();
        }

        private void Edit_button_Click(object sender, EventArgs e)
        {
            try
            {
                CustomerAddEditForm edit_customer_form = new CustomerAddEditForm(MainWindowReference, 1, Convert.ToInt32(customer_ListView.SelectedItems[0].Text));
                edit_customer_form.ShowDialog();
            }
            catch (Exception)
            {
                //MessageBox.Show("Failed to initialize customer add/edit form.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageClass.DisplayMessage(804);
            }
            Load_Customer_List();
        }

        private void Remove_button_Click(object sender, EventArgs e)
        {
            if (customer_ListView.SelectedItems.Count == 1)
            {
                DialogResult dlg_result = MessageClass.DisplayMessage(805, "customer"); //MessageBox.Show("Are you sure you want to remove this customer?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlg_result == DialogResult.Yes)
                {
                    try
                    {
                        int id_to_remove = Convert.ToInt32(customer_ListView.SelectedItems[0].Text);
                        using (SqlConnection connection = new SqlConnection(MainWindowReference.GetConnectionString()))
                        using (SqlCommand command = new SqlCommand("DELETE FROM Klient WHERE Id_klienta=@customer_id", connection))
                        {
                            command.Parameters.Add("@customer_id", SqlDbType.Int);
                            command.Parameters["@customer_id"].Value = id_to_remove;

                            connection.Open();
                            int result = command.ExecuteNonQuery();

                            if (result != 1)
                                MessageClass.DisplayMessage(806);//MessageBox.Show("Failed to remove selected customer! Check if customer is assigned to orders, consignments, pickup requests and/or complaints.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            else if (result == 1)
                                MessageClass.DisplayMessage(807); //MessageBox.Show("Customer removed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception)
                    {
                        MessageClass.DisplayMessage(808); //MessageBox.Show("Error occured during an attempt to remove selected customer! .", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    Load_Customer_List();
                }
            }
        }

        private void Refresh_button_Click(object sender, EventArgs e)
        {
            Load_Customer_List();
        }

        private void Customer_ListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (customer_ListView.SelectedItems.Count == 1)
            {
                edit_button.Enabled = true;
                remove_button.Enabled = true;
            }
            else
            {
                edit_button.Enabled = false;
                remove_button.Enabled = false;
            }
        }

        protected internal void SetUserRole(/*int user_role*/)
        {
            addnew_button.Enabled = false;
            addnew_button.Visible = false;
            edit_button.Enabled = false;
            edit_button.Visible = false;
            remove_button.Enabled = false;
            remove_button.Visible = false;
            refresh_button.Enabled = false;
            refresh_button.Visible = false;
            UserRole user = (UserRole)this.MainWindowReference.Current_role;

            if(user == UserRole.Admin)
            {
                addnew_button.Enabled = true;
                addnew_button.Visible = true;
                edit_button.Visible = true;
                remove_button.Visible = true;
                refresh_button.Enabled = true;
                refresh_button.Visible = true;
            }
            if (user == UserRole.CustomerContact)
            {
                addnew_button.Enabled = true;
                addnew_button.Visible = true;
                //edit_button.Visible = true;
                refresh_button.Enabled = true;
                refresh_button.Visible = true;
            }
            else if (user == UserRole.Dispatcher)
            {
                refresh_button.Enabled = true;
                refresh_button.Visible = true;
            }
            else if (user == UserRole.Courier)
            {

            }
            else if (user == UserRole.OrderManager)
            {
                addnew_button.Enabled = true;
                addnew_button.Visible = true;
                edit_button.Visible = true;
                refresh_button.Enabled = true;
                refresh_button.Visible = true;
            }
        }
    }
}
