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

namespace ParcelDeliveryCompany_ClassLibrary1.AddInDetailsForm
{
    public partial class CourseConsignmentAddForm : Form
    {
        private UserClass mainW;
        private int item_id=0;

        public UserClass MainWindowReference { get => mainW; set => mainW = value; }

        public CourseConsignmentAddForm()
        {
            InitializeComponent();
        }

        public CourseConsignmentAddForm(UserClass mW, int course_id)
        {
            InitializeComponent();

            this.MainWindowReference = mW;
            this.item_id = course_id;
            Load_List_Data();
        }

        private void Load_List_Data()
        {
            consignment_ListView.Items.Clear();
            try
            {
                DataTable dt = new DataTable();
                using (SqlConnection connection = new SqlConnection(MainWindowReference.GetConnectionString()))
                using (SqlCommand command = new SqlCommand("SELECT * FROM Consignment_Detailed_List_View WHERE Id_przesylki NOT IN (SELECT Id_przesylki FROM Przesylki_w_kursie WHERE Id_kursu = @item_id) AND Stan_odbioru != @state;", connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    command.Parameters.Add("@item_id", SqlDbType.Int);
                    command.Parameters.Add("@state", SqlDbType.NVarChar);
                    command.Parameters["@item_id"].Value = item_id;
                    command.Parameters["@state"].Value = "Zakończone";

                    adapter.Fill(dt);

                    foreach (DataRow row in dt.Rows)
                    {
                        ListViewItem item = new ListViewItem(row[0].ToString());

                        for (int i = 1; i < row.ItemArray.Count(); i++)
                        {
                            item.SubItems.Add(row[i].ToString());
                        }
                        consignment_ListView.Items.Add(item);
                    }
                }
            }
            catch (Exception)
            {
                MessageClass.DisplayMessage(1701); 
                this.Close();
                this.Dispose();
            }
        }

        private void Accept_button_Click(object sender, EventArgs e)
        {
            if (Check_Input() == true)
            {

                try
                {
                    string insert_command = "INSERT INTO Przesylki_w_kursie VALUES (@consignment_id, @item_id);";


                    using (SqlConnection connection = new SqlConnection(MainWindowReference.GetConnectionString()))
                    using (SqlCommand command = new SqlCommand(insert_command, connection))
                    {
                        command.Parameters.Add("@consignment_id", SqlDbType.Int);
                        command.Parameters["@consignment_id"].Value = consignment_ListView.SelectedItems[0].Text;

                        command.Parameters.Add("@item_id", SqlDbType.Int);
                        command.Parameters["@item_id"].Value = item_id;


                        if (connection.State != ConnectionState.Open)
                        {
                            connection.Open();
                        }

                        int result = command.ExecuteNonQuery();

                        if (result == 0)
                        {
                            MessageClass.DisplayMessage(1702);
                        }
                        if (result == 1)
                        {
                            MessageClass.DisplayMessage(1703); 
                        }
                    }
                }
                catch(Exception /*ex*/)
                {
                    MessageClass.DisplayMessage(1704);
                    
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

        private bool Check_Input()
        {
            bool result = true;

            if (consignment_ListView.SelectedItems.Count != 1 )
                result = false;

            return result;
        }

        private void Cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
