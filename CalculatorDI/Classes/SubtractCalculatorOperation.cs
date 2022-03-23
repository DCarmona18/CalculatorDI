using CalculatorDI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorDI.Classes
{
    public class SubtractCalculatorOperation : ICalculatorOperation
    {
        public double Calculate(double x, double y)
        {
            return x - y;
        }
    }
}
