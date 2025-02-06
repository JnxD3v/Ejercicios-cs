using System;
//  Calcular el promedio de las 4 notas de un estudiante y determinar si aprobó o
//  reprobó, sabiendo que, para aprobar, la nota mínima es 70 puntos. Mostrar en
//  pantalla el promedio de las calificaciones y el mensaje que indique si aprobó o reprobó.

namespace Gamalier10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3, n4, promedio;

            Console.Write(" ~ Ingrese las 1ra calificacion del estudiante: ");
            n1 = double.Parse(Console.ReadLine());
            Console.Clear();

            Console.Write(" ~ Ingrese las 2da calificacion del estudiante: ");
            n2 = double.Parse(Console.ReadLine());
            Console.Clear();

            Console.Write(" ~ Ingrese las 3ra calificacion del estudiante: ");
            n3 = double.Parse(Console.ReadLine());
            Console.Clear();

            Console.Write(" ~ Ingrese las 4ta calificacion del estudiante: ");
            n4 = double.Parse(Console.ReadLine());
            Console.Clear();

            promedio = (n1 + n2 + n3 + n4) / 4;

            if (promedio > 69) Console.WriteLine($" Felicidades! Aprobaste. \n Tu promedio es: {promedio}");
            else Console.WriteLine($" Lo siento, has reprobado. \n Tup romedio es: {promedio}");
        }
    }
}
