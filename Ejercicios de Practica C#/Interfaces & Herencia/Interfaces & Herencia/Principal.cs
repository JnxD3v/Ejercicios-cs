using System; // OwO 

namespace Interfaces___Herencia
{
    class Program
    {
        static void Main()
        {
            //Console.WriteLine(" ~ Prueba polimorfismo: ");
            //MesaPeluche PelucheMordido = new MesaPeluche();
            //ClosetPeluche PelucheMarron = new ClosetPeluche();

            //Peluches peluches = new Peluches();

            //// Estado 1: El peluche marrón.
            //peluches = PelucheMarron;
            //peluches.Estado();

            //// Estado 2: El pelucho con la oreja mordida.
            //peluches = PelucheMordido;
            //peluches.Estado();

            Hombre Micha = new Hombre();
            Mujer Mere = new Mujer();

            Mere.SetName("Lismerelin");
            Console.WriteLine($" ~ Info de {Mere.GetName()}: ");
            Mere.Caminar();
            Mere.Hablar();
            Mere.Correr();

            Micha.SetName("Michael");
            Console.WriteLine($" ~ Info de {Micha.GetName()}: ");
            Micha.Caminar();
            Micha.Hablar();
            Micha.Correr();

        }
    }

    class Peluches
    {
        public virtual void Estado() => Console.WriteLine(" Mensaje predeterminado de estado.");

    }

    class MesaPeluche : Peluches
    {
        public override void Estado() => Console.WriteLine(" Estoy sentado en la mesa.");

    }

    class ClosetPeluche : Peluches
    {
        public override void Estado() => Console.WriteLine(" Estoy tirado en el armario.");

    }

    // Interfaces : (metodos obligatorios)
    interface IAccionesHumanas
    {
        void Caminar();
        void Hablar();
        void Correr();
    }

    class Personas : IAccionesHumanas
    {
        private string name;
        private string apellido;
        private int edad;
        // Campos de clase -.

        public string SetName(string name) => this.name = name;
        public string GetName() => name;
        public string SetApellido(string apellido) => this.apellido = apellido;
        public string GetApellido() => apellido;
        public int GetEdad(int edad) => this.edad = edad;
        public int GetEdad() => edad;
        // Getters & Setters -.


        public virtual void Caminar() => Console.WriteLine("Predeterminado: Puedo caminar.");
        public virtual void Hablar() => Console.WriteLine("Predeterminado: Puedo hablar.");
        public virtual void Correr() => Console.WriteLine("Predeterminado: Puedo correr.");
        // Comportamientos de clase: Se heredaran a las demas clases -.
    }

    class Hombre : Personas
    {
        public override void Caminar() => Console.WriteLine($" + Puedo caminar.");
        public override void Hablar() => Console.WriteLine($" + Puedo caminar.");
        public override void Correr() => Console.WriteLine($" + Puedo caminar.");
    }

    class Mujer : Personas
    {
        public override void Caminar() => Console.WriteLine(" - Puedo caminar.");
        public override void Hablar() => Console.WriteLine(" - Puedo caminar.");
        public override void Correr() => Console.WriteLine(" - Puedo caminar.");
    }
}
