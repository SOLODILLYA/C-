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
    public partial class Form1 : Form
    {
        private readonly UsersRepo _usersRepo;
        private readonly TestsRepo _testsRepo;
        private readonly GradesRepo _gradesRepo;
        public Form1()
        {
            InitializeComponent();
            _usersRepo = new UsersRepo();
            _testsRepo = new TestsRepo();
            _gradesRepo = new GradesRepo();
            RoleBox.SelectedIndex = 0;
        }

        private void viewYourGradesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(_usersRepo.getCurrentUser().Role != "author")
            {
                MessageBox.Show("You need to be author to create exams", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var addExam = new AddExam(_testsRepo);
                addExam.ShowDialog();
            }
        }

        private void takeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_usersRepo.getCurrentUser().Role != "student")
            {
                MessageBox.Show("You need to be student to take exams", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var exam = new SelectExam(_testsRepo.getTests(), _usersRepo.getCurrentUser(), _gradesRepo);
                exam.ShowDialog();
            }
        }

        private void allGradesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_usersRepo.getCurrentUser().Role != "admin" && _usersRepo.getCurrentUser().Role != "author")
            {
                MessageBox.Show("You need to be admin or author to see all grades", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var gradesList = new GradesForm(_gradesRepo, _usersRepo.getCurrentUser());
                gradesList.ShowDialog();
            }
        }

        private void Login(User user)
        {
            _usersRepo.setCurrentUser(user);
            label2.Text = "Successfuly Logged In";
            label1.Visible = false;
            label3.Visible = false;
            EmailBox.Visible = false;
            PasswordBox.Visible = false;
            RoleBox.Visible = false;
            label2.Location = new System.Drawing.Point(80, 145);
            LoginButton.Visible = false;
            RegisterButton.Visible = false;
        }
        private bool checkForError()
        {
            if (String.IsNullOrEmpty(EmailBox.Text.Trim())
                || String.IsNullOrEmpty(PasswordBox.Text.Trim())) { return true; }
            return false;
        }
        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (checkForError())
            {
                MessageBox.Show("Empty Strings Detected", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                User selectedUser = null;
                try
                {
                    selectedUser = _usersRepo.getUsers().Where(user => user.Email == EmailBox.Text).First();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No user with such email exists", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    selectedUser = null;
                }


                if (selectedUser == null)
                {

                }
                else if (selectedUser.Password != PasswordBox.Text)
                {
                    MessageBox.Show("Incorrect password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Login(selectedUser);
                }

            }
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            if (checkForError())
            {
                MessageBox.Show("Empty Strings Detected", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                User selectedUser = null;
                try
                {
                    selectedUser = _usersRepo.getUsers().Where(user => user.Email == EmailBox.Text).First();
                }
                catch (Exception ex)
                {
                    selectedUser = null;
                    User newUser = new Models.User()
                    {
                        Role = RoleBox.SelectedItem.ToString(),
                        Password = PasswordBox.Text,
                        Email = EmailBox.Text,
                    };
                    _usersRepo.AddUser(newUser);
                    Login(newUser);
                }
                if (selectedUser != null)
                {
                    MessageBox.Show("User with such email already exists", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void yourGradesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_usersRepo.getCurrentUser().Role != "student")
            {
                MessageBox.Show("You need to be student to view your grades", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var gradesList = new GradesForm(_gradesRepo, _usersRepo.getCurrentUser());
                gradesList.ShowDialog();
            }
        }
    }
}
