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
    public partial class AddExam : Form
    {
        Test _test;
        public readonly TestsRepo _testsRepo;
        int _count = 1;
        public AddExam(TestsRepo testRepo)
        {
            InitializeComponent();
            _testsRepo = testRepo;
        }

        private void AddExam_Load(object sender, EventArgs e)
        {
            _test = new Test();
            _test.Questions = new List<Question>();
            label1.Text = "Add Question " + _count;
            ExamNameBox.Focus();
        }
        private bool checkForError()
        {
            if (String.IsNullOrEmpty(ExamNameBox.Text.Trim())
                || String.IsNullOrEmpty(QuestionBox.Text.Trim()) 
                || String.IsNullOrEmpty(CorrectBox.Text.Trim())
                || String.IsNullOrEmpty(IncorrectBox1.Text.Trim())
                || String.IsNullOrEmpty(IncorrectBox2.Text.Trim())
                || String.IsNullOrEmpty(IncorrectBox3.Text.Trim())) { return true; }
            return false;
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            if (checkForError())
            {
                MessageBox.Show("Empty Strings Detected", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else {
                if (_count == 1)
                {
                    ExamNameBox.ReadOnly = true;
                }
                _test.AddQuestion(new Question()
                {
                    Name = QuestionBox.Text,
                    CorrectAnswer = CorrectBox.Text,
                    InorrectAnswer1 = IncorrectBox1.Text,
                    InorrectAnswer2 = IncorrectBox3.Text,
                    InorrectAnswer3 = IncorrectBox3.Text,
                });
                QuestionBox.Clear();
                CorrectBox.Clear();
                IncorrectBox1.Clear();
                IncorrectBox2.Clear();
                IncorrectBox3.Clear();
                _count++;

                label1.Text = "Add Question " + _count; }
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (checkForError())
            {
                MessageBox.Show("Empty Strings Detected", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                _test.Name = ExamNameBox.Text;
                _test.AddQuestion(new Question()
                {
                    Name = QuestionBox.Text,
                    CorrectAnswer = CorrectBox.Text,
                    InorrectAnswer1 = IncorrectBox1.Text,
                    InorrectAnswer2 = IncorrectBox3.Text,
                    InorrectAnswer3 = IncorrectBox3.Text,
                });
                _testsRepo.AddTest(_test);
                DialogResult = DialogResult.OK;
            }
        }
    }
}
