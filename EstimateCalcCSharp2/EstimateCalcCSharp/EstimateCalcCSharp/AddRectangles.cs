using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace EstimateCalcCSharp
{
    public partial class AddRectangles : Form
    {
        public int Number { get; set; }
        public int Amount { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }

        public bool heightCheck = false;

        public AddRectangles()
        {
            InitializeComponent();
        }

        private void ContinueButton_Click(object sender, EventArgs e)
        {
            string data = HeightBox.Text;
            if (string.IsNullOrWhiteSpace(data))
            {
                MessageBox.Show("Height was not entered");
            }
            else
            {
                double r = Convert.ToDouble(data);
                if (r <= 0)
                {
                    MessageBox.Show("Height can not be less or equal 0");
                }
                else
                {
                    Height = r;
                   heightCheck = true;
                }
            }
            data = WidthBox.Text;
            if (string.IsNullOrWhiteSpace(data))
            {
                MessageBox.Show("Width was not entered");
            }
            else
            {
                double r = Convert.ToDouble(data);
                if (r <= 0)
                {
                    MessageBox.Show("Width can not be less or equal 0");
                }
                else
                {
                    Width = r;
                    this.DialogResult = DialogResult.OK;
                }
            }
        }

        private void AddRectangles_Load(object sender, EventArgs e)
        {
            Caption1.Text = $"Rectangle No {Number}/{Amount}";
        }
    }
}
