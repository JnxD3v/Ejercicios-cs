using System;
// Ejercicio 1: --
// Crear una clase llamada articulos cuya propiedades son Nombre, Precio, Categoria
// Luego en la clase principal instanciar 2 objetos de la clase Articulos.

// Ejercicio 2: --
// Crear una clase
public class Ejercicio1
{
    Articulos Articulo1 = new Articulos();
    Articulos Articulo2 = new Articulos();

    public void entradaArticulos()
    {
        Console.Write(" ~ Ingrese el nombre del articulo: ");
        Articulo1.GetNombre(Console.ReadLine());

        Console.Write(" ~ Ingrese el precio del articulo: ");
        Articulo1.GetPrecio(int.Parse(Console.ReadLine()));

        Console.Write(" ~ Ingrese la categoria del articulo: ");
        Articulo1.GetCategoria(Console.ReadLine());
    }

    public void llamadaArticulos()
    {
        Console.WriteLine(" El nombre del articulo es: {0}", Articulo1.GetNombre);
        Console.WriteLine(" La categoria del articulo es: {0}", Articulo1.GetCategoria);
        Console.WriteLine(" El precio del articulo es: {0}", Articulo1.GetPrecio);
    }
}

public class Articulos 
{
    private string Nombre, Categoria;
    private int Precio;

    public string GetNombre(string Nombre)
    {
        this.Nombre = Nombre;
        return this.Nombre;
    }

    public string GetCategoria(string Categoria)
    {
        this.Categoria = Categoria;
        return this.Categoria;
    }
    public int GetPrecio(int Precio)
    {
        this.Precio = Precio;
        return this.Precio;
    }
}