using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ParcelDeliveryCompany_ClassLibrary1;
using System.Data.SqlClient;

namespace TestSQLServerProject01
{
    public partial class OrderManagementControl : UserControl
    {
        private UserClass mainW;

        public UserClass MainWindowReference { get => mainW; set => mainW = value; }

        

        public OrderManagementControl()
        {
            InitializeComponent();
        }

        private void AddOrder_button_Click(object sender, EventArgs e)
        {
            try
            {
                OrderAddEditForm addOrderForm = new OrderAddEditForm(MainWindowReference, 0, 0);
                addOrderForm.ShowDialog();
            }
            catch (Exception)
            {
                ErrorMessageClass.DisplayErrorMessage(602);
            }
        }

        internal void Load_Orders_List()
        {
            orders_ListView.Items.Clear();
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
                        for (int i=1; i< row.ItemArray.Count(); i++)
                        {
                            item.SubItems.Add(row[i].ToString());
                        }
                        orders_ListView.Items.Add(item);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                ErrorMessageClass.DisplayErrorMessage(601);
            }
        }

        private void EditOrder_button_Click(object sender, EventArgs e)
        {
            try
            {
                int order_id = Convert.ToInt32(orders_ListView.SelectedItems[0].Text);
                OrderAddEditForm addOrderForm = new OrderAddEditForm(MainWindowReference, 1, order_id);
                addOrderForm.ShowDialog();
            }
            catch (Exception)
            {
                ErrorMessageClass.DisplayErrorMessage(602);
            }
        }

        private void RemoveOrder_button_Click(object sender, EventArgs e)
        {

            DialogResult dlg_result = MessageBox.Show("DO you want to remove selected order?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlg_result == DialogResult.Yes)
            { 
                try
                {
                    int order_id = Convert.ToInt32(orders_ListView.SelectedItems[0].Text);
                    using (SqlConnection connection = new SqlConnection(MainWindowReference.GetConnectionString()))
                    using (SqlCommand command = new SqlCommand("DELETE FROM Zlecenie WHERE Id_zlecenia = @order_id", connection))
                    {
                        command.Parameters.Add("@order_id", SqlDbType.Int);
                        command.Parameters["@order_id"].Value = order_id;

                        if(connection.State != ConnectionState.Open)
                            connection.Open();

                        int result = command.ExecuteNonQuery();
                        if (result == 1)
                        {
                            MessageBox.Show("Selected order was removed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            throw new Exception("Failed to remove selected order. Try to remove parcels and consignments " +
                        "associated with this order first.");
                        }
                            
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Failed to remove selected order. Error occured! Try to remove parcels and consignments " +
                        "associated with this order first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Refresh_button_Click(object sender, EventArgs e)
        {
            Load_Orders_List();
        }

        private void Orders_ListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (orders_ListView.SelectedItems.Count == 1)
            {
                //consignment_button.Enabled = true;
                editOrder_button.Enabled = true;
                removeOrder_button.Enabled = true;
            }
            else
            {
                //consignment_button.Enabled = false;
                editOrder_button.Enabled = false;
                removeOrder_button.Enabled = false;
            }
        }
    }
}
