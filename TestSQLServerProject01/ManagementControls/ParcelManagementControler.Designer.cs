namespace TestSQLServerProject01
{
    partial class ParcelManagementControler
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
            this.parcel_listView = new System.Windows.Forms.ListView();
            this.parcelID_column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.parcelsConsignment_column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.parcelsWeightCategory_column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.parcelsSizeCategory_Column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.add_button = new System.Windows.Forms.Button();
            this.edit_button = new System.Windows.Forms.Button();
            this.remove_button = new System.Windows.Forms.Button();
            this.refresh_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // parcel_listView
            // 
            this.parcel_listView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.parcel_listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.parcelID_column,
            this.parcelsConsignment_column,
            this.parcelsWeightCategory_column,
            this.parcelsSizeCategory_Column});
            this.parcel_listView.Location = new System.Drawing.Point(3, 107);
            this.parcel_listView.Name = "parcel_listView";
            this.parcel_listView.Size = new System.Drawing.Size(431, 267);
            this.parcel_listView.TabIndex = 27;
            this.parcel_listView.UseCompatibleStateImageBehavior = false;
            this.parcel_listView.View = System.Windows.Forms.View.Details;
            this.parcel_listView.SelectedIndexChanged += new System.EventHandler(this.Parcel_listView_SelectedIndexChanged);
            // 
            // parcelID_column
            // 
            this.parcelID_column.Text = "ID";
            // 
            // parcelsConsignment_column
            // 
            this.parcelsConsignment_column.Text = "Consignment";
            this.parcelsConsignment_column.Width = 117;
            // 
            // parcelsWeightCategory_column
            // 
            this.parcelsWeightCategory_column.Text = "Weight category";
            this.parcelsWeightCategory_column.Width = 118;
            // 
            // parcelsSizeCategory_Column
            // 
            this.parcelsSizeCategory_Column.Text = "Size category";
            this.parcelsSizeCategory_Column.Width = 187;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.add_button);
            this.flowLayoutPanel1.Controls.Add(this.edit_button);
            this.flowLayoutPanel1.Controls.Add(this.remove_button);
            this.flowLayoutPanel1.Controls.Add(this.refresh_button);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 24);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(431, 77);
            this.flowLayoutPanel1.TabIndex = 28;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(3, 3);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(80, 46);
            this.add_button.TabIndex = 4;
            this.add_button.Text = "Add new";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // edit_button
            // 
            this.edit_button.Enabled = false;
            this.edit_button.Location = new System.Drawing.Point(89, 3);
            this.edit_button.Name = "edit_button";
            this.edit_button.Size = new System.Drawing.Size(80, 46);
            this.edit_button.TabIndex = 5;
            this.edit_button.Text = "Edit";
            this.edit_button.UseVisualStyleBackColor = true;
            this.edit_button.Click += new System.EventHandler(this.Edit_button_Click);
            // 
            // remove_button
            // 
            this.remove_button.Enabled = false;
            this.remove_button.Location = new System.Drawing.Point(175, 3);
            this.remove_button.Name = "remove_button";
            this.remove_button.Size = new System.Drawing.Size(80, 46);
            this.remove_button.TabIndex = 6;
            this.remove_button.Text = "Remove";
            this.remove_button.UseVisualStyleBackColor = true;
            this.remove_button.Click += new System.EventHandler(this.Remove_button_Click);
            // 
            // refresh_button
            // 
            this.refresh_button.Location = new System.Drawing.Point(261, 3);
            this.refresh_button.Name = "refresh_button";
            this.refresh_button.Size = new System.Drawing.Size(80, 46);
            this.refresh_button.TabIndex = 7;
            this.refresh_button.Text = "Refresh";
            this.refresh_button.UseVisualStyleBackColor = true;
            this.refresh_button.Click += new System.EventHandler(this.Refresh_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 29;
            this.label1.Text = "Parcels";
            // 
            // ParcelManagementControler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.parcel_listView);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "ParcelManagementControler";
            this.Size = new System.Drawing.Size(437, 377);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView parcel_listView;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader parcelID_column;
        private System.Windows.Forms.ColumnHeader parcelsConsignment_column;
        private System.Windows.Forms.ColumnHeader parcelsWeightCategory_column;
        private System.Windows.Forms.ColumnHeader parcelsSizeCategory_Column;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button edit_button;
        private System.Windows.Forms.Button remove_button;
        private System.Windows.Forms.Button refresh_button;
    }
}
