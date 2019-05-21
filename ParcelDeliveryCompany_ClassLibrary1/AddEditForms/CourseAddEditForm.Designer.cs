namespace ParcelDeliveryCompany_ClassLibrary1
{
    partial class CourseAddEditForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.startLocation_ListView = new System.Windows.Forms.ListView();
            this.locationID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.locationType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.streetName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cityName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.houseNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.postCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.endLocation_listView = new System.Windows.Forms.ListView();
            this.endID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.endLocationType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.endStreetName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.endCityName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.endHouseNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.endPostCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.courier_ListView = new System.Windows.Forms.ListView();
            this.id_column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.couriers_Vehicle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.courier_FirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.courier_LastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.courier_BirthDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.courier_NationalID_Number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.departureDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.arrivalDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // cancel_button
            // 
            this.cancel_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cancel_button.Location = new System.Drawing.Point(112, 780);
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
            this.accept_button.Location = new System.Drawing.Point(12, 780);
            this.accept_button.Name = "accept_button";
            this.accept_button.Size = new System.Drawing.Size(94, 36);
            this.accept_button.TabIndex = 20;
            this.accept_button.Text = "Add new course";
            this.accept_button.UseVisualStyleBackColor = true;
            this.accept_button.Click += new System.EventHandler(this.Accept_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "Start Location";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(9, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = "End location";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(9, 490);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 26;
            this.label3.Text = "Courier";
            // 
            // startLocation_ListView
            // 
            this.startLocation_ListView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.startLocation_ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.locationID,
            this.locationType,
            this.streetName,
            this.cityName,
            this.houseNumber,
            this.postCode});
            this.startLocation_ListView.FullRowSelect = true;
            this.startLocation_ListView.HideSelection = false;
            this.startLocation_ListView.Location = new System.Drawing.Point(12, 29);
            this.startLocation_ListView.MultiSelect = false;
            this.startLocation_ListView.Name = "startLocation_ListView";
            this.startLocation_ListView.Size = new System.Drawing.Size(576, 213);
            this.startLocation_ListView.TabIndex = 27;
            this.startLocation_ListView.UseCompatibleStateImageBehavior = false;
            this.startLocation_ListView.View = System.Windows.Forms.View.Details;
            // 
            // locationID
            // 
            this.locationID.Text = "ID";
            this.locationID.Width = 79;
            // 
            // locationType
            // 
            this.locationType.Text = "Location type";
            this.locationType.Width = 144;
            // 
            // streetName
            // 
            this.streetName.DisplayIndex = 3;
            this.streetName.Text = "Street";
            this.streetName.Width = 103;
            // 
            // cityName
            // 
            this.cityName.DisplayIndex = 2;
            this.cityName.Text = "City";
            // 
            // houseNumber
            // 
            this.houseNumber.Text = "House number";
            this.houseNumber.Width = 92;
            // 
            // postCode
            // 
            this.postCode.Text = "Post code";
            this.postCode.Width = 136;
            // 
            // endLocation_listView
            // 
            this.endLocation_listView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.endLocation_listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.endID,
            this.endLocationType,
            this.endStreetName,
            this.endCityName,
            this.endHouseNumber,
            this.endPostCode});
            this.endLocation_listView.FullRowSelect = true;
            this.endLocation_listView.HideSelection = false;
            this.endLocation_listView.Location = new System.Drawing.Point(12, 274);
            this.endLocation_listView.MultiSelect = false;
            this.endLocation_listView.Name = "endLocation_listView";
            this.endLocation_listView.Size = new System.Drawing.Size(576, 213);
            this.endLocation_listView.TabIndex = 28;
            this.endLocation_listView.UseCompatibleStateImageBehavior = false;
            this.endLocation_listView.View = System.Windows.Forms.View.Details;
            // 
            // endID
            // 
            this.endID.Text = "ID";
            this.endID.Width = 79;
            // 
            // endLocationType
            // 
            this.endLocationType.Text = "Location type";
            this.endLocationType.Width = 144;
            // 
            // endStreetName
            // 
            this.endStreetName.DisplayIndex = 3;
            this.endStreetName.Text = "Street";
            this.endStreetName.Width = 103;
            // 
            // endCityName
            // 
            this.endCityName.DisplayIndex = 2;
            this.endCityName.Text = "City";
            // 
            // endHouseNumber
            // 
            this.endHouseNumber.Text = "House number";
            this.endHouseNumber.Width = 92;
            // 
            // endPostCode
            // 
            this.endPostCode.Text = "Post code";
            this.endPostCode.Width = 136;
            // 
            // courier_ListView
            // 
            this.courier_ListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.courier_ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id_column,
            this.couriers_Vehicle,
            this.courier_FirstName,
            this.courier_LastName,
            this.courier_BirthDate,
            this.courier_NationalID_Number});
            this.courier_ListView.FullRowSelect = true;
            this.courier_ListView.HideSelection = false;
            this.courier_ListView.Location = new System.Drawing.Point(12, 510);
            this.courier_ListView.MultiSelect = false;
            this.courier_ListView.Name = "courier_ListView";
            this.courier_ListView.Size = new System.Drawing.Size(576, 221);
            this.courier_ListView.TabIndex = 29;
            this.courier_ListView.UseCompatibleStateImageBehavior = false;
            this.courier_ListView.View = System.Windows.Forms.View.Details;
            // 
            // id_column
            // 
            this.id_column.Text = "ID";
            // 
            // couriers_Vehicle
            // 
            this.couriers_Vehicle.Text = "Vehicle ID";
            this.couriers_Vehicle.Width = 77;
            // 
            // courier_FirstName
            // 
            this.courier_FirstName.Text = "First name";
            this.courier_FirstName.Width = 72;
            // 
            // courier_LastName
            // 
            this.courier_LastName.Text = "Last name";
            this.courier_LastName.Width = 81;
            // 
            // courier_BirthDate
            // 
            this.courier_BirthDate.Text = "Birth date";
            // 
            // courier_NationalID_Number
            // 
            this.courier_NationalID_Number.Text = "National Identification Number";
            this.courier_NationalID_Number.Width = 162;
            // 
            // departureDateTimePicker
            // 
            this.departureDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.departureDateTimePicker.CustomFormat = "dd-MM-yyyy, HH:mm";
            this.departureDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.departureDateTimePicker.Location = new System.Drawing.Point(12, 754);
            this.departureDateTimePicker.Name = "departureDateTimePicker";
            this.departureDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.departureDateTimePicker.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(9, 734);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 17);
            this.label4.TabIndex = 31;
            this.label4.Text = "Departure date time";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(218, 734);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 17);
            this.label5.TabIndex = 33;
            this.label5.Text = "Arrival date time";
            // 
            // arrivalDateTimePicker
            // 
            this.arrivalDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.arrivalDateTimePicker.CustomFormat = "dd-MM-yyyy, HH:mm";
            this.arrivalDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.arrivalDateTimePicker.Location = new System.Drawing.Point(221, 754);
            this.arrivalDateTimePicker.Name = "arrivalDateTimePicker";
            this.arrivalDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.arrivalDateTimePicker.TabIndex = 32;
            // 
            // CourseAddEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 828);
            this.ControlBox = false;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.arrivalDateTimePicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.departureDateTimePicker);
            this.Controls.Add(this.courier_ListView);
            this.Controls.Add(this.endLocation_listView);
            this.Controls.Add(this.startLocation_ListView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.accept_button);
            this.Name = "CourseAddEditForm";
            this.Text = "Add new course";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Button accept_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView startLocation_ListView;
        private System.Windows.Forms.ColumnHeader locationID;
        private System.Windows.Forms.ColumnHeader locationType;
        private System.Windows.Forms.ColumnHeader streetName;
        private System.Windows.Forms.ColumnHeader houseNumber;
        private System.Windows.Forms.ColumnHeader postCode;
        private System.Windows.Forms.ListView endLocation_listView;
        private System.Windows.Forms.ColumnHeader endID;
        private System.Windows.Forms.ColumnHeader endLocationType;
        private System.Windows.Forms.ColumnHeader endStreetName;
        private System.Windows.Forms.ColumnHeader endHouseNumber;
        private System.Windows.Forms.ColumnHeader endPostCode;
        private System.Windows.Forms.ListView courier_ListView;
        private System.Windows.Forms.ColumnHeader id_column;
        private System.Windows.Forms.ColumnHeader couriers_Vehicle;
        private System.Windows.Forms.ColumnHeader courier_FirstName;
        private System.Windows.Forms.ColumnHeader courier_LastName;
        private System.Windows.Forms.ColumnHeader courier_BirthDate;
        private System.Windows.Forms.ColumnHeader courier_NationalID_Number;
        private System.Windows.Forms.ColumnHeader cityName;
        private System.Windows.Forms.ColumnHeader endCityName;
        private System.Windows.Forms.DateTimePicker departureDateTimePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker arrivalDateTimePicker;
    }
}