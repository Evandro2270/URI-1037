using System;
using System.Globalization;
namespace Programa
{
    class Program
    {
        static void Main(string[] args)
        {
            {

                CultureInfo CI = CultureInfo.InvariantCulture;

                double numero = double.Parse(Console.ReadLine(), CI);

                if (numero < 0.0 || numero > 100.0)
                {
                    Console.WriteLine("Fora de intervalo");
                }
                else if (numero <= 25.0)
                {
                    Console.WriteLine("intervalo [0,25]");
                }
                else if (numero <= 50.0)
                {
                    Console.WriteLine("intervalo [25,50]");
                }

                else if (numero <= 75.0)
                {
                    Console.WriteLine("intervalo [50,75]");
                }

                else
                {
                    Console.WriteLine("intervalo [75,100]");
                }

            }
        }
    }
}