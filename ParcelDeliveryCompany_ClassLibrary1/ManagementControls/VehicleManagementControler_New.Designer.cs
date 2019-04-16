namespace ParcelDeliveryCompanyApplication
{
    partial class VehicleManagementControler_New
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
            this.vehicleType_ColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.vehicleBrandColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.vehicleModelColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.vehicleRegistrationNumberColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // itemTitle_label
            // 
            this.itemTitle_label.Size = new System.Drawing.Size(54, 17);
            this.itemTitle_label.Text = "Vehicle";
            // 
            // item_ListView
            // 
            this.item_ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.vehicleType_ColumnHeader,
            this.vehicleBrandColumn,
            this.vehicleModelColumn,
            this.vehicleRegistrationNumberColumn});
            // 
            // addItem_button
            // 
            this.addItem_button.Text = "Add vehicle";
            // 
            // editItem_button
            // 
            this.editItem_button.Text = "Edit vehicle";
            // 
            // removeItem_button
            // 
            this.removeItem_button.Text = "Remove vehicle";
            // 
            // itemDetails_button
            // 
            this.itemDetails_button.Text = "Vehicle details";
            this.itemDetails_button.Visible = false;
            // 
            // vehicleType_ColumnHeader
            // 
            this.vehicleType_ColumnHeader.Text = "Vehicle type";
            this.vehicleType_ColumnHeader.Width = 129;
            // 
            // vehicleBrandColumn
            // 
            this.vehicleBrandColumn.Text = "Brand";
            this.vehicleBrandColumn.Width = 87;
            // 
            // vehicleModelColumn
            // 
            this.vehicleModelColumn.Text = "Model name";
            this.vehicleModelColumn.Width = 84;
            // 
            // vehicleRegistrationNumberColumn
            // 
            this.vehicleRegistrationNumberColumn.Text = "Registration number";
            this.vehicleRegistrationNumberColumn.Width = 116;
            // 
            // VehicleManagementControler_New
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "VehicleManagementControler_New";
            this.Controls.SetChildIndex(this.item_ListView, 0);
            this.Controls.SetChildIndex(this.itemTitle_label, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader vehicleType_ColumnHeader;
        private System.Windows.Forms.ColumnHeader vehicleBrandColumn;
        private System.Windows.Forms.ColumnHeader vehicleModelColumn;
        private System.Windows.Forms.ColumnHeader vehicleRegistrationNumberColumn;
    }
}
