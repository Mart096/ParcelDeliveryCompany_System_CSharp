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
    public partial class ParcelManagementControl_New : ItemManagementControler
    {
        

        public ParcelManagementControl_New()
        {
            InitializeComponent();
            SetControlBasicData("SELECT * FROM Parcels_View", "DELETE FROM Paczka WHERE Id_paczki = @item_id", "parcel", "Parcel");
            Disable_Details_Button(true);
        }

        protected override void AddItem_button_Click(object sender, EventArgs e)
        {
            try
            {
                ParcelAddEditForm addparcelform = new ParcelAddEditForm(MainWindowReference, 0, 0, 0);
                addparcelform.ShowDialog();
            }
            catch (Exception)
            {
                MessageClass.DisplayMessage(1405);
                //MessageBox.Show("Failed to initialize parcel add/edit form.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadItemList();
        }
        protected override void EditItem_button_Click(object sender, EventArgs e)
        {
            try
            {
                ParcelAddEditForm editparcelform = new ParcelAddEditForm(MainWindowReference, 1, Convert.ToInt32(item_ListView.SelectedItems[0].Text), 0);
                editparcelform.ShowDialog();
            }
            catch (Exception)
            {
                MessageClass.DisplayMessage(1405);
                //MessageBox.Show("Failed to initialize parcel add/edit form.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadItemList();
        }

        /*protected override void RefreshList_button_Click(object sender, EventArgs e)
        {
            base.RefreshList_button_Click(sender, e);
        }*/

        protected internal override void SetUserRole(/*int user_role*/)
        {
            UserRole user = (UserRole)MainWindowReference.Current_role;
            base.SetUserRole(/*user_role*/);

            if (user == UserRole.Admin)
            {
                removeItem_button.Visible = false; //zablokowano tą funkcjonalność ze względu na ryzyko usunięcia przesyłki i zlecenia. paczkę nadal można usunąć w oknie szczegółów zlecenia.
            }
            else if (user == UserRole.CustomerContact)
            {
                
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
