using System;

namespace ComputeAverageApp
{
    class ComputeAverageProgram
    {
        static void Main(string[] args)
        {
            double sum = 0;
            double[] grades = new double[5];

            Console.WriteLine("Enter 5 grades separated by new line:");

            for (int i = 0; i < 5; i++)
            {
                grades[i] = Convert.ToDouble(Console.ReadLine());
                sum += grades[i];
            }

            double average = sum / 5;
            double rounded = Math.Round(average);

            Console.WriteLine("The average is " + average + " and round off to " + rounded);
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
