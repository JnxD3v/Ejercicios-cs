using System;
// Calcular los números ingresados por el usuario hasta que ingrese un cero (0).
// Mostrar en pantalla el resultado de la sumatoria.
namespace Ejercicio_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ~ Ingrese los números que desee sumar. \n Cuando ingrese un cero el programa se detendrá.");
            int num = int.Parse(Console.ReadLine());
            int resultado = 0;


            while (num != 0) 
            {
                resultado = resultado + num;
                Console.Write(" * Ingrese otro número: ");

                num = int.Parse(Console.ReadLine());   
            }

            Console.WriteLine(" Ha ingresado un cero, el programa se ha detenido.");
            Console.WriteLine(" El resultado es: {0}", resultado);
        }
    }
}
