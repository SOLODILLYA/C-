using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BooksCatalog.Models;
using BooksCatalog.Repos;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BooksCatalog
{
    public partial class Form1 : Form
    {
        private readonly CatalogRepo _catalogRepo;
        private readonly SubjectsRepo _subjectsRepo;
        public Form1()
        {
            InitializeComponent();
            _catalogRepo = new CatalogRepo();
            _subjectsRepo = new SubjectsRepo();
        }

        private void LoadBooksList(List<Book> books)
        {
            BooksList.Items.Clear();
            foreach( var book in books)
            {
                var item = BooksList.Items.Add(book.Id.ToString());
                item.SubItems.Add(book.Title);
                item.SubItems.Add(book.Author);
                item.SubItems.Add(book.Year.ToString());
                item.SubItems.Add(book.Pages.ToString());
                item.SubItems.Add(book.Price.ToString());
            }
        }

        private void LoadSubjectsList()
        {
            SubjectsList.Items.Clear();
            foreach (var subject in _subjectsRepo._Subjects.Subjects)
            {
                var item = SubjectsList.Items.Add(subject.Name);
            }
            SubjectsList.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadBooksList(_catalogRepo._Catalog.Books);
            LoadSubjectsList();
        }

        private void BooksList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int k = BooksList.SelectedItems.Count;
            if (k > 0)
            {
                var selectedBookId = int.Parse( BooksList.SelectedItems[0].Text);
                

                var selecteBook = _catalogRepo._Catalog.Books.Where(book => book.Id == selectedBookId).First();
                TitleField.Text = selecteBook.Title;
                AuthorField.Text = selecteBook.Author;
                YearField.Text = selecteBook.Year.ToString();
                PagesField.Text = selecteBook.Pages.ToString();
                PriceField.Text = selecteBook.Price.ToString();
            }
        }

        private void SubjectsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedName = SubjectsList.SelectedItem.ToString();
        }

        private void ClearFields()
        {
            TitleField.Clear();
            AuthorField.Clear();
            YearField.Clear();
            PriceField.Clear();
            PagesField.Clear();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if(SubjectsList.SelectedIndex == -1) {
                MessageBox.Show("Subject is not selected", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                ClearFields();
                var selectedSubject = SubjectsList.SelectedItem.ToString();
                if(selectedSubject == "All Subjects")
                {
                    LoadBooksList(_catalogRepo._Catalog.Books);
                }
                else
                {
                    var targetBooks = _catalogRepo._Catalog.Books
                        .Where((book) => book.Subject == selectedSubject).ToList();
                    LoadBooksList(targetBooks);
                }
            }
        }
    }
}
