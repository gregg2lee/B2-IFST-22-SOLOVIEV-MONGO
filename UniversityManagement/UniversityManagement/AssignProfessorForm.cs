using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;

namespace UniversityManagement
{
    public partial class AssignProfessorForm : Form
    {
        private readonly MongoDBService _dbService;

        public AssignProfessorForm()
        {
            InitializeComponent();
            _dbService = new MongoDBService();
            LoadProfessors();
        }

        private void LoadProfessors()
        {
            var professors = _dbService.Professors.Find(_ => true).ToList();
            cmbProfessors.DataSource = professors;
            cmbProfessors.DisplayMember = "Name";
            cmbProfessors.ValueMember = "Id";
        }

        private void btnAssignProfessor_Click(object sender, EventArgs e)
        {
            var courseCode = txtCourseCode.Text;
            var professorId = cmbProfessors.SelectedValue.ToString();

            var course = _dbService.Courses.Find(c => c.Code == courseCode).FirstOrDefault();
            if (course != null)
            {
                course.ProfessorId = professorId;
                _dbService.Courses.ReplaceOne(c => c.Code == courseCode, course);
                MessageBox.Show("Профессор привязан к курсу!");
            }
            else
            {
                MessageBox.Show("Курс не найден!");
            }
        }
    }
}

