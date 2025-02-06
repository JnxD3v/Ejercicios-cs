using System;
using System.Linq.Expressions;

namespace Ejercicio_Fran
{
    class Program
    {

        static void Main(string[] args)
        {

            Calculadora();

        }

        public static void Calculadora()
        {

            double Numero1 = 0;
            double Numero2 = 0;
            string operacion;
            double resultado = 0;

            Console.WriteLine("- - - - - - - - - - - - - - -");
            Console.WriteLine("         Calculadora");
            Console.WriteLine("- - - - - - - - - - - - - - -");
            Console.WriteLine("  ~ Ingrese el 1er número:");
            Numero1 = double.Parse(Console.ReadLine());

            Console.WriteLine("  ~ Ingrese la operación que desee:");
            operacion = (Console.ReadLine());

            Console.WriteLine("  ~ Ingrese el 2do número:");
            Numero2 = double.Parse(Console.ReadLine());

            switch (operacion)
            {
                case "+":
                    Console.WriteLine($"La suma es igual a: {resultado = Numero1 + Numero2}");
                    break;
                case "*":
                    Console.WriteLine($"La multiplicacion es igual a: {resultado = Numero1 * Numero2}");
                    break;
                case "/":
                    Console.WriteLine($"La division es igual a: {resultado = Numero1 / Numero2}");
                    break;
                case "-":
                    Console.WriteLine($"La resta es igual a: {resultado = Numero1 - Numero2}");
                    break;
                case "**":
                    Console.WriteLine($"La potencia es igual a: {Math.Pow(Numero1, Numero2)}");
                    break;

                default:
                    //try
                    //{

                    //}
                    //catch (Exception)
                    //{
                    //    Console.WriteLine("Ha ocurrido un error, intente de nuevo..");
                    //    throw;
                    //}
                    break;
            
            }

        }

    }

}

