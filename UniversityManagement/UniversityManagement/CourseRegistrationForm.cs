using System;
using System.Windows.Forms;
using MongoDB.Driver;

namespace UniversityManagement
{
    public partial class CourseRegistrationForm : Form
    {
        private readonly MongoDBService _dbService;

        public CourseRegistrationForm()
        {
            InitializeComponent();
            _dbService = new MongoDBService();
        }

        private void btnSaveCourse_Click(object sender, EventArgs e)
        {
            var courseCode = txtCourseCode.Text;
            var courseTitle = txtCourseTitle.Text;
            var creditHours = int.Parse(txtCreditHours.Text);

            var course = new Course
            {
                Code = courseCode,
                Title = courseTitle,
                CreditHours = creditHours
            };

            _dbService.Courses.InsertOne(course);
            MessageBox.Show("Курс успешно зарегистрирован!");
        }
    }
}
