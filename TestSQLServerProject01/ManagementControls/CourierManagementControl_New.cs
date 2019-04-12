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

namespace ParcelDeliveryCompanyApplication.ManagementControls
{
    public partial class CourierManagementControl_New : ItemManagementControler
    {
        public CourierManagementControl_New()
        {
            InitializeComponent();
            SetControlBasicData("SELECT * FROM Kurier", "REMOVE FROM Kurier WHERE Id_kuriera = @item_id", "courier", "Courier");
            Disable_Details_Button(true);
        }

        protected override void AddItem_button_Click(object sender, EventArgs e)
        {
            //base.AddItem_button_Click(sender, e);
            try
            {
                CourierAddEditForm courier_addform = new CourierAddEditForm(MainWindowReference, 0, 0);
                courier_addform.ShowDialog();
            }
            catch (Exception)
            {
                MessageClass.DisplayMessage(504);
            }
            LoadItemList();
        }

        protected override void EditItem_button_Click(object sender, EventArgs e)
        {
            //base.EditItem_button_Click(sender, e);
            try
            {
                int id_to_edit = Convert.ToInt32(item_ListView.SelectedItems[0].Text);
                CourierAddEditForm courier_addform = new CourierAddEditForm(MainWindowReference, 1, id_to_edit);
                courier_addform.ShowDialog();
            }
            catch (Exception)
            {
                MessageClass.DisplayMessage(504);
            }
            LoadItemList();
        }

        protected override void Item_ListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            //base.Item_ListView_SelectedIndexChanged(sender, e);
            if (item_ListView.SelectedItems.Count == 1)
            {
                editItem_button.Enabled = true;
                removeItem_button.Enabled = true;
                //assignVehicle_To_Courier_button.Enabled = true;
            }
            else
            {
                editItem_button.Enabled = false;
                removeItem_button.Enabled = false;
                //assignVehicle_To_Courier_button.Enabled = false;
            }
        }

        protected internal override void SetUserRole(/*int user_role*/)
        {
            UserRole user = (UserRole)MainWindowReference.Current_role;
            base.SetUserRole(/*user_role*/);

            if (user == UserRole.CustomerContact)
            {

            }
            else if (user == UserRole.Dispatcher)
            {
                refreshList_button.Enabled = true;
                refreshList_button.Visible = true;
            }
            else if (user == UserRole.Courier)
            {

            }
            else if (user == UserRole.OrderManager)
            {
                refreshList_button.Enabled = true;
                refreshList_button.Visible = true;
            }
        }
    }
}
