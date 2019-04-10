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

namespace TestSQLServerProject01.DetailsForms
{
    public partial class CourseDetailsForm : Form
    {

        private UserClass mainW;
        internal UserClass MainWindowReference { get => mainW; set => mainW = value; }

        private int object_id;

        public CourseDetailsForm()
        {
            InitializeComponent();
        }

        public CourseDetailsForm(UserClass mW, /*int mode,*/ int object_id)
        {
            InitializeComponent();
            MainWindowReference = mW;
            this.object_id = object_id;
            courseConsignmentsManagement_panel.MainWindowReference = mW;
            courseConsignmentsManagement_panel.SetUserRole();
            //courseConsignmentsManagement_panel.LoadItemList();
            courseConsignmentsManagement_panel.Item_id = object_id;
            courseConsignmentsManagement_panel.LoadItemList();
            Load_Item_Data(this.object_id);
            
        }

        private void Load_Item_Data(int consignment_id)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(MainWindowReference.GetConnectionString()))
                using (SqlCommand command = new SqlCommand("SELECT * FROM Course_Details_View WHERE Id_kursu = @item_id;", connection)) //Id_przesylki IN (SELECT Id_przesylki FROM Przesylki_w_kursie WHERE Id_kursu = @item_id);", connection))
                {
                    command.Parameters.Add("@item_id", SqlDbType.Int);
                    command.Parameters["@item_id"].Value = consignment_id;
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        if (connection.State != ConnectionState.Open)
                        {
                            connection.Open();
                        }
                        adapter.Fill(dt);

                        startPointID_textBox.Text = dt.Rows[0].ItemArray[1].ToString();
                        startPointFullAddress_textbox.Text = dt.Rows[0].ItemArray[2].ToString();
                        endPointID_textbox.Text = dt.Rows[0].ItemArray[3].ToString();
                        endPointFullAddress_textbox.Text = dt.Rows[0].ItemArray[4].ToString();
                        courierID_textbox.Text = dt.Rows[0].ItemArray[5].ToString();
                        courierFullName_textBox.Text = dt.Rows[0].ItemArray[6].ToString();
                    }
                }

            }
            catch (Exception /*ex*/)
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
    }
}
