using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithoutIfCalc
{
    internal class CalcManager
    {
        public MathOperations _MathOperations { get; set; }
        public string[] _OperationsList { get; set; }

        public CalcManager() { 
            _MathOperations = new MathOperations();
            _OperationsList = new string[4] { "+","-", "*", "/"};
        }

        public void Calculate()
        {
            //1
            Console.Write("\n> Enter first operand: ");
            if (!double.TryParse(Console.ReadLine(), out double a))
                throw new FormatException("First Operand Format Exception");

            //2
            Console.Write("\n> Enter second operand: ");
            if (!double.TryParse(Console.ReadLine(), out double b))
                throw new FormatException("Second Operand Format Exception");

            //3
            Console.Write("\n> Enter number of operation\n 1 => +, 2 => -, 3 => *, 4 => / : ");
            if (!int.TryParse(Console.ReadLine(), out int c))
                throw new FormatException("Number of Operation Format Exception");

            //4
            if (c < 1 || c > 4)
                throw new ApplicationException("No such operation exists");

            //5 
            string operation = _OperationsList[c - 1];
            double res = _MathOperations.Operations[c - 1].Invoke(a, b);
            Console.WriteLine($"\n> Result: \n {a} {operation} {b} = {res:f}");
        }
    }
}
