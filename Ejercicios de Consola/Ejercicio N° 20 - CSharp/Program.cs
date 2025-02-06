using System;

//  Crear un programa que calcule el promedio de las 4 notas de un estudiante, determine si

//  aprobó, reprobó, tomando en cuenta que para aprobar la nota mínima es 70 puntos, si reprobó,

//  entonces el estudiante ira a completivo, para esto se calcula el 50% de la nota promedio,

//  colocar la nota del examen o prueba y este tambien se calcula el 50% , el resultado de la 

//  nota completiva ses sumando los resultados de los 50%. Si aprueba debe mostrar en pantalla 

//  la nota y determinar si aprobó o reprobó o reprobo la nota completiva. Si reprobó, entonces

//  el estudiante ira a extraordinario, donde se calculara el 30% de la nota promedio, se 

//  introduce la nota de la prueba extraordinaria y calcular el 70% de dicha nota. El resultado

//  de la calificacion extraordinaria es sumando el resultado del 30 y del 70%. Si el estudiante

//  aprobó, se debe mostrar en pantalla que aprobo, colocando la nota y el mensaje, de lo contrario

//  reprobó. Mostrar en pantalla el nombre, la materia, la calificacion obtenida, ya sea normal

//  completivo o extraordinario y la situacion si aprobo o reprobo.

namespace Gamalier20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double promedio, p1, p2, p3, p4, notaExtraordinario, notaCompletivo;
            bool completivo = false;
            bool extraordinario = false;
            bool situ = false;
            string situacion, nombre;

            Console.Write(" Ingrese su nombre estimado/a: ");
            nombre = Console.ReadLine();
            Console.Clear();

            Console.Write(" Ingrese la 1ra calificación: ");
            p1 = double.Parse(Console.ReadLine());
            Console.Clear();

            Console.Write(" Ingrese la 2da calificación: ");
            p2 = double.Parse(Console.ReadLine());
            Console.Clear();

            Console.Write(" Ingrese la 3ra calificación: ");
            p3 = double.Parse(Console.ReadLine());
            Console.Clear();

            Console.Write(" Ingrese la 4ta calificación: ");
            p4 = double.Parse(Console.ReadLine());
            Console.Clear();

            promedio = (p1 + p2 + p3 + p4) / 4;

            switch (situ)
            {
                case true:
                    situacion = "Aprovado";
                    break;

                case false:
                    situacion = "Reprobado";
                    break;

                default:
                    situacion = "Cancelando error jaja";
                    break;
            }

            if (promedio >= 70)
            {
                situ = true;
                switch (situ)
                {
                    case true:
                        situacion = "Aprovado";
                        break;

                    case false:
                        situacion = "Reprobado";
                        break;

                    default:
                        situacion = "Cancelando error jaja";
                        break;
                }
                
                Console.WriteLine($" El estudiante {nombre} ha aprovado , Mis Felicitaciones!");
                Console.WriteLine($" ~ Su calificación promedio fue de: {promedio}   |   Situacion: {situacion}!");
            }
            else
            {
                Console.Clear();
                Console.WriteLine(" Usted ha reprobado, ira a completivo :(");
                completivo = true;
            }

            if (completivo == true)
            {
                Console.Write(" Ingrese la nota de su examen en completivo: ");
                notaCompletivo = double.Parse(Console.ReadLine());
                Console.Clear();

                notaCompletivo = notaCompletivo * 0.5 + promedio * 0.5;

                if (notaCompletivo < 70)
                {
                    Console.WriteLine(" Usted ha reprobado completivo. Ira para extraordinario.");
                    extraordinario = true;
                }
                else
                {
                    situ = true;
                    Console.WriteLine($" Felicidades! Has aprovado el completivo {nombre}.");
                    Console.WriteLine($" ~ Su calificación completiva fue de: {notaCompletivo}   |   Situacion: {situacion}!");
                }
            }

            if (extraordinario == true)
            {
                Console.Write(" Ingrese la nota de su examen extraordinario: ");
                notaExtraordinario = double.Parse(Console.ReadLine());
                Console.Clear();

                notaExtraordinario = notaExtraordinario * 0.7 + promedio * 0.3;

                if (notaExtraordinario < 70)
                {
                    Console.WriteLine(" Usted ha reprovado el extraordinario. (Que bruto)");
                    Console.WriteLine($" ~ Su calificación extraordinaria fue de: {notaExtraordinario}   |   Situacion: {situacion}!");
                }
                else
                {
                    situ = false;
                    Console.WriteLine($" Felicidades! Haz aprovado el extraordinario {nombre}, Esfuerzate más para la proxima.");
                    Console.WriteLine($" ~ Su calificación extraordinaria fue de: {notaExtraordinario}   |   Situacion: {situacion}!");
                }
            }
        }
    }
}
