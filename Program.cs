using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;


namespace T2_E3
{
    class Alumno
    {
        public string NumeroCuenta { get; set; }
        public string Nombre { get; set; }
    }

    class Asignatura
    {
        private string codigo;
        private string nombre;
        private string hora;
        private string catedratico;
        private Alumno[] alumnos;
        private int totalAlumnos;

        public Asignatura(string codigo, string nombre, string hora, string catedratico)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.hora = hora;
            this.alumnos = new Alumno[30]; // Suponemos un máximo de 30 alumnos
            this.totalAlumnos = 0;
            this.catedratico = catedratico;
        }

        public void AgregarAlumno()
        {
            Console.WriteLine("Ingrese los datos del alumno:");
            Console.Write("Número de cuenta: ");
            string numeroCuenta = Console.ReadLine();
            Console.Write("Nombre: ");
            string nombreAlumno = Console.ReadLine();

            Alumno alumno = new Alumno
            {
                NumeroCuenta = numeroCuenta,
                Nombre = nombreAlumno
            };

            alumnos[totalAlumnos] = alumno;
            totalAlumnos++;

            Console.WriteLine("Alumno agregado correctamente.");
        }

        public void MostrarAlumnos()
        {
            Console.WriteLine("Alumnos agregados:");
            for (int i = 0; i < totalAlumnos; i++)
            {
                Console.WriteLine("Número de cuenta: " + alumnos[i].NumeroCuenta);
                Console.WriteLine("Nombre: " + alumnos[i].Nombre);
                Console.WriteLine();
            }
        }

        public void ImprimirDetallesAsignatura()
        {
            Console.WriteLine("Detalles de la asignatura:");
            Console.WriteLine("Código: " + codigo);
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Catedratico que la imparte: " + catedratico);
            Console.WriteLine("Hora de impartición: " + hora);
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Asignatura asignatura = new Asignatura("IS410", "Programación Orientada a Objetos", "09:00", "Ing. Julio Sandoval");

            bool salir = false;
            while (!salir)
            {
                Console.WriteLine("Menú:");
                Console.WriteLine("1. Agregar alumno.");
                Console.WriteLine("2. Mostrar alumnos agregados.");
                Console.WriteLine("3. Salir");
                Console.Write("Seleccione una opción: ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        asignatura.AgregarAlumno();
                        break;
                    case "2":
                        asignatura.ImprimirDetallesAsignatura();
                        asignatura.MostrarAlumnos();
                        break;
                    case "3":
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Opción inválida. Intente nuevamente.");
                        break;
                }

                Console.WriteLine();
            }

            Console.WriteLine("¡Hasta luego!");
        }
    }
}
