using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using HR_App.Models;
using HR_App.Repos;
using HR_App.Interfaces;
namespace HR_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _depsRepos = new DepsRepos();
            _empsRepos = new EmpsRepos();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string depName = DepName.Text.Trim();
            if (string.IsNullOrEmpty(depName))
            {
                MessageBox.Show("No department name was entered.");
                DepName.Focus();
            }
            else
            {
                var newDep = new Department()
                {
                    Id = _depsRepos.GetLastId() + 1,
                    Name = depName
                };
                _depsRepos.AddDep(newDep);
                DepName.Clear();
                DisplayDeps();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void DisplayDeps()
        {
            DepsList.DataSource = null;
            DepsList.DataSource = _depsRepos.GetAllDeps();
            DepsList.DisplayMember = "Name";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DisplayDeps();
        }

        private void DepsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(DepsList.SelectedItem as Department != null)
            {
                int selId = (DepsList.SelectedItem as Department).Id;
                EmpsList.DataSource = _empsRepos.GetEmpsByDep(selId);
                EmpsList.DisplayMember = "Name";
            }
            
        }

        private void EmpPhoto_Click(object sender, EventArgs e)
        {

        }

        private void EmpsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selEmp = EmpsList.SelectedItem as Employee;
            string photoPath = (@"..\..\Images\") + selEmp.Photo;
            EmpPhoto.Image = Image.FromFile(photoPath);
            EmpPhoto.Tag = Path.GetFileName(photoPath);
            EmpName.Text = selEmp.Name;
            EmpBirth.Value = selEmp.Birth;
            EmpMail.Text = selEmp.Email;
            EmpPhone.Text = selEmp.Phone;
            EmpPosition.Text = selEmp.Position;
        }


        private readonly DepsRepos _depsRepos;

        private readonly EmpsRepos _empsRepos;

        private void ClearDepButton_Click(object sender, EventArgs e)
        {
            DepName.Clear();
        }

        private void EditPhotoButton_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            if(openFileDialog.ShowDialog() == DialogResult.OK) 
            {
                string fileName = openFileDialog.SafeFileName;
                string initFilePath = openFileDialog.FileName;
                string destinationFilePath = @"..\..\Images\" + fileName;

                if(File.Exists(destinationFilePath)) {
                    MessageBox.Show("File already exists");
                }
                else
                {
                    File.Copy(initFilePath, destinationFilePath);
                    EmpPhoto.Image = Image.FromFile(destinationFilePath);
                    EmpPhoto.Tag = Path.GetFileName(destinationFilePath);
                }
            }
        }

        private void EmpSaveButton_Click(object sender, EventArgs e)
        {
            var newEmp = _empsRepos.GetEmp((EmpsList.SelectedItem as Employee).Id);
            
            if (string.IsNullOrEmpty(EmpName.Text.Trim()) ||
                string.IsNullOrEmpty(EmpPhone.Text.Trim()) ||
                string.IsNullOrEmpty(EmpPosition.Text.Trim()) ||
                string.IsNullOrEmpty(EmpMail.Text.Trim()) ||
                string.IsNullOrEmpty((EmpPhoto.Tag as string).Trim()) ||
                EmpBirth.Value == null)
            {
                MessageBox.Show("Some data is missing.");
                DepName.Focus();
            }
            else
            {
                newEmp.Name = EmpName.Text.Trim();
                newEmp.Birth = EmpBirth.Value;
                newEmp.Phone = EmpPhone.Text.Trim();
                newEmp.Photo = EmpPhoto.Tag as string;
                newEmp.Position = EmpPosition.Text.Trim();
                newEmp.Email = EmpMail.Text.Trim();
                _empsRepos.ChangeEmp(newEmp);
                DepName.Clear();
                DisplayDeps();
            }
        }
    }
}
