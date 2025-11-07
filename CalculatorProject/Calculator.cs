using System;

namespace CalculatorProject
{
    public class Calculator
    {
        public double Calculate(double a, double b, char operation)
        {
            return operation switch
            {
                '+' => a + b,
                '-' => a - b,
                '*' => a * b,
                '/' => b != 0 ? a / b : throw new DivideByZeroException("Cannot divide by zero."),
                _ => throw new ArgumentException("Invalid operation.")
            };
        }
    }
}