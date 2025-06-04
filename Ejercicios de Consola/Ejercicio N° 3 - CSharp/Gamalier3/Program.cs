using System;
//      Partiendo del ejercicio 1, agregar un
//      tercer número y modificar las
//      operaciones para que cada una de ellas
//      sea en base a esos 3 en vez de 2 y
//      mostrar el resultado de cada operación.
namespace Gamalier3
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, num3, mult, div, suma, resta;
            Console.WriteLine(" ~ Ingresa los 3 números:");
            num1 = double.Parse(Console.ReadLine());
            num2 = double.Parse(Console.ReadLine());
            num3 = double.Parse(Console.ReadLine());

            Console.WriteLine($"La suma es: {suma = num1 + num2 + num3}");
            Console.WriteLine($"La resta es: {resta = num1 - num2 - num3}");
            Console.WriteLine($"La multiplicación es: {mult = num1 * num2 * num3}");
            Console.WriteLine($"La división es: {div = num1 / num2 / num3}");       
        }

    }

}