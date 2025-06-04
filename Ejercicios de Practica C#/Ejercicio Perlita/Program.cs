using System;

namespace Ejercicio_Perlita
{
    class Program
    {
        static void Main(string[] args)
        {
            Dispositivo dispositivo = new Dispositivo();

            Console.WriteLine(" Variante #1");
            Console.WriteLine(" ~ Ingrese el Tipo, Color & Marca del dispositivo: \n  (En ese orden)");
            dispositivo.Dispositive(Console.ReadLine(), Console.ReadLine(), Console.ReadLine());
            Console.WriteLine(dispositivo.todo);

            Console.WriteLine(" \n Variante #2 \n");
            dispositivo.Disp();

        }
    }

    class Dispositivo
    {
        public void Disp()
        {
            string[] Dispositivo = new string[3];
            Console.Write(" ~ Ingrese el tipo de dispositivo: ");
            Dispositivo[0] = Console.ReadLine();

            Console.Write(" ~ Ingrese el color del dispositivo: ");
            Dispositivo[1] = Console.ReadLine();

            Console.Write(" ~ Ingrese la marca del dispositivo: ");
            Dispositivo[2] = Console.ReadLine();

            Console.WriteLine(" - - - - - - - - - - - - - - - - ");
            Console.WriteLine("|   Tipo   |  Color   |   Marca   |");
            Console.WriteLine(" - - - - - - - - - - - - - - - - ");
            Console.WriteLine("|   {0}   |   {1}   |   {2}   |", Dispositivo[0], Dispositivo[1], Dispositivo[2]);
            Console.WriteLine(" - - - - - - - - - - - - - - - - ");
        }

        public string todo;
        public string Dispositive(string tipo, string color, string marca)
        {
            todo = "\n ~ El tipo es: " + tipo + "\n ~ El color es: " + color + "\n ~ La marca es: " + marca;
            return todo;
        }
    }
}
