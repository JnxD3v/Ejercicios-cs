using System;

namespace Ejercicio_4
// Calcular la suma de los primeros 100 numeros naturales.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            int resultado;

            for (int i = 0; i < 100 ; i++) n++;

            resultado = (n * (n + 1)) / 2;
            Console.WriteLine(" La suma de los primeros 100 numeros naturales es: {0}", resultado);
        }
    }
}
