using System;
using System.Globalization;

namespace SmoothOperator
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Insere um número inteiro: ");
           string number = Console.ReadLine();
           sbyte n = sbyte.Parse(number);
           Console.WriteLine(--n);
           Console.WriteLine(++n);
        }
    }
}
