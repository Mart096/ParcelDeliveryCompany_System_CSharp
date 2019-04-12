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

namespace ParcelDeliveryCompanyApplication
{
    public partial class ParcelManagementControler : UserControl
    {
        int consignment_id=0;
        private UserClass mainW;

        public UserClass MainWindowReference { get => mainW; set => mainW = value; }

        public ParcelManagementControler()
        {
            InitializeComponent();
        }

        protected internal enum UserRole
        {
            Admin = 0,
            Dispatcher = 1,
            Courier = 2,
            OrderManager = 3,
            CustomerContact = 4
        };

        private void Add_button_Click(object sender, EventArgs e)
        {
            ParcelAddEditForm addparcelform = new ParcelAddEditForm(MainWindowReference, 0, 0, consignment_id);
            addparcelform.ShowDialog();
        }

        private void Edit_button_Click(object sender, EventArgs e)
        {
            ParcelAddEditForm editparcelform = new ParcelAddEditForm(MainWindowReference, 1, Convert.ToInt32(parcel_listView.SelectedItems[0].Text), consignment_id);
            editparcelform.ShowDialog();
        }

        private void Remove_button_Click(object sender, EventArgs e)
        {
            if (parcel_listView.SelectedItems.Count == 1)
            {
                DialogResult dlg_result = MessageClass.DisplayMessage(1410, ""); //MessageBox.Show("Are you sure you want to remove this parcel?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlg_result == DialogResult.Yes)
                {
                    try
                    {
                        int id_to_remove = Convert.ToInt32(parcel_listView.SelectedItems[0].Text);
                        using (SqlConnection connection = new SqlConnection(MainWindowReference.GetConnectionString()))
                        using (SqlCommand command = new SqlCommand("DELETE FROM Paczka WHERE Id_paczki=@parcel_id", connection))
                        {
                            command.Parameters.Add("@parcel_id", SqlDbType.Int);
                            command.Parameters["@parcel_id"].Value = id_to_remove;

                            connection.Open();
                            int result = command.ExecuteNonQuery();

                            if (result != 1)
                                MessageClass.DisplayMessage(1408); //MessageBox.Show("Failed to remove selected parcel! Check if parcel has assigned properties.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            else if (result == 1)
                                MessageClass.DisplayMessage(1409); //MessageBox.Show("Parcel removed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception)
                    {
                        MessageClass.DisplayMessage(1407); //MessageBox.Show("Error occured during an attempt to remove selected parcel! .", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    if (consignment_id == 0)
                        Load_Parcels_List();
                    else
                        Load_Parcels_List(consignment_id);
                }
            }
        }

        private void Refresh_button_Click(object sender, EventArgs e)
        {
            if (this.consignment_id == 0)
                Load_Parcels_List();
            else
                Load_Parcels_List(consignment_id);
        }

        internal void Load_Parcels_List()
        {
            parcel_listView.Items.Clear();
            try
            {
                DataTable dt = new DataTable();
                using (SqlConnection connection = new SqlConnection(MainWindowReference.GetConnectionString()))
                using (SqlCommand command = new SqlCommand("SELECT * FROM Parcels_View", connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    connection.Open();
                    adapter.Fill(dt);

                    foreach (DataRow row in dt.Rows)
                    {
                        ListViewItem item = new ListViewItem(row[0].ToString());

                        for (int i = 1; i < row.ItemArray.Count(); i++)
                        {
                            item.SubItems.Add(row[i].ToString());
                        }
                        parcel_listView.Items.Add(item);
                    }
                }
            }
            catch (Exception /*ex*/)
            {
                MessageClass.DisplayMessage(1406);
                //MessageBox.Show("Could not load parcels' list.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        internal void Load_Parcels_List(int consignment_id)
        {
            parcel_listView.Items.Clear();
            this.consignment_id = consignment_id;
            try
            {
                DataTable dt = new DataTable();
                using (SqlConnection connection = new SqlConnection(MainWindowReference.GetConnectionString()))
                using (SqlCommand command = new SqlCommand("SELECT * FROM Parcels_View WHERE Id_przesylki = @consignment_id", connection))
                {
                    command.Parameters.Add("@consignment_id", SqlDbType.Int);
                    command.Parameters["@consignment_id"].Value = consignment_id;


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
                            parcel_listView.Items.Add(item);
                        }
                    }
                }
            }
            catch (Exception /*ex*/)
            {
                MessageClass.DisplayMessage(1406);
                //MessageBox.Show(/*ex.Message+*/"Could not load parcels' list.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Parcel_listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(parcel_listView.Items.Count > 0)
            {
                if (parcel_listView.SelectedItems.Count == 1)
                {
                    remove_button.Enabled = true;
                    edit_button.Enabled = true;
                }
                else
                {
                    remove_button.Enabled = false;
                    edit_button.Enabled = false;
                }
            }
            else
            {
                remove_button.Enabled = false;
                edit_button.Enabled = false;
            }
        }
    }
}
