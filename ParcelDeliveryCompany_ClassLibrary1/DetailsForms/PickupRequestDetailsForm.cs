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

namespace ParcelDeliveryCompanyApplication
{
    public partial class PickupRequestDetailsForm : Form
    {
        private UserClass mainW;
        internal UserClass MainWindowReference { get => mainW; set => mainW = value; }

        private int object_id;

        public PickupRequestDetailsForm()
        {
            InitializeComponent();
        }

        public PickupRequestDetailsForm(UserClass mW, /*int mode,*/ int object_id)
        {
            InitializeComponent();
            MainWindowReference = mW;
            this.object_id = object_id;
            Load_Pickup_Request_Data(object_id);
            Load_Pickup_Request_States_List();
            /*parcelManagement_Controler.MainWindowReference = mW;
            parcelManagement_Controler.Load_Parcels_List(object_id);
            Load_Pickup_State_List();
            Load_Consignment_Data(object_id);*/
        }

        private void Load_Pickup_Request_States_List()
        {
            try
            {
                DataTable dt = new DataTable();
                using (SqlConnection connection = new SqlConnection(MainWindowReference.GetConnectionString()))
                using (SqlCommand command = new SqlCommand("SELECT * FROM Stan_zgloszenia_odbioru", connection))
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
                        pickupRequestState_listView.Items.Add(item);
                    }
                }
            }
            catch (Exception)
            {
                MessageClass.DisplayMessage(1901); 
            }
        }

        private void Load_Pickup_Request_Data(int object_id)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(MainWindowReference.GetConnectionString()))
                using (SqlCommand command = new SqlCommand("SELECT * FROM Pickup_Request_Details_View WHERE Id_zgloszenia_odbioru = @item_id", connection))
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

                        orderID_textbox.Text = dt.Rows[0].ItemArray[1].ToString();
                        consignerID_textBox.Text = dt.Rows[0].ItemArray[2].ToString();
                        consignerFullName_textbox.Text = dt.Rows[0].ItemArray[3].ToString();
                        pickupRequestState_textbox.Text = dt.Rows[0].ItemArray[4].ToString();
                        pickupDateTime_textbox.Text = dt.Rows[0].ItemArray[5].ToString();
                        courierID_textBox.Text = dt.Rows[0].ItemArray[6].ToString();
                        courierFullName_textBox.Text = dt.Rows[0].ItemArray[7].ToString();

                        /*foreach (ListViewItem item in pickupRequestState_listView.Items)
                        {
                            if (item.SubItems[1].Text.Equals(pickupRequestState_textbox.Text))
                            {
                                int temp_id = item.Index;
                                pickupRequestState_listView.Items[temp_id].Selected = true;
                                break;
                            }
                        }*/
                    }
                }

            }
            catch (Exception)
            {
                MessageClass.DisplayMessage(1902);
                this.Close();
                this.Dispose();
            }
        }

        private void UpdatePickupRequestState_button_Click(object sender, EventArgs e)
        {
            DialogResult dlg_result = MessageClass.DisplayMessage(1903, "");
            if (dlg_result == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(MainWindowReference.GetConnectionString()))
                    using (SqlCommand command = new SqlCommand("UPDATE Zgloszenia_odbioru SET Id_stanu_zgloszenia_odbioru = @pickup_request_state_id WHERE Id_zgloszenia_odbioru = @item_id", connection))
                    {
                        command.Parameters.Add("@pickup_request_state_id", SqlDbType.Int);
                        command.Parameters.Add("@item_id", SqlDbType.Int);
                        command.Parameters["@pickup_request_state_id"].Value = Convert.ToInt32(pickupRequestState_listView.SelectedItems[0].Text);
                        command.Parameters["@item_id"].Value = this.object_id;

                        connection.Open();

                        int result = command.ExecuteNonQuery();
                        if (result == 1)
                        {
                            pickupRequestState_textbox.Text = pickupRequestState_listView.SelectedItems[0].SubItems[1].Text;
                            pickupRequestState_listView.SelectedItems.Clear();
                            MessageClass.DisplayMessage(1904); 
                        }
                        else
                        {
                            MessageClass.DisplayMessage(1905); 
                        }
                    }
                }
                catch (Exception)
                {
                    MessageClass.DisplayMessage(1906); 
                }
            }
        }

        private void Cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void PickupRequestState_listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pickupRequestState_listView.SelectedItems.Count == 1 && (MainWindowReference.Current_role == UserClass.UserRole.Admin || MainWindowReference.Current_role == UserClass.UserRole.Dispatcher || MainWindowReference.Current_role == UserClass.UserRole.OrderManager))
            {
                if (pickupRequestState_listView.SelectedItems[0].SubItems[1].Text.Equals(pickupRequestState_textbox.Text))
                {
                    updateConsignmentPickupState_button.Enabled = false;
                }
                else
                {
                    updateConsignmentPickupState_button.Enabled = true;
                }
            }
            else
            {
                updateConsignmentPickupState_button.Enabled = false;
            }
        }

        private void showRouteOnMapButton_Click(object sender, EventArgs e)
        {
            AddInDetailsForm.PickupRequestStartLocation locform = new AddInDetailsForm.PickupRequestStartLocation(MainWindowReference, object_id);
            locform.ShowDialog();
            /*CourseMapForm mapForm = new CourseMapForm();
            mapForm.UserItem = this.MainWindowReference;
            //mapForm.SendCourseDataToMapControl(Item_id);
            mapForm.ShowDialog();*/
        }
    }
}
