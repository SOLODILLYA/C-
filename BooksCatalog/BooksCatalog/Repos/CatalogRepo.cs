using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using BooksCatalog.Interfaces;
using BooksCatalog.Models;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace BooksCatalog.Repos
{
    internal class CatalogRepo : ICatalog
    {
        private Catalog _catalog;
        private readonly string _filePath;
        public Catalog _Catalog => _catalog;

        public void LoadData()
        {
            string data = File.ReadAllText(_filePath);
            //MessageBox.Show(data, "Text copy", MessageBoxButtons.OK, MessageBoxIcon.Information);
            _catalog = JsonSerializer.Deserialize<Catalog>(data, 
                new JsonSerializerOptions(){
                PropertyNameCaseInsensitive = true,
            });
            //MessageBox.Show(_catalog.Name, "Catalog name", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void SaveData() 
        {
            string data = JsonSerializer.Serialize(_catalog);
            File.WriteAllText(_filePath, data);
        }

        public CatalogRepo()
        {
            _catalog = new Catalog();
            _filePath = @"..\..\Data\Books.json";
            LoadData();
        }

    }
}
