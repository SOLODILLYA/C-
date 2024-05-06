using ExamC_.Models;
using ExamC_.Repos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamC_
{
    public partial class GradesForm : Form
    {
        GradesRepo repo;
        User _currentUser;
        public GradesForm(GradesRepo repo, User currentUser)
        {
            InitializeComponent();
            this.repo = repo;
            _currentUser = currentUser;
        }

        private void GradesForm_Load(object sender, EventArgs e)
        {
            GradesList.Items.Clear();
            if(_currentUser.Role == "admin" ||  _currentUser.Role == "author")
            {
                foreach (Grade grade in repo._gradesData.Grades)
                {
                    GradesList.Items.Add(grade.ToString());
                }
            }
            else
            {
                var grades = repo._gradesData.Grades.Where((grade) => grade.Email == _currentUser.Email).ToList();
                foreach (Grade grade in grades)
                {
                    GradesList.Items.Add(grade.ToString());
                }
            }
        }
    }
}
