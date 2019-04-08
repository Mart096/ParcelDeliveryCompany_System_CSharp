using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParcelDeliveryCompany_ClassLibrary1
{
    public static class ErrorMessageClass
    {
        /*static ErrorMessageClass()
        {

        }*/

        public static void DisplayErrorMessage(int error_code)
        {
            if (error_code == 102)
            {
                MessageBox.Show("The port number has invalid characters. Remove any character that is " +
                      "not a number.", "Port Number is Invalid", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (error_code == 203)
            {
                MessageBox.Show("You have to select dictionary first to add new record.", "No dictionary selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //DictionaryAddRecordForm
            else if (error_code == 301)
            {
                MessageBox.Show("Failed to add new dictionary record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (error_code == 302)
            {
                MessageBox.Show("Error occcured during insertion of new dictionary record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            //VehicleAddEditForm
            else if (error_code == 401)
            {
                MessageBox.Show("Failed to initialize vehicle add/edit form.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (error_code == 402)
            {
                MessageBox.Show("Error occcured after an attempt to load vehicle types.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (error_code == 403)
            {
                MessageBox.Show("Error occcured after an attempt to load edited vehicle's data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (error_code == 404)
            {
                MessageBox.Show("Error occured after an attempt to insert new vehicle.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (error_code == 405)
            {
                MessageBox.Show("You must enter name and choose vehicle type to add new vehicle", "Some data has been left unspecified", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (error_code == 415)
            {
                MessageBox.Show("You must enter name and choose vehicle type to save changes to edited vehicle", "Some data has been left unspecified", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (error_code == 406)
            {
                MessageBox.Show("Failed to save changes to edited vehicle", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (error_code == 407)
            {
                MessageBox.Show("Failed to remove selected vehicle.\nSelected vehicle might be already assigned to courier, thus cannot be removed.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (error_code == 408)
            {
                MessageBox.Show("Failed to remove selected vehicle. Error occured.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (error_code == 409)
            {
                MessageBox.Show("Failed to save changes to edited vehicle", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (error_code == 410)
            {
                MessageBox.Show("Could not load vehicle's list.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (error_code == 411)
            {
                MessageBox.Show("Could not load vehicle's list. Server/database fault occured.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //Courier
            else if (error_code == 501)
            {
                MessageBox.Show("Could not load courier's data.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (error_code == 502)
            {
                MessageBox.Show("Failed to remove selected courier.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (error_code == 503)
            {
                MessageBox.Show("This operation affected more than one record!\nConsult with data base administrator!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (error_code == 504)
            {
                MessageBox.Show("Failed to initalize add/edit courier form!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (error_code == 505)
            {
                MessageBox.Show("Failed to load courier's data!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (error_code == 506)
            {
                MessageBox.Show("Error occured! Failed to add new courier to database!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (error_code == 507)
            {
                MessageBox.Show("Error occured! Failed to save changes to courier's data!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (error_code == 508)
            {
                MessageBox.Show("Failed to add new courier to data base!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (error_code == 509)
            {
                MessageBox.Show("New courier added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (error_code == 510)
            {
                MessageBox.Show("The following data was not complete. Fill in missing information.", "Incomplete data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //Orders
            else if (error_code == 601)
            {
                MessageBox.Show("Failed to load orders\' list.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (error_code == 602)
            {
                MessageBox.Show("Failed to initialize add/edit order form.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void DisplayErrorMessage(int error_code, Exception ex)
        {
            //ServerLoginControler
            if (error_code == 101)
            {
                MessageBox.Show("Could not open connection!\n" + ex.Message);
            }
            else if (error_code == 102)
            {
                MessageBox.Show("The port number has invalid characters. Remove any character that is " +
                      "not a number.", "Port Number is Invalid", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (error_code == 103)
            {
                MessageBox.Show("Failed to load server configuration file. Fill in server address, port number and database name in "+ AppDomain.CurrentDomain.BaseDirectory + "\\dataSource.xml" + " or contact administrator to resolve the problem.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (error_code == 201)
            {
                MessageBox.Show("Could not receive query's result.\n");// + ex.Message);
            }
            else
            {
                MessageBox.Show("Error occured!\n");
            }
        }
    }
}
