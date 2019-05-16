namespace ParcelDeliveryCompany_ClassLibrary1
{
    partial class LocationAddEditForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.locationTypes_listbox = new System.Windows.Forms.ListBox();
            this.street_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cancel_button = new System.Windows.Forms.Button();
            this.accept_button = new System.Windows.Forms.Button();
            this.city_listbox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.postCode_textBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.houseNumber_numericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.houseNumber_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Location type";
            // 
            // locationTypes_listbox
            // 
            this.locationTypes_listbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.locationTypes_listbox.FormattingEnabled = true;
            this.locationTypes_listbox.Location = new System.Drawing.Point(12, 29);
            this.locationTypes_listbox.Name = "locationTypes_listbox";
            this.locationTypes_listbox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.locationTypes_listbox.Size = new System.Drawing.Size(216, 147);
            this.locationTypes_listbox.TabIndex = 10;
            // 
            // street_textbox
            // 
            this.street_textbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.street_textbox.Location = new System.Drawing.Point(12, 212);
            this.street_textbox.MaxLength = 50;
            this.street_textbox.Name = "street_textbox";
            this.street_textbox.Size = new System.Drawing.Size(266, 20);
            this.street_textbox.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(9, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Street name";
            // 
            // cancel_button
            // 
            this.cancel_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cancel_button.Location = new System.Drawing.Point(112, 369);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(82, 36);
            this.cancel_button.TabIndex = 19;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.Cancel_button_Click);
            // 
            // accept_button
            // 
            this.accept_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.accept_button.Location = new System.Drawing.Point(12, 369);
            this.accept_button.Name = "accept_button";
            this.accept_button.Size = new System.Drawing.Size(94, 36);
            this.accept_button.TabIndex = 18;
            this.accept_button.Text = "Add new location";
            this.accept_button.UseVisualStyleBackColor = true;
            this.accept_button.Click += new System.EventHandler(this.Accept_button_Click);
            // 
            // city_listbox
            // 
            this.city_listbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.city_listbox.FormattingEnabled = true;
            this.city_listbox.Location = new System.Drawing.Point(250, 29);
            this.city_listbox.Name = "city_listbox";
            this.city_listbox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.city_listbox.Size = new System.Drawing.Size(216, 147);
            this.city_listbox.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(247, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "City";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(9, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "House number";
            // 
            // postCode_textBox
            // 
            this.postCode_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.postCode_textBox.Location = new System.Drawing.Point(12, 325);
            this.postCode_textBox.MaxLength = 50;
            this.postCode_textBox.Name = "postCode_textBox";
            this.postCode_textBox.Size = new System.Drawing.Size(266, 20);
            this.postCode_textBox.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(9, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Post code";
            // 
            // houseNumber_numericUpDown
            // 
            this.houseNumber_numericUpDown.Location = new System.Drawing.Point(12, 265);
            this.houseNumber_numericUpDown.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.houseNumber_numericUpDown.Name = "houseNumber_numericUpDown";
            this.houseNumber_numericUpDown.Size = new System.Drawing.Size(266, 20);
            this.houseNumber_numericUpDown.TabIndex = 16;
            // 
            // LocationAddEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 417);
            this.ControlBox = false;
            this.Controls.Add(this.houseNumber_numericUpDown);
            this.Controls.Add(this.postCode_textBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.city_listbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.locationTypes_listbox);
            this.Controls.Add(this.street_textbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.accept_button);
            this.Name = "LocationAddEditForm";
            this.Text = "Add new location";
            ((System.ComponentModel.ISupportInitialize)(this.houseNumber_numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox locationTypes_listbox;
        private System.Windows.Forms.TextBox street_textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Button accept_button;
        private System.Windows.Forms.ListBox city_listbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox postCode_textBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown houseNumber_numericUpDown;
    }
}