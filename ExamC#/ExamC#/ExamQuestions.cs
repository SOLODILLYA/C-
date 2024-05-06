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
    public partial class ExamQuestions : Form
    {
        User _currentUser;
        Test _test;
        int _count = 0;
        int _correctCount = 0;
        GradesRepo _gradesData;
        public ExamQuestions(User user, Test test, GradesRepo gradesData)
        {
            InitializeComponent();
            _test = test;
            _currentUser = user;
            _gradesData = gradesData;
           
        }
        
        private void ExamQuestions_Load(object sender, EventArgs e)
        {
            ExamLabel.Text = $"Exam {_test.Name}";
            QuestionLabel.Text = $"Question {_count + 1}";
            QuestionNameLabel.Text = _test.Questions[0].Name;
            List<string> answers = new List<string>
                {
                    _test.Questions[_count].CorrectAnswer,
                    _test.Questions[_count].InorrectAnswer1,
                    _test.Questions[_count].InorrectAnswer2,
                    _test.Questions[_count].InorrectAnswer3
                };
            Shuffle(answers);
            foreach (string answer in answers)
            {
                Answers.Items.Add(answer);
            }
            Answers.SelectedIndex = 0;

        }

        private void AnswerButton_Click(object sender, EventArgs e)
        {
            _count++;
            if (_test.Questions[_count - 1].CorrectAnswer == Answers.SelectedItem.ToString())
            {
                _correctCount++;
            }
            if (_count == _test.Questions.Count)
            {
                _gradesData.AddGrade(new Grade()
                {
                    Email = _currentUser.Email,
                    Score = (float)_correctCount / _count * 100,
                    Exam = _test.Name
                });
                MessageBox.Show("Exam Finished");
                DialogResult = DialogResult.OK;
            }
            else
            {
                Answers.Items.Clear();
                List<string> answers = new List<string>
                {
                    _test.Questions[_count].CorrectAnswer,
                    _test.Questions[_count].InorrectAnswer1,
                    _test.Questions[_count].InorrectAnswer2,
                    _test.Questions[_count].InorrectAnswer3
                }; 
                Shuffle(answers);
                foreach (string answer in answers)
                {
                    Answers.Items.Add(answer);
                }
                QuestionLabel.Text = $"Question {_count + 1}";
                QuestionNameLabel.Text = _test.Questions[_count].Name;

                Answers.SelectedIndex = 0;
            }
        }

        private void Answers_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < Answers.Items.Count; i++)
            {
                if (i != Answers.SelectedIndex)
                {
                    if (Answers.GetItemChecked(i))
                    {
                        Answers.SetItemChecked(i, false);
                    }
                }
            }
        }

        private void Shuffle<T>(IList<T> list)
        {
            Random rng = new Random();
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }
}
