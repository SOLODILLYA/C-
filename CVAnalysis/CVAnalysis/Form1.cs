using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CVAnalysis
{
    public partial class Form1 : Form
    {
        public List<string> ListItems = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            ListItems.Clear();
        }

        private void SelectFolderButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.Description = "Select a folder";

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string folderPath = folderBrowserDialog.SelectedPath;

                string[] fileNames = Directory.GetFiles(folderPath)
                                               .Where(fileName => fileName.ToLower().EndsWith(".xml"))
                                               .ToArray();

                foreach (string fileName in fileNames)
                {
                    listBox1.Items.Add(fileName);
                    ListItems.Add(fileName);
                }
            }
        }

        private void SelectFilesButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select files to upload";
            openFileDialog.Filter = "XML files (*.xml)|*.xml";
            openFileDialog.Multiselect = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string filename in openFileDialog.FileNames)
                {
                    listBox1.Items.Add((string)filename);
                    ListItems.Add((string)filename);
                }
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            ListItems.Clear();
        }

        private void AnalyzeButton_Click(object sender, EventArgs e)
        {
            if(ListItems.Count > 0)
            {
                Analysis analysis = new Analysis(this);
                if (analysis.ShowDialog() == DialogResult.OK)
                {
                    listBox1.Items.Clear();
                    ListItems.Clear();
                }
            }
            else
            {
                MessageBox.Show("Please select at least one CV");
            }
        }
    }
}
