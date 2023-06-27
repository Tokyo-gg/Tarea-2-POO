using System;
using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;


namespace T2_E5
{
    class ListaCaracteres
    {
        private List<char> lista;

        public ListaCaracteres()
        {
            lista = new List<char>();
        }

        public void AgregarCaracteres()
        {
            Console.Write("Ingrese la cadena de caracteres: ");
            string cadena = Console.ReadLine();
                    
            Console.Write("Ingrese la posición en la que desea insertar la cadena: ");
            int posicion = int.Parse(Console.ReadLine());

            if (posicion >= 1 && posicion <= lista.Count + 1)
            {
                lista.InsertRange(posicion - 1, cadena.ToCharArray());
                Console.WriteLine("Cadena insertada correctamente.");
            }
            else
            {
                Console.WriteLine("Posición inválida. No se pudo insertar la cadena.");
            }
        }

        public void EliminarCaracter()
        {
            Console.Write("Ingrese la posición del carácter que desea eliminar: ");
            int posicion = int.Parse(Console.ReadLine());

            if (posicion >= 1 && posicion <= lista.Count)
            {
                lista.RemoveAt(posicion - 1);
                Console.WriteLine("Carácter eliminado correctamente.");
            }
            else
            {
                Console.WriteLine("Posición inválida. No se pudo eliminar el carácter.");
            }
        }

        public void EliminarSublista()
        {
            Console.Write("Ingrese la posición de inicio de la sublista: ");
            int inicio = int.Parse(Console.ReadLine());
            Console.Write("Ingrese la posición de fin de la sublista: ");
            int fin = int.Parse(Console.ReadLine());

            if (inicio >= 1 && fin <= lista.Count && inicio <= fin)
            {
                lista.RemoveRange(inicio - 1, fin - inicio + 1);
                Console.WriteLine("Sublista eliminada correctamente.");
            }
            else
            {
                Console.WriteLine("Posiciones inválidas. No se pudo eliminar la sublista.");
            }
        }

        public void ImprimirLista()
        {
            Console.WriteLine("Contenido de la lista:");
            foreach (char caracter in lista)
            {
                Console.Write(caracter + " ");
            }
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ListaCaracteres listaCaracteres = new ListaCaracteres();

            bool salir = false;
            while (!salir)
            {
                Console.WriteLine("Menú:");
                Console.WriteLine("1. Agregar caracteres a la lista.");
                Console.WriteLine("2. Eliminar carácter.");
                Console.WriteLine("3. Eliminar sublista.");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opción: ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        listaCaracteres.AgregarCaracteres();
                        break;
                    case "2":
                        listaCaracteres.EliminarCaracter();
                        break;
                    case "3":
                        listaCaracteres.EliminarSublista();
                        break;
                    case "4":
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Opción inválida. Intente nuevamente.");
                        break;
                }

                Console.WriteLine();
            }

            listaCaracteres.ImprimirLista();
            Console.WriteLine("¡Hasta luego!");
        }
    }
}

