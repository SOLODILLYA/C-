using BooksCatalog.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BooksCatalog.Models;
using System.Security.Policy;
using System.Text.Json;
using System.IO;

namespace BooksCatalog.Repos
{
    internal class SubjectsRepo : ISubjects
    {
        private SubjectsCatalog _subjectsCatalog;
        private readonly string _filePath;
        public SubjectsCatalog _Subjects => _subjectsCatalog;

        public void LoadData()
        {
            string data = File.ReadAllText(_filePath);
           _subjectsCatalog = JsonSerializer.Deserialize<SubjectsCatalog>(data,
                new JsonSerializerOptions()
                {
                    PropertyNameCaseInsensitive = true,
                });
            //MessageBox.Show(_catalog.Name, "Catalog name", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public SubjectsRepo()
        {
            _subjectsCatalog = new SubjectsCatalog();
            _filePath = @"..\..\Data\Subject.json";
            LoadData();
        }
    }
}
