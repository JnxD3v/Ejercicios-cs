using System;
using System.Diagnostics.Tracing;

namespace Prueba_Técnica
{
    class Program
    {
        static void Main()
        {
            Reservaciones Reservar = new Reservaciones();
            Reservar.LlamarTodo();
            
        }

    }

    class Reservaciones
    {

        private string[,] PosicionesTeatro = new string[10, 10];
        private int Opcion, Fila, Columna;
        private int AsientoReservado;

        public void LlamarTodo()
        {
            SeleccionarOpciones();
            OpcionesValidas();
        }

        private void SeleccionarOpciones()
        {
            Console.WriteLine("\n  Reservaciones de Teatro:");
            Console.WriteLine("- . - . - - . - . - - . - . - ");
            Console.WriteLine(" [x] Opciones disponibles: ");
            Console.WriteLine(" 1. Reservar un asiento.");
            Console.WriteLine(" 2. Ver todos los asientos.\n");
            Console.Write(" Ingrese una opción: ");

        }

        private void PedirDatos()
        {
            Console.WriteLine(" Esos son los asientos disponibles: ");
            Console.WriteLine(" [-] Ingrese la fila en la que quiere estar: ");
            Fila = int.Parse(Console.ReadLine());

            Console.WriteLine(" [+] Ingrese el asiendo de la fila en la que quiere estar: ");
            Columna = int.Parse(Console.ReadLine());

            Console.WriteLine(" Asientos disponibles en este momento: ");
            VerAsientosU();
        }

        private void OpcionesValidas()
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
                        Console.WriteLine("  Opciones disponibles: ");
                        Console.WriteLine(" 1. Reservar un asiento.");
                        Console.WriteLine(" 2. Ver todos los asientos.");
                        OpcionesValidas();
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
                        Console.WriteLine(" Opcion invalida! Porfavor intente de nuevo: \n");
                        Console.WriteLine("  Opciones disponibles: ");
                        Console.WriteLine(" 1. Reservar un asiento.");
                        Console.WriteLine(" 2. Ver todos los asientos.");
                        OpcionesValidas();

                    }
                    break;
            }
        }

        private void Reservar()
        {
            Console.Clear();
            Console.WriteLine("\n ¡Bienvenido a nuestro sistema de reservaciones!");
            VerAsientos();
            PedirDatos();
        }

        private void VerAsientos()
        {
            for (int i = 0; i < 10; i++)
            {
                int a = 0;
                PosicionesTeatro[i, a] = "L";


                for (int j = 0; j < 10; j++)
                {
                    PosicionesTeatro[a, i] = "L";
                    a++;
                }
            }


            Console.Clear();
            Console.WriteLine("\n                     [+] Asientos disponibles: ");
            Console.WriteLine("                   (L = Libre   /   X = Ocupado) \n");
            Console.WriteLine(".-  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -.");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("|      |      |      |      |      |      |      |      |      |       |");
                Console.WriteLine($"|  {PosicionesTeatro[i, 0]}   |  {PosicionesTeatro[i, 1]}   |  {PosicionesTeatro[i, 2]}   |  {PosicionesTeatro[i, 3]}   |  {PosicionesTeatro[i, 4]}   |   {PosicionesTeatro[i, 5]}  |   {PosicionesTeatro[i, 6]}  |   {PosicionesTeatro[i, 7]}  |   {PosicionesTeatro[i, 8]}  |   {PosicionesTeatro[i, 9]}   |");
                Console.WriteLine("|      |      |      |      |      |      |      |      |      |       |");
                Console.WriteLine(".-  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -.");
            }

        }

        private void VerAsientosU()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    PosicionesTeatro[i, j] = "L";
                }
            }



            Console.WriteLine(".-  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -.");
            for (int i = 0; i < 10; i++)
            {
                if (Fila < 11 && Columna < 11 && Fila > -1 && Columna > -1) 
                {
                    if (PosicionesTeatro[Fila, Columna] == "L" && Columna != 0 && Fila != 0)
                    {
                        PosicionesTeatro[Fila, Columna] = "X";
                    }
                } else
                {
                    Console.Clear();
                    Console.WriteLine(" @ Error! posicion invalida, ingrese las posiciones nuevamente: ");
                    PedirDatos();
                }

                Console.WriteLine("|      |      |      |      |      |      |      |      |      |       |");
                Console.WriteLine($"|  {PosicionesTeatro[i, 0]}   |  {PosicionesTeatro[i, 1]}   |  {PosicionesTeatro[i, 2]}   |  {PosicionesTeatro[i, 3]}   |  {PosicionesTeatro[i, 4]}   |   {PosicionesTeatro[i, 5]}  |   {PosicionesTeatro[i, 6]}  |   {PosicionesTeatro[i, 7]}  |   {PosicionesTeatro[i, 8]}  |   {PosicionesTeatro[i, 9]}   |");
                Console.WriteLine("|      |      |      |      |      |      |      |      |      |       |");
                Console.WriteLine(".-  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -.");
            }
        }

    }
}
