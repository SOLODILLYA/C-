using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesDemo
{
    internal class Converter
    {
        public string Type { get; set; }
        private double c;
        public double C
        {
            get { return c; }
            set { 
                if( value < -50 ) 
                    throw new Exception($" Entered value {value} is less than minimum accepteble value -50");
                else if (value > 50)
                    throw new Exception($" Entered value {value} is bigger than maximum accepteble value 50");
                else
                    c = value; }
        }
        private double f;
        public double F
        {
            get { return f; }
            set {
                if (value < -100)
                    throw new Exception($" Entered value {value} is less than minimum accepteble value -100");
                else if (value > 100)
                    throw new Exception($" Entered value {value} is bigger than maximum accepteble value 100");
                else
                    f = value;
            }
        }

        private string author;

        public string Author => author;

        public Converter(string author)
        {
            this.author = author;
        }

        public void ConvertFromCtoF()
        {
            f = 32 + c * 9 / 5;
        }

        public void ConvertFromFtoC()
        {
            c = (f - 32) * 5 / 9;
        }

        public override string ToString()
        {
            return $"\n> Converter of type {Type}";
        }
    }
}
