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
            }
        }

        private void SaveData() 
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
            /*MessageBox.Show("Data loaded successfuly", "Message",
               MessageBoxButtons.OK, MessageBoxIcon.Information);*/

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
        }

        private void AddWord_Click(object sender, EventArgs e)
        {
            var wordsEditor = new WordsEditor()
            {
                actionName = "Add word",
            };

            if(wordsEditor.ShowDialog() == DialogResult.OK)
            {
                //1
                var newWord = new Word()
                {
                    En = wordsEditor.enText,
                    Ua = wordsEditor.uaText,
                    ExEn = wordsEditor.enExText,
                    ExUa = wordsEditor.uaExText,
                };
                _wordsEnUa.Add(newWord.En, newWord);

                //2
                _root.Add(new XElement("word",
                    new XAttribute("en", newWord.En),
                    new XAttribute("ua", newWord.Ua),
                    new XAttribute("enEx", newWord.ExEn),
                    new XAttribute("uaEx", newWord.ExUa)));
                _doc.Save(_filePath);

                //3
                MessageBox.Show("Word have been saved", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void EditWord_Click(object sender, EventArgs e)
        {
            //->
            int selIndex = WordsList.SelectedIndex;
            if (selIndex == -1)
            {
                MessageBox.Show("Select word for editing", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                var selKey = WordsList.SelectedItem.ToString();
                var oldWord = _wordsEnUa[selKey];

                var wordsEditor = new WordsEditor()
                {
                    actionName = "Edit word",
                    enText = oldWord.En,
                    uaText = oldWord.Ua,
                    enExText = oldWord.ExEn,
                    uaExText = oldWord.ExUa,
                };

                if (wordsEditor.ShowDialog() == DialogResult.OK)
                {
                    //1 - in dictionary
                    oldWord.Ua = wordsEditor.uaText;
                    oldWord.ExUa = wordsEditor.uaExText;
                    oldWord.ExEn = wordsEditor.enExText;

                    //2 - in XML File
                    var target = _root.Elements("word").Where(w => w.Attribute("en").Value == selKey).First();
                    target.Attribute("ua").Value = oldWord.Ua;
                    target.Attribute("ExUa").Value = oldWord.ExUa;
                    target.Attribute("ExEn").Value = oldWord.ExEn;

                    _doc.Save(_filePath);

                    //3
                    MessageBox.Show("Word have been updated", "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void DeleteWord_Click(object sender, EventArgs e)
        {
            //->
            int selIndex = WordsList.SelectedIndex;
            if (selIndex == -1)
            {
                MessageBox.Show("Select word for deletion", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                var selKey = WordsList.SelectedItem.ToString();
                var oldWord = _wordsEnUa[selKey];

                var wordsEditor = new WordsEditor()
                {
                    actionName = "Delete word",
                    enText = oldWord.En,
                    uaText = oldWord.Ua,
                    enExText = oldWord.ExEn,
                    uaExText = oldWord.ExUa,
                };

                if (wordsEditor.ShowDialog() == DialogResult.OK)
                {
                    //1 - in dictionary
                    _wordsEnUa.Remove(selKey);

                    //2 - in XML File
                    var target = _root.Elements("word").Where(w => w.Attribute("en").Value == selKey).First();
                    target.Remove();

                    _doc.Save(_filePath);

                    //3
                    MessageBox.Show("Word have been deleted", "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }


        private void quizToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var quizz = new Quizz()
            {
                WordsEnUa = _wordsEnUa
            };
            if (quizz.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("You answered correctly " + quizz.correctAnswers + " words out of " + quizz.answers + " words.", "Results",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        private readonly string _filePath;
        private readonly XDocument _doc;
        private readonly XElement _root;
        private readonly Dictionary<string, Word> _wordsEnUa;
    }
}
