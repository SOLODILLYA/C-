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
    public class TestsRepo
    {
        private readonly string _filePath;
        public TestsData _testsData;

        public void LoadData()
        {
            string data = File.ReadAllText(_filePath);
            _testsData = JsonSerializer.Deserialize<TestsData>(data,
                new JsonSerializerOptions()
                {
                    PropertyNameCaseInsensitive = true,
                });
        }

        public List<Test> getTests()
        {
            return _testsData.Tests;
        }
        public void SaveData()
        {
            string data = JsonSerializer.Serialize(_testsData);
            File.WriteAllText(_filePath, data);
        }

        public TestsRepo()
        {
            _testsData = new TestsData();
            _filePath = @"..\..\Data\tests.json";
            LoadData();
        }
        internal void AddTest(Test test)
        {
            _testsData.Add(test);
            SaveData();
        }
    }
}
