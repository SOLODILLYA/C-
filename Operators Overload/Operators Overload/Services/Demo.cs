using System;
using Operators_Overload.Models;

namespace Operators_Overload.Services
{
    public class Demo
    {
        private readonly Vector _a;
        private readonly Vector _b;
        public Demo()
        {
            _a = new Vector(10, 20);
            _b = new Vector(20, 45);
        }
        
        public void AddVectorsDemo()
        {
            var c = _a + _b;
            
            Console.Write(_a);
            Console.Write(" + ");
            Console.Write(_b);
            Console.Write(" = ");
            Console.WriteLine(c);
        }

        public void SubtractVectorsDemo()
        {
            var c = _a - _b;
            
            Console.Write(_a);
            Console.Write(" - ");
            Console.Write(_b);
            Console.Write(" = ");
            Console.WriteLine(c);
        }
        
        public void MultiplicationVectorsDemo()
        {
            var c = _a * _b;
            
            Console.Write(_a);
            Console.Write(" * ");
            Console.Write(_b);
            Console.Write(" = ");
            Console.WriteLine(c);
        }
        
        public void NumberMultiplicationVectorsDemo()
        {
            var num = 2.5;
            var c = _a * num;
            
            Console.Write(_a);
            Console.Write(" * ");
            Console.Write(num);
            Console.Write(" = ");
            Console.WriteLine(c);
        }
    }
}