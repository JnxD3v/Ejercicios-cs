using System;
//       Partiendo del ejercicio 8, determinar cual es el mayor, cual es el central y cuál es el menor.

namespace Gamalier16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" ~ Ingrese el 1er número entero: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Clear();

            Console.Write(" ~ Ingrese el 2do número entero: ");
            int n2 = int.Parse(Console.ReadLine());
            Console.Clear();

            Console.Write(" ~ Ingrese el 3er número entero: ");
            int n3 = int.Parse(Console.ReadLine());
            Console.Clear();

            if (n1 > n2 && n1 > n3 )
            {
                if (n2 > n3)
                {
                    Console.WriteLine($" El número mayor es: {n1}");
                    Console.WriteLine($" El número de en medio es: {n2}");
                    Console.WriteLine($" El numero menor es: {n3}");
                }
                if (n3 > n2)
                {
                    Console.WriteLine($" El número mayor es: {n1}");
                    Console.WriteLine($" El número de en medio es: {n3}");
                    Console.WriteLine($" El numero menor es: {n2}");
                }
            }
            if (n2 > n3 && n2 > n1)
            {
                if (n1 > n3)
                {
                    Console.WriteLine($" El número mayor es: {n2}");
                    Console.WriteLine($" El número de en medio es: {n1}");
                    Console.WriteLine($" El numero menor es: {n3}");
                }
                if (n3 > n1)
                {
                    Console.WriteLine($" El número mayor es: {n2}");
                    Console.WriteLine($" El número de en medio es: {n3}");
                    Console.WriteLine($" El numero menor es: {n1}");
                }
            }
            if (n3 > n1 && n3 > n2)
            {
                if (n2 > n1)
                {
                    Console.WriteLine($" El número mayor es: {n3}");
                    Console.WriteLine($" El número de en medio es: {n2}");
                    Console.WriteLine($" El numero menor es: {n1}");
                }
                if (n1 > n2)
                {
                    Console.WriteLine($" El número mayor es: {n3}");
                    Console.WriteLine($" El número de en medio es: {n1}");
                    Console.WriteLine($" El numero menor es: {n2}");
                }
            }
        }
    }
}
