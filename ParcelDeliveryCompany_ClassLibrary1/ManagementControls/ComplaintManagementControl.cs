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

namespace ParcelDeliveryCompany_ClassLibrary1
{
    public partial class ComplaintManagementControl : ItemManagementControler
    {
        public ComplaintManagementControl()
        {
            InitializeComponent();
            SetControlBasicData("SELECT * FROM Zgloszenia_reklamacji", "DELETE FROM Zgloszenia_reklamacji WHERE Id_zgloszenia_reklamacji = @item_id;", "complaint", "Complaint");
            Disable_Details_Button(false);
            /*List_refresh_command = "SELECT * FROM Zgloszenia_reklamacji";
            Remove_command = "DELETE FROM Zgloszenia_reklamacji WHERE Id_zgloszenia_reklamacji = @item_id;";
            Item_name = "complaint";
            Item_name_capital_letter = "Complaint";*/
        }

        protected override void AddItem_button_Click(object sender, EventArgs e)
        {
            try
            {
                ComplaintAddEditForm addComplForm = new ComplaintAddEditForm(this.MainWindowReference, 0, 0);
                addComplForm.ShowDialog();
            }
            catch
            {
                //ErrorMessageClass.DisplayErrorMessage(401);
                MessageClass.DisplayMessage(1614);
            }
            LoadItemList();
        }

        protected override void EditItem_button_Click(object sender, EventArgs e)
        {
            try
            {
                ComplaintAddEditForm editComplForm = new ComplaintAddEditForm(this.MainWindowReference, 1, Convert.ToInt32(item_ListView.SelectedItems[0].Text));
                editComplForm.ShowDialog();
            }
            catch
            {
                MessageClass.DisplayMessage(1614);
                //ErrorMessageClass.DisplayErrorMessage(401);
            }
            LoadItemList();
        }

        protected override void ItemDetails_button_Click(object sender, EventArgs e)
        {
            try
            {
                ComplaintDetailsForm detComplForm = new ComplaintDetailsForm(this.MainWindowReference, Convert.ToInt32(item_ListView.SelectedItems[0].Text));
                detComplForm.ShowDialog();
            }
            catch
            {
                MessageClass.DisplayMessage(1615);
            }
            LoadItemList();
        }

        protected internal override void SetUserRole(/*int user_role*/)
        {
            UserRole user = (UserRole) this.MainWindowReference.Current_role;//(UserRole)user_role;
            base.SetUserRole(/*user_role*/);


            /*if(user == UserRole.Admin)
            {

            }*/
            if (user == UserRole.CustomerContact)
            {
                addItem_button.Enabled = true;
                addItem_button.Visible = true;
                itemDetails_button.Visible = true;
                editItem_button.Visible = true;
                refreshList_button.Enabled = true;
                refreshList_button.Visible = true;
            }
            else if (user == UserRole.Dispatcher)
            {

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
