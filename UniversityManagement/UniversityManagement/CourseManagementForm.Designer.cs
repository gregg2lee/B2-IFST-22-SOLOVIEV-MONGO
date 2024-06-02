namespace UniversityManagement
{
    partial class CourseManagementForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblCourseCode;
        private System.Windows.Forms.TextBox txtCourseCode;
        private System.Windows.Forms.Label lblCourseTitle;
        private System.Windows.Forms.TextBox txtCourseTitle;
        private System.Windows.Forms.Label lblCreditHours;
        private System.Windows.Forms.TextBox txtCreditHours;
        private System.Windows.Forms.Button btnSearchCourse;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Button btnCompleteCourse;

        private void InitializeComponent()
        {
            this.lblCourseCode = new System.Windows.Forms.Label();
            this.txtCourseCode = new System.Windows.Forms.TextBox();
            this.lblCourseTitle = new System.Windows.Forms.Label();
            this.txtCourseTitle = new System.Windows.Forms.TextBox();
            this.lblCreditHours = new System.Windows.Forms.Label();
            this.txtCreditHours = new System.Windows.Forms.TextBox();
            this.btnSearchCourse = new System.Windows.Forms.Button();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.btnCompleteCourse = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // lblCourseCode
            this.lblCourseCode.AutoSize = true;
            this.lblCourseCode.Location = new System.Drawing.Point(12, 15);
            this.lblCourseCode.Name = "lblCourseCode";
            this.lblCourseCode.Size = new System.Drawing.Size(72, 13);
            this.lblCourseCode.TabIndex = 0;
            this.lblCourseCode.Text = "Course Code:";

            // txtCourseCode
            this.txtCourseCode.Location = new System.Drawing.Point(90, 12);
            this.txtCourseCode.Name = "txtCourseCode";
            this.txtCourseCode.Size = new System.Drawing.Size(182, 20);
            this.txtCourseCode.TabIndex = 1;

            // lblCourseTitle
            this.lblCourseTitle.AutoSize = true;
            this.lblCourseTitle.Location = new System.Drawing.Point(12, 45);
            this.lblCourseTitle.Name = "lblCourseTitle";
            this.lblCourseTitle.Size = new System.Drawing.Size(66, 13);
            this.lblCourseTitle.TabIndex = 2;
            this.lblCourseTitle.Text = "Course Title:";

            // txtCourseTitle
            this.txtCourseTitle.Location = new System.Drawing.Point(90, 42);
            this.txtCourseTitle.Name = "txtCourseTitle";
            this.txtCourseTitle.Size = new System.Drawing.Size(182, 20);
            this.txtCourseTitle.TabIndex = 3;

            // lblCreditHours
            this.lblCreditHours.AutoSize = true;
            this.lblCreditHours.Location = new System.Drawing.Point(12, 75);
            this.lblCreditHours.Name = "lblCreditHours";
            this.lblCreditHours.Size = new System.Drawing.Size(69, 13);
            this.lblCreditHours.TabIndex = 4;
            this.lblCreditHours.Text = "Credit Hours:";

            // txtCreditHours
            this.txtCreditHours.Location = new System.Drawing.Point(90, 72);
            this.txtCreditHours.Name = "txtCreditHours";
            this.txtCreditHours.Size = new System.Drawing.Size(182, 20);
            this.txtCreditHours.TabIndex = 5;

            // btnSearchCourse
            this.btnSearchCourse.Location = new System.Drawing.Point(12, 108);
            this.btnSearchCourse.Name = "btnSearchCourse";
            this.btnSearchCourse.Size = new System.Drawing.Size(75, 23);
            this.btnSearchCourse.TabIndex = 6;
            this.btnSearchCourse.Text = "Search";
            this.btnSearchCourse.UseVisualStyleBackColor = true;
            this.btnSearchCourse.Click += new System.EventHandler(this.btnSearchCourse_Click);

            // btnSaveChanges
            this.btnSaveChanges.Location = new System.Drawing.Point(93, 108);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(75, 23);
            this.btnSaveChanges.TabIndex = 7;
            this.btnSaveChanges.Text = "Save";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);

            // btnCompleteCourse
            this.btnCompleteCourse.Location = new System.Drawing.Point(174, 108);
            this.btnCompleteCourse.Name = "btnCompleteCourse";
            this.btnCompleteCourse.Size = new System.Drawing.Size(75, 23);
            this.btnCompleteCourse.TabIndex = 8;
            this.btnCompleteCourse.Text = "Complete";
            this.btnCompleteCourse.UseVisualStyleBackColor = true;
            this.btnCompleteCourse.Click += new System.EventHandler(this.btnCompleteCourse_Click);

            // CourseManagementForm
            this.ClientSize = new System.Drawing.Size(284, 151);
            this.Controls.Add(this.lblCourseCode);
            this.Controls.Add(this.txtCourseCode);
            this.Controls.Add(this.lblCourseTitle);
            this.Controls.Add(this.txtCourseTitle);
            this.Controls.Add(this.lblCreditHours);
            this.Controls.Add(this.txtCreditHours);
            this.Controls.Add(this.btnSearchCourse);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.btnCompleteCourse);
            this.Name = "CourseManagementForm";
            this.Text = "Course Management";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
