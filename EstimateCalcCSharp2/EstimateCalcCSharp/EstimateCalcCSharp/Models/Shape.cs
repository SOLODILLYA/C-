using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstimateCalcCSharp.Models
{
    public abstract class Shape
    {
        protected string _name;
        public Shape(string name)
        {
            _name = name;
        }
        public override string ToString()
        {
            return $"Figure {_name}";
        }
        public abstract double CalcArea();

    }
}
