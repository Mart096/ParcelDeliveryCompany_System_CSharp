namespace ParcelDeliveryCompanyApplication
{
    partial class DictionaryManagementControler
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
            this.dictionary_listView = new System.Windows.Forms.ListView();
            this.idColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.vehicleType_button = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.area__button = new System.Windows.Forms.Button();
            this.locationType__button = new System.Windows.Forms.Button();
            this.weightCategory_button = new System.Windows.Forms.Button();
            this.sizeCategory_button = new System.Windows.Forms.Button();
            this.properties_button = new System.Windows.Forms.Button();
            this.pickupState_button = new System.Windows.Forms.Button();
            this.pickupMethod_button = new System.Windows.Forms.Button();
            this.consignmentType_button = new System.Windows.Forms.Button();
            this.pickupRequestState_button = new System.Windows.Forms.Button();
            this.complaintReportState_button = new System.Windows.Forms.Button();
            this.currentSelection_label = new System.Windows.Forms.Label();
            this.addNewRecord_button = new System.Windows.Forms.Button();
            this.editRecord_button = new System.Windows.Forms.Button();
            this.refresh_button = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.clearFilter_button = new System.Windows.Forms.Button();
            this.search_button = new System.Windows.Forms.Button();
            this.search_textBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dictionaryColumns_listbox = new System.Windows.Forms.ListBox();
            this.city_button = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dictionary_listView
            // 
            this.dictionary_listView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dictionary_listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idColumn,
            this.nameColumn});
            this.dictionary_listView.Enabled = false;
            this.dictionary_listView.Location = new System.Drawing.Point(136, 85);
            this.dictionary_listView.Name = "dictionary_listView";
            this.dictionary_listView.Size = new System.Drawing.Size(331, 218);
            this.dictionary_listView.TabIndex = 0;
            this.dictionary_listView.UseCompatibleStateImageBehavior = false;
            this.dictionary_listView.View = System.Windows.Forms.View.Details;
            this.dictionary_listView.SelectedIndexChanged += new System.EventHandler(this.Dictionary_listView_SelectedIndexChanged);
            // 
            // idColumn
            // 
            this.idColumn.Text = "ID";
            this.idColumn.Width = 85;
            // 
            // nameColumn
            // 
            this.nameColumn.Text = "Name";
            this.nameColumn.Width = 242;
            // 
            // vehicleType_button
            // 
            this.vehicleType_button.Location = new System.Drawing.Point(3, 3);
            this.vehicleType_button.Name = "vehicleType_button";
            this.vehicleType_button.Size = new System.Drawing.Size(97, 38);
            this.vehicleType_button.TabIndex = 1;
            this.vehicleType_button.Text = "Vehicle type";
            this.vehicleType_button.UseVisualStyleBackColor = true;
            this.vehicleType_button.Click += new System.EventHandler(this.VehicleType_button_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.vehicleType_button);
            this.flowLayoutPanel1.Controls.Add(this.area__button);
            this.flowLayoutPanel1.Controls.Add(this.city_button);
            this.flowLayoutPanel1.Controls.Add(this.locationType__button);
            this.flowLayoutPanel1.Controls.Add(this.weightCategory_button);
            this.flowLayoutPanel1.Controls.Add(this.sizeCategory_button);
            this.flowLayoutPanel1.Controls.Add(this.properties_button);
            this.flowLayoutPanel1.Controls.Add(this.pickupState_button);
            this.flowLayoutPanel1.Controls.Add(this.pickupMethod_button);
            this.flowLayoutPanel1.Controls.Add(this.consignmentType_button);
            this.flowLayoutPanel1.Controls.Add(this.pickupRequestState_button);
            this.flowLayoutPanel1.Controls.Add(this.complaintReportState_button);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(127, 300);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // area__button
            // 
            this.area__button.Location = new System.Drawing.Point(3, 47);
            this.area__button.Name = "area__button";
            this.area__button.Size = new System.Drawing.Size(97, 38);
            this.area__button.TabIndex = 2;
            this.area__button.Text = "Area";
            this.area__button.UseVisualStyleBackColor = true;
            this.area__button.Click += new System.EventHandler(this.Area__button_Click);
            // 
            // locationType__button
            // 
            this.locationType__button.Location = new System.Drawing.Point(3, 135);
            this.locationType__button.Name = "locationType__button";
            this.locationType__button.Size = new System.Drawing.Size(97, 38);
            this.locationType__button.TabIndex = 3;
            this.locationType__button.Text = "Location type";
            this.locationType__button.UseVisualStyleBackColor = true;
            this.locationType__button.Click += new System.EventHandler(this.LocationType__button_Click);
            // 
            // weightCategory_button
            // 
            this.weightCategory_button.Location = new System.Drawing.Point(3, 179);
            this.weightCategory_button.Name = "weightCategory_button";
            this.weightCategory_button.Size = new System.Drawing.Size(97, 38);
            this.weightCategory_button.TabIndex = 4;
            this.weightCategory_button.Text = "Weight category";
            this.weightCategory_button.UseVisualStyleBackColor = true;
            this.weightCategory_button.Click += new System.EventHandler(this.WeightCategory_button_Click);
            // 
            // sizeCategory_button
            // 
            this.sizeCategory_button.Location = new System.Drawing.Point(3, 223);
            this.sizeCategory_button.Name = "sizeCategory_button";
            this.sizeCategory_button.Size = new System.Drawing.Size(97, 38);
            this.sizeCategory_button.TabIndex = 5;
            this.sizeCategory_button.Text = "Size category";
            this.sizeCategory_button.UseVisualStyleBackColor = true;
            this.sizeCategory_button.Click += new System.EventHandler(this.SizeCategory_button_Click);
            // 
            // properties_button
            // 
            this.properties_button.Location = new System.Drawing.Point(3, 267);
            this.properties_button.Name = "properties_button";
            this.properties_button.Size = new System.Drawing.Size(97, 38);
            this.properties_button.TabIndex = 6;
            this.properties_button.Text = "Properties";
            this.properties_button.UseVisualStyleBackColor = true;
            this.properties_button.Click += new System.EventHandler(this.Properties_button_Click);
            // 
            // pickupState_button
            // 
            this.pickupState_button.Location = new System.Drawing.Point(3, 311);
            this.pickupState_button.Name = "pickupState_button";
            this.pickupState_button.Size = new System.Drawing.Size(97, 38);
            this.pickupState_button.TabIndex = 7;
            this.pickupState_button.Text = "Pickup state";
            this.pickupState_button.UseVisualStyleBackColor = true;
            this.pickupState_button.Click += new System.EventHandler(this.PickupState_button_Click);
            // 
            // pickupMethod_button
            // 
            this.pickupMethod_button.Location = new System.Drawing.Point(3, 355);
            this.pickupMethod_button.Name = "pickupMethod_button";
            this.pickupMethod_button.Size = new System.Drawing.Size(97, 38);
            this.pickupMethod_button.TabIndex = 8;
            this.pickupMethod_button.Text = "Pickup method";
            this.pickupMethod_button.UseVisualStyleBackColor = true;
            this.pickupMethod_button.Click += new System.EventHandler(this.PickupMethod_button_Click);
            // 
            // consignmentType_button
            // 
            this.consignmentType_button.Location = new System.Drawing.Point(3, 399);
            this.consignmentType_button.Name = "consignmentType_button";
            this.consignmentType_button.Size = new System.Drawing.Size(97, 38);
            this.consignmentType_button.TabIndex = 9;
            this.consignmentType_button.Text = "Consignment type";
            this.consignmentType_button.UseVisualStyleBackColor = true;
            this.consignmentType_button.Click += new System.EventHandler(this.ConsignmentType_button_Click);
            // 
            // pickupRequestState_button
            // 
            this.pickupRequestState_button.Location = new System.Drawing.Point(3, 443);
            this.pickupRequestState_button.Name = "pickupRequestState_button";
            this.pickupRequestState_button.Size = new System.Drawing.Size(97, 38);
            this.pickupRequestState_button.TabIndex = 10;
            this.pickupRequestState_button.Text = "Pickup request state";
            this.pickupRequestState_button.UseVisualStyleBackColor = true;
            this.pickupRequestState_button.Click += new System.EventHandler(this.PickupRequestState_button_Click);
            // 
            // complaintReportState_button
            // 
            this.complaintReportState_button.Location = new System.Drawing.Point(3, 487);
            this.complaintReportState_button.Name = "complaintReportState_button";
            this.complaintReportState_button.Size = new System.Drawing.Size(97, 38);
            this.complaintReportState_button.TabIndex = 11;
            this.complaintReportState_button.Text = "Complaint report state";
            this.complaintReportState_button.UseVisualStyleBackColor = true;
            this.complaintReportState_button.Click += new System.EventHandler(this.ComplaintReportState_button_Click);
            // 
            // currentSelection_label
            // 
            this.currentSelection_label.AutoSize = true;
            this.currentSelection_label.Location = new System.Drawing.Point(136, 6);
            this.currentSelection_label.Name = "currentSelection_label";
            this.currentSelection_label.Size = new System.Drawing.Size(63, 13);
            this.currentSelection_label.TabIndex = 4;
            this.currentSelection_label.Text = "Unspecified";
            // 
            // addNewRecord_button
            // 
            this.addNewRecord_button.Enabled = false;
            this.addNewRecord_button.Location = new System.Drawing.Point(3, 3);
            this.addNewRecord_button.Name = "addNewRecord_button";
            this.addNewRecord_button.Size = new System.Drawing.Size(63, 46);
            this.addNewRecord_button.TabIndex = 5;
            this.addNewRecord_button.Text = "Add new record";
            this.addNewRecord_button.UseVisualStyleBackColor = true;
            this.addNewRecord_button.Click += new System.EventHandler(this.AddNewRecord_button_Click);
            // 
            // editRecord_button
            // 
            this.editRecord_button.Enabled = false;
            this.editRecord_button.Location = new System.Drawing.Point(72, 3);
            this.editRecord_button.Name = "editRecord_button";
            this.editRecord_button.Size = new System.Drawing.Size(86, 46);
            this.editRecord_button.TabIndex = 6;
            this.editRecord_button.Text = "Edit selected record";
            this.editRecord_button.UseVisualStyleBackColor = true;
            this.editRecord_button.Click += new System.EventHandler(this.EditRecord_button_Click);
            // 
            // refresh_button
            // 
            this.refresh_button.Enabled = false;
            this.refresh_button.Location = new System.Drawing.Point(164, 3);
            this.refresh_button.Name = "refresh_button";
            this.refresh_button.Size = new System.Drawing.Size(86, 46);
            this.refresh_button.TabIndex = 8;
            this.refresh_button.Text = "Refresh button";
            this.refresh_button.UseVisualStyleBackColor = true;
            this.refresh_button.Click += new System.EventHandler(this.Refresh_button_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.Controls.Add(this.addNewRecord_button);
            this.flowLayoutPanel2.Controls.Add(this.editRecord_button);
            this.flowLayoutPanel2.Controls.Add(this.refresh_button);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(136, 22);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(331, 57);
            this.flowLayoutPanel2.TabIndex = 9;
            this.flowLayoutPanel2.WrapContents = false;
            // 
            // clearFilter_button
            // 
            this.clearFilter_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clearFilter_button.Enabled = false;
            this.clearFilter_button.Location = new System.Drawing.Point(473, 280);
            this.clearFilter_button.Name = "clearFilter_button";
            this.clearFilter_button.Size = new System.Drawing.Size(102, 23);
            this.clearFilter_button.TabIndex = 16;
            this.clearFilter_button.Text = "Clear filter";
            this.clearFilter_button.UseVisualStyleBackColor = true;
            this.clearFilter_button.Click += new System.EventHandler(this.ClearFilter_button_Click);
            // 
            // search_button
            // 
            this.search_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.search_button.Enabled = false;
            this.search_button.Location = new System.Drawing.Point(473, 250);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(102, 23);
            this.search_button.TabIndex = 15;
            this.search_button.Text = "Search";
            this.search_button.UseVisualStyleBackColor = true;
            this.search_button.Click += new System.EventHandler(this.Search_button_Click);
            // 
            // search_textBox
            // 
            this.search_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.search_textBox.Location = new System.Drawing.Point(473, 98);
            this.search_textBox.Name = "search_textBox";
            this.search_textBox.Size = new System.Drawing.Size(104, 20);
            this.search_textBox.TabIndex = 14;
            this.search_textBox.TextChanged += new System.EventHandler(this.Search_textBox_TextChanged);
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(470, 81);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 13);
            this.label13.TabIndex = 13;
            this.label13.Text = "Search";
            // 
            // dictionaryColumns_listbox
            // 
            this.dictionaryColumns_listbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dictionaryColumns_listbox.FormattingEnabled = true;
            this.dictionaryColumns_listbox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dictionaryColumns_listbox.Items.AddRange(new object[] {
            "ID",
            "Name"});
            this.dictionaryColumns_listbox.Location = new System.Drawing.Point(473, 148);
            this.dictionaryColumns_listbox.Name = "dictionaryColumns_listbox";
            this.dictionaryColumns_listbox.Size = new System.Drawing.Size(104, 95);
            this.dictionaryColumns_listbox.TabIndex = 12;
            this.dictionaryColumns_listbox.SelectedIndexChanged += new System.EventHandler(this.DictionaryColumns_listbox_SelectedIndexChanged);
            // 
            // city_button
            // 
            this.city_button.Location = new System.Drawing.Point(3, 91);
            this.city_button.Name = "city_button";
            this.city_button.Size = new System.Drawing.Size(97, 38);
            this.city_button.TabIndex = 12;
            this.city_button.Text = "City";
            this.city_button.UseVisualStyleBackColor = true;
            this.city_button.Click += new System.EventHandler(this.City_button_Click);
            // 
            // DictionaryManagementControler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.clearFilter_button);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.search_textBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dictionaryColumns_listbox);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.currentSelection_label);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.dictionary_listView);
            this.Name = "DictionaryManagementControler";
            this.Size = new System.Drawing.Size(598, 306);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView dictionary_listView;
        private System.Windows.Forms.ColumnHeader idColumn;
        private System.Windows.Forms.ColumnHeader nameColumn;
        private System.Windows.Forms.Button vehicleType_button;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button area__button;
        private System.Windows.Forms.Button locationType__button;
        private System.Windows.Forms.Button weightCategory_button;
        private System.Windows.Forms.Button sizeCategory_button;
        private System.Windows.Forms.Button properties_button;
        private System.Windows.Forms.Button pickupState_button;
        private System.Windows.Forms.Button pickupMethod_button;
        private System.Windows.Forms.Button consignmentType_button;
        private System.Windows.Forms.Button pickupRequestState_button;
        private System.Windows.Forms.Button complaintReportState_button;
        private System.Windows.Forms.Label currentSelection_label;
        private System.Windows.Forms.Button addNewRecord_button;
        private System.Windows.Forms.Button editRecord_button;
        private System.Windows.Forms.Button refresh_button;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button clearFilter_button;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.TextBox search_textBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ListBox dictionaryColumns_listbox;
        private System.Windows.Forms.Button city_button;
    }
}
