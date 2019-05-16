namespace ParcelDeliveryCompany_ClassLibrary1
{
    partial class PickupRequestDetailsForm
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
            this.Details_titleLabel = new System.Windows.Forms.Label();
            this.cancel_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.updateConsignmentPickupState_button = new System.Windows.Forms.Button();
            this.pickupRequestState_listView = new System.Windows.Forms.ListView();
            this.idColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label7 = new System.Windows.Forms.Label();
            this.consignmentData_panel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.courierFullName_textBox = new System.Windows.Forms.TextBox();
            this.courierID_textBox = new System.Windows.Forms.TextBox();
            this.orderID_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.consignerFullName_textbox = new System.Windows.Forms.TextBox();
            this.consignerID_textBox = new System.Windows.Forms.TextBox();
            this.pickupDateTime_textbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pickupRequestState_textbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.showRouteOnMapButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.consignmentData_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Details_titleLabel
            // 
            this.Details_titleLabel.AutoSize = true;
            this.Details_titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Details_titleLabel.Location = new System.Drawing.Point(8, 9);
            this.Details_titleLabel.Name = "Details_titleLabel";
            this.Details_titleLabel.Size = new System.Drawing.Size(114, 20);
            this.Details_titleLabel.TabIndex = 7;
            this.Details_titleLabel.Text = "Pickup request";
            // 
            // cancel_button
            // 
            this.cancel_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cancel_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel_button.Location = new System.Drawing.Point(12, 345);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(75, 23);
            this.cancel_button.TabIndex = 8;
            this.cancel_button.Text = "Close";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.Cancel_button_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.updateConsignmentPickupState_button);
            this.panel1.Controls.Add(this.pickupRequestState_listView);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(304, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(251, 296);
            this.panel1.TabIndex = 25;
            // 
            // updateConsignmentPickupState_button
            // 
            this.updateConsignmentPickupState_button.Enabled = false;
            this.updateConsignmentPickupState_button.Location = new System.Drawing.Point(6, 21);
            this.updateConsignmentPickupState_button.Name = "updateConsignmentPickupState_button";
            this.updateConsignmentPickupState_button.Size = new System.Drawing.Size(240, 35);
            this.updateConsignmentPickupState_button.TabIndex = 26;
            this.updateConsignmentPickupState_button.Text = "Update pickup request state";
            this.updateConsignmentPickupState_button.UseVisualStyleBackColor = true;
            this.updateConsignmentPickupState_button.Click += new System.EventHandler(this.UpdatePickupRequestState_button_Click);
            // 
            // pickupRequestState_listView
            // 
            this.pickupRequestState_listView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pickupRequestState_listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idColumn,
            this.nameColumn});
            this.pickupRequestState_listView.Location = new System.Drawing.Point(6, 62);
            this.pickupRequestState_listView.Name = "pickupRequestState_listView";
            this.pickupRequestState_listView.Size = new System.Drawing.Size(240, 229);
            this.pickupRequestState_listView.TabIndex = 25;
            this.pickupRequestState_listView.UseCompatibleStateImageBehavior = false;
            this.pickupRequestState_listView.View = System.Windows.Forms.View.Details;
            this.pickupRequestState_listView.SelectedIndexChanged += new System.EventHandler(this.PickupRequestState_listView_SelectedIndexChanged);
            // 
            // idColumn
            // 
            this.idColumn.Text = "ID";
            this.idColumn.Width = 52;
            // 
            // nameColumn
            // 
            this.nameColumn.Text = "Pickup state";
            this.nameColumn.Width = 124;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(196, 17);
            this.label7.TabIndex = 22;
            this.label7.Text = "Update pickup request\'s state";
            // 
            // consignmentData_panel
            // 
            this.consignmentData_panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.consignmentData_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.consignmentData_panel.Controls.Add(this.showRouteOnMapButton);
            this.consignmentData_panel.Controls.Add(this.label3);
            this.consignmentData_panel.Controls.Add(this.courierFullName_textBox);
            this.consignmentData_panel.Controls.Add(this.courierID_textBox);
            this.consignmentData_panel.Controls.Add(this.orderID_textbox);
            this.consignmentData_panel.Controls.Add(this.label1);
            this.consignmentData_panel.Controls.Add(this.label2);
            this.consignmentData_panel.Controls.Add(this.consignerFullName_textbox);
            this.consignmentData_panel.Controls.Add(this.consignerID_textBox);
            this.consignmentData_panel.Controls.Add(this.pickupDateTime_textbox);
            this.consignmentData_panel.Controls.Add(this.label5);
            this.consignmentData_panel.Controls.Add(this.pickupRequestState_textbox);
            this.consignmentData_panel.Controls.Add(this.label4);
            this.consignmentData_panel.Location = new System.Drawing.Point(12, 43);
            this.consignmentData_panel.Name = "consignmentData_panel";
            this.consignmentData_panel.Size = new System.Drawing.Size(283, 296);
            this.consignmentData_panel.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(5, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Assigned Courier";
            // 
            // courierFullName_textBox
            // 
            this.courierFullName_textBox.Location = new System.Drawing.Point(113, 233);
            this.courierFullName_textBox.Name = "courierFullName_textBox";
            this.courierFullName_textBox.ReadOnly = true;
            this.courierFullName_textBox.Size = new System.Drawing.Size(142, 20);
            this.courierFullName_textBox.TabIndex = 21;
            // 
            // courierID_textBox
            // 
            this.courierID_textBox.Location = new System.Drawing.Point(4, 233);
            this.courierID_textBox.Name = "courierID_textBox";
            this.courierID_textBox.ReadOnly = true;
            this.courierID_textBox.Size = new System.Drawing.Size(103, 20);
            this.courierID_textBox.TabIndex = 20;
            // 
            // orderID_textbox
            // 
            this.orderID_textbox.Location = new System.Drawing.Point(4, 26);
            this.orderID_textbox.Name = "orderID_textbox";
            this.orderID_textbox.ReadOnly = true;
            this.orderID_textbox.Size = new System.Drawing.Size(251, 20);
            this.orderID_textbox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(2, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Order ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(5, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Consigner";
            // 
            // consignerFullName_textbox
            // 
            this.consignerFullName_textbox.Location = new System.Drawing.Point(113, 81);
            this.consignerFullName_textbox.Name = "consignerFullName_textbox";
            this.consignerFullName_textbox.ReadOnly = true;
            this.consignerFullName_textbox.Size = new System.Drawing.Size(142, 20);
            this.consignerFullName_textbox.TabIndex = 18;
            // 
            // consignerID_textBox
            // 
            this.consignerID_textBox.Location = new System.Drawing.Point(4, 81);
            this.consignerID_textBox.Name = "consignerID_textBox";
            this.consignerID_textBox.ReadOnly = true;
            this.consignerID_textBox.Size = new System.Drawing.Size(103, 20);
            this.consignerID_textBox.TabIndex = 11;
            // 
            // pickupDateTime_textbox
            // 
            this.pickupDateTime_textbox.Location = new System.Drawing.Point(4, 190);
            this.pickupDateTime_textbox.Name = "pickupDateTime_textbox";
            this.pickupDateTime_textbox.ReadOnly = true;
            this.pickupDateTime_textbox.Size = new System.Drawing.Size(251, 20);
            this.pickupDateTime_textbox.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(5, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Pickup request date and time";
            // 
            // pickupRequestState_textbox
            // 
            this.pickupRequestState_textbox.Location = new System.Drawing.Point(4, 136);
            this.pickupRequestState_textbox.Name = "pickupRequestState_textbox";
            this.pickupRequestState_textbox.ReadOnly = true;
            this.pickupRequestState_textbox.Size = new System.Drawing.Size(251, 20);
            this.pickupRequestState_textbox.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(5, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Pickup request state";
            // 
            // showRouteOnMapButton
            // 
            this.showRouteOnMapButton.Location = new System.Drawing.Point(4, 259);
            this.showRouteOnMapButton.Name = "showRouteOnMapButton";
            this.showRouteOnMapButton.Size = new System.Drawing.Size(251, 23);
            this.showRouteOnMapButton.TabIndex = 22;
            this.showRouteOnMapButton.Text = "Show route to consigner on map";
            this.showRouteOnMapButton.UseVisualStyleBackColor = true;
            this.showRouteOnMapButton.Click += new System.EventHandler(this.ShowRouteOnMapButton_Click);
            // 
            // PickupRequestDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancel_button;
            this.ClientSize = new System.Drawing.Size(567, 380);
            this.ControlBox = false;
            this.Controls.Add(this.consignmentData_panel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.Details_titleLabel);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(583, 396);
            this.Name = "PickupRequestDetailsForm";
            this.Text = "Details";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.consignmentData_panel.ResumeLayout(false);
            this.consignmentData_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Details_titleLabel;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button updateConsignmentPickupState_button;
        private System.Windows.Forms.ListView pickupRequestState_listView;
        private System.Windows.Forms.ColumnHeader idColumn;
        private System.Windows.Forms.ColumnHeader nameColumn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel consignmentData_panel;
        private System.Windows.Forms.TextBox orderID_textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox consignerFullName_textbox;
        private System.Windows.Forms.TextBox consignerID_textBox;
        private System.Windows.Forms.TextBox pickupRequestState_textbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox courierFullName_textBox;
        private System.Windows.Forms.TextBox courierID_textBox;
        private System.Windows.Forms.TextBox pickupDateTime_textbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button showRouteOnMapButton;
    }
}