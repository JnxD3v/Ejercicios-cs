using System;

namespace Ejercicio_Yisus
{ 

    class program
    {
        static void Main(string[] args)
        {

            string estado;
            int vueltas = 0;
            Console.WriteLine("¿Estas durmiendo?");
            estado = Console.ReadLine().ToLower();

            while (estado == "si") {

                ++vueltas;

                Console.WriteLine($" ~ Cuenta de ovejas: {vueltas} Zzz");

                Console.WriteLine("¿Sigues durmiendo?");
                estado = Console.ReadLine().ToLower();
            
            }

            Console.WriteLine($"Contaste este numero de ovejas:  {vueltas}");

        }

    }

}

