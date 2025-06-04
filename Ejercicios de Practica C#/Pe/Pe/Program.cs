using System;
using System.Numerics;

namespace Ejemplo
{
    class Ejemplo
    {
        public static void Main(string[] args)
        {
            Doxeo();
            //string continuar;
            //do
            //{
            //    Ejxmplo();

            //    Console.WriteLine(" ~ ¿Desea seguir sumando números?");
            //    continuar = Console.ReadLine().ToLower();
            //    Console.Clear();

            //} while (continuar == "SI".ToLower());
        }

        //public static BigInteger Ejxmplo()
        //{ 

        //    Console.WriteLine(" ~ Ingrese el numero 1:");
        //    BigInteger N1 = BigInteger.Parse(Console.ReadLine());

        //    Console.WriteLine(" ~ Ingrese el numero 2:");
        //    BigInteger N2 = BigInteger.Parse(Console.ReadLine());

        //    Console.Clear();

        //    Console.WriteLine($" El resultado es: {N1 + N2}");
        //    return N1 + N2;
        
        //}

        public static void Doxeo()
        {
            for (int i = 0; i < 200; i++)
            {
                Console.WriteLine(" Francisco vive en villa cesarina, Tiene 16 años, y le gusta el nepe. (Y arleni)");
            }
        }
    }
}