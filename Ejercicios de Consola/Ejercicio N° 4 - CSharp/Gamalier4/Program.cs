using System;
//Leer 5 números por teclado y calcular el promedio, luego imprimir el resultado.
//Para obtener el promedio, se realiza sumando las cantidades y luego se divide entre ellas.
namespace Gamalier4
{
    class Program
    {
        static void Main(string[] args)
        {
            float num1, num2, num3, num4, num5, promedio;

            Console.WriteLine(" ~Ingrese los 5 números que desea promediar: ");
            num1 = float.Parse(Console.ReadLine());
            num2 = float.Parse(Console.ReadLine());
            num3 = float.Parse(Console.ReadLine());
            num4 = float.Parse(Console.ReadLine());
            num5 = float.Parse(Console.ReadLine());

            Console.WriteLine($" ~ El promedio es de: {promedio = (num1 + num2 + num3 + num4 + num5) / 5}");
        }
    }
}