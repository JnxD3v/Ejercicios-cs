using System;
//  Crea un programa que permita introducir la edad y el sexo de una persona,
//  y determine si puede entrar o no a una discoteca, tomando en cuneta lo siguiente.
//  Si es hembra, entra gratis, si es varón, entra pagando, pero no pueden entrar si
//  son menores de edad.
namespace Gamalier8
{
    internal class Program
    {
        static void Main()
        {
            int sexoPersona;
            int edadPersona;

            Console.WriteLine(" Ingrese su edad: ");
            edadPersona = int.Parse(Console.ReadLine());

            if (edadPersona > 17)
            {
                Console.WriteLine(" Ingrese su género (1. Masculino, 2. Femenino): ");
                sexoPersona = int.Parse(Console.ReadLine());

                if (sexoPersona == 1) Console.WriteLine(" Puede entrar, el costo de entrada es: 5,000$");
                else if (sexoPersona == 2) Console.WriteLine(" ¡Usted es mujer y puede entrar gratis!  (Feminismo Extremo por cierto)");
                else if (sexoPersona != 1 && sexoPersona != 2)
                {
                    Console.Clear();
                    Console.WriteLine(" Error! El genero ingresado es invalido, Intente de nuevo.");
                    Main();
                }
                

            }
            else Console.WriteLine("Usted es menor de edad y no puede entrar, vuelva en otro momento.");

        }

    }

}
