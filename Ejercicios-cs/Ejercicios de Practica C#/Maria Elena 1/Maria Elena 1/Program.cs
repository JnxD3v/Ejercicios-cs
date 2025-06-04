using System;

namespace Ejercicio_I
{
    class Program
    {

        static void Main(string[] args)
        {
            // Elaborar un algoritmo que permita ingresar 10 letras cualquiera, y luego nos indique al final
            // cuantas vocales y consonantes fueron

            string l;
            int V = 0;
            int C = 0;
            int vueltas = 0;

            while (vueltas < 10) {
                Console.WriteLine(" ~ Ingrese una letra:");
                l = Console.ReadLine();
                vueltas++;
                switch (l)
                {

                    case "a":
                        V++;
                        break;

                    case "e":
                        V++;
                        break;

                    case "i":
                        V++;
                        break;

                    case "o":
                        break;

                    case "u":
                        V++;
                        break;

                    default:
                        C++;
                        break;

                }


            }
            Console.WriteLine(" ~ En total:");
            Console.WriteLine($" Escribiste {V} Vocales. \n ~ Escribiste {V} Vocales.");

        }

    }

}
