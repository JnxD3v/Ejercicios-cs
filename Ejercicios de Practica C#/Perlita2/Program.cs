using System;

namespace Perlita2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dispositivo dispositivo = new Dispositivo();
            dispositivo.Disp();
            dispositivo.Accion1();
            dispositivo.Accion2();
        }
    }

    class Dispositivo
    {
        string[] atributos = new string[3];

        public void Disp()
        {
            Console.WriteLine(" ~ Ingrese el tipo de dispositivo: ");
            atributos[0] = Console.ReadLine();

            Console.WriteLine(" ~ Ingrese el color del dispositivo: ");
            atributos[1] = Console.ReadLine();

            Console.WriteLine(" ~ Ingrese la marca del dispositivo: ");
            atributos[2] = Console.ReadLine();

            Console.WriteLine($" \n ~ El tipo del dispositivo es: {atributos[0]} \n ~ El color del dispositivo es: {atributos[1]} \n ~ La marca del dispositivo es: {atributos[2]} \n");
        }

        public void Accion1() => Console.WriteLine("El dispositivo enciende.");
        public void Accion2() => Console.WriteLine("El dispositivo apaga.");
    }
}
