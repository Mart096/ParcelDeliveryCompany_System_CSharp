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
    public partial class PickupRequestManagementControl : ItemManagementControler
    {
        public PickupRequestManagementControl()
        {
            InitializeComponent();

            SetControlBasicData("SELECT * FROM Pickup_Request_List_View"/*Zgloszenia_odbioru"*/, "DELETE FROM Zgloszenia_odbioru WHERE Id_zgloszenia_odbioru = @item_id;", "pickup request", "Pickup request");
            Disable_Details_Button(false);
        }

        protected override void AddItem_button_Click(object sender, EventArgs e)
        {
            try
            {
                PickupRequestAddEditForm addPckReqForm = new PickupRequestAddEditForm(this.MainWindowReference, 0, 0);
                addPckReqForm.ShowDialog();
            }
            catch
            {
                //ErrorMessageClass.DisplayErrorMessage(401);
                MessageClass.DisplayMessage(1510);
                //MessageBox.Show("Failed to initialize pickup request add/edit form.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadItemList();
        }

        protected override void EditItem_button_Click(object sender, EventArgs e)
        {
            try
            {
                PickupRequestAddEditForm editPckReqForm = new PickupRequestAddEditForm(this.MainWindowReference, 1, Convert.ToInt32(item_ListView.SelectedItems[0].Text));
                editPckReqForm.ShowDialog();
            }
            catch
            {
                //ErrorMessageClass.DisplayErrorMessage(401);
                MessageClass.DisplayMessage(1510);
                //MessageBox.Show("Failed to initialize pickup request add/edit form.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadItemList();
        }

        protected override void ItemDetails_button_Click(object sender, EventArgs e)
        {
            try
            {
                PickupRequestDetailsForm detPckReqForm = new PickupRequestDetailsForm(this.MainWindowReference, Convert.ToInt32(item_ListView.SelectedItems[0].Text));
                detPckReqForm.ShowDialog();
            }
            catch
            {
                //ErrorMessageClass.DisplayErrorMessage(401);
                MessageClass.DisplayMessage(1511);
                //MessageBox.Show("Failed to initialize pickup request's details form.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadItemList();
        }

        protected internal override void SetUserRole(/*int user_role*/)
        {
            UserRole user = (UserRole)MainWindowReference.Current_role;
            base.SetUserRole(/*user_role*/);

            if (user == UserRole.CustomerContact)
            {
                addItem_button.Enabled = true;
                addItem_button.Visible = true;
                editItem_button.Visible = true;
                //itemDetails_button.Visible = true;
                refreshList_button.Enabled = true;
                refreshList_button.Visible = true;
            }
            else if (user == UserRole.Dispatcher)
            {
                addItem_button.Enabled = true;
                addItem_button.Visible = true;
                editItem_button.Visible = true;
                itemDetails_button.Visible = true;
                refreshList_button.Enabled = true;
                refreshList_button.Visible = true;
            }
            else if (user == UserRole.Courier)
            {
                itemDetails_button.Visible = true;
                refreshList_button.Enabled = true;
                refreshList_button.Visible = true;
            }
            else if (user == UserRole.OrderManager)
            {
                addItem_button.Enabled = true;
                addItem_button.Visible = true;
                editItem_button.Visible = true;
                itemDetails_button.Visible = true;
                refreshList_button.Enabled = true;
                refreshList_button.Visible = true;
            }
        }
    }
}
