namespace TestSQLServerProject01
{
    partial class CourierAddEditForm
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
            this.accept_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.firstName_textBox = new System.Windows.Forms.TextBox();
            this.lastName_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nationalIdNumber_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.birthDate_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.vehicle_ListView = new System.Windows.Forms.ListView();
            this.vehicleID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.vehicleType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.vehicleBrand = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.vehicleModel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.vehicleRegistryPlate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // accept_button
            // 
            this.accept_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.accept_button.Location = new System.Drawing.Point(13, 203);
            this.accept_button.Name = "accept_button";
            this.accept_button.Size = new System.Drawing.Size(75, 23);
            this.accept_button.TabIndex = 0;
            this.accept_button.Text = "Add new";
            this.accept_button.UseVisualStyleBackColor = true;
            this.accept_button.Click += new System.EventHandler(this.Accept_button_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cancel_button.Location = new System.Drawing.Point(94, 203);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(75, 23);
            this.cancel_button.TabIndex = 1;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.Cancel_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "First name";
            // 
            // firstName_textBox
            // 
            this.firstName_textBox.Location = new System.Drawing.Point(12, 29);
            this.firstName_textBox.Name = "firstName_textBox";
            this.firstName_textBox.Size = new System.Drawing.Size(198, 20);
            this.firstName_textBox.TabIndex = 3;
            // 
            // lastName_textBox
            // 
            this.lastName_textBox.Location = new System.Drawing.Point(12, 72);
            this.lastName_textBox.Name = "lastName_textBox";
            this.lastName_textBox.Size = new System.Drawing.Size(198, 20);
            this.lastName_textBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(10, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Last name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(10, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Birth date";
            // 
            // nationalIdNumber_textBox
            // 
            this.nationalIdNumber_textBox.Location = new System.Drawing.Point(12, 161);
            this.nationalIdNumber_textBox.Name = "nationalIdNumber_textBox";
            this.nationalIdNumber_textBox.Size = new System.Drawing.Size(198, 20);
            this.nationalIdNumber_textBox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(10, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "National Identification Number";
            // 
            // birthDate_dateTimePicker
            // 
            this.birthDate_dateTimePicker.CustomFormat = "yyyy-MM-dd";
            this.birthDate_dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.birthDate_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.birthDate_dateTimePicker.Location = new System.Drawing.Point(13, 115);
            this.birthDate_dateTimePicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.birthDate_dateTimePicker.Name = "birthDate_dateTimePicker";
            this.birthDate_dateTimePicker.Size = new System.Drawing.Size(119, 23);
            this.birthDate_dateTimePicker.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(256, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Vehicle";
            // 
            // vehicle_ListView
            // 
            this.vehicle_ListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vehicle_ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.vehicleID,
            this.vehicleType,
            this.vehicleBrand,
            this.vehicleModel,
            this.vehicleRegistryPlate});
            this.vehicle_ListView.FullRowSelect = true;
            this.vehicle_ListView.Location = new System.Drawing.Point(259, 29);
            this.vehicle_ListView.MultiSelect = false;
            this.vehicle_ListView.Name = "vehicle_ListView";
            this.vehicle_ListView.Size = new System.Drawing.Size(275, 197);
            this.vehicle_ListView.TabIndex = 13;
            this.vehicle_ListView.UseCompatibleStateImageBehavior = false;
            this.vehicle_ListView.View = System.Windows.Forms.View.Details;
            this.vehicle_ListView.SelectedIndexChanged += new System.EventHandler(this.vehicle_ListView_SelectedIndexChanged);
            // 
            // vehicleID
            // 
            this.vehicleID.Text = "ID";
            this.vehicleID.Width = 79;
            // 
            // vehicleType
            // 
            this.vehicleType.Text = "Vehicle type";
            this.vehicleType.Width = 88;
            // 
            // vehicleBrand
            // 
            this.vehicleBrand.Text = "Brand name";
            this.vehicleBrand.Width = 25;
            // 
            // vehicleModel
            // 
            this.vehicleModel.Text = "Model name";
            this.vehicleModel.Width = 75;
            // 
            // vehicleRegistryPlate
            // 
            this.vehicleRegistryPlate.Text = "Registry Plate";
            this.vehicleRegistryPlate.Width = 80;
            // 
            // CourierAddEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 261);
            this.ControlBox = false;
            this.Controls.Add(this.vehicle_ListView);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.birthDate_dateTimePicker);
            this.Controls.Add(this.nationalIdNumber_textBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lastName_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.firstName_textBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.accept_button);
            this.MinimumSize = new System.Drawing.Size(562, 277);
            this.Name = "CourierAddEditForm";
            this.Text = "CourierAddEditForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button accept_button;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox firstName_textBox;
        private System.Windows.Forms.TextBox lastName_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nationalIdNumber_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker birthDate_dateTimePicker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView vehicle_ListView;
        private System.Windows.Forms.ColumnHeader vehicleID;
        private System.Windows.Forms.ColumnHeader vehicleType;
        private System.Windows.Forms.ColumnHeader vehicleBrand;
        private System.Windows.Forms.ColumnHeader vehicleModel;
        private System.Windows.Forms.ColumnHeader vehicleRegistryPlate;
    }
}