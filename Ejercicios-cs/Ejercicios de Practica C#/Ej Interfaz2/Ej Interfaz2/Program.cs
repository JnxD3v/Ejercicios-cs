using System; // OwO

namespace Ej_Interfaz2
{
    class Program
    {
        static void Main()
        {
            IAve Loro1 = new Loro();
            IAve Avestruz1 = new Avestruz();

            Loro1.NombreAnimal("Lorito");
            Loro1.Volar();
            Loro1.Cantar();

            Console.ReadLine();

            Avestruz1.NombreAnimal("Vice");
            Avestruz1.Volar();
            Avestruz1.Cantar();
        }
    }

    interface IAve
    {
        void NombreAnimal(string nombre);
        void Volar();
        void Cantar();
    }

    class Loro : IAve
    {
        public void NombreAnimal(string nombre) => Console.WriteLine(" El ave: " + nombre);
        public void Volar()
        {
            Console.WriteLine(" ¡Este loro puede volar!");
        }
        public void Cantar()
        {
            Console.WriteLine(" Este loro hace: Creek!");
        }
    }
    class Avestruz : IAve
    {
        public void NombreAnimal(string nombre) => Console.WriteLine(" El ave: " + nombre);
        public void Volar()
        {
            Console.WriteLine(" ¡Esta avestruz no puede volar!");
        }
        public void Cantar()
        {
            Console.WriteLine(" Este avestruz hace: gReskqs!");
        }
    }
}
