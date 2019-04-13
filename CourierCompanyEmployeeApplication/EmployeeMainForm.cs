using ParcelDeliveryCompany_ClassLibrary1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ParcelDeliveryCompanyApplication;

namespace CourierCompanyEmployeeApplication
{
    public partial class EmployeeMainForm : Form
    {
        public EmployeeMainForm()
        {
            InitializeComponent();
            Serverlogin_Load(this, this.UserItem);
        }

        private bool connected = false;
        private TimeSpan startTimeSpan = TimeSpan.Zero;
        private TimeSpan periodTimeSpan = TimeSpan.FromSeconds(30);
        private UserClass userItem = new UserClass();

        public UserClass UserItem { get => userItem; set => userItem = value; }

        public void Serverlogin_Load(EmployeeMainForm mainW, UserClass user)
        {
            //tworzenie i wyświetlanie okna logowania
            EmployeeServerLoginControl ucSrvlogin01 = new EmployeeServerLoginControl(this/*, user*/)
            {
                Location = new System.Drawing.Point(0, 25),
                Height = Convert.ToInt32(this.Size.Height) - 70,
                Width = Convert.ToInt32(this.Size.Width) - 20,
                Anchor = (AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right)
            };

            this.Controls.Add(ucSrvlogin01);
        }

        internal string GetConnectionString()
        {
            return this.UserItem.ConnectionString;//this.ConnectionString;
        }

        public void DispatcherControl_load()
        {
            EmployeeControl mdmc = new EmployeeControl(this.UserItem)
            {
                Location = new System.Drawing.Point(0, 25),// 25);
                Height = Convert.ToInt32(this.Size.Height) - 70,
                Width = Convert.ToInt32(this.Size.Width) - 20,
                Anchor = (AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right)
            };

            this.Controls.Add(mdmc);
        }

        public void SQLconnectionCheck()
        {
            if (this.connected == true)
            {

            }
        }

        public int SQLconnectionOpenClose(/*string connectionString*/)
        {
            try
            {
                bool result = UserItem.IsEmployee();
                if (result == true)
                {
                    connectToDatabaseToolStripMenuItem.Enabled = true;
                    this.connected = true;
                    return 0;
                }
                else
                {
                    //MessageBox.Show("Your account is not authorized to use this application! Ask database administrator for permission.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return 1;
                }

            }
            catch (Exception /*ex*/)
            {
                //MessageBox.Show("Could not connect to database!" + ex.Message);
                MessageClass.DisplayMessage(2302);
                return 1;
            }

        }

        private void Connected_status()
        {

        }

        private void QuitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.Application.MessageLoop)
            {
                // WinForms app
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                // Console app
                System.Environment.Exit(1);
            }
        }

        private void ConnectToDatabseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Control.ControlCollection controls_arr = this.Controls;
            //controls_arr = this.Controls;
            Control control_to_close = controls_arr["DispatcherControl"];
            control_to_close.Dispose();

            this.connectToDatabaseToolStripMenuItem.Enabled = false;
            this.UserItem.User_Logout();
            this.Serverlogin_Load(this, this.UserItem);
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm about_form = new AboutForm();
            about_form.ShowDialog();
        }
    }
}
