using CalculatorDI.Classes;
using System;

namespace CalculatorDI
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator(new AddCalculatorOperation());
            double result = calculator.Solve(1, 1);
            Console.WriteLine("Sum result: {0}", result);

            Calculator calculator2 = new Calculator(new SubtractCalculatorOperation());
            double result2 = calculator2.Solve(1, 1);
            Console.WriteLine("Substract result: {0}", result2);

            Calculator calculator3 = new Calculator(new MultiplyCalculatorOperation());
            double result3 = calculator3.Solve(1, 2);
            Console.WriteLine("Multiply result: {0}", result3);

            Calculator calculator4 = new Calculator(new DivideCalculatorOperation());
            double result4 = calculator4.Solve(10, 5);
            Console.WriteLine("Divide result: {0}", result4);
        }
    }
}
