using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var manager = new ExampleManager();
            manager.Example1();
            manager.Example2();
            manager.Example3();
            manager.Example4();
            manager.Example5();
        }
    }
}
