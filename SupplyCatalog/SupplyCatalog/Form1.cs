using SupplyCatalog.Models;
using SupplyCatalog.Repos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupplyCatalog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _categoryRepo = new CategoriesRepo();
            _productsRepo = new ProductsRepo();
        }

        private void EmpPhoto_Click(object sender, EventArgs e)
        {

        }

        private void EmployerPhotoBox_Enter(object sender, EventArgs e)
        {

        }

        private void DepsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedId = (CategoryList.SelectedItem as Category).Id;
            ProductsList.DataSource = _productsRepo.GetProductsByCategories(selectedId);
            ProductsList.DisplayMember = "Name";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void ProductQuantity_Click(object sender, EventArgs e)
        {

        }

        private void ProductsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedProduct = ProductsList.SelectedItem as Product;
            string photoPath = (@"..\..\Images\") + selectedProduct.Photo;

            ProductName.Text = selectedProduct.Name;
            ProductPrice.Text = selectedProduct.Price;
            ProductQuantity.Text = selectedProduct.Quantity;
            //MessageBox.Show(photoPath);
            ProductPhoto.Image = Image.FromFile(photoPath);
        }


        private readonly CategoriesRepo _categoryRepo;

        private readonly ProductsRepo _productsRepo;

        private void Form1_Load(object sender, EventArgs e)
        {
            CategoryList.DataSource = _categoryRepo.GetAllCategories();
            CategoryList.DisplayMember = "Name";
        }
    }
}
