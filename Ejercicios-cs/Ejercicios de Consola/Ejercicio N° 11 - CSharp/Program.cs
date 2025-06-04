using System;
//  Partiendo del ejercicio anterior, determinar el literal según la calificación obtenida del estudiante:
//  Calificación Situación
//  90 – 100 Excelente
//  80 – 89 Muy bueno
//  75 – 79 Bueno
//  70 – 74 Regular
//  Menos de 70 deficiente

namespace Gamalier11
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

            if (promedio >= 90 && promedio <= 100) Console.WriteLine($" Felicidades! Su calificacion es Excelente. \n Tu promedio es: {promedio}");
            if (promedio >= 80 && promedio <= 89) Console.WriteLine($" Felicidades! Su calificacion es Muy Buena. \n Tu promedio es: {promedio}");
            if (promedio >= 75 && promedio <= 79) Console.WriteLine($" Felicidades! Su calificacion es Buena. \n Tu promedio es: {promedio}");
            if (promedio >= 70 && promedio <= 74) Console.WriteLine($" Felicidades! Su calificacion es regular. \n Tu promedio es: {promedio}");
            if (promedio < 69) Console.WriteLine($" ¡Lo siento! Su calificacion es deficiente y has reprobado. \n Tu promedio es: {promedio}");
        }
    }
}
