using System.Net.Security;

namespace Ej_Interfaz3
{
    class Program
    {
        static void Main()
        {
            Libro Libro1 = new Libro();
            Libro1.ObtenerTitulo();
            Libro1.ObtenerTipo();
            Libro1.ObtenerAutor();
            Libro1.Leer();

            Console.ReadLine();

            Revista Revista1 = new Revista();
            Revista1.ObtenerTitulo();
            Revista1.NumeroEdicion();
            Revista1.ObtenerTipo();
            Revista1.Leer();
        }
    }

    interface IMaterial
    {
        void ObtenerTitulo();
        string ObtenerTipo();
        void Leer();
    }

    class Libro : IMaterial
    {
        private string titulo, autor;

        public void ObtenerTitulo()
        {
            Console.Write("\n ~ Ingrese el titulo del libro: ");
            titulo = Console.ReadLine();
        }

        public void Leer()
        {
            Console.WriteLine("\n  - Info. del libro:");
            Console.WriteLine("  Leyendo el libro: " + titulo);
            Console.WriteLine("  Autor: " + autor);
            Console.WriteLine("  Tipo: " + ObtenerTipo());
        }

        public string ObtenerTipo() => "Libro";
        public void ObtenerAutor()
        {
            Console.Write(" ~ Ingrese el autor del libro: ");
            autor = Console.ReadLine();
        }
    }


    class Revista : IMaterial
    {
        private string titulo;
        private int numeroEdicion;

        public void ObtenerTitulo()
        {
            Console.Write("\n ~ Ingrese el titulo de la revista: ");
            titulo = Console.ReadLine();
        }

        public int NumeroEdicion()
        {
            Console.Write(" ~ Ingrese el N° de la Edición: ");
            numeroEdicion = Convert.ToInt32(Console.ReadLine());
            return numeroEdicion;
        }

        public void Leer()
        {
            Console.WriteLine("\n  + Info. de la revista:");
            Console.WriteLine("  Leyendo la revista: " + titulo);
            Console.WriteLine("  Edición #" + numeroEdicion);
            Console.WriteLine("  Tipo: " + ObtenerTipo());
        }

        public string ObtenerTipo() => "Revista";
    }
}
