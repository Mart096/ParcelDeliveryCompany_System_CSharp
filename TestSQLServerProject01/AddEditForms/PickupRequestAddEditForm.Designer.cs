namespace ParcelDeliveryCompanyApplication
{
    partial class PickupRequestAddEditForm
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
            this.cancel_button = new System.Windows.Forms.Button();
            this.accept_button = new System.Windows.Forms.Button();
            this.courier_ListView = new System.Windows.Forms.ListView();
            this.id_column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.couriers_Vehicle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.courier_FirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.courier_LastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.orders_ListView = new System.Windows.Forms.ListView();
            this.id_ColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.courierHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sender_idHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.senderHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancel_button
            // 
            this.cancel_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cancel_button.Location = new System.Drawing.Point(112, 330);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(82, 36);
            this.cancel_button.TabIndex = 21;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.Cancel_button_Click);
            // 
            // accept_button
            // 
            this.accept_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.accept_button.Location = new System.Drawing.Point(12, 330);
            this.accept_button.Name = "accept_button";
            this.accept_button.Size = new System.Drawing.Size(94, 36);
            this.accept_button.TabIndex = 20;
            this.accept_button.Text = "Add new pickup request";
            this.accept_button.UseVisualStyleBackColor = true;
            this.accept_button.Click += new System.EventHandler(this.Accept_button_Click);
            // 
            // courier_ListView
            // 
            this.courier_ListView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.courier_ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id_column,
            this.couriers_Vehicle,
            this.courier_FirstName,
            this.courier_LastName});
            this.courier_ListView.FullRowSelect = true;
            this.courier_ListView.HideSelection = false;
            this.courier_ListView.Location = new System.Drawing.Point(464, 29);
            this.courier_ListView.MultiSelect = false;
            this.courier_ListView.Name = "courier_ListView";
            this.courier_ListView.Size = new System.Drawing.Size(324, 256);
            this.courier_ListView.TabIndex = 22;
            this.courier_ListView.UseCompatibleStateImageBehavior = false;
            this.courier_ListView.View = System.Windows.Forms.View.Details;
            // 
            // id_column
            // 
            this.id_column.Text = "ID";
            this.id_column.Width = 40;
            // 
            // couriers_Vehicle
            // 
            this.couriers_Vehicle.Text = "Vehicle ID";
            this.couriers_Vehicle.Width = 62;
            // 
            // courier_FirstName
            // 
            this.courier_FirstName.Text = "First name";
            this.courier_FirstName.Width = 86;
            // 
            // courier_LastName
            // 
            this.courier_LastName.Text = "Last name";
            this.courier_LastName.Width = 112;
            // 
            // orders_ListView
            // 
            this.orders_ListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.orders_ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id_ColumnHeader,
            this.courierHeader,
            this.sender_idHeader,
            this.senderHeader});
            this.orders_ListView.FullRowSelect = true;
            this.orders_ListView.HideSelection = false;
            this.orders_ListView.Location = new System.Drawing.Point(12, 29);
            this.orders_ListView.MultiSelect = false;
            this.orders_ListView.Name = "orders_ListView";
            this.orders_ListView.Size = new System.Drawing.Size(439, 256);
            this.orders_ListView.TabIndex = 24;
            this.orders_ListView.UseCompatibleStateImageBehavior = false;
            this.orders_ListView.View = System.Windows.Forms.View.Details;
            // 
            // id_ColumnHeader
            // 
            this.id_ColumnHeader.Text = "ID";
            // 
            // courierHeader
            // 
            this.courierHeader.Text = "Assigned Courier ID";
            this.courierHeader.Width = 107;
            // 
            // sender_idHeader
            // 
            this.sender_idHeader.Text = "Sender ID";
            this.sender_idHeader.Width = 87;
            // 
            // senderHeader
            // 
            this.senderHeader.Text = "Sender";
            this.senderHeader.Width = 130;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(461, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "Courier";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 25;
            this.label2.Text = "Order";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dateTimePicker1.CustomFormat = "dd-MM-yyyy, hh:mm:ss";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(179, 298);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(208, 20);
            this.dateTimePicker1.TabIndex = 26;
            this.dateTimePicker1.Value = new System.DateTime(2019, 3, 20, 12, 4, 20, 0);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(9, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 17);
            this.label3.TabIndex = 27;
            this.label3.Text = "Pickup request date time";
            // 
            // PickupRequestAddEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 378);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.orders_ListView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.courier_ListView);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.accept_button);
            this.Name = "PickupRequestAddEditForm";
            this.Text = "Add new pickup request";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Button accept_button;
        private System.Windows.Forms.ListView courier_ListView;
        private System.Windows.Forms.ColumnHeader id_column;
        private System.Windows.Forms.ColumnHeader couriers_Vehicle;
        private System.Windows.Forms.ColumnHeader courier_FirstName;
        private System.Windows.Forms.ColumnHeader courier_LastName;
        private System.Windows.Forms.ListView orders_ListView;
        private System.Windows.Forms.ColumnHeader id_ColumnHeader;
        private System.Windows.Forms.ColumnHeader courierHeader;
        private System.Windows.Forms.ColumnHeader sender_idHeader;
        private System.Windows.Forms.ColumnHeader senderHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
    }
}