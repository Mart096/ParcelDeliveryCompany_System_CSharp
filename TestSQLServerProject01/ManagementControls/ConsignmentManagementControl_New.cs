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
    public partial class ConsignmentManagementControl_New : ItemManagementControler
    {
        public ConsignmentManagementControl_New()
        {
            InitializeComponent();
            SetControlBasicData("SELECT * FROM Consignment_Detailed_List_View", "DELETE FROM Przesylka WHERE Id_przesylki=@item_id", "consignment", "Consignment");
            Disable_Details_Button(false);
        }

        protected override void AddItem_button_Click(object sender, EventArgs e)
        {
            try
            {
                ConsignmentAddEditUpdateForm addform = new ConsignmentAddEditUpdateForm(MainWindowReference, 0, 0);
                addform.ShowDialog();
            }
            catch (Exception)
            {
                MessageClass.DisplayMessage(1101); //MessageBox.Show("Error! Could not initialize consignment's add/edit form.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadItemList();
        }

        protected override void ItemDetails_button_Click(object sender, EventArgs e)
        {
            try
            {
                ConsignmentDetailsForm consignment_details_form = new ConsignmentDetailsForm(MainWindowReference, Convert.ToInt32(item_ListView.SelectedItems[0].Text));
                consignment_details_form.ShowDialog();
            }
            catch (Exception)
            {
                MessageClass.DisplayMessage(1102); //MessageBox.Show("Error! Could not initialize consignment's details form.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void EditItem_button_Click(object sender, EventArgs e)
        {
            try
            {
                ConsignmentAddEditUpdateForm editform = new ConsignmentAddEditUpdateForm(MainWindowReference, 1, Convert.ToInt32(item_ListView.SelectedItems[0].Text));
                editform.ShowDialog();
            }
            catch (Exception)
            {
                MessageClass.DisplayMessage(1101);  //MessageBox.Show("Error! Could not initialize consignment's add/edit form.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadItemList();
        }

        //protected override 
        protected internal override void SetUserRole(/*int user_role*/)
        {
            UserRole user = (UserRole)MainWindowReference.Current_role;
            base.SetUserRole(/*user_role*/);

            
            if (user == UserRole.CustomerContact)
            {
                itemDetails_button.Visible = true;
                refreshList_button.Enabled = true;
                refreshList_button.Visible = true;
            }
            else if (user == UserRole.Dispatcher)
            {
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
                itemDetails_button.Visible = true;
                refreshList_button.Enabled = true;
                refreshList_button.Visible = true;
            }
        }
    }
}
