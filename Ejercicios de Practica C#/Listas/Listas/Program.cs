namespace Listas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Colores();
        }

        private void Colores()
        {
            // Lista de colores sin orden.
            List<string> listaDeColores = new List<string>();

            listaDeColores.Add("Rojo");
            listaDeColores.Add("Morado");
            listaDeColores.Add("Azul");
            listaDeColores.Add("Verde");
            listaDeColores.Add("Naranja");
            listaDeColores.Add("Negro");
            int i = 1;

            Console.WriteLine("  Lista de colores sin orden.");
            foreach (var item in listaDeColores)
            {

                Console.WriteLine(" [@] Color #{1}: {0}", item, i);
                i += 1;
            }

        }
    }
}
