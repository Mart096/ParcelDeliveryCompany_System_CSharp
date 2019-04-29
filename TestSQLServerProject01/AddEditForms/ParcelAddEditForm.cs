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
                this.edited_id = edit_id;
                Load_Edited_Parcel_Data(edited_id);
            }
        }

        private void Load_Edited_Parcel_Data(int edited_id)
        {
            DataTable dt = new DataTable();
            DataTable dt1 = new DataTable();

            string command1 = "SELECT * FROM Paczka WHERE Id_paczki = @parcel_id;";
            string command2 = "SELECT Id_cechy_paczki FROM Cecha_Paczki WHERE Id_paczki = @parcel_id;";

            try
            {
                using (SqlConnection connection = new SqlConnection(MainWindowReference.GetConnectionString()))
                using (SqlCommand command = new SqlCommand(command1, connection))
                {
                    command.Parameters.Add("@parcel_id", SqlDbType.Int);
                    command.Parameters["@parcel_id"].Value = edited_id;
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
                command_string = "SELECT * FROM Consignment_Detailed_List_View WHERE Id_przesylki = @consignment_id";
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
                        command.Parameters.Add("@consignment_id", SqlDbType.Int);
                        command.Parameters["@consignment_id"].Value = this.consignment_id;
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
                MessageClass.DisplayMessage(706, "consignments\'");
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

            string operation_string= "INSERT INTO Paczka OUTPUT INSERTED.Id_paczki VALUES(@consignment_id, @weight_cat_id, " +
                                "@size_cat_id);";
            string operation_string2="SELECT Id_cechy_paczki FROM Cecha_Paczki WHERE Id_paczki = @parcel_id;";
            string operation_string3 = "INSERT INTO Cecha_Paczki VALUES (@parcel_id, @property_id);";//(@parcel_id, (SELECT Id_cechy FROM Cecha WHERE Cecha = @property_name))";
            string operation_string4 = "DELETE FROM Cecha_Paczki WHERE Id_paczki = @parcel_id AND Id_cechy_paczki = @property_id";

            if (Check_Input() == true)
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(MainWindowReference.GetConnectionString()))
                    {
                        if (this.current_mode == FormMode.edit)
                        {
                            operation_string = "UPDATE Paczka SET Id_przesylki = @consignment_id, " +
                                "Id_kat_wagowej = @weight_cat_id, Id_gabarytu = @size_cat_id WHERE Id_paczki = @parcel_id";
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
                            command.Parameters.Add("@consignment_id", SqlDbType.Int);
                            command.Parameters.Add("@weight_cat_id", SqlDbType.Int);
                            command.Parameters.Add("@size_cat_id", SqlDbType.Int);

                            command.Parameters["@consignment_id"].Value = Convert.ToInt32(consignment_ListView.SelectedItems[0].Text);
                            command.Parameters["@weight_cat_id"].Value = Convert.ToInt32(weightCategory_listView.SelectedItems[0].Text);
                            command.Parameters["@size_cat_id"].Value = Convert.ToInt32(sizeCategory_listView.SelectedItems[0].Text);

                            if (current_mode == FormMode.edit)
                            {
                                parcel_id = edited_id;

                                command.Parameters.Add("@parcel_id", SqlDbType.Int);

                                command.Parameters["@parcel_id"].Value = parcel_id;

                                //command.Parameters.Add("@property_id", SqlDbType.Int).Value=1;
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
                                command.CommandText = operation_string3;
                                command.Parameters.Add("@parcel_id", SqlDbType.Int).Value = parcel_id;
                                command.Parameters.Add("@property_id", SqlDbType.Int);
                                result = 0;
                                foreach (ListViewItem item in properties_ListView.SelectedItems)
                                {
                                    command.Parameters["@property_id"].Value = Convert.ToInt32(item.Text); //przypisanie id cechy
                                    result = (int)command.ExecuteNonQuery();//dodanie cechy paczki
                                    if (result != 1)
                                        break;
                                }
                            }
                            else
                            {
                                command.Parameters.Add("@parcel_id", SqlDbType.Int).Value = parcel_id;
                                //command.Parameters.Add("@property_name", SqlDbType.NVarChar);
                                command.CommandText = operation_string2;

                                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                                {
                                    adapter.Fill(dt); //pobieranie listy cech paczki
                                }

                                command.CommandText = operation_string3;
                                //command.Parameters.Add("@property_name", SqlDbType.NVarChar);
                                command.Parameters.Add("@property_id", SqlDbType.Int);
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
                                        command.Parameters["@property_id"].Value = Convert.ToInt32(item.Text);
                                        command.ExecuteNonQuery();
                                    }
                                }

                                //command.Parameters.Clear();
                                //command.Parameters.Add("@parcel_id", SqlDbType.Int).Value = parcel_id;
                                //command.Parameters.Add("@property_id", SqlDbType.Int);
                                command.CommandText = operation_string4;
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
                                            break;
                                        }
                                        /*if (found == false)
                                        {
                                            command.Parameters["@property_id"].Value = Convert.ToInt32(value);
                                            result = (int)command.ExecuteNonQuery();
                                        }*/
                                    }
                                    if (found == false)
                                    {
                                        command.Parameters["@property_id"].Value = Convert.ToInt32(value);
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

            if (weightCategory_listView.SelectedItems.Count != 1)
            {
                result = false;
            }
            if (sizeCategory_listView.SelectedItems.Count != 1)
            {
                result = false;
            }
            if (properties_ListView.SelectedItems.Count < 1)
            {
                result = false;
            }
            

            return result;
        }
    }
}
