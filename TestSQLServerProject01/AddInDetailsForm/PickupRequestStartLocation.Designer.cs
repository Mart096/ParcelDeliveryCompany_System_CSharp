namespace ParcelDeliveryCompanyApplication.AddInDetailsForm
{
    partial class PickupRequestStartLocation
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
            this.location_ListView = new System.Windows.Forms.ListView();
            this.locationID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.locationType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cityName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.streetName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.houseNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.postCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cancelButton = new System.Windows.Forms.Button();
            this.acceptButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // location_ListView
            // 
            this.location_ListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.location_ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.locationID,
            this.locationType,
            this.cityName,
            this.streetName,
            this.houseNumber,
            this.postCode});
            this.location_ListView.FullRowSelect = true;
            this.location_ListView.HideSelection = false;
            this.location_ListView.Location = new System.Drawing.Point(12, 35);
            this.location_ListView.MultiSelect = false;
            this.location_ListView.Name = "location_ListView";
            this.location_ListView.Size = new System.Drawing.Size(405, 257);
            this.location_ListView.TabIndex = 5;
            this.location_ListView.UseCompatibleStateImageBehavior = false;
            this.location_ListView.View = System.Windows.Forms.View.Details;
            this.location_ListView.SelectedIndexChanged += new System.EventHandler(this.location_ListView_SelectedIndexChanged);
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
            // cityName
            // 
            this.cityName.Text = "City";
            // 
            // streetName
            // 
            this.streetName.Text = "Street";
            this.streetName.Width = 103;
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
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(93, 301);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // acceptButton
            // 
            this.acceptButton.Enabled = false;
            this.acceptButton.Location = new System.Drawing.Point(12, 301);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(75, 23);
            this.acceptButton.TabIndex = 7;
            this.acceptButton.Text = "Accept";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // PickupRequestStartLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 336);
            this.ControlBox = false;
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.location_ListView);
            this.Name = "PickupRequestStartLocation";
            this.Text = "Choose start location";
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.ListView location_ListView;
        private System.Windows.Forms.ColumnHeader locationID;
        private System.Windows.Forms.ColumnHeader locationType;
        private System.Windows.Forms.ColumnHeader cityName;
        private System.Windows.Forms.ColumnHeader streetName;
        private System.Windows.Forms.ColumnHeader houseNumber;
        private System.Windows.Forms.ColumnHeader postCode;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button acceptButton;
    }
}