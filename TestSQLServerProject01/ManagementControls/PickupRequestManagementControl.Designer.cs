namespace ParcelDeliveryCompanyApplication
{
    partial class PickupRequestManagementControl
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
            this.orderID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pickupRequestDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pickupRequestState = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.courierID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.courierFullName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // itemTitle_label
            // 
            this.itemTitle_label.Size = new System.Drawing.Size(109, 17);
            this.itemTitle_label.Text = "Pickup requests";
            // 
            // item_ListView
            // 
            this.item_ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.orderID,
            this.pickupRequestDate,
            this.pickupRequestState,
            this.courierID,
            this.courierFullName});
            // 
            // addItem_button
            // 
            this.addItem_button.Text = "Add pickup request";
            // 
            // editItem_button
            // 
            this.editItem_button.Text = "Edit pickup request";
            // 
            // removeItem_button
            // 
            this.removeItem_button.Text = "Remove pickup request";
            // 
            // itemDetails_button
            // 
            this.itemDetails_button.Text = "Pickup request details";
            // 
            // orderID
            // 
            this.orderID.Text = "Order ID";
            this.orderID.Width = 84;
            // 
            // pickupRequestDate
            // 
            this.pickupRequestDate.Text = "Pickup request date";
            this.pickupRequestDate.Width = 115;
            // 
            // pickupRequestState
            // 
            this.pickupRequestState.Text = "Pickup request state";
            this.pickupRequestState.Width = 140;
            // 
            // courierID
            // 
            this.courierID.Text = "Courier ID";
            this.courierID.Width = 87;
            // 
            // courierFullName
            // 
            this.courierFullName.Text = "Courier";
            // 
            // PickupRequestManagementControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "PickupRequestManagementControl";
            this.Controls.SetChildIndex(this.item_ListView, 0);
            this.Controls.SetChildIndex(this.itemTitle_label, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader orderID;
        private System.Windows.Forms.ColumnHeader pickupRequestDate;
        private System.Windows.Forms.ColumnHeader pickupRequestState;
        private System.Windows.Forms.ColumnHeader courierID;
        private System.Windows.Forms.ColumnHeader courierFullName;
    }
}
