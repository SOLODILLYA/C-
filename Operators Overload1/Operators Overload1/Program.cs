using System;
using Operators_Overload1.Services;

namespace Operators_Overload1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var demo = new Demo();
            demo.AddVectorsDemo();

            Console.WriteLine("\n\nFinish");
        }
    }
}