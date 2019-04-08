namespace TestSQLServerProject01.ManagementControls
{
    partial class ParcelManagementControl_New
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
            this.consignmentColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.weightCatColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sizeCatColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // item_ListView
            // 
            this.item_ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.consignmentColumn,
            this.weightCatColumn,
            this.sizeCatColumn});
            // 
            // consignmentColumn
            // 
            this.consignmentColumn.Text = "Consignment";
            this.consignmentColumn.Width = 140;
            // 
            // weightCatColumn
            // 
            this.weightCatColumn.Text = "Weight category";
            this.weightCatColumn.Width = 115;
            // 
            // sizeCatColumn
            // 
            this.sizeCatColumn.Text = "Size category";
            this.sizeCatColumn.Width = 181;
            // 
            // ParcelManagementControl_New
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "ParcelManagementControl_New";
            this.Controls.SetChildIndex(this.item_ListView, 0);
            this.Controls.SetChildIndex(this.itemTitle_label, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader consignmentColumn;
        private System.Windows.Forms.ColumnHeader weightCatColumn;
        private System.Windows.Forms.ColumnHeader sizeCatColumn;
    }
}
