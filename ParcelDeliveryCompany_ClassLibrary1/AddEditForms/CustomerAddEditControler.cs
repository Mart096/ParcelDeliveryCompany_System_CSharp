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

namespace ParcelDeliveryCompany_ClassLibrary1
{
    public partial class CustomerAddEditControler : UserControl
    {
        private UserClass mainW;
        public UserClass MainWindowReference { get => mainW; set => mainW = value; }

        /*FormMode current_mode = FormMode.add;
        private int edit_id;*/

        /*enum FormMode
        {
            add = 0,
            edit = 1
        };*/

        public CustomerAddEditControler()
        {
            InitializeComponent();
        }

        internal void Load_Customer_To_Edit(int customer_id)
        {
            try
            {
                DataTable dt = new DataTable();
                using (SqlConnection connection = new SqlConnection(MainWindowReference.GetConnectionString()))
                using (SqlCommand command = new SqlCommand("SELECT k.Imie, k.Nazwisko, k.Ulica, m.Nazwa_miasta, k.Nr_domu, k.Nr_mieszkania, k.Kod_pocztowy, k.Numer_telefonu FROM Klient k INNER JOIN Miasto m ON k.Miasto = m.Id_miasta WHERE k.Id_klienta = @client_id", connection))
                {
                    command.Parameters.Add("@client_id", SqlDbType.Int);
                    command.Parameters["@client_id"].Value = customer_id;

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        if (connection.State != ConnectionState.Open)
                            connection.Open();

                        adapter.Fill(dt);

                        firstName_textBox.Text = dt.Rows[0].ItemArray[0].ToString();
                        lastName_textBox.Text = dt.Rows[0].ItemArray[1].ToString();
                        street_TextBox.Text = dt.Rows[0].ItemArray[2].ToString();

                        foreach(ListViewItem city in city_listView.Items)
                        {
                            if(city.Text == dt.Rows[0].ItemArray[3].ToString())
                            {
                                city_listView.Items[city.Index].Selected = true;
                                break;
                            }
                        }

                        houseNumber_textBox.Text = dt.Rows[0].ItemArray[4].ToString();
                        apartmentNum_numeric.Value = Convert.ToInt32(dt.Rows[0].ItemArray[5].ToString());
                        postalCode_textbox.Text = dt.Rows[0].ItemArray[6].ToString();
                        phoneNumber_textBox.Text = dt.Rows[0].ItemArray[7].ToString();
                    }
                }
                
            }
            catch (Exception /*ex*/)
            {
                MessageClass.DisplayMessage(809); //MessageBox.Show(ex.Message+"Failed to load client's data to edit.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private string Insert_New_City(SqlConnection connection)
        {
            try
            {
                string command2_string = "INSERT INTO Miasto OUTPUT INSERTED.Nazwa_miasta VALUES(@city_name, " +
                                "(SELECT Id_strefy FROM Strefa WHERE Nazwa_strefy = @area));";

                using (SqlCommand command02 = new SqlCommand(command2_string, connection))
                {
                    if (connection.State != ConnectionState.Open)
                    {
                        connection.Open();
                    }
                    command02.Parameters.Add("@city_name", SqlDbType.NVarChar);
                    command02.Parameters.Add("@area", SqlDbType.NVarChar);
                    command02.Parameters["@city_name"].Value = newCityName_textBox.Text;
                    command02.Parameters["@area"].Value = newCityArea_listBox.SelectedItems[0].ToString();

                    string added_city = (string)command02.ExecuteScalar();
                    return added_city;
                }
            }
            catch (Exception)
            {
                MessageClass.DisplayMessage(1002); //MessageBox.Show("Failed to add new city during insertion of new order.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return "-";
            }

        }

        internal void Edit_client(SqlConnection connection, int edit_id)
        {
            string command_string = "UPDATE Klient SET " +
                            "Imie = @firstname, Nazwisko = @lastname, Ulica = @street, Miasto = (SELECT Id_miasta FROM Miasto WHERE Nazwa_miasta = @city_name), " +
                            "Nr_domu = @house_number, Nr_mieszkania = @apartment_number, Kod_pocztowy = @postal_code, Numer_telefonu = @phone_number WHERE Id_klienta = @client_id;";
            string city_name;
            if (newCity_checkbox.Checked == true)
            {
                city_name = Insert_New_City(connection);
            }
            else { city_name = city_listView.SelectedItems[0].Text; }
            try
            {
                using (SqlCommand command01 = new SqlCommand(command_string, connection))
                {
                    if (connection.State != ConnectionState.Open)
                    {
                        connection.Open();
                    }
                    command01.Parameters.Add("@firstname", SqlDbType.NVarChar);
                    command01.Parameters.Add("@lastname", SqlDbType.NVarChar);
                    command01.Parameters.Add("@street", SqlDbType.NVarChar);
                    command01.Parameters.Add("@city_name", SqlDbType.NVarChar);
                    command01.Parameters.Add("@house_number", SqlDbType.NChar);
                    command01.Parameters.Add("@apartment_number", SqlDbType.Int);
                    command01.Parameters.Add("@postal_code", SqlDbType.NChar);
                    command01.Parameters.Add("@phone_number", SqlDbType.Char);
                    command01.Parameters.Add("@client_id", SqlDbType.Int);

                    command01.Parameters["@firstname"].Value = firstName_textBox.Text;
                    command01.Parameters["@lastname"].Value = lastName_textBox.Text;
                    command01.Parameters["@street"].Value = street_TextBox.Text;
                    command01.Parameters["@city_name"].Value = city_name;//city_listView.SelectedItems[0].Text;
                    command01.Parameters["@house_number"].Value = houseNumber_textBox.Text;
                    command01.Parameters["@apartment_number"].Value = apartmentNum_numeric.Value;
                    command01.Parameters["@postal_code"].Value = postalCode_textbox.Text;
                    command01.Parameters["@phone_number"].Value = phoneNumber_textBox.Text;
                    command01.Parameters["@client_id"].Value = edit_id;

                    //string sender_id_string = (string)command01.ExecuteScalar();
                    int result = command01.ExecuteNonQuery();

                    if(result == 1)
                    {
                        MessageClass.DisplayMessage(810);//MessageBox.Show("Modifications to customer's data saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception /*ex*/)
            {
                MessageClass.DisplayMessage(811); //MessageBox.Show(/*ex.Message+*/"Failed to save changes to customer's data.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        internal int Insert_New_Sender(SqlConnection connection)
        {
            int sender_id = 0;
            string command_string = "INSERT INTO Klient OUTPUT INSERTED.Id_klienta VALUES " +
                            "(@firstname, @lastname, @street, (SELECT Id_miasta FROM Miasto WHERE Nazwa_miasta = @city_name), " +
                            "@house_number, @apartment_number, @postal_code, @phone_number);";
            string city_name;
            if (newCity_checkbox.Checked == true)
            {
                city_name = Insert_New_City(connection);
            }
            else { city_name = city_listView.SelectedItems[0].Text; }

            try
            {
                /*if(Check_Input() == true)
                {*/
                    using (SqlCommand command01 = new SqlCommand(command_string, connection))
                    {
                        if (connection.State != ConnectionState.Open)
                        {
                            connection.Open();
                        }
                        command01.Parameters.Add("@firstname", SqlDbType.NVarChar);
                        command01.Parameters.Add("@lastname", SqlDbType.NVarChar);
                        command01.Parameters.Add("@street", SqlDbType.NVarChar);
                        command01.Parameters.Add("@city_name", SqlDbType.NVarChar);
                        command01.Parameters.Add("@house_number", SqlDbType.NChar);
                        command01.Parameters.Add("@apartment_number", SqlDbType.Int);
                        command01.Parameters.Add("@postal_code", SqlDbType.NChar);
                        command01.Parameters.Add("@phone_number", SqlDbType.Char);

                        command01.Parameters["@firstname"].Value = firstName_textBox.Text;
                        command01.Parameters["@lastname"].Value = lastName_textBox.Text;
                        command01.Parameters["@street"].Value = street_TextBox.Text;
                        command01.Parameters["@city_name"].Value = city_name;//city_listView.SelectedItems[0].ToString();
                        command01.Parameters["@house_number"].Value = houseNumber_textBox.Text;
                        command01.Parameters["@apartment_number"].Value = apartmentNum_numeric.Value;
                        command01.Parameters["@postal_code"].Value = postalCode_textbox.Text;
                        command01.Parameters["@phone_number"].Value = phoneNumber_textBox.Text;

                        //string sender_id_string = (string)command01.ExecuteScalar();
                        sender_id = Convert.ToInt32(command01.ExecuteScalar());
                        return sender_id;
                    }
                /*}
                else
                {
                    MessageBox.Show("Not all data was specified. Check your input for missing infromation.", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }*/
                
            }
            catch (Exception)
            {
                MessageClass.DisplayMessage(812); //MessageBox.Show("Failed to add new customer.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return -1;
            }
        }

        internal string Get_Selected_City_Name()
        {
            return city_listView.SelectedItems[0].Text;
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

        internal void Load_City_List()
        {
            city_listView.Items.Clear();
            try
            {
                DataTable dt = new DataTable();
                using (SqlConnection connection = new SqlConnection(MainWindowReference.GetConnectionString()))
                using (SqlCommand command = new SqlCommand("SELECT * FROM City_Area_list_View", connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    adapter.Fill(dt);

                    foreach (DataRow row in dt.Rows)
                    {
                        ListViewItem item = new ListViewItem(row[0].ToString());
                        item.SubItems.Add(row[1].ToString());
                        city_listView.Items.Add(item);
                    }
                }
            }
            catch (Exception)
            {
                MessageClass.DisplayMessage(1001);
            }
        }

        internal bool Check_Input()
        {
            bool result = true;

            if (
                (firstName_textBox.Text.Length == 0 || firstName_textBox.Text.Trim().Length == 0) || 
                (lastName_textBox.Text.Length == 0 || lastName_textBox.Text.Trim().Length == 0) ||
                (street_TextBox.Text.Length == 0 || street_TextBox.Text.Trim().Length == 0) ||
                (houseNumber_textBox.Text.Length == 0 || houseNumber_textBox.Text.Trim().Length == 0) ||
                (postalCode_textbox.Text.Length == 0 || postalCode_textbox.Text.Trim().Length == 0)
                )
            {
                result = false;
            }

            if(newCity_checkbox.Checked == false && city_listView.SelectedItems.Count != 1)
            {
                result = false;
            }


            if (newCity_checkbox.Checked == true && (newCityName_textBox.Text.Length == 0 || newCityName_textBox.Text.Trim().Length == 0)
                    && (newCityArea_listBox.SelectedItems.Count != 1))
            {
                    result = false;
            }
            

            return result;
        }

        private void NewCity_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (newCity_checkbox.Checked == true)
            {
                Load_Area_List();
                city_listView.Enabled = false;
                newCityName_textBox.Enabled = true;
                newCityName_textBox.Visible = true;
                newCityName_label.Visible = true;
                newCityArea_listBox.Enabled = true;
                newCityArea_listBox.Visible = true;
                newCityArea_label.Visible = true;
            }
            else
            {
                city_listView.Enabled = true;
                newCityName_textBox.Enabled = false;
                newCityName_textBox.Visible = false;
                newCityName_label.Visible = false;
                newCityArea_listBox.Enabled = false;
                newCityArea_listBox.Visible = false;
                newCityArea_label.Visible = false;
            }
        }

    }
}
