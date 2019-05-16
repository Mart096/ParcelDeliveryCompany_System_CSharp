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
    public partial class CourseManagementControler : UserControl
    {
        private UserClass MainW;

        public CourseManagementControler()
        {
            InitializeComponent();
        }

        public UserClass MainWindowReference { get => MainW; set => MainW = value; }

        internal void LoadCourseList()
        {
            course_ListView.Items.Clear();
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(MainW.GetConnectionString()))
                using (SqlCommand command = new SqlCommand("SELECT * FROM Kurs", connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    adapter.Fill(dt);
                    foreach (DataRow row in dt.Rows)
                    {
                        ListViewItem item = new ListViewItem(row[0].ToString());
                        item.SubItems.Add(row[1].ToString());
                        course_ListView.Items.Add(item);
                    }
                }
            }
            catch (SqlException)
            {
                //ErrorMessageClass.DisplayErrorMessage(411);
            }
            catch (Exception)
            {
                //ErrorMessageClass.DisplayErrorMessage(410);
            }
        }

        private void RefreshList_button_Click(object sender, EventArgs e)
        {
            LoadCourseList();
        }

        private void AddCourse_button_Click(object sender, EventArgs e)
        {
            try
            {
                CourseAddEditForm addItemForm = new CourseAddEditForm(MainWindowReference, 0, 0);
                addItemForm.ShowDialog();
            }
            catch
            {
                //ErrorMessageClass.DisplayErrorMessage(401);
            }
            LoadCourseList();
        }

        private void EditCourse_button_Click(object sender, EventArgs e)
        {
            if (course_ListView.SelectedItems.Count == 1)
            {
                try
                {
                    int course_to_edit = 0;
                    course_to_edit = Convert.ToInt32(course_ListView.SelectedItems[0].Text);
                    CourseAddEditForm editItemForm = new CourseAddEditForm(MainWindowReference, 1, course_to_edit);
                    editItemForm.ShowDialog();
                }
                catch (Exception)
                {
                    //ErrorMessageClass.DisplayErrorMessage(401);
                }
            }
            LoadCourseList();
        }

        private void RemoveCourse_button_Click(object sender, EventArgs e)
        {
            if (course_ListView.SelectedItems.Count == 1)
            {
                DialogResult dlg_result = MessageBox.Show("Are you sure you want to remove selected course?", "Attention!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (dlg_result == DialogResult.Yes)
                {
                    try
                    {
                        using (SqlConnection connection = new SqlConnection(MainW.GetConnectionString()))
                        using (SqlCommand command = new SqlCommand("DELETE FROM Kurs WHERE Id_kursu=@course_id", connection))
                        {
                            connection.Open();
                            command.Parameters.Add("@course_id", SqlDbType.Int);

                            //foreach (ListViewItem location_to_remove in course_ListView.SelectedItems)
                            //{
                                command.Parameters["@course_id"].Value = Convert.ToInt32(course_ListView.SelectedItems[0].Text);
                                int result = command.ExecuteNonQuery();
                                if (result != 1)
                                {
                                    //ErrorMessageClass.DisplayErrorMessage(407);
                                }
                                else
                                {
                                    MessageBox.Show("Course removed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            //}
                        }
                    }
                    catch (Exception)
                    {
                        //ErrorMessageClass.DisplayErrorMessage(408);
                    }
                }
                else
                {
                    course_ListView.SelectedItems.Clear();
                }
                LoadCourseList(); ;
            }
        }

        private void RefreshList_button_Click_1(object sender, EventArgs e)
        {
            LoadCourseList();
        }

        private void Course_ListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (course_ListView.SelectedItems.Count == 1)
            {
                editCourse_button.Enabled = true;
                removeCourse_button.Enabled = true;
            }
            else
            {
                editCourse_button.Enabled = false;
                removeCourse_button.Enabled = false;
            }
        }
    }
}
