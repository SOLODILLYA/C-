using System;
using Operators_Overload.Services;

namespace Operators_Overload
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var demo = new Demo();
            
            demo.AddVectorsDemo();
            Console.WriteLine("\n");
            
            demo.SubtractVectorsDemo();
            Console.WriteLine("\n");
            
            demo.MultiplicationVectorsDemo();
            Console.WriteLine("\n");
            
            demo.NumberMultiplicationVectorsDemo();
            Console.WriteLine("\n");
            
            Console.WriteLine("\n\nFinish");
        }
    }
}