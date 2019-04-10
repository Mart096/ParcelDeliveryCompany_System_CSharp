using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Linq;
using ParcelDeliveryCompany_ClassLibrary1;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace CourierCompanyEmployeeApplication
{
    public partial class EmployeeServerLoginControl : UserControl
    {
        private EmployeeMainForm MainW;
        private int TimeOutInt = 10;

        enum ButtonsEnabled
        {
            disabled = 0,
            enabled = 1
        }

        public EmployeeServerLoginControl()
        {
            InitializeComponent();
        }

        public EmployeeServerLoginControl(EmployeeMainForm mainW)
        {
            InitializeComponent();
            this.MainW = mainW;
            //this.userRef = this.MainW.UserItem;

            try
            { //wczytywanie nazwy serwera i bazy danych z pliku dataSource.xml
                FileStream fs = new FileStream(AppDomain.CurrentDomain.BaseDirectory + "\\dataSource.xml", FileMode.Open, FileAccess.Read);
                XDocument xdoc = XDocument.Load(fs);

                this.ipBox.Text = (from xml in xdoc.Element("Data_source").Descendants("Source")
                                   select xml.Element("Server_url").Value).First().ToString();

                this.portNumberBox.Text = (from xml in xdoc.Element("Data_source").Descendants("Source")
                                           select xml.Element("Port").Value).First().ToString();

                this.databaseBox.Text = (from xml in xdoc.Element("Data_source").Descendants("Source")
                                         select xml.Element("Database").Value).First().ToString();

                fs.Close();
                //XmlReader xmlreader =
            }
            catch (Exception ex)
            {
                MessageClass.DisplayMessage(103, ex);
                FileStream fs = new FileStream(AppDomain.CurrentDomain.BaseDirectory + "\\dataSource.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                XDocument xdoc = new XDocument(
                    new XDeclaration("1.0", "UTF-8", "no"),
                        new XElement("Data_source",
                                        new XElement("Source",
                                            new XElement("Server_url", ""),
                                            new XElement("Port", ""),
                                            new XElement("Database", "")
                                                    )
                                     )
                );
                try
                {
                    xdoc.Save(fs);
                }
                finally
                {
                    fs.Close();
                }

            }

        }

        private void ConnectButton1_Click(object sender, EventArgs e)
        {
            //Blokowanie pól
            ToggleButtons(ButtonsEnabled.disabled);

            //string connectionString = null;
            //SqlConnection connection01;
            Regex portReg1 = new Regex("^\\d+$");

            //Zapamiętywanie adresu serwera, nazwy BD i loginu użytkownika
            String ServerUrlString = ipBox.Text;//@"DESKTOP-UUNN1M4";
            String DatabaseNameString = databaseBox.Text;
            String UserLoginString = userLoginBox.Text;
            String PortString = portNumberBox.Text;//Convert.ToInt32(portNumberBox.Text);
            //MainW.UserPasswordString = passwordBox.Text;

            if (!(portReg1.IsMatch(PortString)) && PortString.Length != 0)
            {
                MessageClass.DisplayMessage(102, new Exception(""));
                return;
            }
            SqlConnectionStringBuilder builder1 = new SqlConnectionStringBuilder(); //umożliwia budowę ciągu znaków zawierającego dane potrzebne do nawiązania połączenia

            //Wprowadzanie danych do ciągu znaków, wykorzystywanego do nawiązania połączenia
            if (PortString.Length == 0) //nie rozpoznano numeru portu
            {
                builder1.DataSource = ServerUrlString;
                builder1.InitialCatalog = DatabaseNameString;
                builder1.UserID = userLoginBox.Text;
                builder1.Password = passwordBox.Text;
                builder1.ConnectTimeout = TimeOutInt;

                /*connectionString = "Data Source=" + ServerUrlString + ";Initial Catalog=" + DatabaseNameString +
                    ";User ID=" + userLoginBox.Text +";Password=" + passwordBox.Text + ";Connection Timeout=" + this.TimeOutInt.ToString();//MainW.UserLoginString + ";Password=" + passwordBox.Text + ";Connection Timeout="+this.TimeOutInt.ToString();
                /*connectionString = "Data Source=@ServerUrlString; Initial Catalog=@DatabaseNameString;User ID=@UserLogin;Password=@Password;" + "Connection Timeout=" + this.TimeOutInt.ToString();*/
                //MainW.Set_ConnectionString(connectionString);//builder1.ConnectionString.ToString());

                //MainW.Set_ConnectionString(builder1.ConnectionString.ToString());
                this.MainW.UserItem.ConnectionString = builder1.ConnectionString.ToString();
            }
            else //numer portu został podany
            {
                builder1.DataSource = ServerUrlString + ", " + PortString;
                builder1.InitialCatalog = DatabaseNameString;
                builder1.UserID = userLoginBox.Text;
                builder1.Password = passwordBox.Text;
                builder1.ConnectTimeout = TimeOutInt;

                //connectionString = "Data Source=" + ServerUrlString + ", " + PortString + ";Initial Catalog=" + 
                // DatabaseNameString + ";User ID=" + userLoginBox.Text + ";Password=" + passwordBox.Text + ";Connection Timeout=" + this.TimeOutInt.ToString(); // MainW.UserLoginString + ";Password=" + passwordBox.Text + ";Connection Timeout="+this.TimeOutInt.ToString();
                /*connectionString = "Data Source=@ServerUrlString, @PortString;Initial Catalog=@DatabaseName;" +
                "User ID=@UserLogin;Password=@Password;Connection Timeout=" + this.TimeOutInt.ToString(); // MainW.UserLoginString + ";Password=" + passwordBox.Text + ";Connection Timeout="+this.TimeOutInt.ToString();*/

                //MainW.Set_ConnectionString(builder1.ConnectionString);// connectionString);
                this.MainW.UserItem.ConnectionString = builder1.ConnectionString.ToString();
            }

            //using
            int result = MainW.SQLconnectionOpenClose(/*builder1.ConnectionString*/);


            ToggleButtons(ButtonsEnabled.enabled);

            if (result == 0)
            {
                MainW.DispatcherControl_load();
                this.Dispose();
            }

            /*/Przygotowanie do nawiązania połączenia
            connection01 = new SqlConnection(connectionString);
            
            try
            {
                connection01.Open(); //łączenie z serwerem, wykorzystując wcześniejsze parametry 
                MessageBox.Show("Connection open successful.");
                connection01.Close(); //Kończenie połączenia
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to connect to server." + ex.Message, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MainW.ServerUrlString = "";
                MainW.DatabaseNameString = "";
                MainW.UserLoginString = "";
                MainW.PortString = "";
            }*/
        }

        private void ToggleButtons(ButtonsEnabled buttons_mode)
        {
            if (buttons_mode == ButtonsEnabled.enabled)
            {
                ipBox.ReadOnly = false;
                portNumberBox.ReadOnly = false;
                databaseBox.ReadOnly = false;
                userLoginBox.ReadOnly = false;
                passwordBox.ReadOnly = false;
                connectButton1.Enabled = true;
            }
            else if (buttons_mode == ButtonsEnabled.disabled)
            {
                ipBox.ReadOnly = true;
                portNumberBox.ReadOnly = true;
                databaseBox.ReadOnly = true;
                userLoginBox.ReadOnly = true;
                passwordBox.ReadOnly = true;
                connectButton1.Enabled = false;
            }
        }

        private void AcceptNumbersOnly1(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
