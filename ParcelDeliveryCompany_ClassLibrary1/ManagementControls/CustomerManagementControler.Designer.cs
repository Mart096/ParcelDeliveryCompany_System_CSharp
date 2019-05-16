namespace ParcelDeliveryCompany_ClassLibrary1
{
    partial class CustomerManagementControler
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
            this.consigneeListView_panel = new System.Windows.Forms.Panel();
            this.customerFilter_button = new System.Windows.Forms.Button();
            this.customerSearch_button = new System.Windows.Forms.Button();
            this.searchCustomer_textBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.customerColumns_listbox = new System.Windows.Forms.ListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.customer_ListView = new System.Windows.Forms.ListView();
            this.id_sender_column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.firstName_column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lastName_column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.street_Column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.houseNum_column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.apartmentNum_column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.city_Column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.postCode_column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.phoneNumber_column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.addnew_button = new System.Windows.Forms.Button();
            this.edit_button = new System.Windows.Forms.Button();
            this.remove_button = new System.Windows.Forms.Button();
            this.refresh_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.consigneeListView_panel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // consigneeListView_panel
            // 
            this.consigneeListView_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.consigneeListView_panel.Controls.Add(this.customerFilter_button);
            this.consigneeListView_panel.Controls.Add(this.customerSearch_button);
            this.consigneeListView_panel.Controls.Add(this.searchCustomer_textBox);
            this.consigneeListView_panel.Controls.Add(this.label13);
            this.consigneeListView_panel.Controls.Add(this.customerColumns_listbox);
            this.consigneeListView_panel.Controls.Add(this.label12);
            this.consigneeListView_panel.Controls.Add(this.customer_ListView);
            this.consigneeListView_panel.Location = new System.Drawing.Point(3, 94);
            this.consigneeListView_panel.Name = "consigneeListView_panel";
            this.consigneeListView_panel.Size = new System.Drawing.Size(570, 264);
            this.consigneeListView_panel.TabIndex = 15;
            // 
            // customerFilter_button
            // 
            this.customerFilter_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customerFilter_button.Enabled = false;
            this.customerFilter_button.Location = new System.Drawing.Point(422, 205);
            this.customerFilter_button.Name = "customerFilter_button";
            this.customerFilter_button.Size = new System.Drawing.Size(102, 23);
            this.customerFilter_button.TabIndex = 11;
            this.customerFilter_button.Text = "Clear filter";
            this.customerFilter_button.UseVisualStyleBackColor = true;
            this.customerFilter_button.Click += new System.EventHandler(this.ClearFilter_button_Click);
            // 
            // customerSearch_button
            // 
            this.customerSearch_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customerSearch_button.Enabled = false;
            this.customerSearch_button.Location = new System.Drawing.Point(422, 175);
            this.customerSearch_button.Name = "customerSearch_button";
            this.customerSearch_button.Size = new System.Drawing.Size(102, 23);
            this.customerSearch_button.TabIndex = 10;
            this.customerSearch_button.Text = "Search";
            this.customerSearch_button.UseVisualStyleBackColor = true;
            this.customerSearch_button.Click += new System.EventHandler(this.CustomerSearch_button_Click);
            // 
            // searchCustomer_textBox
            // 
            this.searchCustomer_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchCustomer_textBox.Location = new System.Drawing.Point(422, 23);
            this.searchCustomer_textBox.Name = "searchCustomer_textBox";
            this.searchCustomer_textBox.Size = new System.Drawing.Size(104, 20);
            this.searchCustomer_textBox.TabIndex = 9;
            this.searchCustomer_textBox.TextChanged += new System.EventHandler(this.SearchCustomer_textBox_TextChanged);
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(419, 6);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 13);
            this.label13.TabIndex = 8;
            this.label13.Text = "Search";
            // 
            // customerColumns_listbox
            // 
            this.customerColumns_listbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customerColumns_listbox.FormattingEnabled = true;
            this.customerColumns_listbox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.customerColumns_listbox.Items.AddRange(new object[] {
            "ID",
            "First name",
            "Last name",
            "Street",
            "City",
            "House number",
            "Apartment number",
            "Post code",
            "Phone number"});
            this.customerColumns_listbox.Location = new System.Drawing.Point(422, 73);
            this.customerColumns_listbox.Name = "customerColumns_listbox";
            this.customerColumns_listbox.Size = new System.Drawing.Size(104, 95);
            this.customerColumns_listbox.TabIndex = 7;
            this.customerColumns_listbox.SelectedIndexChanged += new System.EventHandler(this.CustomerColumns_listbox_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(419, 56);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "Search by";
            // 
            // customer_ListView
            // 
            this.customer_ListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customer_ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id_sender_column,
            this.firstName_column,
            this.lastName_column,
            this.street_Column,
            this.city_Column,
            this.houseNum_column,
            this.apartmentNum_column,
            this.postCode_column,
            this.phoneNumber_column});
            this.customer_ListView.FullRowSelect = true;
            this.customer_ListView.HideSelection = false;
            this.customer_ListView.Location = new System.Drawing.Point(0, 6);
            this.customer_ListView.MultiSelect = false;
            this.customer_ListView.Name = "customer_ListView";
            this.customer_ListView.Size = new System.Drawing.Size(399, 234);
            this.customer_ListView.TabIndex = 5;
            this.customer_ListView.UseCompatibleStateImageBehavior = false;
            this.customer_ListView.View = System.Windows.Forms.View.Details;
            this.customer_ListView.SelectedIndexChanged += new System.EventHandler(this.Customer_ListView_SelectedIndexChanged);
            // 
            // id_sender_column
            // 
            this.id_sender_column.Text = "ID";
            // 
            // firstName_column
            // 
            this.firstName_column.Text = "First name";
            this.firstName_column.Width = 74;
            // 
            // lastName_column
            // 
            this.lastName_column.Text = "Last name";
            this.lastName_column.Width = 76;
            // 
            // street_Column
            // 
            this.street_Column.Text = "Street";
            // 
            // houseNum_column
            // 
            this.houseNum_column.DisplayIndex = 4;
            this.houseNum_column.Text = "House number";
            // 
            // apartmentNum_column
            // 
            this.apartmentNum_column.DisplayIndex = 5;
            this.apartmentNum_column.Text = "Apartment number";
            // 
            // city_Column
            // 
            this.city_Column.DisplayIndex = 6;
            this.city_Column.Text = "City";
            // 
            // postCode_column
            // 
            this.postCode_column.Text = "Post code";
            // 
            // phoneNumber_column
            // 
            this.phoneNumber_column.Text = "Phone number";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.addnew_button);
            this.flowLayoutPanel1.Controls.Add(this.edit_button);
            this.flowLayoutPanel1.Controls.Add(this.remove_button);
            this.flowLayoutPanel1.Controls.Add(this.refresh_button);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 19);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(570, 69);
            this.flowLayoutPanel1.TabIndex = 17;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // addnew_button
            // 
            this.addnew_button.Location = new System.Drawing.Point(3, 3);
            this.addnew_button.Name = "addnew_button";
            this.addnew_button.Size = new System.Drawing.Size(80, 46);
            this.addnew_button.TabIndex = 0;
            this.addnew_button.Text = "Add new";
            this.addnew_button.UseVisualStyleBackColor = true;
            this.addnew_button.Click += new System.EventHandler(this.Addnew_button_Click);
            // 
            // edit_button
            // 
            this.edit_button.Enabled = false;
            this.edit_button.Location = new System.Drawing.Point(89, 3);
            this.edit_button.Name = "edit_button";
            this.edit_button.Size = new System.Drawing.Size(80, 46);
            this.edit_button.TabIndex = 1;
            this.edit_button.Text = "Edit";
            this.edit_button.UseVisualStyleBackColor = true;
            this.edit_button.Click += new System.EventHandler(this.Edit_button_Click);
            // 
            // remove_button
            // 
            this.remove_button.Enabled = false;
            this.remove_button.Location = new System.Drawing.Point(175, 3);
            this.remove_button.Name = "remove_button";
            this.remove_button.Size = new System.Drawing.Size(80, 46);
            this.remove_button.TabIndex = 2;
            this.remove_button.Text = "Remove";
            this.remove_button.UseVisualStyleBackColor = true;
            this.remove_button.Click += new System.EventHandler(this.Remove_button_Click);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Customers";
            // 
            // CustomerManagementControler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.consigneeListView_panel);
            this.Name = "CustomerManagementControler";
            this.Size = new System.Drawing.Size(576, 361);
            this.consigneeListView_panel.ResumeLayout(false);
            this.consigneeListView_panel.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel consigneeListView_panel;
        private System.Windows.Forms.Button customerFilter_button;
        private System.Windows.Forms.Button customerSearch_button;
        private System.Windows.Forms.TextBox searchCustomer_textBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ListBox customerColumns_listbox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ListView customer_ListView;
        private System.Windows.Forms.ColumnHeader id_sender_column;
        private System.Windows.Forms.ColumnHeader firstName_column;
        private System.Windows.Forms.ColumnHeader lastName_column;
        private System.Windows.Forms.ColumnHeader street_Column;
        private System.Windows.Forms.ColumnHeader houseNum_column;
        private System.Windows.Forms.ColumnHeader apartmentNum_column;
        private System.Windows.Forms.ColumnHeader city_Column;
        private System.Windows.Forms.ColumnHeader postCode_column;
        private System.Windows.Forms.ColumnHeader phoneNumber_column;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button addnew_button;
        private System.Windows.Forms.Button edit_button;
        private System.Windows.Forms.Button remove_button;
        private System.Windows.Forms.Button refresh_button;
        private System.Windows.Forms.Label label1;
    }
}
