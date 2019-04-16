namespace ParcelDeliveryCompanyApplication
{
    partial class MainDatabaseManagementControler
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
            System.Windows.Forms.FlowLayoutPanel menu_panel1;
            this.dictionaryManagement_button = new System.Windows.Forms.Button();
            this.vehicleManagement_button = new System.Windows.Forms.Button();
            this.courierManagement_button = new System.Windows.Forms.Button();
            this.locationManagement_button = new System.Windows.Forms.Button();
            this.customerManagement_button = new System.Windows.Forms.Button();
            this.orderManagement_button = new System.Windows.Forms.Button();
            this.consignmentManagement_button = new System.Windows.Forms.Button();
            this.parcelManagement_button = new System.Windows.Forms.Button();
            this.courseManagement_button = new System.Windows.Forms.Button();
            this.pickupAssignmentManagement_button = new System.Windows.Forms.Button();
            this.complaintManagement_button = new System.Windows.Forms.Button();
            this.display_panel = new System.Windows.Forms.Panel();
            this.parcelManagementNew_panel = new ParcelDeliveryCompanyApplication.ManagementControls.ParcelManagementControl_New();
            this.courierManagementNew_panel = new ParcelDeliveryCompanyApplication.ManagementControls.CourierManagementControl_New();
            this.locationManagementNew_panel = new ParcelDeliveryCompanyApplication.ManagementControls.LocationManagementControl_New();
            this.consignmentManagementNew_panel = new ParcelDeliveryCompanyApplication.ManagementControls.ConsignmentManagementControl_New();
            this.orderManagementNew_panel = new ParcelDeliveryCompanyApplication.ManagementControls.OrderManagementControl_New();
            this.vehicleManagementNew_panel = new ParcelDeliveryCompanyApplication.VehicleManagementControler_New();
            this.complaintManagement_panel = new ParcelDeliveryCompanyApplication.ComplaintManagementControl();
            this.pickupRequestManagement_panel = new ParcelDeliveryCompanyApplication.PickupRequestManagementControl();
            this.courseManagementNew_panel = new ParcelDeliveryCompanyApplication.ManagementControls.CourseManagementControl_New();
            this.customerManagement_panel = new ParcelDeliveryCompanyApplication.CustomerManagementControler();
            this.dictionaryManagement_panel = new ParcelDeliveryCompanyApplication.DictionaryManagementControler();
            menu_panel1 = new System.Windows.Forms.FlowLayoutPanel();
            menu_panel1.SuspendLayout();
            this.display_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu_panel1
            // 
            menu_panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            menu_panel1.AutoScroll = true;
            menu_panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            menu_panel1.Controls.Add(this.dictionaryManagement_button);
            menu_panel1.Controls.Add(this.vehicleManagement_button);
            menu_panel1.Controls.Add(this.courierManagement_button);
            menu_panel1.Controls.Add(this.locationManagement_button);
            menu_panel1.Controls.Add(this.customerManagement_button);
            menu_panel1.Controls.Add(this.orderManagement_button);
            menu_panel1.Controls.Add(this.consignmentManagement_button);
            menu_panel1.Controls.Add(this.parcelManagement_button);
            menu_panel1.Controls.Add(this.courseManagement_button);
            menu_panel1.Controls.Add(this.pickupAssignmentManagement_button);
            menu_panel1.Controls.Add(this.complaintManagement_button);
            menu_panel1.Location = new System.Drawing.Point(3, 3);
            menu_panel1.Name = "menu_panel1";
            menu_panel1.Size = new System.Drawing.Size(146, 341);
            menu_panel1.TabIndex = 0;
            // 
            // dictionaryManagement_button
            // 
            this.dictionaryManagement_button.Location = new System.Drawing.Point(3, 3);
            this.dictionaryManagement_button.Name = "dictionaryManagement_button";
            this.dictionaryManagement_button.Size = new System.Drawing.Size(108, 46);
            this.dictionaryManagement_button.TabIndex = 0;
            this.dictionaryManagement_button.Text = "Dictionaries management";
            this.dictionaryManagement_button.UseVisualStyleBackColor = true;
            this.dictionaryManagement_button.Click += new System.EventHandler(this.DictionaryManagement_Click);
            // 
            // vehicleManagement_button
            // 
            this.vehicleManagement_button.Location = new System.Drawing.Point(3, 55);
            this.vehicleManagement_button.Name = "vehicleManagement_button";
            this.vehicleManagement_button.Size = new System.Drawing.Size(108, 46);
            this.vehicleManagement_button.TabIndex = 1;
            this.vehicleManagement_button.Text = "Vehicles management";
            this.vehicleManagement_button.UseVisualStyleBackColor = true;
            this.vehicleManagement_button.Click += new System.EventHandler(this.VehicleManagement_Click);
            // 
            // courierManagement_button
            // 
            this.courierManagement_button.Location = new System.Drawing.Point(3, 107);
            this.courierManagement_button.Name = "courierManagement_button";
            this.courierManagement_button.Size = new System.Drawing.Size(108, 46);
            this.courierManagement_button.TabIndex = 2;
            this.courierManagement_button.Text = "Couriers management";
            this.courierManagement_button.UseVisualStyleBackColor = true;
            this.courierManagement_button.Click += new System.EventHandler(this.CourierManagement_button_Click);
            // 
            // locationManagement_button
            // 
            this.locationManagement_button.Location = new System.Drawing.Point(3, 159);
            this.locationManagement_button.Name = "locationManagement_button";
            this.locationManagement_button.Size = new System.Drawing.Size(108, 46);
            this.locationManagement_button.TabIndex = 3;
            this.locationManagement_button.Text = "Locations management";
            this.locationManagement_button.UseVisualStyleBackColor = true;
            this.locationManagement_button.Click += new System.EventHandler(this.LocationManagement_button_Click);
            // 
            // customerManagement_button
            // 
            this.customerManagement_button.Location = new System.Drawing.Point(3, 211);
            this.customerManagement_button.Name = "customerManagement_button";
            this.customerManagement_button.Size = new System.Drawing.Size(108, 46);
            this.customerManagement_button.TabIndex = 4;
            this.customerManagement_button.Text = "Customers management";
            this.customerManagement_button.UseVisualStyleBackColor = true;
            this.customerManagement_button.Click += new System.EventHandler(this.CustomerManagement_button_Click);
            // 
            // orderManagement_button
            // 
            this.orderManagement_button.Location = new System.Drawing.Point(3, 263);
            this.orderManagement_button.Name = "orderManagement_button";
            this.orderManagement_button.Size = new System.Drawing.Size(108, 46);
            this.orderManagement_button.TabIndex = 5;
            this.orderManagement_button.Text = "Orders management";
            this.orderManagement_button.UseVisualStyleBackColor = true;
            this.orderManagement_button.Click += new System.EventHandler(this.OrderManagement_button_Click);
            // 
            // consignmentManagement_button
            // 
            this.consignmentManagement_button.Location = new System.Drawing.Point(3, 315);
            this.consignmentManagement_button.Name = "consignmentManagement_button";
            this.consignmentManagement_button.Size = new System.Drawing.Size(108, 46);
            this.consignmentManagement_button.TabIndex = 6;
            this.consignmentManagement_button.Text = "Consignments management";
            this.consignmentManagement_button.UseVisualStyleBackColor = true;
            this.consignmentManagement_button.Click += new System.EventHandler(this.ConsignmentManagement_button_Click);
            // 
            // parcelManagement_button
            // 
            this.parcelManagement_button.Location = new System.Drawing.Point(3, 367);
            this.parcelManagement_button.Name = "parcelManagement_button";
            this.parcelManagement_button.Size = new System.Drawing.Size(108, 46);
            this.parcelManagement_button.TabIndex = 7;
            this.parcelManagement_button.Text = "Parcels management";
            this.parcelManagement_button.UseVisualStyleBackColor = true;
            this.parcelManagement_button.Click += new System.EventHandler(this.ParcelManagement_button_Click);
            // 
            // courseManagement_button
            // 
            this.courseManagement_button.Location = new System.Drawing.Point(3, 419);
            this.courseManagement_button.Name = "courseManagement_button";
            this.courseManagement_button.Size = new System.Drawing.Size(108, 46);
            this.courseManagement_button.TabIndex = 8;
            this.courseManagement_button.Text = "Courses management";
            this.courseManagement_button.UseVisualStyleBackColor = true;
            this.courseManagement_button.Click += new System.EventHandler(this.CourseManagement_button_Click);
            // 
            // pickupAssignmentManagement_button
            // 
            this.pickupAssignmentManagement_button.Location = new System.Drawing.Point(3, 471);
            this.pickupAssignmentManagement_button.Name = "pickupAssignmentManagement_button";
            this.pickupAssignmentManagement_button.Size = new System.Drawing.Size(108, 46);
            this.pickupAssignmentManagement_button.TabIndex = 9;
            this.pickupAssignmentManagement_button.Text = "Pickup requests management";
            this.pickupAssignmentManagement_button.UseVisualStyleBackColor = true;
            this.pickupAssignmentManagement_button.Click += new System.EventHandler(this.PickupAssignmentManagement_button_Click);
            // 
            // complaintManagement_button
            // 
            this.complaintManagement_button.Location = new System.Drawing.Point(3, 523);
            this.complaintManagement_button.Name = "complaintManagement_button";
            this.complaintManagement_button.Size = new System.Drawing.Size(108, 46);
            this.complaintManagement_button.TabIndex = 10;
            this.complaintManagement_button.Text = "Complaint management";
            this.complaintManagement_button.UseVisualStyleBackColor = true;
            this.complaintManagement_button.Click += new System.EventHandler(this.ComplaintManagement_button_Click);
            // 
            // display_panel
            // 
            this.display_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.display_panel.Controls.Add(this.parcelManagementNew_panel);
            this.display_panel.Controls.Add(this.courierManagementNew_panel);
            this.display_panel.Controls.Add(this.locationManagementNew_panel);
            this.display_panel.Controls.Add(this.consignmentManagementNew_panel);
            this.display_panel.Controls.Add(this.orderManagementNew_panel);
            this.display_panel.Controls.Add(this.vehicleManagementNew_panel);
            this.display_panel.Controls.Add(this.complaintManagement_panel);
            this.display_panel.Controls.Add(this.pickupRequestManagement_panel);
            this.display_panel.Controls.Add(this.courseManagementNew_panel);
            this.display_panel.Controls.Add(this.customerManagement_panel);
            this.display_panel.Controls.Add(this.dictionaryManagement_panel);
            this.display_panel.Location = new System.Drawing.Point(155, 3);
            this.display_panel.Name = "display_panel";
            this.display_panel.Size = new System.Drawing.Size(503, 344);
            this.display_panel.TabIndex = 1;
            // 
            // parcelManagementNew_panel
            // 
            this.parcelManagementNew_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.parcelManagementNew_panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.parcelManagementNew_panel.Details_button_disabled = true;
            this.parcelManagementNew_panel.Item_name_plural = "parcels";
            this.parcelManagementNew_panel.Item_name_plural_capital_letter = "Parcels";
            this.parcelManagementNew_panel.Location = new System.Drawing.Point(4, 5);
            this.parcelManagementNew_panel.MainWindowReference = null;
            this.parcelManagementNew_panel.Name = "parcelManagementNew_panel";
            this.parcelManagementNew_panel.Size = new System.Drawing.Size(496, 337);
            this.parcelManagementNew_panel.TabIndex = 16;
            this.parcelManagementNew_panel.Visible = false;
            // 
            // courierManagementNew_panel
            // 
            this.courierManagementNew_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.courierManagementNew_panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.courierManagementNew_panel.Details_button_disabled = true;
            this.courierManagementNew_panel.Item_name_plural = "couriers";
            this.courierManagementNew_panel.Item_name_plural_capital_letter = "Couriers";
            this.courierManagementNew_panel.Location = new System.Drawing.Point(4, 5);
            this.courierManagementNew_panel.MainWindowReference = null;
            this.courierManagementNew_panel.Name = "courierManagementNew_panel";
            this.courierManagementNew_panel.Size = new System.Drawing.Size(496, 337);
            this.courierManagementNew_panel.TabIndex = 15;
            this.courierManagementNew_panel.Visible = false;
            // 
            // locationManagementNew_panel
            // 
            this.locationManagementNew_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.locationManagementNew_panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.locationManagementNew_panel.Details_button_disabled = true;
            this.locationManagementNew_panel.Item_name_plural = "locations";
            this.locationManagementNew_panel.Item_name_plural_capital_letter = "Locations";
            this.locationManagementNew_panel.Location = new System.Drawing.Point(4, 5);
            this.locationManagementNew_panel.MainWindowReference = null;
            this.locationManagementNew_panel.Name = "locationManagementNew_panel";
            this.locationManagementNew_panel.Size = new System.Drawing.Size(496, 337);
            this.locationManagementNew_panel.TabIndex = 14;
            this.locationManagementNew_panel.Visible = false;
            // 
            // consignmentManagementNew_panel
            // 
            this.consignmentManagementNew_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.consignmentManagementNew_panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.consignmentManagementNew_panel.Details_button_disabled = false;
            this.consignmentManagementNew_panel.Item_name_plural = "consignments";
            this.consignmentManagementNew_panel.Item_name_plural_capital_letter = "Consignments";
            this.consignmentManagementNew_panel.Location = new System.Drawing.Point(4, 5);
            this.consignmentManagementNew_panel.MainWindowReference = null;
            this.consignmentManagementNew_panel.Name = "consignmentManagementNew_panel";
            this.consignmentManagementNew_panel.Size = new System.Drawing.Size(496, 337);
            this.consignmentManagementNew_panel.TabIndex = 12;
            this.consignmentManagementNew_panel.Visible = false;
            // 
            // orderManagementNew_panel
            // 
            this.orderManagementNew_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.orderManagementNew_panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.orderManagementNew_panel.Details_button_disabled = true;
            this.orderManagementNew_panel.Item_name_plural = "orders";
            this.orderManagementNew_panel.Item_name_plural_capital_letter = "Orders";
            this.orderManagementNew_panel.Location = new System.Drawing.Point(4, 5);
            this.orderManagementNew_panel.MainWindowReference = null;
            this.orderManagementNew_panel.Name = "orderManagementNew_panel";
            this.orderManagementNew_panel.Size = new System.Drawing.Size(496, 337);
            this.orderManagementNew_panel.TabIndex = 2;
            this.orderManagementNew_panel.Visible = false;
            // 
            // vehicleManagementNew_panel
            // 
            this.vehicleManagementNew_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vehicleManagementNew_panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.vehicleManagementNew_panel.Details_button_disabled = true;
            this.vehicleManagementNew_panel.Item_name_plural = "vehicles";
            this.vehicleManagementNew_panel.Item_name_plural_capital_letter = "Vehicles";
            this.vehicleManagementNew_panel.Location = new System.Drawing.Point(4, 5);
            this.vehicleManagementNew_panel.MainWindowReference = null;
            this.vehicleManagementNew_panel.Name = "vehicleManagementNew_panel";
            this.vehicleManagementNew_panel.Size = new System.Drawing.Size(496, 337);
            this.vehicleManagementNew_panel.TabIndex = 11;
            this.vehicleManagementNew_panel.Visible = false;
            // 
            // complaintManagement_panel
            // 
            this.complaintManagement_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.complaintManagement_panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.complaintManagement_panel.Details_button_disabled = false;
            this.complaintManagement_panel.Item_name_plural = "complaints";
            this.complaintManagement_panel.Item_name_plural_capital_letter = "Complaints";
            this.complaintManagement_panel.Location = new System.Drawing.Point(4, 5);
            this.complaintManagement_panel.MainWindowReference = null;
            this.complaintManagement_panel.Name = "complaintManagement_panel";
            this.complaintManagement_panel.Size = new System.Drawing.Size(496, 337);
            this.complaintManagement_panel.TabIndex = 10;
            this.complaintManagement_panel.Visible = false;
            // 
            // pickupRequestManagement_panel
            // 
            this.pickupRequestManagement_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pickupRequestManagement_panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pickupRequestManagement_panel.Details_button_disabled = false;
            this.pickupRequestManagement_panel.Item_name_plural = "pickup requests";
            this.pickupRequestManagement_panel.Item_name_plural_capital_letter = "Pickup requests";
            this.pickupRequestManagement_panel.Location = new System.Drawing.Point(4, 5);
            this.pickupRequestManagement_panel.MainWindowReference = null;
            this.pickupRequestManagement_panel.Name = "pickupRequestManagement_panel";
            this.pickupRequestManagement_panel.Size = new System.Drawing.Size(496, 337);
            this.pickupRequestManagement_panel.TabIndex = 9;
            this.pickupRequestManagement_panel.Visible = false;
            // 
            // courseManagementNew_panel
            // 
            this.courseManagementNew_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.courseManagementNew_panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.courseManagementNew_panel.Details_button_disabled = false;
            this.courseManagementNew_panel.Item_name_plural = "courses";
            this.courseManagementNew_panel.Item_name_plural_capital_letter = "Courses";
            this.courseManagementNew_panel.Location = new System.Drawing.Point(4, 5);
            this.courseManagementNew_panel.MainWindowReference = null;
            this.courseManagementNew_panel.Name = "courseManagementNew_panel";
            this.courseManagementNew_panel.Size = new System.Drawing.Size(496, 337);
            this.courseManagementNew_panel.TabIndex = 13;
            this.courseManagementNew_panel.Visible = false;
            // 
            // customerManagement_panel
            // 
            this.customerManagement_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customerManagement_panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.customerManagement_panel.Location = new System.Drawing.Point(4, 5);
            this.customerManagement_panel.MainWindowReference = null;
            this.customerManagement_panel.Name = "customerManagement_panel";
            this.customerManagement_panel.Size = new System.Drawing.Size(496, 337);
            this.customerManagement_panel.TabIndex = 5;
            this.customerManagement_panel.Visible = false;
            // 
            // dictionaryManagement_panel
            // 
            this.dictionaryManagement_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dictionaryManagement_panel.AutoScroll = true;
            this.dictionaryManagement_panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.dictionaryManagement_panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dictionaryManagement_panel.Location = new System.Drawing.Point(4, 4);
            this.dictionaryManagement_panel.MainWindowReference = null;
            this.dictionaryManagement_panel.Name = "dictionaryManagement_panel";
            this.dictionaryManagement_panel.Size = new System.Drawing.Size(496, 337);
            this.dictionaryManagement_panel.TabIndex = 0;
            this.dictionaryManagement_panel.Visible = false;
            // 
            // MainDatabaseManagementControler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(menu_panel1);
            this.Controls.Add(this.display_panel);
            this.MinimumSize = new System.Drawing.Size(500, 300);
            this.Name = "MainDatabaseManagementControler";
            this.Size = new System.Drawing.Size(661, 350);
            menu_panel1.ResumeLayout(false);
            this.display_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected internal System.Windows.Forms.Button customerManagement_button;
        protected internal System.Windows.Forms.Button pickupAssignmentManagement_button;
        protected internal System.Windows.Forms.Button orderManagement_button;
        protected internal System.Windows.Forms.Button courierManagement_button;
        protected internal System.Windows.Forms.Button vehicleManagement_button;
        protected internal System.Windows.Forms.Button dictionaryManagement_button;
        protected internal System.Windows.Forms.Button complaintManagement_button;
        protected internal DictionaryManagementControler dictionaryManagement_panel;
        protected internal System.Windows.Forms.Button consignmentManagement_button;
        protected internal CustomerManagementControler customerManagement_panel;
        protected internal System.Windows.Forms.Button locationManagement_button;
        protected internal System.Windows.Forms.Button parcelManagement_button;
        protected internal System.Windows.Forms.Button courseManagement_button;
        protected internal PickupRequestManagementControl pickupRequestManagement_panel;
        protected internal ComplaintManagementControl complaintManagement_panel;
        protected internal System.Windows.Forms.Panel display_panel;
        private ManagementControls.CourseManagementControl_New courseManagementNew_panel;
        protected internal VehicleManagementControler_New vehicleManagementNew_panel;
        protected internal ManagementControls.OrderManagementControl_New orderManagementNew_panel;
        protected internal ManagementControls.ConsignmentManagementControl_New consignmentManagementNew_panel;
        protected internal ManagementControls.LocationManagementControl_New locationManagementNew_panel;
        protected internal ManagementControls.CourierManagementControl_New courierManagementNew_panel;
        protected internal ManagementControls.ParcelManagementControl_New parcelManagementNew_panel;
    }
}
