using System;
using System.Linq;
using System.Windows.Forms;
using MongoDB.Driver;

namespace UniversityManagement
{
    public partial class CourseStudentManagementForm : Form
    {
        private readonly MongoDBService _dbService;

        public CourseStudentManagementForm()
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
                LoadStudents(course.Students);
            }
            else
            {
                MessageBox.Show("Курс не найден!");
            }
        }

        private void LoadStudents(string[] studentIds)
        {
            lstStudents.Items.Clear();
            if (studentIds != null)
            {
                foreach (var studentId in studentIds)
                {
                    var student = _dbService.Students.Find(s => s.Id == studentId).FirstOrDefault();
                    if (student != null)
                    {
                        lstStudents.Items.Add(student.Name);
                    }
                }
            }
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            var courseCode = txtCourseCode.Text;
            var course = _dbService.Courses.Find(c => c.Code == courseCode).FirstOrDefault();

            if (course != null)
            {
                var student = new Student
                {
                    Name = txtStudentName.Text,
                    Marks = txtStudentMarks.Text,
                    Year = int.Parse(txtStudentYear.Text)
                };

                _dbService.Students.InsertOne(student);

                
                if (course.Students == null)
                {
                    course.Students = new string[0];
                }

                
                course.Students = course.Students.Append(student.Id).ToArray();

                
                _dbService.Courses.ReplaceOne(c => c.Id == course.Id, course);

                LoadStudents(course.Students);
            }
            else
            {
                MessageBox.Show("Курс не найден!");
            }
        }


        private void btnRemoveStudent_Click(object sender, EventArgs e)
        {
            var courseCode = txtCourseCode.Text;
            var course = _dbService.Courses.Find(c => c.Code == courseCode).FirstOrDefault();

            if (course != null)
            {
                
                if (lstStudents.SelectedItem != null)
                {
                    var selectedStudentName = lstStudents.SelectedItem.ToString();
                    var student = _dbService.Students.Find(s => s.Name == selectedStudentName).FirstOrDefault();

                    if (student != null)
                    {
                        _dbService.Students.DeleteOne(s => s.Id == student.Id);

                        
                        course.Students = course.Students.Where(s => s != student.Id).ToArray();

                        
                        _dbService.Courses.ReplaceOne(c => c.Id == course.Id, course);

                        LoadStudents(course.Students);
                    }
                    else
                    {
                        MessageBox.Show("Студент не найден!");
                    }
                }
                else
                {
                    MessageBox.Show("Выберите студента для удаления!");
                }
            }
            else
            {
                MessageBox.Show("Курс не найден!");
            }
        }
    }
}
