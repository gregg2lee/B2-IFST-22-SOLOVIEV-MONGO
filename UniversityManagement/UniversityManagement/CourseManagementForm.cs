using System;
using System.Windows.Forms;
using MongoDB.Driver;

namespace UniversityManagement
{
    public partial class CourseManagementForm : Form
    {
        private readonly MongoDBService _dbService;

        public CourseManagementForm()
        {
            InitializeComponent();
            _dbService = new MongoDBService();
        }

        private void btnSearchCourse_Click(object sender, EventArgs e)
        {
            var courseCode = txtCourseCode.Text;
            var course = _dbService.Courses.Find(c => c.Code == courseCode).FirstOrDefault();

            if (course != null)
            {
                txtCourseTitle.Text = course.Title;
                txtCreditHours.Text = course.CreditHours.ToString();
            }
            else
            {
                MessageBox.Show("Курс не найден!");
            }
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            var courseCode = txtCourseCode.Text;
            var course = _dbService.Courses.Find(c => c.Code == courseCode).FirstOrDefault();

            if (course != null)
            {
                course.Title = txtCourseTitle.Text;
                course.CreditHours = int.Parse(txtCreditHours.Text);
                _dbService.Courses.ReplaceOne(c => c.Code == courseCode, course);
                MessageBox.Show("Информация обновлена!");
            }
            else
            {
                MessageBox.Show("Курс не найден!");
            }
        }

        private void btnCompleteCourse_Click(object sender, EventArgs e)
        {
            var courseCode = txtCourseCode.Text;
            _dbService.Courses.DeleteOne(c => c.Code == courseCode);
            MessageBox.Show("Курс завершен!");
        }
    }
}
