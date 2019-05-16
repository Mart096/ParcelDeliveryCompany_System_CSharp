namespace ParcelDeliveryCompany_ClassLibrary1.ManagementControls
{
    partial class CourseManagementControl_New
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
            this.startLocCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.endLocationCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.courierId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.courierFullNameCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.startLocIDCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.endLocIdCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // itemTitle_label
            // 
            this.itemTitle_label.Size = new System.Drawing.Size(60, 17);
            this.itemTitle_label.Text = "Courses";
            // 
            // item_ListView
            // 
            this.item_ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.startLocIDCol,
            this.startLocCol,
            this.endLocIdCol,
            this.endLocationCol,
            this.courierId,
            this.courierFullNameCol});
            // 
            // startLocCol
            // 
            this.startLocCol.Text = "Start location";
            this.startLocCol.Width = 124;
            // 
            // endLocationCol
            // 
            this.endLocationCol.Text = "End location";
            this.endLocationCol.Width = 118;
            // 
            // courierId
            // 
            this.courierId.Text = "Courier\'s ID";
            this.courierId.Width = 94;
            // 
            // courierFullNameCol
            // 
            this.courierFullNameCol.Text = "Assigned courier";
            this.courierFullNameCol.Width = 97;
            // 
            // startLocIDCol
            // 
            this.startLocIDCol.Text = "Start location ID";
            this.startLocIDCol.Width = 98;
            // 
            // endLocIdCol
            // 
            this.endLocIdCol.Text = "End locaction ID";
            this.endLocIdCol.Width = 96;
            // 
            // CourseManagementControl_New
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "CourseManagementControl_New";
            this.Controls.SetChildIndex(this.item_ListView, 0);
            this.Controls.SetChildIndex(this.itemTitle_label, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader startLocCol;
        private System.Windows.Forms.ColumnHeader endLocationCol;
        private System.Windows.Forms.ColumnHeader courierId;
        private System.Windows.Forms.ColumnHeader courierFullNameCol;
        private System.Windows.Forms.ColumnHeader startLocIDCol;
        private System.Windows.Forms.ColumnHeader endLocIdCol;
    }
}
