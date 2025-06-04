using System;
// Crear un programa que permita introducir 2 numeros enteros y determine cual de los dos es mayor.

namespace Gamalier15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" ~ Ingrese el 1er número entero: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.Write(" ~ Ingrese el 2do número entero: ");
            int n2 = int.Parse(Console.ReadLine());

            Console.Write(" ~ Ingrese el 3er número entero: ");
            int n3 = int.Parse(Console.ReadLine());

            if (n1 > n2 && n1 > n3) Console.WriteLine(" El primer número es mayor.");
            if (n2 > n1 && n2 > n3) Console.WriteLine(" El segundo número es mayor.");
            if (n3 > n2 && n3 > n1) Console.WriteLine(" El tercer número es mayor");
        }
    }
}
