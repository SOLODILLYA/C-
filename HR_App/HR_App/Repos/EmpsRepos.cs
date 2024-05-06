using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HR_App.Interfaces;
using HR_App.Services;
using HR_App.Models;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace HR_App.Repos
{
    public class EmpsRepos : IEmployees
    {
        public void DelEmp(int EmpId)
        {
            throw new NotImplementedException();
        }

        public void AddEmp(Employee emp)
        {
            throw new NotImplementedException();
        }

        public void ChangeEmp(Employee emp)
        {
            var oldEmp = GetEmp(emp.Id);
            oldEmp.Name = emp.Name;
            oldEmp.Email = emp.Email; 
            oldEmp.Phone = emp.Phone;
            oldEmp.Birth = emp.Birth;
            oldEmp.Position = emp.Position;
            oldEmp.DepId = emp.DepId;
            oldEmp.Photo = emp.Photo;
            SaveData();
        }

        public Employee GetEmp(int empId)
        {
            return Emps.Where(emp => emp.Id == empId).First();
        }

        public List<Employee> GetEmpsByDep(int depId)
        {
            return Emps.Where(emp => emp.DepId == depId).ToList();
        }

        public EmpsRepos()
        {
            _filePath = @"..\..\Data\Employees.txt";
            _fileService = new FileService();
            Emps = new List<Employee>();
            LoadData();
        }
        public List<Employee> Emps { get; set; }

        private void LoadData()
        {
            string text = _fileService.ReadFileContent(_filePath);
            string[] rows = text.Split('\n');
            Emps.Clear();

            foreach (string row in rows)
            {
                if (!string.IsNullOrWhiteSpace(row))
                {
                    string[] parts = row.Split('-');
                    Employee emp = new Employee()
                    {
                        Id = Convert.ToInt32(parts[0].Trim()),
                        Name = parts[1].Trim(),
                        Birth = Convert.ToDateTime(parts[2].Trim()),
                        Email = parts[3].Trim(),
                        Phone = parts[4].Trim(),
                        Position = parts[5].Trim(),
                        DepId = Convert.ToInt32(parts[6].Trim()),
                        Photo = parts[7].Trim(),
                    };
                    Emps.Add(emp);
                }
            }
        }

        private void SaveData()
        {
            string content = string.Empty;
            foreach (var emp in Emps)
            {
                content += $"{emp.Id} - {emp.Name} - {emp.Birth} - {emp.Email} - {emp.Phone} - {emp.Position} - {emp.DepId} - {emp.Photo}\n";
            }
            _fileService.WriteFileContent(_filePath, content);
            MessageBox.Show("Saved Successfuly");
        }

        private readonly string _filePath;
        private readonly FileService _fileService;
    }
}
