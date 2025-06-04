using System;

public class Class1 
{
	public void Ejercicio1()
    {

        Console.WriteLine("\n Ejercicio #1: \n");
        //  Una tienda de electrónica tiene una matriz que representa el inventario de distintos
        //  tipos de Dispositivos(televisores, laptops, teléfonos, etc.) en varios almacenes.
        //  Cada fila representa un tipo de dispositivo y cada columna un almacén.

        //  ~ Calcula la cantitad total de dispositivos en cada almacén.
        //  ~ Determina qué dispositivo tiene mayor y menor cantidad en cada almacén.


        string[] Campos = new string[3];
        Campos[0] = "|   Televisores   ";
        Campos[1] = "|   Laptops   ";
        Campos[2] = "|   Teléfonos   |";

        int[,] Inventario = new int[3, 5];
        int[] col1 = new int[Inventario.Length];
        int[] col2 = new int[Inventario.Length];
        int[] col3 = new int[Inventario.Length];

        Console.Write(" ~ Ingrese los datos de la primera fila: ");
        Inventario[0, 0] = int.Parse(Console.ReadLine());
        Inventario[1, 0] = int.Parse(Console.ReadLine());
        Inventario[2, 0] = int.Parse(Console.ReadLine());

        Console.Write(" ~ Ingrese los datos de la segunda fila: ");
        Inventario[0, 1] = int.Parse(Console.ReadLine());
        Inventario[1, 1] = int.Parse(Console.ReadLine());
        Inventario[2, 1] = int.Parse(Console.ReadLine());

        Console.Write(" ~ Ingrese los datos de la tercera fila: ");
        Inventario[0, 2] = int.Parse(Console.ReadLine());
        Inventario[1, 2] = int.Parse(Console.ReadLine());
        Inventario[2, 2] = int.Parse(Console.ReadLine());

        Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - ");
        Console.WriteLine(Campos[0] + Campos[1] + Campos[2]);
        Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - ");
        Console.WriteLine("|       {0}       |       {1}      |       {2}      |", Inventario[0, 0], Inventario[1, 0], Inventario[2, 0]);
        Console.WriteLine("|       {0}       |       {1}      |       {2}      |", Inventario[0, 1], Inventario[1, 1], Inventario[2, 1]);
        Console.WriteLine("|       {0}       |       {1}      |       {2}      |", Inventario[0, 2], Inventario[1, 2], Inventario[2, 2]);

        for (int i = 0; i < 5; i++)
        {
            col1[i] = Inventario[0, i];

        }
        for (int i = 0; i < 5; i++)
        {
            col2[i] = Inventario[1, i];
        }
        for (int i = 0; i < 5; i++)
        {
            col3[i] = Inventario[2, i];
        }

        int columna1 = col1.Sum();
        int columna2 = col2.Sum();
        int columna3 = col3.Sum();

       

        Console.WriteLine("\n El total de la columna 1 es: {0} \n El total de la columna 2 es: {1} \n El total de la columna 3 es: {2}", columna3, columna1, columna2);
    }

    public void Ejercicio3()
    {
        Console.WriteLine("\n Ejercicio #3: \n");
        // Declarar un arreglo que almacene números leídos por teclado y su la sumatoria es
        // Mayor o igual que 100, debe mostrar el resultado en pantalla dicho resultado. Sugerencia
        // Para esto se debe utilizar un bucle.

        Console.Write("Ingresa la cantidad de numeros que quieres sumar: ");
        int[] posiciones = new int[Convert.ToInt32(Console.ReadLine())];
        double[] numeros = new double[posiciones.Length];

        for (int i = 0; i < posiciones.Length; i++)
        {
            Console.Write("Introduce el numero: ");
            numeros[i] = double.Parse(Console.ReadLine());

        }

        double sumatoria = numeros.Sum();

        if (sumatoria >= 100) Console.WriteLine("\n La sumatoria es mayor a 100. \n El resultado es: " + sumatoria);
        else Console.WriteLine(" La sumatoria no es mayor que 100.");

    }
}
