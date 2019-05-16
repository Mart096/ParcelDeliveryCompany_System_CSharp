namespace ParcelDeliveryCompany_ClassLibrary1
{
    partial class AboutForm
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
            this.close_button = new System.Windows.Forms.Button();
            this.licenseRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // close_button
            // 
            this.close_button.Location = new System.Drawing.Point(12, 270);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(105, 23);
            this.close_button.TabIndex = 0;
            this.close_button.Text = "Close";
            this.close_button.UseVisualStyleBackColor = true;
            this.close_button.Click += new System.EventHandler(this.Close_button_Click);
            // 
            // licenseRichTextBox
            // 
            this.licenseRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.licenseRichTextBox.Location = new System.Drawing.Point(12, 12);
            this.licenseRichTextBox.Name = "licenseRichTextBox";
            this.licenseRichTextBox.ReadOnly = true;
            this.licenseRichTextBox.Size = new System.Drawing.Size(527, 252);
            this.licenseRichTextBox.TabIndex = 0;
            this.licenseRichTextBox.Text = "";
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 305);
            this.ControlBox = false;
            this.Controls.Add(this.licenseRichTextBox);
            this.Controls.Add(this.close_button);
            this.Name = "AboutForm";
            this.Text = "About";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button close_button;
        private System.Windows.Forms.RichTextBox licenseRichTextBox;
    }
}