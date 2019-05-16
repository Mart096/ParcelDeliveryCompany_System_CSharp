namespace TestSQLServerProject01
{
    partial class OrderManagementControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.orders_ListView = new System.Windows.Forms.ListView();
            this.id_ColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.courierHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sender_idHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.senderHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.addOrder_button = new System.Windows.Forms.Button();
            this.editOrder_button = new System.Windows.Forms.Button();
            this.removeOrder_button = new System.Windows.Forms.Button();
            this.refresh_button = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Orders";
            // 
            // orders_ListView
            // 
            this.orders_ListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.orders_ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id_ColumnHeader,
            this.courierHeader,
            this.sender_idHeader,
            this.senderHeader});
            this.orders_ListView.FullRowSelect = true;
            this.orders_ListView.HideSelection = false;
            this.orders_ListView.Location = new System.Drawing.Point(6, 94);
            this.orders_ListView.MultiSelect = false;
            this.orders_ListView.Name = "orders_ListView";
            this.orders_ListView.Size = new System.Drawing.Size(439, 184);
            this.orders_ListView.TabIndex = 1;
            this.orders_ListView.UseCompatibleStateImageBehavior = false;
            this.orders_ListView.View = System.Windows.Forms.View.Details;
            this.orders_ListView.SelectedIndexChanged += new System.EventHandler(this.Orders_ListView_SelectedIndexChanged);
            // 
            // id_ColumnHeader
            // 
            this.id_ColumnHeader.Text = "ID";
            // 
            // courierHeader
            // 
            this.courierHeader.Text = "Assigned Courier ID";
            this.courierHeader.Width = 107;
            // 
            // sender_idHeader
            // 
            this.sender_idHeader.Text = "Sender ID";
            this.sender_idHeader.Width = 87;
            // 
            // senderHeader
            // 
            this.senderHeader.Text = "Sender";
            this.senderHeader.Width = 130;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.addOrder_button);
            this.flowLayoutPanel1.Controls.Add(this.editOrder_button);
            this.flowLayoutPanel1.Controls.Add(this.removeOrder_button);
            this.flowLayoutPanel1.Controls.Add(this.refresh_button);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 19);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(439, 69);
            this.flowLayoutPanel1.TabIndex = 2;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // addOrder_button
            // 
            this.addOrder_button.Location = new System.Drawing.Point(3, 3);
            this.addOrder_button.Name = "addOrder_button";
            this.addOrder_button.Size = new System.Drawing.Size(80, 46);
            this.addOrder_button.TabIndex = 0;
            this.addOrder_button.Text = "Add new";
            this.addOrder_button.UseVisualStyleBackColor = true;
            this.addOrder_button.Click += new System.EventHandler(this.AddOrder_button_Click);
            // 
            // editOrder_button
            // 
            this.editOrder_button.Enabled = false;
            this.editOrder_button.Location = new System.Drawing.Point(89, 3);
            this.editOrder_button.Name = "editOrder_button";
            this.editOrder_button.Size = new System.Drawing.Size(80, 46);
            this.editOrder_button.TabIndex = 1;
            this.editOrder_button.Text = "Edit";
            this.editOrder_button.UseVisualStyleBackColor = true;
            this.editOrder_button.Click += new System.EventHandler(this.EditOrder_button_Click);
            // 
            // removeOrder_button
            // 
            this.removeOrder_button.Enabled = false;
            this.removeOrder_button.Location = new System.Drawing.Point(175, 3);
            this.removeOrder_button.Name = "removeOrder_button";
            this.removeOrder_button.Size = new System.Drawing.Size(80, 46);
            this.removeOrder_button.TabIndex = 2;
            this.removeOrder_button.Text = "Remove";
            this.removeOrder_button.UseVisualStyleBackColor = true;
            this.removeOrder_button.Click += new System.EventHandler(this.RemoveOrder_button_Click);
            // 
            // refresh_button
            // 
            this.refresh_button.Location = new System.Drawing.Point(261, 3);
            this.refresh_button.Name = "refresh_button";
            this.refresh_button.Size = new System.Drawing.Size(80, 46);
            this.refresh_button.TabIndex = 3;
            this.refresh_button.Text = "Refresh";
            this.refresh_button.UseVisualStyleBackColor = true;
            this.refresh_button.Click += new System.EventHandler(this.Refresh_button_Click);
            // 
            // OrderManagementControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.orders_ListView);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Name = "OrderManagementControl";
            this.Size = new System.Drawing.Size(448, 281);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView orders_ListView;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button addOrder_button;
        private System.Windows.Forms.Button editOrder_button;
        private System.Windows.Forms.Button removeOrder_button;
        private System.Windows.Forms.Button refresh_button;
        private System.Windows.Forms.ColumnHeader id_ColumnHeader;
        private System.Windows.Forms.ColumnHeader sender_idHeader;
        private System.Windows.Forms.ColumnHeader courierHeader;
        private System.Windows.Forms.ColumnHeader senderHeader;
    }
}
