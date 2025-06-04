using System;

namespace Ejercicio_4
// Calcular la suma de los primeros 100 numeros naturales.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            double resultado;
            double promedio;

            for (int i = 0; i < 100; i++) n++;

            resultado = (n * (n + 1)) / 2;
            promedio = resultado / 100;
            Console.WriteLine("\n La suma de los primeros 100 numeros naturales es: {0} \n El promedio de los primeros 100 numeros naturales es: {1}", resultado, promedio);
        }
    }
}
