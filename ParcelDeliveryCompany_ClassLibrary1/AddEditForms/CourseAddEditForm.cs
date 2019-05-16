//using ParcelDeliveryCompany_ClassLibrary1;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ParcelDeliveryCompany_ClassLibrary1
{
    public partial class CourseAddEditForm : Form
    {
        private UserClass mainW;
        private FormMode current_mode;
        private int edited_id;

        public UserClass MainWindowReference { get => mainW; set => mainW = value; }

        enum FormMode
        {
            add = 0,
            edit = 1
        };

        public CourseAddEditForm()
        {
            InitializeComponent();
        }

        public CourseAddEditForm(UserClass mW, int mode, int id)
        {
            InitializeComponent();
            this.MainWindowReference = mW;
            ToggleMode((FormMode)mode);
            LoadLocationList();
            LoadCourierList();

            if (this.current_mode == FormMode.edit)
            {
                this.edited_id = id;
                Load_Course_to_Edit(edited_id);
            }
        }

        private void LoadLocationList()
        {
            startLocation_ListView.Items.Clear();
            endLocation_listView.Items.Clear();

            try
            {
                DataTable dt = new DataTable();
                using (SqlConnection connection = new SqlConnection(MainWindowReference.GetConnectionString()))
                using (SqlCommand command = new SqlCommand("SELECT * FROM Location_Detailed_View", connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    connection.Open();
                    adapter.Fill(dt);
                    foreach (DataRow row in dt.Rows)
                    {
                        ListViewItem item = new ListViewItem(row[0].ToString());
                        
                        item.SubItems.Add(row[1].ToString());
                        item.SubItems.Add(row[2].ToString());
                        item.SubItems.Add(row[3].ToString());
                        item.SubItems.Add(row[4].ToString());
                        item.SubItems.Add(row[5].ToString());

                        ListViewItem item1 = (ListViewItem)item.Clone();
                        startLocation_ListView.Items.Add(item);
                        endLocation_listView.Items.Add(item1);
                    }
                }
            }
            catch (Exception)
            {
                //ErrorMessageClass.DisplayErrorMessage(402);
                MessageBox.Show("Could not load locations' list.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LoadCourierList()
        {
            courier_ListView.Items.Clear();

            try
            {
                DataTable dt = new DataTable();
                using (SqlConnection connection = new SqlConnection(MainWindowReference.GetConnectionString()))
                using (SqlCommand command = new SqlCommand("SELECT * FROM Kurier", connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    connection.Open();
                    adapter.Fill(dt);
                    foreach (DataRow row in dt.Rows)
                    {
                        ListViewItem item = new ListViewItem(row[0].ToString());
                        item.SubItems.Add(row[1].ToString());
                        item.SubItems.Add(row[2].ToString());
                        item.SubItems.Add(row[3].ToString());
                        item.SubItems.Add(row[4].ToString());
                        item.SubItems.Add(row[5].ToString());
                        courier_ListView.Items.Add(item);
                    }
                }
            }
            catch (Exception)
            {
                //ErrorMessageClass.DisplayErrorMessage(402);
                MessageClass.DisplayMessage(501);
            }
        }

        private void Load_Course_to_Edit(int edited_id)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(MainWindowReference.GetConnectionString()))
                using (SqlCommand command = new SqlCommand("SELECT * FROM Course_Details_View WHERE Id_kursu = @course_id", connection))
                {
                    command.Parameters.Add("@course_id", SqlDbType.Int);
                    command.Parameters["@course_id"].Value = edited_id;
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        connection.Open();
                        adapter.Fill(dt);

                        int check_list = 0;
                        foreach (ListViewItem item in startLocation_ListView.Items)//startLocation_ListView.FindItemWithText(dt.Rows[0].ItemArray[0].ToString(), false, 0))
                        {
                            if (item.Text.Equals( dt.Rows[0].ItemArray[1].ToString()))
                            {
                                check_list += 1;
                                int temp_id = item.Index;
                                startLocation_ListView.Items[temp_id].Selected = true;
                            }
                            else if (item.Text.Equals(dt.Rows[0].ItemArray[3].ToString()))
                            {
                                check_list += 1;
                                int temp_id = item.Index;
                                endLocation_listView.Items[temp_id].Selected = true;
                            }

                            if (check_list >= 2)
                                break;
                        }

                        foreach (ListViewItem item in courier_ListView.Items)
                        {
                            if (item.Text.Equals( dt.Rows[0].ItemArray[5].ToString()))
                            {
                                check_list += 1;
                                int temp_id = item.Index;
                                courier_ListView.Items[temp_id].Selected = true;
                                break;
                            }
                        }
                    }
                }
            }
            catch (SqlException /*sqlex*/)
            {
                //ErrorMessageClass.DisplayErrorMessage(411);
                MessageClass.DisplayMessage(2402);
                //MessageBox.Show(sqlex.Message);
            }
            catch (Exception /*ex*/)
            {
                //ErrorMessageClass.DisplayErrorMessage(410);
                MessageClass.DisplayMessage(2403);
                //MessageBox.Show(ex.Message);
            }
        }

        private void ToggleMode(FormMode mode)
        {
            this.current_mode = mode;
            if (mode == FormMode.add)
            {
                this.Text = "Add course";
                accept_button.Text = "Add new course";
            }
            else if (mode == FormMode.edit)
            {
                this.Text = "Edit course";
                accept_button.Text = "Accept changes";
            }
            else
            {
                MessageClass.DisplayMessage(401);
                this.Close();
                this.Dispose();
            }
        }

        private bool Check_Input()
        {
            bool result = true;
            if (startLocation_ListView.SelectedItems.Count !=1 || endLocation_listView.SelectedItems.Count != 1 || 
                courier_ListView.SelectedItems.Count != 1)
            {
                result = false;
            }

            return result;
        }

        private void Accept_button_Click(object sender, EventArgs e)
        {
            if(Check_Input() == true)
            {
                try
                {
                    string insert_command = "INSERT INTO Kurs VALUES (@start_location, @end_location, @courier_id)";
                    string update_command = "UPDATE Kurs SET Id_punktu = @start_location, Id_punktu_koncowego = @end_location, Id_kuriera = @courier_id WHERE Id_kursu = @course_id;";
                    string executed_command = insert_command;
                    if(current_mode == FormMode.edit)
                    {
                        executed_command = update_command;
                    }
                    using (SqlConnection connection = new SqlConnection(MainWindowReference.GetConnectionString()))
                    using (SqlCommand command = new SqlCommand(executed_command, connection))
                    {
                        command.Parameters.Add("@start_location", SqlDbType.Int);
                        command.Parameters.Add("@end_location", SqlDbType.Int);
                        command.Parameters.Add("@courier_id", SqlDbType.Int);

                        command.Parameters["@start_location"].Value = Convert.ToInt32(startLocation_ListView.SelectedItems[0].Text);
                        command.Parameters["@end_location"].Value = Convert.ToInt32(endLocation_listView.SelectedItems[0].Text);
                        command.Parameters["@courier_id"].Value = Convert.ToInt32(courier_ListView.SelectedItems[0].Text);

                        if(current_mode == FormMode.edit)
                        {
                            command.Parameters.Add("@course_id", SqlDbType.Int);
                            command.Parameters["@course_id"].Value = this.edited_id;
                        }

                        connection.Open();
                        int result = command.ExecuteNonQuery();

                        if(result == 0)
                        {
                            if (current_mode == FormMode.add)
                                MessageClass.DisplayMessage(2406);
                            //MessageBox.Show("Failed to insert new course.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            else if (current_mode == FormMode.edit)
                                MessageClass.DisplayMessage(2407);
                            //MessageBox.Show("Failed to save changes to selected course.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else if (result > 1)
                        {
                            MessageClass.DisplayMessage(703);
                            //MessageBox.Show("Unexpected behaviour occured. Contact you database administrator and inform him about this issue.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            if(current_mode == FormMode.add)
                                MessageClass.DisplayMessage(2408);
                            //MessageBox.Show("New course added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            else if(current_mode == FormMode.edit)
                                MessageClass.DisplayMessage(2409);
                            //MessageBox.Show("Course data was updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch
                {
                    if (current_mode == FormMode.add)
                        MessageClass.DisplayMessage(2404);
                        //MessageBox.Show("Failed to insert new course. Error occured!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else if (current_mode == FormMode.edit)
                        MessageClass.DisplayMessage(2405);
                    //MessageBox.Show("Failed to update selected course. Error occured!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                this.Close();
                this.Dispose();
            }
            else
            {
                MessageClass.DisplayMessage(1112);
                //MessageBox.Show("Not all data was specified! Check your input for missing information.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
