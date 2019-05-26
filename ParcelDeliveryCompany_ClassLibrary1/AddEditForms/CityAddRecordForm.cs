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

namespace ParcelDeliveryCompany_ClassLibrary1.AddEditForms
{
    public partial class CityAddRecordForm : Form
    {
        private UserClass mainW;
        private int edited_record = 0;
        private FormMode current_mode;

        public UserClass MainWindowReference { get => mainW; set => mainW = value; }

        enum FormMode
        {
            add = 0,
            edit = 1
        };

        public CityAddRecordForm()
        {
            InitializeComponent();
            
        }

        public CityAddRecordForm(UserClass mainW)
        {
            InitializeComponent();
            MainWindowReference = mainW;
            /*this.selected_dictionary = selection;
            DictionariesNames dn = (DictionariesNames)selected_dictionary;
            SetDictionaryLabels(dn);*/
            Load_Area_List();
            current_mode = FormMode.add;
        }
        public CityAddRecordForm(UserClass mainW, int record_to_edit)
        {
            InitializeComponent();
            MainWindowReference = mainW;
            this.Text = "Edit selected city";
            //this.selected_dictionary = selection;
            //DictionariesNames dn = (DictionariesNames)selected_dictionary;
            //SetDictionaryLabels(dn);
            this.new_area_Checkbox.Enabled = false;
            this.new_area_Checkbox.Checked = false;
            Load_Area_List();

            this.edited_record = record_to_edit;
            current_mode = FormMode.edit;
            LoadEditedRecordValue(record_to_edit);
        }

        private void LoadEditedRecordValue(int record_to_edit)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(MainWindowReference.GetConnectionString())) //mainW.Connection01
                {
                    string query_string = "";
                    DataTable dt = new DataTable();
                    query_string = "SELECT Nazwa_miasta, Nazwa_strefy FROM City_Details_View WHERE Id_miasta = @Nazwa";

                    using (SqlCommand cmd = new SqlCommand(query_string, connection))
                    {
                        cmd.Parameters.Add("@Nazwa", SqlDbType.Int);
                        cmd.Parameters["@Nazwa"].Value = record_to_edit;
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                            newCityName_textBox.Text = dt.Rows[0].ItemArray[0].ToString();

                            for (int i = 0; i < newCityArea_listBox.Items.Count; i++)//row in newCityArea_listBox.Items)
                            {
                                if(newCityArea_listBox.Items[i].ToString().Equals(dt.Rows[0].ItemArray[1].ToString()))
                                {
                                    newCityArea_listBox.SelectedItem = newCityArea_listBox.Items[i];
                                    break;
                                }
                            }
                        }
                    }
                }
            }
            catch
            {
                MessageClass.DisplayMessage(303);
                this.Close();
                this.Dispose();
            }
        }

        internal void Load_Area_List()
        {
            newCityArea_listBox.Items.Clear();
            try
            {
                DataTable dt = new DataTable();
                using (SqlConnection connection = new SqlConnection(MainWindowReference.GetConnectionString()))
                using (SqlCommand command = new SqlCommand("SELECT Nazwa_strefy FROM Strefa", connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    adapter.Fill(dt);

                    foreach (DataRow row in dt.Rows)
                    {
                        newCityArea_listBox.Items.Add(row[0].ToString());
                    }
                }
            }
            catch (Exception)
            {
                MessageClass.DisplayMessage(901);
            }
        }

        internal bool Check_Input()
        {
            bool result = true;

            if ((newCityName_textBox.Text.Length == 0 || newCityName_textBox.Text.Trim().Length == 0) 
                && (newCityArea_listBox.SelectedItems.Count != 1))
            {
                result = false;
            }
            return result;
        }

        private void Accept_button_Click(object sender, EventArgs e)
        {

            try
            {
                using (SqlConnection connection = new SqlConnection(MainWindowReference.GetConnectionString()))
                {

                    string command_string = "Dodaj_miasto";/*"INSERT INTO Miasto VALUES(@city_name, " +
                                    "(SELECT Id_strefy FROM Strefa WHERE Nazwa_strefy = @area));";*/

                    if(current_mode == FormMode.edit)
                    {
                        command_string = "UPDATE Miasto SET Nazwa_miasta = @Nazwa_miasta, " +
                                    "Id_strefy = (SELECT Id_strefy FROM Strefa WHERE Nazwa_strefy = @Strefa) WHERE Id_miasta = @item_id;";
                    }

                    using (SqlCommand command02 = new SqlCommand(command_string, connection))
                    {
                        if (connection.State != ConnectionState.Open)
                        {
                            connection.Open();
                        }

                        if(current_mode == FormMode.add)
                        {
                            command02.CommandType = CommandType.StoredProcedure;
                        }
                        command02.Parameters.Add("@Nazwa_miasta", SqlDbType.NVarChar);
                        command02.Parameters.Add("@Strefa", SqlDbType.NVarChar);
                        command02.Parameters["@Nazwa_miasta"].Value = newCityName_textBox.Text;

                        if (new_area_Checkbox.Checked == true)
                        {
                            command02.Parameters["@Strefa"].Value = new_area_nameTextBox1.Text;
                        }
                        else
                        {
                            command02.Parameters["@Strefa"].Value = newCityArea_listBox.SelectedItems[0].ToString();
                        }

                        if (current_mode == FormMode.edit)
                        {
                            command02.Parameters.Add("@item_id", SqlDbType.Int).Value = edited_record;
                        }

                        int added_city = command02.ExecuteNonQuery();
                        //return added_city;
                    }
                }
            }
            catch (Exception)
            {
                MessageClass.DisplayMessage(1002); //MessageBox.Show("Failed to add new city during insertion of new order.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                   //return "-";
            }
            this.Close();
            this.Dispose();
        }

        private void Cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void New_area_Checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (new_area_Checkbox.Checked == true)
            {
                newCityArea_listBox.SelectedItems.Clear();
                newCityArea_listBox.Visible = false;
                new_area_nameTextBox1.Visible = true;
            }
            else
            {
                newCityArea_listBox.Visible = true;
                new_area_nameTextBox1.Visible = false;
            }
        }
    }
}
