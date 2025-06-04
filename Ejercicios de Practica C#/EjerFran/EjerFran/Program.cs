using System;
using System.ComponentModel;

namespace Ejerfran
{
    class Program
    {

        static void Main(string[] args)
        {

            Random random = new Random();
            int Numero = random.Next(1, 3);
            string JugadorPc = "0"; // Referencia a sociales
            string Continuar;

            switch (Numero)
            {
                case 1:
                    JugadorPc = "Piedra";
                    break;
                case 2:
                    JugadorPc = "Papel";
                    break;
                case 3:
                    JugadorPc = "Tijera";
                    break;
                default:
                    break;
            }

            Console.WriteLine(JugadorPc);

            Console.WriteLine("- - - - - - - - - - - - - - - - - -");
            Console.WriteLine("~ Juego de piedra, papel o tijeras.");
            Console.WriteLine("- - - - - - - - - - - - - - - - - -");
            Console.WriteLine(" ~ Ingresa alguna de las opciones:");
            Console.WriteLine(" 1. Piedra");
            Console.WriteLine(" 2. Papel");
            Console.WriteLine(" 3. Tijera");
            string JugadorPersona = Console.ReadLine();

            do
            {
                switch (JugadorPersona)
                {
                    case "Piedra":
                        if (JugadorPc == "Piedra")
                        {
                            Console.WriteLine("- - - - - - - - - - - - - - - - - -");
                            Console.WriteLine("~ - ~ - ~ - ~ Empate");
                            Console.WriteLine("- - - - - - - - - - - - - - - - - -");
                        }
                        else if (JugadorPc == "Papel")
                        {
                            Console.WriteLine("- - - - - - - - - - - - - - - - - -");
                            Console.WriteLine("~ - ~ - ~ - ~ Perdiste");
                            Console.WriteLine("- - - - - - - - - - - - - - - - - -");
                        } 
                        else if (JugadorPc == "Tijera"){
                            Console.WriteLine("- - - - - - - - - - - - - - - - - -");
                            Console.WriteLine("~ - ~ - ~ - ~ Ganaste!");
                            Console.WriteLine("- - - - - - - - - - - - - - - - - -");
                        }
                        break;

                    case "Papel":

                        if (JugadorPc == "Piedra")
                        {
                            Console.WriteLine("- - - - - - - - - - - - - - - - - -");
                            Console.WriteLine("~ - ~ - ~ - ~ Ganaste!");
                            Console.WriteLine("- - - - - - - - - - - - - - - - - -");
                        }
                        else if (JugadorPc == "Papel")
                        {
                            Console.WriteLine("- - - - - - - - - - - - - - - - - -");
                            Console.WriteLine("~ - ~ - ~ - ~ Empate");
                            Console.WriteLine("- - - - - - - - - - - - - - - - - -");
                        }
                        else if (JugadorPc == "Tijera")
                        {
                            Console.WriteLine("- - - - - - - - - - - - - - - - - -");
                            Console.WriteLine("~ - ~ - ~ - ~ Perdiste");
                            Console.WriteLine("- - - - - - - - - - - - - - - - - -");
                        }
                        break;

                    case "Tijera":
                        if (JugadorPc == "Piedra")
                        {
                            Console.WriteLine("- - - - - - - - - - - - - - - - - -");
                            Console.WriteLine("~ - ~ - ~ - ~ Perdiste");
                            Console.WriteLine("- - - - - - - - - - - - - - - - - -");
                        }
                        else if (JugadorPc == "Papel")
                        {
                            Console.WriteLine("- - - - - - - - - - - - - - - - - -");
                            Console.WriteLine("~ - ~ - ~ - ~ Ganaste");
                            Console.WriteLine("- - - - - - - - - - - - - - - - - -");
                        }
                        else if (JugadorPc == "Tijera")
                        {
                            Console.WriteLine("- - - - - - - - - - - - - - - - - -");
                            Console.WriteLine("~ - ~ - ~ - ~ Empate");
                            Console.WriteLine("- - - - - - - - - - - - - - - - - -");
                        }
                        break;
                    default:
                        string nadaXD;
                        break;
                }


                Console.WriteLine("¿Quieres continuar?");
                Continuar = Console.ReadLine();


                if (Continuar == "Si")
                {
                    Console.WriteLine(" ~ Ingresa alguna de las opciones (Piedra, Papel o Tijeras) :");
                    JugadorPersona = Console.ReadLine();
                };
                                
            } while (Continuar == "Si");

        }

    }

}
