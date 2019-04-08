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

namespace TestSQLServerProject01
{
    public partial class CourseMapForm : Form
    {
        private UserClass userItem;

        public CourseMapForm()
        {
            InitializeComponent();
        }

        public UserClass UserItem { get => userItem; set => userItem = value; }

        public void SendCourseDataToMapControl(int course_id)
        {
            try
            {
                string command1 = "SELECT * FROM Course_Details_View WHERE Id_kursu=@item_id";
                string command2 = "SELECT * FROM Course_Consignments_Map_View WHERE Id_kursu = @item_id";
                DataTable dt = new DataTable();
                DataTable dt_point = new DataTable();
                using (SqlConnection connection = new SqlConnection(UserItem.GetConnectionString()))
                using (SqlCommand command = new SqlCommand(command1, connection))
                {
                    command.Parameters.Add("@item_id", SqlDbType.Int);
                    command.Parameters["@item_id"].Value = course_id;

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        connection.Open();
                        adapter.Fill(dt_point);

                        adapter.SelectCommand.CommandText = command2;
                        adapter.Fill(dt);

                        if (Convert.ToInt32(dt_point.Rows[0].ItemArray[1].ToString()) == Convert.ToInt32(dt_point.Rows[0].ItemArray[3].ToString())) //punkt firmowy początkowy taki sam jak końcowy - przesyłki będą dostarczane
                        {
                            string point_location = (dt_point.Rows[0].ItemArray[2].ToString());
                            //point_location.Substring(point_location.Length-)
                            mapControler1.InsertConsignmentFromCourseMarkers(point_location, true); //dodawanie znacznika na punkt startowy
                            foreach (DataRow row in dt.Rows)
                            {
                                mapControler1.InsertConsignmentFromCourseMarkers(row.ItemArray[3].ToString(), false);
                            }
                        }
                        else
                        {
                            mapControler1.InsertCourseBetweenPointsMarkers(dt_point.Rows[0].ItemArray[2].ToString(), dt_point.Rows[0].ItemArray[4].ToString());
                        }
                        //mapControler1.InsertConsignmentFromCourseMarkers(, true); //dodawanie znacznika na punkt startowy
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Failed to send course's data to map control."+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
