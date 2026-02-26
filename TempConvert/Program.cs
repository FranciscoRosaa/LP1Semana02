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
            Console.ReadLine();
            Console.Write("Unit (C/F): ");
            Console.ReadLine();
        }
    }
}
