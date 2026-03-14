using System;

namespace MathApp
{
    class MathProgram
    {
        static void Main(string[] args)
        {
            double negativeNumber = -25.7;
            double decimalNumber = 8.3;
            double angleInRadians = Math.PI / 6; 
            double numberForSqrt = 49;

            double absoluteValue = Math.Abs(negativeNumber);    
            double squareRoot = Math.Sqrt(numberForSqrt);        
            double ceilingValue = Math.Ceiling(decimalNumber);   
            double floorValue = Math.Floor(decimalNumber);       
            double roundedValue = Math.Round(decimalNumber);     

            Console.WriteLine("Demonstration of Math Class Methods:");
            Console.WriteLine("Absolute value of " + negativeNumber + " = " + absoluteValue);
            Console.WriteLine("Square root of " + numberForSqrt + " = " + squareRoot);
            Console.WriteLine("Ceiling of " + decimalNumber + " = " + ceilingValue);
            Console.WriteLine("Floor of " + decimalNumber + " = " + floorValue);
            Console.WriteLine("Rounded value of " + decimalNumber + " = " + roundedValue);

            Console.ReadLine();
        }
    }
}