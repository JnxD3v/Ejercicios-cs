namespace Ejercicio_1
// Crear un programa que lea n cantidad de números enteros y determine cuantos son positivos,
// cuantos negativos, cuantos pares, cuantos impares, luego mostrar los resultados en pantalla.

{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numeroIngresado;
            int n, v = 0, pares = 0, impares = 0, negativos = 0, positivos = 0;

            Console.Write(" ~ Ingrese cuantos numero quiere ingresar: ");
            n = int.Parse(Console.ReadLine());

            while (v < n)
            {
                v++;
                Console.Write(" * Ingrese un número cualquiera: ");
                n = int.Parse(Console.ReadLine());

                if (n % 2 == 0)
                {
                    pares++;
                }
                else if (n % 2 != 0)
                {
                    impares++;
                }
                else if (n > 0)
                {
                    positivos++;
                }
                else if (n < 0)
                {
                    negativos++;
                }

            }

            Console.WriteLine();
            Console.WriteLine(" Gracias por usar, Los resultados fueron: ");
            Console.WriteLine($" Los pares fueron: {pares};");
            Console.WriteLine($" Los impares fueron: {impares};");
            Console.WriteLine($" Los positivos fueron: {positivos};");
            Console.WriteLine($" Los negativos fueron: {negativos};");
        }
    }
}
