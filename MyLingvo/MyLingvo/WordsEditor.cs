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
    public partial class WordsEditor : Form
    {
        public string actionName { get; set; }
        public string enText { get; set; }
        public string uaText { get; set; }
        public string enExText { get; set; }
        public string uaExText { get; set; }
        public WordsEditor()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void WordsEditor_Load(object sender, EventArgs e)
        {
            //1
            if (string.IsNullOrEmpty(actionName))
            {
                ActionLable.Text = "Operation";
            }
            else
            {
                ActionLable.Text = actionName;
            }

            //2
            if (!string.IsNullOrEmpty(enText))
            {
                EnField.Text = enText;
                UaField.Text = uaText;
                EnExField.Text = enExText;
                UaExField.Text = uaExText;
                EnField.ReadOnly = true;
                ClearButton.Enabled = false;

                if (actionName == "Delete word")
                {
                    UaField.ReadOnly = true;
                    EnExField.ReadOnly = true;
                    UaExField.ReadOnly = true;
                }
            }
        }

        private void ActionButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(EnField.Text))
            {
                MessageBox.Show("You have not enter English text", "Warning", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                EnField.Focus();
            }else if (string.IsNullOrWhiteSpace(UaField.Text))
            {
                MessageBox.Show("You have not enter Ukranian text", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                UaField.Focus();
            }else if (string.IsNullOrWhiteSpace(EnExField.Text))
            {
                MessageBox.Show("You have not enter English example", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                EnExField.Focus();
            }
            else if (string.IsNullOrWhiteSpace(UaExField.Text))
            {
                MessageBox.Show("You have not enter Ukranian example", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                UaExField.Focus();
            }
            else
            {
                enText = EnField.Text.Trim();
                uaText = UaField.Text.Trim();
                enExText = EnExField.Text.Trim();
                uaExText = UaExField.Text.Trim();
                this.DialogResult = DialogResult.OK;
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            EnField.Clear();
            UaField.Clear();
            EnExField.Clear();
            UaExField.Clear();
        }
    }
}
