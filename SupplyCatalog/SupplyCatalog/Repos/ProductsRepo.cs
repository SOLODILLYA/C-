using SupplyCatalog.Interfaces;
using SupplyCatalog.Models;
using SupplyCatalog.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplyCatalog.Repos
{
    internal class ProductsRepo : IProducts
    {
        public void AddEmp(Product product)
        {
            throw new NotImplementedException();
        }

        public void ChangeEmp(Product product)
        {
            throw new NotImplementedException();
        }

        public void DelEmp(int productId)
        {
            throw new NotImplementedException();
        }

        public Product GetProduct(int productId)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProductsByCategories(int categoryId)
        {

            return Products.Where(product => product.CategotyId == categoryId).ToList();
        }


        public ProductsRepo()
        {
            _filePath = @"..\..\Data\Products.txt";
            _fileService = new FileService();
            Products = new List<Product>();
            LoadData();
        }

        public List<Product> Products { get; set; }

        private void LoadData()
        {
            string text = _fileService.ReadFileContent(_filePath);
            string[] rows = text.Split('\n');
            Products.Clear();

            foreach (string row in rows)
            {
                if (!string.IsNullOrWhiteSpace(row))
                {
                    string[] parts = row.Split('-');
                    Product product = new Product()
                    {
                        Id = Convert.ToInt32(parts[0].Trim()),
                        Name = parts[1].Trim(),
                        Price = parts[2].Trim(),
                        Quantity = parts[3].Trim(),
                        CategotyId = Convert.ToInt32(parts[4].Trim()),
                        Photo = parts[5].Trim(),
                    };
                    Products.Add(product);
                }
            }
        }

        private readonly string _filePath;
        private readonly FileService _fileService;
    }
}
