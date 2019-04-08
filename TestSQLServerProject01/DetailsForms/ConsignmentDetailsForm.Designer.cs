namespace TestSQLServerProject01
{
    partial class ConsignmentDetailsForm
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
            this.Details_titleLabel = new System.Windows.Forms.Label();
            this.orderID_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.consignerID_textBox = new System.Windows.Forms.TextBox();
            this.consigneeID_textbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pickupState_textbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pickupMethod_textbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.consignerFullName_textbox = new System.Windows.Forms.TextBox();
            this.consigneeFullName_textbox = new System.Windows.Forms.TextBox();
            this.consignmentType_textbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.consignmentData_panel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.updateConsignmentPickupState_button = new System.Windows.Forms.Button();
            this.pickupState_listView = new System.Windows.Forms.ListView();
            this.idColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label7 = new System.Windows.Forms.Label();
            this.parcelManagement_Controler = new TestSQLServerProject01.ParcelManagementControler();
            this.consignmentParcelManagement_panel = new TestSQLServerProject01.ManagementControls.ConsignmentParcelManagementControl();
            this.consignmentData_panel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cancel_button
            // 
            this.cancel_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cancel_button.Location = new System.Drawing.Point(12, 415);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(75, 23);
            this.cancel_button.TabIndex = 5;
            this.cancel_button.Text = "Close";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.Cancel_button_Click);
            // 
            // Details_titleLabel
            // 
            this.Details_titleLabel.AutoSize = true;
            this.Details_titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Details_titleLabel.Location = new System.Drawing.Point(12, 9);
            this.Details_titleLabel.Name = "Details_titleLabel";
            this.Details_titleLabel.Size = new System.Drawing.Size(103, 20);
            this.Details_titleLabel.TabIndex = 6;
            this.Details_titleLabel.Text = "Consignment";
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
            // consignerID_textBox
            // 
            this.consignerID_textBox.Location = new System.Drawing.Point(4, 81);
            this.consignerID_textBox.Name = "consignerID_textBox";
            this.consignerID_textBox.ReadOnly = true;
            this.consignerID_textBox.Size = new System.Drawing.Size(103, 20);
            this.consignerID_textBox.TabIndex = 11;
            // 
            // consigneeID_textbox
            // 
            this.consigneeID_textbox.Location = new System.Drawing.Point(4, 138);
            this.consigneeID_textbox.Name = "consigneeID_textbox";
            this.consigneeID_textbox.ReadOnly = true;
            this.consigneeID_textbox.Size = new System.Drawing.Size(103, 20);
            this.consigneeID_textbox.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(5, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Consignee";
            // 
            // pickupState_textbox
            // 
            this.pickupState_textbox.Location = new System.Drawing.Point(4, 197);
            this.pickupState_textbox.Name = "pickupState_textbox";
            this.pickupState_textbox.ReadOnly = true;
            this.pickupState_textbox.Size = new System.Drawing.Size(251, 20);
            this.pickupState_textbox.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(5, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Pickup state";
            // 
            // pickupMethod_textbox
            // 
            this.pickupMethod_textbox.Location = new System.Drawing.Point(4, 251);
            this.pickupMethod_textbox.Name = "pickupMethod_textbox";
            this.pickupMethod_textbox.ReadOnly = true;
            this.pickupMethod_textbox.Size = new System.Drawing.Size(251, 20);
            this.pickupMethod_textbox.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(5, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Pickup method";
            // 
            // consignerFullName_textbox
            // 
            this.consignerFullName_textbox.Location = new System.Drawing.Point(113, 81);
            this.consignerFullName_textbox.Name = "consignerFullName_textbox";
            this.consignerFullName_textbox.ReadOnly = true;
            this.consignerFullName_textbox.Size = new System.Drawing.Size(142, 20);
            this.consignerFullName_textbox.TabIndex = 18;
            // 
            // consigneeFullName_textbox
            // 
            this.consigneeFullName_textbox.Location = new System.Drawing.Point(113, 138);
            this.consigneeFullName_textbox.Name = "consigneeFullName_textbox";
            this.consigneeFullName_textbox.ReadOnly = true;
            this.consigneeFullName_textbox.Size = new System.Drawing.Size(142, 20);
            this.consigneeFullName_textbox.TabIndex = 19;
            // 
            // consignmentType_textbox
            // 
            this.consignmentType_textbox.Location = new System.Drawing.Point(4, 303);
            this.consignmentType_textbox.Name = "consignmentType_textbox";
            this.consignmentType_textbox.ReadOnly = true;
            this.consignmentType_textbox.Size = new System.Drawing.Size(251, 20);
            this.consignmentType_textbox.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(5, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 17);
            this.label6.TabIndex = 20;
            this.label6.Text = "Consignment type";
            // 
            // consignmentData_panel
            // 
            this.consignmentData_panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.consignmentData_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.consignmentData_panel.Controls.Add(this.consignmentType_textbox);
            this.consignmentData_panel.Controls.Add(this.orderID_textbox);
            this.consignmentData_panel.Controls.Add(this.label6);
            this.consignmentData_panel.Controls.Add(this.label1);
            this.consignmentData_panel.Controls.Add(this.consigneeFullName_textbox);
            this.consignmentData_panel.Controls.Add(this.label2);
            this.consignmentData_panel.Controls.Add(this.consignerFullName_textbox);
            this.consignmentData_panel.Controls.Add(this.consignerID_textBox);
            this.consignmentData_panel.Controls.Add(this.pickupMethod_textbox);
            this.consignmentData_panel.Controls.Add(this.label3);
            this.consignmentData_panel.Controls.Add(this.label5);
            this.consignmentData_panel.Controls.Add(this.consigneeID_textbox);
            this.consignmentData_panel.Controls.Add(this.pickupState_textbox);
            this.consignmentData_panel.Controls.Add(this.label4);
            this.consignmentData_panel.Location = new System.Drawing.Point(12, 32);
            this.consignmentData_panel.Name = "consignmentData_panel";
            this.consignmentData_panel.Size = new System.Drawing.Size(283, 377);
            this.consignmentData_panel.TabIndex = 22;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.updateConsignmentPickupState_button);
            this.panel1.Controls.Add(this.pickupState_listView);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(301, 288);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(576, 121);
            this.panel1.TabIndex = 24;
            // 
            // updateConsignmentPickupState_button
            // 
            this.updateConsignmentPickupState_button.Enabled = false;
            this.updateConsignmentPickupState_button.Location = new System.Drawing.Point(6, 21);
            this.updateConsignmentPickupState_button.Name = "updateConsignmentPickupState_button";
            this.updateConsignmentPickupState_button.Size = new System.Drawing.Size(137, 35);
            this.updateConsignmentPickupState_button.TabIndex = 26;
            this.updateConsignmentPickupState_button.Text = "Update pickup state";
            this.updateConsignmentPickupState_button.UseVisualStyleBackColor = true;
            this.updateConsignmentPickupState_button.Click += new System.EventHandler(this.UpdateConsignmentPickupState_button_Click);
            // 
            // pickupState_listView
            // 
            this.pickupState_listView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pickupState_listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idColumn,
            this.nameColumn});
            this.pickupState_listView.Location = new System.Drawing.Point(230, 3);
            this.pickupState_listView.Name = "pickupState_listView";
            this.pickupState_listView.Size = new System.Drawing.Size(341, 113);
            this.pickupState_listView.TabIndex = 25;
            this.pickupState_listView.UseCompatibleStateImageBehavior = false;
            this.pickupState_listView.View = System.Windows.Forms.View.Details;
            this.pickupState_listView.SelectedIndexChanged += new System.EventHandler(this.PickupState_listView_SelectedIndexChanged);
            // 
            // idColumn
            // 
            this.idColumn.Text = "ID";
            this.idColumn.Width = 52;
            // 
            // nameColumn
            // 
            this.nameColumn.Text = "Pickup state";
            this.nameColumn.Width = 242;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(228, 17);
            this.label7.TabIndex = 22;
            this.label7.Text = "Update consignment\'s pickup state";
            // 
            // parcelManagement_Controler
            // 
            this.parcelManagement_Controler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.parcelManagement_Controler.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.parcelManagement_Controler.Location = new System.Drawing.Point(301, 32);
            this.parcelManagement_Controler.MainWindowReference = null;
            this.parcelManagement_Controler.Name = "parcelManagement_Controler";
            this.parcelManagement_Controler.Size = new System.Drawing.Size(576, 252);
            this.parcelManagement_Controler.TabIndex = 23;
            // 
            // consignmentParcelManagement_panel
            // 
            this.consignmentParcelManagement_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.consignmentParcelManagement_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.consignmentParcelManagement_panel.Details_button_disabled = true;
            this.consignmentParcelManagement_panel.Item_id = 0;
            this.consignmentParcelManagement_panel.Item_name_plural = "parcels";
            this.consignmentParcelManagement_panel.Item_name_plural_capital_letter = "Parcels";
            this.consignmentParcelManagement_panel.Location = new System.Drawing.Point(301, 32);
            this.consignmentParcelManagement_panel.MainWindowReference = null;
            this.consignmentParcelManagement_panel.Name = "consignmentParcelManagement_panel";
            this.consignmentParcelManagement_panel.Size = new System.Drawing.Size(576, 252);
            this.consignmentParcelManagement_panel.TabIndex = 25;
            // 
            // ConsignmentDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 473);
            this.ControlBox = false;
            this.Controls.Add(this.consignmentParcelManagement_panel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.parcelManagement_Controler);
            this.Controls.Add(this.Details_titleLabel);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.consignmentData_panel);
            this.MinimumSize = new System.Drawing.Size(905, 489);
            this.Name = "ConsignmentDetailsForm";
            this.Text = "Details";
            this.consignmentData_panel.ResumeLayout(false);
            this.consignmentData_panel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Label Details_titleLabel;
        private System.Windows.Forms.TextBox orderID_textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox consignerID_textBox;
        private System.Windows.Forms.TextBox consigneeID_textbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox pickupState_textbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox pickupMethod_textbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox consignerFullName_textbox;
        private System.Windows.Forms.TextBox consigneeFullName_textbox;
        private System.Windows.Forms.TextBox consignmentType_textbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel consignmentData_panel;
        private ParcelManagementControler parcelManagement_Controler;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button updateConsignmentPickupState_button;
        private System.Windows.Forms.ListView pickupState_listView;
        private System.Windows.Forms.ColumnHeader idColumn;
        private System.Windows.Forms.ColumnHeader nameColumn;
        private ManagementControls.ConsignmentParcelManagementControl consignmentParcelManagement_panel;
    }
}