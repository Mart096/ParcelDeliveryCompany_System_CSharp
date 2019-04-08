namespace TestSQLServerProject01
{
    partial class CourierManagementControl
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.addCourier_button = new System.Windows.Forms.Button();
            this.editCourier_button = new System.Windows.Forms.Button();
            this.removeCourier_button = new System.Windows.Forms.Button();
            this.refresh_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.courier_ListView = new System.Windows.Forms.ListView();
            this.id_column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.couriers_Vehicle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.courier_FirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.courier_LastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.courier_BirthDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.courier_NationalID_Number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.addCourier_button);
            this.flowLayoutPanel1.Controls.Add(this.editCourier_button);
            this.flowLayoutPanel1.Controls.Add(this.removeCourier_button);
            this.flowLayoutPanel1.Controls.Add(this.refresh_button);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 27);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(499, 79);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // addCourier_button
            // 
            this.addCourier_button.Location = new System.Drawing.Point(3, 3);
            this.addCourier_button.Name = "addCourier_button";
            this.addCourier_button.Size = new System.Drawing.Size(100, 56);
            this.addCourier_button.TabIndex = 0;
            this.addCourier_button.Text = "Add new";
            this.addCourier_button.UseVisualStyleBackColor = true;
            this.addCourier_button.Click += new System.EventHandler(this.AddCourier_button_Click);
            // 
            // editCourier_button
            // 
            this.editCourier_button.Enabled = false;
            this.editCourier_button.Location = new System.Drawing.Point(109, 3);
            this.editCourier_button.Name = "editCourier_button";
            this.editCourier_button.Size = new System.Drawing.Size(97, 56);
            this.editCourier_button.TabIndex = 1;
            this.editCourier_button.Text = "Edit selected";
            this.editCourier_button.UseVisualStyleBackColor = true;
            this.editCourier_button.Click += new System.EventHandler(this.EditCourier_button_Click);
            // 
            // removeCourier_button
            // 
            this.removeCourier_button.Enabled = false;
            this.removeCourier_button.Location = new System.Drawing.Point(212, 3);
            this.removeCourier_button.Name = "removeCourier_button";
            this.removeCourier_button.Size = new System.Drawing.Size(97, 56);
            this.removeCourier_button.TabIndex = 2;
            this.removeCourier_button.Text = "Remove selected";
            this.removeCourier_button.UseVisualStyleBackColor = true;
            this.removeCourier_button.Click += new System.EventHandler(this.RemoveCourier_button_Click);
            // 
            // refresh_button
            // 
            this.refresh_button.Location = new System.Drawing.Point(315, 3);
            this.refresh_button.Name = "refresh_button";
            this.refresh_button.Size = new System.Drawing.Size(97, 56);
            this.refresh_button.TabIndex = 3;
            this.refresh_button.Text = "Refresh list";
            this.refresh_button.UseVisualStyleBackColor = true;
            this.refresh_button.Click += new System.EventHandler(this.Refresh_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(0, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Couriers";
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
            this.courier_ListView.Location = new System.Drawing.Point(3, 112);
            this.courier_ListView.MultiSelect = false;
            this.courier_ListView.Name = "courier_ListView";
            this.courier_ListView.Size = new System.Drawing.Size(499, 207);
            this.courier_ListView.TabIndex = 2;
            this.courier_ListView.UseCompatibleStateImageBehavior = false;
            this.courier_ListView.View = System.Windows.Forms.View.Details;
            this.courier_ListView.SelectedIndexChanged += new System.EventHandler(this.Courier_ListView_SelectedIndexChanged);
            // 
            // id_column
            // 
            this.id_column.Text = "ID";
            // 
            // couriers_Vehicle
            // 
            this.couriers_Vehicle.Text = "Vehicle ID";
            this.couriers_Vehicle.Width = 64;
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
            this.courier_BirthDate.Width = 66;
            // 
            // courier_NationalID_Number
            // 
            this.courier_NationalID_Number.Text = "National Identification Number";
            this.courier_NationalID_Number.Width = 162;
            // 
            // CourierManagementControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.courier_ListView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "CourierManagementControl";
            this.Size = new System.Drawing.Size(505, 336);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView courier_ListView;
        private System.Windows.Forms.ColumnHeader id_column;
        private System.Windows.Forms.ColumnHeader couriers_Vehicle;
        private System.Windows.Forms.ColumnHeader courier_FirstName;
        private System.Windows.Forms.ColumnHeader courier_LastName;
        private System.Windows.Forms.ColumnHeader courier_BirthDate;
        private System.Windows.Forms.ColumnHeader courier_NationalID_Number;
        private System.Windows.Forms.Button addCourier_button;
        private System.Windows.Forms.Button editCourier_button;
        private System.Windows.Forms.Button removeCourier_button;
        private System.Windows.Forms.Button refresh_button;
    }
}
