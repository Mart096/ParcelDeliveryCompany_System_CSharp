namespace ParcelDeliveryCompanyApplication
{
    partial class DictionaryAddRecordForm
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
            this.accept_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.newRecordValueColumn_label = new System.Windows.Forms.Label();
            this.newRecordValue_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // accept_button
            // 
            this.accept_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.accept_button.Location = new System.Drawing.Point(12, 66);
            this.accept_button.Name = "accept_button";
            this.accept_button.Size = new System.Drawing.Size(75, 23);
            this.accept_button.TabIndex = 0;
            this.accept_button.Text = "Accept";
            this.accept_button.UseVisualStyleBackColor = true;
            this.accept_button.Click += new System.EventHandler(this.Accept_button_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cancel_button.Location = new System.Drawing.Point(93, 66);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(75, 23);
            this.cancel_button.TabIndex = 1;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.Cancel_button_Click);
            // 
            // newRecordValueColumn_label
            // 
            this.newRecordValueColumn_label.AutoSize = true;
            this.newRecordValueColumn_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.newRecordValueColumn_label.Location = new System.Drawing.Point(13, 13);
            this.newRecordValueColumn_label.Name = "newRecordValueColumn_label";
            this.newRecordValueColumn_label.Size = new System.Drawing.Size(45, 17);
            this.newRecordValueColumn_label.TabIndex = 2;
            this.newRecordValueColumn_label.Text = "Name";
            // 
            // newRecordValue_textBox
            // 
            this.newRecordValue_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newRecordValue_textBox.Location = new System.Drawing.Point(12, 33);
            this.newRecordValue_textBox.Name = "newRecordValue_textBox";
            this.newRecordValue_textBox.Size = new System.Drawing.Size(404, 20);
            this.newRecordValue_textBox.TabIndex = 3;
            // 
            // DictionaryAddRecordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 124);
            this.ControlBox = false;
            this.Controls.Add(this.newRecordValue_textBox);
            this.Controls.Add(this.newRecordValueColumn_label);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.accept_button);
            this.MinimumSize = new System.Drawing.Size(444, 140);
            this.Name = "DictionaryAddRecordForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add new ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button accept_button;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Label newRecordValueColumn_label;
        private System.Windows.Forms.TextBox newRecordValue_textBox;
    }
}