using ExamC_.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ExamC_.Repos
{
    public class GradesRepo
    {
        private readonly string _filePath;
        public GradesData _gradesData;

        public void LoadData()
        {
            string data = File.ReadAllText(_filePath);
            _gradesData = JsonSerializer.Deserialize<GradesData>(data,
                new JsonSerializerOptions()
                {
                    PropertyNameCaseInsensitive = true,
                });
        }

        public void SaveData()
        {
            string data = JsonSerializer.Serialize(_gradesData);
            File.WriteAllText(_filePath, data);
        }

        public GradesRepo()
        {
            _gradesData = new GradesData();
            _filePath = @"..\..\Data\grades.json";
            LoadData();
        }
        internal void AddGrade(Grade grade)
        {
            _gradesData.Add(grade);
            SaveData();
        }
    }
}
