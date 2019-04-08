namespace TestSQLServerProject01
{
    partial class VehicleManagementControl
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.vehicle_ListView = new System.Windows.Forms.ListView();
            this.vehicleID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.vehicleType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.addVehicle_button = new System.Windows.Forms.Button();
            this.editVehicle_button = new System.Windows.Forms.Button();
            this.removeVehicle_button = new System.Windows.Forms.Button();
            this.refreshList_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // vehicle_ListView
            // 
            this.vehicle_ListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vehicle_ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.vehicleID,
            this.vehicleType});
            this.vehicle_ListView.Location = new System.Drawing.Point(6, 88);
            this.vehicle_ListView.Name = "vehicle_ListView";
            this.vehicle_ListView.Size = new System.Drawing.Size(560, 295);
            this.vehicle_ListView.TabIndex = 0;
            this.vehicle_ListView.UseCompatibleStateImageBehavior = false;
            this.vehicle_ListView.View = System.Windows.Forms.View.Details;
            this.vehicle_ListView.SelectedIndexChanged += new System.EventHandler(this.Vehicle_ListView_SelectedIndexChanged);
            // 
            // vehicleID
            // 
            this.vehicleID.Text = "ID";
            this.vehicleID.Width = 79;
            // 
            // vehicleType
            // 
            this.vehicleType.Text = "Vehicle type";
            this.vehicleType.Width = 185;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.addVehicle_button);
            this.flowLayoutPanel1.Controls.Add(this.editVehicle_button);
            this.flowLayoutPanel1.Controls.Add(this.removeVehicle_button);
            this.flowLayoutPanel1.Controls.Add(this.refreshList_button);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 20);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(560, 62);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // addVehicle_button
            // 
            this.addVehicle_button.Location = new System.Drawing.Point(3, 3);
            this.addVehicle_button.Name = "addVehicle_button";
            this.addVehicle_button.Size = new System.Drawing.Size(85, 51);
            this.addVehicle_button.TabIndex = 0;
            this.addVehicle_button.Text = "Add vehicle";
            this.addVehicle_button.UseVisualStyleBackColor = true;
            this.addVehicle_button.Click += new System.EventHandler(this.AddVehicle_button_Click);
            // 
            // editVehicle_button
            // 
            this.editVehicle_button.Enabled = false;
            this.editVehicle_button.Location = new System.Drawing.Point(94, 3);
            this.editVehicle_button.Name = "editVehicle_button";
            this.editVehicle_button.Size = new System.Drawing.Size(85, 51);
            this.editVehicle_button.TabIndex = 1;
            this.editVehicle_button.Text = "Edit vehicle";
            this.editVehicle_button.UseVisualStyleBackColor = true;
            this.editVehicle_button.Click += new System.EventHandler(this.EditVehicle_button_Click);
            // 
            // removeVehicle_button
            // 
            this.removeVehicle_button.Enabled = false;
            this.removeVehicle_button.Location = new System.Drawing.Point(185, 3);
            this.removeVehicle_button.Name = "removeVehicle_button";
            this.removeVehicle_button.Size = new System.Drawing.Size(85, 51);
            this.removeVehicle_button.TabIndex = 2;
            this.removeVehicle_button.Text = "Remove vehicle";
            this.removeVehicle_button.UseVisualStyleBackColor = true;
            this.removeVehicle_button.Click += new System.EventHandler(this.RemoveVehicle_button_Click);
            // 
            // refreshList_button
            // 
            this.refreshList_button.Location = new System.Drawing.Point(276, 3);
            this.refreshList_button.Name = "refreshList_button";
            this.refreshList_button.Size = new System.Drawing.Size(85, 51);
            this.refreshList_button.TabIndex = 3;
            this.refreshList_button.Text = "Refresh list";
            this.refreshList_button.UseVisualStyleBackColor = true;
            this.refreshList_button.Click += new System.EventHandler(this.RefreshList_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Vehicles";
            // 
            // VehicleManagementControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vehicle_ListView);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "VehicleManagementControl";
            this.Size = new System.Drawing.Size(569, 386);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView vehicle_ListView;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ColumnHeader vehicleID;
        private System.Windows.Forms.ColumnHeader vehicleType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addVehicle_button;
        private System.Windows.Forms.Button editVehicle_button;
        private System.Windows.Forms.Button removeVehicle_button;
        private System.Windows.Forms.Button refreshList_button;
    }
}
