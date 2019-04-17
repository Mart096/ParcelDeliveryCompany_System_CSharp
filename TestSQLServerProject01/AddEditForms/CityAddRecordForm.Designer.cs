namespace TestSQLServerProject01.AddEditForms
{
    partial class CityAddRecordForm
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
            this.cancel_button = new System.Windows.Forms.Button();
            this.accept_button = new System.Windows.Forms.Button();
            this.newCityArea_label = new System.Windows.Forms.Label();
            this.newCityArea_listBox = new System.Windows.Forms.ListBox();
            this.newCityName_textBox = new System.Windows.Forms.TextBox();
            this.newCityName_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancel_button
            // 
            this.cancel_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cancel_button.Location = new System.Drawing.Point(92, 186);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(75, 23);
            this.cancel_button.TabIndex = 5;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.Cancel_button_Click);
            // 
            // accept_button
            // 
            this.accept_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.accept_button.Location = new System.Drawing.Point(11, 186);
            this.accept_button.Name = "accept_button";
            this.accept_button.Size = new System.Drawing.Size(75, 23);
            this.accept_button.TabIndex = 4;
            this.accept_button.Text = "Accept";
            this.accept_button.UseVisualStyleBackColor = true;
            this.accept_button.Click += new System.EventHandler(this.Accept_button_Click);
            // 
            // newCityArea_label
            // 
            this.newCityArea_label.AutoSize = true;
            this.newCityArea_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.newCityArea_label.Location = new System.Drawing.Point(8, 60);
            this.newCityArea_label.Name = "newCityArea_label";
            this.newCityArea_label.Size = new System.Drawing.Size(103, 17);
            this.newCityArea_label.TabIndex = 28;
            this.newCityArea_label.Text = "New city\'s area";
            // 
            // newCityArea_listBox
            // 
            this.newCityArea_listBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newCityArea_listBox.FormattingEnabled = true;
            this.newCityArea_listBox.Location = new System.Drawing.Point(11, 80);
            this.newCityArea_listBox.Name = "newCityArea_listBox";
            this.newCityArea_listBox.Size = new System.Drawing.Size(205, 95);
            this.newCityArea_listBox.TabIndex = 26;
            // 
            // newCityName_textBox
            // 
            this.newCityName_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newCityName_textBox.Location = new System.Drawing.Point(11, 29);
            this.newCityName_textBox.Name = "newCityName_textBox";
            this.newCityName_textBox.Size = new System.Drawing.Size(205, 20);
            this.newCityName_textBox.TabIndex = 25;
            // 
            // newCityName_label
            // 
            this.newCityName_label.AutoSize = true;
            this.newCityName_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.newCityName_label.Location = new System.Drawing.Point(8, 9);
            this.newCityName_label.Name = "newCityName_label";
            this.newCityName_label.Size = new System.Drawing.Size(70, 17);
            this.newCityName_label.TabIndex = 27;
            this.newCityName_label.Text = "City name";
            // 
            // CityAddRecordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 221);
            this.ControlBox = false;
            this.Controls.Add(this.newCityArea_label);
            this.Controls.Add(this.newCityArea_listBox);
            this.Controls.Add(this.newCityName_textBox);
            this.Controls.Add(this.newCityName_label);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.accept_button);
            this.MinimumSize = new System.Drawing.Size(244, 200);
            this.Name = "CityAddRecordForm";
            this.Text = "Add new cty";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Button accept_button;
        private System.Windows.Forms.Label newCityArea_label;
        private System.Windows.Forms.ListBox newCityArea_listBox;
        private System.Windows.Forms.TextBox newCityName_textBox;
        private System.Windows.Forms.Label newCityName_label;
    }
}