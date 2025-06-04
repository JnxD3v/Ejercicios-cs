using System;
// Imprimir un patrón triangular con asteriscos (*) utilizando bucles anidados.
// Un bucle anidado es aquel que este compuesto de un bucle dentro de otro bucle.
// Para esto, debe definir el rango en el primer bucle y en el segundo, definir 
// desde 1 hasta la variable del contador del primer bucle.
namespace Ejercicio_9
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Console.Clear();

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}

