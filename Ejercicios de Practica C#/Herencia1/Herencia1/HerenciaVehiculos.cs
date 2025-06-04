using System;
using System.Threading.Channels;

namespace HerenciaVehiculos
{
    class Principal
    {
        static void Main()
        {
            Vehiculo[] arrayVehiculos = new Vehiculo[3];

            Avión avion1 = new Avión();
            Auto auto1 = new Auto();
            Moto moto1 = new Moto();

            arrayVehiculos[0] = avion1;
            arrayVehiculos[1] = auto1;
            arrayVehiculos[2] = moto1;

            for (int i = 0; i < arrayVehiculos.Length; i++)
            {
                arrayVehiculos[i].conducir();
                arrayVehiculos[i].arrancarMotor();
                arrayVehiculos[i].apagarMotor();
                Console.ReadLine();
            }     

        }
    }

    file class Vehiculo
    {
        public void arrancarMotor() => Console.WriteLine(" El motor se encendio [+].");
        public void apagarMotor() => Console.WriteLine(" El motor se apago [-].");
        public virtual void conducir() => Console.WriteLine(" Soy un vehiculo, y pueden conducirme.") ;
    }

    file class Avión : Vehiculo
    {
        public override void conducir() => Console.WriteLine(" Soy un avion, y necesitan 2 personas para conducirme.");
    }

    file class Auto : Vehiculo
    {
        public override void conducir() => Console.WriteLine(" Soy un auto, y me puede conducir hasta un adolescente.");
    }

    file class Moto : Vehiculo
    {

    }
}