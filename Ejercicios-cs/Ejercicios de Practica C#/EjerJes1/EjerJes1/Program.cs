using System;

namespace EjerJes1
{
    class Program
    {

        static void Main(string[] args)
        {
            // Escribe un algoritmo que cuente todos los Si y no que pongas.
            int no = 0;
            int si = 0;
            string respuesta;
            bool Ki = false;



            while (!Ki)
            {
                Console.WriteLine(" ~ ¿Estas durmiendo?");
                string nose = Console.ReadLine();

                if (nose == "si") si++;
                else no++;

                if (nose != "si" && nose != "no")
                {
                    Console.WriteLine("Haz escrito una respuesta incorrecta, fin del programa.");
                    Ki = true;
                }
            }

            Console.WriteLine("Gracias por las respuestas!");
            Console.WriteLine($" En total: \n Respondiste: {no} No \n Respondiste: {si} Si");

        }
                
    }

}
