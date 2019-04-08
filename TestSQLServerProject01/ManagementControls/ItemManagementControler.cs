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

namespace TestSQLServerProject01
{
    [TypeDescriptionProvider(typeof(AbstractControlDescriptionProvider<ItemManagementControler, UserControl>))]// rozwiązanie stosowane w celu umożliwienia tworzenia kontrolek abstrakcyjnych bez nadmiarowych pośredników (tzw. middlecontrol).
    public partial class ItemManagementControler : UserControl
    {
        private UserClass mainW;
        private bool control_data_set = false;
        private string list_refresh_command;
        private string remove_command;
        private int removed_item_id = 0;
        private bool details_button_disabled=false;
        private string item_name;
        private string item_name_capital_letter;
        private string item_name_plural;
        private string item_name_plural_capital_letter;

        protected internal enum UserRole
        {
            Admin = 0,
            Dispatcher = 1,
            Courier = 2,
            OrderManager = 3,
            CustomerContact = 4
        };

        public ItemManagementControler()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="v1">Database query to fill item list view.</param>
        /// <param name="v2">Database query to remove selected item in the list view.</param>
        /// <param name="v3">Name of the item (lower letter).</param>
        /// <param name="v4">Name of the item (capital letter).</param>
        protected internal void SetControlBasicData(string v1, string v2, string v3, string v4)
        {
            if (this.control_data_set == false)
            {
                List_refresh_command = v1;
                Remove_command = v2;
                Item_name = v3;
                Item_name_plural = v3 + "s";
                Item_name_capital_letter = v4;
                Item_name_plural_capital_letter = v4 + "s";
                SetControlNames();
                this.control_data_set = true;
            }
    }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="v1">Database query to fill item list view.</param>
        /// <param name="v2">Database query to remove selected item in the list view.</param>
        /// <param name="v3">Name of the item (lower letter).</param>
        /// <param name="v4">Name of the item (capital letter).</param>
        /// <param name="v5">Name of the item (plural).</param>
        /// <param name="v6">Name of the item (plural, capital letter).</param>
        protected internal void SetControlBasicData(string v1, string v2, string v3, string v4, string v5, string v6)
        {
            if (this.control_data_set == false)
            {
                List_refresh_command = v1;
                Remove_command = v2;
                Item_name = v3;
                Item_name_capital_letter = v4;
                Item_name_plural = v5;
                Item_name_plural_capital_letter = v6;
                SetControlNames();
                this.control_data_set = true;
            }
        }

        /// <summary>
        /// Method used to hide item details button for certain controls.
        /// </summary>
        /// <param name="state"></param>
        protected internal void Disable_Details_Button(bool state)
        {
            Details_button_disabled = state;
            if (this.Details_button_disabled == true)
            {
                //itemDetails_button.Enabled = false;
                itemDetails_button.Visible = false;
            }
            if (this.Details_button_disabled == false)
            {
                //itemDetails_button.Enabled = true;
                itemDetails_button.Visible = true;
            }

        }

        

        public UserClass MainWindowReference { get => mainW; set => mainW = value; }
        protected int Removed_item_id { get => removed_item_id; set => removed_item_id = value; }
        protected string List_refresh_command { get => list_refresh_command; set => list_refresh_command = value; }
        protected string Remove_command { get => remove_command; set => remove_command = value; }
        protected string Item_name { get => item_name; set => item_name = value; }
        protected string Item_name_capital_letter { get => item_name_capital_letter; set => item_name_capital_letter = value; }
        public string Item_name_plural { get => item_name_plural; set => item_name_plural = value; }
        public string Item_name_plural_capital_letter { get => item_name_plural_capital_letter; set => item_name_plural_capital_letter = value; }
        public bool Details_button_disabled { get => details_button_disabled; set => details_button_disabled = value; }

        protected virtual void AddItem_button_Click(object sender, EventArgs e)
        {

        }

        protected virtual void EditItem_button_Click(object sender, EventArgs e)
        {

        }

        protected virtual void ItemDetails_button_Click(object sender, EventArgs e)
        {

        }

        protected virtual void RemoveItem_button_Click(object sender, EventArgs e)
        {
            if (item_ListView.SelectedItems.Count == 1)
            {
                DialogResult dlg_result = MessageBox.Show("Are you sure you want to remove selected "+ this.Item_name+"?", "Attention!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (dlg_result == DialogResult.Yes)
                {
                    try
                    {
                        using (SqlConnection connection = new SqlConnection(MainWindowReference.GetConnectionString()))
                        using (SqlCommand command = new SqlCommand(this.Remove_command, connection))
                        {
                            connection.Open();
                            command.Parameters.Add("@item_id", SqlDbType.Int);
                            command.Parameters["@item_id"].Value = Convert.ToInt32(item_ListView.SelectedItems[0].Text);

                            int result = command.ExecuteNonQuery();
                            if (result != 1)
                            {
                                //ErrorMessageClass.DisplayErrorMessage(407);
                            }
                            else
                            {
                                MessageBox.Show(this.Item_name_capital_letter+" removed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        //ErrorMessageClass.DisplayErrorMessage(408);
                    }
                }
                else
                {
                    item_ListView.SelectedItems.Clear();
                }
                item_ListView.SelectedItems.Clear();
                LoadItemList();
            }
        }

        protected virtual void RefreshList_button_Click(object sender, EventArgs e)
        {
            LoadItemList();
        }

        internal virtual void LoadItemList()
        {
            item_ListView.Items.Clear();

            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(MainWindowReference.GetConnectionString()))
                using (SqlCommand command = new SqlCommand(this.List_refresh_command, connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    adapter.Fill(dt);

                    //wypełnianie listy
                    foreach (DataRow row in dt.Rows)
                    {
                        ListViewItem item = new ListViewItem(row[0].ToString());
                        int check_column = 0;
                        foreach(var column in row.ItemArray)
                        {
                            if (check_column > 0)
                            {
                                item.SubItems.Add(column.ToString());
                            }
                            check_column += 1;
                        }
                        item_ListView.Items.Add(item);
                    }
                }
            }
            catch (SqlException ex)
            {
                //ErrorMessageClass.DisplayErrorMessage(411);
                MessageBox.Show("Could not load " + Item_name_plural + " list. Query failed." + ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                //ErrorMessageClass.DisplayErrorMessage(410);
                MessageBox.Show("Could not load " + Item_name_plural + " list. "+ ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        protected virtual void Item_ListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (item_ListView.SelectedItems.Count == 1)
            {
                itemDetails_button.Enabled = true;
                editItem_button.Enabled = true;
                removeItem_button.Enabled = true;
                Removed_item_id = Convert.ToInt32(item_ListView.SelectedItems[0].Text);
            }
            else
            {
                itemDetails_button.Enabled = false;
                editItem_button.Enabled = false;
                removeItem_button.Enabled = false;
                removed_item_id = 0;
            }
        }

        protected void SetControlNames()
        {
            if (Item_name != null && Item_name_capital_letter != null)
            {
                if(Item_name.Trim().Length != 0 && Item_name_capital_letter.Trim().Length != 0)
                {
                    addItem_button.Text = "Add " + Item_name;
                    itemDetails_button.Text = Item_name_capital_letter + " details";
                    editItem_button.Text = "Edit " + Item_name;
                    removeItem_button.Text = "Remove " + Item_name;
                    itemTitle_label.Text = Item_name_capital_letter + "s";
                }
            }
        }

        protected virtual void CreateColumns()
        {
            //tworzenie kolumn
            item_ListView.Columns.Clear();
            item_ListView.Columns.Add("ID");
        }

        protected internal virtual void SetUserRole(/*int userrole*/) 
        {
            UserRole user = (UserRole)this.MainWindowReference.Current_role; //user_role;

            addItem_button.Enabled = false;
            addItem_button.Visible = false;
            if (details_button_disabled == false)
            {
                itemDetails_button.Enabled = false;
                itemDetails_button.Visible = false;
            }
            editItem_button.Enabled = false;
            editItem_button.Visible = false;
            removeItem_button.Enabled = false;
            removeItem_button.Visible = false;
            refreshList_button.Enabled = false;
            refreshList_button.Visible = false;

            if (user == UserRole.Admin)
            {
                addItem_button.Enabled = true;
                addItem_button.Visible = true;
                //itemDetails_button.Enabled = true;
                if(details_button_disabled == false)
                {
                    itemDetails_button.Visible = true;
                }
                //editItem_button.Enabled = true;
                editItem_button.Visible = true;
                //removeItem_button.Enabled = true;
                removeItem_button.Visible = true;
                refreshList_button.Enabled = true;
                refreshList_button.Visible = true;
            }
            /*else
            {
                removeItem_button.Enabled = false;
                removeItem_button.Visible = false;
            }*/
            //metoda powinna być od tego momentu zasłaniana w każdej kontrolce aby dokładnie określić, które przyciski powinny być dostępne
            /*
            else if (user == UserRole.OrderManager)
            {
                addItem_button.Enabled = true;
                addItem_button.Visible = true;
                if (details_button_disabled == false)
                {
                    //itemDetails_button.Enabled = true;
                    itemDetails_button.Visible = true;
                }
                refreshList_button.Enabled = true;
                refreshList_button.Visible = true;
            }
            else if (user == UserRole.Dispatcher)
            {
                addItem_button.Enabled = true;
                addItem_button.Visible = true;
                if(details_button_disabled == false)
                {
                    //itemDetails_button.Enabled = true;
                    itemDetails_button.Visible = true;
                }
                //editItem_button.Enabled = true;
                editItem_button.Visible = true;
                refreshList_button.Enabled = true;
                refreshList_button.Visible = true;
            }
            else if (user == UserRole.Courier)
            {
                refreshList_button.Enabled = true;
                refreshList_button.Visible = true;
            }*/
        }
    }
}
