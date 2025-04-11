using System;

namespace Ej_Interfaz1
{
    class Program
    {
        static void Main()
        {
            IVehiculo Auto = new Auto();
            IVehiculo Moto = new Moto();

            Console.WriteLine(" Auto: ");
            Auto.Conducir();

            Console.ReadLine();

            Console.WriteLine(" Moto: ");
            Moto.Conducir();
        }
    }

    interface IVehiculo
    {
        void Conducir();
    }

    class Moto : IVehiculo
    {
        public void Conducir() 
        {
            Console.WriteLine(" [+] Las motos se pueden conducir.");
        }
    }

    class Auto : IVehiculo
    {
        public void Conducir()
        {
            Console.WriteLine(" [-] Los autos se pueden conducir.");
        }
    }
}
