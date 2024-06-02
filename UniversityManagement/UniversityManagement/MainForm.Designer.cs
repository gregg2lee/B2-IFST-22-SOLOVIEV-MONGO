namespace UniversityManagement
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnCourseRegistration;
        private System.Windows.Forms.Button btnCourseManagement;
        private System.Windows.Forms.Button btnProfessorAssignment;
        private System.Windows.Forms.Button btnStudentManagement;

        private void InitializeComponent()
        {
            this.btnCourseRegistration = new System.Windows.Forms.Button();
            this.btnCourseManagement = new System.Windows.Forms.Button();
            this.btnProfessorAssignment = new System.Windows.Forms.Button();
            this.btnStudentManagement = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // btnCourseRegistration
            this.btnCourseRegistration.Location = new System.Drawing.Point(12, 12);
            this.btnCourseRegistration.Name = "btnCourseRegistration";
            this.btnCourseRegistration.Size = new System.Drawing.Size(180, 23);
            this.btnCourseRegistration.TabIndex = 0;
            this.btnCourseRegistration.Text = "Course Registration";
            this.btnCourseRegistration.UseVisualStyleBackColor = true;
            this.btnCourseRegistration.Click += new System.EventHandler(this.btnCourseRegistration_Click);

            // btnCourseManagement
            this.btnCourseManagement.Location = new System.Drawing.Point(12, 41);
            this.btnCourseManagement.Name = "btnCourseManagement";
            this.btnCourseManagement.Size = new System.Drawing.Size(180, 23);
            this.btnCourseManagement.TabIndex = 1;
            this.btnCourseManagement.Text = "Course Management";
            this.btnCourseManagement.UseVisualStyleBackColor = true;
            this.btnCourseManagement.Click += new System.EventHandler(this.btnCourseManagement_Click);

            // btnProfessorAssignment
            this.btnProfessorAssignment.Location = new System.Drawing.Point(12, 70);
            this.btnProfessorAssignment.Name = "btnProfessorAssignment";
            this.btnProfessorAssignment.Size = new System.Drawing.Size(180, 23);
            this.btnProfessorAssignment.TabIndex = 2;
            this.btnProfessorAssignment.Text = "Professor Assignment";
            this.btnProfessorAssignment.UseVisualStyleBackColor = true;
            this.btnProfessorAssignment.Click += new System.EventHandler(this.btnProfessorAssignment_Click);

            // btnStudentManagement
            this.btnStudentManagement.Location = new System.Drawing.Point(12, 99);
            this.btnStudentManagement.Name = "btnStudentManagement";
            this.btnStudentManagement.Size = new System.Drawing.Size(180, 23);
            this.btnStudentManagement.TabIndex = 3;
            this.btnStudentManagement.Text = "Student Management";
            this.btnStudentManagement.UseVisualStyleBackColor = true;
            this.btnStudentManagement.Click += new System.EventHandler(this.btnStudentManagement_Click);

            // MainForm
            this.ClientSize = new System.Drawing.Size(204, 134);
            this.Controls.Add(this.btnCourseRegistration);
            this.Controls.Add(this.btnCourseManagement);
            this.Controls.Add(this.btnProfessorAssignment);
            this.Controls.Add(this.btnStudentManagement);
            this.Name = "MainForm";
            this.Text = "University Management";
            this.ResumeLayout(false);
        }
    }
}
