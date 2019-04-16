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
using System.Data.SqlClient;

namespace ParcelDeliveryCompanyApplication
{
    public partial class LocationManagementControl : UserControl
    {
        private UserClass MainW;

        private enum ListControlEnable
        {
            disabled = 0,
            enabled = 1
        };

        public LocationManagementControl()
        {
            InitializeComponent();
        }

        LocationManagementControl(UserClass mW)
        {
            InitializeComponent();
            MainWindowReference = mW;

        }

        public UserClass MainWindowReference { get => MainW; set => MainW = value; }

        private void AddLocation_button_Click(object sender, EventArgs e)
        {
            try
            {
                LocationAddEditForm addLocForm = new LocationAddEditForm(this.MainWindowReference, 0, 0);
                addLocForm.ShowDialog();
            }
            catch
            {
                //ErrorMessageClass.DisplayErrorMessage(401);
            }
            LoadLocationList();
        }

        internal void MainWReference(UserClass mainW)
        {
            this.MainW = mainW;
        }

        internal void LoadLocationList()
        {
            location_ListView.Items.Clear();
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(MainW.GetConnectionString()))
                using (SqlCommand command = new SqlCommand("SELECT * FROM Location_Detailed_View", connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    adapter.Fill(dt);
                    foreach (DataRow row in dt.Rows)
                    {
                        ListViewItem item = new ListViewItem(row[0].ToString());
                        item.SubItems.Add(row[1].ToString());
                        item.SubItems.Add(row[2].ToString());
                        item.SubItems.Add(row[3].ToString());
                        item.SubItems.Add(row[4].ToString());
                        item.SubItems.Add(row[5].ToString());
                        location_ListView.Items.Add(item);
                    }
                }
            }
            catch (SqlException)
            {
                //ErrorMessageClass.DisplayErrorMessage(411);
            }
            catch (Exception)
            {
                //ErrorMessageClass.DisplayErrorMessage(410);
            }
        }

        private void EditLocation_button_Click(object sender, EventArgs e)
        {
            if (location_ListView.SelectedItems.Count == 1)
            {
                try
                {
                    int location_to_edit = 0;
                    location_to_edit = Convert.ToInt32(location_ListView.SelectedItems[0].Text);
                    LocationAddEditForm editLocForm = new LocationAddEditForm(this.MainW, 1, location_to_edit);
                    editLocForm.ShowDialog();
                }
                catch (Exception)
                {
                    MessageClass.DisplayMessage(401);
                }
            }
            LoadLocationList();
        }

        private void RemoveLocation_button_Click(object sender, EventArgs e)
        {
            if (location_ListView.SelectedItems.Count == 1)
            {
                DialogResult dlg_result = MessageBox.Show("Are you sure you want to remove selected location?", "Attention!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (dlg_result == DialogResult.Yes)
                {
                    try
                    {
                        using (SqlConnection connection = new SqlConnection(MainW.GetConnectionString()))
                        using (SqlCommand command = new SqlCommand("DELETE FROM Punkt_obslugi WHERE Id_punktu=@location_id", connection))
                        {
                            connection.Open();
                            command.Parameters.Add("@location_id", SqlDbType.Int);

                            foreach (ListViewItem location_to_remove in location_ListView.SelectedItems)
                            {
                                command.Parameters["@location_id"].Value = Convert.ToInt32(location_to_remove.Text);
                                int result = command.ExecuteNonQuery();
                                if (result != 1)
                                {
                                    //ErrorMessageClass.DisplayErrorMessage(407);
                                }
                                else
                                {
                                    MessageBox.Show("Location removed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }
                    }
                    catch (Exception)
                    {
                        //ErrorMessageClass.DisplayErrorMessage(408);
                    }
                }
                else
                {
                    location_ListView.SelectedItems.Clear();
                }
                LoadLocationList();
            }
        }

        private void RefreshList_button_Click(object sender, EventArgs e)
        {
            LoadLocationList();
        }

        private void ToggleListAndButtons(ListControlEnable choice)
        {
            if (choice == ListControlEnable.enabled)
            {
                location_ListView.Enabled = true;
                addLocation_button.Enabled = true;
                editLocation_button.Enabled = true;
                removeLocation_button.Enabled = true;
                refreshList_button.Enabled = true;
            }
            else if (choice == ListControlEnable.disabled)
            {
                location_ListView.Enabled = false;
                addLocation_button.Enabled = false;
                editLocation_button.Enabled = false;
                removeLocation_button.Enabled = false;
                refreshList_button.Enabled = false;
            }
        }

        private void Location_ListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (location_ListView.SelectedItems.Count == 1)
            {
                editLocation_button.Enabled = true;
                removeLocation_button.Enabled = true;
            }
            else
            {
                editLocation_button.Enabled = false;
                removeLocation_button.Enabled = false;
            }
        }
    }
}
