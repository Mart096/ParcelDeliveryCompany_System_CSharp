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
    public partial class LocationManagementControl_New : ItemManagementControler
    {
        public LocationManagementControl_New()
        {
            InitializeComponent();
            SetControlBasicData("SELECT * FROM Location_Detailed_View", "DELETE FROM Punkt_obslugi WHERE Id_punktu=@item_id;", "location", "Location");
            Disable_Details_Button(true);
        }

        protected override void AddItem_button_Click(object sender, EventArgs e)
        {
            //base.AddItem_button_Click(sender, e);
            try
            {
                LocationAddEditForm addLocForm = new LocationAddEditForm(MainWindowReference, 0, 0);
                addLocForm.ShowDialog();
            }
            catch
            {
                MessageClass.DisplayMessage(1303);
                //MessageBox.Show("Failed to initialize location add/edit form.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadItemList();
        }
        protected override void EditItem_button_Click(object sender, EventArgs e)
        {
            if (item_ListView.SelectedItems.Count == 1)
            {
                try
                {
                    int location_to_edit = 0;
                    location_to_edit = Convert.ToInt32(item_ListView.SelectedItems[0].Text);
                    LocationAddEditForm editLocForm = new LocationAddEditForm(MainWindowReference, 1, location_to_edit);
                    editLocForm.ShowDialog();
                }
                catch (Exception)
                {
                    //ErrorMessageClass.DisplayErrorMessage(401);
                    MessageClass.DisplayMessage(1303);
                    //MessageBox.Show("Failed to initialize location add/edit form.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                LoadItemList();
            }
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

            }
        }
    }
}
