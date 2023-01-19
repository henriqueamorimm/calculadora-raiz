using System;
using System.Globalization;

namespace MessageSpammer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Calculadora de raiz quadrada";
            Console.WriteLine("Digite um número abaixo: ");
            double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (x >= 0.0)
            {
                double raiz = Math.Sqrt(x);
                Console.WriteLine(raiz.ToString("F3"), CultureInfo.InvariantCulture);
                Console.WriteLine("Digite outro número: ");
                x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            Console.WriteLine("Número negativo");

        }
    }
}