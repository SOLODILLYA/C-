using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Operators_Overload1.Models;

namespace Operators_Overload1.Services
{
    public class Demo
    {
        public void AddVectorsDemo()
        {
            var a = new Vector(10, 20);
            Console.WriteLine(a);
            var b = new Vector(30, 40);
            Console.WriteLine();
        }
    }
}
