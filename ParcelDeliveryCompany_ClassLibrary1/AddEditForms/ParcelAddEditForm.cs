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

namespace ParcelDeliveryCompany_ClassLibrary1
{
    public partial class ParcelAddEditForm : Form
    {
        private UserClass mainW;

        public UserClass MainWindowReference { get => mainW; set => mainW = value; }
        private FormMode current_mode;
        private int edited_id;
        private int consignment_id=0;

        enum FormMode
        {
            add=0,
            edit=1
        };

        public ParcelAddEditForm()
        {
            InitializeComponent();
        }

        public ParcelAddEditForm(UserClass mW, int mode, int edit_id, int consignment_id)
        {
            InitializeComponent();
            MainWindowReference = mW;
            current_mode = (FormMode)mode;
            this.consignment_id = consignment_id;
            ToggleFormMode(current_mode);
            Load_Consignments_List();
            Load_WeightCategory_Items();
            Load_SizeCategory_Items();
            Load_Properties_Items();

            if(current_mode == FormMode.edit)
            {
                new_weight_category_checkBox.Enabled = false;
                new_size_category_checkBox.Enabled = false;
                this.edited_id = edit_id;
                Load_Edited_Parcel_Data(edited_id);
            }
        }

        private void Load_Edited_Parcel_Data(int edited_id)
        {
            DataTable dt = new DataTable();
            DataTable dt1 = new DataTable();

            string command1 = "SELECT * FROM Paczka WHERE Id_paczki = @Id_paczki;";
            string command2 = "SELECT Id_cechy_paczki FROM Cecha_Paczki WHERE Id_paczki = @Id_paczki;";

            try
            {
                using (SqlConnection connection = new SqlConnection(MainWindowReference.GetConnectionString()))
                using (SqlCommand command = new SqlCommand(command1, connection))
                {
                    command.Parameters.Add("@Id_paczki", SqlDbType.Int);
                    command.Parameters["@Id_paczki"].Value = edited_id;
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        if (connection.State != ConnectionState.Open)
                        {
                            connection.Open();
                        }
                        adapter.Fill(dt);
                        foreach (ListViewItem consignment in consignment_ListView.Items)
                        {
                            if (consignment.Text.Equals(dt.Rows[0].ItemArray[1].ToString()))
                            {
                                int temp_id = consignment.Index;
                                consignment_ListView.Items[temp_id].Selected = true;
                                break;
                            }
                        }

                        foreach (ListViewItem weight_cat in weightCategory_listView.Items)
                        {
                            if (weight_cat.Text.Equals(dt.Rows[0].ItemArray[2].ToString()))
                            {
                                int temp_id = weight_cat.Index;
                                weightCategory_listView.Items[temp_id].Selected = true;
                                break;
                            }
                        }

                        foreach (ListViewItem size_cat in sizeCategory_listView.Items)
                        {
                            if (size_cat.Text.Equals(dt.Rows[0].ItemArray[3].ToString()))
                            {
                                int temp_id = size_cat.Index;
                                sizeCategory_listView.Items[temp_id].Selected = true;
                                break;
                            }
                        }

                        //ta pętla powinna zostać wykorzystana po wykonaniu zapytania z command2
                        /*command.CommandText = command2;
                        command.CommandType = CommandType.Text;*/
                        adapter.SelectCommand.CommandText = command2;
                        adapter.Fill(dt1);

                        foreach (ListViewItem property in properties_ListView.Items)
                        {
                            //foreach (var item in dt1.Rows/*[0].ItemArray*/)
                            for (int i=0; i<dt1.Rows.Count; i++)
                            {
                                if (property.Text.Equals(dt1.Rows[i].ItemArray[0].ToString()))
                                {
                                    int temp_id = property.Index;
                                    properties_ListView.Items[temp_id].Selected = true;
                                }

                                /*if (property.Text.Equals(item.ToString()))
                                {
                                    int temp_id = property.Index;
                                    properties_ListView.Items[temp_id].Selected = true;
                                }*/
                            }
                        }
                    }
                }
            }
            catch (Exception /*ex-*/)
            {
                MessageClass.DisplayMessage(1401);
                this.Close();
                this.Dispose();
            }
        }


        private void ToggleFormMode(FormMode current_mode)
        {
            this.current_mode = current_mode;

            if (this.current_mode == FormMode.add)
            {
                this.Text = "Add new parcel";
                this.accept_button.Text = "Add parcel";
            }
            else if (this.current_mode == FormMode.edit)
            {
                this.Text = "Edit selected parcel";
                this.accept_button.Text = "Save changes";
            }
        }

        internal void Load_Consignments_List()
        {
            consignment_ListView.Items.Clear();
            string command_string = "SELECT * FROM Consignment_Detailed_List_View";
            if (consignment_id != 0)
            {
                command_string = "SELECT * FROM Consignment_Detailed_List_View WHERE Id_przesylki = @Id_przesylki";
            }
            try
            {
                DataTable dt = new DataTable();
                using (SqlConnection connection = new SqlConnection(MainWindowReference.GetConnectionString()))
                using (SqlCommand command = new SqlCommand(command_string, connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    if(consignment_id != 0)
                    {
                        command.Parameters.Add("@Id_przesylki", SqlDbType.Int);
                        command.Parameters["@Id_przesylki"].Value = this.consignment_id;
                    }
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
                    if (consignment_id != 0)
                    {
                        consignment_ListView.Enabled = false;
                        consignment_ListView.Items[0].Selected = true;
                    }
                }
            }
            catch (Exception)
            {
                MessageClass.DisplayMessage(706, "consignments'");
                //MessageBox.Show("Could not load consignments\' list.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        internal void Load_WeightCategory_Items()
        {
            weightCategory_listView.Items.Clear();

            string command_string = "SELECT * FROM Kategoria_wagowa;";

            try
            {
                DataTable dt = new DataTable();
                using (SqlConnection connection = new SqlConnection(MainWindowReference.GetConnectionString()))
                using (SqlCommand command = new SqlCommand(command_string, connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    connection.Open();
                    adapter.Fill(dt);

                    foreach (DataRow row in dt.Rows)
                    {
                        ListViewItem item = new ListViewItem(row.ItemArray[0].ToString());
                        item.SubItems.Add(row.ItemArray[1].ToString());
                        weightCategory_listView.Items.Add(item);
                    }
                }
            }
            catch (Exception /*ex*/)
            {
                MessageClass.DisplayMessage(706, "weight categories\'");
                //MessageBox.Show(ex.Message+"Could not load weight categories' list.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        internal void Load_SizeCategory_Items()
        {
            sizeCategory_listView.Items.Clear();

            string command_string = "SELECT * FROM Gabaryty;";

            try
            {
                DataTable dt = new DataTable();
                using (SqlConnection connection = new SqlConnection(MainWindowReference.GetConnectionString()))
                using (SqlCommand command = new SqlCommand(command_string, connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    connection.Open();
                    adapter.Fill(dt);

                    foreach (DataRow row in dt.Rows)
                    {
                        ListViewItem item = new ListViewItem(row.ItemArray[0].ToString());
                        item.SubItems.Add(row.ItemArray[1].ToString());
                        sizeCategory_listView.Items.Add(item);
                    }
                }
            }
            catch (Exception /*ex*/)
            {
                MessageClass.DisplayMessage(706, "size categories\'");
                //MessageBox.Show(ex.Message+"Could not load size categories' list.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        internal void Load_Properties_Items()
        {
            properties_ListView.Items.Clear();

            string command_string = "SELECT * FROM Cecha;";

            try
            {
                DataTable dt = new DataTable();
                using (SqlConnection connection = new SqlConnection(MainWindowReference.GetConnectionString()))
                using (SqlCommand command = new SqlCommand(command_string, connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    connection.Open();
                    adapter.Fill(dt);

                    foreach (DataRow row in dt.Rows)
                    {
                        ListViewItem item = new ListViewItem(row.ItemArray[0].ToString());
                        item.SubItems.Add(row.ItemArray[1].ToString());
                        properties_ListView.Items.Add(item);
                    }
                }
            }
            catch (Exception /*ex*/)
            {
                MessageClass.DisplayMessage(706, "properties\'");
                //MessageBox.Show(ex.Message+"Could not load properties' list.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Accept_button_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            string operation_string = "Dodaj_paczke";//"INSERT INTO Paczka OUTPUT INSERTED.Id_paczki VALUES(@Id_przesylki, @weight_cat_id, @size_cat_id);";
            string operation_string2= "SELECT Id_cechy_paczki FROM Cecha_Paczki WHERE Id_paczki = @Id_paczki;";
            string operation_string3 = "Dodaj_ceche_paczki";//"INSERT INTO Cecha_Paczki VALUES (@Id_paczki, @Id_cechy);";//(@Id_paczki, (SELECT Id_cechy FROM Cecha WHERE Cecha = @property_name))";
            string operation_string4 = "DELETE FROM Cecha_Paczki WHERE Id_paczki = @Id_paczki AND Id_cechy_paczki = @Id_cechy";

            if (Check_Input() == true)
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(MainWindowReference.GetConnectionString()))
                    {
                        if (this.current_mode == FormMode.edit)
                        {
                            operation_string = "UPDATE Paczka SET Id_przesylki = @Id_przesylki, " +
                                "Id_kat_wagowej = @weight_cat_id, Id_gabarytu = @size_cat_id WHERE Id_paczki = @Id_paczki";
                        }
                        //!!!
                        //Należy sprawdzić jakie cechy ma paczka i usunąć te cechy, które zostały odznaczone, i dodać nowe, jeszcze nie dodane to tabeli
                        //!!!
                        /*using (SqlTransaction transaction = connection.BeginTransaction())
                        {*/

                        using (SqlCommand command = new SqlCommand(operation_string, connection/*, transaction*/))
                        {
                            if (connection.State != ConnectionState.Open)
                            {
                                connection.Open();
                            }

                            int parcel_id = 0;
                            command.Parameters.Add("@Id_przesylki", SqlDbType.Int);
                            command.Parameters["@Id_przesylki"].Value = Convert.ToInt32(consignment_ListView.SelectedItems[0].Text);

                            if (current_mode == FormMode.add)
                            {
                                command.CommandType = CommandType.StoredProcedure;

                                if (new_weight_category_checkBox.Checked == true)
                                {
                                    command.Parameters.AddWithValue("@Kategoria_wagowa", new_weight_category_textBox.Text);
                                }
                                else
                                {
                                    command.Parameters.AddWithValue("@Kategoria_wagowa", weightCategory_listView.SelectedItems[0].SubItems[1].Text);
                                }

                                if (new_size_category_checkBox.Checked == true)
                                {
                                    command.Parameters.AddWithValue("@Gabaryt", new_size_category_textBox.Text);
                                }
                                else
                                {
                                    command.Parameters.AddWithValue("@Gabaryt", sizeCategory_listView.SelectedItems[0].SubItems[1].Text);
                                }
                                
                            }
                            else if (current_mode == FormMode.edit)
                            {
                                command.Parameters.Add("@weight_cat_id", SqlDbType.Int);
                                command.Parameters.Add("@size_cat_id", SqlDbType.Int);

                                command.Parameters["@weight_cat_id"].Value = Convert.ToInt32(weightCategory_listView.SelectedItems[0].Text);
                                command.Parameters["@size_cat_id"].Value = Convert.ToInt32(sizeCategory_listView.SelectedItems[0].Text);
                            }
                            

                            /*command.Parameters.Add("@weight_cat_id", SqlDbType.Int);
                            command.Parameters.Add("@size_cat_id", SqlDbType.Int);*/

                            
                            /*command.Parameters["@weight_cat_id"].Value = Convert.ToInt32(weightCategory_listView.SelectedItems[0].Text);
                            command.Parameters["@size_cat_id"].Value = Convert.ToInt32(sizeCategory_listView.SelectedItems[0].Text);*/

                            if (current_mode == FormMode.edit)
                            {
                                parcel_id = edited_id;

                                command.Parameters.Add("@Id_paczki", SqlDbType.Int);

                                command.Parameters["@Id_paczki"].Value = parcel_id;

                                //command.Parameters.Add("@Id_cechy", SqlDbType.Int).Value=1;
                                command.ExecuteNonQuery();
                            }
                            else
                            {
                                parcel_id = (int)command.ExecuteScalar();
                            }


                            //Aktualizacja tabeli cech paczki
                            int result = 0;

                            command.Parameters.Clear();
                            if (current_mode == FormMode.add)
                            {
                                command.CommandType = CommandType.StoredProcedure;
                                command.CommandText = operation_string3;
                                command.Parameters.Add("@Id_paczki", SqlDbType.Int).Value = parcel_id;
                                command.Parameters.Add("@Cecha", SqlDbType.NVarChar);
                                result = 0;
                                foreach (ListViewItem item in properties_ListView.SelectedItems)
                                {
                                    command.Parameters["@Cecha"].Value = item.SubItems[1].Text; //przypisanie nazwy cechy
                                    result = (int)command.ExecuteNonQuery();//dodanie cechy paczki
                                    if (result != 1)
                                        break;
                                }
                                if (new_property_checkBox.Checked == true)
                                {
                                    command.Parameters["@Cecha"].Value = new_property_textBox.Text; //przypisanie nazwy cechy
                                    result = (int)command.ExecuteNonQuery();//dodanie cechy paczki
                                }
                            }
                            else
                            {
                                command.Parameters.Add("@Id_paczki", SqlDbType.Int).Value = parcel_id;
                                //command.Parameters.Add("@property_name", SqlDbType.NVarChar);
                                command.CommandType = CommandType.Text;
                                command.CommandText = operation_string2;

                                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                                {
                                    adapter.Fill(dt); //pobieranie listy cech paczki
                                }

                                command.CommandType = CommandType.StoredProcedure;
                                command.CommandText = operation_string3;
                                //command.Parameters.Add("@property_name", SqlDbType.NVarChar);
                                //command.Parameters.Add("@Id_cechy", SqlDbType.Int);
                                command.Parameters.Add("@Cecha", SqlDbType.NVarChar);
                                foreach (ListViewItem item in properties_ListView.SelectedItems) //dodawanie cech, które nie były zaznaczone
                                {
                                    bool found = false;
                                    for (int i = 0; i < dt.Rows.Count; i++)
                                    {
                                        string value = dt.Rows[i].ItemArray[0].ToString();
                                        if (item.Text.Equals(value))
                                        {
                                            found = true;
                                            break;
                                        }
                                    }
                                    if (found == false)
                                    {
                                        command.Parameters["@Cecha"].Value = item.SubItems[1].Text;//Convert.ToInt32(item.Text);
                                        command.ExecuteNonQuery();
                                    }
                                }
                                int added_property_id = 0;
                                int added_property_listview_id = 0;
                                if (new_property_checkBox.Checked == true)
                                {
                                    command.Parameters["@Cecha"].Value = new_property_textBox.Text;//Convert.ToInt32(item.Text);
                                    added_property_id = (int)command.ExecuteScalar();
                                    ListViewItem new_property = new ListViewItem(added_property_id.ToString());
                                    new_property.SubItems.Add(new_property_textBox.Text);

                                    added_property_listview_id=properties_ListView.Items.Add(new_property).Index;
                                    properties_ListView.Items[added_property_listview_id].Selected = true;
                                    
                                }

                                //command.Parameters.Clear();
                                //command.Parameters.Add("@Id_paczki", SqlDbType.Int).Value = parcel_id;
                                //command.Parameters.Add("@Id_cechy", SqlDbType.Int);
                                command.CommandType = CommandType.Text;
                                command.Parameters.Clear();
                                command.CommandText = operation_string4;
                                //command.Parameters.Remove("@Cecha");
                                command.Parameters.AddWithValue("@Id_paczki", parcel_id);
                                command.Parameters.Add("@Id_cechy", SqlDbType.Int);
                                //usuwanie cech, które zostały odznaczone
                                for (int i = 0; i < dt.Rows.Count; i++)
                                {
                                    bool found = false;
                                    string value = dt.Rows[i].ItemArray[0].ToString();
                                    foreach (ListViewItem item in properties_ListView.SelectedItems) //porównanie z każdym zaznaczonym rekordem w liście cech
                                    {

                                        if (value.Equals(item.Text))
                                        {
                                            found = true;
                                            result = 1;
                                            break;
                                        }
                                        /*if (found == false)
                                        {
                                            command.Parameters["@Id_cechy"].Value = Convert.ToInt32(value);
                                            result = (int)command.ExecuteNonQuery();
                                        }*/
                                    }
                                    if (found == false)
                                    {
                                        command.Parameters["@Id_cechy"].Value = Convert.ToInt32(value);
                                        //command.Parameters["@Cecha"].Value=
                                        result = (int)command.ExecuteNonQuery();
                                    }
                                }
                                //}
                            }

                            if (result == 0)
                            {
                                MessageClass.DisplayMessage(604);
                                //MessageBox.Show("Query failed! Please, try again later.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            /*else if (result > 1)
                            {
                                MessageClass.DisplayMessage(703);
                                //MessageBox.Show("Query unexpected behaviour detected! Please contact your data base administrator and let them know about issue.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }*/
                            else if (result >= 1 && this.current_mode == FormMode.add)
                                MessageClass.DisplayMessage(1402); //MessageBox.Show("New parcel added successfully!", "Success", MessageBoxButtons.OK);
                            else if (result >= 1 && this.current_mode == FormMode.edit)
                                MessageClass.DisplayMessage(1403);  //MessageBox.Show("Selected parcel has been updated successfully!", "Success", MessageBoxButtons.OK);
                        }
                        //}

                    }
                    this.Close();
                    this.Dispose();
                }
                catch (Exception /*ex*/)
                {
                    //MessageBox.Show(ex.Message);
                    if (this.current_mode == FormMode.add)
                        MessageClass.DisplayMessage(1404); //MessageBox.Show("Failed to save new order's details." + ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else if (this.current_mode == FormMode.edit)
                        MessageClass.DisplayMessage(1405); //MessageBox.Show("Failed to save changes to selected order.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Close();
                    this.Dispose();
                }
            }
            else
            {
                MessageClass.DisplayMessage(1112);
                //MessageBox.Show("Not all data was specified. Check your input for missing information.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        internal bool Check_Input()
        {
            bool result = true;

            if (consignment_ListView.SelectedItems.Count != 1)
            {
                result = false;
            }

            if (new_weight_category_checkBox.Checked==false && weightCategory_listView.SelectedItems.Count != 1)
            {
                result = false;
            }
            else if (new_weight_category_checkBox.Checked == true && (new_weight_category_textBox.Text.Length==0 || new_weight_category_textBox.Text.Trim().Length == 0))
            {
                result = false;
            }

            if (new_size_category_checkBox.Checked==false && sizeCategory_listView.SelectedItems.Count != 1)
            {
                result = false;
            }
            else if(new_size_category_checkBox.Checked==true && (new_size_category_textBox.Text.Length==0 || new_size_category_textBox.Text.Trim().Length == 0))
            {
                result = false;
            }

            if (new_property_checkBox.Checked==false && properties_ListView.SelectedItems.Count < 1)
            {
                result = false;
            }
            if(new_property_checkBox.Checked==true && (new_property_textBox.Text.Length==0 || new_property_textBox.Text.Trim().Length == 0))
            {
                result = false;
            }
            

            return result;
        }

        private void New_weight_category_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (new_weight_category_checkBox.Checked==true)
            {
                weightCategory_listView.SelectedItems.Clear();
                weightCategory_listView.Visible = false;
                new_weight_category_textBox.Visible = true;
            }
            else
            {
                weightCategory_listView.Visible = true;
                new_weight_category_textBox.Visible = false;
            }
        }

        private void New_size_category_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (new_size_category_checkBox.Checked == true)
            {
                sizeCategory_listView.SelectedItems.Clear();
                sizeCategory_listView.Visible = false;
                new_size_category_textBox.Visible = true;
            }
            else
            {
                sizeCategory_listView.Visible = true;
                new_size_category_textBox.Visible = false;
            }
        }

        private void New_property_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (new_property_checkBox.Checked == true)
            {
                //properties_ListView.SelectedItems.Clear();
                properties_ListView.Visible = false;
                new_property_textBox.Visible = true;
            }
            else
            {
                properties_ListView.Visible = true;
                new_property_textBox.Visible = false;
            }
        }
    }
}
