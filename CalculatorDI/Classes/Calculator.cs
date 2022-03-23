using CalculatorDI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorDI.Classes
{
    public class Calculator
    {
        // ICalculatorOperation is "injected" via the constructor.
        // This guarantees that the Calculator cannot be created without a calculator operation.
        // This makes the Calculator "dependent" on the ICalculatorOperation.
        public Calculator(ICalculatorOperation calculatorOperation)
        {
            CalculatorOperation = calculatorOperation;
        }

        public ICalculatorOperation CalculatorOperation { get; }

        public double Solve(double x, double y)
        {
            // Calculations will be based on the "injected" ICalculatorOperation.
            return CalculatorOperation.Calculate(x, y);
        }
    }
}
