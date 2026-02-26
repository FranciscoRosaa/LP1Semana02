using System;

namespace Cilindro
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Insere a altura do cilindro: ");
            string altura = Console.ReadLine();
            double a = double.Parse(altura);
            Console.Write("Insere o raio do cilindro: ");
            string raio = Console.ReadLine();
            double r = double.Parse(raio);
            double volume = Math.PI * Math.Pow(r, 2) * a;
            double area = 2 * Math.PI * r * (r + a);
            Console.WriteLine($"Volume = {Math.Round(volume, 3)}");
            Console.WriteLine($"Área = {Math.Round(area, 3)}");
        }
    }
}
