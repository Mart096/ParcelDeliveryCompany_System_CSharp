using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ParcelDeliveryCompany_ClassLibrary1;

namespace TestSQLServerProject01.ManagementControls
{
    public partial class OrderManagementControl_New : ItemManagementControler
    {
        public OrderManagementControl_New()
        {
            InitializeComponent();
            SetControlBasicData("SELECT * FROM Orders_detailed_list_View", "DELETE FROM Zlecenie WHERE Id_zlecenia = @item_id", "order", "Order");
            Disable_Details_Button(true);
        }

        protected override void AddItem_button_Click(object sender, EventArgs e)
        {
            try
            {
                OrderAddEditForm addOrderForm = new OrderAddEditForm(MainWindowReference, 0, 0);
                addOrderForm.ShowDialog();
            }
            catch (Exception)
            {
                MessageClass.DisplayMessage(602);
            }
            LoadItemList();
        }

        protected override void EditItem_button_Click(object sender, EventArgs e)
        {
            if (item_ListView.SelectedItems.Count == 1)
            {
                try
                {
                    int order_id = Convert.ToInt32(item_ListView.SelectedItems[0].Text);
                    OrderAddEditForm editOrderForm = new OrderAddEditForm(MainWindowReference, 1, order_id);
                    editOrderForm.ShowDialog();
                }
                catch (Exception)
                {
                    MessageClass.DisplayMessage(602);
                }
            }
            LoadItemList();
        }

        protected override void Item_ListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (item_ListView.SelectedItems.Count == 1)
            {
                editItem_button.Enabled = true;
                removeItem_button.Enabled = true;
            }
            else
            {
                editItem_button.Enabled = false;
                removeItem_button.Enabled = false;
            }
        }

        protected internal override void SetUserRole(/*int user_role*/)
        {
            UserRole user = (UserRole)MainWindowReference.Current_role;
            base.SetUserRole(/*user_role*/);

            if (user == UserRole.CustomerContact)
            {
                addItem_button.Enabled = true;
                addItem_button.Visible = true;
                refreshList_button.Enabled = true;
                refreshList_button.Visible = true;
            }
            else if (user == UserRole.Dispatcher)
            {
                refreshList_button.Enabled = true;
                refreshList_button.Visible = true;
            }
            else if (user == UserRole.Courier)
            {
                refreshList_button.Enabled = true;
                refreshList_button.Visible = true;
            }
            else if (user == UserRole.OrderManager)
            {
                addItem_button.Enabled = true;
                addItem_button.Visible = true;
                editItem_button.Visible = true;
                refreshList_button.Enabled = true;
                refreshList_button.Visible = true;
            }
        }
    }
}
