using System;
using System.Threading.Channels;

namespace Heredenme_Esta
{
    class Program
    {
        static void Main(string[] args)
        {
            Articulos[] articulos = new Articulos[2];

            for (int i = 0; i < articulos.Length; i++)
            {
                articulos[i] = new Articulos("", 0, "");

                Console.WriteLine("");

                Console.WriteLine($"Ingresa el nombre del articulo {i + 1}:");
                articulos[i].nombre = Console.ReadLine();

                Console.WriteLine($"Ingresa el precio del articulo{i + 1}:");
                articulos[i].precio = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine($"Ingresa la categoria del articulo {i + 1}:");
                articulos[i].categoria = Console.ReadLine();

            }

            Console.Clear();

            for (int i = 0; i < articulos.Length; i++)
            {
                Console.WriteLine($"Nombre del articulo {i + 1}: {articulos[i].nombre}");
                Console.WriteLine($"Precio del articulo {i + 1}: {articulos[i].precio}");
                Console.WriteLine($"Categoria del articulo {i + 1}: {articulos[i].categoria}");

                Console.WriteLine("");
            }
        }
    }

    class Articulos
    {

        public Articulos(string nombre, double precio, string categoria)
        {
            this.nombre = nombre;
            this.precio = precio;
            this.categoria = categoria;
        }

        public string nombre { get; set; }
        public double precio { get; set; }
        public string categoria { get; set; }
    }
}