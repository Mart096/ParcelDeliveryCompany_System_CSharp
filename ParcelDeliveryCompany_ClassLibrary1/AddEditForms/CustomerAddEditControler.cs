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
                string command2_string = "INSERT INTO Miasto OUTPUT INSERTED.Nazwa_miasta VALUES(@Nazwa_miasta, " +
                                "(SELECT Id_strefy FROM Strefa WHERE Nazwa_strefy = @Strefa));";

                using (SqlCommand command02 = new SqlCommand(command2_string, connection))
                {
                    //command02.CommandType = CommandType.StoredProcedure;
                    if (connection.State != ConnectionState.Open)
                    {
                        connection.Open();
                    }
                    command02.Parameters.Add("@Nazwa_miasta", SqlDbType.NVarChar);
                    command02.Parameters.Add("@Strefa", SqlDbType.NVarChar);
                    command02.Parameters["@Nazwa_miasta"].Value = newCityName_textBox.Text;
                    command02.Parameters["@Strefa"].Value = newCityArea_listBox.SelectedItems[0].ToString();

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

        private int Get_City_Id_By_Name(SqlConnection connection, string city_name)
        {
            using (SqlCommand command02 = new SqlCommand("SELECT TOP 1 Id_miasta FROM Miasto WHERE Nazwa_miasta=@Nazwa_Miasta ORDER BY Id_miasta DESC", connection))
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                command02.Parameters.Add("@Nazwa_Miasta", SqlDbType.NVarChar).Value = city_name;
                int return_value = 0;
                return_value=(int)command02.ExecuteScalar();

                return return_value;
            }

            //return 0;
        }

        internal void Edit_client(SqlConnection connection, int edit_id)
        {
            string command_string = "UPDATE Klient SET " +
                            "Imie = @Imie, Nazwisko = @Nazwisko, Ulica = @Ulica, Miasto = (SELECT Id_miasta FROM Miasto WHERE Nazwa_miasta = @Nazwa_miasta), " +
                            "Nr_domu = @Nr_domu, Nr_mieszkania = @Nr_mieszkania, Kod_pocztowy = @Kod_pocztowy, Numer_telefonu = @Numer_telefonu WHERE Id_klienta = @client_id;";
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
                    command01.Parameters.Add("@Imie", SqlDbType.NVarChar);
                    command01.Parameters.Add("@Nazwisko", SqlDbType.NVarChar);
                    command01.Parameters.Add("@Ulica", SqlDbType.NVarChar);
                    command01.Parameters.Add("@Nazwa_miasta", SqlDbType.NVarChar);
                    command01.Parameters.Add("@Nr_domu", SqlDbType.NChar);
                    command01.Parameters.Add("@Nr_mieszkania", SqlDbType.Int);
                    command01.Parameters.Add("@Kod_pocztowy", SqlDbType.NChar);
                    command01.Parameters.Add("@Numer_telefonu", SqlDbType.Char);
                    command01.Parameters.Add("@client_id", SqlDbType.Int);

                    command01.Parameters["@Imie"].Value = firstName_textBox.Text;
                    command01.Parameters["@Nazwisko"].Value = lastName_textBox.Text;
                    command01.Parameters["@Ulica"].Value = street_TextBox.Text;
                    command01.Parameters["@Nazwa_miasta"].Value = city_name;//city_listView.SelectedItems[0].Text;
                    command01.Parameters["@Nr_domu"].Value = houseNumber_textBox.Text;
                    command01.Parameters["@Nr_mieszkania"].Value = apartmentNum_numeric.Value;
                    command01.Parameters["@Kod_pocztowy"].Value = postalCode_textbox.Text;
                    command01.Parameters["@Numer_telefonu"].Value = phoneNumber_textBox.Text;
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
            string command_string = "Dodaj_klienta";/*"INSERT INTO Klient OUTPUT INSERTED.Id_klienta VALUES " +
                            "(@Imie, @Nazwisko, @Ulica, (SELECT Id_miasta FROM Miasto WHERE Nazwa_miasta = @Nazwa_miasta), " +
                            "@Nr_domu, @Nr_mieszkania, @Kod_pocztowy, @Numer_telefonu);";*/
            string city_name;
            int city_id;
            if (newCity_checkbox.Checked == true)
            {
                city_name = Insert_New_City(connection);
                city_id = Get_City_Id_By_Name(connection, city_name);
            }
            else
            {
                city_name = city_listView.SelectedItems[0].Text;
                city_id = Get_City_Id_By_Name(connection, city_name);
            }

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
                    command01.CommandType = CommandType.StoredProcedure;

                    command01.Parameters.AddWithValue("@Imie", firstName_textBox.Text);
                    command01.Parameters.AddWithValue("@Nazwisko", lastName_textBox.Text);
                    command01.Parameters.AddWithValue("@Ulica", street_TextBox.Text);
                    command01.Parameters.AddWithValue("@Id_Miasta", city_id);
                    command01.Parameters.AddWithValue("@Nr_domu", houseNumber_textBox.Text);
                    command01.Parameters.AddWithValue("@Nr_mieszkania", apartmentNum_numeric.Value);
                    command01.Parameters.AddWithValue("@Kod_pocztowy", postalCode_textbox.Text);
                    command01.Parameters.AddWithValue("@Numer_telefonu", phoneNumber_textBox.Text);
                    /*command01.Parameters.Add("@Imie", SqlDbType.NVarChar);
                    command01.Parameters.Add("@Nazwisko", SqlDbType.NVarChar);
                    command01.Parameters.Add("@Ulica", SqlDbType.NVarChar);
                    command01.Parameters.Add("@Id_Miasta", SqlDbType.NVarChar);
                    command01.Parameters.Add("@Nr_domu", SqlDbType.NChar);
                    command01.Parameters.Add("@Nr_mieszkania", SqlDbType.Int);
                    command01.Parameters.Add("@Kod_pocztowy", SqlDbType.NChar);
                    command01.Parameters.Add("@Numer_telefonu", SqlDbType.Char);

                    command01.Parameters["@Imie"].Value = firstName_textBox.Text;
                    command01.Parameters["@Nazwisko"].Value = lastName_textBox.Text;
                    command01.Parameters["@Ulica"].Value = street_TextBox.Text;
                    command01.Parameters["@Id_Miasta"].Value = city_id;//city_listView.SelectedItems[0].ToString();
                    command01.Parameters["@Nr_domu"].Value = houseNumber_textBox.Text;
                    command01.Parameters["@Nr_mieszkania"].Value = apartmentNum_numeric.Value;
                    command01.Parameters["@Kod_pocztowy"].Value = postalCode_textbox.Text;
                    command01.Parameters["@Numer_telefonu"].Value = phoneNumber_textBox.Text;*/

                    //string sender_id_string = (string)command01.ExecuteScalar
                    SqlParameter result_param = command01.Parameters.Add("RetVal", SqlDbType.Int);
                    result_param.Direction = ParameterDirection.ReturnValue;
                    command01.ExecuteNonQuery();
                    sender_id = Convert.ToInt32(result_param.Value);
                    //sender_id = Convert.ToInt32(command01.ExecuteScalar()); //stara wersja - bez procedury
                    return sender_id;
                }
                /*}
                else
                {
                    MessageBox.Show("Not all data was specified. Check your input for missing infromation.", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }*/
                
            }
            catch (Exception /*ex*/)
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
