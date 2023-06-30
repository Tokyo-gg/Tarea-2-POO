using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace T2_E1
{
    /*Clase que recibe tres enteros e imprime la suma, el promedio, el producto, mayor y menor */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese tres números enteros:");

            int num1 = int.Parse(Console.ReadLine()); // int.Parse() convierte las cadenas de texto en números enteros 
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Calculadora calculadora = new Calculadora(num1, num2, num3);

            Console.WriteLine("Suma: " + calculadora.ObtenerSuma());
            Console.WriteLine("Promedio: " + calculadora.ObtenerPromedio());
            Console.WriteLine("Producto: " + calculadora.ObtenerProducto());
            Console.WriteLine("Mayor: " + calculadora.ObtenerMayor());
            Console.WriteLine("Menor: " + calculadora.ObtenerMenor());

        }

    }

    /*Clase que realiza los calculos*/
    class Calculadora
    {
        private int num1;
        private int num2;
        private int num3;

        public Calculadora(int num1, int num2, int num3) //metodo constructor de la clase
        {
            this.num1 = num1;
            this.num2 = num2;
            this.num3 = num3;
        }

        public int ObtenerSuma()
        {
            return num1 + num2 + num3;
        }

        public String ObtenerPromedio()
        {
            double promedio = ObtenerSuma() / 3.00;
            return promedio.ToString("0.##"); //metodo que convierte cualquier tipo en string y muestra solo dos valores después del punto

        }

        public int ObtenerProducto()
        {
            return num1 * num2 * num3;
        }

        public int ObtenerMayor()
        {
            int mayor = Math.Max(num1, Math.Max(num2, num3));
            return mayor;
        }

        public int ObtenerMenor()
        {
            int menor = Math.Min(num1, Math.Min(num2, num3));
            return menor;
        }
    }
}