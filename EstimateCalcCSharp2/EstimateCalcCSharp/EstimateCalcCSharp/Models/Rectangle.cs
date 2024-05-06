using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstimateCalcCSharp.Models
{
    public class Rectangle : Shape
    {
        private double _height;
        private double _width;
        public Rectangle(double height, double width) : base("Rectangle")
        {
            _height = height;
            _width = width;
        }

        public override string ToString()
        {
            return base.ToString() + $"; Height: {_height}; Width: {_width}; Area: {CalcArea()}";
        }
        public override double CalcArea()
        {
            return _height * _width;
        }
    }
}
