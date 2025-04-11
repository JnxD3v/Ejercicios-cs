using System;

namespace Array1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Llamando cada ejercicio.
            // jaja c me olvido

            //Ejercicio1 Ej1 = new Ejercicio1();
            //Ej1.Ej1();

            //Ejercicio1 Ej2 = new Ejercicio1();
            //Ej2.Ej2();

            Ejercicio1 Ej3 = new Ejercicio1();
            Ej3.Ej3();
        }
    }

    class Ejercicio1
    {
//// Crea un array de 10 posiciones, con valores puestos por ti y muestra el array.
//        public void Ej1()
//        {
//            int[] numeros = { 11, 24, 10, 34, 59, 16, 58, 27, 95, 23 };

//            Console.WriteLine(" #Ej 1: Los numeros son: ");
//            for (int i = 0; i < 10; i++) Console.WriteLine("  {0}",numeros[i]);
//        }

//        public void Ej2()
//        {
//// Crea un array de 10 posiciones, pide los valores por consola y muestra el array.
//            int[] numeros = new int[10];


//            int j = 1;
//            Console.Write("\n #Ej 2: Ingrese 10 Números: ");
//            for (int i = 0; i < numeros.Length; i++) numeros[i] = int.Parse(Console.ReadLine());
//            for (int i = 0; i < numeros.Length; i++)
//            {
//                Console.WriteLine("# El numero {1} es: {0}", numeros[i], j);
//                j++;
//            }
//        }

        public void Ej3() 
        {
// Sumar los valores de un array y mostrar el resultado.
            int[] sumar = new int[5];
            int resultado = 0, vueltas = 0;
            
            for (int i = 0; i < 5; i++)
            {
                Console.Write(" #Ej 3: Ingrese 5 Números que desee sumar: ");
                sumar[i] = int.Parse(Console.ReadLine());
            }
            // ...
        }
    }
}