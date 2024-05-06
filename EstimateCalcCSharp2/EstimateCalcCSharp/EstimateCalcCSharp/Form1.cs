using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EstimateCalcCSharp.Models;

namespace EstimateCalcCSharp
{
    public partial class Form1 : Form
    {
        public List<Shape> Shapes { get; set; }
        public Form1()
        {
            InitializeComponent();
            Shapes = new List<Shape>();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void CalcButton_Click(object sender, EventArgs e)
        {
            //1 -> Circles
            int count1 = (int)CirclesCount.Value;
            if(count1 > 0)
            {
                for (int i = 0; i < count1; i++)
                {
                    var addCirclesForm = new AddCircles() { 
                        Number = i + 1 , 
                        Amount = count1
                    };

                    if (addCirclesForm.ShowDialog() == DialogResult.OK)
                    {
                        double r = addCirclesForm.Radius;
                        Shapes.Add(new Models.Circle(r));
                    } 
                }
            }
            //2 -> Squares
            int count2 = (int)SquaresCount.Value;
            if (count2 > 0)
            {
                for (int i = 0; i < count2; i++)
                {
                    var addRectandlesForm = new AddRectangles()
                    {
                        Number = i + 1,
                        Amount = count2
                    };

                    if (addRectandlesForm.ShowDialog() == DialogResult.OK)
                    {
                        double h = addRectandlesForm.Height;
                        double w = addRectandlesForm.Width;
                        Shapes.Add(new Models.Rectangle(h, w));
                    }
                }
            }


            //3 -> Triangles
            // General Test
            foreach (var item in Shapes)
            {
                ResultBox.Text += item.ToString() + "\r\n";
            }
        }

        private void CirclesCount_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
