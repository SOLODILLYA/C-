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
    public partial class SelectExam : Form
    {
        private List<Test> _tests;
        private User _currentUser;
        private GradesRepo _gradesData;
        public SelectExam(List<Test> tests, User user, GradesRepo gradesData)
        {
            InitializeComponent();
            foreach (Test test in tests)
            {
                ExamBox.Items.Add(test.Name);
            }
            _tests = tests;
            _currentUser = user;
            _gradesData = gradesData;
        }

        private void SelectExam_Load(object sender, EventArgs e)
        {

            ExamBox.SelectedIndex = 0;
        }

        private void SelectButton_Click(object sender, EventArgs e)
        {
            var exam = new ExamQuestions(_currentUser, _tests[ExamBox.SelectedIndex], _gradesData);
            exam.ShowDialog();
            DialogResult = DialogResult.OK;
        }
    }
}
