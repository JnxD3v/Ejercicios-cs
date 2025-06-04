using System;
using System.Threading.Channels;

namespace Ejercicio_1
{
    internal class Program
    {
        static string opcion;
        static double peso, dolar;

        static void Main(string[] args)
        {
            Console.WriteLine(" Ingrese los 2 números que desea sumar: ");
            Suma(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
            Console.WriteLine();

            Console.WriteLine(" Ingrese los 2 números que desee multiplicar: ");
            multiplicacion(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
            Console.WriteLine();

            Console.WriteLine(" Ingrese el número que desee comprobar: ");
            numeroEntero(int.Parse(Console.ReadLine()));

            Console.WriteLine(" ~ Conversor de Dolar a Peso | Peso a Dolar: ");
            Console.WriteLine(" ¿Que desea convertir? \n Opciones: \n Peso a dolar: P \n Dolar a peso: D");
            opcion = Console.ReadLine().ToLower();
            dolaryPeso();
            
        }

        // Suma de dos números enteros.
        static int Suma(int n1, int n2)
        {
            int resultado = n1 + n2; 
            Console.WriteLine("La suma es: {0}", resultado);
            return n1 + n2;
        }

        // Multiplicación de dos números enteros.
        static int multiplicacion(int n1, int n2) 
        {
            int resultado = n1 * n2;
            Console.WriteLine(" La multiplicación es: {0}", resultado);
            return n1 * n2;
        }

        // Comprobador si el número es par o impar.
        static int numeroEntero(int N)
        {
            string Par = "El número es par. \n", Impar = "El número es impar. \n ";

            if (N % 2 == 0)
            {
                Console.WriteLine("{0}", Par);
            } else
            {
                Console.WriteLine("{0}", Impar);
            }
            return N;
        }


        // Conversor de dolar a peso y de peso a dolar.
        static void dolaryPeso()
        {
            if (opcion == "d")
            {
                Console.Write(" ~ Ingrese los dolares que quiere convertir a peso: ");
                dolarAPeso();
            }
            else if (opcion == "p")
            {
                Console.Write(" ~ Ingrese los pesos que quiere converitr a dolar: ");
                pesoADolar();
            }
        }

        static void pesoADolar()
        {
            peso = double.Parse(Console.ReadLine());
            dolar = peso * 0.0179;

            Console.WriteLine(" El resultado es: {0}", dolar);
        }

        static void dolarAPeso()
        {
            dolar = double.Parse(Console.ReadLine());
            peso = dolar * 60.17;

            Console.WriteLine(" El resultado es: {0}", peso);
        }
    }
}
