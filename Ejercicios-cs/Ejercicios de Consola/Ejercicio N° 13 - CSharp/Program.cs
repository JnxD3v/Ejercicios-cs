using System;
// Crear un programa que permita introducir un numero entero y determine si es par o impar.

namespace Gamalier13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" ~ Ingrese un número entero: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Clear();

            if (numero % 2 == 0) Console.WriteLine(" ~ El número es par.");
            else Console.WriteLine(" ~ El número es impar.");
        }
    }
}
