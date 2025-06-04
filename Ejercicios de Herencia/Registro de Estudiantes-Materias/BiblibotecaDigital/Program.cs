using System.Text;

namespace BiblibotecaDigital
{
    internal class Program
    {
        static int opciones;
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            // Crear Estudiante;
            //Console.Write(" [#] Ingrese el nombre del estudiante:  ");
            Console.WriteLine("\n    - Registro Academico \n-");
            Console.ForegroundColor = ConsoleColor.Yellow;
            //Console.Write(" [#] Ingrese el nombre del estudiante:  ");
            Console.WriteLine(" [#]  Elija una opción:");
            Console.ForegroundColor= ConsoleColor.DarkGray;
            Console.WriteLine(" ------------- • ------------");
            Opciones();
        }

        static void Opciones()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" [1]  Agregar estudiantes. ");
            Console.WriteLine(" [2]  Salir.");

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("\n [#]  ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("Ingrese una Opción: ");
            opciones = int.Parse(Console.ReadLine());

            switch (opciones)
            {

                case 1:
                    CrearEstudiantes();
                    break;
                case 2:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine(" Fin del Programa!");
                    Console.ResetColor();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine(" Error! Opcion invalida. Intente de nuevo.");
                    Opciones();
                    break;
            }
        }

        static void CrearEstudiantes()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("\n [#] Ingrese cuantos estudiantes quiere crear: ");
            Estudiante[] AgregarEstudiante = new Estudiante[int.Parse(Console.ReadLine())];
            

            for (int i = 0; i < AgregarEstudiante.Length; i++)
            {
                AgregarEstudiante[i] = new Estudiante();
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(" [#] Ingrese el nombre del estudiante No. " + (i + 1));
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("  # ");
                Console.ForegroundColor = ConsoleColor.Gray;
                string Nombre = Console.ReadLine();
                AgregarEstudiante[i].SetNombre(Nombre);

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(" [#] Ingrese la edad del estudiante No. " + (i + 1));
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("  # ");
                Console.ForegroundColor = ConsoleColor.Gray;
                int Edad = int.Parse(Console.ReadLine());
                AgregarEstudiante[i].SetEdad(Edad);

                
            }
        }
    }

    class Estudiante
    {

        public void SetNombre(string nombre) => this.Nombre = nombre;
        public string GetNombre() => this.Nombre;
        public void SetEdad(int edad) => this.Edad = edad;
        public int GetEdad() => this.Edad;

        protected string Nombre { get; set; }
        protected int Edad { get; set; }
    }

    class Asignatura
    {

        public Asignatura(string Materia, double Calificacion)
        {
            this.Materia = Materia;
            this.Calificacion = Calificacion;
        }

        public string GetMateria() => this.Materia;
        public double GetCalificacion() => this.Calificacion;

        protected string Materia { get; set; }
        protected double Calificacion { get; set; }
    }

    class RegistroAcademico
    {
        List<Asignatura> Materias = [];
        public void AgregarAsignatura(string NombreAsignatura, double Calificacion)
        {
            Asignatura MATERIA = new Asignatura(NombreAsignatura, Calificacion);
            Materias.Add(MATERIA);
        }
    }
}
