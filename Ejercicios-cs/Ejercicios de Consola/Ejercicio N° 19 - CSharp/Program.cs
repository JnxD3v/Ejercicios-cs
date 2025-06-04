using System;
using System.Text;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;

//      Crear un programa que introduzca el sueldo de un empleado y aplicar un incentivo 
//      si tiene hijos y aplicar 500 por cada hijo que tenga. Mostrar en pantalla el sueldo,
//      numero de hijos y el incentivo correspondiente, siempre y cuando tenga hijos.

namespace Gamalier19
{
    class ConWhile
    {
        static void Main(string[] args)
        {
            ConIF con = new ConIF();
            con.ConIf();

            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" // Versión con el bucle While. \n");
            Console.ResetColor();
            int sueldo, hijos;
            int incentivo = 0;
            int vueltas = 0;

            Console.WriteLine(" ~ Ingrese su sueldo:");
            sueldo = int.Parse(Console.ReadLine());

            Console.WriteLine(" ~ ¿Cuantos hijos tiene?");
            hijos = int.Parse(Console.ReadLine());

            if (hijos > 0)
            {
                while (vueltas < hijos)
                {
                    vueltas++;
                    incentivo += 500;
                }

                Console.WriteLine($" ~ Usted tiene {hijos} hijos");
                Console.WriteLine($" # Su sueldo base es: RD${sueldo}");
                Console.WriteLine($" # Su sueldo con los incentivos es: RD${sueldo + incentivo}");
                Console.WriteLine($" # Los incentivos totales son: RD${incentivo}");

            }
            else
            {
                Console.WriteLine(" ¡Lo sentimos! Usted no tiene hijos. Por ende no recibira incentivo/s.");
                Console.WriteLine($" Su sueldo total es: RD${sueldo}");
            }
        }
    }

    public class ConIF
    {
        public void ConIf() 
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" // Versión con el condicional IF. \n");
            Console.ResetColor();
            int sueldo, hijos, incentivo = 0;

            Console.WriteLine(" ~ Ingrese su sueldo:");
            sueldo = int.Parse(Console.ReadLine());
            
            Console.WriteLine(" ~ ¿Cuantos hijos tiene?");
            hijos = int.Parse(Console.ReadLine());

            if (hijos > 0)
            {
                Console.WriteLine($" Su sueldo total es: RD${sueldo}");
                Console.WriteLine($" Usted tiene {hijos} hijos.");
                Console.WriteLine($" Su incentivo total fue: RD${incentivo = hijos * 500}");
                Console.WriteLine();
                Console.WriteLine($" ~ Su sueldo con incentivos es: RD${sueldo + incentivo}");
                
            } else
            {
                Console.WriteLine(" ¡Lo sentimos! Usted no recibira incentivo/s.");
                Console.WriteLine($" Usted no tiene hijos :(");
                Console.WriteLine($" Su sueldo total es: RD${sueldo}");

            }

            Console.ReadLine();
        }
    }
}
