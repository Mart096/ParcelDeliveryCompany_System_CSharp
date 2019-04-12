using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ParcelDeliveryCompany_ClassLibrary1;
using ParcelDeliveryCompanyApplication.DetailsForms;
using System.Data.SqlClient;

namespace ParcelDeliveryCompanyApplication.ManagementControls
{
    public partial class CourseManagementControl_New : ItemManagementControler
    {
        public CourseManagementControl_New()
        {
            InitializeComponent();
            SetControlBasicData("SELECT * FROM Course_Details_View", "DELETE FROM Kurs WHERE Id_kursu=@item_id", "course", "Course");
            Disable_Details_Button(false);
        }

        protected override void AddItem_button_Click(object sender, EventArgs e)
        {
            try
            {
                CourseAddEditForm addItemForm = new CourseAddEditForm(MainWindowReference, 0, 0);
                addItemForm.ShowDialog();
            }
            catch
            {
                //ErrorMessageClass.DisplayErrorMessage(401);
                MessageBox.Show("Failed to initialize course add/edit form.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadItemList();
        }
        protected override void EditItem_button_Click(object sender, EventArgs e)
        {
            if (item_ListView.SelectedItems.Count == 1)
            {
                try
                {
                    int course_to_edit = 0;
                    course_to_edit = Convert.ToInt32(item_ListView.SelectedItems[0].Text);
                    CourseAddEditForm editItemForm = new CourseAddEditForm(MainWindowReference, 1, course_to_edit);
                    editItemForm.ShowDialog();
                }
                catch (Exception)
                {
                    //ErrorMessageClass.DisplayErrorMessage(401);
                    MessageBox.Show("Failed to initialize course add/edit form.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            LoadItemList();
        }

        protected override void ItemDetails_button_Click(object sender, EventArgs e)
        {
            if (item_ListView.SelectedItems.Count == 1)
            {
                try
                {
                    int course_id = 0;
                    course_id = Convert.ToInt32(item_ListView.SelectedItems[0].Text);
                    CourseDetailsForm courseDetForm = new CourseDetailsForm(MainWindowReference, course_id);
                    courseDetForm.ShowDialog();
                }
                catch (Exception /*ex*/)
                {
                    MessageClass.DisplayMessage(2401);
                    //MessageBox.Show("Failed to initialize course's details form.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                LoadItemList();
            }
        }

        internal override void LoadItemList()
        {
            item_ListView.Items.Clear();
            
            /*if(MainWindowReference.Current_role == UserClass.UserRole.Courier)
            {
                List_refresh_command = "SELECT * FROM Course_Details_View WHERE Id_kuriera = @item_id";
            }*/

            DataTable dt = new DataTable();
            try
            {
                if((UserRole)MainWindowReference.Current_role == UserRole.Courier)
                {
                    this.List_refresh_command = "Kursy_kuriera";
                }

                using (SqlConnection connection = new SqlConnection(MainWindowReference.GetConnectionString()))
                using (SqlCommand command = new SqlCommand(this.List_refresh_command, connection))
                {
                    if ((UserRole)MainWindowReference.Current_role == UserRole.Courier)
                    {
                        command.CommandType = CommandType.StoredProcedure;
                    }

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        /*if (MainWindowReference.Current_role == UserClass.UserRole.Courier)
                        { 
                            command.Parameters.Add("@item_id", SqlDbType.Int);
                            command.Parameters["@item_id"].Value = 
                        }*/

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
            }
            catch (SqlException /*ex*/)
            {
                //ErrorMessageClass.DisplayErrorMessage(411);
                MessageClass.DisplayMessage(705, this.Item_name_plural);
                //MessageBox.Show("Could not load " + Item_name_plural + " list. Query failed." /*+ ex.Message*/, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception /*ex*/)
            {
                //ErrorMessageClass.DisplayErrorMessage(410);
                MessageClass.DisplayMessage(706, this.Item_name_plural);
                //MessageBox.Show("Could not load " + Item_name_plural + " list. "/* + ex.Message*/, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /*protected override void Item_ListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (item_ListView.SelectedItems.Count == 1)
            {
                editItem_button.Enabled = true;
                removeItem_button.Enabled = true;
            }
            else
            {
                editItem_button.Enabled = false;
                removeItem_button.Enabled = false;
            }
        }*/

        protected internal override void SetUserRole(/*int user_role*/)
        {
            UserRole user = (UserRole)MainWindowReference.Current_role;
            base.SetUserRole(/*user_role*/);
            
            if (user == UserRole.CustomerContact)
            {

            }
            else if (user == UserRole.Dispatcher)
            {
                addItem_button.Enabled = true;
                addItem_button.Visible = true;
                itemDetails_button.Visible = true;
                editItem_button.Visible = true;
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

            }
        }
    }
}
