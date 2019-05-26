namespace ParcelDeliveryCompany_ClassLibrary1
{
    partial class ComplaintDetailsForm
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
            this.Details_titleLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.updateComplaintState_button = new System.Windows.Forms.Button();
            this.complaintState_listView = new System.Windows.Forms.ListView();
            this.idColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ComplaintState_textbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.complaintRegisrationDate_textbox = new System.Windows.Forms.TextBox();
            this.consigneeID_textBox = new System.Windows.Forms.TextBox();
            this.consigneeFullName_textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.consignmentID_textbox = new System.Windows.Forms.TextBox();
            this.consignmentData_panel = new System.Windows.Forms.Panel();
            this.new_complaint_state_checkBox = new System.Windows.Forms.CheckBox();
            this.new_complaint_state_textBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.consignmentData_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // cancel_button
            // 
            this.cancel_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cancel_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel_button.Location = new System.Drawing.Point(12, 415);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(75, 23);
            this.cancel_button.TabIndex = 9;
            this.cancel_button.Text = "Close";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.Cancel_button_Click);
            // 
            // Details_titleLabel
            // 
            this.Details_titleLabel.AutoSize = true;
            this.Details_titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Details_titleLabel.Location = new System.Drawing.Point(12, 9);
            this.Details_titleLabel.Name = "Details_titleLabel";
            this.Details_titleLabel.Size = new System.Drawing.Size(80, 20);
            this.Details_titleLabel.TabIndex = 10;
            this.Details_titleLabel.Text = "Complaint";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.new_complaint_state_textBox);
            this.panel1.Controls.Add(this.new_complaint_state_checkBox);
            this.panel1.Controls.Add(this.updateComplaintState_button);
            this.panel1.Controls.Add(this.complaintState_listView);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(321, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(251, 357);
            this.panel1.TabIndex = 26;
            // 
            // updateComplaintState_button
            // 
            this.updateComplaintState_button.Enabled = false;
            this.updateComplaintState_button.Location = new System.Drawing.Point(6, 20);
            this.updateComplaintState_button.Name = "updateComplaintState_button";
            this.updateComplaintState_button.Size = new System.Drawing.Size(240, 35);
            this.updateComplaintState_button.TabIndex = 26;
            this.updateComplaintState_button.Text = "Update complaint\'s state";
            this.updateComplaintState_button.UseVisualStyleBackColor = true;
            this.updateComplaintState_button.Click += new System.EventHandler(this.UpdatePickupRequestState_button_Click);
            // 
            // complaintState_listView
            // 
            this.complaintState_listView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.complaintState_listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idColumn,
            this.nameColumn});
            this.complaintState_listView.Location = new System.Drawing.Point(6, 61);
            this.complaintState_listView.Name = "complaintState_listView";
            this.complaintState_listView.Size = new System.Drawing.Size(240, 291);
            this.complaintState_listView.TabIndex = 25;
            this.complaintState_listView.UseCompatibleStateImageBehavior = false;
            this.complaintState_listView.View = System.Windows.Forms.View.Details;
            this.complaintState_listView.SelectedIndexChanged += new System.EventHandler(this.ComplaintState_listView_SelectedIndexChanged);
            // 
            // idColumn
            // 
            this.idColumn.Text = "ID";
            this.idColumn.Width = 52;
            // 
            // nameColumn
            // 
            this.nameColumn.Text = "Pickup state";
            this.nameColumn.Width = 167;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 17);
            this.label7.TabIndex = 22;
            this.label7.Text = "Update complaint\'s state";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(2, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Complaint state";
            // 
            // ComplaintState_textbox
            // 
            this.ComplaintState_textbox.Location = new System.Drawing.Point(5, 191);
            this.ComplaintState_textbox.Name = "ComplaintState_textbox";
            this.ComplaintState_textbox.ReadOnly = true;
            this.ComplaintState_textbox.Size = new System.Drawing.Size(251, 20);
            this.ComplaintState_textbox.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(5, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Complaint registration date";
            // 
            // complaintRegisrationDate_textbox
            // 
            this.complaintRegisrationDate_textbox.Location = new System.Drawing.Point(5, 136);
            this.complaintRegisrationDate_textbox.Name = "complaintRegisrationDate_textbox";
            this.complaintRegisrationDate_textbox.ReadOnly = true;
            this.complaintRegisrationDate_textbox.Size = new System.Drawing.Size(251, 20);
            this.complaintRegisrationDate_textbox.TabIndex = 17;
            // 
            // consigneeID_textBox
            // 
            this.consigneeID_textBox.Location = new System.Drawing.Point(5, 81);
            this.consigneeID_textBox.Name = "consigneeID_textBox";
            this.consigneeID_textBox.ReadOnly = true;
            this.consigneeID_textBox.Size = new System.Drawing.Size(103, 20);
            this.consigneeID_textBox.TabIndex = 11;
            // 
            // consigneeFullName_textbox
            // 
            this.consigneeFullName_textbox.Location = new System.Drawing.Point(113, 81);
            this.consigneeFullName_textbox.Name = "consigneeFullName_textbox";
            this.consigneeFullName_textbox.ReadOnly = true;
            this.consigneeFullName_textbox.Size = new System.Drawing.Size(142, 20);
            this.consigneeFullName_textbox.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(5, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Consignee";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(2, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Consignment ID";
            // 
            // consignmentID_textbox
            // 
            this.consignmentID_textbox.Location = new System.Drawing.Point(5, 26);
            this.consignmentID_textbox.Name = "consignmentID_textbox";
            this.consignmentID_textbox.ReadOnly = true;
            this.consignmentID_textbox.Size = new System.Drawing.Size(251, 20);
            this.consignmentID_textbox.TabIndex = 7;
            // 
            // consignmentData_panel
            // 
            this.consignmentData_panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.consignmentData_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.consignmentData_panel.Controls.Add(this.consignmentID_textbox);
            this.consignmentData_panel.Controls.Add(this.label1);
            this.consignmentData_panel.Controls.Add(this.label2);
            this.consignmentData_panel.Controls.Add(this.consigneeFullName_textbox);
            this.consignmentData_panel.Controls.Add(this.consigneeID_textBox);
            this.consignmentData_panel.Controls.Add(this.complaintRegisrationDate_textbox);
            this.consignmentData_panel.Controls.Add(this.label5);
            this.consignmentData_panel.Controls.Add(this.ComplaintState_textbox);
            this.consignmentData_panel.Controls.Add(this.label4);
            this.consignmentData_panel.Location = new System.Drawing.Point(12, 52);
            this.consignmentData_panel.Name = "consignmentData_panel";
            this.consignmentData_panel.Size = new System.Drawing.Size(287, 357);
            this.consignmentData_panel.TabIndex = 27;
            // 
            // new_complaint_state_checkBox
            // 
            this.new_complaint_state_checkBox.AutoSize = true;
            this.new_complaint_state_checkBox.Location = new System.Drawing.Point(173, 0);
            this.new_complaint_state_checkBox.Name = "new_complaint_state_checkBox";
            this.new_complaint_state_checkBox.Size = new System.Drawing.Size(52, 17);
            this.new_complaint_state_checkBox.TabIndex = 27;
            this.new_complaint_state_checkBox.Text = "Other";
            this.new_complaint_state_checkBox.UseVisualStyleBackColor = true;
            this.new_complaint_state_checkBox.CheckedChanged += new System.EventHandler(this.New_complaint_state_checkBox_CheckedChanged);
            // 
            // new_complaint_state_textBox
            // 
            this.new_complaint_state_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.new_complaint_state_textBox.Location = new System.Drawing.Point(6, 81);
            this.new_complaint_state_textBox.Name = "new_complaint_state_textBox";
            this.new_complaint_state_textBox.Size = new System.Drawing.Size(240, 20);
            this.new_complaint_state_textBox.TabIndex = 28;
            this.new_complaint_state_textBox.Visible = false;
            // 
            // ComplaintDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 450);
            this.ControlBox = false;
            this.Controls.Add(this.consignmentData_panel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Details_titleLabel);
            this.Controls.Add(this.cancel_button);
            this.Name = "ComplaintDetailsForm";
            this.Text = "Details";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.consignmentData_panel.ResumeLayout(false);
            this.consignmentData_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Label Details_titleLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button updateComplaintState_button;
        private System.Windows.Forms.ListView complaintState_listView;
        private System.Windows.Forms.ColumnHeader idColumn;
        private System.Windows.Forms.ColumnHeader nameColumn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ComplaintState_textbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox complaintRegisrationDate_textbox;
        private System.Windows.Forms.TextBox consigneeID_textBox;
        private System.Windows.Forms.TextBox consigneeFullName_textbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox consignmentID_textbox;
        private System.Windows.Forms.Panel consignmentData_panel;
        private System.Windows.Forms.CheckBox new_complaint_state_checkBox;
        private System.Windows.Forms.TextBox new_complaint_state_textBox;
    }
}