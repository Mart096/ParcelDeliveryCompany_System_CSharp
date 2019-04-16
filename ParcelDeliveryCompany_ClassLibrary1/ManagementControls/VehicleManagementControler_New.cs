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

namespace ParcelDeliveryCompanyApplication
{
    public partial class VehicleManagementControler_New : ItemManagementControler
    {
        public VehicleManagementControler_New()
        {
            InitializeComponent();
            SetControlBasicData("SELECT * FROM Vehicle_Details_View", "DELETE FROM Pojazd WHERE Id_pojazdu = @item_id", "vehicle", "Vehicle");
            Disable_Details_Button(true);
        }

        protected override void AddItem_button_Click(object sender, EventArgs e)
        {
            //base.AddItem_button_Click(sender, e);
            try
            {
                VehicleAddEditForm addVehForm = new VehicleAddEditForm(MainWindowReference, 0, 0);
                addVehForm.ShowDialog();
            }
            catch
            {
                MessageClass.DisplayMessage(401);
            }
            LoadItemList();
        }

        protected override void EditItem_button_Click(object sender, EventArgs e)
        {
            //base.EditItem_button_Click(sender, e);
            if (item_ListView.SelectedItems.Count == 1)
            {
                try
                {
                    int vehicle_to_edit = 0;
                    vehicle_to_edit = Convert.ToInt32(item_ListView.SelectedItems[0].Text);
                    VehicleAddEditForm addVehForm = new VehicleAddEditForm(MainWindowReference, 1, vehicle_to_edit);
                    addVehForm.ShowDialog();
                }
                catch (Exception)
                {
                    MessageClass.DisplayMessage(401);
                }
            }
            LoadItemList();
        }

        protected override void Item_ListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            //base.Item_ListView_SelectedIndexChanged(sender, e);
            if(item_ListView.SelectedItems.Count == 1)
            {
                //tą część należy dostosować do posiadanych uprawnień
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
            base.SetUserRole();

            if (user == UserRole.CustomerContact)
            {
                
            }
            else if (user == UserRole.Dispatcher)
            {   
                refreshList_button.Visible = true;
                refreshList_button.Enabled = true;
            }
            else if (user == UserRole.Courier)
            {

            }
            else if (user == UserRole.OrderManager)
            {

            }
        }
    }
}
