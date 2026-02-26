using System;
using System.Globalization;

namespace TempConvert
{
    public class Program
    {
        private static void Main(string[] args)
        {
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
            Console.Write("Temperature: ");
            double temp = double.Parse(Console.ReadLine());
            Console.Write("Unit (C/F): ");
            string unit = Console.ReadLine();
            double converted;
            switch (unit)
            {
                case "C":
                    converted = temp * 1.8 + 32;
                    Console.WriteLine($"{temp:f2} C = {converted:f2} F");
                    Console.WriteLine($"Absolute value: {Math.Abs(converted):f2}");
                    break;


                case "F":
                    converted = (temp - 32) / 1.8;
                    Console.WriteLine($"{temp:f2} F = {converted:f2} C");
                    Console.WriteLine($"Absolute value: {Math.Abs(converted):f2}");
                    break;
            }
        }
    }
}