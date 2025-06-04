using System;
using System.Threading.Channels;
// 2. Crear un programa que introduzca el precio de un articulo y aplique un descuento con la siguiente escala:

//  Escala Porcentaje
//  de 1,000 a 5,000                       3%
//  de 5,001 a 10,000                      5%
//  de 10,001 a 15,000                     8%
//  de 15,001 a 20,000                     10%
namespace Gamalier9
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double descuento;

            Console.WriteLine(" ~ Ingrese el precio del articulo: ");
            double precioArticulo = double.Parse(Console.ReadLine());

            if (precioArticulo >= 1000 && precioArticulo <= 5000)
            {
                descuento = precioArticulo * 0.97;
                Console.WriteLine($" ~ Su producto tiene un descuento del 3% \n ~ El precio final es: {descuento}");
            }
            else if (precioArticulo >= 5001 && precioArticulo <= 10000)
            {
                descuento = precioArticulo * 0.95;
                Console.WriteLine($" ~ Su producto tiene un descuento del 5% \n ~ El precio final es {descuento}");
            }
            else if (precioArticulo >= 10001 && precioArticulo <=15000)
            {
                descuento = precioArticulo * 0.92;
                Console.WriteLine($" ~ Su producto tiene un descuento del 8% \n ~ El precio final es {descuento}");
            }
            else if (precioArticulo >= 15001 && precioArticulo <= 20000)
            {
                descuento = precioArticulo * 0.90;
                Console.WriteLine($" ~ Su producto tiene un descuento del 10% \n ~ El precio final es {descuento}");
            }
        }
    }
}
