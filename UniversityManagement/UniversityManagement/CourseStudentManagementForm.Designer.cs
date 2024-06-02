namespace UniversityManagement
{
    partial class CourseStudentManagementForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblCourseCode;
        private System.Windows.Forms.TextBox txtCourseCode;
        private System.Windows.Forms.Button btnSearchCourse;
        private System.Windows.Forms.ListBox lstStudents;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Label lblStudentMarks;
        private System.Windows.Forms.TextBox txtStudentMarks;
        private System.Windows.Forms.Label lblStudentYear;
        private System.Windows.Forms.TextBox txtStudentYear;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnRemoveStudent;

        private void InitializeComponent()
        {
            this.lblCourseCode = new System.Windows.Forms.Label();
            this.txtCourseCode = new System.Windows.Forms.TextBox();
            this.btnSearchCourse = new System.Windows.Forms.Button();
            this.lstStudents = new System.Windows.Forms.ListBox();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.lblStudentMarks = new System.Windows.Forms.Label();
            this.txtStudentMarks = new System.Windows.Forms.TextBox();
            this.lblStudentYear = new System.Windows.Forms.Label();
            this.txtStudentYear = new System.Windows.Forms.TextBox();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnRemoveStudent = new System.Windows.Forms.Button();
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

            // btnSearchCourse
            this.btnSearchCourse.Location = new System.Drawing.Point(278, 10);
            this.btnSearchCourse.Name = "btnSearchCourse";
            this.btnSearchCourse.Size = new System.Drawing.Size(75, 23);
            this.btnSearchCourse.TabIndex = 2;
            this.btnSearchCourse.Text = "Search";
            this.btnSearchCourse.UseVisualStyleBackColor = true;
            this.btnSearchCourse.Click += new System.EventHandler(this.btnSearchCourse_Click);

            // lstStudents
            this.lstStudents.FormattingEnabled = true;
            this.lstStudents.Location = new System.Drawing.Point(12, 48);
            this.lstStudents.Name = "lstStudents";
            this.lstStudents.Size = new System.Drawing.Size(341, 95);
            this.lstStudents.TabIndex = 3;

            // lblStudentName
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Location = new System.Drawing.Point(12, 155);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(78, 13);
            this.lblStudentName.TabIndex = 4;
            this.lblStudentName.Text = "Student Name:";

            // txtStudentName
            this.txtStudentName.Location = new System.Drawing.Point(96, 152);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(257, 20);
            this.txtStudentName.TabIndex = 5;

            // lblStudentMarks
            this.lblStudentMarks.AutoSize = true;
            this.lblStudentMarks.Location = new System.Drawing.Point(12, 185);
            this.lblStudentMarks.Name = "lblStudentMarks";
            this.lblStudentMarks.Size = new System.Drawing.Size(78, 13);
            this.lblStudentMarks.TabIndex = 6;
            this.lblStudentMarks.Text = "Student Marks:";

            // txtStudentMarks
            this.txtStudentMarks.Location = new System.Drawing.Point(96, 182);
            this.txtStudentMarks.Name = "txtStudentMarks";
            this.txtStudentMarks.Size = new System.Drawing.Size(257, 20);
            this.txtStudentMarks.TabIndex = 7;

            // lblStudentYear
            this.lblStudentYear.AutoSize = true;
            this.lblStudentYear.Location = new System.Drawing.Point(12, 215);
            this.lblStudentYear.Name = "lblStudentYear";
            this.lblStudentYear.Size = new System.Drawing.Size(71, 13);
            this.lblStudentYear.TabIndex = 8;
            this.lblStudentYear.Text = "Student Year:";

            // txtStudentYear
            this.txtStudentYear.Location = new System.Drawing.Point(96, 212);
            this.txtStudentYear.Name = "txtStudentYear";
            this.txtStudentYear.Size = new System.Drawing.Size(257, 20);
            this.txtStudentYear.TabIndex = 9;

            // btnAddStudent
            this.btnAddStudent.Location = new System.Drawing.Point(96, 245);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(75, 23);
            this.btnAddStudent.TabIndex = 10;
            this.btnAddStudent.Text = "Add";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);

            // btnRemoveStudent
            this.btnRemoveStudent.Location = new System.Drawing.Point(178, 245);
            this.btnRemoveStudent.Name = "btnRemoveStudent";
            this.btnRemoveStudent.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveStudent.TabIndex = 11;
            this.btnRemoveStudent.Text = "Remove";
            this.btnRemoveStudent.UseVisualStyleBackColor = true;
            this.btnRemoveStudent.Click += new System.EventHandler(this.btnRemoveStudent_Click);

            // CourseStudentManagementForm
            this.ClientSize = new System.Drawing.Size(365, 280);
            this.Controls.Add(this.lblCourseCode);
            this.Controls.Add(this.txtCourseCode);
            this.Controls.Add(this.btnSearchCourse);
            this.Controls.Add(this.lstStudents);
            this.Controls.Add(this.lblStudentName);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.lblStudentMarks);
            this.Controls.Add(this.txtStudentMarks);
            this.Controls.Add(this.lblStudentYear);
            this.Controls.Add(this.txtStudentYear);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.btnRemoveStudent);
            this.Name = "CourseStudentManagementForm";
            this.Text = "Course Student Management";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
