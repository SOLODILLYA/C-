using SupplyCatalog.Interfaces;
using SupplyCatalog.Models;
using SupplyCatalog.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SupplyCatalog.Repos
{
    public class CategoriesRepo : ICategories
    {

        public List<Category> Categories { get; set; }
        public CategoriesRepo() {
            _filePath = @"..\..\Data\Categories.txt";
            _fileService = new FileService();
            Categories = new List<Category>();
            LoadData();
        }

        
        public void AddCategory(Category category)
        {
            throw new NotImplementedException();
        }

        public void ChangeCategory(Category category)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetAllCategories()
        {
            return Categories;
        }

        private void LoadData()
        {
            string text = _fileService.ReadFileContent(_filePath);
            string[] rows = text.Split('\n');
            Categories.Clear();

            foreach (string row in rows)
            {
                if (!string.IsNullOrWhiteSpace(row))
                {
                    string[] parts = row.Split('-');
                    Category category = new Category()
                    {
                        Id = Convert.ToInt32(parts[0].Trim()),
                        Name = parts[1].Trim()
                    };
                    Categories.Add(category);
                }
            }
        }

        private readonly string _filePath;
        private readonly FileService _fileService;
    }
}
