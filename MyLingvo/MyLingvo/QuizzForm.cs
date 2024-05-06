using MyLingvo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyLingvo
{
    public partial class Quizz : Form
    {
        public Quizz()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Quizz_Load(object sender, EventArgs e)
        {
            WordBox.Text = GetRandomKeyFromDictionary(WordsEnUa);
            WordBox.ReadOnly = true;
            TranslationBox.Focus();
            correctAnswers = 0;
            answers = 0;
        }

        private static string GetRandomKeyFromDictionary(Dictionary<string, Word> dict)
        {
            Random rand = new Random();
            List<string> keys = Enumerable.ToList(dict.Keys);
            int randomIndex = rand.Next(keys.Count);
            return keys[randomIndex];
        }

        private void CheckButton_Click(object sender, EventArgs e)
        {

            string res = WordBox.Text + " - " + TranslationBox.Text + " - ";
            if (WordsEnUa[WordBox.Text].Ua == TranslationBox.Text.Trim())
            {
                res += "correct";
                correctAnswers++;
            }
            else
            {
                res += "incorrect";
            }
            res += "\n";

            PreviousTranslationsList.Items.Add(res);
            WordBox.Text = GetRandomKeyFromDictionary(WordsEnUa);
            TranslationBox.Clear();
            TranslationBox.Focus();
            answers++;
        }
        private void EndButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        public Dictionary<string, Word> WordsEnUa { get; set; }
        public int correctAnswers { get; set; }
        public int answers { get; set; }

        
    }
}
