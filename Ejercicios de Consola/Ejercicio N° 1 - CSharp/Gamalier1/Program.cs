using System;
// Suma, Resta, Multiplicación, y Division |  Simple.
namespace Gamalier1
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, mult, div, suma, resta;
            Console.WriteLine(" ~ Ingresa los 2 números:");
            num1 = double.Parse(Console.ReadLine());
            num2 = double.Parse(Console.ReadLine());

            Console.WriteLine($"La suma es: {suma = num1 + num2}");
            Console.WriteLine($"La resta es: {resta = num1 - num2}");
            Console.WriteLine($"La multiplicación es: {mult = num1 * num2}");
            Console.WriteLine($"La división es: {div = num1 / num2}");
        }

    }

}