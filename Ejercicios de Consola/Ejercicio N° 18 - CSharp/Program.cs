using System;
using System.Runtime.ConstrainedExecution;

//    Crear un programa que permita determinar si le corresponde incentivos a un empleado,
//    tomando en cuenta la producción semanal que se realiza desde el lunes hasta el 
//    viernes, cada día se debe registrar la producción y obtener el promedio de esta,
//    si el promedio es mayor o igual a 20,000 unidades, le corresponde un incentivo 
//    de 3,000 pesos, de lo contrario, colocar un mensaje que indica “N/A”. Mostrar
//    en pantalla el total e la producción de la semana, el promedio de la producción 
//    y el incentivo que corresponde.

namespace Gamalier18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int prodLunes, prodMartes, prodMiercoles, prodJueves, prodViernes, promedio;

            Console.Write("\n ~ Ingrese la producción del Lunes: ");
            prodLunes = int.Parse(Console.ReadLine());

            Console.Write(" ~ Ingrese la producción del Martes: ");
            prodMartes = int.Parse(Console.ReadLine());

            Console.Write(" ~ Ingrese la producción del Miercoles: ");
            prodMiercoles = int.Parse(Console.ReadLine());

            Console.Write(" ~ Ingrese la producción del Jueves: ");
            prodJueves = int.Parse(Console.ReadLine());

            Console.Write(" ~ Ingrese la producción del Viernes: ");
            prodViernes = int.Parse(Console.ReadLine());
            Console.WriteLine();

            promedio = (prodLunes + prodMartes + prodMiercoles + prodJueves + prodViernes)/5;

            if (promedio >= 20000)
            {
                Console.WriteLine($"  El promedio de su producción fue: {promedio}");
                Console.WriteLine($" ¡Felicidades! Usted recibira un incentivo de: 3000$");
            }
            else 
            {
                Console.WriteLine($" ¡Lo sentimos! Usted no recibira incentivo.");
                Console.WriteLine($"  El promedio de su producción fue: {promedio}");
            }
        }
    }
}
