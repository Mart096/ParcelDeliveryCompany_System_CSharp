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
    public partial class ConsignmentDetailsForm : Form
    {
        private UserClass mainW;
        internal UserClass MainWindowReference { get => mainW; set => mainW = value; }

        private int object_id;

        /*enum DetailsMode
        {
            Consignment=0,
            Parcels=1
        };*/

        public ConsignmentDetailsForm()
        {
            InitializeComponent(); 
        }

        public ConsignmentDetailsForm(UserClass mW, /*int mode,*/ int object_id)
        {
            InitializeComponent();
            MainWindowReference = mW;
            this.object_id = object_id;
            /*parcelManagement_Controler.MainWindowReference = mW;
            parcelManagement_Controler.Load_Parcels_List(object_id);*/
            consignmentParcelManagement_panel.Item_id = object_id;
            consignmentParcelManagement_panel.MainWindowReference = mW;
            consignmentParcelManagement_panel.SetUserRole();
            consignmentParcelManagement_panel.LoadItemList();
            
            Load_Pickup_State_List();
            Load_Consignment_Data(object_id);
        }

        /*private void Accept_button_Click(object sender, EventArgs e)
        {

        }*/

        internal void Load_Pickup_State_List()
        {
            pickupState_listView.Items.Clear();
            try
            {
                DataTable dt = new DataTable();
                using (SqlConnection connection = new SqlConnection(MainWindowReference.GetConnectionString()))
                using (SqlCommand command = new SqlCommand("SELECT * FROM Stan_odbioru", connection))
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
                        pickupState_listView.Items.Add(item);
                    }
                }
            }
            catch (Exception)
            {
                MessageClass.DisplayMessage(1801);
            }
        }

        private void Load_Consignment_Data(int consignment_id)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(MainWindowReference.GetConnectionString()))
                using (SqlCommand command = new SqlCommand("SELECT * FROM Consignment_Details_View WHERE Id_przesylki = @Id_przesylki", connection))
                {
                    command.Parameters.Add("@Id_przesylki", SqlDbType.Int);
                    command.Parameters["@Id_przesylki"].Value = consignment_id;
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        if (connection.State != ConnectionState.Open)
                        {
                            connection.Open();
                        }
                        adapter.Fill(dt);

                        orderID_textbox.Text = dt.Rows[0].ItemArray[1].ToString();
                        consigneeID_textbox.Text = dt.Rows[0].ItemArray[2].ToString();
                        pickupState_textbox.Text = dt.Rows[0].ItemArray[3].ToString();
                        pickupMethod_textbox.Text = dt.Rows[0].ItemArray[4].ToString();
                        consignmentType_textbox.Text = dt.Rows[0].ItemArray[5].ToString();
                        consignerID_textBox.Text = dt.Rows[0].ItemArray[6].ToString();
                        consignerFullName_textbox.Text = dt.Rows[0].ItemArray[7].ToString();
                        consigneeFullName_textbox.Text = dt.Rows[0].ItemArray[8].ToString();

                        //sprawdzić czy wszystko pracuje w zamierzony sposób
                        /*foreach (ListViewItem item in pickupState_listView.Items)
                        {
                            if(item.SubItems[1].Text.Equals(pickupState_textbox.Text))
                            {
                                int temp_id = item.Index;
                                pickupState_listView.Items[temp_id].Selected = true;
                                break;
                            }
                        }*/
                    }
                }

            }
            catch (Exception)
            {
                MessageClass.DisplayMessage(1705);
                this.Close();
                this.Dispose();
            }
        }

        private void Cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void TitleLabelChange(string newtitle)
        {
            this.Details_titleLabel.Text = newtitle;
        }

        private void UpdateConsignmentPickupState_button_Click(object sender, EventArgs e)
        {
            //sprawdzanie uprawnień użytkownika
            if(MainWindowReference.Current_role == UserClass.UserRole.Admin || MainWindowReference.Current_role == UserClass.UserRole.Dispatcher || MainWindowReference.Current_role == UserClass.UserRole.OrderManager)
            {
                DialogResult dlg_result = MessageClass.DisplayMessage(1802, "");
                if (dlg_result == DialogResult.Yes)
                {
                    if (Check_Input() == true)
                    {
                        try
                        {

                            string command_string= "Aktualizuj_stan_odbioru_przesylki";//"UPDATE Przesylka SET Id_stanu_odbioru = @Stan_odbioru WHERE Id_przesylki = @Id_przesylki"

                            using (SqlConnection connection = new SqlConnection(MainWindowReference.GetConnectionString()))
                            using (SqlCommand command = new SqlCommand(command_string, connection))
                            {
                                command.CommandType = CommandType.StoredProcedure;
                                command.Parameters.Add("@Stan_odbioru", SqlDbType.NVarChar);
                                command.Parameters.Add("@Id_przesylki", SqlDbType.Int);

                                if (new_consignment_pickup_state_checkBox.Checked == true)
                                    command.Parameters["@Stan_odbioru"].Value = new_consignment_pickup_state_textBox.Text;//Convert.ToInt32(pickupState_listView.SelectedItems[0].Text);
                                else
                                    command.Parameters["@Stan_odbioru"].Value = pickupState_listView.SelectedItems[0].SubItems[1].Text;//Convert.ToInt32(pickupState_listView.SelectedItems[0].Text);
                                command.Parameters["@Id_przesylki"].Value = this.object_id;

                                connection.Open();

                                int result = command.ExecuteNonQuery();
                                if (result == (-1))
                                {

                                    if (new_consignment_pickup_state_checkBox.Checked == false)
                                        pickupState_textbox.Text = pickupState_listView.SelectedItems[0].SubItems[1].Text;
                                    else
                                        pickupState_textbox.Text = new_consignment_pickup_state_textBox.Text;

                                    pickupState_listView.SelectedItems.Clear();
                                    new_consignment_pickup_state_textBox.Clear();
                                    new_consignment_pickup_state_checkBox.Checked = false;

                                    MessageClass.DisplayMessage(1803);
                                }
                                else
                                {
                                    MessageClass.DisplayMessage(1804);

                                }
                            }
                        }
                        catch (Exception)
                        {
                            MessageClass.DisplayMessage(1805);
                        }
                    }
                    else
                    {
                        MessageClass.DisplayMessage(1112);
                    }
                }
            }
            else
            {
                MessageClass.DisplayMessage(2501);
            }
            Load_Pickup_State_List();
        }

        private bool Check_Input()
        {
            bool result = true;

            if(new_consignment_pickup_state_checkBox.Checked==false && pickupState_listView.SelectedItems.Count != 1)
            {
                result = false;
            }
            else if ( new_consignment_pickup_state_checkBox.Checked==true && (new_consignment_pickup_state_textBox.Text.Length==0 || new_consignment_pickup_state_textBox.Text.Trim().Length==0))
            {
                result = false;
            }

            return result;
        }

        private void PickupState_listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(pickupState_listView.SelectedItems.Count == 1 && (MainWindowReference.Current_role == UserClass.UserRole.Admin || MainWindowReference.Current_role == UserClass.UserRole.Dispatcher || MainWindowReference.Current_role == UserClass.UserRole.OrderManager))
            {
                if (pickupState_listView.SelectedItems[0].SubItems[1].Text.Equals(pickupState_textbox.Text))
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

        private void New_consignment_pickup_state_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (new_consignment_pickup_state_checkBox.Checked == true)
            {
                pickupState_listView.SelectedItems.Clear();
                pickupState_listView.Enabled = false;
                new_consignment_pickup_state_textBox.Visible = true;
                updateConsignmentPickupState_button.Enabled = true;
            }
            else
            {
                pickupState_listView.Enabled = true;
                new_consignment_pickup_state_textBox.Visible = false;
                updateConsignmentPickupState_button.Enabled = false;
            }
        }
    }
}
