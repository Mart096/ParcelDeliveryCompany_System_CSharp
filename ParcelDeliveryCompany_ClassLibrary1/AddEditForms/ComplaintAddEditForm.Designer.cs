namespace ParcelDeliveryCompany_ClassLibrary1
{
    partial class ComplaintAddEditForm
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
            this.cancel_button = new System.Windows.Forms.Button();
            this.accept_button = new System.Windows.Forms.Button();
            this.consignment_ListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancel_button
            // 
            this.cancel_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cancel_button.Location = new System.Drawing.Point(112, 313);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(82, 36);
            this.cancel_button.TabIndex = 23;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.Cancel_button_Click);
            // 
            // accept_button
            // 
            this.accept_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.accept_button.Location = new System.Drawing.Point(12, 313);
            this.accept_button.Name = "accept_button";
            this.accept_button.Size = new System.Drawing.Size(94, 36);
            this.accept_button.TabIndex = 22;
            this.accept_button.Text = "Add new complaint";
            this.accept_button.UseVisualStyleBackColor = true;
            this.accept_button.Click += new System.EventHandler(this.Accept_button_Click);
            // 
            // consignment_ListView
            // 
            this.consignment_ListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.consignment_ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader4,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader5,
            this.columnHeader6});
            this.consignment_ListView.FullRowSelect = true;
            this.consignment_ListView.HideSelection = false;
            this.consignment_ListView.Location = new System.Drawing.Point(12, 28);
            this.consignment_ListView.MultiSelect = false;
            this.consignment_ListView.Name = "consignment_ListView";
            this.consignment_ListView.Size = new System.Drawing.Size(588, 279);
            this.consignment_ListView.TabIndex = 24;
            this.consignment_ListView.UseCompatibleStateImageBehavior = false;
            this.consignment_ListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID - Consignment";
            this.columnHeader1.Width = 96;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Order Id";
            this.columnHeader4.Width = 69;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Consignee";
            this.columnHeader2.Width = 71;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Pickup state";
            this.columnHeader3.Width = 88;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Pickup method";
            this.columnHeader5.Width = 95;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Consignment type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 25;
            this.label1.Text = "Consignments";
            // 
            // ComplaintAddEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 361);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.consignment_ListView);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.accept_button);
            this.Name = "ComplaintAddEditForm";
            this.Text = "Add new complaint";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        protected internal System.Windows.Forms.Button cancel_button;
        protected internal System.Windows.Forms.Button accept_button;
        protected internal System.Windows.Forms.ListView consignment_ListView;
        protected internal System.Windows.Forms.Label label1;
    }
}
