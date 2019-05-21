namespace ParcelDeliveryCompany_ClassLibrary1.DetailsForms
{
    partial class CourseDetailsForm
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
            this.Details_titleLabel = new System.Windows.Forms.Label();
            this.cancel_button = new System.Windows.Forms.Button();
            this.consignmentData_panel = new System.Windows.Forms.Panel();
            this.courseMode_textbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.courierFullName_textBox = new System.Windows.Forms.TextBox();
            this.courierID_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.endPointFullAddress_textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.startPointFullAddress_textbox = new System.Windows.Forms.TextBox();
            this.startPointID_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.endPointID_textbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.departureDT_textBox = new System.Windows.Forms.TextBox();
            this.arrivalDT_textBox = new System.Windows.Forms.TextBox();
            this.courseConsignmentsManagement_panel = new ParcelDeliveryCompany_ClassLibrary1.ManagementControls.CourseConsignmentsManagementControl();
            this.parcelManagement_Controler = new ParcelDeliveryCompany_ClassLibrary1.ParcelManagementControler();
            this.consignmentData_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Details_titleLabel
            // 
            this.Details_titleLabel.AutoSize = true;
            this.Details_titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Details_titleLabel.Location = new System.Drawing.Point(12, 9);
            this.Details_titleLabel.Name = "Details_titleLabel";
            this.Details_titleLabel.Size = new System.Drawing.Size(60, 20);
            this.Details_titleLabel.TabIndex = 26;
            this.Details_titleLabel.Text = "Course";
            // 
            // cancel_button
            // 
            this.cancel_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cancel_button.Location = new System.Drawing.Point(12, 438);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(75, 23);
            this.cancel_button.TabIndex = 25;
            this.cancel_button.Text = "Close";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.Cancel_button_Click);
            // 
            // consignmentData_panel
            // 
            this.consignmentData_panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.consignmentData_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.consignmentData_panel.Controls.Add(this.arrivalDT_textBox);
            this.consignmentData_panel.Controls.Add(this.departureDT_textBox);
            this.consignmentData_panel.Controls.Add(this.label4);
            this.consignmentData_panel.Controls.Add(this.label6);
            this.consignmentData_panel.Controls.Add(this.courseMode_textbox);
            this.consignmentData_panel.Controls.Add(this.label5);
            this.consignmentData_panel.Controls.Add(this.courierFullName_textBox);
            this.consignmentData_panel.Controls.Add(this.courierID_textbox);
            this.consignmentData_panel.Controls.Add(this.label1);
            this.consignmentData_panel.Controls.Add(this.endPointFullAddress_textbox);
            this.consignmentData_panel.Controls.Add(this.label2);
            this.consignmentData_panel.Controls.Add(this.startPointFullAddress_textbox);
            this.consignmentData_panel.Controls.Add(this.startPointID_textBox);
            this.consignmentData_panel.Controls.Add(this.label3);
            this.consignmentData_panel.Controls.Add(this.endPointID_textbox);
            this.consignmentData_panel.Location = new System.Drawing.Point(12, 32);
            this.consignmentData_panel.Name = "consignmentData_panel";
            this.consignmentData_panel.Size = new System.Drawing.Size(283, 400);
            this.consignmentData_panel.TabIndex = 27;
            // 
            // courseMode_textbox
            // 
            this.courseMode_textbox.Location = new System.Drawing.Point(3, 220);
            this.courseMode_textbox.Name = "courseMode_textbox";
            this.courseMode_textbox.ReadOnly = true;
            this.courseMode_textbox.Size = new System.Drawing.Size(252, 20);
            this.courseMode_textbox.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(2, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Course mode";
            // 
            // courierFullName_textBox
            // 
            this.courierFullName_textBox.Location = new System.Drawing.Point(95, 26);
            this.courierFullName_textBox.Name = "courierFullName_textBox";
            this.courierFullName_textBox.ReadOnly = true;
            this.courierFullName_textBox.Size = new System.Drawing.Size(160, 20);
            this.courierFullName_textBox.TabIndex = 20;
            // 
            // courierID_textbox
            // 
            this.courierID_textbox.Location = new System.Drawing.Point(3, 26);
            this.courierID_textbox.Name = "courierID_textbox";
            this.courierID_textbox.ReadOnly = true;
            this.courierID_textbox.Size = new System.Drawing.Size(86, 20);
            this.courierID_textbox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(2, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Courier";
            // 
            // endPointFullAddress_textbox
            // 
            this.endPointFullAddress_textbox.Location = new System.Drawing.Point(95, 138);
            this.endPointFullAddress_textbox.Name = "endPointFullAddress_textbox";
            this.endPointFullAddress_textbox.ReadOnly = true;
            this.endPointFullAddress_textbox.Size = new System.Drawing.Size(160, 20);
            this.endPointFullAddress_textbox.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(2, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Start point";
            // 
            // startPointFullAddress_textbox
            // 
            this.startPointFullAddress_textbox.Location = new System.Drawing.Point(95, 81);
            this.startPointFullAddress_textbox.Name = "startPointFullAddress_textbox";
            this.startPointFullAddress_textbox.ReadOnly = true;
            this.startPointFullAddress_textbox.Size = new System.Drawing.Size(160, 20);
            this.startPointFullAddress_textbox.TabIndex = 18;
            // 
            // startPointID_textBox
            // 
            this.startPointID_textBox.Location = new System.Drawing.Point(3, 81);
            this.startPointID_textBox.Name = "startPointID_textBox";
            this.startPointID_textBox.ReadOnly = true;
            this.startPointID_textBox.Size = new System.Drawing.Size(85, 20);
            this.startPointID_textBox.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(2, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "End point";
            // 
            // endPointID_textbox
            // 
            this.endPointID_textbox.Location = new System.Drawing.Point(3, 138);
            this.endPointID_textbox.Name = "endPointID_textbox";
            this.endPointID_textbox.ReadOnly = true;
            this.endPointID_textbox.Size = new System.Drawing.Size(85, 20);
            this.endPointID_textbox.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(2, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 17);
            this.label4.TabIndex = 37;
            this.label4.Text = "Arrival date time";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(2, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 17);
            this.label6.TabIndex = 35;
            this.label6.Text = "Departure date time";
            // 
            // departureDT_textBox
            // 
            this.departureDT_textBox.Location = new System.Drawing.Point(3, 280);
            this.departureDT_textBox.Name = "departureDT_textBox";
            this.departureDT_textBox.ReadOnly = true;
            this.departureDT_textBox.Size = new System.Drawing.Size(252, 20);
            this.departureDT_textBox.TabIndex = 38;
            // 
            // arrivalDT_textBox
            // 
            this.arrivalDT_textBox.Location = new System.Drawing.Point(3, 323);
            this.arrivalDT_textBox.Name = "arrivalDT_textBox";
            this.arrivalDT_textBox.ReadOnly = true;
            this.arrivalDT_textBox.Size = new System.Drawing.Size(252, 20);
            this.arrivalDT_textBox.TabIndex = 39;
            // 
            // courseConsignmentsManagement_panel
            // 
            this.courseConsignmentsManagement_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.courseConsignmentsManagement_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.courseConsignmentsManagement_panel.Details_button_disabled = true;
            this.courseConsignmentsManagement_panel.Item_id = 0;
            this.courseConsignmentsManagement_panel.Item_name_plural = "consignments";
            this.courseConsignmentsManagement_panel.Item_name_plural_capital_letter = "Consignments";
            this.courseConsignmentsManagement_panel.Location = new System.Drawing.Point(301, 32);
            this.courseConsignmentsManagement_panel.MainWindowReference = null;
            this.courseConsignmentsManagement_panel.Name = "courseConsignmentsManagement_panel";
            this.courseConsignmentsManagement_panel.Size = new System.Drawing.Size(576, 400);
            this.courseConsignmentsManagement_panel.TabIndex = 29;
            this.courseConsignmentsManagement_panel.UserItem = null;
            // 
            // parcelManagement_Controler
            // 
            this.parcelManagement_Controler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.parcelManagement_Controler.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.parcelManagement_Controler.Location = new System.Drawing.Point(301, 32);
            this.parcelManagement_Controler.MainWindowReference = null;
            this.parcelManagement_Controler.Name = "parcelManagement_Controler";
            this.parcelManagement_Controler.Size = new System.Drawing.Size(576, 400);
            this.parcelManagement_Controler.TabIndex = 28;
            // 
            // CourseDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 473);
            this.ControlBox = false;
            this.Controls.Add(this.courseConsignmentsManagement_panel);
            this.Controls.Add(this.parcelManagement_Controler);
            this.Controls.Add(this.Details_titleLabel);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.consignmentData_panel);
            this.Name = "CourseDetailsForm";
            this.Text = "Details";
            this.consignmentData_panel.ResumeLayout(false);
            this.consignmentData_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ParcelManagementControler parcelManagement_Controler;
        private System.Windows.Forms.Label Details_titleLabel;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Panel consignmentData_panel;
        private System.Windows.Forms.TextBox courierID_textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox endPointFullAddress_textbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox startPointFullAddress_textbox;
        private System.Windows.Forms.TextBox startPointID_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox endPointID_textbox;
        private System.Windows.Forms.TextBox courierFullName_textBox;
        private ManagementControls.CourseConsignmentsManagementControl courseConsignmentsManagement_panel;
        private System.Windows.Forms.TextBox courseMode_textbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox arrivalDT_textBox;
        private System.Windows.Forms.TextBox departureDT_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
    }
}