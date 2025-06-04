using System;
using System.Runtime.ConstrainedExecution;

// Crear un programa que lea n cantidad de números enteros, si la sumatoria es
// mayor o igual a 100, el programa debe mostrar un mensaje indicando que la
// sumatoria es mayor o igual a 100.

namespace Ejercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sumatoria = 0;
            Console.WriteLine(" ~ Ingrese la cantidad de número que quiera ingresar: ");
            int v = 0, n = int.Parse(Console.ReadLine());
            
            while (v < n)
            {
                v++;
                Console.WriteLine($"\n ~ Ingrese un número cualquiera: ");
                double num = double.Parse(Console.ReadLine());

                sumatoria += num;
            }

            if (v < n) Console.WriteLine($" La sumatoria es mayor que 100. \n El total es: {sumatoria}"); 
            else Console.WriteLine($" La sumatoria es menor de 100. \n El total es: {sumatoria}");
        }
    }
}
