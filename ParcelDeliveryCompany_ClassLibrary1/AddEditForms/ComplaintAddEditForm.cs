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

namespace ParcelDeliveryCompanyApplication
{
    public partial class ComplaintAddEditForm : Form
    {
        private UserClass mainW;
        private FormMode current_mode;
        private int edited_id;

        public UserClass MainWindowReference { get => mainW; set => mainW = value; }

        enum FormMode
        {
            add = 0,
            edit = 1
        };

        public ComplaintAddEditForm()
        {
            InitializeComponent();
        }

        public ComplaintAddEditForm(UserClass mW, int mode, int edited_id)
        {
            InitializeComponent();
            this.MainWindowReference = mW;
            ToggleMode((FormMode)mode);
            Load_List_Data();

            if (current_mode == FormMode.edit)
            {
                this.edited_id = edited_id;
                Load_Edited_Item(edited_id);
            }
        }

        private void Load_Edited_Item(int edited_id)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(MainWindowReference.GetConnectionString()))
                using (SqlCommand command = new SqlCommand("SELECT * FROM Zgloszenia_reklamacji WHERE Id_zgloszenia_reklamacji = @item_id", connection))
                {
                    command.Parameters.Add("@item_id", SqlDbType.Int);
                    command.Parameters["@item_id"].Value = edited_id;
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        if (connection.State != ConnectionState.Open)
                        {
                            connection.Open();
                        }
                        adapter.Fill(dt);
                        foreach (DataRow row in dt.Rows)
                        {
                            foreach (ListViewItem consignment in consignment_ListView.Items)
                            {
                                if (consignment.Text.Equals(row[1].ToString()))
                                {
                                    int temp_id = consignment.Index;
                                    consignment_ListView.Items[temp_id].Selected = true;
                                    break;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageClass.DisplayMessage(1601); 
                this.Close();
                this.Dispose();
            }
        }

        private void ToggleMode(FormMode current_mode)
        {
            this.current_mode = (FormMode)current_mode;
            if (current_mode == FormMode.add)
            {
                this.Text = "Add new complaint";
                accept_button.Text = "Add complaint";
            }
            else if (current_mode == FormMode.edit)
            {
                this.Text = "Edit complaint";
                accept_button.Text = "Save changes";
            }
        }

        private void Load_List_Data()
        {
            consignment_ListView.Items.Clear();
            try
            {
                DataTable dt = new DataTable();
                using (SqlConnection connection = new SqlConnection(MainWindowReference.GetConnectionString()))
                using (SqlCommand command = new SqlCommand("SELECT * FROM Consignment_Detailed_List_View", connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
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
                MessageClass.DisplayMessage(1602);
            }
        }

        private void Accept_button_Click(object sender, EventArgs e)
        {
            if (Check_Input() == true)
            {

                try
                {
                    string insert_command = "INSERT INTO Zgloszenia_reklamacji VALUES (@consignment_id, @compl_date, @compl_state_id);";
                    string update_command = "UPDATE Zgloszenia_reklamacji SET Id_przesylki = @consignment_id WHERE Id_zgloszenia_reklamacji = @item_id;";

                    string executed_command = insert_command;
                    if (current_mode == FormMode.edit)
                    {
                        executed_command = update_command;
                    }
                    using (SqlConnection connection = new SqlConnection(MainWindowReference.GetConnectionString()))
                    using (SqlCommand command = new SqlCommand(executed_command, connection))
                    {
                        command.Parameters.Add("@consignment_id", SqlDbType.Int);
                        command.Parameters.Add("@compl_date", SqlDbType.Date);
                        command.Parameters.Add("@compl_state_id", SqlDbType.Int);

                        command.Parameters["@consignment_id"].Value = consignment_ListView.SelectedItems[0].Text;
                        command.Parameters["@compl_date"].Value = DateTime.Today;
                        command.Parameters["@compl_state_id"].Value = 1;

                        if (current_mode == FormMode.edit)
                        {
                            command.Parameters.Add("@item_id", SqlDbType.Int);
                            command.Parameters["@item_id"].Value = edited_id;
                        }

                        if (connection.State != ConnectionState.Open)
                        {
                            connection.Open();
                        }

                        int result = command.ExecuteNonQuery();

                        if (result == 0)
                        {
                            if (current_mode == FormMode.add)
                                MessageClass.DisplayMessage(1603); //MessageBox.Show("Failed to add new complaint.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            if (current_mode == FormMode.edit)
                                MessageClass.DisplayMessage(1604); //MessageBox.Show("Failed to save changes to seleceted complaint.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        if (result == 1)
                        {
                            if (current_mode == FormMode.add)
                                MessageClass.DisplayMessage(1605); 
                            if (current_mode == FormMode.edit)
                                MessageClass.DisplayMessage(1606); 
                        }
                    }
                }
                catch
                {
                    if (current_mode == FormMode.add)
                        MessageClass.DisplayMessage(1607); 
                    if (current_mode == FormMode.edit)
                        MessageClass.DisplayMessage(1608);
                }
                this.Close();
                this.Dispose();
            }
            else
            {
                MessageClass.DisplayMessage(1112);//MessageBox.Show("Not all data was specified! Check your input for missing information.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
