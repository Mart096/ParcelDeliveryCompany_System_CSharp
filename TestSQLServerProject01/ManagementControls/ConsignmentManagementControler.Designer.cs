namespace TestSQLServerProject01
{
    partial class ConsignmentManagementControler
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
            this.consignment_ListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.addConsignment_button = new System.Windows.Forms.Button();
            this.details_button = new System.Windows.Forms.Button();
            this.editConsignment_button = new System.Windows.Forms.Button();
            this.removeConsignment_button = new System.Windows.Forms.Button();
            this.refresh_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
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
            this.consignment_ListView.Location = new System.Drawing.Point(3, 98);
            this.consignment_ListView.MultiSelect = false;
            this.consignment_ListView.Name = "consignment_ListView";
            this.consignment_ListView.Size = new System.Drawing.Size(472, 200);
            this.consignment_ListView.TabIndex = 4;
            this.consignment_ListView.UseCompatibleStateImageBehavior = false;
            this.consignment_ListView.View = System.Windows.Forms.View.Details;
            this.consignment_ListView.SelectedIndexChanged += new System.EventHandler(this.Consignment_ListView_SelectedIndexChanged);
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
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.addConsignment_button);
            this.flowLayoutPanel1.Controls.Add(this.details_button);
            this.flowLayoutPanel1.Controls.Add(this.editConsignment_button);
            this.flowLayoutPanel1.Controls.Add(this.removeConsignment_button);
            this.flowLayoutPanel1.Controls.Add(this.refresh_button);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 23);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(472, 69);
            this.flowLayoutPanel1.TabIndex = 5;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // addConsignment_button
            // 
            this.addConsignment_button.Location = new System.Drawing.Point(3, 3);
            this.addConsignment_button.Name = "addConsignment_button";
            this.addConsignment_button.Size = new System.Drawing.Size(80, 46);
            this.addConsignment_button.TabIndex = 0;
            this.addConsignment_button.Text = "Add new";
            this.addConsignment_button.UseVisualStyleBackColor = true;
            this.addConsignment_button.Click += new System.EventHandler(this.AddConsignment_button_Click);
            // 
            // details_button
            // 
            this.details_button.Enabled = false;
            this.details_button.Location = new System.Drawing.Point(89, 3);
            this.details_button.Name = "details_button";
            this.details_button.Size = new System.Drawing.Size(80, 46);
            this.details_button.TabIndex = 4;
            this.details_button.Text = "Details";
            this.details_button.UseVisualStyleBackColor = true;
            this.details_button.Click += new System.EventHandler(this.Details_button_Click);
            // 
            // editConsignment_button
            // 
            this.editConsignment_button.Enabled = false;
            this.editConsignment_button.Location = new System.Drawing.Point(175, 3);
            this.editConsignment_button.Name = "editConsignment_button";
            this.editConsignment_button.Size = new System.Drawing.Size(80, 46);
            this.editConsignment_button.TabIndex = 1;
            this.editConsignment_button.Text = "Edit";
            this.editConsignment_button.UseVisualStyleBackColor = true;
            this.editConsignment_button.Click += new System.EventHandler(this.EditConsignment_button_Click);
            // 
            // removeConsignment_button
            // 
            this.removeConsignment_button.Enabled = false;
            this.removeConsignment_button.Location = new System.Drawing.Point(261, 3);
            this.removeConsignment_button.Name = "removeConsignment_button";
            this.removeConsignment_button.Size = new System.Drawing.Size(80, 46);
            this.removeConsignment_button.TabIndex = 2;
            this.removeConsignment_button.Text = "Remove";
            this.removeConsignment_button.UseVisualStyleBackColor = true;
            this.removeConsignment_button.Click += new System.EventHandler(this.RemoveConsignment_button_Click);
            // 
            // refresh_button
            // 
            this.refresh_button.Location = new System.Drawing.Point(347, 3);
            this.refresh_button.Name = "refresh_button";
            this.refresh_button.Size = new System.Drawing.Size(80, 46);
            this.refresh_button.TabIndex = 3;
            this.refresh_button.Text = "Refresh";
            this.refresh_button.UseVisualStyleBackColor = true;
            this.refresh_button.Click += new System.EventHandler(this.Refresh_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Consignments";
            // 
            // ConsignmentManagementControler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.consignment_ListView);
            this.Controls.Add(this.label1);
            this.Name = "ConsignmentManagementControler";
            this.Size = new System.Drawing.Size(478, 301);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView consignment_ListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button addConsignment_button;
        private System.Windows.Forms.Button editConsignment_button;
        private System.Windows.Forms.Button removeConsignment_button;
        private System.Windows.Forms.Button refresh_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button details_button;
    }
}
