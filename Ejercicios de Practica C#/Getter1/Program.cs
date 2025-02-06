namespace Getter1
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            Peluche mesaPeluche = new Peluche();
            Console.WriteLine(mesaPeluche.getInfoPeluche());

            Peluche closetPeluche = new Peluche("Marrón", 45, "Tirado");
            Console.WriteLine(closetPeluche.getInfoPeluche1());


            Peluche ventanaPeluche = new Peluche("Crema", 65, "Colgado");
            ventanaPeluche.setViendoDistancia(true, "Un poco lejos.");
            Console.WriteLine(ventanaPeluche.getInfoPeluche1());
            Console.WriteLine(ventanaPeluche.getViendoDistancia());

            */

            Peluche francisco = new Peluche("Rojo", 15, "Soltero");
            Console.WriteLine(francisco.getInfoPeluche());
            Console.WriteLine("");
            Console.WriteLine(francisco.getInfoPeluche1());

        }
    }

    class Peluche
    {

        // Constructores :p . .
        public Peluche()
        {
            colorPeluche[0] = "Rojo";
            colorPeluche[1] = "Azul";
            colorPeluche[2] = "Verde";
            colorPeluche[3] = "Amarillo";
            colorPeluche[4] = "Naranja";

            tamañoPeluche = 50;
            estadoPeluche = "Sentadito";
        }

        public Peluche(string ColorPeluche, int TamañoPeluche, string EstadoPeluche)
        {
            colorPeluche[0] = ColorPeluche;
            tamañoPeluche = TamañoPeluche;
            estadoPeluche = EstadoPeluche;
        }

        // Primeros getters. .

        public string getInfoPeluche()
        {
            return "\n ~ Información del peluche:\n  Colores: " + colorPeluche[0] + ", " + colorPeluche[1] + ", " + colorPeluche[2] + ", " + colorPeluche[3] + ", " + colorPeluche[4] + "\n  Tamaño: " + tamañoPeluche + "cm \n" + "  Estado: " + estadoPeluche;

        }
        public string getInfoPeluche1()
        {
            return "\n \n ~ Información del peluche: \n  Color: " + colorPeluche[0] + "\n  Tamaño: " + tamañoPeluche + "cm \n" + "  Estado: " + estadoPeluche;

        }


        // Setter para saber si me esta viendo y su distancia de mi. .
        public void setViendoDistancia(bool viendoPeluche, string distanciaPeluche)
        {

            // Uso del this: Diferencias un campo de clase de el parametro del metodo. .
            this.viendoPeluche = viendoPeluche;
            this.distanciaPeluche = distanciaPeluche;
        }


        // Getter para saber si me esta viendo y su distancia de mi.
        public string getViendoDistancia()
        {
            

            if (viendoPeluche == true)
            {
                return "\n El peluche te esta mirando, Ojo. \n El peluche está: " + distanciaPeluche;
            }
            else
            {
                return "\n El peluche no te esta mirando (Por feo). \n El peluche está: " + distanciaPeluche;
            }     
        }

        // Variables encapsuladas. .
        private string[] colorPeluche = new string[5];
        
        private int tamañoPeluche;
        private string estadoPeluche;

        private bool viendoPeluche;
        private string distanciaPeluche;

    }
}