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
    public partial class CourierManagementControl : UserControl
    {
        private UserClass MainW;

        public UserClass MainWindowReference { get => MainW; set => MainW = value; }

        public CourierManagementControl()
        {
            InitializeComponent();
        }

        private void Courier_ListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (courier_ListView.SelectedItems.Count == 1)
            {
                editCourier_button.Enabled = true;
                removeCourier_button.Enabled = true;
                //assignVehicle_To_Courier_button.Enabled = true;
            }
            else
            {
                editCourier_button.Enabled = false;
                removeCourier_button.Enabled = false;
                //assignVehicle_To_Courier_button.Enabled = false;
            }
        }

        internal void Load_Couriers_Data()
        {
            courier_ListView.Items.Clear();
            try
            {
                DataTable dt = new DataTable();
                using (SqlConnection connection = new SqlConnection(MainW.GetConnectionString()))
                using (SqlCommand command = new SqlCommand("SELECT * FROM Kurier", connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    adapter.Fill(dt);

                    foreach (DataRow row in dt.Rows)
                    {
                        ListViewItem item = new ListViewItem(row[0].ToString());

                        for (int i=1 ; i< row.ItemArray.Count(); i++)
                        {
                                item.SubItems.Add(row[i].ToString());
                        }
                        courier_ListView.Items.Add(item);
                    }
                }
            }
            catch (Exception)
            {
                ErrorMessageClass.DisplayErrorMessage(501);
            }
        }

        private void AddCourier_button_Click(object sender, EventArgs e)
        {
            try
            {
                CourierAddEditForm courier_addform = new CourierAddEditForm(MainWindowReference, 0, 0);
                courier_addform.ShowDialog();
            }
            catch (Exception)
            {
                ErrorMessageClass.DisplayErrorMessage(504);
            }
        }

        private void EditCourier_button_Click(object sender, EventArgs e)
        {
            try
            {
                int id_to_edit = Convert.ToInt32(courier_ListView.SelectedItems[0].Text);
                CourierAddEditForm courier_addform = new CourierAddEditForm(MainWindowReference, 1, id_to_edit);
                courier_addform.ShowDialog();
            }
            catch (Exception)
            {
                ErrorMessageClass.DisplayErrorMessage(504);
            }
        }

        private void RemoveCourier_button_Click(object sender, EventArgs e)
        {
            if (courier_ListView.SelectedItems.Count == 1)
            {
                DialogResult dlg_result = MessageBox.Show("Are you sure you want to remove this courier?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlg_result == DialogResult.Yes)
                {
                    try
                    {
                        int id_to_remove = Convert.ToInt32(courier_ListView.SelectedItems[0].Text);
                        using (SqlConnection connection = new SqlConnection(MainWindowReference.GetConnectionString()))
                        using (SqlCommand command = new SqlCommand("DELETE FROM Kurier WHERE Id_kuriera=@id_kuriera", connection))
                        {
                            command.Parameters.Add("@id_kuriera", SqlDbType.Int);
                            command.Parameters["@id_kuriera"].Value = id_to_remove;

                            connection.Open();
                            int result = command.ExecuteNonQuery();

                            if (result == 0)
                                ErrorMessageClass.DisplayErrorMessage(502);
                            else if (result > 1)
                                ErrorMessageClass.DisplayErrorMessage(503);
                            else if (result == 1)
                                MessageBox.Show("Courier removed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception)
                    {
                        ErrorMessageClass.DisplayErrorMessage(502);
                    }
                    Load_Couriers_Data();
                }
            }
        }

        private void AssignVehicle_To_Courier_button_Click(object sender, EventArgs e)
        {
            //if 
        }

        private void Refresh_button_Click(object sender, EventArgs e)
        {
            Load_Couriers_Data();
        }
    }
}
