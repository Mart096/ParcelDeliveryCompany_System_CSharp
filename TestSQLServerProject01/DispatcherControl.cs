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

namespace TestSQLServerProject01
{
    public partial class DispatcherControl : MainDatabaseManagementControler
    { //kontrolka przeznaczona dla dyspozytorów
        public DispatcherControl()
        {
            InitializeComponent();
            /*this.Controls.Remove();
            this.Controls.Remove();*/
        }
        public DispatcherControl(UserClass mw)
        {
            InitializeComponent();
            MainWindowReference = mw;

            /*dictionaryManagement_panel.MainWReference(MainWindowReference);
            vehicleManagement_panel.MainWindowReference = MainWindowReference;
            courierManagement_panel.MainWindowReference = MainWindowReference;
            orderManagement_panel.MainWindowReference = MainWindowReference;
            customerManagement_panel.MainWindowReference = MainWindowReference;
            consignmentManagement_panel.MainWindowReference = MainWindowReference;
            courseManagement_panel.MainWindowReference = MainWindowReference;
            parcelManagement_panel.MainWindowReference = MainWindowReference;
            locationManagement_panel.MainWindowReference = MainWindowReference;
            pickupRequestManagement_panel.MainWindowReference = MainWindowReference;
            complaintManagement_panel.MainWindowReference = MainWindowReference;*/

            SetMainWindowReference(MainWindowReference);

            pickupRequestManagement_panel.SetUserRole();
            complaintManagement_panel.SetUserRole();
        }

        private void dictionaryManagement_button_EnabledChanged(object sender, EventArgs e)
        {
            dictionaryManagement_button.Enabled = false;
            dictionaryManagement_panel.Enabled = false;
            dictionaryManagement_panel.Visible = false;
        }
    }
}
