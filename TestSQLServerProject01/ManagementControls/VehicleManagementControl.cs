using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ParcelDeliveryCompany_ClassLibrary1;

namespace TestSQLServerProject01
{
    public partial class VehicleManagementControl : UserControl
    {
        private UserClass mainW;

        public UserClass MainWindowReference { get => mainW; set => mainW = value; }

        private enum ListControlEnable
        {
            disabled = 0,
            enabled = 1
        };

        public VehicleManagementControl()
        {
            InitializeComponent();
        }

        public VehicleManagementControl(UserClass mW)
        {
            InitializeComponent();
            this.MainWindowReference = mW;
            
        }

        private void AddVehicle_button_Click(object sender, EventArgs e)
        {
            try
            {
                VehicleAddEditForm addVehForm = new VehicleAddEditForm(MainWindowReference, 0, 0);
                addVehForm.ShowDialog();
            }
            catch
            {
                MessageClass.DisplayMessage(401);
            }
            LoadVehicleList();
        }

        internal void MainWReference(UserClass mainW)
        {
            MainWindowReference = mainW;
        }

        internal void LoadVehicleList()
        {
            vehicle_ListView.Items.Clear();
            DataTable dt = new DataTable();
            try {
                using (SqlConnection connection = new SqlConnection(MainWindowReference.GetConnectionString()))
                using (SqlCommand command = new SqlCommand("SELECT * FROM Vehicle_Details_View", connection)) //SELECT p.Id_pojazdu, tp.Typ_pojazdu FROM Pojazd p INNER JOIN Typ_pojazdu tp ON p.Id_typu_pojazdu=tp.Id_typu_pojazdu WHERE p.Id_typu_pojazdu = tp.Id_typu_pojazdu
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    adapter.Fill(dt);
                    foreach (DataRow row in dt.Rows)
                    {
                        ListViewItem item = new ListViewItem(row[0].ToString());
                        item.SubItems.Add(row[1].ToString());
                        vehicle_ListView.Items.Add(item);
                    }
                }
            }
            catch (SqlException)
            {
                MessageClass.DisplayMessage(411);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageClass.DisplayMessage(410);
            }
        }

        private void EditVehicle_button_Click(object sender, EventArgs e)
        {
            if (vehicle_ListView.SelectedItems.Count == 1)
            {
                try
                {
                    int vehicle_to_edit = 0;
                    vehicle_to_edit = Convert.ToInt32(vehicle_ListView.SelectedItems[0].Text);
                    VehicleAddEditForm addVehForm = new VehicleAddEditForm(MainWindowReference, 1, vehicle_to_edit);
                    addVehForm.ShowDialog();
                }
                catch (Exception)
                {
                    MessageClass.DisplayMessage(401);
                }
            }
            LoadVehicleList();
        }

        private void RemoveVehicle_button_Click(object sender, EventArgs e)
        {
            if (vehicle_ListView.SelectedItems.Count == 1)
            {
                DialogResult dlg_result = MessageBox.Show("Are you sure you want to remove selected vehicle/vehicles?", "Attention!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (dlg_result == DialogResult.Yes)
                {
                    try
                    {
                        using (SqlConnection connection = new SqlConnection(MainWindowReference.GetConnectionString()))
                        using (SqlCommand command = new SqlCommand("DELETE FROM Pojazd WHERE Id_pojazdu=@Id_pojazdu", connection))
                        {
                            connection.Open();
                            command.Parameters.Add("@Id_pojazdu", SqlDbType.Int);

                            foreach (ListViewItem vehicle_to_remove in vehicle_ListView.SelectedItems)
                            {
                                command.Parameters["@Id_pojazdu"].Value = Convert.ToInt32(vehicle_to_remove.Text);
                                int result = command.ExecuteNonQuery();
                                if (result < 1)
                                {
                                    MessageClass.DisplayMessage(407);
                                }
                            }
                        }
                    }
                    catch (Exception)
                    {
                        MessageClass.DisplayMessage(408);
                    }
                }
                else
                {
                    vehicle_ListView.SelectedItems.Clear();
                }
                LoadVehicleList();
            }

        }

        private void RefreshList_button_Click(object sender, EventArgs e)
        {
            LoadVehicleList();
        }

        private void ToggleListAndButtons(ListControlEnable choice)
        {
            if (choice == ListControlEnable.enabled)
            {
                vehicle_ListView.Enabled = true;
                addVehicle_button.Enabled = true;
                editVehicle_button.Enabled = true;
                removeVehicle_button.Enabled = true;
                refreshList_button.Enabled = true;
            }
            else if (choice == ListControlEnable.disabled)
            {
                vehicle_ListView.Enabled = false;
                addVehicle_button.Enabled = false;
                editVehicle_button.Enabled = false;
                removeVehicle_button.Enabled = false;
                refreshList_button.Enabled = false;
            }
        }

        private void Vehicle_ListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (vehicle_ListView.SelectedItems.Count == 1)
            {
                editVehicle_button.Enabled = true;
                removeVehicle_button.Enabled = true;
            }
            /*else if (vehicle_ListView.SelectedItems.Count > 1) { //Zablokowano możliwość, aby zapobiec przypadkowemu usunięciu kilku/wszystkich pojazdów
                editVehicle_button.Enabled = false;
                removeVehicle_button.Enabled = true;
            }*/
            else
            {
                editVehicle_button.Enabled = false;
                removeVehicle_button.Enabled = false;
            }
        }
    }
}
