using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstimateCalcCSharp
{
    public partial class AddCircles : Form
    {
        public int Number {  get; set; }
        public int Amount { get; set; }
        public double Radius { get; set; }

        public AddCircles()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string data = RadiusField.Text;
            if (string.IsNullOrWhiteSpace(data))
            {
                MessageBox.Show("Radius was not entered");
            }
            else
            {
                double r = Convert.ToDouble(data);
                if (r <= 0)
                {
                    MessageBox.Show("Radius can not be less or equal 0");
                }
                else
                {
                    Radius = r;
                    this.DialogResult = DialogResult.OK;
                }
            }

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            RadiusField.Clear();
        }

        private void AddCircles_Load(object sender, EventArgs e)
        {
            Caption.Text = $"Circle No {Number}/{Amount}";
        }
    }
}
