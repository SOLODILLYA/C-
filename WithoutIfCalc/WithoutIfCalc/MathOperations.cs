using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithoutIfCalc
{
    delegate double MathDelegete(double a, double b);

    internal class MathOperations
    {
        public string[] Messages { get; set; }
        public MathDelegete[] Operations { get; set; }

        public MathOperations() { 
            Operations = new MathDelegete[4] 
            { 
                AddNumbers, SubNumbers, MulNumbers, DivNumbers,
            };
        }

        public double AddNumbers(double a, double b) {  return a + b; }
        public double SubNumbers(double a, double b) { return a - b; }
        public double MulNumbers(double a, double b) { return a * b; }
        public double DivNumbers(double a, double b) { 

            if(b== 0) return 0;

            return a / b; 
        }
    }
}
