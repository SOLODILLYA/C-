using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstimateCalcCSharp.Models
{
    public class Circle : Shape
    {
        private double _radius;

        public Circle( double radius) : base("Circle")
        {
            _radius = radius;
        }

        public override string ToString()
        {
            return base.ToString() + $"; Radius: {_radius}; Area: {CalcArea()}" ;
        }

        public override double CalcArea()
        {
            return Math.PI * _radius * _radius;
        }

    }
}
