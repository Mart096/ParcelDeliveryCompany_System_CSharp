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

namespace ParcelDeliveryCompanyApplication.ManagementControls
{
    public partial class ConsignmentParcelManagementControl : ParcelManagementControl_New
    {
        private int item_id = 0;
        public int Item_id { get => item_id; set => item_id = value; }

        public ConsignmentParcelManagementControl()
        {
            InitializeComponent();
            Disable_Details_Button(true);
            //addItem_button.Text = "Add existing parcel";
            //removeItem_button.Text = "Remove parcel from consignment";
            List_refresh_command = "SELECT * FROM Parcels_View WHERE Id_przesylki = @item_id;";
            //Remove_command = "";
        }

        protected override void AddItem_button_Click(object sender, EventArgs e)
        {
            //base.AddItem_button_Click(sender, e);
            try
            {
                ParcelAddEditForm addparcelform = new ParcelAddEditForm(MainWindowReference, 0, 0, Item_id);
                addparcelform.ShowDialog();
            }
            catch (Exception)
            {
                MessageClass.DisplayMessage(2001);
                //MessageBox.Show("Failed to initialize parcel add form", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadItemList();
        }

        protected override void RemoveItem_button_Click(object sender, EventArgs e)
        {
            if (item_ListView.SelectedItems.Count == 1)
            {
                DialogResult dlg_result;
                if (item_ListView.Items.Count == 1)
                {
                    dlg_result = MessageClass.DisplayMessage(1411, ""); //ZAGROŻENIE USUNIĘCIA PRZESYŁKI
                }
                else
                {
                    dlg_result = MessageClass.DisplayMessage(1410, ""); 
                }

                if (dlg_result == DialogResult.Yes)
                {
                    try
                    {
                        int id_to_remove = Convert.ToInt32(item_ListView.SelectedItems[0].Text);
                        string command1 = "DELETE FROM Cecha_paczki WHERE Id_paczki=@parcel_id";
                        string command2 = "DELETE FROM Paczka WHERE Id_paczki=@parcel_id";
                        using (SqlConnection connection = new SqlConnection(MainWindowReference.GetConnectionString()))
                        using (SqlCommand command = new SqlCommand(command1, connection))
                        {
                            command.Parameters.Add("@parcel_id", SqlDbType.Int);
                            command.Parameters["@parcel_id"].Value = id_to_remove;

                            connection.Open();
                            int result1 = command.ExecuteNonQuery(); // usuwanie cech paczki

                            command.CommandText = command2;

                            int result2 = command.ExecuteNonQuery();

                            if (result2 != 1)
                                MessageClass.DisplayMessage(1408); //MessageBox.Show("Failed to remove selected parcel! Check if parcel has assigned properties.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            else if (result2 == 1)
                                MessageClass.DisplayMessage(1409); //MessageBox.Show("Parcel removed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception)
                    {
                        MessageClass.DisplayMessage(1407); //MessageBox.Show("Error occured during an attempt to remove selected parcel! .", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    LoadItemList();
                }
            }
        }

        internal override void LoadItemList()
        {
            item_ListView.Items.Clear();

            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(MainWindowReference.GetConnectionString()))
                using (SqlCommand command = new SqlCommand(this.List_refresh_command, connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    command.Parameters.Add("@item_id", SqlDbType.Int);
                    command.Parameters["@item_id"].Value = this.Item_id;
                    adapter.Fill(dt);

                    //wypełnianie listy
                    foreach (DataRow row in dt.Rows)
                    {
                        ListViewItem item = new ListViewItem(row[0].ToString());
                        int check_column = 0;
                        foreach (var column in row.ItemArray)
                        {
                            if (check_column > 0)
                            {
                                item.SubItems.Add(column.ToString());
                            }
                            check_column += 1;
                        }
                        item_ListView.Items.Add(item);
                    }
                }
            }
            catch (SqlException)
            {
                //ErrorMessageClass.DisplayErrorMessage(411);
                MessageClass.DisplayMessage(2002);
            }
            catch (Exception)
            {
                //ErrorMessageClass.DisplayErrorMessage(410);
                MessageClass.DisplayMessage(2003);
            }

        }

        protected internal override void SetUserRole(/*int user_role*/)
        {
            UserRole user = (UserRole)MainWindowReference.Current_role;
            base.SetUserRole(/*user_role*/);

            if (user == UserRole.Admin)
            {
                removeItem_button.Visible = true;
            }
            else if (user == UserRole.CustomerContact)
            {
                refreshList_button.Enabled = true;
                refreshList_button.Visible = true;
            }
            else if (user == UserRole.Dispatcher)
            {
                refreshList_button.Enabled = true;
                refreshList_button.Visible = true;
            }
            else if (user == UserRole.Courier)
            {
                refreshList_button.Enabled = true;
                refreshList_button.Visible = true;
            }
            else if (user == UserRole.OrderManager)
            {
                addItem_button.Enabled = true;
                addItem_button.Visible = true;
                editItem_button.Visible = true;
                removeItem_button.Visible = true;
                refreshList_button.Enabled = true;
                refreshList_button.Visible = true;
            }
        }
    }
}
