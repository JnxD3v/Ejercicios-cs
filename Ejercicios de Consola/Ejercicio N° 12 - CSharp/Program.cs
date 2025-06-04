using System;
using System.Text;

namespace Gamalier12
{
    internal class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("~ Ingrese el número: ");
                Int128 numero = Int128.Parse(Console.ReadLine());
                try
                {

                    if (numero > 0)
                    {
                        Console.WriteLine("El número es positivo.");
                    }
                    else if (numero < 0)
                    {
                        Console.WriteLine("El número es negativo.");
                    }
                    else
                    {
                        Console.WriteLine("El número es cero (ni positivo ni negativo).");
                    }

                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Error de formato. Por favor, ingrese un número válido.");
                }
            }
        }
    }
}
