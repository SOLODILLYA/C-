using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter.Services
{
    internal class CalcManager
    {
        public double ConvertFromFtoC(double f)
        {
            return (f - 32) * 5 / 9;
        }
    }
}
