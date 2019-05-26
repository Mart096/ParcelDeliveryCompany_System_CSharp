namespace ParcelDeliveryCompany_ClassLibrary1
{
    partial class LocationAddEditForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.street_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cancel_button = new System.Windows.Forms.Button();
            this.accept_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.postCode_textBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.houseNumber_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.new_location_type_CheckBox = new System.Windows.Forms.CheckBox();
            this.new_location_type_textBox = new System.Windows.Forms.TextBox();
            this.city_listView = new System.Windows.Forms.ListView();
            this.city_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.city_name_col = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.city_area_col = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.location_type_listView = new System.Windows.Forms.ListView();
            this.location_type_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.location_type_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.houseNumber_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Location type";
            // 
            // street_textbox
            // 
            this.street_textbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.street_textbox.Location = new System.Drawing.Point(12, 212);
            this.street_textbox.MaxLength = 50;
            this.street_textbox.Name = "street_textbox";
            this.street_textbox.Size = new System.Drawing.Size(266, 20);
            this.street_textbox.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(9, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Street name";
            // 
            // cancel_button
            // 
            this.cancel_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cancel_button.Location = new System.Drawing.Point(112, 369);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(82, 36);
            this.cancel_button.TabIndex = 19;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.Cancel_button_Click);
            // 
            // accept_button
            // 
            this.accept_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.accept_button.Location = new System.Drawing.Point(12, 369);
            this.accept_button.Name = "accept_button";
            this.accept_button.Size = new System.Drawing.Size(94, 36);
            this.accept_button.TabIndex = 18;
            this.accept_button.Text = "Add new location";
            this.accept_button.UseVisualStyleBackColor = true;
            this.accept_button.Click += new System.EventHandler(this.Accept_button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(247, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "City";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(9, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "House number";
            // 
            // postCode_textBox
            // 
            this.postCode_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.postCode_textBox.Location = new System.Drawing.Point(12, 325);
            this.postCode_textBox.MaxLength = 50;
            this.postCode_textBox.Name = "postCode_textBox";
            this.postCode_textBox.Size = new System.Drawing.Size(266, 20);
            this.postCode_textBox.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(9, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Post code";
            // 
            // houseNumber_numericUpDown
            // 
            this.houseNumber_numericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.houseNumber_numericUpDown.Location = new System.Drawing.Point(12, 265);
            this.houseNumber_numericUpDown.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.houseNumber_numericUpDown.Name = "houseNumber_numericUpDown";
            this.houseNumber_numericUpDown.Size = new System.Drawing.Size(266, 20);
            this.houseNumber_numericUpDown.TabIndex = 16;
            // 
            // new_location_type_CheckBox
            // 
            this.new_location_type_CheckBox.AutoSize = true;
            this.new_location_type_CheckBox.Location = new System.Drawing.Point(110, 10);
            this.new_location_type_CheckBox.Name = "new_location_type_CheckBox";
            this.new_location_type_CheckBox.Size = new System.Drawing.Size(108, 17);
            this.new_location_type_CheckBox.TabIndex = 20;
            this.new_location_type_CheckBox.Text = "Add location type";
            this.new_location_type_CheckBox.UseVisualStyleBackColor = true;
            this.new_location_type_CheckBox.CheckedChanged += new System.EventHandler(this.New_location_type_CheckBox_CheckedChanged);
            // 
            // new_location_type_textBox
            // 
            this.new_location_type_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.new_location_type_textBox.Location = new System.Drawing.Point(12, 33);
            this.new_location_type_textBox.Name = "new_location_type_textBox";
            this.new_location_type_textBox.Size = new System.Drawing.Size(216, 20);
            this.new_location_type_textBox.TabIndex = 21;
            this.new_location_type_textBox.Visible = false;
            // 
            // city_listView
            // 
            this.city_listView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.city_listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.city_id,
            this.city_name_col,
            this.city_area_col});
            this.city_listView.FullRowSelect = true;
            this.city_listView.HideSelection = false;
            this.city_listView.Location = new System.Drawing.Point(250, 29);
            this.city_listView.MultiSelect = false;
            this.city_listView.Name = "city_listView";
            this.city_listView.Size = new System.Drawing.Size(216, 147);
            this.city_listView.TabIndex = 22;
            this.city_listView.UseCompatibleStateImageBehavior = false;
            this.city_listView.View = System.Windows.Forms.View.Details;
            // 
            // city_id
            // 
            this.city_id.Text = "ID";
            this.city_id.Width = 39;
            // 
            // city_name_col
            // 
            this.city_name_col.Text = "Name";
            this.city_name_col.Width = 86;
            // 
            // city_area_col
            // 
            this.city_area_col.Text = "Area";
            this.city_area_col.Width = 74;
            // 
            // location_type_listView
            // 
            this.location_type_listView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.location_type_listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.location_type_id,
            this.location_type_name});
            this.location_type_listView.FullRowSelect = true;
            this.location_type_listView.HideSelection = false;
            this.location_type_listView.Location = new System.Drawing.Point(12, 29);
            this.location_type_listView.MultiSelect = false;
            this.location_type_listView.Name = "location_type_listView";
            this.location_type_listView.Size = new System.Drawing.Size(216, 147);
            this.location_type_listView.TabIndex = 23;
            this.location_type_listView.UseCompatibleStateImageBehavior = false;
            this.location_type_listView.View = System.Windows.Forms.View.Details;
            // 
            // location_type_id
            // 
            this.location_type_id.Text = "ID";
            this.location_type_id.Width = 39;
            // 
            // location_type_name
            // 
            this.location_type_name.Text = "Location type";
            this.location_type_name.Width = 86;
            // 
            // LocationAddEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 417);
            this.ControlBox = false;
            this.Controls.Add(this.city_listView);
            this.Controls.Add(this.new_location_type_textBox);
            this.Controls.Add(this.location_type_listView);
            this.Controls.Add(this.new_location_type_CheckBox);
            this.Controls.Add(this.houseNumber_numericUpDown);
            this.Controls.Add(this.postCode_textBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.street_textbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.accept_button);
            this.MinimumSize = new System.Drawing.Size(494, 456);
            this.Name = "LocationAddEditForm";
            this.Text = "Add new location";
            ((System.ComponentModel.ISupportInitialize)(this.houseNumber_numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox street_textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Button accept_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox postCode_textBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown houseNumber_numericUpDown;
        private System.Windows.Forms.CheckBox new_location_type_CheckBox;
        private System.Windows.Forms.TextBox new_location_type_textBox;
        private System.Windows.Forms.ListView city_listView;
        private System.Windows.Forms.ColumnHeader city_id;
        private System.Windows.Forms.ColumnHeader city_name_col;
        private System.Windows.Forms.ColumnHeader city_area_col;
        private System.Windows.Forms.ListView location_type_listView;
        private System.Windows.Forms.ColumnHeader location_type_id;
        private System.Windows.Forms.ColumnHeader location_type_name;
    }
}