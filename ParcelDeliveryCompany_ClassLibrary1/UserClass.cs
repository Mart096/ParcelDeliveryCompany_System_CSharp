using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParcelDeliveryCompany_ClassLibrary1
{
    public class UserClass
    {
        private string connectionString;
        private UserRole current_role=UserRole.None;

        public string ConnectionString { get => connectionString; set => connectionString = value; }
        public UserRole Current_role { get => current_role; private set => current_role = value; }

        public enum UserRole
        {
            Admin = 0,
            Dispatcher = 1,
            Courier = 2,
            OrderManager = 3,
            CustomerContact = 4,
            None = 5
        };

        public UserClass()
        {
            //this.MainWindowReference = connectionString;
        }
        public UserClass(String connectionString)
        {
            this.ConnectionString = connectionString;
        }

        public string GetConnectionString()
        {
            return this.ConnectionString;
        }

        private int UserAuthentication()
        {
            try
            {

                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand auth_command = new SqlCommand("DECLARE @Result INT " +
                            "IF IS_ROLEMEMBER(@name1) = 1 " +
                            "SET @Result = 0;" +
                            "ELSE IF IS_ROLEMEMBER(@name2) = 1 " +
                            "SET @Result = 1;" +
                            "ELSE IF IS_ROLEMEMBER(@name3) = 1 " +
                            "SET @Result = 2;" +
                            "ELSE IF IS_ROLEMEMBER(@name4) = 1 " +
                            "SET @Result = 3;" +
                            "ELSE IF IS_ROLEMEMBER(@name5) = 1 " +
                            "SET @Result = 4;" +
                            "ELSE " +
                            "SET @Result = 5;" +
                            "SELECT @Result", connection))
                {
                    auth_command.Parameters.Add("@name1", SqlDbType.NVarChar);
                    auth_command.Parameters.Add("@name2", SqlDbType.NVarChar);
                    auth_command.Parameters.Add("@name3", SqlDbType.NVarChar);
                    auth_command.Parameters.Add("@name4", SqlDbType.NVarChar);
                    auth_command.Parameters.Add("@name5", SqlDbType.NVarChar);
                    auth_command.Parameters["@name1"].Value = "db_owner";
                    auth_command.Parameters["@name2"].Value = "Dispatcher";
                    auth_command.Parameters["@name3"].Value = "Courier";
                    auth_command.Parameters["@name4"].Value = "OrderManager";
                    auth_command.Parameters["@name5"].Value = "CustomerContact";
                    connection.Open();
                    int result = Convert.ToInt32(auth_command.ExecuteScalar());
                    if (result == 0)
                    {
                        SetUserRole(UserRole.Admin);
                        return (int)UserRole.Admin;
                    }
                    if (result == 1)
                    {
                        SetUserRole(UserRole.Dispatcher);
                        return (int)UserRole.Dispatcher;
                    }
                    if (result == 2)
                    {
                        SetUserRole(UserRole.Courier);
                        return (int)UserRole.Courier;
                    }
                    if (result == 3)
                    {
                        SetUserRole(UserRole.OrderManager);
                        return (int)UserRole.OrderManager;
                    }
                    else if (result == 4)
                    {
                        SetUserRole(UserRole.CustomerContact);
                        return (int)UserRole.CustomerContact;
                    }
                    else
                    {
                        SetUserRole(UserRole.None);
                        return (int)UserRole.None;
                    }

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Failed to authenticate user. Error occured!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return (int)UserRole.None;
        }

        public bool IsAdmin()
        {
            int result = UserAuthentication();
            if (result == (int)UserRole.Admin)
            {
                return true;
            }
            else
                return false;
        }
        public bool IsEmployee()
        {
            int result = UserAuthentication();
            if (result != (int)UserRole.None)
            {
                return true;
            }
            else
                return false;
        }

        private void SetUserRole(UserRole role)
        {
            this.Current_role = role;
        }

        public void User_Logout()
        {
            ConnectionString = "";
            SetUserRole(UserRole.None);
        }
    }
}
