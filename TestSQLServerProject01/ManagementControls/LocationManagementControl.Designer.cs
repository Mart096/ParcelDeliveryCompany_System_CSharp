namespace TestSQLServerProject01
{
    partial class LocationManagementControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.location_ListView = new System.Windows.Forms.ListView();
            this.locationID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.locationType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.streetName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.houseNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.postCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.addLocation_button = new System.Windows.Forms.Button();
            this.editLocation_button = new System.Windows.Forms.Button();
            this.removeLocation_button = new System.Windows.Forms.Button();
            this.refreshList_button = new System.Windows.Forms.Button();
            this.cityName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Locations";
            // 
            // location_ListView
            // 
            this.location_ListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.location_ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.locationID,
            this.locationType,
            this.cityName,
            this.streetName,
            this.houseNumber,
            this.postCode});
            this.location_ListView.FullRowSelect = true;
            this.location_ListView.HideSelection = false;
            this.location_ListView.Location = new System.Drawing.Point(6, 88);
            this.location_ListView.MultiSelect = false;
            this.location_ListView.Name = "location_ListView";
            this.location_ListView.Size = new System.Drawing.Size(560, 295);
            this.location_ListView.TabIndex = 4;
            this.location_ListView.UseCompatibleStateImageBehavior = false;
            this.location_ListView.View = System.Windows.Forms.View.Details;
            this.location_ListView.SelectedIndexChanged += new System.EventHandler(this.Location_ListView_SelectedIndexChanged);
            // 
            // locationID
            // 
            this.locationID.Text = "ID";
            this.locationID.Width = 79;
            // 
            // locationType
            // 
            this.locationType.Text = "Location type";
            this.locationType.Width = 144;
            // 
            // streetName
            // 
            this.streetName.Text = "Street";
            this.streetName.Width = 103;
            // 
            // houseNumber
            // 
            this.houseNumber.Text = "House number";
            this.houseNumber.Width = 92;
            // 
            // postCode
            // 
            this.postCode.Text = "Post code";
            this.postCode.Width = 136;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.addLocation_button);
            this.flowLayoutPanel1.Controls.Add(this.editLocation_button);
            this.flowLayoutPanel1.Controls.Add(this.removeLocation_button);
            this.flowLayoutPanel1.Controls.Add(this.refreshList_button);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 20);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(560, 62);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // addLocation_button
            // 
            this.addLocation_button.Location = new System.Drawing.Point(3, 3);
            this.addLocation_button.Name = "addLocation_button";
            this.addLocation_button.Size = new System.Drawing.Size(85, 51);
            this.addLocation_button.TabIndex = 0;
            this.addLocation_button.Text = "Add location";
            this.addLocation_button.UseVisualStyleBackColor = true;
            this.addLocation_button.Click += new System.EventHandler(this.AddLocation_button_Click);
            // 
            // editLocation_button
            // 
            this.editLocation_button.Enabled = false;
            this.editLocation_button.Location = new System.Drawing.Point(94, 3);
            this.editLocation_button.Name = "editLocation_button";
            this.editLocation_button.Size = new System.Drawing.Size(85, 51);
            this.editLocation_button.TabIndex = 1;
            this.editLocation_button.Text = "Edit location";
            this.editLocation_button.UseVisualStyleBackColor = true;
            this.editLocation_button.Click += new System.EventHandler(this.EditLocation_button_Click);
            // 
            // removeLocation_button
            // 
            this.removeLocation_button.Enabled = false;
            this.removeLocation_button.Location = new System.Drawing.Point(185, 3);
            this.removeLocation_button.Name = "removeLocation_button";
            this.removeLocation_button.Size = new System.Drawing.Size(85, 51);
            this.removeLocation_button.TabIndex = 2;
            this.removeLocation_button.Text = "Remove location";
            this.removeLocation_button.UseVisualStyleBackColor = true;
            this.removeLocation_button.Click += new System.EventHandler(this.RemoveLocation_button_Click);
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
            // cityName
            // 
            this.cityName.Text = "City";
            // 
            // LocationManagementControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.location_ListView);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "LocationManagementControl";
            this.Size = new System.Drawing.Size(575, 389);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader locationID;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button addLocation_button;
        private System.Windows.Forms.Button editLocation_button;
        private System.Windows.Forms.Button removeLocation_button;
        private System.Windows.Forms.Button refreshList_button;
        private System.Windows.Forms.ColumnHeader locationType;
        private System.Windows.Forms.ColumnHeader streetName;
        private System.Windows.Forms.ColumnHeader houseNumber;
        private System.Windows.Forms.ColumnHeader postCode;
        private System.Windows.Forms.ColumnHeader cityName;
        protected System.Windows.Forms.ListView location_ListView;
    }
}
