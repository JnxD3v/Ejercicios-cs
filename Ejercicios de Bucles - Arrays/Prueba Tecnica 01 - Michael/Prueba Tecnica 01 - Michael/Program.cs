using System.Text;

namespace Prueba_Tecnica_01___Michael
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Reservaciones R = new Reservaciones();
            R.GetTodo();
        }
    }

    class Reservaciones
    {
        private string[,] Asientos = new string[10, 10];
        private int Opcion, fila, columna;

        public Reservaciones()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Asientos[i, j] = "L";
                    Console.ResetColor();
                }
            }
        }

        public void GetTodo()
        {
            Inicio();
        }

        private void Inicio()
        {
            
            Console.WriteLine("\n  Reservaciones de Teatro:");

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("‒‒‒‒‒‒‒‒‒‒‒‒‒‒‒‒‒‒‒‒‒‒‒‒‒‒‒‒●");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(" [x]");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(" Opciones disponibles: \n\n");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write(" [1]");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(" Reservar un asiento.\n");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write(" [2]");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(" Ver todos los asientos.\n");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("‒‒‒‒‒‒‒‒‒‒‒‒‒‒‒‒‒‒‒‒‒‒‒‒‒‒‒‒●");
            Console.ResetColor();
            Console.Write(" Ingrese una opción: ");
            Opciones();
        }

        private void Opciones()
        {
            Opcion = int.Parse(Console.ReadLine());
            switch (Opcion)
            {
                case 1:
                    Reservar();
                    break;

                case 2:
                    VerAsientos();
                    Console.WriteLine(" Desea volver al menú ¿? (1 = Si   /   2 = No)");
                    int respuesta = int.Parse(Console.ReadLine());
                    if (respuesta == 1)
                    {
                        Console.Clear();
                        Inicio();
                    }
                    else
                    {
                        Console.WriteLine(" Fin del programa!");
                    }
                    break;

                default:
                    if (Opcion > 2 || Opcion < 1)
                    {
                        Console.Clear();
                        Console.WriteLine(" @ Error, Opción invalida! Por favor intente de nuevo: \n");
                        Inicio();
                    }
                    break;
            }
        }

        private void Reservar()
        {
            bool continuar = true;

            while (continuar)
            {
                Console.Clear();
                Console.WriteLine(" Bienvenido al menú básico de reservaciones!");
                Console.WriteLine("         Asientos disponibles:");
                Console.WriteLine(" X = Ocupado     /     L = Libre");
                VerAsientos();
                ElegirPosicion();

                Console.WriteLine(" ¿Desea reservar otro asiento? (1 = Si / 2 = No): ");
                int respuesta = int.Parse(Console.ReadLine());

                if (respuesta != 1)
                {
                    continuar = false;
                    Console.WriteLine(" Volviendo al menú principal...");
                    Console.ReadLine();
                    Console.Clear();
                }
            }

            Inicio();
        }

        private void VerAsientos()
        {
            Console.Clear();
            Console.WriteLine(".-  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -.");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("|      |      |      |      |      |      |      |      |      |       |");
                Console.WriteLine($"|  {Asientos[i, 0]}   |  {Asientos[i, 1]}   |  {Asientos[i, 2]}   |  {Asientos[i, 3]}   |  {Asientos[i, 4]}   |   {Asientos[i, 5]}  |   {Asientos[i, 6]}  |   {Asientos[i, 7]}  |   {Asientos[i, 8]}  |   {Asientos[i, 9]}   |");
                Console.WriteLine("|      |      |      |      |      |      |      |      |      |       |");
                Console.WriteLine(".-  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -.");
            }
        }

        private void ElegirPosicion()
        {
            bool posicionValida = false;

            while (!posicionValida)
            {
                Console.Write("  [x] Ingrese la fila en la que desee estar (0-9): ");
                fila = int.Parse(Console.ReadLine());

                Console.Write("  [z] Ingrese el asiento en el que quiera sentarse (0-9): ");
                columna = int.Parse(Console.ReadLine());

                if (fila >= 0 && fila < 10 && columna >= 0 && columna < 10)
                {
                    if (Asientos[fila, columna] == "L")
                    {
                        Asientos[fila, columna] = "X";
                        VerAsientos();
                        posicionValida = true;
                    }
                    else
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(" @ Error! Asiento ocupado, por favor elija otro asiento: ");
                        Console.ResetColor();
                    }
                }
                else
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(" @ Error! Fila o columna fuera de rango, intente nuevamente.");
                    Console.ResetColor();
                }
            }
        }
    }
}
