namespace ParcelDeliveryCompany_ClassLibrary1
{
    partial class OrderAddEditForm
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
            this.sender_ListView = new System.Windows.Forms.ListView();
            this.id_sender_column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.firstName_column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lastName_column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.street_Column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.houseNum_column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.apartmentNum_column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.city_Column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.postCode_column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.phoneNumber_column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.addNewSender_checkbox = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.apartmentNum_numeric = new System.Windows.Forms.NumericUpDown();
            this.phoneNumber_textBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.courier_ListView = new System.Windows.Forms.ListView();
            this.id_column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.couriers_Vehicle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.courier_FirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.courier_LastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label = new System.Windows.Forms.Label();
            this.selectedCourier_label = new System.Windows.Forms.Label();
            this.selectedSender_label = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.orderDate_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.apartmentNum_numeric)).BeginInit();
            this.SuspendLayout();
            // 
            // accept_button
            // 
            this.accept_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.accept_button.Location = new System.Drawing.Point(12, 362);
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
            this.cancel_button.Location = new System.Drawing.Point(93, 362);
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
            this.label1.Location = new System.Drawing.Point(308, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sender";
            // 
            // sender_ListView
            // 
            this.sender_ListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sender_ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id_sender_column,
            this.firstName_column,
            this.lastName_column,
            this.street_Column,
            this.houseNum_column,
            this.apartmentNum_column,
            this.city_Column,
            this.postCode_column,
            this.phoneNumber_column});
            this.sender_ListView.FullRowSelect = true;
            this.sender_ListView.HideSelection = false;
            this.sender_ListView.Location = new System.Drawing.Point(312, 30);
            this.sender_ListView.MultiSelect = false;
            this.sender_ListView.Name = "sender_ListView";
            this.sender_ListView.Size = new System.Drawing.Size(369, 277);
            this.sender_ListView.TabIndex = 3;
            this.sender_ListView.UseCompatibleStateImageBehavior = false;
            this.sender_ListView.View = System.Windows.Forms.View.Details;
            this.sender_ListView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.ListView1_ItemSelectionChanged);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(9, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Courier";
            // 
            // addNewSender_checkbox
            // 
            this.addNewSender_checkbox.AutoSize = true;
            this.addNewSender_checkbox.Location = new System.Drawing.Point(392, 9);
            this.addNewSender_checkbox.Name = "addNewSender_checkbox";
            this.addNewSender_checkbox.Size = new System.Drawing.Size(114, 17);
            this.addNewSender_checkbox.TabIndex = 6;
            this.addNewSender_checkbox.Text = "Add new customer";
            this.addNewSender_checkbox.UseVisualStyleBackColor = true;
            this.addNewSender_checkbox.CheckedChanged += new System.EventHandler(this.AddNewSender_checkbox_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.apartmentNum_numeric);
            this.panel1.Controls.Add(this.phoneNumber_textBox);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.city_listView);
            this.panel1.Controls.Add(this.newCityArea_label);
            this.panel1.Controls.Add(this.newCityArea_listBox);
            this.panel1.Controls.Add(this.newCityName_textBox);
            this.panel1.Controls.Add(this.newCityName_label);
            this.panel1.Controls.Add(this.newCity_checkbox);
            this.panel1.Controls.Add(this.city_listBox);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.postalCode_textbox);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.houseNumber_textBox);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.street_TextBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lastName_textBox);
            this.panel1.Controls.Add(this.firstName_textBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(312, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(369, 276);
            this.panel1.TabIndex = 7;
            this.panel1.Visible = false;
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
            this.apartmentNum_numeric.TabIndex = 30;
            // 
            // phoneNumber_textBox
            // 
            this.phoneNumber_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.phoneNumber_textBox.Location = new System.Drawing.Point(6, 204);
            this.phoneNumber_textBox.Name = "phoneNumber_textBox";
            this.phoneNumber_textBox.Size = new System.Drawing.Size(196, 20);
            this.phoneNumber_textBox.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(3, 184);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 17);
            this.label10.TabIndex = 26;
            this.label10.Text = "Phone number";
            // 
            // city_listView
            // 
            this.city_listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.city_name_column,
            this.area_name_column});
            this.city_listView.FullRowSelect = true;
            this.city_listView.HideSelection = false;
            this.city_listView.Location = new System.Drawing.Point(3, 258);
            this.city_listView.MultiSelect = false;
            this.city_listView.Name = "city_listView";
            this.city_listView.Size = new System.Drawing.Size(163, 160);
            this.city_listView.TabIndex = 25;
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
            this.newCityArea_label.Location = new System.Drawing.Point(182, 290);
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
            this.newCityArea_listBox.Location = new System.Drawing.Point(184, 310);
            this.newCityArea_listBox.Name = "newCityArea_listBox";
            this.newCityArea_listBox.Size = new System.Drawing.Size(163, 108);
            this.newCityArea_listBox.TabIndex = 23;
            this.newCityArea_listBox.Visible = false;
            // 
            // newCityName_textBox
            // 
            this.newCityName_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newCityName_textBox.Enabled = false;
            this.newCityName_textBox.Location = new System.Drawing.Point(185, 259);
            this.newCityName_textBox.Name = "newCityName_textBox";
            this.newCityName_textBox.Size = new System.Drawing.Size(124, 20);
            this.newCityName_textBox.TabIndex = 22;
            this.newCityName_textBox.Visible = false;
            // 
            // newCityName_label
            // 
            this.newCityName_label.AutoSize = true;
            this.newCityName_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.newCityName_label.Location = new System.Drawing.Point(182, 239);
            this.newCityName_label.Name = "newCityName_label";
            this.newCityName_label.Size = new System.Drawing.Size(70, 17);
            this.newCityName_label.TabIndex = 21;
            this.newCityName_label.Text = "City name";
            this.newCityName_label.Visible = false;
            // 
            // newCity_checkbox
            // 
            this.newCity_checkbox.AutoSize = true;
            this.newCity_checkbox.Location = new System.Drawing.Point(68, 238);
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
            this.city_listBox.Location = new System.Drawing.Point(3, 258);
            this.city_listBox.Name = "city_listBox";
            this.city_listBox.Size = new System.Drawing.Size(163, 160);
            this.city_listBox.TabIndex = 19;
            this.city_listBox.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(3, 238);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "City";
            // 
            // postalCode_textbox
            // 
            this.postalCode_textbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.postalCode_textbox.Location = new System.Drawing.Point(255, 161);
            this.postalCode_textbox.Name = "postalCode_textbox";
            this.postalCode_textbox.Size = new System.Drawing.Size(79, 20);
            this.postalCode_textbox.TabIndex = 17;
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
            this.houseNumber_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.houseNumber_textBox.Location = new System.Drawing.Point(6, 161);
            this.houseNumber_textBox.Name = "houseNumber_textBox";
            this.houseNumber_textBox.Size = new System.Drawing.Size(98, 20);
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
            this.street_TextBox.Size = new System.Drawing.Size(303, 20);
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
            this.lastName_textBox.Size = new System.Drawing.Size(303, 20);
            this.lastName_textBox.TabIndex = 9;
            // 
            // firstName_textBox
            // 
            this.firstName_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.firstName_textBox.Location = new System.Drawing.Point(6, 32);
            this.firstName_textBox.Name = "firstName_textBox";
            this.firstName_textBox.Size = new System.Drawing.Size(303, 20);
            this.firstName_textBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(3, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Last name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(3, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "First name";
            // 
            // courier_ListView
            // 
            this.courier_ListView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.courier_ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id_column,
            this.couriers_Vehicle,
            this.courier_FirstName,
            this.courier_LastName});
            this.courier_ListView.FullRowSelect = true;
            this.courier_ListView.HideSelection = false;
            this.courier_ListView.Location = new System.Drawing.Point(12, 29);
            this.courier_ListView.MultiSelect = false;
            this.courier_ListView.Name = "courier_ListView";
            this.courier_ListView.Size = new System.Drawing.Size(283, 277);
            this.courier_ListView.TabIndex = 8;
            this.courier_ListView.UseCompatibleStateImageBehavior = false;
            this.courier_ListView.View = System.Windows.Forms.View.Details;
            this.courier_ListView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.Courier_ListView_ItemSelectionChanged);
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
            // label
            // 
            this.label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label.Location = new System.Drawing.Point(9, 309);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(67, 17);
            this.label.TabIndex = 25;
            this.label.Text = "Selected:";
            // 
            // selectedCourier_label
            // 
            this.selectedCourier_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.selectedCourier_label.AutoSize = true;
            this.selectedCourier_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.selectedCourier_label.Location = new System.Drawing.Point(82, 309);
            this.selectedCourier_label.Name = "selectedCourier_label";
            this.selectedCourier_label.Size = new System.Drawing.Size(42, 17);
            this.selectedCourier_label.TabIndex = 26;
            this.selectedCourier_label.Text = "None";
            // 
            // selectedSender_label
            // 
            this.selectedSender_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.selectedSender_label.AutoSize = true;
            this.selectedSender_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.selectedSender_label.Location = new System.Drawing.Point(381, 309);
            this.selectedSender_label.Name = "selectedSender_label";
            this.selectedSender_label.Size = new System.Drawing.Size(42, 17);
            this.selectedSender_label.TabIndex = 29;
            this.selectedSender_label.Text = "None";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label14.Location = new System.Drawing.Point(308, 309);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 17);
            this.label14.TabIndex = 28;
            this.label14.Text = "Selected:";
            // 
            // orderDate_dateTimePicker
            // 
            this.orderDate_dateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.orderDate_dateTimePicker.Location = new System.Drawing.Point(93, 336);
            this.orderDate_dateTimePicker.Name = "orderDate_dateTimePicker";
            this.orderDate_dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.orderDate_dateTimePicker.TabIndex = 30;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(9, 336);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 17);
            this.label11.TabIndex = 31;
            this.label11.Text = "Order date:";
            // 
            // OrderAddEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 397);
            this.ControlBox = false;
            this.Controls.Add(this.label11);
            this.Controls.Add(this.orderDate_dateTimePicker);
            this.Controls.Add(this.selectedSender_label);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.selectedCourier_label);
            this.Controls.Add(this.label);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sender_ListView);
            this.Controls.Add(this.courier_ListView);
            this.Controls.Add(this.addNewSender_checkbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.accept_button);
            this.MinimumSize = new System.Drawing.Size(714, 413);
            this.Name = "OrderAddEditForm";
            this.Text = "Add new order";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.apartmentNum_numeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button accept_button;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView sender_ListView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox addNewSender_checkbox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColumnHeader id_sender_column;
        private System.Windows.Forms.ColumnHeader firstName_column;
        private System.Windows.Forms.ColumnHeader lastName_column;
        private System.Windows.Forms.ColumnHeader street_Column;
        private System.Windows.Forms.ColumnHeader houseNum_column;
        private System.Windows.Forms.ColumnHeader apartmentNum_column;
        private System.Windows.Forms.ColumnHeader city_Column;
        private System.Windows.Forms.ColumnHeader postCode_column;
        private System.Windows.Forms.ColumnHeader phoneNumber_column;
        private System.Windows.Forms.ListView courier_ListView;
        private System.Windows.Forms.ColumnHeader id_column;
        private System.Windows.Forms.ColumnHeader couriers_Vehicle;
        private System.Windows.Forms.ColumnHeader courier_FirstName;
        private System.Windows.Forms.ColumnHeader courier_LastName;
        private System.Windows.Forms.TextBox lastName_textBox;
        private System.Windows.Forms.TextBox firstName_textBox;
        private System.Windows.Forms.TextBox postalCode_textbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox houseNumber_textBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox street_TextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox city_listBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox newCity_checkbox;
        private System.Windows.Forms.TextBox newCityName_textBox;
        private System.Windows.Forms.Label newCityName_label;
        private System.Windows.Forms.Label newCityArea_label;
        private System.Windows.Forms.ListBox newCityArea_listBox;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label selectedCourier_label;
        private System.Windows.Forms.Label selectedSender_label;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ListView city_listView;
        private System.Windows.Forms.ColumnHeader city_name_column;
        private System.Windows.Forms.ColumnHeader area_name_column;
        private System.Windows.Forms.TextBox phoneNumber_textBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown apartmentNum_numeric;
        private System.Windows.Forms.DateTimePicker orderDate_dateTimePicker;
        private System.Windows.Forms.Label label11;
    }
}