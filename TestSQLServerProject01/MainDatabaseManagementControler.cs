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
using static ParcelDeliveryCompany_ClassLibrary1.UserClass;

namespace ParcelDeliveryCompanyApplication
{
    public partial class MainDatabaseManagementControler : UserControl
    {// kontrolka przeznaczona dla administratorów bazy danych
        private UserClass MainW;
        /*private enum UserRole
        {

        }*/

        protected internal UserClass MainWindowReference { get => MainW; set => MainW = value; }

        protected internal enum PanelNames
        {
            dictionaryManagement_panel=0,
            vehicleManagement_panel=1,
            courierManagement_panel=2,
            customerManagement_panel=3,
            orderManagement=4,
            pickupRequestManagement_panel=5,
            complaintManagement_panel=6,
            consignmentManagement_panel=7,
            locationManagement_panel=8,
            courseManagement_panel=9,
            parcelManagement_panel=10
        };

        public MainDatabaseManagementControler()
        {
            InitializeComponent();
            DenyAccessToControls();
        }

        public MainDatabaseManagementControler(UserClass /*MainForm*/ mainW)
        {
            InitializeComponent();

            SetMainWindowReference(mainW);
            CheckUsersPermissions();
        }

        protected internal virtual void DictionaryManagement_Click(object sender, EventArgs e)
        {
            //dictionaryManagement_panel.Visible = true;
            PanelNames pn = PanelNames.dictionaryManagement_panel;
            TogglePanels(pn);
        }

        protected internal virtual void VehicleManagement_Click(object sender, EventArgs e)
        {
            //vehicleManagement_panel.Visible = true;
            PanelNames pn = PanelNames.vehicleManagement_panel;
            TogglePanels(pn);
            //vehicleManagement_panel.LoadVehicleList();
            vehicleManagementNew_panel.LoadItemList();
        }

        protected internal virtual void LocationManagement_button_Click(object sender, EventArgs e)
        {
            PanelNames pn = PanelNames.locationManagement_panel;
            TogglePanels(pn);
            //locationManagement_panel.LoadLocationList();
            locationManagementNew_panel.LoadItemList();
        }

        protected internal virtual void CourierManagement_button_Click(object sender, EventArgs e)
        {
            //courierManagement_panel.Visible = true;
            PanelNames pn = PanelNames.courierManagement_panel;
            TogglePanels(pn);
            //courierManagement_panel.Load_Couriers_Data();
            courierManagementNew_panel.LoadItemList();
        }

        protected internal virtual void CustomerManagement_button_Click(object sender, EventArgs e)
        {
            PanelNames pn = PanelNames.customerManagement_panel;
            TogglePanels(pn);
            customerManagement_panel.Load_Customer_List();
        }

        protected internal virtual void OrderManagement_button_Click(object sender, EventArgs e)
        {
            PanelNames pn = PanelNames.orderManagement;
            TogglePanels(pn);
            //orderManagement_panel.Load_Orders_List();
            orderManagementNew_panel.LoadItemList();
        }

        protected internal virtual void ConsignmentManagement_button_Click(object sender, EventArgs e)
        {
            PanelNames pn = PanelNames.consignmentManagement_panel;
            TogglePanels(pn);
            //consignmentManagement_panel.Load_Consignments_List();
            consignmentManagementNew_panel.LoadItemList();
        }

        protected internal virtual void ParcelManagement_button_Click(object sender, EventArgs e)
        {
            PanelNames pn = PanelNames.parcelManagement_panel;
            TogglePanels(pn);
            //parcelManagement_panel.Load_Parcels_List();
            parcelManagementNew_panel.LoadItemList();
        }

        protected internal virtual void PickupAssignmentManagement_button_Click(object sender, EventArgs e)
        {
            PanelNames pn = PanelNames.pickupRequestManagement_panel;
            TogglePanels(pn);
            pickupRequestManagement_panel.LoadItemList();
        }

        protected internal virtual void ComplaintManagement_button_Click(object sender, EventArgs e)
        {
            PanelNames pn = PanelNames.complaintManagement_panel;
            TogglePanels(pn);
            complaintManagement_panel.LoadItemList();
        }

        protected internal virtual void CourseManagement_button_Click(object sender, EventArgs e)
        {
            PanelNames pn = PanelNames.courseManagement_panel;
            TogglePanels(pn);
            //courseManagement_panel.LoadCourseList();
            courseManagementNew_panel.LoadItemList();
        }



        protected internal void TogglePanels(PanelNames panel_name)
        {   
            dictionaryManagement_panel.Visible = false;

            //vehicleManagement_panel.Visible = false;
            vehicleManagementNew_panel.Visible = false;

            //courierManagement_panel.Visible = false;
            courierManagementNew_panel.Visible = false;

            //orderManagement_panel.Visible = false;
            orderManagementNew_panel.Visible = false;

            //consignmentManagement_panel.Visible = false;
            consignmentManagementNew_panel.Visible = false;

            customerManagement_panel.Visible = false;

            //locationManagement_panel.Visible = false;
            locationManagementNew_panel.Visible = false;

            //courseManagement_panel.Visible = false;
            courseManagementNew_panel.Visible = false;

            //parcelManagement_panel.Visible=false;
            parcelManagementNew_panel.Visible=false;
            pickupRequestManagement_panel.Visible = false;
            complaintManagement_panel.Visible = false;
            
            if (panel_name == PanelNames.orderManagement)
            {
                //orderManagement_panel.Visible = true;
                orderManagementNew_panel.Visible = true;
            }
            else if (panel_name == PanelNames.customerManagement_panel)
            {
                customerManagement_panel.Visible = true;
            }
            else if (panel_name == PanelNames.complaintManagement_panel)
            {
                complaintManagement_panel.Visible = true;
            }
            else if (panel_name == PanelNames.courierManagement_panel)
            {
                //courierManagement_panel.Visible = true;
                courierManagementNew_panel.Visible = true;
            }
            else if (panel_name == PanelNames.dictionaryManagement_panel)
            {
                dictionaryManagement_panel.Visible = true;
            }
            else if (panel_name == PanelNames.pickupRequestManagement_panel)
            {
                pickupRequestManagement_panel.Visible = true;
            }
            else if (panel_name == PanelNames.vehicleManagement_panel)
            {
                //vehicleManagement_panel.Visible = true;
                vehicleManagementNew_panel.Visible = true;
            }
            else if (panel_name == PanelNames.consignmentManagement_panel)
            {
                //consignmentManagement_panel.Visible = true;
                consignmentManagementNew_panel.Visible = true;
            }
            else if (panel_name == PanelNames.parcelManagement_panel)
            {
                //parcelManagement_panel.Visible = true;
                parcelManagementNew_panel.Visible = true;
            }
            else if (panel_name == PanelNames.courseManagement_panel)
            {
                //courseManagement_panel.Visible = true;
                courseManagementNew_panel.Visible = true;
            }
            else if (panel_name == PanelNames.locationManagement_panel)
            {
                //locationManagement_panel.Visible = true;
                locationManagementNew_panel.Visible = true;
            }
        }

        protected internal void SetMainWindowReference(UserClass mainW)
        {
            this.MainWindowReference = mainW;
            dictionaryManagement_panel.MainWindowReference=MainWindowReference;

            //vehicleManagement_panel.MainWindowReference = MainWindowReference;//do usunięcia
            vehicleManagementNew_panel.MainWindowReference = MainWindowReference;
            vehicleManagementNew_panel.SetUserRole();

            //courierManagement_panel.MainWindowReference = MainWindowReference;//do usunięcia
            courierManagementNew_panel.MainWindowReference = MainWindowReference;
            courierManagementNew_panel.SetUserRole();

            //orderManagement_panel.MainWindowReference = MainWindowReference;//do usunięcia
            orderManagementNew_panel.MainWindowReference = MainWindowReference;
            orderManagementNew_panel.SetUserRole();

            customerManagement_panel.MainWindowReference = MainWindowReference;
            customerManagement_panel.SetUserRole();

            //consignmentManagement_panel.MainWindowReference = MainWindowReference;//do usunięcia
            consignmentManagementNew_panel.MainWindowReference = MainWindowReference;
            consignmentManagementNew_panel.SetUserRole();

            ///courseManagement_panel.MainWindowReference = MainWindowReference;//do usunięcia
            courseManagementNew_panel.MainWindowReference = MainWindowReference;
            courseManagementNew_panel.SetUserRole();

            //parcelManagement_panel.MainWindowReference = MainWindowReference;
            parcelManagementNew_panel.MainWindowReference = MainWindowReference;
            parcelManagementNew_panel.SetUserRole();

            //locationManagement_panel.MainWindowReference = MainWindowReference;//do usunięcia
            locationManagementNew_panel.MainWindowReference = MainWindowReference;
            locationManagementNew_panel.SetUserRole();

            pickupRequestManagement_panel.MainWindowReference = MainWindowReference;
            pickupRequestManagement_panel.SetUserRole();

            complaintManagement_panel.MainWindowReference = MainWindowReference;
            complaintManagement_panel.SetUserRole();
        }

        protected internal void CheckUsersPermissions()
        {
            try
            {
                DenyAccessToControls();

                UserRole user = (UserRole)this.MainWindowReference.Current_role;


                if (user == UserRole.Admin)
                {
                    dictionaryManagement_button.Enabled = true;
                    dictionaryManagement_button.Visible = true;

                    vehicleManagement_button.Enabled = true;
                    vehicleManagement_button.Visible = true;

                    courierManagement_button.Enabled = true;
                    courierManagement_button.Visible = true;

                    orderManagement_button.Enabled = true;
                    orderManagement_button.Visible = true;

                    customerManagement_button.Enabled = true;
                    customerManagement_button.Visible = true;

                    consignmentManagement_button.Enabled = true;
                    consignmentManagement_button.Visible = true;

                    courseManagement_button.Enabled = true;
                    courseManagement_button.Visible = true;

                    parcelManagement_button.Enabled = true;
                    parcelManagement_button.Visible = true;

                    locationManagement_button.Enabled = true;
                    locationManagement_button.Visible = true;

                    pickupAssignmentManagement_button.Enabled = true;
                    pickupAssignmentManagement_button.Visible = true;

                    complaintManagement_button.Enabled = true;
                    complaintManagement_button.Visible = true;
                }
                else if (user == UserRole.CustomerContact)
                {
                    customerManagement_button.Enabled = true;
                    customerManagement_button.Visible = true;

                    orderManagement_button.Enabled = true;
                    orderManagement_button.Visible = true;

                    consignmentManagement_button.Enabled = true;
                    consignmentManagement_button.Visible = true;

                    pickupAssignmentManagement_button.Enabled = true;
                    pickupAssignmentManagement_button.Visible = true;

                    complaintManagement_button.Enabled = true;
                    complaintManagement_button.Visible = true;
                }
                else if (user == UserRole.Dispatcher)
                {
                    customerManagement_button.Enabled = true;
                    customerManagement_button.Visible= true;

                    courierManagement_button.Enabled = true;
                    courierManagement_button.Visible = true; 

                    orderManagement_button.Enabled = true;
                    orderManagement_button.Visible = true;

                    consignmentManagement_button.Enabled = true;
                    consignmentManagement_button.Visible = true;

                    courseManagement_button.Enabled = true;
                    courseManagement_button.Visible = true;

                    parcelManagement_button.Enabled = true;
                    parcelManagement_button.Visible = true;

                    locationManagement_button.Enabled = true;
                    locationManagement_button.Visible = true;

                    pickupAssignmentManagement_button.Enabled = true;
                    pickupAssignmentManagement_button.Visible = true;
                }
                else if (user == UserRole.Courier)
                {
                    orderManagement_button.Enabled = true;
                    orderManagement_button.Visible = true;

                    consignmentManagement_button.Enabled = true;
                    consignmentManagement_button.Visible = true;

                    courseManagement_button.Enabled = true;
                    courseManagement_button.Visible = true;

                    parcelManagement_button.Enabled = true;
                    parcelManagement_button.Visible = true;

                    pickupAssignmentManagement_button.Enabled = true;
                    pickupAssignmentManagement_button.Visible = true;
                }
                else if (user == UserRole.OrderManager)
                {
                    courierManagement_button.Enabled = true;
                    courierManagement_button.Visible = true;

                    orderManagement_button.Enabled = true;
                    orderManagement_button.Visible = true;

                    consignmentManagement_button.Enabled = true;
                    consignmentManagement_button.Visible = true;

                    parcelManagement_button.Enabled = true;
                    parcelManagement_button.Visible = true;

                    pickupAssignmentManagement_button.Enabled = true;
                    pickupAssignmentManagement_button.Visible = true;
                }
                else
                {
                    DenyAccessToControls();
                }
            }
            catch
            {
                MessageClass.DisplayMessage(2201);
                //MessageBox.Show("Failed to obtain user's permissions. Access to controls has been denied. Try to log in again.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DenyAccessToControls();
            }
        }

        private void DenyAccessToControls()
        {
            dictionaryManagement_button.Enabled = false;
            dictionaryManagement_button.Visible = false;

            vehicleManagement_button.Enabled = false;
            vehicleManagement_button.Visible = false;

            courierManagement_button.Enabled = false;
            courierManagement_button.Visible = false;

            orderManagement_button.Enabled = false;
            orderManagement_button.Visible = false;

            customerManagement_button.Enabled = false;
            customerManagement_button.Visible = false;

            consignmentManagement_button.Enabled = false;
            consignmentManagement_button.Visible = false;

            courseManagement_button.Enabled = false;
            courseManagement_button.Visible = false;

            parcelManagement_button.Enabled = false;
            parcelManagement_button.Visible = false;

            locationManagement_button.Enabled = false;
            locationManagement_button.Visible = false;

            pickupAssignmentManagement_button.Enabled = false;
            pickupAssignmentManagement_button.Visible = false;

            complaintManagement_button.Enabled = false;
            complaintManagement_button.Visible = false;
        }
    }
}
