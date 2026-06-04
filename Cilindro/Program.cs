using System;

namespace Cilindro
{
    /// <summary>
    /// Initializes the Program.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Program that asks the user for the height and radius of a cylinder
        /// and then convertes them into doubles and calculates the volume and
        /// superficial area of said cylinder.
        /// </summary>
        /// <param name="args">Not used.</param>
        private static void Main(string[] args)
        {
            Console.Write("Insert the height of the cylinder: ");
            string height = Console.ReadLine();
            double h = double.Parse(height);

            Console.Write("Insert the radius of the cylinder: ");
            string radius = Console.ReadLine();
            double r = double.Parse(radius);

            double v = Math.PI * Math.Pow(r, 2) * h;
            Console.WriteLine($"Volume of the Cylinder: {Math.Round(v, 3)}");

            double superficiala = 2 * Math.PI * r * (r + h);
            Console.WriteLine($"Superficial Area of the Cylinder: {Math.Round(superficiala, 3)}"); 
        }
    }
}
