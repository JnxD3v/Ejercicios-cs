using System;
//      Crear un programa que permita calcular el sueldo neto de un empleado, partiendo del pago por hora 
//      y las horas trabajadas, aplicar un descuento de AFP que es 2.87% y SFS que es el 3.04%, sumar los
//      descuentos y luego debe restarlos del sueldo bruto.
namespace Gamalier2
{
    class Program
    {
        static void Main(string[] args)
        {
            double sueldoNeto, pagoPorHora, horasTrabajadas, descuentoTotal, sueldoBruto;
            
            Console.Write(" ~ Ingrese sus horas trabajadas: ");
            horasTrabajadas = double.Parse(Console.ReadLine());

            Console.Write(" ~ Ingrese su pago por hora: ");
            pagoPorHora = double.Parse(Console.ReadLine());
            sueldoBruto = pagoPorHora * horasTrabajadas;

            descuentoTotal = sueldoBruto * (0.0287 + 0.0304);

            sueldoNeto = sueldoBruto - descuentoTotal;

            Console.WriteLine($" Su sueldo antes de descuentos es: {sueldoBruto}");
            Console.WriteLine($" Su sueldo final es: {sueldoNeto}");
        }

    }

}

