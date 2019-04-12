namespace ParcelDeliveryCompanyApplication
{
    partial class ComplaintManagementControl
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
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // itemTitle_label
            // 
            this.itemTitle_label.Size = new System.Drawing.Size(77, 17);
            this.itemTitle_label.Text = "Complaints";
            // 
            // item_ListView
            // 
            this.item_ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            // 
            // addItem_button
            // 
            this.addItem_button.Text = "Add complaint";
            // 
            // editItem_button
            // 
            this.editItem_button.Text = "Edit complaint";
            // 
            // removeItem_button
            // 
            this.removeItem_button.Text = "Remove complaint";
            // 
            // itemDetails_button
            // 
            this.itemDetails_button.Text = "Complaint details";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Consignment ID";
            this.columnHeader1.Width = 97;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Complaint registration date";
            this.columnHeader2.Width = 153;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Complaint State";
            this.columnHeader3.Width = 117;
            // 
            // ComplaintManagementControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "ComplaintManagementControl";
            this.Controls.SetChildIndex(this.item_ListView, 0);
            this.Controls.SetChildIndex(this.itemTitle_label, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}
