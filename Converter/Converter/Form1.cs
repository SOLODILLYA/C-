using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Converter.Services;

namespace Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tempF.Clear();
            tempC.Clear();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            string data = tempF.Text;
            if (string.IsNullOrEmpty(data))
            {
                MessageBox.Show("No Farenheight tempreture was added");
                tempF.Focus();
            }
            else
            {
                try
                {
                    double F = Convert.ToDouble(data);
                    var calc = new CalcManager();
                    double C = calc.ConvertFromFtoC(F);
                    tempC.Text = C.ToString("F");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void tempC_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
