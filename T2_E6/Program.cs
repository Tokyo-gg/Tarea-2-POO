using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2_E6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese los números separados por espacios y presione Enter para calcular promedio:");
            string input = Console.ReadLine();

            CalcularPromedio calculator = new CalcularPromedio(input);
            double promedio = calculator.Promedio(); 

            Console.WriteLine("El promedio es: " + promedio.ToString("0.00")); //método para formatear el número con dos decimales después del punto
        }

    }


    class CalcularPromedio
    {
        string input;

        public CalcularPromedio(string input)
        {
            this.input = input;
        }

        public double Promedio()
        {
            string[] numeros = input.Split(' '); //.Split divide una cadena en subcadenas cada vez que se encuentre un espacio en blanco,
                                                 //crea un arreglo llamado numeros, donde cada contiene una de las subcadenas
            double suma = 0;
            int cantidad = 0;

            foreach (string numero in numeros)
            {
                if (double.TryParse(numero, out double valor)) // convirte cada elemento de la cadena en un número decimal
                {
                    suma += valor;
                    cantidad++;
                }
                else
                {
                    Console.WriteLine("¡Valor inválido! Se omitirá.");
                }
            }

            if (cantidad > 0)
            {
                return suma / cantidad;
            }
            else
            {
                Console.WriteLine("No se ingresaron números válidos.");
                return 0;
            }
        }
    }


}
