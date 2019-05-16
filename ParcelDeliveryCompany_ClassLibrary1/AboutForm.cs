using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParcelDeliveryCompany_ClassLibrary1 //ParcelDeliveryCompanyApplication //TestSQLServerProject01
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
            Show_licenses();
        }

        private void Show_licenses()
        {
            licenseRichTextBox.Text = "\"GMaps .NET is great and Powerful, Free, cross platform, open source .NET control.\"\nProject's home website: https://github.com/radioman/greatmaps" +
               "\nGMaps .NET created by radioman, 2019.\n" +
               "\n" +
               "\nThis application is meant to be used with Microsoft SQL Server instance to work properly. Microsoft SQL Server copyrights belong to Microsoft Corporation, 2019.\n" +
               "\n" +
               "Parcel Delivery Company Management applcation created by Marcin Surma, 2019.";
        }

        private void Close_button_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
