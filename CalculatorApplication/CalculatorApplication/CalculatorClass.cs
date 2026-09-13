using System;
using System.Collections.Generic;
using System.Text;


using System;

namespace CalculatorApplication
{
    public delegate double Formula(double arg1, double arg2);

    internal class CalculatorClass
    {
        private Formula formula;

        public double GetSum(double num1, double num2)
        {
            return num1 + num2;
        }

        public double GetDifference(double num1, double num2)
        {
            return num1 - num2;
        }

        public double GetProduct(double num1, double num2)
        {
            return num1 * num2;
        }

        public double GetQuotient(double num1, double num2)
        {
            return num1 / num2;
        }

        public event Formula CalculateEvent
        {
            add
            {
                formula += value;
                Console.WriteLine("Added the Delegate");
            }

            remove
            {
                formula -= value;
                Console.WriteLine("Removed the Delegate");
            }
        }

        public double Calculate(double num1, double num2)
        {
            return formula?.Invoke(num1, num2) ?? 0.0;
        }
    }
}


