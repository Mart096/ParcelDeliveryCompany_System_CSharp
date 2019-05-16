namespace ParcelDeliveryCompany_ClassLibrary1
{
    partial class ConsignmentAddEditUpdateForm
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
            this.order_ListView = new System.Windows.Forms.ListView();
            this.id_ColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.courierHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sender_idHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.senderHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.consignee_ListView = new System.Windows.Forms.ListView();
            this.id_sender_column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.firstName_column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lastName_column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.street_Column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.houseNum_column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.apartmentNum_column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.city_Column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.postCode_column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.phoneNumber_column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.consigneeListView_panel = new System.Windows.Forms.Panel();
            this.clearFilter_button = new System.Windows.Forms.Button();
            this.consigneeSearch_button = new System.Windows.Forms.Button();
            this.searchConsignee_textBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.consigneeColumns_listbox = new System.Windows.Forms.ListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.addNewConsignee_checkbox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.consignmentType_ListView = new System.Windows.Forms.ListView();
            this.consignmentTypeID_column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.consignmentType_column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.pickupMethodlistView = new System.Windows.Forms.ListView();
            this.pickupMethodID_column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pickupMethod_column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.customerAddEdit_controler = new ParcelDeliveryCompany_ClassLibrary1.CustomerAddEditControler();
            this.panel1.SuspendLayout();
            this.consigneeListView_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // cancel_button
            // 
            this.cancel_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cancel_button.Location = new System.Drawing.Point(93, 614);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(75, 23);
            this.cancel_button.TabIndex = 3;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.Cancel_button_Click);
            // 
            // accept_button
            // 
            this.accept_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.accept_button.Location = new System.Drawing.Point(12, 614);
            this.accept_button.Name = "accept_button";
            this.accept_button.Size = new System.Drawing.Size(75, 23);
            this.accept_button.TabIndex = 2;
            this.accept_button.Text = "Add new";
            this.accept_button.UseVisualStyleBackColor = true;
            this.accept_button.Click += new System.EventHandler(this.Accept_button_Click);
            // 
            // order_ListView
            // 
            this.order_ListView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.order_ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id_ColumnHeader,
            this.courierHeader,
            this.sender_idHeader,
            this.senderHeader});
            this.order_ListView.FullRowSelect = true;
            this.order_ListView.HideSelection = false;
            this.order_ListView.Location = new System.Drawing.Point(12, 20);
            this.order_ListView.MultiSelect = false;
            this.order_ListView.Name = "order_ListView";
            this.order_ListView.Size = new System.Drawing.Size(544, 242);
            this.order_ListView.TabIndex = 4;
            this.order_ListView.UseCompatibleStateImageBehavior = false;
            this.order_ListView.View = System.Windows.Forms.View.Details;
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
            // consignee_ListView
            // 
            this.consignee_ListView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.consignee_ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id_sender_column,
            this.firstName_column,
            this.lastName_column,
            this.street_Column,
            this.houseNum_column,
            this.apartmentNum_column,
            this.city_Column,
            this.postCode_column,
            this.phoneNumber_column});
            this.consignee_ListView.FullRowSelect = true;
            this.consignee_ListView.HideSelection = false;
            this.consignee_ListView.Location = new System.Drawing.Point(0, 6);
            this.consignee_ListView.MultiSelect = false;
            this.consignee_ListView.Name = "consignee_ListView";
            this.consignee_ListView.Size = new System.Drawing.Size(398, 234);
            this.consignee_ListView.TabIndex = 5;
            this.consignee_ListView.UseCompatibleStateImageBehavior = false;
            this.consignee_ListView.View = System.Windows.Forms.View.Details;
            // 
            // id_sender_column
            // 
            this.id_sender_column.Text = "ID";
            // 
            // firstName_column
            // 
            this.firstName_column.Text = "First name";
            this.firstName_column.Width = 74;
            // 
            // lastName_column
            // 
            this.lastName_column.Text = "Last name";
            this.lastName_column.Width = 76;
            // 
            // street_Column
            // 
            this.street_Column.Text = "Street";
            // 
            // houseNum_column
            // 
            this.houseNum_column.Text = "House number";
            // 
            // apartmentNum_column
            // 
            this.apartmentNum_column.Text = "Apartment number";
            // 
            // city_Column
            // 
            this.city_Column.Text = "City";
            // 
            // postCode_column
            // 
            this.postCode_column.Text = "Post code";
            // 
            // phoneNumber_column
            // 
            this.phoneNumber_column.Text = "Phone number";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.customerAddEdit_controler);
            this.panel1.Controls.Add(this.addNewConsignee_checkbox);
            this.panel1.Controls.Add(this.consigneeListView_panel);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.consignmentType_ListView);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pickupMethodlistView);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.order_ListView);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(616, 596);
            this.panel1.TabIndex = 6;
            // 
            // consigneeListView_panel
            // 
            this.consigneeListView_panel.Controls.Add(this.clearFilter_button);
            this.consigneeListView_panel.Controls.Add(this.consigneeSearch_button);
            this.consigneeListView_panel.Controls.Add(this.searchConsignee_textBox);
            this.consigneeListView_panel.Controls.Add(this.label13);
            this.consigneeListView_panel.Controls.Add(this.consigneeColumns_listbox);
            this.consigneeListView_panel.Controls.Add(this.label12);
            this.consigneeListView_panel.Controls.Add(this.consignee_ListView);
            this.consigneeListView_panel.Location = new System.Drawing.Point(12, 296);
            this.consigneeListView_panel.Name = "consigneeListView_panel";
            this.consigneeListView_panel.Size = new System.Drawing.Size(544, 243);
            this.consigneeListView_panel.TabIndex = 14;
            // 
            // clearFilter_button
            // 
            this.clearFilter_button.Enabled = false;
            this.clearFilter_button.Location = new System.Drawing.Point(421, 205);
            this.clearFilter_button.Name = "clearFilter_button";
            this.clearFilter_button.Size = new System.Drawing.Size(102, 23);
            this.clearFilter_button.TabIndex = 11;
            this.clearFilter_button.Text = "Clear filter";
            this.clearFilter_button.UseVisualStyleBackColor = true;
            this.clearFilter_button.Click += new System.EventHandler(this.ClearFilter_button_Click);
            // 
            // consigneeSearch_button
            // 
            this.consigneeSearch_button.Enabled = false;
            this.consigneeSearch_button.Location = new System.Drawing.Point(421, 175);
            this.consigneeSearch_button.Name = "consigneeSearch_button";
            this.consigneeSearch_button.Size = new System.Drawing.Size(102, 23);
            this.consigneeSearch_button.TabIndex = 10;
            this.consigneeSearch_button.Text = "Search";
            this.consigneeSearch_button.UseVisualStyleBackColor = true;
            this.consigneeSearch_button.Click += new System.EventHandler(this.ConsigneeSearch_button_Click);
            // 
            // searchConsignee_textBox
            // 
            this.searchConsignee_textBox.Location = new System.Drawing.Point(421, 23);
            this.searchConsignee_textBox.Name = "searchConsignee_textBox";
            this.searchConsignee_textBox.Size = new System.Drawing.Size(104, 20);
            this.searchConsignee_textBox.TabIndex = 9;
            this.searchConsignee_textBox.TextChanged += new System.EventHandler(this.SearchConsignee_textBox_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(418, 6);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 13);
            this.label13.TabIndex = 8;
            this.label13.Text = "Search";
            // 
            // consigneeColumns_listbox
            // 
            this.consigneeColumns_listbox.FormattingEnabled = true;
            this.consigneeColumns_listbox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.consigneeColumns_listbox.Items.AddRange(new object[] {
            "ID",
            "First name",
            "Last name",
            "Street",
            "House number",
            "Apartment number",
            "City",
            "Post code",
            "Phone number"});
            this.consigneeColumns_listbox.Location = new System.Drawing.Point(421, 73);
            this.consigneeColumns_listbox.Name = "consigneeColumns_listbox";
            this.consigneeColumns_listbox.Size = new System.Drawing.Size(104, 95);
            this.consigneeColumns_listbox.TabIndex = 7;
            this.consigneeColumns_listbox.SelectedIndexChanged += new System.EventHandler(this.ConsigneeColumns_listbox_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(418, 56);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "Search by";
            // 
            // addNewConsignee_checkbox
            // 
            this.addNewConsignee_checkbox.AutoSize = true;
            this.addNewConsignee_checkbox.Location = new System.Drawing.Point(107, 265);
            this.addNewConsignee_checkbox.Name = "addNewConsignee_checkbox";
            this.addNewConsignee_checkbox.Size = new System.Drawing.Size(114, 17);
            this.addNewConsignee_checkbox.TabIndex = 13;
            this.addNewConsignee_checkbox.Text = "Add new customer";
            this.addNewConsignee_checkbox.UseVisualStyleBackColor = true;
            this.addNewConsignee_checkbox.CheckedChanged += new System.EventHandler(this.AddNewConsignee_checkbox_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(307, 542);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Consignment type";
            // 
            // consignmentType_ListView
            // 
            this.consignmentType_ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.consignmentTypeID_column,
            this.consignmentType_column});
            this.consignmentType_ListView.HideSelection = false;
            this.consignmentType_ListView.Location = new System.Drawing.Point(310, 559);
            this.consignmentType_ListView.MultiSelect = false;
            this.consignmentType_ListView.Name = "consignmentType_ListView";
            this.consignmentType_ListView.Size = new System.Drawing.Size(246, 136);
            this.consignmentType_ListView.TabIndex = 10;
            this.consignmentType_ListView.UseCompatibleStateImageBehavior = false;
            this.consignmentType_ListView.View = System.Windows.Forms.View.Details;
            // 
            // consignmentTypeID_column
            // 
            this.consignmentTypeID_column.Text = "ID";
            // 
            // consignmentType_column
            // 
            this.consignmentType_column.Text = "Consignment type";
            this.consignmentType_column.Width = 176;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(9, 542);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Pickup method";
            // 
            // pickupMethodlistView
            // 
            this.pickupMethodlistView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.pickupMethodID_column,
            this.pickupMethod_column});
            this.pickupMethodlistView.HideSelection = false;
            this.pickupMethodlistView.Location = new System.Drawing.Point(12, 559);
            this.pickupMethodlistView.MultiSelect = false;
            this.pickupMethodlistView.Name = "pickupMethodlistView";
            this.pickupMethodlistView.Size = new System.Drawing.Size(253, 136);
            this.pickupMethodlistView.TabIndex = 8;
            this.pickupMethodlistView.UseCompatibleStateImageBehavior = false;
            this.pickupMethodlistView.View = System.Windows.Forms.View.Details;
            // 
            // pickupMethodID_column
            // 
            this.pickupMethodID_column.Text = "ID";
            // 
            // pickupMethod_column
            // 
            this.pickupMethod_column.Text = "Pickup method";
            this.pickupMethod_column.Width = 188;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(9, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Consignee";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Order";
            // 
            // customerAddEdit_controler
            // 
            this.customerAddEdit_controler.AutoScroll = true;
            this.customerAddEdit_controler.Enabled = false;
            this.customerAddEdit_controler.Location = new System.Drawing.Point(15, 296);
            this.customerAddEdit_controler.MainWindowReference = null;
            this.customerAddEdit_controler.Name = "customerAddEdit_controler";
            this.customerAddEdit_controler.Size = new System.Drawing.Size(563, 251);
            this.customerAddEdit_controler.TabIndex = 29;
            this.customerAddEdit_controler.Visible = false;
            // 
            // ConsignmentAddEditUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 649);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.accept_button);
            this.Name = "ConsignmentAddEditUpdateForm";
            this.Text = "Add new consignment";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.consigneeListView_panel.ResumeLayout(false);
            this.consigneeListView_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Button accept_button;
        private System.Windows.Forms.ListView order_ListView;
        private System.Windows.Forms.ColumnHeader id_ColumnHeader;
        private System.Windows.Forms.ColumnHeader courierHeader;
        private System.Windows.Forms.ColumnHeader sender_idHeader;
        private System.Windows.Forms.ColumnHeader senderHeader;
        private System.Windows.Forms.ListView consignee_ListView;
        private System.Windows.Forms.ColumnHeader id_sender_column;
        private System.Windows.Forms.ColumnHeader firstName_column;
        private System.Windows.Forms.ColumnHeader lastName_column;
        private System.Windows.Forms.ColumnHeader street_Column;
        private System.Windows.Forms.ColumnHeader houseNum_column;
        private System.Windows.Forms.ColumnHeader apartmentNum_column;
        private System.Windows.Forms.ColumnHeader city_Column;
        private System.Windows.Forms.ColumnHeader postCode_column;
        private System.Windows.Forms.ColumnHeader phoneNumber_column;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView pickupMethodlistView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView consignmentType_ListView;
        private System.Windows.Forms.CheckBox addNewConsignee_checkbox;
        private System.Windows.Forms.Panel consigneeListView_panel;
        private System.Windows.Forms.TextBox searchConsignee_textBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ListBox consigneeColumns_listbox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button clearFilter_button;
        private System.Windows.Forms.Button consigneeSearch_button;
        private System.Windows.Forms.ColumnHeader consignmentTypeID_column;
        private System.Windows.Forms.ColumnHeader consignmentType_column;
        private System.Windows.Forms.ColumnHeader pickupMethodID_column;
        private System.Windows.Forms.ColumnHeader pickupMethod_column;
        private CustomerAddEditControler customerAddEdit_controler;
    }
}