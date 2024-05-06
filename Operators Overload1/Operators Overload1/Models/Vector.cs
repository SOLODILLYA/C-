using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators_Overload1.Models
{
    internal class Vector
    {
        private double _x;
        private double _y;

        public Vector(double x, double y)
        {
            _x = x;
            _y = y;
        }

        public override string ToString()
        {
            return $"({_x}; {_y})";
            //return "<" + _x + ", " + _y + ">";
        }
    }
}
