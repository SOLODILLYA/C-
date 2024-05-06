using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using MyLingvo.Models;

namespace MyLingvo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _filePath = @"..\..\Data\Words.xml";
            _doc = XDocument.Load(_filePath);
            _root = _doc.Root;
            _wordsEnUa = new Dictionary<string, Word>();
            _wordsUaEn = new Dictionary<string, Word>();
        }

        private void LoadData()
        {
            foreach (XElement wordElement in _root.Elements("word"))
            {
                var newWord = new Word()
                {
                    En = wordElement.Attribute("en").Value,
                    Ua = wordElement.Attribute("ua").Value,
                    ExEn = wordElement.Attribute("ExEn").Value,
                    ExUa = wordElement.Attribute("ExUa").Value,
                };
                _wordsEnUa.Add(newWord.En, newWord);
                _wordsUaEn.Add(newWord.Ua, newWord);
            }
        }

        private void SaveData() 
        {
            
        }

        private void quizToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            InputWord.Clear();
            InputWord.Focus();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
            MessageBox.Show("Data loaded successfuly", "Message",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
            EnglishRadio.Checked = true;

        }
        private void TranslateButton_Click(object sender, EventArgs e)
        {
            var targetWord = InputWord.Text.Trim().ToLower();
            if(string.IsNullOrEmpty(targetWord) )
            {
                MessageBox.Show("No word was entered", "Warning",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                InputWord.Focus();
            }
            else
            {
                if(EnglishRadio.Checked)
                {
                    if (!_wordsEnUa.ContainsKey(targetWord))
                    {
                        MessageBox.Show("Such word do not exist in dictionary", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        InputWord.Clear();
                        InputWord.Focus();
                    }
                    else
                    {
                        var result = _wordsEnUa[targetWord];
                        if (result != null)
                        {
                            WordsList.Items.Add(result.En);
                            TranslatesList.Items.Add(result.Ua);
                            EnExample.Items.Add(result.ExEn);
                            UaExample.Items.Add(result.ExUa);
                        }
                    }
                }
                else if(UkrainianRadio.Checked)
                {
                    if (!_wordsUaEn.ContainsKey(targetWord))
                    {
                        MessageBox.Show("Such word do not exist in dictionary", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        InputWord.Clear();
                        InputWord.Focus();
                    }
                    else
                    {
                        var result = _wordsUaEn[targetWord];
                        if (result != null)
                        {
                            WordsList.Items.Add(result.En);
                            TranslatesList.Items.Add(result.Ua);
                            EnExample.Items.Add(result.ExEn);
                            UaExample.Items.Add(result.ExUa);
                        }
                    }
                }
            }
        }

        private readonly string _filePath;
        private readonly XDocument _doc;
        private readonly XElement _root;
        private readonly Dictionary<string, Word> _wordsEnUa;
        private readonly Dictionary<string, Word> _wordsUaEn;

    }
}
