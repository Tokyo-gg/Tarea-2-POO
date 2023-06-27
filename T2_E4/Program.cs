using System;
using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;


namespace T2_E4
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
        private List<Alumno> alumnos;

        public Asignatura(string codigo, string nombre, string hora, string catedratico)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.hora = hora;
            this.catedratico = catedratico;
            this.alumnos = new List<Alumno>();
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

            alumnos.Add(alumno);

            Console.WriteLine("Alumno agregado correctamente.");
        }

        public void MostrarAlumnos()
        {
            Console.WriteLine("Alumnos agregados:");
            foreach (Alumno alumno in alumnos)
            {
                Console.WriteLine("Número de cuenta: " + alumno.NumeroCuenta);
                Console.WriteLine("Nombre: " + alumno.Nombre);
                Console.WriteLine();
            }
        }

        public void ImprimirDetallesAsignatura()
        {
            Console.WriteLine("Detalles de la asignatura:");
            Console.WriteLine("Código: " + codigo);
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Hora de impartición: " + hora);
            Console.WriteLine("Catedratico: " + catedratico);   
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Asignatura asignatura = new Asignatura("IS410", "Programación Orientada a Objetos", "09:00", " Ing. Julio Sandoval");

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
