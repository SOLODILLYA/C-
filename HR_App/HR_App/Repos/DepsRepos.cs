using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HR_App.Interfaces;
using HR_App.Models;
using HR_App.Services;

namespace HR_App.Repos
{
    public class DepsRepos : IDepartments
    {

        public List<Department> Deps { get; set; }

        public DepsRepos()
        {
            _filePath = @"..\..\Data\Departments.txt";
            _fileService = new FileService();
            Deps = new List<Department>();
            LoadData();
        }


        public List<Department> GetAllDeps()
        {
            return Deps;
        }

        

        public void AddDep(Department department)
        {
            if (Exists(department))
            {
                MessageBox.Show("Department already exists");
            }
            else
            {
                Deps.Add(department);
                SaveData();
            }
        }

        public int GetLastId()
        {
            return Deps[Deps.Count - 1].Id;
        }

        public void ChangeDep(Department department)
        {
            throw new NotImplementedException();
        }

        private void SaveData() {
            string content = string.Empty;
            foreach(var dep in Deps)
            {
                content += $"{dep.Id} - {dep.Name}\n";
            }
            _fileService.WriteFileContent(_filePath, content);
            MessageBox.Show("Saved Successfuly");
        }

        private void LoadData()
        {
            string text = _fileService.ReadFileContent(_filePath);
            string[] rows = text.Split('\n');
            Deps.Clear();

            foreach (string row in rows)
            {
                if (!string.IsNullOrWhiteSpace(row))
                {
                    string[] parts = row.Split('-');
                    Department dept = new Department()
                    {
                        Id = Convert.ToInt32(parts[0].Trim()),
                        Name = parts[1].Trim()
                    };
                    Deps.Add(dept);
                }
            }
        }

        private bool Exists(Department department)
        {
            return Deps.Any(dep => dep.Name == department.Name);
        }

        private readonly string _filePath;
        private readonly FileService _fileService;
    }
}
