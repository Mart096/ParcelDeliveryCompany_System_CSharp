namespace ParcelDeliveryCompanyApplication
{
    partial class ItemManagementControler
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
            System.Windows.Forms.FlowLayoutPanel button_flowLayoutPanel;
            this.addItem_button = new System.Windows.Forms.Button();
            this.itemDetails_button = new System.Windows.Forms.Button();
            this.editItem_button = new System.Windows.Forms.Button();
            this.removeItem_button = new System.Windows.Forms.Button();
            this.refreshList_button = new System.Windows.Forms.Button();
            this.itemTitle_label = new System.Windows.Forms.Label();
            this.item_ListView = new System.Windows.Forms.ListView();
            this.idColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            button_flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            button_flowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_flowLayoutPanel
            // 
            button_flowLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            button_flowLayoutPanel.AutoScroll = true;
            button_flowLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            button_flowLayoutPanel.Controls.Add(this.addItem_button);
            button_flowLayoutPanel.Controls.Add(this.itemDetails_button);
            button_flowLayoutPanel.Controls.Add(this.editItem_button);
            button_flowLayoutPanel.Controls.Add(this.removeItem_button);
            button_flowLayoutPanel.Controls.Add(this.refreshList_button);
            button_flowLayoutPanel.Location = new System.Drawing.Point(6, 20);
            button_flowLayoutPanel.Name = "button_flowLayoutPanel";
            button_flowLayoutPanel.Size = new System.Drawing.Size(461, 62);
            button_flowLayoutPanel.TabIndex = 8;
            button_flowLayoutPanel.WrapContents = false;
            button_flowLayoutPanel.Click += new System.EventHandler(this.RefreshList_button_Click);
            // 
            // addItem_button
            // 
            this.addItem_button.Location = new System.Drawing.Point(3, 3);
            this.addItem_button.Name = "addItem_button";
            this.addItem_button.Size = new System.Drawing.Size(85, 51);
            this.addItem_button.TabIndex = 0;
            this.addItem_button.Text = "Add item";
            this.addItem_button.UseVisualStyleBackColor = true;
            this.addItem_button.Click += new System.EventHandler(this.AddItem_button_Click);
            // 
            // itemDetails_button
            // 
            this.itemDetails_button.Enabled = false;
            this.itemDetails_button.Location = new System.Drawing.Point(94, 3);
            this.itemDetails_button.Name = "itemDetails_button";
            this.itemDetails_button.Size = new System.Drawing.Size(85, 51);
            this.itemDetails_button.TabIndex = 4;
            this.itemDetails_button.Text = "Item details";
            this.itemDetails_button.UseVisualStyleBackColor = true;
            this.itemDetails_button.Click += new System.EventHandler(this.ItemDetails_button_Click);
            // 
            // editItem_button
            // 
            this.editItem_button.Enabled = false;
            this.editItem_button.Location = new System.Drawing.Point(185, 3);
            this.editItem_button.Name = "editItem_button";
            this.editItem_button.Size = new System.Drawing.Size(85, 51);
            this.editItem_button.TabIndex = 1;
            this.editItem_button.Text = "Edit item";
            this.editItem_button.UseVisualStyleBackColor = true;
            this.editItem_button.Click += new System.EventHandler(this.EditItem_button_Click);
            // 
            // removeItem_button
            // 
            this.removeItem_button.Enabled = false;
            this.removeItem_button.Location = new System.Drawing.Point(276, 3);
            this.removeItem_button.Name = "removeItem_button";
            this.removeItem_button.Size = new System.Drawing.Size(85, 51);
            this.removeItem_button.TabIndex = 2;
            this.removeItem_button.Text = "Remove item";
            this.removeItem_button.UseVisualStyleBackColor = true;
            this.removeItem_button.Click += new System.EventHandler(this.RemoveItem_button_Click);
            // 
            // refreshList_button
            // 
            this.refreshList_button.Location = new System.Drawing.Point(367, 3);
            this.refreshList_button.Name = "refreshList_button";
            this.refreshList_button.Size = new System.Drawing.Size(85, 51);
            this.refreshList_button.TabIndex = 3;
            this.refreshList_button.Text = "Refresh list";
            this.refreshList_button.UseVisualStyleBackColor = true;
            this.refreshList_button.Click += new System.EventHandler(this.RefreshList_button_Click);
            // 
            // itemTitle_label
            // 
            this.itemTitle_label.AutoSize = true;
            this.itemTitle_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.itemTitle_label.Location = new System.Drawing.Point(3, 0);
            this.itemTitle_label.Name = "itemTitle_label";
            this.itemTitle_label.Size = new System.Drawing.Size(34, 17);
            this.itemTitle_label.TabIndex = 9;
            this.itemTitle_label.Text = "Item";
            // 
            // item_ListView
            // 
            this.item_ListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.item_ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idColumn});
            this.item_ListView.FullRowSelect = true;
            this.item_ListView.HideSelection = false;
            this.item_ListView.Location = new System.Drawing.Point(6, 88);
            this.item_ListView.MultiSelect = false;
            this.item_ListView.Name = "item_ListView";
            this.item_ListView.Size = new System.Drawing.Size(461, 244);
            this.item_ListView.TabIndex = 7;
            this.item_ListView.UseCompatibleStateImageBehavior = false;
            this.item_ListView.View = System.Windows.Forms.View.Details;
            this.item_ListView.SelectedIndexChanged += new System.EventHandler(this.Item_ListView_SelectedIndexChanged);
            // 
            // idColumn
            // 
            this.idColumn.Text = "ID";
            // 
            // ItemManagementControler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.itemTitle_label);
            this.Controls.Add(this.item_ListView);
            this.Controls.Add(button_flowLayoutPanel);
            this.Name = "ItemManagementControler";
            this.Size = new System.Drawing.Size(470, 335);
            button_flowLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected internal System.Windows.Forms.Label itemTitle_label;
        protected internal System.Windows.Forms.ListView item_ListView;
        protected internal System.Windows.Forms.Button addItem_button;
        protected internal System.Windows.Forms.Button editItem_button;
        protected internal System.Windows.Forms.Button removeItem_button;
        protected internal System.Windows.Forms.Button refreshList_button;
        private System.Windows.Forms.ColumnHeader idColumn;
        protected internal System.Windows.Forms.Button itemDetails_button;
    }
}
