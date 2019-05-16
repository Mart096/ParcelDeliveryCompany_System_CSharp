namespace TestSQLServerProject01
{
    partial class CourseManagementControler
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
            this.label1 = new System.Windows.Forms.Label();
            this.course_ListView = new System.Windows.Forms.ListView();
            this.courseID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.courseStartLocation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.courseEndLocation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.courseAssignedCourierID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.courseAssignedCourier = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.addCourse_button = new System.Windows.Forms.Button();
            this.editCourse_button = new System.Windows.Forms.Button();
            this.removeCourse_button = new System.Windows.Forms.Button();
            this.refreshList_button = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Courses";
            // 
            // course_ListView
            // 
            this.course_ListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.course_ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.courseID,
            this.courseStartLocation,
            this.courseEndLocation,
            this.courseAssignedCourierID,
            this.courseAssignedCourier});
            this.course_ListView.FullRowSelect = true;
            this.course_ListView.HideSelection = false;
            this.course_ListView.Location = new System.Drawing.Point(6, 88);
            this.course_ListView.MultiSelect = false;
            this.course_ListView.Name = "course_ListView";
            this.course_ListView.Size = new System.Drawing.Size(571, 301);
            this.course_ListView.TabIndex = 7;
            this.course_ListView.UseCompatibleStateImageBehavior = false;
            this.course_ListView.View = System.Windows.Forms.View.Details;
            this.course_ListView.SelectedIndexChanged += new System.EventHandler(this.Course_ListView_SelectedIndexChanged);
            // 
            // courseID
            // 
            this.courseID.Text = "ID";
            this.courseID.Width = 79;
            // 
            // courseStartLocation
            // 
            this.courseStartLocation.Text = "Start location";
            this.courseStartLocation.Width = 144;
            // 
            // courseEndLocation
            // 
            this.courseEndLocation.Text = "End location";
            this.courseEndLocation.Width = 103;
            // 
            // courseAssignedCourierID
            // 
            this.courseAssignedCourierID.Text = "Courier\'s ID";
            this.courseAssignedCourierID.Width = 72;
            // 
            // courseAssignedCourier
            // 
            this.courseAssignedCourier.Text = "Assigned Courier";
            this.courseAssignedCourier.Width = 160;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.addCourse_button);
            this.flowLayoutPanel1.Controls.Add(this.editCourse_button);
            this.flowLayoutPanel1.Controls.Add(this.removeCourse_button);
            this.flowLayoutPanel1.Controls.Add(this.refreshList_button);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 20);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(571, 62);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // addCourse_button
            // 
            this.addCourse_button.Location = new System.Drawing.Point(3, 3);
            this.addCourse_button.Name = "addCourse_button";
            this.addCourse_button.Size = new System.Drawing.Size(85, 51);
            this.addCourse_button.TabIndex = 0;
            this.addCourse_button.Text = "Add course";
            this.addCourse_button.UseVisualStyleBackColor = true;
            this.addCourse_button.Click += new System.EventHandler(this.AddCourse_button_Click);
            // 
            // editCourse_button
            // 
            this.editCourse_button.Enabled = false;
            this.editCourse_button.Location = new System.Drawing.Point(94, 3);
            this.editCourse_button.Name = "editCourse_button";
            this.editCourse_button.Size = new System.Drawing.Size(85, 51);
            this.editCourse_button.TabIndex = 1;
            this.editCourse_button.Text = "Edit course";
            this.editCourse_button.UseVisualStyleBackColor = true;
            this.editCourse_button.Click += new System.EventHandler(this.EditCourse_button_Click);
            // 
            // removeCourse_button
            // 
            this.removeCourse_button.Enabled = false;
            this.removeCourse_button.Location = new System.Drawing.Point(185, 3);
            this.removeCourse_button.Name = "removeCourse_button";
            this.removeCourse_button.Size = new System.Drawing.Size(85, 51);
            this.removeCourse_button.TabIndex = 2;
            this.removeCourse_button.Text = "Remove course";
            this.removeCourse_button.UseVisualStyleBackColor = true;
            this.removeCourse_button.Click += new System.EventHandler(this.RemoveCourse_button_Click);
            // 
            // refreshList_button
            // 
            this.refreshList_button.Location = new System.Drawing.Point(276, 3);
            this.refreshList_button.Name = "refreshList_button";
            this.refreshList_button.Size = new System.Drawing.Size(85, 51);
            this.refreshList_button.TabIndex = 3;
            this.refreshList_button.Text = "Refresh list";
            this.refreshList_button.UseVisualStyleBackColor = true;
            this.refreshList_button.Click += new System.EventHandler(this.RefreshList_button_Click_1);
            // 
            // CourseManagementControler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.course_ListView);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "CourseManagementControler";
            this.Size = new System.Drawing.Size(580, 392);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView course_ListView;
        private System.Windows.Forms.ColumnHeader courseID;
        private System.Windows.Forms.ColumnHeader courseStartLocation;
        private System.Windows.Forms.ColumnHeader courseEndLocation;
        private System.Windows.Forms.ColumnHeader courseAssignedCourierID;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button addCourse_button;
        private System.Windows.Forms.Button editCourse_button;
        private System.Windows.Forms.Button removeCourse_button;
        private System.Windows.Forms.Button refreshList_button;
        private System.Windows.Forms.ColumnHeader courseAssignedCourier;
    }
}
