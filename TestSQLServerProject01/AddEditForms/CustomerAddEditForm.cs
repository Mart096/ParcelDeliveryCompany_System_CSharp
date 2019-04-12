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

namespace ParcelDeliveryCompanyApplication
{
    public partial class CustomerAddEditForm : Form
    {
        private UserClass mainW;
        private FormMode current_mode;
        private int edit_id;

        enum FormMode
        {
            add = 0,
            edit = 1
        };

        public CustomerAddEditForm()
        {
            InitializeComponent();
        }

        public CustomerAddEditForm(UserClass mW, int mode, int edit_id)
        {
            InitializeComponent();
            MainWindowReference = mW;
            customerAddEdit_Controler.MainWindowReference = MainWindowReference;
            current_mode = (FormMode)mode;
            Toggle_Form_Descr(current_mode);
            customerAddEdit_Controler.Load_City_List();

            if (current_mode == FormMode.edit)
            {
                this.edit_id = edit_id;
                customerAddEdit_Controler.Load_Customer_To_Edit( edit_id);
            }
        }

        private void Toggle_Form_Descr(FormMode formMode)
        {
            if (formMode == FormMode.add)
            {
                accept_button.Text = "Add new";
                this.Text = "Add new customer";
            }
            else if (formMode == FormMode.edit)
            {
                accept_button.Text = "Save changes";
                this.Text = "Edit selected customer";
            }
        }

        internal UserClass MainWindowReference { get => mainW; set => mainW = value; }

        private void Accept_button_Click(object sender, EventArgs e)
        {
            try
            {
                using(SqlConnection connection = new SqlConnection(MainWindowReference.GetConnectionString()))
                {
                    if (current_mode == FormMode.add && customerAddEdit_Controler.Check_Input() == true)
                    {
                        
                        customerAddEdit_Controler.Insert_New_Sender(connection);
                        this.Close();
                        this.Dispose();
                    }
                    else if (current_mode == FormMode.edit && customerAddEdit_Controler.Check_Input() == true)
                    {
                        customerAddEdit_Controler.Edit_client(connection, this.edit_id);
                        this.Close();
                        this.Dispose();
                    }
                    else
                    {
                        MessageClass.DisplayMessage(1112);// MessageBox.Show("Not all data was specified. Check your input for missing infromation.", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception){
                MessageClass.DisplayMessage(813); //MessageBox.Show("Failed to add/edit customer.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
                this.Dispose();
            }
        }

        private void Cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        
    }
}
