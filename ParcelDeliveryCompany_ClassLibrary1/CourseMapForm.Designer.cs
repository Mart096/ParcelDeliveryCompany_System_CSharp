namespace ParcelDeliveryCompany_ClassLibrary1
{
    partial class CourseMapForm
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
            this.closeButton = new System.Windows.Forms.Button();
            this.mapControler1 = new ParcelDeliveryCompany_ClassLibrary1.MapControler();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.closeButton.Location = new System.Drawing.Point(12, 551);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // mapControler1
            // 
            this.mapControler1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mapControler1.Location = new System.Drawing.Point(12, 12);
            this.mapControler1.MinimumSize = new System.Drawing.Size(797, 507);
            this.mapControler1.Name = "mapControler1";
            this.mapControler1.Size = new System.Drawing.Size(797, 533);
            this.mapControler1.TabIndex = 1;
            // 
            // CourseMapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 586);
            this.ControlBox = false;
            this.Controls.Add(this.mapControler1);
            this.Controls.Add(this.closeButton);
            this.MinimumSize = new System.Drawing.Size(840, 602);
            this.Name = "CourseMapForm";
            this.Text = "Course map";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private ParcelDeliveryCompany_ClassLibrary1.MapControler mapControler1;
    }
}