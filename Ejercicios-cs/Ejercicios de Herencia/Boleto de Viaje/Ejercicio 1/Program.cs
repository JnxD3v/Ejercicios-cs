using System;

namespace Ejercicio_1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("     [+] Creación de boletos de transporte.  ");
            Console.Write("   ~ Ingrese cuántos boletos desea crear: ");

            if (!int.TryParse(Console.ReadLine(), out int cantidadBoletos) || cantidadBoletos <= 0)
            {
                Console.WriteLine("   Ha ingresado un valor inválido o 0. Fin del programa.");
                return;
            }

            Taxi[] taxis = new Taxi[cantidadBoletos];
            Metro[] metros = new Metro[cantidadBoletos];
            Teleferico[] telefericos = new Teleferico[cantidadBoletos];
            BusUrbano[] busesUrbanos = new BusUrbano[cantidadBoletos];
            BusInterurbano[] busesInterurbanos = new BusInterurbano[cantidadBoletos];

            Console.Clear();

            for (int i = 0; i < cantidadBoletos; i++)
            {
                Console.WriteLine();
                Console.WriteLine($" [+] Creación del boleto N° {i + 1}: \n");
                Console.WriteLine("  Boletos disponibles: ");
                Console.WriteLine("  1. Taxi");
                Console.WriteLine("  2. Metro");
                Console.WriteLine("  3. Teleférico");
                Console.WriteLine("  4. Bus Urbano");
                Console.WriteLine("  5. Bus Interurbano");
                Console.Write("\n  Ingrese una opción:  ");

                if (!int.TryParse(Console.ReadLine(), out int tipoDeBoleto) || tipoDeBoleto < 1 || tipoDeBoleto > 5)
                {
                    Console.WriteLine("   Opción no válida. Intente nuevamente.");
                    i--; // Repetir el ciclo para este boleto
                    continue;
                }

                Console.Clear();

                switch (tipoDeBoleto)
                {
                    case 1:
                        taxis[i] = new Taxi();
                        taxis[i].SetTaxi();
                        taxis[i].GetBoleto();
                        break;

                    case 2:
                        metros[i] = new Metro();
                        metros[i].SetMetro();
                        metros[i].GetBoleto();
                        break;

                    case 3:
                        telefericos[i] = new Teleferico();
                        telefericos[i].SetTeleferico();
                        telefericos[i].GetBoleto();
                        break;

                    case 4:
                        busesUrbanos[i] = new BusUrbano();
                        busesUrbanos[i].SetBusUrbano();
                        busesUrbanos[i].GetBoleto();
                        break;

                    case 5:
                        busesInterurbanos[i] = new BusInterurbano();
                        busesInterurbanos[i].SetBusInterurbano();
                        busesInterurbanos[i].GetBoleto();
                        break;
                }

                Console.WriteLine("\nPresione cualquier tecla para continuar...");
                Console.ReadKey();
                Console.Clear();
            }

            Console.WriteLine(" Eso es todo amigos..");
        }
    }

    class Transporte
    {
        protected virtual double PrecioBoleto()
        {
            return 0;
        }
    }

    class Taxi : Transporte
    {
        private string nombreTaxi;
        private string destinoTaxi;
        private string nombrePasajero;
        private double distanciaTaxi;
        private double velocidad = 40;

        protected override double PrecioBoleto()
        {
            double tiempo = distanciaTaxi / velocidad;
            return distanciaTaxi * tiempo;
        }

        public void SetTaxi()
        {
            Console.WriteLine("\n  ~ Obtener datos del boleto (Taxi): ");
            Console.Write("  [#]  Ingrese el nombre del pasajero: ");
            nombrePasajero = Console.ReadLine();
            Console.Write("  [#]  Ingrese el nombre de la compañía del taxi: ");
            nombreTaxi = Console.ReadLine();
            Console.Write("  [#]  Ingrese el destino al que se dirige: ");
            destinoTaxi = Console.ReadLine();
            Console.Write("  [#]  Ingrese la distancia (km): ");
            distanciaTaxi = double.Parse(Console.ReadLine());
        }

        public void GetBoleto()
        {
            Console.WriteLine();
            Console.WriteLine("\n  ~ Boleto de tipo Taxi: ");
            Console.WriteLine("  ~ - ~ - ~ - ~ - ~ - ~ - ~ - ~ - ~ - ~ - ~");
            Console.WriteLine($"  [#] El nombre del pasajero es: {nombrePasajero}");
            Console.WriteLine($"  [#]  La compañía de su taxi es: {nombreTaxi}");
            Console.WriteLine($"  [#]  Se dirige hacia: {destinoTaxi}");
            Console.WriteLine($"  [#]  La distancia que recorrerá es: {distanciaTaxi} km");
            Console.WriteLine("  ~ - ~ - ~ - ~ - ~ - ~ - ~ - ~ - ~ - ~ - ~");
            Console.WriteLine($"  [$]  El precio de su boleto es: RD$ {PrecioBoleto():F2}");
            Console.WriteLine();
        }
    }

    class Metro : Transporte
    {
        private string nombreMetro;
        private string lineaMetro;
        private string nombrePasajero;
        private double tarifaMetro = 45;

        protected override double PrecioBoleto()
        {
            return tarifaMetro;
        }

        public void SetMetro()
        {
            Console.WriteLine("\n  ~ Obtener datos del boleto (Metro): ");
            Console.Write("  [#]  Ingrese el nombre del pasajero: ");
            nombrePasajero = Console.ReadLine();
            Console.Write("  [#]  Ingrese el nombre de la compañía del metro: ");
            nombreMetro = Console.ReadLine();
            Console.Write("  [#]  Ingrese la línea de metro: ");
            lineaMetro = Console.ReadLine();
        }

        public void GetBoleto()
        {
            Console.WriteLine();
            Console.WriteLine("\n  ~ Boleto de tipo Metro: ");
            Console.WriteLine("  ~ - ~ - ~ - ~ - ~ - ~ - ~ - ~ - ~ - ~ - ~");
            Console.WriteLine($"  [#] El nombre del pasajero es: {nombrePasajero}");
            Console.WriteLine($"  [#]  La compañía del metro es: {nombreMetro}");
            Console.WriteLine($"  [#]  La línea de metro es: {lineaMetro}");
            Console.WriteLine("  ~ - ~ - ~ - ~ - ~ - ~ - ~ - ~ - ~ - ~ - ~");
            Console.WriteLine($"  [$]  El precio de su boleto es: RD$ {PrecioBoleto():F2}");
            Console.WriteLine();
        }
    }

    class Teleferico : Transporte
    {
        private string nombreTeleferico;
        private string lineaTeleferico;
        private string nombrePasajero;
        private double tarifaTeleferico = 50;

        protected override double PrecioBoleto()
        {
            return tarifaTeleferico;
        }

        public void SetTeleferico()
        {
            Console.WriteLine("\n  ~ Obtener datos del boleto (Teleférico): ");
            Console.Write("  [#]  Ingrese el nombre del pasajero: ");
            nombrePasajero = Console.ReadLine();
            Console.Write("  [#]  Ingrese el nombre de la compañía del teleférico: ");
            nombreTeleferico = Console.ReadLine();
            Console.Write("  [#]  Ingrese la línea de teleférico: ");
            lineaTeleferico = Console.ReadLine();
        }

        public void GetBoleto()
        {
            Console.WriteLine();
            Console.WriteLine("\n  ~ Boleto de tipo Teleférico: ");
            Console.WriteLine("  ~ - ~ - ~ - ~ - ~ - ~ - ~ - ~ - ~ - ~ - ~");
            Console.WriteLine($"  [#] El nombre del pasajero es: {nombrePasajero}");
            Console.WriteLine($"  [#]  La compañía del teleférico es: {nombreTeleferico}");
            Console.WriteLine($"  [#]  La línea de teleférico es: {lineaTeleferico}");
            Console.WriteLine("  ~ - ~ - ~ - ~ - ~ - ~ - ~ - ~ - ~ - ~ - ~");
            Console.WriteLine($"  [$]  El precio de su boleto es: RD$ {PrecioBoleto():F2}");
            Console.WriteLine();
        }
    }

    class BusUrbano : Transporte
    {
        private string corredorBus;
        private string nombrePasajero;
        private double tarifaBusUrbano = 35;

        protected override double PrecioBoleto()
        {
            return tarifaBusUrbano;
        }

        public void SetBusUrbano()
        {
            Console.WriteLine("\n  ~ Obtener datos del boleto (Bus Urbano): ");
            Console.Write("  [#]  Ingrese el nombre del pasajero: ");
            nombrePasajero = Console.ReadLine();
            Console.Write("  [#]  Ingrese el corredor del bus urbano: ");
            corredorBus = Console.ReadLine();
        }

        public void GetBoleto()
        {
            Console.WriteLine();
            Console.WriteLine("\n  ~ Boleto de tipo Bus Urbano: ");
            Console.WriteLine("  ~ - ~ - ~ - ~ - ~ - ~ - ~ - ~ - ~ - ~ - ~");
            Console.WriteLine($"  [#] El nombre del pasajero es: {nombrePasajero}");
            Console.WriteLine($"  [#]  El corredor del bus urbano es: {corredorBus}");
            Console.WriteLine("  ~ - ~ - ~ - ~ - ~ - ~ - ~ - ~ - ~ - ~ - ~");
            Console.WriteLine($"  [$]  El precio de su boleto es: RD$ {PrecioBoleto():F2}");
            Console.WriteLine();
        }
    }

    class BusInterurbano : Transporte
    {
        private string nombreBus;
        private string destinoBus;
        private string nombrePasajero;
        private double distanciaBus;

        protected override double PrecioBoleto()
        {
            return distanciaBus * 2; // Precio arbitrario por km
        }

        public void SetBusInterurbano()
        {
            Console.WriteLine("\n  ~ Obtener datos del boleto (Bus Interurbano): ");
            Console.Write("  [#]  Ingrese el nombre del pasajero: ");
            nombrePasajero = Console.ReadLine();
            Console.Write("  [#]  Ingrese el nombre de la compañía del bus: ");
            nombreBus = Console.ReadLine();
            Console.Write("  [#]  Ingrese el destino al que se dirige: ");
            destinoBus = Console.ReadLine();
            Console.Write("  [#]  Ingrese la distancia (km): ");
            distanciaBus = double.Parse(Console.ReadLine());
        }

        public void GetBoleto()
        {
            Console.WriteLine();
            Console.WriteLine("\n  ~ Boleto de tipo Bus Interurbano: ");
            Console.WriteLine("  ~ - ~ - ~ - ~ - ~ - ~ - ~ - ~ - ~ - ~ - ~");
            Console.WriteLine($"  [#] El nombre del pasajero es: {nombrePasajero}");
            Console.WriteLine($"  [#]  La compañía del bus es: {nombreBus}");
            Console.WriteLine($"  [#]  Se dirige hacia: {destinoBus}");
            Console.WriteLine($"  [#]  La distancia que recorrerá es: {distanciaBus} km");
            Console.WriteLine("  ~ - ~ - ~ - ~ - ~ - ~ - ~ - ~ - ~ - ~ - ~");
            Console.WriteLine($"  [$]  El precio de su boleto es: RD$ {PrecioBoleto():F2}");
            Console.WriteLine();
        }
    }
}
