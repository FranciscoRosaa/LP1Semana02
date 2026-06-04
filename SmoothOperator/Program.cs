using System;
using System.Globalization;

namespace SmoothOperator
{
    /// <summary>
    /// Initializes the Program.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Asks the user for a integrer number, converts the number into an
        /// sbyte and decrements/increments that same number.
        /// </summary>
        /// <param name="args">Not Used.</param>
        private static void Main(string[] args)
        {
            Console.Write("Insert an integrer number: ");
            string number = Console.ReadLine();
            sbyte snumber = sbyte.Parse(number);

            Console.WriteLine($"Decremented number: {--snumber}");
            Console.WriteLine($"Incremented number: {++snumber}");
        }
    }
}
