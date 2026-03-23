// testing 2026 Sprint 2
using System;

namespace MathOperations
{
    public class Addition
    {
        /// <summary>
        /// Adds two numbers and returns the result
        /// </summary>
        /// <param name="a">First number</param>
        /// <param name="b">Second number</param>
        /// <returns>Sum of the two numbers</returns>
        public static double AddTwoNumbers(double a, double b)
        {
            return a + b;
        }

        /// <summary>
        /// Adds two integers and returns the result
        /// </summary>
        /// <param name="a">First integer</param>
        /// <param name="b">Second integer</param>
        /// <returns>Sum of the two integers</returns>
        public static int AddTwoNumbers(int a, int b)
        {
            return a + b;
        }

        // Example usage
        public static void Main(string[] args)
        {
            int result1 = AddTwoNumbers(5, 3);
            double result2 = AddTwoNumbers(2.5, 3.7);

            Console.WriteLine($"5 + 3 = {result1}");
            Console.WriteLine($"2.5 + 3.7 = {result2}");
        }
    }
}
