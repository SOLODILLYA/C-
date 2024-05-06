using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDataSet2.CrossView' table. You can move, or remove it, as needed.
            this.crossViewTableAdapter.Fill(this.libraryDataSet2.CrossView);
            // TODO: This line of code loads data into the 'libraryDataSet1.BooksView' table. You can move, or remove it, as needed.
            this.booksViewTableAdapter.Fill(this.libraryDataSet1.BooksView);
            // TODO: This line of code loads data into the 'libraryDataSet.AuthorsView' table. You can move, or remove it, as needed.
            this.authorsViewTableAdapter.Fill(this.libraryDataSet.AuthorsView);

        }
    }
}
