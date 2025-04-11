using System;
using System.Threading.Channels;
// Crear un arreglo que almacene 10 números enteros, otro arreglo que almacene 10 números
// Enteros y un tercer arreglo que almacene la suma de los arreglos anteriores, mostrar
// en pantalla los resultados.

namespace Ejercicio_28_10_2024
{
    class Program
    {
        private static int[] numeros1 = new int[10], numeros2 = new int[10];
        private static int[] resultado = new int[1];
        private static int total1, total2;

        static void Main(string[] args)
        {
            Sumatoria();
        }

        static void Sumatoria()
        {
            Console.WriteLine("    ~ Sumatoria de arrays.");
            Console.WriteLine(" Ingrese los 1ros 10 Números: "); 
            for (int i = 0; i < 10; i++)
            {
                Console.Write(" ~ Ingrese un número: ");
                numeros1[i] = int.Parse(Console.ReadLine());
                total1 = numeros1[i] + numeros2[i];

                // TODO: 
            }

            Console.WriteLine("\n Ingrese los otros 10 Números: ");
            for (int i = 0;i < 10; i++)
            {
                Console.Write(" ~ Ingrese un número: ");
                numeros1[i] = int.Parse(Console.ReadLine());
                total2 = numeros1[i] + numeros2[i];

                // TODO:
            }

            Console.WriteLine(resultado[0] = total2 + total1);
        

        }
    }
}
