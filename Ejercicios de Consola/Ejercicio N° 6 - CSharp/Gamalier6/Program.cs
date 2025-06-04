using System;
using System.Runtime.ConstrainedExecution;

//  Crear un programa que calcule la cantidad y precio de un artículo, luego calcular el
//  impuesto de ITBIS que es el 18%, aplicar un descuento de 10%, y calcular el total
//  general.
//  El ITBIS se calcula multiplicando el importe por el 18%, el descuento se
//  calcula multiplicando el importe por el 10% y el total general se calcula restando
//  el importe menos descuento más ITBIS.

namespace Gamalier6
{
    class Program
    {
        static void Main(string[] args) 
        {

            double cantidad, precio, impuesto, descuento, importe, total;

            Console.WriteLine(" ~ Ingrese la cantidad del articulo: ");
            cantidad = double.Parse(Console.ReadLine());

            Console.WriteLine(" ~ Ingrese el preio del articulo: ");
            precio = double.Parse(Console.ReadLine());

            importe = cantidad * precio;
            impuesto = importe * 0.18;
            descuento = impuesto * 0.90;
            total = importe - impuesto;

            Console.WriteLine($" El coste de importe es: {importe}");
            Console.WriteLine($" El coste impuesto es: {impuesto}");
            Console.WriteLine($" El descuento: {descuento}");
            Console.WriteLine($" El total general es: {total}");

        }
    }
}