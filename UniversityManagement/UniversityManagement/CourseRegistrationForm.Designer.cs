namespace UniversityManagement
{
    partial class CourseRegistrationForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblCourseCode;
        private System.Windows.Forms.TextBox txtCourseCode;
        private System.Windows.Forms.Label lblCourseTitle;
        private System.Windows.Forms.TextBox txtCourseTitle;
        private System.Windows.Forms.Label lblCreditHours;
        private System.Windows.Forms.TextBox txtCreditHours;
        private System.Windows.Forms.Button btnSaveCourse;

        private void InitializeComponent()
        {
            this.lblCourseCode = new System.Windows.Forms.Label();
            this.txtCourseCode = new System.Windows.Forms.TextBox();
            this.lblCourseTitle = new System.Windows.Forms.Label();
            this.txtCourseTitle = new System.Windows.Forms.TextBox();
            this.lblCreditHours = new System.Windows.Forms.Label();
            this.txtCreditHours = new System.Windows.Forms.TextBox();
            this.btnSaveCourse = new System.Windows.Forms.Button();
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

            // btnSaveCourse
            this.btnSaveCourse.Location = new System.Drawing.Point(90, 108);
            this.btnSaveCourse.Name = "btnSaveCourse";
            this.btnSaveCourse.Size = new System.Drawing.Size(182, 23);
            this.btnSaveCourse.TabIndex = 6;
            this.btnSaveCourse.Text = "Save Course";
            this.btnSaveCourse.UseVisualStyleBackColor = true;
            this.btnSaveCourse.Click += new System.EventHandler(this.btnSaveCourse_Click);

            // CourseRegistrationForm
            this.ClientSize = new System.Drawing.Size(284, 151);
            this.Controls.Add(this.lblCourseCode);
            this.Controls.Add(this.txtCourseCode);
            this.Controls.Add(this.lblCourseTitle);
            this.Controls.Add(this.txtCourseTitle);
            this.Controls.Add(this.lblCreditHours);
            this.Controls.Add(this.txtCreditHours);
            this.Controls.Add(this.btnSaveCourse);
            this.Name = "CourseRegistrationForm";
            this.Text = "Course Registration";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
