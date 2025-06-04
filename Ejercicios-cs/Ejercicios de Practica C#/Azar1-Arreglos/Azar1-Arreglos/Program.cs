using System;

namespace Azarmichi
{
    class Program
    {
        static void Main(string[] args)
        {
            // (Arreglos / Edicion) hecha por francisco


            string continuar;

            do
            {
                int N = 0;
                bool exito = false;

                while (!exito)
                {
                    try
                    {
                        Console.Write(" ~ Ingrese un número: ");
                        N = int.Parse(Console.ReadLine());
                        exito = true;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Error! Por favor intente de nuevo.");
                    }
                }

                if (N == 0) Console.WriteLine("El número es igual a cero (=)");

                else if (N > 0) Console.WriteLine("El número es mayor que cero (>)");

                else Console.WriteLine("El número es menor que cero (<)");

                Console.WriteLine(" ~ ¿Desea ingresar otro número? (Si / No)");
                continuar = Console.ReadLine().ToLower();

            } while (continuar == "si");

            Console.WriteLine("Fin!");
        }
    }
}