namespace ParcelDeliveryCompany_ClassLibrary1
{
    partial class VehicleAddEditForm
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
            this.vehicleBrandName_textbox = new System.Windows.Forms.TextBox();
            this.vehicleTypes_listbox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.vehicleModelName_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.vehicleRegistrationPlate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.new_vehicle_type_checkBox = new System.Windows.Forms.CheckBox();
            this.new_vehicle_type_textBox = new System.Windows.Forms.TextBox();
            this.vehicleTypes_listView = new System.Windows.Forms.ListView();
            this.veh_type_id_col = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.veh_type_name_col = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // accept_button
            // 
            this.accept_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.accept_button.Location = new System.Drawing.Point(12, 382);
            this.accept_button.Name = "accept_button";
            this.accept_button.Size = new System.Drawing.Size(75, 23);
            this.accept_button.TabIndex = 0;
            this.accept_button.Text = "Add vehicle";
            this.accept_button.UseVisualStyleBackColor = true;
            this.accept_button.Click += new System.EventHandler(this.Accept_button_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cancel_button.Location = new System.Drawing.Point(93, 382);
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
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Vehicle\'s brand name";
            // 
            // vehicleBrandName_textbox
            // 
            this.vehicleBrandName_textbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vehicleBrandName_textbox.Location = new System.Drawing.Point(12, 29);
            this.vehicleBrandName_textbox.MaxLength = 50;
            this.vehicleBrandName_textbox.Name = "vehicleBrandName_textbox";
            this.vehicleBrandName_textbox.Size = new System.Drawing.Size(321, 20);
            this.vehicleBrandName_textbox.TabIndex = 3;
            // 
            // vehicleTypes_listbox
            // 
            this.vehicleTypes_listbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vehicleTypes_listbox.FormattingEnabled = true;
            this.vehicleTypes_listbox.Location = new System.Drawing.Point(12, 171);
            this.vehicleTypes_listbox.Name = "vehicleTypes_listbox";
            this.vehicleTypes_listbox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.vehicleTypes_listbox.Size = new System.Drawing.Size(321, 199);
            this.vehicleTypes_listbox.TabIndex = 4;
            this.vehicleTypes_listbox.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(9, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Vehicle type";
            // 
            // vehicleModelName_textBox
            // 
            this.vehicleModelName_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vehicleModelName_textBox.Location = new System.Drawing.Point(12, 72);
            this.vehicleModelName_textBox.MaxLength = 50;
            this.vehicleModelName_textBox.Name = "vehicleModelName_textBox";
            this.vehicleModelName_textBox.Size = new System.Drawing.Size(321, 20);
            this.vehicleModelName_textBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(9, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Vehicle\'s model";
            // 
            // vehicleRegistrationPlate
            // 
            this.vehicleRegistrationPlate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vehicleRegistrationPlate.Location = new System.Drawing.Point(12, 115);
            this.vehicleRegistrationPlate.MaxLength = 50;
            this.vehicleRegistrationPlate.Name = "vehicleRegistrationPlate";
            this.vehicleRegistrationPlate.Size = new System.Drawing.Size(321, 20);
            this.vehicleRegistrationPlate.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(9, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Vehicle\'s registration plate";
            // 
            // new_vehicle_type_checkBox
            // 
            this.new_vehicle_type_checkBox.AutoSize = true;
            this.new_vehicle_type_checkBox.Location = new System.Drawing.Point(101, 148);
            this.new_vehicle_type_checkBox.Name = "new_vehicle_type_checkBox";
            this.new_vehicle_type_checkBox.Size = new System.Drawing.Size(128, 17);
            this.new_vehicle_type_checkBox.TabIndex = 10;
            this.new_vehicle_type_checkBox.Text = "Add new vehicle type";
            this.new_vehicle_type_checkBox.UseVisualStyleBackColor = true;
            this.new_vehicle_type_checkBox.CheckedChanged += new System.EventHandler(this.New_vehicle_type_checkBox_CheckedChanged);
            // 
            // new_vehicle_type_textBox
            // 
            this.new_vehicle_type_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.new_vehicle_type_textBox.Location = new System.Drawing.Point(12, 172);
            this.new_vehicle_type_textBox.Name = "new_vehicle_type_textBox";
            this.new_vehicle_type_textBox.Size = new System.Drawing.Size(321, 20);
            this.new_vehicle_type_textBox.TabIndex = 11;
            this.new_vehicle_type_textBox.Visible = false;
            // 
            // vehicleTypes_listView
            // 
            this.vehicleTypes_listView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vehicleTypes_listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.veh_type_id_col,
            this.veh_type_name_col});
            this.vehicleTypes_listView.FullRowSelect = true;
            this.vehicleTypes_listView.HideSelection = false;
            this.vehicleTypes_listView.Location = new System.Drawing.Point(12, 172);
            this.vehicleTypes_listView.MultiSelect = false;
            this.vehicleTypes_listView.Name = "vehicleTypes_listView";
            this.vehicleTypes_listView.Size = new System.Drawing.Size(321, 198);
            this.vehicleTypes_listView.TabIndex = 12;
            this.vehicleTypes_listView.UseCompatibleStateImageBehavior = false;
            this.vehicleTypes_listView.View = System.Windows.Forms.View.Details;
            // 
            // veh_type_id_col
            // 
            this.veh_type_id_col.Text = "ID";
            this.veh_type_id_col.Width = 45;
            // 
            // veh_type_name_col
            // 
            this.veh_type_name_col.Text = "Name";
            this.veh_type_name_col.Width = 134;
            // 
            // VehicleAddEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 417);
            this.ControlBox = false;
            this.Controls.Add(this.new_vehicle_type_textBox);
            this.Controls.Add(this.vehicleTypes_listView);
            this.Controls.Add(this.new_vehicle_type_checkBox);
            this.Controls.Add(this.vehicleRegistrationPlate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.vehicleModelName_textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.vehicleTypes_listbox);
            this.Controls.Add(this.vehicleBrandName_textbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.accept_button);
            this.Name = "VehicleAddEditForm";
            this.Text = "Add vehicle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button accept_button;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox vehicleBrandName_textbox;
        private System.Windows.Forms.ListBox vehicleTypes_listbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox vehicleModelName_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox vehicleRegistrationPlate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox new_vehicle_type_checkBox;
        private System.Windows.Forms.TextBox new_vehicle_type_textBox;
        private System.Windows.Forms.ListView vehicleTypes_listView;
        private System.Windows.Forms.ColumnHeader veh_type_id_col;
        private System.Windows.Forms.ColumnHeader veh_type_name_col;
    }
}