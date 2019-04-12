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
using ParcelDeliveryCompanyApplication.AddInDetailsForm;
using TestGmapProject01;
using ParcelDeliveryCompany_ClassLibrary1;

namespace ParcelDeliveryCompanyApplication.ManagementControls
{
    public partial class CourseConsignmentsManagementControl : ConsignmentManagementControl_New
    {
        private UserClass userItem; // do usunięcia

        private int item_id=0;
        public int Item_id { get => item_id; set => item_id = value; }
        public UserClass UserItem { get => userItem; set => userItem = value; } // do usunięcia

        public CourseConsignmentsManagementControl()
        {
            InitializeComponent();
            Disable_Details_Button(false);
            addItem_button.Text = "Add existing consignment";
            removeItem_button.Text = "Remove consignment from course";
            List_refresh_command = "SELECT * FROM Consignment_Detailed_List_View WHERE Id_przesylki IN (SELECT Id_przesylki FROM Przesylki_w_kursie WHERE Id_kursu =  @item_id);";
            itemDetails_button.Text = "Show course routes";
            Remove_command = "DELETE FROM Przesylki_w_kursie WHERE Id_przesylki = @consignment_id AND Id_kursu = @item_id;";
            editItem_button.Enabled = false;
            editItem_button.Visible = false;
            //LoadItemList();
        }
        /*public CourseConsignmentsManagementControl(MainForm mW, int object_id)
        {
            InitializeComponent();
            MainWindowReference = mW;
            Disable_Details_Button(true);
            this.Item_id = object_id;
            addItem_button.Text = "Add existing consignment";
            removeItem_button.Text = "Remove consignment from this course";
            List_refresh_command = "SELECT * FROM Consignment_Detailed_List_View WHERE Id_przesylki IN (SELECT Id_przesylki FROM Przesylki_w_kursie WHERE Id_kursu =  @item_id);";
            Remove_command = "DELETE FROM Przesylki_w_kursie WHERE Id_przesylki = @consignment_id AND Id_kursu = @item_id;";
            editItem_button.Enabled = false;
            editItem_button.Visible = false;
            //LoadItemList();
        }*/

        protected override void AddItem_button_Click(object sender, EventArgs e)
        {
            try
            {
                CourseConsignmentAddForm addform = new CourseConsignmentAddForm(MainWindowReference, this.Item_id);
                addform.ShowDialog();
            }
            catch (Exception)
            {
                MessageClass.DisplayMessage(1706);//MessageBox.Show("Error! Could not initialize \"Add consignment to course\" form.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadItemList();
        }

        protected override void ItemDetails_button_Click(object sender, EventArgs e)
        {
            CourseMapForm mapForm = new CourseMapForm();
            mapForm.UserItem = this.MainWindowReference;
            mapForm.SendCourseDataToMapControl(Item_id);
            mapForm.ShowDialog();
        }

        protected override void EditItem_button_Click(object sender, EventArgs e)
        {
            //base.EditItem_button_Click(sender, e);
            //Funkcjonalność zbędna w tej kontrolce
        }

        protected override void RemoveItem_button_Click(object sender, EventArgs e)
        {
            if (item_ListView.SelectedItems.Count == 1)
            {
                DialogResult dlg_result = MessageClass.DisplayMessage(1707, this.Item_name);
                if (dlg_result == DialogResult.Yes)
                {
                    try
                    {
                        using (SqlConnection connection = new SqlConnection(MainWindowReference.GetConnectionString()))
                        using (SqlCommand command = new SqlCommand(this.Remove_command, connection))
                        {
                            connection.Open();
                            command.Parameters.Add("@consignment_id", SqlDbType.Int);
                            command.Parameters.Add("@item_id", SqlDbType.Int);
                            command.Parameters["@consignment_id"].Value = Convert.ToInt32(item_ListView.SelectedItems[0].Text);
                            command.Parameters["@item_id"].Value = this.Item_id;

                            int result = command.ExecuteNonQuery();
                            if (result != 1)
                            {
                                MessageClass.DisplayMessage(703);
                            }
                            else
                            {
                                MessageClass.DisplayMessage(1708, this.Item_name_capital_letter);
                                //MessageBox.Show(this.Item_name_capital_letter + " removed from course successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    catch (Exception /*ex*/)
                    {
                        MessageClass.DisplayMessage(1709);
                    }
                }
                else
                {
                    item_ListView.SelectedItems.Clear();
                }
                item_ListView.SelectedItems.Clear();
                LoadItemList();
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
            catch (SqlException ex)
            {
                //ErrorMessageClass.DisplayErrorMessage(411);
                MessageClass.DisplayMessage(1710);
            }
            catch (Exception)
            {
                //ErrorMessageClass.DisplayErrorMessage(410);
                MessageClass.DisplayMessage(1711);
            }
        }

        protected internal override void SetUserRole(/*int user_role*/)
        {
            UserRole user = (UserRole)MainWindowReference.Current_role;
            base.SetUserRole(/*user_role*/);

            if (user == UserRole.CustomerContact)
            {
                refreshList_button.Enabled = true;
                refreshList_button.Visible = true;
            }
            else if (user == UserRole.Dispatcher)
            {
                addItem_button.Enabled = true;
                addItem_button.Visible = true;
                itemDetails_button.Visible = true;
                removeItem_button.Visible = true;
                refreshList_button.Enabled = true;
                refreshList_button.Visible = true;
            }
            else if (user == UserRole.Courier)
            {
                itemDetails_button.Visible = true;
                refreshList_button.Enabled = true;
                refreshList_button.Visible = true;
            }
            else if (user == UserRole.OrderManager)
            {
                /*addItem_button.Enabled = true;
                addItem_button.Visible = true;*/
                itemDetails_button.Visible = true;
                //removeItem_button.Visible = true;
                refreshList_button.Enabled = true;
                refreshList_button.Visible = true;
            }
        }
    }
}
