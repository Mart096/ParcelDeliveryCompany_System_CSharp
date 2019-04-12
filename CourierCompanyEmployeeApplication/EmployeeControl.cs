using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ParcelDeliveryCompanyApplication;
using ParcelDeliveryCompany_ClassLibrary1;
using static ParcelDeliveryCompany_ClassLibrary1.UserClass;

namespace CourierCompanyEmployeeApplication
{
    public partial class EmployeeControl : MainDatabaseManagementControler //UserControl
    { //kontrolka przeznaczona dla dyspozytorów
        //private UserClass userItem;

        public EmployeeControl()
        {
            InitializeComponent();
            /*this.Controls.Remove();
            this.Controls.Remove();*/
        }
        public EmployeeControl(UserClass mw)
        {
            InitializeComponent();
            this.MainWindowReference = mw;
            SetMainWindowReference(MainWindowReference);
            CheckUsersPermissions();
        }

        private void DictionaryManagement_button_EnabledChanged(object sender, EventArgs e)
        {
            dictionaryManagement_button.Enabled = false;
            dictionaryManagement_button.Visible = false;
            dictionaryManagement_panel.Enabled = false;
            dictionaryManagement_panel.Visible = false;
        }
    }
}
