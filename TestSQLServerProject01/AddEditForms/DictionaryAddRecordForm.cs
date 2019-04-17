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

namespace ParcelDeliveryCompanyApplication
{
    public partial class DictionaryAddRecordForm : Form
    {
        private UserClass mainW;
        private int selected_dictionary;
        private int edited_record=0;
        private FormMode current_mode;

        enum FormMode
        {
            add = 0,
            edit = 1
        };

        enum DictionariesNames
        {
            none = 0,
            vehicle_type = 1,
            area = 2,
            location_type = 3,
            weight_category = 4,
            size_category = 5,
            properties = 6,
            pickup_state = 7,
            pickup_method = 8,
            consignment_type = 9,
            pickup_request_state = 10,
            complaint_report_state = 11,
            city = 12
        };

        public DictionaryAddRecordForm()
        {
            InitializeComponent();
            selected_dictionary = 0;
            current_mode = FormMode.add;
        }

        public DictionaryAddRecordForm(UserClass mainW, int selection)
        {
            InitializeComponent();
            this.mainW = mainW;
            this.selected_dictionary = selection;
            DictionariesNames dn = (DictionariesNames)selected_dictionary;
            SetDictionaryLabels(dn);
            current_mode = FormMode.add;
        }
        public DictionaryAddRecordForm(UserClass mainW, int selection, int record_to_edit)
        {
            InitializeComponent();
            this.mainW = mainW;
            this.selected_dictionary = selection;
            DictionariesNames dn = (DictionariesNames)selected_dictionary;
            SetDictionaryLabels(dn);

            this.edited_record = record_to_edit;
            current_mode = FormMode.edit;
            LoadEditedRecordValue(record_to_edit);
        }

        private void LoadEditedRecordValue(int record_to_edit)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(mainW.GetConnectionString())) //mainW.Connection01
                {
                    //DataTable dt = new DataTable();
                    string query_string = "";
                    DataTable dt = new DataTable();
                    //przygotowywanie zapytania - parametryzacja zapytania w celu zapobiegania ataku typu SQL injection
                    if (selected_dictionary == (int)DictionariesNames.vehicle_type) query_string = "SELECT Typ_pojazdu FROM Typ_pojazdu WHERE Id_typu_pojazdu = @Nazwa";
                    else if (selected_dictionary == (int)DictionariesNames.area) query_string = "SELECT Nazwa_strefy FROM Strefa WHERE Id_strefy = @Nazwa";
                    else if (selected_dictionary == (int)DictionariesNames.location_type) query_string = "SELECT Typ_budynku FROM Typ_budynku WHERE Id_typu_budynku = @Nazwa";
                    else if (selected_dictionary == (int)DictionariesNames.weight_category) query_string = "SELECT Kategoria_wagowa FROM Kategoria_wagowa WHERE Id_kat_wagowej = @Nazwa";
                    else if (selected_dictionary == (int)DictionariesNames.size_category) query_string = "SELECT Nazwa_gabarytu FROM Gabaryty WHERE Id_gabarytu = @Nazwa";
                    else if (selected_dictionary == (int)DictionariesNames.properties) query_string = "SELECT Cecha FROM Cecha WHERE Id_cechy = @Nazwa";
                    else if (selected_dictionary == (int)DictionariesNames.pickup_state) query_string = "SELECT Stan_odbioru FROM Stan_odbioru WHERE Id_stanu_odbioru = @Nazwa";
                    else if (selected_dictionary == (int)DictionariesNames.pickup_method) query_string = "SELECT Forma_odbioru FROM Forma_odbioru WHERE Id_formy_odbioru = @Nazwa";
                    else if (selected_dictionary == (int)DictionariesNames.consignment_type) query_string = "SELECT Typ_przesylki FROM Typ_przesylki WHERE Id_typu_przesylki = @Nazwa";
                    else if (selected_dictionary == (int)DictionariesNames.pickup_request_state) query_string = "SELECT Stan_zgloszenia_odbioru FROM Stan_zgloszenia_odbioru WHERE Id_stanu_zgloszenia_odbioru = @Nazwa";
                    else if (selected_dictionary == (int)DictionariesNames.complaint_report_state) query_string = "SELECT Stan_reklamacji FROM Stan_reklamacji WHERE Id_stanu_reklamacji = @Nazwa";
                    //else if (selected_dictionary == (int)DictionariesNames.city) query_string = "SELECT Nazwa_miasta, Strefa FROM Miasto WHERE Id_miasta = @Nazwa";

                    using (SqlCommand cmd = new SqlCommand(query_string, connection))
                    {
                        cmd.Parameters.Add("@Nazwa", SqlDbType.Int);
                        cmd.Parameters["@Nazwa"].Value = record_to_edit;
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                            newRecordValue_textBox.Text = dt.Rows[0].ItemArray[0].ToString();
                        }
                    }
                }
            }
            catch
            {
                //MessageBox.Show("Could not load record's data to edit. Error occured!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageClass.DisplayMessage(303);
                this.Close();
                this.Dispose();
            }
        }

        private void Accept_button_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(mainW.GetConnectionString())) //mainW.Connection01
            {
                //DataTable dt = new DataTable();
                string query_string = "";

                //przygotowywanie zapytania - parametryzacja zapytania w celu zapobiegania ataku typu SQL injection
                if(current_mode == FormMode.add)
                {
                    if (selected_dictionary == (int)DictionariesNames.vehicle_type) query_string = "INSERT INTO Typ_pojazdu VALUES(@Nazwa)";
                    else if (selected_dictionary == (int)DictionariesNames.area) query_string = "INSERT INTO  Strefa VALUES(@Nazwa)";
                    else if (selected_dictionary == (int)DictionariesNames.location_type) query_string = "INSERT INTO Typ_budynku VALUES(@Nazwa)"; // Typ_punktu";
                    else if (selected_dictionary == (int)DictionariesNames.weight_category) query_string = "INSERT INTO  Kategoria_wagowa VALUES(@Nazwa)";
                    else if (selected_dictionary == (int)DictionariesNames.size_category) query_string = "INSERT INTO  Gabaryty VALUES(@Nazwa)";
                    else if (selected_dictionary == (int)DictionariesNames.properties) query_string = "INSERT INTO  Cecha VALUES(@Nazwa)";
                    else if (selected_dictionary == (int)DictionariesNames.pickup_state) query_string = "INSERT INTO  Stan_odbioru VALUES(@Nazwa)";
                    else if (selected_dictionary == (int)DictionariesNames.pickup_method) query_string = "INSERT INTO  Forma_odbioru VALUES(@Nazwa)";
                    else if (selected_dictionary == (int)DictionariesNames.consignment_type) query_string = "INSERT INTO  Typ_przesylki VALUES(@Nazwa)";
                    else if (selected_dictionary == (int)DictionariesNames.pickup_request_state) query_string = "INSERT INTO  Stan_zgloszenia_odbioru VALUES(@Nazwa)";
                    else if (selected_dictionary == (int)DictionariesNames.complaint_report_state) query_string = "INSERT INTO  Stan_reklamacji VALUES(@Nazwa)";
                }
                else if(current_mode == FormMode.edit)
                {
                    if (selected_dictionary == (int)DictionariesNames.vehicle_type) query_string = "UPDATE Typ_pojazdu SET Typ_pojazdu = @Nazwa WHERE Id_typu_pojazdu = @id";
                    else if (selected_dictionary == (int)DictionariesNames.area) query_string = "UPDATE Strefa SET Nazwa_strefy = @Nazwa WHERE Id_strefy = @id";
                    else if (selected_dictionary == (int)DictionariesNames.location_type) query_string = "UPDATE Typ_budynku SET Typ_budynku = @Nazwa WHERE Id_typu_budynku = @id";
                    else if (selected_dictionary == (int)DictionariesNames.weight_category) query_string = "UPDATE Kategoria_wagowa SET Kategoria_wagowa = @Nazwa WHERE Id_kat_wagowej = @id";
                    else if (selected_dictionary == (int)DictionariesNames.size_category) query_string = "UPDATE Gabaryty SET Nazwa_gabarytu = @Nazwa WHERE Id_gabarytu = @id";
                    else if (selected_dictionary == (int)DictionariesNames.properties) query_string = "UPDATE Cecha SET Cecha = @Nazwa WHERE Id_cechy = @id";
                    else if (selected_dictionary == (int)DictionariesNames.pickup_state) query_string = "UPDATE Stan_odbioru SET Stan_odbioru = @Nazwa WHERE Id_stanu_odbioru = @id";
                    else if (selected_dictionary == (int)DictionariesNames.pickup_method) query_string = "UPDATE Forma_odbioru SET Forma_odbioru = @Nazwa WHERE Id_formy_odbioru = @id";
                    else if (selected_dictionary == (int)DictionariesNames.consignment_type) query_string = "UPDATE Typ_przesylki SET Typ_przesylki = @Nazwa WHERE Id_typu_przesylki = @id";
                    else if (selected_dictionary == (int)DictionariesNames.pickup_request_state) query_string = "UPDATE Stan_zgloszenia_odbioru SET Stan_zgloszenia_odbioru = @Nazwa WHERE Id_stanu_zgloszenia_odbioru = @id";
                    else if (selected_dictionary == (int)DictionariesNames.complaint_report_state) query_string = "UPDATE Stan_reklamacji SET Stan_reklamacji = @Nazwa WHERE Id_stanu_reklamacji = @id";
                }

                using (SqlCommand cmd = new SqlCommand(query_string, connection))
                {
                    cmd.Parameters.Add("@Nazwa", SqlDbType.NVarChar);
                    cmd.Parameters["@Nazwa"].Value = newRecordValue_textBox.Text;
                    if(current_mode == FormMode.edit)
                    {
                        cmd.Parameters.Add("@id", SqlDbType.Int);
                        cmd.Parameters["@id"].Value = this.edited_record;
                    }

                    try
                    {
                        connection.Open();
                        Int32 cmd_result = cmd.ExecuteNonQuery();
                        //connection.Close();
                    }
                    catch (SqlException /*sqlex*/)
                    {
                        //MessageBox.Show(sqlex.Message);
                        MessageClass.DisplayMessage(302);
                        connection.Close();
                    }
                    catch (Exception /*ex*/)
                    {
                        MessageClass.DisplayMessage(301/*, ex*/);
                        connection.Close();
                    }
                }
                
                //SqlCommand sqlcmd = new SqlCommand(, sqlconnect);
            }
            this.Close();
            this.Dispose();
        }

        private void Cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void SetDictionaryLabels(DictionariesNames current_selection)
        {
            if (current_selection == DictionariesNames.vehicle_type)
            {
                this.Text = "Add new vehicle type";
                this.newRecordValueColumn_label.Text = "New vehicle type name";
                this.newRecordValue_textBox.MaxLength=50;
            }
            else if (current_selection == DictionariesNames.area)
            {
                
                this.Text = "Add new area";
                this.newRecordValueColumn_label.Text = "New area name";
            }
            else if (current_selection == DictionariesNames.location_type)
            {
                this.Text = "Add new company point type";
                this.newRecordValueColumn_label.Text = "New company point type name";
            }
            else if (current_selection == DictionariesNames.weight_category)
            {
                this.Text = "Add new weight category";
                this.newRecordValueColumn_label.Text = "New weight category name";
            }
            else if (current_selection == DictionariesNames.size_category)
            {
                this.Text = "Add new size category";
                this.newRecordValueColumn_label.Text = "New size category name";
            }
            else if (current_selection == DictionariesNames.properties)
            {
                this.Text = "Add new property";
                this.newRecordValueColumn_label.Text = "New property name";
            }
            else if (current_selection == DictionariesNames.pickup_state)
            {
                this.Text = "Add new pickup state";
                this.newRecordValueColumn_label.Text = "New pickup state name";
            }
            else if (current_selection == DictionariesNames.pickup_method)
            {
                this.Text = "Add new pickup method";
                this.newRecordValueColumn_label.Text = "New pickup method name";
            }
            else if (current_selection == DictionariesNames.consignment_type)
            {
                this.Text = "Add new consignment type";
                this.newRecordValueColumn_label.Text = "New pickup consignment type name";
            }
            else if (current_selection == DictionariesNames.pickup_request_state)
            {
                this.Text = "Add new request state";
                this.newRecordValueColumn_label.Text = "New request state name";
            }
            else if (current_selection == DictionariesNames.complaint_report_state)
            {
                this.Text = "Add new complaint report state";
                this.newRecordValueColumn_label.Text = "New complaint report state name";
            }
        }
    }
}
