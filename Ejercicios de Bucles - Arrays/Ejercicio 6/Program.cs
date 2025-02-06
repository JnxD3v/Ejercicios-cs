using System;
// Imprimir los números impares del 1 al 30.
namespace Ejercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int numeroImpar = 1; numeroImpar < 30; numeroImpar = numeroImpar + 2) Console.WriteLine("# {0}", numeroImpar);
        }
    }
}