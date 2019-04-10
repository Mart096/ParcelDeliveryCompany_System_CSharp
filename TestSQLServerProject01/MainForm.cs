using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ParcelDeliveryCompany_ClassLibrary1;

namespace TestSQLServerProject01
{
    public partial class MainForm : Form
    {
        /*private string ServerUrlString { get; set; }
        private string DatabaseNameString { get; set; }
        private string UserLoginString {get; set; }
        private string PortString { get; set; }*/
        private bool connected = false;
        /*private string ConnectionString { get; set; } 
        public SqlConnection Connection01 { get; private set; }*/
        private TimeSpan startTimeSpan = TimeSpan.Zero;
        private TimeSpan periodTimeSpan = TimeSpan.FromSeconds(30);
        private UserClass userItem = new UserClass();
        //public int TimeOutInt = 1;

        public UserClass UserItem { get => userItem; set => userItem = value; }

        public MainForm()
        {
            InitializeComponent();
            Serverlogin_Load(this, this.UserItem);
        }

        public void Serverlogin_Load(MainForm mainW, UserClass user)
        {
            //tworzenie i wyświetlanie okna logowania
            ServerLoginControler ucSrvlogin01 = new ServerLoginControler(this/*, user*/)
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

        public void MasterDatabaseManager_load(/*MainForm mainW*/)
        {
            MainDatabaseManagementControler mdmc = new MainDatabaseManagementControler(this.UserItem)
            {
                Location = new System.Drawing.Point(0, 25),// 25);
                Height = Convert.ToInt32(this.Size.Height) - 70,
                Width = Convert.ToInt32(this.Size.Width) - 20,
                Anchor = (AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right)
            };

            this.Controls.Add(mdmc);
        }

        /*public void Set_ConnectionString(string connection_string)
        {
            this.ConnectionString = connection_string;
        }*/

        public void SQLconnectionCheck()
        {
            if (this.connected == true)
            {

            }
        }

        public int SQLconnectionOpenClose(/*string connectionString*/)
        {
            //this.ConnectionString = connectionString;

            //Przygotowanie do nawiązania połączenia


            //using (SqlConnection connection = new SqlConnection(connectionString) )//this.connection01)
            /*using (SqlConnection connection = new SqlConnection(userItem.ConnectionString))
            {*/
            try
            {
                //sprawdzanie czy użytkownik to admin
                /*using (SqlCommand auth_command = new SqlCommand("DECLARE @Result INT " +
                    "IF IS_ROLEMEMBER(@name) = 1 " +
                    "SET @Result = 1;" +
                    "ELSE " +
                    "SET @Result = 0;" +
                    "SELECT @Result", connection))
                {
                    //UserItem.UserAuthentication()
                    auth_command.Parameters.Add("@name", SqlDbType.NVarChar);
                    auth_command.Parameters["@name"].Value = "db_owner";*/
                //connection.Open();
                bool result = UserItem.IsAdmin(); //Convert.ToInt32(auth_command.ExecuteScalar());
                if (result == true)
                {
                    //MessageBox.Show(" Connection Open ! ");
                    this.connectToDatabaseToolStripMenuItem.Enabled = true;
                    this.connected = true;
                    return 0;
                }
                else
                {
                    //MessageClass.DisplayMessage(2301);
                    //MessageBox.Show("Your account is not authorized to use this application! Ask database administrator for permission.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return 1;
                }

            }
            catch (Exception /*ex*/)
            {
                MessageClass.DisplayMessage(2302); //MessageBox.Show("Could not connect to database!" + ex.Message);
                /*this.Connection01.Close();
                this.Connection01.Dispose();
                this.ConnectionString = "";*/
                connected = false;
                return 1;
            }

                /*this.Connection01.Close();
                this.Connection01.Dispose();*/
                //return 1;
            //}
            //return 1;
        }

        public void SQLconnectionClose(SqlConnection connection, string connectionString)
        {
            //connection.
            connection.ConnectionString = connectionString;
            connection.Close();
            connection.Dispose();
        }

        private void Connected_status()
        {

        }

        private void ConnectToDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Control.ControlCollection controls_arr = this.Controls;
            //controls_arr = this.Controls;
            Control control_to_close = controls_arr["MainDatabaseManagementControler"];
            control_to_close.Dispose();

            this.connectToDatabaseToolStripMenuItem.Enabled = false;
            this.UserItem.User_Logout();
            this.Serverlogin_Load(this, this.UserItem);
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

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
