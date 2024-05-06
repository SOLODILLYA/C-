using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EstimateCalcCSharp.Models
{
    public class Triangle : Shape
    {
        private double _sideA;
        private double _sideB;
        private double _sideC;

        public Triangle(double sideA, double sideB, double sideC) : base("Triangle")
        {
            _sideA = sideA;
            _sideB = sideB;
            _sideC = sideC;
        }
        public override double CalcArea()
        {
            double p = _sideA + _sideB + _sideC;
            return Math.Sqrt(p * (p - _sideA) * (p - _sideB) * (p - _sideC));
        }

    }
}
