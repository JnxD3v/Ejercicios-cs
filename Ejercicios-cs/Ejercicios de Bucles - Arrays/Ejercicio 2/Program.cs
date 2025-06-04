using System;

namespace Ejercicio_2
// Crear un programa que lea una contraseña, si es incorrecta, mostrar un mensaje que lo indique
// y tenga como máximo 3 intentos, luego después de esos intentos, mostrar un mensaje indicando
// que ha agotado el numero de intentos y el programa debe terminar.

{
    internal class Program
    {
        static void Main(string[] args)
        {
            String pass = "Pass123";

            Console.WriteLine(" ~ ¡Bienvenido/a!");
            Console.Write(" ~ Ingrese su contraseña: ");
            string UserPass = Console.ReadLine();
            int intentos = 2;
            int intentos2 = 0;

            while (UserPass != pass && intentos2 != intentos) 
            {
                intentos2++;

                Console.Write(" \n ~ Error! Contraseña incorrecta. \n ~ Intente nuevamente: ");
                UserPass = Console.ReadLine();

            }

            if (UserPass != pass) Console.WriteLine(" Lo sentimos! Ha agotado los intentos disponibles.");
            else if (UserPass == pass) Console.WriteLine(" Bienvenido/a, Se ha logueado correctamente!");
        }
    }
}
