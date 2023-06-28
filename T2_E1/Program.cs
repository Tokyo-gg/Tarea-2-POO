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

            int numero1 = int.Parse(Console.ReadLine());
            int numero2 = int.Parse(Console.ReadLine());
            int numero3 = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Calculadora calculadora = new Calculadora(numero1, numero2, numero3);//

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
        private int numero1;
        private int numero2;
        private int numero3;

        public Calculadora(int num1, int num2, int num3) //metodo constructor de la clase
        {
            this.numero1 = num1;
            this.numero2 = num2;
            this.numero3 = num3;
        }

        public int ObtenerSuma() //metodo que devuelve la suma
        {
            return numero1 + numero2 + numero3;
        }

        public String ObtenerPromedio() //metodo que devuelve el promedio
        {
            double promedio = ObtenerSuma() / 3.00;
            return promedio.ToString("0.##"); //metodo para definir que solo queremos dos valores después del punto

        }

        public int ObtenerProducto() //metodo que devuelve el producto
        {
            return numero1 * numero2 * numero3;
        }

        public int ObtenerMayor() //metodo que devuelve el numero mayor
        {
            int mayor = Math.Max(numero1, Math.Max(numero2, numero3));
            return mayor;
        }

        public int ObtenerMenor() //metodo que devuelve el numero menor
        {
            int menor = Math.Min(numero1, Math.Min(numero2, numero3));
            return menor;
        }
    }
}
