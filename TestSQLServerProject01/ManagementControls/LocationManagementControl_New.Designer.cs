namespace TestSQLServerProject01.ManagementControls
{
    partial class LocationManagementControl_New
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
            this.locationTypeColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.idColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cityColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.streetColumnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.houseNumberColumnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.postCodecolumnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // itemTitle_label
            // 
            this.itemTitle_label.Size = new System.Drawing.Size(69, 17);
            this.itemTitle_label.Text = "Locations";
            // 
            // item_ListView
            // 
            this.item_ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idColumn,
            this.locationTypeColumn,
            this.cityColumn,
            this.streetColumnHeader1,
            this.houseNumberColumnHeader1,
            this.postCodecolumnHeader2});
            // 
            // addItem_button
            // 
            this.addItem_button.Text = "Add location";
            // 
            // editItem_button
            // 
            this.editItem_button.Text = "Edit location";
            // 
            // removeItem_button
            // 
            this.removeItem_button.Text = "Remove location";
            // 
            // itemDetails_button
            // 
            this.itemDetails_button.Text = "Location details";
            this.itemDetails_button.Visible = false;
            // 
            // locationTypeColumn
            // 
            this.locationTypeColumn.Text = "Location type";
            this.locationTypeColumn.Width = 86;
            // 
            // idColumn
            // 
            this.idColumn.Text = "ID";
            // 
            // cityColumn
            // 
            this.cityColumn.Text = "City";
            // 
            // streetColumnHeader1
            // 
            this.streetColumnHeader1.Text = "Street";
            // 
            // houseNumberColumnHeader1
            // 
            this.houseNumberColumnHeader1.Text = "House number";
            // 
            // postCodecolumnHeader2
            // 
            this.postCodecolumnHeader2.Text = "Post code";
            // 
            // LocationManagementControl_New
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "LocationManagementControl_New";
            this.Controls.SetChildIndex(this.item_ListView, 0);
            this.Controls.SetChildIndex(this.itemTitle_label, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader locationTypeColumn;
        private System.Windows.Forms.ColumnHeader idColumn;
        private System.Windows.Forms.ColumnHeader cityColumn;
        private System.Windows.Forms.ColumnHeader streetColumnHeader1;
        private System.Windows.Forms.ColumnHeader houseNumberColumnHeader1;
        private System.Windows.Forms.ColumnHeader postCodecolumnHeader2;
    }
}
