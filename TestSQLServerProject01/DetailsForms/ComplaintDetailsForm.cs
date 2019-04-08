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
    public partial class ComplaintDetailsForm : Form
    {
        private UserClass mainW;
        internal UserClass MainWindowReference { get => mainW; set => mainW = value; }

        private int object_id;

        public ComplaintDetailsForm()
        {
            InitializeComponent();
        }

        public ComplaintDetailsForm(UserClass mW, int object_id)
        {
            InitializeComponent();
            MainWindowReference = mW;
            this.object_id = object_id;
            Load_Complaint_Data(object_id);
            Load_Complaint_State_List();
            /*parcelManagement_Controler.MainWindowReference = mW;
            parcelManagement_Controler.Load_Parcels_List(object_id);
            Load_Pickup_State_List();
            Load_Consignment_Data(object_id);*/
        }

        private void Load_Complaint_State_List()
        {
            try
            {
                DataTable dt = new DataTable();
                using (SqlConnection connection = new SqlConnection(MainWindowReference.GetConnectionString()))
                using (SqlCommand command = new SqlCommand("SELECT * FROM Stan_reklamacji", connection))
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
                        complaintState_listView.Items.Add(item);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Could not load complaint states' list.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Load_Complaint_Data(int object_id)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(MainWindowReference.GetConnectionString()))
                using (SqlCommand command = new SqlCommand("SELECT * FROM Complaint_Details_View WHERE Id_zgloszenia_reklamacji = @item_id", connection))
                {
                    command.Parameters.Add("@item_id", SqlDbType.Int);
                    command.Parameters["@item_id"].Value = object_id;
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        if (connection.State != ConnectionState.Open)
                        {
                            connection.Open();
                        }
                        adapter.Fill(dt);

                        consignmentID_textbox.Text = dt.Rows[0].ItemArray[1].ToString();
                        consigneeID_textBox.Text = dt.Rows[0].ItemArray[2].ToString();
                        consigneeFullName_textbox.Text = dt.Rows[0].ItemArray[3].ToString();
                        ComplaintState_textbox.Text = dt.Rows[0].ItemArray[5].ToString();
                        complaintRegisrationDate_textbox.Text = dt.Rows[0].ItemArray[4].ToString();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //ErrorMessageClass.DisplayErrorMessage(6056);
                this.Close();
                this.Dispose();
            }
        }

        private void UpdatePickupRequestState_button_Click(object sender, EventArgs e)
        {
            DialogResult dlg_result = MessageBox.Show("Are you sure you want to change state of this complaint?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlg_result == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(MainWindowReference.GetConnectionString()))
                    using (SqlCommand command = new SqlCommand("UPDATE Zgloszenia_reklamacji SET Id_stanu_reklamacji = @complaint_state_id WHERE Id_zgloszenia_reklamacji = @item_id", connection))
                    {
                        command.Parameters.Add("@complaint_state_id", SqlDbType.Int);
                        command.Parameters.Add("@item_id", SqlDbType.Int);
                        command.Parameters["@complaint_state_id"].Value = Convert.ToInt32(complaintState_listView.SelectedItems[0].Text);
                        command.Parameters["@item_id"].Value = this.object_id;

                        connection.Open();

                        int result = command.ExecuteNonQuery();
                        if (result == 1)
                        {
                            ComplaintState_textbox.Text = complaintState_listView.SelectedItems[0].SubItems[1].Text;
                            complaintState_listView.SelectedItems.Clear();
                            MessageBox.Show("Complaint has been updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Failed to update complaint's data.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Failed to initiate complaint's update. Error occured.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void ComplaintState_listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (complaintState_listView.SelectedItems.Count == 1)
            {
                if (complaintState_listView.SelectedItems[0].SubItems[1].Text.Equals(ComplaintState_textbox.Text))
                {
                    updateComplaintState_button.Enabled = false;
                }
                else
                {
                    updateComplaintState_button.Enabled = true;
                }
            }
            else
            {
                updateComplaintState_button.Enabled = false;
            }
        }
    }
}
