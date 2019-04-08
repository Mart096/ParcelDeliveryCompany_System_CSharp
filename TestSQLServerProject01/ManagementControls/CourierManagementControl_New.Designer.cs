namespace TestSQLServerProject01.ManagementControls
{
    partial class CourierManagementControl_New
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
            this.vehicleIDColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.firstNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lastNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.birthDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nationalIDNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // itemTitle_label
            // 
            this.itemTitle_label.Size = new System.Drawing.Size(61, 17);
            this.itemTitle_label.Text = "Couriers";
            // 
            // item_ListView
            // 
            this.item_ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.vehicleIDColumn,
            this.firstNameColumn,
            this.lastNameColumn,
            this.birthDate,
            this.nationalIDNumber});
            // 
            // addItem_button
            // 
            this.addItem_button.Text = "Add courier";
            // 
            // editItem_button
            // 
            this.editItem_button.Text = "Edit courier";
            // 
            // removeItem_button
            // 
            this.removeItem_button.Text = "Remove courier";
            // 
            // itemDetails_button
            // 
            this.itemDetails_button.Visible = false;
            // 
            // vehicleIDColumn
            // 
            this.vehicleIDColumn.Text = "Vehicle ID";
            this.vehicleIDColumn.Width = 69;
            // 
            // firstNameColumn
            // 
            this.firstNameColumn.Text = "First name";
            this.firstNameColumn.Width = 77;
            // 
            // lastNameColumn
            // 
            this.lastNameColumn.Text = "Last name";
            this.lastNameColumn.Width = 74;
            // 
            // birthDate
            // 
            this.birthDate.Text = "Birth date";
            // 
            // nationalIDNumber
            // 
            this.nationalIDNumber.Text = "National Identification Number";
            this.nationalIDNumber.Width = 145;
            // 
            // CourierManagementControl_New
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "CourierManagementControl_New";
            this.Controls.SetChildIndex(this.item_ListView, 0);
            this.Controls.SetChildIndex(this.itemTitle_label, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader vehicleIDColumn;
        private System.Windows.Forms.ColumnHeader firstNameColumn;
        private System.Windows.Forms.ColumnHeader lastNameColumn;
        private System.Windows.Forms.ColumnHeader birthDate;
        private System.Windows.Forms.ColumnHeader nationalIDNumber;
    }
}
