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
            complaintState_listView.Items.Clear();
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
                MessageClass.DisplayMessage(1609);
            }
        }

        private void Load_Complaint_Data(int object_id)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(MainWindowReference.GetConnectionString()))
                using (SqlCommand command = new SqlCommand("SELECT * FROM Complaint_Details_View WHERE Id_zgloszenia_reklamacji = @Stan_reklamacji", connection))
                {
                    command.Parameters.Add("@Stan_reklamacji", SqlDbType.Int);
                    command.Parameters["@Stan_reklamacji"].Value = object_id;
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
            catch (Exception /*ex*/)
            {
                MessageClass.DisplayMessage(1601);
                this.Close();
                this.Dispose();
            }
        }

        private void UpdatePickupRequestState_button_Click(object sender, EventArgs e)
        {
            if (MainWindowReference.Current_role == UserClass.UserRole.Admin || MainWindowReference.Current_role == UserClass.UserRole.OrderManager || MainWindowReference.Current_role == UserClass.UserRole.Dispatcher)
            {
                DialogResult dlg_result = MessageClass.DisplayMessage(1614, "");
                if (dlg_result == DialogResult.Yes)
                {
                    if (Check_Input() == true)
                    {
                        try
                        {
                            string command_string = "Aktualizuj_zgloszenie_reklamacji";

                            using (SqlConnection connection = new SqlConnection(MainWindowReference.GetConnectionString()))
                            using (SqlCommand command = new SqlCommand(command_string, connection)) //"UPDATE Zgloszenia_reklamacji SET Id_stanu_reklamacji = @Id_zgloszenia_reklamacji WHERE Id_zgloszenia_reklamacji = @Stan_reklamacji", connection))
                            {
                                command.CommandType = CommandType.StoredProcedure;

                                command.Parameters.Add("@Id_zgloszenia_reklamacji", SqlDbType.Int);
                                command.Parameters.Add("@Stan_reklamacji", SqlDbType.NVarChar);
                                command.Parameters["@Id_zgloszenia_reklamacji"].Value = this.object_id;

                                if (new_complaint_state_checkBox.Checked == true)
                                {
                                    command.Parameters["@Stan_reklamacji"].Value = new_complaint_state_textBox.Text;
                                }
                                else
                                {
                                    command.Parameters["@Stan_reklamacji"].Value = complaintState_listView.SelectedItems[0].SubItems[1].Text;//Convert.ToInt32(complaintState_listView.SelectedItems[0].Text);
                                }

                                connection.Open();

                                int result = command.ExecuteNonQuery();
                                if (result == (-1))
                                {
                                    if (new_complaint_state_checkBox.Checked == true)
                                    {
                                        ComplaintState_textbox.Text = new_complaint_state_textBox.Text;
                                    }
                                    else
                                    {
                                        ComplaintState_textbox.Text = complaintState_listView.SelectedItems[0].SubItems[1].Text;
                                    }
                                    complaintState_listView.SelectedItems.Clear();
                                    new_complaint_state_textBox.Clear();
                                    new_complaint_state_checkBox.Checked = false;
                                    MessageClass.DisplayMessage(1611);
                                }
                                else
                                {
                                    MessageClass.DisplayMessage(1612);
                                }
                            }
                        }
                        catch (Exception)
                        {
                            MessageClass.DisplayMessage(1613);
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
            Load_Complaint_State_List();
        }

        private void Cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void ComplaintState_listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (complaintState_listView.SelectedItems.Count == 1 && new_complaint_state_checkBox.Checked==false)
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

        private bool Check_Input()
        {
            bool result = true;

            if(new_complaint_state_checkBox.Checked==true && (new_complaint_state_textBox.Text.Length==0 || new_complaint_state_textBox.Text.Trim().Length == 0))
            {
                result = false;
            }
            else if(new_complaint_state_checkBox.Checked==false && complaintState_listView.SelectedItems.Count != 1)
            {
                result = false;
            }

            return result;
        }

        private void New_complaint_state_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (new_complaint_state_checkBox.Checked == true)
            {
                complaintState_listView.SelectedItems.Clear();
                complaintState_listView.Visible = false;
                new_complaint_state_textBox.Visible = true;
                updateComplaintState_button.Enabled = true;
            }
            else
            {
                complaintState_listView.Visible = true;
                new_complaint_state_textBox.Visible = false;
                updateComplaintState_button.Enabled = false;
            }
        }
    }
}
