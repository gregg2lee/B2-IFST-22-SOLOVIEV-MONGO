using System;
using System.Windows.Forms;

namespace UniversityManagement
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnCourseRegistration_Click(object sender, EventArgs e)
        {
            var courseRegistrationForm = new CourseRegistrationForm();
            courseRegistrationForm.Show();
        }

        private void btnCourseManagement_Click(object sender, EventArgs e)
        {
            var courseManagementForm = new CourseManagementForm();
            courseManagementForm.Show();
        }

        private void btnProfessorAssignment_Click(object sender, EventArgs e)
        {
            var professorAssignmentForm = new AssignProfessorForm();
            professorAssignmentForm.Show();
        }

        private void btnStudentManagement_Click(object sender, EventArgs e)
        {
            var courseStudentManagementForm = new CourseStudentManagementForm();
            courseStudentManagementForm.Show();
        }
    }
}
