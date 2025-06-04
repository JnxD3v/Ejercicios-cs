using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;

namespace Piedra_Papel_Tijera
{
    class Program
    {
        static int juegos = 0;
        static int wins = 0;
        static int defeats = 0;
        static int draws = 0;
        static string continuar;

        static void Main(string[] args)
        {            
            // By micha

            do
            {                
                ++juegos;
                Console.Clear();
                Juego();
                Console.WriteLine("¿Quieres seguir jugando?");
                continuar = Console.ReadLine();
                if (continuar != "si")
                {
                    marcador();
                }
            } while (continuar == "si");
            
            
        }

        public static void marcador()
        {

            if (continuar != "si")
            {
                Console.Clear();
                Console.WriteLine(" ~ Gracias por Jugar! \n");
                
                Console.WriteLine(" ~ Marcador:");
                Console.WriteLine("-  -  -  -  -  -  -  -");
                Console.WriteLine($" @ Jugaste: {juegos} juegos.");
                Console.WriteLine($" - Perdiste: {defeats} juegos.");
                Console.WriteLine($" = Empataste: {draws} juegos.");
                Console.WriteLine($" + Ganaste: {wins} juegos.");
            }
        }

        public static void Juego()
        {
            Random numeroMaquina = new Random();
            int Maquina = numeroMaquina.Next(1, 3);
            string opcionMaquina = ".";
            int Jugador;


            Console.WriteLine("-  -  -  -  -  -  -  -  -  -  -  -  -");
            Console.WriteLine(" ~ Juego de Piedra, Papel y Tijeras");
            Console.WriteLine("-  -  -  -  -  -  -  -  -  -  -  -  -");
            Console.WriteLine(" ~ Ingrese una de las opciones:");
            Console.WriteLine(" 1. Piedra \n 2. Papel \n 3. Tijera");
            Jugador = int.Parse(Console.ReadLine());

            switch (Maquina)
            {
                case 1: 
                    opcionMaquina = "Piedra";
                    break;

                case 2:
                    opcionMaquina = "Papel";
                    break;

                case 3:
                    opcionMaquina = "Tijera";
                    break;
            }

            switch (Jugador)
            {
                case 1:
                    if (Maquina == 1)
                    {
                        Console.WriteLine(" -   ~   -   ~   -   ~   -   ~   -");
                        Console.WriteLine("             ~ Empate");
                        Console.WriteLine($"     ~ La maquina eligio: {opcionMaquina}");
                        Console.WriteLine(" -   ~   -   ~   -   ~   -   ~   -");
                        draws++;
                    }
                    else if (Maquina == 2)
                    {
                        Console.WriteLine(" -   ~   -   ~   -   ~   -   ~   -");
                        Console.WriteLine("             ~ Perdiste");
                        Console.WriteLine($"     ~ La maquina eligio: {opcionMaquina}");
                        Console.WriteLine(" -   ~   -   ~   -   ~   -   ~   -");
                        defeats++;
                    }
                    else if (Maquina == 3)
                    {
                        Console.WriteLine(" -   ~   -   ~   -   ~   -   ~   -");
                        Console.WriteLine("             ~ Ganaste!");
                        Console.WriteLine($"     ~ La maquina eligio: {opcionMaquina}");
                        Console.WriteLine(" -   ~   -   ~   -   ~   -   ~   -");
                        wins++;
                    }
                    break;

                case 2:
                    if (Maquina == 1)
                    {
                        Console.WriteLine(" -   ~   -   ~   -   ~   -   ~   -");
                        Console.WriteLine("             ~ Ganaste!");
                        Console.WriteLine($"     ~ La maquina eligio: {opcionMaquina}");
                        Console.WriteLine(" -   ~   -   ~   -   ~   -   ~   -");
                        wins++;

                    }
                    else if (Maquina == 2)
                    {
                        Console.WriteLine(" -   ~   -   ~   -   ~   -   ~   -");
                        Console.WriteLine("             ~ Empate");
                        Console.WriteLine($"     ~ La maquina eligio: {opcionMaquina}");
                        Console.WriteLine(" -   ~   -   ~   -   ~   -   ~   -");
                        draws++;
                    }
                    else if (Maquina == 3)
                    {
                        Console.WriteLine(" -   ~   -   ~   -   ~   -   ~   -");
                        Console.WriteLine("             ~ Perdiste");
                        Console.WriteLine($"     ~ La maquina eligio: {opcionMaquina}");
                        Console.WriteLine(" -   ~   -   ~   -   ~   -   ~   -");
                        defeats++;
                    }
                    break;
                case 3:
                    if (Maquina == 1)
                    {
                        Console.WriteLine(" -   ~   -   ~   -   ~   -   ~   -");
                        Console.WriteLine("             ~ Perdiste");
                        Console.WriteLine($"     ~ La maquina eligio: {opcionMaquina}");
                        Console.WriteLine(" -   ~   -   ~   -   ~   -   ~   -");
                        defeats++;

                    }
                    else if (Maquina == 2)
                    {
                        Console.WriteLine(" -   ~   -   ~   -   ~   -   ~   -");
                        Console.WriteLine("             ~ Ganaste!");
                        Console.WriteLine($"     ~ La maquina eligio: {opcionMaquina}");
                        Console.WriteLine(" -   ~   -   ~   -   ~   -   ~   -");
                        wins++;
                    }
                    else if (Maquina == 3)
                    {
                        Console.WriteLine(" -   ~   -   ~   -   ~   -   ~   -");
                        Console.WriteLine("             ~ Empate");
                        Console.WriteLine($"     ~ La maquina eligio: {opcionMaquina}");
                        Console.WriteLine(" -   ~   -   ~   -   ~   -   ~   -");
                        draws++;
                    }
                    break;

                default:

                    break;
            }

        }

    }

}
