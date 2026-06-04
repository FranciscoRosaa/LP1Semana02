using System;

namespace VariousOperators
{
    /// <summary>
    /// Initializes the Program.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Asks the user for an non-negative int number, stores and converts
        /// it in a variable byte and divides it, shifts its bytes to the left
        /// by 3, does a xor with 6 and sees if the number is higher or equal
        /// than 10.
        /// </summary>
        /// <param name="args">Not used.</param>
        private static void Main(string[] args)
        {
            Console.Write("Insert a non-negative int number: ");
            string number = Console.ReadLine();
            byte bnumber = byte.Parse(number);

            Console.WriteLine($"{bnumber} /2 = {bnumber / 2}");
            Console.WriteLine($"{bnumber} << 3 = {bnumber << 3}");
            Console.WriteLine($"{bnumber} ^ 6 = {bnumber ^ 6}");
            Console.WriteLine($"{bnumber} >= 10 = {bnumber >= 10}");
        }
    }
}
