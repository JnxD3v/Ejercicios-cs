using System;

namespace _26_8_2024
{
    class Program
    {

        static void Main(string[] args)
        {

            bool alive = false;

            while (alive) {
                eat();
                sleep();
                code();

            }

            Console.WriteLine("Te moriste (Jaja que pendejo)");
                
        }

        static void eat() {
            Console.WriteLine("Como comidita :3");
        }

        static void sleep()
        {
            Console.WriteLine("Duermo..");
        }

        static void code()
        {
            Console.WriteLine("Programo..");
        }
    }

}
