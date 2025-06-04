using System.Collections.Concurrent;
using System.ComponentModel.DataAnnotations;

namespace PruebaArrays1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] datos = new string[3];

            //Console.WriteLine("     ~ Formulario ~");
            //Console.WriteLine("Por favor ingrese sus datos..");

            //Console.Write(" Ingrese su nombre: ");
            //datos[0] = Console.ReadLine();

            //Console.Write(" Ingrese su apellido: ");
            //datos[1] = Console.ReadLine();

            //Console.Write(" Ingrese su edad: ");
            //datos[2] = Console.ReadLine();

            //Console.WriteLine();
            //Console.WriteLine(" Su nombre es: {0} \n Su apellido es: {1} \n Su edad es: {2}", datos[0], datos[1], datos[2]);

            string[] Info = new string[5];
            var desc = new string[5] {"  Nombre: ", "  Apellido: ", "  Nacionalidad: ", "  Dirección: ", "  Edad: " };

            Console.Write(" Ingrese su nombre: ");
            Info[0] = Console.ReadLine();

            Console.Write(" Ingrese su apellido: ");
            Info[1] = Console.ReadLine();

            Console.Write(" Ingrese su nacionalidad: ");
            Info[2] = Console.ReadLine();

            Console.Write(" Ingrese su dirección: ");
            Info[3] = Console.ReadLine();

            Console.Write(" Ingrese su edad: ");
            Info[4] = Console.ReadLine();

            Console.WriteLine();
            int descLenght = 0;
            foreach (string infos in Info) 
            {
                Console.WriteLine(desc[descLenght] + infos);
                descLenght++;
            }
        }
    }
}
