using System;
using System.ComponentModel.DataAnnotations.Schema;
// Realizar la tabla de multiplicar de un numero especifico del 1 al 12,
// por ejemplo: “2 x 3 = 6”, imprimir la tabla en pantalla.
namespace Ejercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("     * Tabla de Multiplicar *");
            Console.Write(" * Ingrese el número que quiera: ");
            int tabla = 1, numero = int.Parse(Console.ReadLine());

            for (int i = 0; i < 12; i++) 
            {
                int resultado = numero * tabla;
                Console.WriteLine(" # {0} x {1} = {2}", numero, tabla, resultado);
                tabla++;
            }
        }
    }
}
