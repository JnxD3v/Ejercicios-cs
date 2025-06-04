using System;

namespace Ejercicio_I
{
    class Program
    {

        static void Main(string[] args)
        {
            // Elabora un algoritmo que te diga un numero aleatorio.
            // Que pida al usuario un numero y que diga al usuario cuantos intentos le costo adivinarlo.

            Random numero = new Random();
            int numeroRandom = numero.Next(0, 100);
            int miNumero = 0;
            int intentos = 0;

            Console.WriteLine("  Ingrese un numero cualquiera:");

            do
            {
                intentos++;

                miNumero = int.Parse(Console.ReadLine());
                //try
                //{
                //    miNumero = int.Parse(Console.ReadLine());
                //}
                //catch (Exception e)
                //{
                //    Console.WriteLine("Error al ingresar el número. Favor intente de nuevo.");
                //    miNumero = -1;
                //    Console.WriteLine(e);
                //}

                if (miNumero == -1)
                {
                   
                } else
                {
                    if (miNumero > numeroRandom)
                    {
                        Console.WriteLine(" El número es mayor.");
                    }

                    else if (miNumero < numeroRandom)
                    {
                        Console.WriteLine(" El número es menor.");
                    }
                }


            } while (miNumero != numeroRandom);

            Console.WriteLine($"Felicidades! Has acertado en {intentos} intentos.");

        }

    }

}
