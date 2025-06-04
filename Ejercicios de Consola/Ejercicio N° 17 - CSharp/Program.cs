using System;
using System.Threading.Tasks;
//      Crear un programa que permita calcular el ISR de un empleado, partiendo del
//      sueldo de este. Para ello, debe investigar como se realiza el calculo del ISR de este país,
//      también debe investigar la escala impositiva en el sitio web de la DGII, dicha escala es
//      correspondiente a este año en curso. Si el sueldo no aplica para descuento de ISR,
//      mostrar en esa sección un mensaje que diga “No Aplica” o “N/A”. mostrar en pantalla
//      el sueldo, el descuento de AFP y SFS, el ISR y el sueldo neto.

// ​Según DGII.
//Escala anual	                                    Tasa
//Rentas hasta RD$416,220.00	                    Exento
//Rentas desde RD$416,220.01 hasta RD$624,329.00	15% del excedente de RD$416,220.01
//Rentas desde RD$624,329.01 hasta RD$867,123.00	RD$31,216.00 más el 20% del excedente de RD$624,329.01
//Rentas desde RD$867,123.01 en adelante	        RD$79,776.00 más el 25% del excedente de RD$867,123.01

namespace Gamalier17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double ISR, AFP, SFS, sueldoISR, sueldoBruto, sueldoNeto;


            Console.WriteLine("   Calculadora de ISR (Impuesto Sobre la Renta)");
            Console.Write(" ~ Ingrese su sueldo Anual: ");
            sueldoBruto = double.Parse(Console.ReadLine());
            AFP = sueldoBruto * 0.0287;
            SFS = sueldoBruto * 0.0304;

            if (sueldoBruto < 416220)
            {
                Console.WriteLine("\n     ¡Calculo completado!");
                Console.WriteLine($" No aplica.");
                Console.WriteLine($" # Su sueldo bruto es: {sueldoBruto}");
                Console.WriteLine($" # Su sueldo con el descuento AFP & ISR es: {sueldoBruto - (AFP + SFS)}");

            } 
            else if (sueldoBruto >= 416220 && sueldoBruto < 624329)
            {

                ISR = (sueldoBruto - 416220) * 0.15;
                sueldoISR = sueldoBruto - ISR;
                sueldoNeto = sueldoISR - (AFP + SFS);

                Console.WriteLine("\n     ¡Calculo completado!");
                Console.WriteLine($" # Su sueldo bruto es: RD${sueldoBruto}");
                Console.WriteLine($" # Su ISR (Impuesto Sobre la Renta) es: RD${ISR}");
                Console.WriteLine($" # Su sueldo neto (descuento AFP, SFS & ISR): RD${sueldoNeto}");

            } 
            else if (sueldoBruto >= 624329 && sueldoBruto < 867123) 
            {
                ISR = 31216 + (sueldoBruto - 624329) * 0.20;
                sueldoISR = sueldoBruto - ISR;
                sueldoNeto = sueldoISR - (AFP + SFS);

                Console.WriteLine("\n     ¡Calculo completado!");
                Console.WriteLine($" # Su sueldo bruto es: RD${sueldoBruto}");
                Console.WriteLine($" # Su ISR (Impuesto Sobre la Renta) es: RD${ISR}");
                Console.WriteLine($" # Su sueldo neto (descuento AFP, SFS & ISR): RD${sueldoNeto}");
            } 
            else if (sueldoBruto >= 867123)
            {
                ISR = 79776 + (sueldoBruto - 867123) * 0.25;
                sueldoISR = sueldoBruto - ISR;
                sueldoNeto = sueldoISR - (AFP + SFS);

                Console.WriteLine("\n     ¡Calculo completado!");
                Console.WriteLine($" # Su sueldo bruto es: RD${sueldoBruto}");
                Console.WriteLine($" # Su ISR (Impuesto Sobre la Renta) es: RD${ISR}");
                Console.WriteLine($" # Su sueldo neto (descuento AFP, SFS & ISR): RD${sueldoNeto}");
            }
        }
    }
}
