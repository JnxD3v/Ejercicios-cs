using System;
// Leer la cantidad y precio de un artículo y calcular su importe, mostrar el resultado en pantalla.
namespace Gamalier5
{
    class Program
    {
        static void Main(string[] args)
        {

            double cantidad, precio, importe;

            Console.WriteLine(" ~ Ingrese la cantidad de el artículo:");
            cantidad = double.Parse(Console.ReadLine());

            Console.WriteLine(" ~ Ingrese el precio de el artículo:");
            precio = double.Parse(Console.ReadLine());

            Console.WriteLine($" ~ El costo del importe es: {importe = precio * cantidad}");

        }

    }

}
