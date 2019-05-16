namespace ParcelDeliveryCompany_ClassLibrary1
{
    partial class CustomerAddEditControler
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
            this.newCustomer_panel = new System.Windows.Forms.Panel();
            this.apartmentNum_numeric = new System.Windows.Forms.NumericUpDown();
            this.phoneNumber_textBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.city_listView = new System.Windows.Forms.ListView();
            this.city_name_column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.area_name_column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.newCityArea_label = new System.Windows.Forms.Label();
            this.newCityArea_listBox = new System.Windows.Forms.ListBox();
            this.newCityName_textBox = new System.Windows.Forms.TextBox();
            this.newCityName_label = new System.Windows.Forms.Label();
            this.newCity_checkbox = new System.Windows.Forms.CheckBox();
            this.city_listBox = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.postalCode_textbox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.houseNumber_textBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.street_TextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lastName_textBox = new System.Windows.Forms.TextBox();
            this.firstName_textBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.newCustomer_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.apartmentNum_numeric)).BeginInit();
            this.SuspendLayout();
            // 
            // newCustomer_panel
            // 
            this.newCustomer_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newCustomer_panel.AutoScroll = true;
            this.newCustomer_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newCustomer_panel.Controls.Add(this.apartmentNum_numeric);
            this.newCustomer_panel.Controls.Add(this.phoneNumber_textBox);
            this.newCustomer_panel.Controls.Add(this.label14);
            this.newCustomer_panel.Controls.Add(this.city_listView);
            this.newCustomer_panel.Controls.Add(this.newCityArea_label);
            this.newCustomer_panel.Controls.Add(this.newCityArea_listBox);
            this.newCustomer_panel.Controls.Add(this.newCityName_textBox);
            this.newCustomer_panel.Controls.Add(this.newCityName_label);
            this.newCustomer_panel.Controls.Add(this.newCity_checkbox);
            this.newCustomer_panel.Controls.Add(this.city_listBox);
            this.newCustomer_panel.Controls.Add(this.label9);
            this.newCustomer_panel.Controls.Add(this.postalCode_textbox);
            this.newCustomer_panel.Controls.Add(this.label8);
            this.newCustomer_panel.Controls.Add(this.label7);
            this.newCustomer_panel.Controls.Add(this.houseNumber_textBox);
            this.newCustomer_panel.Controls.Add(this.label6);
            this.newCustomer_panel.Controls.Add(this.street_TextBox);
            this.newCustomer_panel.Controls.Add(this.label5);
            this.newCustomer_panel.Controls.Add(this.lastName_textBox);
            this.newCustomer_panel.Controls.Add(this.firstName_textBox);
            this.newCustomer_panel.Controls.Add(this.label10);
            this.newCustomer_panel.Controls.Add(this.label11);
            this.newCustomer_panel.Location = new System.Drawing.Point(3, 3);
            this.newCustomer_panel.Name = "newCustomer_panel";
            this.newCustomer_panel.Size = new System.Drawing.Size(523, 367);
            this.newCustomer_panel.TabIndex = 13;
            // 
            // apartmentNum_numeric
            // 
            this.apartmentNum_numeric.Location = new System.Drawing.Point(113, 161);
            this.apartmentNum_numeric.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.apartmentNum_numeric.Name = "apartmentNum_numeric";
            this.apartmentNum_numeric.Size = new System.Drawing.Size(122, 20);
            this.apartmentNum_numeric.TabIndex = 14;
            // 
            // phoneNumber_textBox
            // 
            this.phoneNumber_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.phoneNumber_textBox.Location = new System.Drawing.Point(6, 204);
            this.phoneNumber_textBox.Name = "phoneNumber_textBox";
            this.phoneNumber_textBox.Size = new System.Drawing.Size(158, 20);
            this.phoneNumber_textBox.TabIndex = 16;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label14.Location = new System.Drawing.Point(3, 184);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(101, 17);
            this.label14.TabIndex = 28;
            this.label14.Text = "Phone number";
            // 
            // city_listView
            // 
            this.city_listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.city_name_column,
            this.area_name_column});
            this.city_listView.FullRowSelect = true;
            this.city_listView.HideSelection = false;
            this.city_listView.Location = new System.Drawing.Point(3, 251);
            this.city_listView.MultiSelect = false;
            this.city_listView.Name = "city_listView";
            this.city_listView.Size = new System.Drawing.Size(163, 175);
            this.city_listView.TabIndex = 17;
            this.city_listView.UseCompatibleStateImageBehavior = false;
            this.city_listView.View = System.Windows.Forms.View.Details;
            // 
            // city_name_column
            // 
            this.city_name_column.Text = "City";
            // 
            // area_name_column
            // 
            this.area_name_column.Text = "Area";
            // 
            // newCityArea_label
            // 
            this.newCityArea_label.AutoSize = true;
            this.newCityArea_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.newCityArea_label.Location = new System.Drawing.Point(182, 283);
            this.newCityArea_label.Name = "newCityArea_label";
            this.newCityArea_label.Size = new System.Drawing.Size(103, 17);
            this.newCityArea_label.TabIndex = 24;
            this.newCityArea_label.Text = "New city\'s area";
            this.newCityArea_label.Visible = false;
            // 
            // newCityArea_listBox
            // 
            this.newCityArea_listBox.Enabled = false;
            this.newCityArea_listBox.FormattingEnabled = true;
            this.newCityArea_listBox.Location = new System.Drawing.Point(185, 303);
            this.newCityArea_listBox.Name = "newCityArea_listBox";
            this.newCityArea_listBox.Size = new System.Drawing.Size(163, 121);
            this.newCityArea_listBox.TabIndex = 19;
            this.newCityArea_listBox.Visible = false;
            // 
            // newCityName_textBox
            // 
            this.newCityName_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newCityName_textBox.Enabled = false;
            this.newCityName_textBox.Location = new System.Drawing.Point(185, 252);
            this.newCityName_textBox.Name = "newCityName_textBox";
            this.newCityName_textBox.Size = new System.Drawing.Size(191, 20);
            this.newCityName_textBox.TabIndex = 18;
            this.newCityName_textBox.Visible = false;
            // 
            // newCityName_label
            // 
            this.newCityName_label.AutoSize = true;
            this.newCityName_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.newCityName_label.Location = new System.Drawing.Point(182, 232);
            this.newCityName_label.Name = "newCityName_label";
            this.newCityName_label.Size = new System.Drawing.Size(70, 17);
            this.newCityName_label.TabIndex = 21;
            this.newCityName_label.Text = "City name";
            this.newCityName_label.Visible = false;
            // 
            // newCity_checkbox
            // 
            this.newCity_checkbox.AutoSize = true;
            this.newCity_checkbox.Location = new System.Drawing.Point(79, 232);
            this.newCity_checkbox.Name = "newCity_checkbox";
            this.newCity_checkbox.Size = new System.Drawing.Size(87, 17);
            this.newCity_checkbox.TabIndex = 20;
            this.newCity_checkbox.Text = "Add new city";
            this.newCity_checkbox.UseVisualStyleBackColor = true;
            this.newCity_checkbox.CheckedChanged += new System.EventHandler(this.NewCity_checkbox_CheckedChanged);
            // 
            // city_listBox
            // 
            this.city_listBox.FormattingEnabled = true;
            this.city_listBox.Location = new System.Drawing.Point(3, 252);
            this.city_listBox.Name = "city_listBox";
            this.city_listBox.Size = new System.Drawing.Size(163, 160);
            this.city_listBox.TabIndex = 19;
            this.city_listBox.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(3, 231);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "City";
            // 
            // postalCode_textbox
            // 
            this.postalCode_textbox.Location = new System.Drawing.Point(255, 161);
            this.postalCode_textbox.Name = "postalCode_textbox";
            this.postalCode_textbox.Size = new System.Drawing.Size(142, 20);
            this.postalCode_textbox.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(252, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Postal code";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(110, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Apartment number";
            // 
            // houseNumber_textBox
            // 
            this.houseNumber_textBox.Location = new System.Drawing.Point(6, 161);
            this.houseNumber_textBox.Name = "houseNumber_textBox";
            this.houseNumber_textBox.Size = new System.Drawing.Size(100, 20);
            this.houseNumber_textBox.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(3, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "House number";
            // 
            // street_TextBox
            // 
            this.street_TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.street_TextBox.Location = new System.Drawing.Point(6, 118);
            this.street_TextBox.Name = "street_TextBox";
            this.street_TextBox.Size = new System.Drawing.Size(391, 20);
            this.street_TextBox.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(3, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Street";
            // 
            // lastName_textBox
            // 
            this.lastName_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lastName_textBox.Location = new System.Drawing.Point(6, 75);
            this.lastName_textBox.Name = "lastName_textBox";
            this.lastName_textBox.Size = new System.Drawing.Size(391, 20);
            this.lastName_textBox.TabIndex = 9;
            // 
            // firstName_textBox
            // 
            this.firstName_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.firstName_textBox.Location = new System.Drawing.Point(6, 32);
            this.firstName_textBox.Name = "firstName_textBox";
            this.firstName_textBox.Size = new System.Drawing.Size(391, 20);
            this.firstName_textBox.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(3, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 17);
            this.label10.TabIndex = 7;
            this.label10.Text = "Last name";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(3, 11);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 17);
            this.label11.TabIndex = 6;
            this.label11.Text = "First name";
            // 
            // CustomerAddEditControler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.newCustomer_panel);
            this.Name = "CustomerAddEditControler";
            this.Size = new System.Drawing.Size(529, 373);
            this.newCustomer_panel.ResumeLayout(false);
            this.newCustomer_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.apartmentNum_numeric)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel newCustomer_panel;
        private System.Windows.Forms.NumericUpDown apartmentNum_numeric;
        private System.Windows.Forms.TextBox phoneNumber_textBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ColumnHeader city_name_column;
        private System.Windows.Forms.ColumnHeader area_name_column;
        private System.Windows.Forms.Label newCityArea_label;
        private System.Windows.Forms.ListBox newCityArea_listBox;
        private System.Windows.Forms.TextBox newCityName_textBox;
        private System.Windows.Forms.Label newCityName_label;
        private System.Windows.Forms.CheckBox newCity_checkbox;
        private System.Windows.Forms.ListBox city_listBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox postalCode_textbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox houseNumber_textBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox street_TextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox lastName_textBox;
        private System.Windows.Forms.TextBox firstName_textBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        internal System.Windows.Forms.ListView city_listView;
    }
}
