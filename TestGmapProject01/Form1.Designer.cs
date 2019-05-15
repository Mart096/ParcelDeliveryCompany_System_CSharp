namespace TestGmapProject01
{
    partial class Form1
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
            this.mapControler1 = new ParcelDeliveryCompany_ClassLibrary1.MapControler();
            this.SuspendLayout();
            // 
            // mapControler1
            // 
            this.mapControler1.Location = new System.Drawing.Point(1, 12);
            this.mapControler1.MinimumSize = new System.Drawing.Size(797, 507);
            this.mapControler1.Name = "mapControler1";
            this.mapControler1.Size = new System.Drawing.Size(797, 507);
            this.mapControler1.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 515);
            this.Controls.Add(this.mapControler1);
            this.MinimumSize = new System.Drawing.Size(813, 527);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private ParcelDeliveryCompany_ClassLibrary1.MapControler mapControler1;
    }
}

