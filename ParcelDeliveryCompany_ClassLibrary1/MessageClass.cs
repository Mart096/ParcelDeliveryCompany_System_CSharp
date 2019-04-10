using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParcelDeliveryCompany_ClassLibrary1
{
    public static class MessageClass
    {
        /*static MessageClass()
        {

        }*/

        public static void DisplayMessage(int message_code)
        {
            if (message_code == 102)
            {
                MessageBox.Show("The port number has invalid characters. Remove any character that is " +
                      "not a number.", "Port Number is Invalid", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (message_code == 203)
            {
                MessageBox.Show("You have to select dictionary first to add new record.", "No dictionary selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (message_code == 204)
            {
                MessageBox.Show("Error occured during an attemmpt to search for\nspecified items in customers' list.");
            }
            else if (message_code == 205)
            {
                MessageBox.Show("Failed to initialize dictionary item edit form. Error occured!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //DictionaryAddRecordForm
            else if (message_code == 301)
            {
                MessageBox.Show("Failed to add new/modify existing dictionary record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (message_code == 302)
            {
                MessageBox.Show("Error occcured during insertion of new/modification of selected dictionary record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (message_code == 303)
            {
                MessageBox.Show("Could not load record's data to edit. Error occured!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (message_code == 304)
            {
                
            }
            else if (message_code == 305)
            {
                
            }
            //VehicleAddEditForm
            else if (message_code == 401)
            {
                MessageBox.Show("Failed to initialize vehicle add/edit form.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (message_code == 402)
            {
                MessageBox.Show("Error occcured after an attempt to load vehicle types.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (message_code == 403)
            {
                MessageBox.Show("Error occcured after an attempt to load edited vehicle's data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (message_code == 404)
            {
                MessageBox.Show("Error occured after an attempt to insert new vehicle.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (message_code == 405)
            {
                MessageBox.Show("You must enter name and choose vehicle type to add new vehicle", "Some data has been left unspecified", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (message_code == 415)
            {
                MessageBox.Show("You must enter name and choose vehicle type to save changes to edited vehicle", "Some data has been left unspecified", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (message_code == 406)
            {
                MessageBox.Show("Failed to save changes to edited vehicle", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (message_code == 407)
            {
                MessageBox.Show("Failed to remove selected vehicle.\nSelected vehicle might be already assigned to courier, thus cannot be removed.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (message_code == 408)
            {
                MessageBox.Show("Failed to remove selected vehicle. Error occured.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (message_code == 409)
            {
                MessageBox.Show("Failed to save changes to edited vehicle", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (message_code == 410)
            {
                MessageBox.Show("Could not load vehicle's list.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (message_code == 411)
            {
                MessageBox.Show("Could not load vehicle's list. Server/database fault occured.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //Courier
            else if (message_code == 501)
            {
                MessageBox.Show("Could not load courier's data.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (message_code == 502)
            {
                MessageBox.Show("Failed to remove selected courier.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (message_code == 503)
            {
                MessageBox.Show("This operation affected more than one record!\nConsult with data base administrator!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (message_code == 504)
            {
                MessageBox.Show("Failed to initalize add/edit courier form!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (message_code == 505)
            {
                MessageBox.Show("Failed to load courier's data!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (message_code == 506)
            {
                MessageBox.Show("Error occured! Failed to add new courier to database!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (message_code == 507)
            {
                MessageBox.Show("Error occured! Failed to save changes to courier's data!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (message_code == 508)
            {
                MessageBox.Show("Failed to add new courier to data base!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (message_code == 509)
            {
                MessageBox.Show("New courier added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (message_code == 510)
            {
                MessageBox.Show("The following data was not complete. Fill in missing information.", "Incomplete data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //Orders
            else if (message_code == 601)
            {
                MessageBox.Show("Failed to load orders\' list.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (message_code == 602)
            {
                MessageBox.Show("Failed to initialize add/edit order form.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (message_code == 603)
            {
                MessageBox.Show("Failed to load edited order's data.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (message_code == 604)
            {
                MessageBox.Show("Query failed! Please, try again later.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (message_code == 605)
            {
                MessageBox.Show("New order added successfully!", "Success", MessageBoxButtons.OK);
            }
            else if (message_code == 606)
            {
                MessageBox.Show("Selected order updated successfully!", "Success", MessageBoxButtons.OK);
            }
            else if (message_code == 607)
            {
                MessageBox.Show("Failed to save new order's details.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (message_code == 608)
            {
                MessageBox.Show("Failed to save changes to selected order.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (message_code == 703)
            {
                MessageBox.Show("Query unexpected behaviour detected! Please contact your data base administrator and let them know about issue.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //Customers
            else if (message_code == 801)
            {
                MessageBox.Show("Could not load senders/customers' list.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (message_code == 802)
            {
                MessageBox.Show("Failed to add new customer during insertion of new order.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (message_code == 803)
            {
                MessageBox.Show(/*ex.Message + */"Error occured during an attemmpt to search for\nspecified items in customers' list.");
            }
            else if (message_code == 804)
            {
                MessageBox.Show("Failed to initialize customer add/edit form.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (message_code == 806)
            {
                MessageBox.Show("Failed to remove selected customer! Check if customer is assigned to orders, consignments, pickup requests and/or complaints.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (message_code == 807)
            {
                MessageBox.Show("Customer removed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (message_code == 808)
            {
                MessageBox.Show("Error occured during an attempt to remove selected customer! .", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (message_code == 809)
            {
                MessageBox.Show("Failed to load client's data to edit.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (message_code == 810)
            {
                MessageBox.Show("Modifications to customer's data saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (message_code == 811)
            {
                MessageBox.Show(/*ex.Message+*/"Failed to save changes to customer's data.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (message_code == 812)
            {
                MessageBox.Show("Failed to add new customer.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (message_code == 813)
            {
                MessageBox.Show("Failed to add/edit customer.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //Area
            else if (message_code == 901)
            {
                MessageBox.Show("Could not load list of areas.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //City
            else if (message_code == 1001)
            {
                MessageBox.Show("Could not load list of cities.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (message_code == 1002)
            {
                //MessageBox.Show("Could not load list of cities.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MessageBox.Show("Failed to add new city during insertion of new order.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //Consignments
            else if (message_code == 1101)
            {
                MessageBox.Show("Error! Could not initialize consignment's add/edit form.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (message_code == 1102)
            {
                MessageBox.Show("Error! Could not initialize consignment's details form.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (message_code == 1103)
            {
                MessageBox.Show("Could not load consignees' list.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (message_code == 1104)
            {
                MessageBox.Show("Could not load pickup methods' list.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (message_code == 1105)
            {
                MessageBox.Show("Could not load edited consignment's data. Error occured!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (message_code == 1106)
            {
                MessageBox.Show("Query failed! Please, try again later.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (message_code == 1107)
            {
                MessageBox.Show("Query unexpected behaviour detected! Please contact your data base administrator and let them know about issue.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (message_code == 1108)
            {
                MessageBox.Show("New consignment added successfully!", "Success", MessageBoxButtons.OK);
            }
            else if (message_code == 1109)
            {
                MessageClass.DisplayMessage(1109); MessageBox.Show("Selected consignment has been updated successfully!", "Success", MessageBoxButtons.OK);
            }
            else if (message_code == 1110)
            {
                MessageBox.Show("Failed to save new order's details." /*+ ex.Message*/, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (message_code == 1111)
            {
                MessageBox.Show("Failed to save changes to selected order.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (message_code == 1112)
            {
                MessageBox.Show("Not all data was specified. Check your input for missing information.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (message_code == 1113)
            {
                MessageBox.Show(/*ex.Message+*/"Error occured during an attemmpt to search for\nspecified items in consignees' list.");
            }
            //Consignment type
            else if (message_code == 1201)
            {
                MessageBox.Show("Could not load consignment types' list.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //Location
            else if (message_code == 1301)
            {
                MessageBox.Show("Could not load locations' list.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (message_code == 1302)
            {
                MessageBox.Show("Could not load edited location's data. Error occured!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (message_code == 1303)
            {
                MessageBox.Show("Could not initialize location add/edit form. Error occured!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (message_code == 1304)
            {
                //MessageBox.Show("Query unexpected behaviour detected! Please contact your data base administrator and let them know about issue.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MessageBox.Show("Failed to insert new location!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (message_code == 1305)
            {
                MessageBox.Show("Failed to save changes to edited location!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //Parcel
            else if (message_code == 1401)
            {
                MessageBox.Show("Failed to load edited parcel's data.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (message_code == 1402)
            {
                MessageBox.Show("New parcel added successfully!", "Success", MessageBoxButtons.OK);
            }
            else if (message_code == 1403)
            {
                MessageBox.Show("Selected parcel has been updated successfully!", "Success", MessageBoxButtons.OK);
            }
            else if (message_code == 1404)
            {
                MessageBox.Show("Failed to save new order's details." /*+ ex.Message*/, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (message_code == 1405)
            {
                MessageBox.Show("Failed to initialize parcel add/edit form.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (message_code == 1405)
            {
                MessageBox.Show("Failed to save changes to selected order.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //Pickup Request
            else if (message_code == 1501)
            {
                MessageBox.Show("Could not load couriers or orders' list.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (message_code == 1502)
            {
                MessageBox.Show("Could not load selected pickup request's data.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (message_code == 1503)
            {
                MessageBox.Show("Failed to add new pickup request.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (message_code == 1504)
            {
                MessageBox.Show("Failed to save changes to seleceted pickup request.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (message_code == 1505)
            {
                MessageBox.Show("New pickup request has been added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (message_code == 1506)
            {
                MessageBox.Show("Changes to seleceted pickup request have been saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (message_code == 1507)
            {
                MessageBox.Show("Failed to add new pickup request. Error occured!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (message_code == 1508)
            {
                MessageBox.Show("Failed to save changes to selected pickup request. Error occured!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (message_code == 1509)
            {
                MessageBox.Show("Not all data was specified! Check your input for missing information.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (message_code == 1510)
            {
                MessageBox.Show("Failed to initialize pickup request add/edit form.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (message_code == 1511)
            {
                MessageBox.Show("Failed to initialize pickup request's details form.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (message_code == 1512)
            {
                
            }
            //Complaint
            else if (message_code == 1601)
            {
                MessageBox.Show("Could not load selected complaint's data.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (message_code == 1602)
            {
                MessageBox.Show("Could not load consignments' list.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (message_code == 1603)
            {
                MessageBox.Show("Failed to add new complaint.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (message_code == 1604)
            {
                MessageBox.Show("Failed to save changes to seleceted complaint.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (message_code == 1605)
            {
                MessageBox.Show("New complaint has been added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (message_code == 1606)
            {
                MessageBox.Show("Changes to seleceted complaint has been saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (message_code == 1607)
            {
                MessageBox.Show("Failed to add new complaint. Error occured!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (message_code == 1608)
            {
                MessageBox.Show("Failed to save changes to selected complaint. Error occured!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (message_code == 1609)
            {
                MessageBox.Show("Could not load complaint states' list.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (message_code == 1610)
            {
                MessageBox.Show("Could not load complaints' list.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (message_code == 1611)
            {
                MessageBox.Show("Complaint has been updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (message_code == 1612)
            {
                MessageBox.Show("Failed to update complaint's data.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (message_code == 1613)
            {
                MessageBox.Show("Failed to initiate complaint's update. Error occured.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (message_code == 1614)
            {
                MessageBox.Show("Failed to initiate complaint's add/edit form. Error occured.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (message_code == 1615)
            {
                MessageBox.Show("Failed to initiate complaint's details form. Error occured.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //Course Consignment
            else if (message_code == 1701)
            {
                MessageBox.Show("Could not load consignments' list.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (message_code == 1702)
            {
                MessageBox.Show("Failed to add selected consignment to course.\n" +
                                "Make sure if consignment is not already added to the same course.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (message_code == 1703)
            {
                MessageBox.Show("Consignment has been added to course successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (message_code == 1704)
            {
                MessageBox.Show("Failed to add selected consignment to course. Error occured!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (message_code == 1705)
            {
                MessageBox.Show("Failed to load consignment's data. Error occured!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (message_code == 1706)
            {
                MessageBox.Show("Error! Could not initialize \"Add consignment to course\" form.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (message_code == 1709)
            {
                MessageBox.Show("Failed to remove selected consignment from course.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (message_code == 1710)
            {
                MessageBox.Show("Failed to load course's consignments. Query failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (message_code == 1711)
            {
                MessageBox.Show("Failed to load course's consignments.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //Pickup state
            else if (message_code == 1801)
            {
                MessageBox.Show("Could not load pickup states' list.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (message_code == 1803)
            {
                MessageBox.Show("Consignment has been updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (message_code == 1804)
            {
                MessageBox.Show("Failed to update consignment's data.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (message_code == 1805)
            {
                MessageBox.Show("Failed to initiate consignment's update. Error occured.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //Pickup request
            else if (message_code == 1901)
            {
                MessageBox.Show("Could not load pickup states' list.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (message_code == 1902)
            {
                MessageBox.Show("Could not load pickup request's data.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (message_code == 1904)
            {
                MessageBox.Show("Pickup request has been updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (message_code == 1905)
            {
                MessageBox.Show("Failed to update pickup request's data.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (message_code == 1906)
            {
                MessageBox.Show("Failed to initiate pickup request's update. Error occured.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (message_code == 2001)
            {
                MessageBox.Show("Failed to initialize parcel add form.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (message_code == 2002)
            {
                MessageBox.Show("Failed to load consignment's parcels. Query failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (message_code == 2003)
            {
                MessageBox.Show("Failed to load consignment's parcels.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //CourseMapForm
            else if (message_code == 2101)
            {
                MessageBox.Show("Failed to send course's data to map control." /*+ ex.Message*/, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //MainDatabaseManagementControler
            else if (message_code == 2201)
            {
                MessageBox.Show("Failed to obtain user's permissions. Access to controls has been denied. Try to log in again.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //MainForm
            else if (message_code == 2301)
            {
                MessageBox.Show("Your account is not authorized to use this application! Ask database administrator for permission.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (message_code == 2302)
            {
                MessageBox.Show("Could not connect to database!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (message_code == 2303)
            {
                MessageBox.Show("Your account is not authorized to use this application! Use admin's application to manage data.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //Course
            else if (message_code == 2401)
            {
                MessageBox.Show("Failed to initialize course's details form.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static DialogResult DisplayMessage(int message_code, string item_name) //metoda stosowana przy zapytaniach
        {
            if (message_code == 701)
            {
                return MessageBox.Show("Are you sure you want to remove selected " + item_name + "?", "Attention!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            }
            else if (message_code == 702)
            {
                return MessageBox.Show(item_name + " removed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (message_code == 704)
            {
                return MessageBox.Show("Failed to remove selected " + item_name + ".", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (message_code == 705)
            {
                return MessageBox.Show("Could not load " + item_name + " list. Query failed."/* + ex.Message*/, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (message_code == 706)
            {
                return MessageBox.Show("Could not load " + item_name + " list. "/* + ex.Message*/, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (message_code == 805)
            {
                return MessageBox.Show("Are you sure you want to remove this customer?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
            else if (message_code == 1614)
            {
                return MessageBox.Show("Are you sure you want to change state of this complaint?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
            else if (message_code == 1707)
            {
                return MessageBox.Show("Are you sure you want to remove selected " + item_name + " from course?", "Attention!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            }
            else if (message_code == 1708)
            {
                return MessageBox.Show(item_name + " removed from course successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (message_code == 1802)
            {
                return MessageBox.Show("Are you sure you want to change pickup state of this consignment?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
            else if (message_code == 1903)
            {
                return MessageBox.Show("Are you sure you want to change state of this pickup request?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
            else
            {
                return DialogResult.No;
            }
        }

        public static void DisplayMessage(int message_code, Exception ex)
        {
            //ServerLoginControler
            if (message_code == 101)
            {
                MessageBox.Show("Could not open connection!\n" + ex.Message);
            }
            else if (message_code == 102)
            {
                MessageBox.Show("The port number has invalid characters. Remove any character that is " +
                      "not a number.", "Port Number is Invalid", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (message_code == 103)
            {
                MessageBox.Show("Failed to load server configuration file. Fill in server address, port number and database name in "+ AppDomain.CurrentDomain.BaseDirectory + "\\dataSource.xml" + " or contact administrator to resolve the problem.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (message_code == 201)
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
