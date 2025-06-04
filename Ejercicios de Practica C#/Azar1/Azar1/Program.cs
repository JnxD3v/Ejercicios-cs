using System;

namespace Azar1
{
    class Program
    {

        static void Main(string[] args)
        {
            // Elabore un algoritmo que diga si el número ingresado es mayor, menor o igual a cero.
            string continuar = string.Empty;

            do { 

                bool ex = false;
                int N = 0;
                Console.WriteLine(" ~ - ~ - ~ - ~ - ~ - ~ - ~ ");

                /* Se puede comprobar si la variable "ex" contiene una excepcion dentro? */
  
                while (!ex)
                {
                    try
                    {
                        Console.Write(" ~ Ingrese un número: ");
                        N = int.Parse(Console.ReadLine());
                        ex = true;
                        break; 
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Error! Por favor intente de nuevo.");
                    }
                }

                // Continúa el programa con un valor válido para N





                if (N == 0)
                {
                    Console.WriteLine("El número es igual a cero (=)");
                }
                else if (N > 0)
                {
                    Console.WriteLine("El número es mayor que cero (>)");
                }
                else if (N < 0)
                {
                    Console.WriteLine("El número es menor que cero (<)");
                }
                Console.WriteLine("~-~~-~~-~~-~~-~~-~~-~~-~~-~~-~~-~~-~~-~~-~");
                Console.WriteLine(" ~ ¿Desea ingresar otro número? (Si / No)");
                try
                {
                    continuar = Console.ReadLine();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error! Respuesta invalida. Intente de nuevo");
                }
                
            } while (continuar == "Si" || continuar == "si");
            Console.WriteLine("Fin!");

        }

    }

}
