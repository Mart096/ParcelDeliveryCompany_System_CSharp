namespace TestSQLServerProject01.ManagementControls
{
    partial class ConsignmentManagementControl_New
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
            this.orderIDColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ConsigneeColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pickupStateColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pickupMethodColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.consignmentTypeCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // itemTitle_label
            // 
            this.itemTitle_label.Size = new System.Drawing.Size(97, 17);
            this.itemTitle_label.Text = "Consignments";
            // 
            // item_ListView
            // 
            this.item_ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.orderIDColumn,
            this.ConsigneeColumn,
            this.pickupStateColumn,
            this.pickupMethodColumn,
            this.consignmentTypeCol});
            // 
            // orderIDColumn
            // 
            this.orderIDColumn.Text = "Order ID";
            // 
            // ConsigneeColumn
            // 
            this.ConsigneeColumn.Text = "Consignee";
            this.ConsigneeColumn.Width = 93;
            // 
            // pickupStateColumn
            // 
            this.pickupStateColumn.Text = "Pickup state";
            this.pickupStateColumn.Width = 96;
            // 
            // pickupMethodColumn
            // 
            this.pickupMethodColumn.Text = "Pickup method";
            this.pickupMethodColumn.Width = 100;
            // 
            // consignmentTypeCol
            // 
            this.consignmentTypeCol.Text = "Consignment type";
            this.consignmentTypeCol.Width = 110;
            // 
            // ConsignmentManagementControl_New
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "ConsignmentManagementControl_New";
            this.Controls.SetChildIndex(this.item_ListView, 0);
            this.Controls.SetChildIndex(this.itemTitle_label, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader orderIDColumn;
        private System.Windows.Forms.ColumnHeader ConsigneeColumn;
        private System.Windows.Forms.ColumnHeader pickupStateColumn;
        private System.Windows.Forms.ColumnHeader pickupMethodColumn;
        private System.Windows.Forms.ColumnHeader consignmentTypeCol;
    }
}
