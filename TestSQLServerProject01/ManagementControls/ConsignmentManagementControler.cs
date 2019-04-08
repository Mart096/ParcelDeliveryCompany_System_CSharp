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

namespace TestSQLServerProject01
{
    public partial class ConsignmentManagementControler : UserControl
    {
        private UserClass mainW;

        public UserClass MainWindowReference { get => mainW; set => mainW = value; }

        public ConsignmentManagementControler()
        {
            InitializeComponent();
        }

        internal void Load_Consignments_List()
        {
            consignment_ListView.Items.Clear();
            try
            {
                DataTable dt = new DataTable();
                using (SqlConnection connection = new SqlConnection(MainWindowReference.GetConnectionString()))
                using (SqlCommand command = new SqlCommand("SELECT * FROM Consignment_Detailed_List_View", connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    adapter.Fill(dt);

                    foreach (DataRow row in dt.Rows)
                    {
                        ListViewItem item = new ListViewItem(row[0].ToString());

                        for (int i = 1; i<row.ItemArray.Count(); i++)
                        {
                            item.SubItems.Add(row[i].ToString());
                        }
                        consignment_ListView.Items.Add(item);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Could not load consignments' list.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Refresh_button_Click(object sender, EventArgs e)
        {
            Load_Consignments_List();
        }

        private void Consignment_ListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (consignment_ListView.SelectedItems.Count == 1)
            {
                details_button.Enabled = true;
                editConsignment_button.Enabled = true;
                removeConsignment_button.Enabled = true;
            }
            else
            {
                details_button.Enabled = false;
                editConsignment_button.Enabled = false;
                removeConsignment_button.Enabled = false;
            }
        }

        private void AddConsignment_button_Click(object sender, EventArgs e)
        {
            try
            {
                ConsignmentAddEditUpdateForm addform = new ConsignmentAddEditUpdateForm(MainWindowReference, 0, 0);
                addform.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Error! Could not initialize consignment's add/edit form.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Details_button_Click(object sender, EventArgs e)
        {
            try
            {
                ConsignmentDetailsForm consignment_details_form = new ConsignmentDetailsForm(MainWindowReference, Convert.ToInt32(consignment_ListView.SelectedItems[0].Text));
                consignment_details_form.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Error! Could not initialize consignment's details form.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditConsignment_button_Click(object sender, EventArgs e)
        {
            try
            {
                ConsignmentAddEditUpdateForm editform = new ConsignmentAddEditUpdateForm(MainWindowReference, 1, Convert.ToInt32(consignment_ListView.SelectedItems[0].Text));
                editform.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Error! Could not initialize consignment's add/edit form.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RemoveConsignment_button_Click(object sender, EventArgs e)
        {
            if (consignment_ListView.SelectedItems.Count == 1)
            {
                DialogResult dlg_result = MessageBox.Show("Are you sure you want to remove this consignment?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlg_result == DialogResult.Yes)
                {
                    try
                    {
                        int id_to_remove = Convert.ToInt32(consignment_ListView.SelectedItems[0].Text);
                        using (SqlConnection connection = new SqlConnection(MainWindowReference.GetConnectionString()))
                        using (SqlCommand command = new SqlCommand("DELETE FROM Przesylka WHERE Id_przesylki=@consignment_id", connection))
                        {
                            command.Parameters.Add("@consignment_id", SqlDbType.Int);
                            command.Parameters["@consignment_id"].Value = id_to_remove;

                            connection.Open();
                            int result = command.ExecuteNonQuery();

                            if (result != 1)
                            {
                                //ErrorMessageClass.DisplayErrorMessage(502);
                                MessageBox.Show("Failed to remove selected consignment! Check if consignment has assigned parcels.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else if (result == 1)
                                MessageBox.Show("Consignment removed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception)
                    {
                        //ErrorMessageClass.DisplayErrorMessage(502);
                    }
                    Load_Consignments_List();
                }
            }
        }

        private void Refresh_button_Click_1(object sender, EventArgs e)
        {
            Load_Consignments_List();
        }
    }
}
