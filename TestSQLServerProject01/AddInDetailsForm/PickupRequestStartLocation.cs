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

namespace ParcelDeliveryCompanyApplication.AddInDetailsForm
{
    public partial class PickupRequestStartLocation : Form
    {
        private int decision;
        private int pickup_request;
        private UserClass mainW;

        public PickupRequestStartLocation(UserClass mW, int pickup_request)
        {
            InitializeComponent();
            MainWindowReference = mW;
            this.Pickup_request = pickup_request;
            LoadLocationList();
        }

        public int Decision { get => decision; private set => decision = value; }
        public UserClass MainWindowReference { get => mainW; set => mainW = value; }
        public int Pickup_request { get => pickup_request; set => pickup_request = value; }

        internal void LoadLocationList()
        {
            location_ListView.Items.Clear();
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(MainWindowReference.GetConnectionString()))
                using (SqlCommand command = new SqlCommand("SELECT * FROM Location_Detailed_View", connection))
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
                        item.SubItems.Add(row[5].ToString());
                        location_ListView.Items.Add(item);
                    }
                }
            }
            catch (Exception)
            {
                MessageClass.DisplayMessage(1301);
                this.Close();
                this.Dispose();
            }
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            if(location_ListView.SelectedItems.Count == 1)
            {
                CourseMapForm mapForm = new CourseMapForm();
                mapForm.UserItem = this.MainWindowReference;
                mapForm.SendPickupRequestDataToMapControl(Pickup_request, Convert.ToInt32(location_ListView.SelectedItems[0].Text));
                mapForm.ShowDialog();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            //this.Decision = 0;

            this.Close();
            this.Dispose();
        }

        private void location_ListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (location_ListView.SelectedItems.Count == 1)
            {
                acceptButton.Enabled = true;
            }
            else
            {
                acceptButton.Enabled = true;
            }
        }
    }
}
