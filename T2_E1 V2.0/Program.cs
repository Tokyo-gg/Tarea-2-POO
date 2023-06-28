using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2_E1_V2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese tres números enteros:");

            // Leer las tres entradas desde la consola
            Console.Write("Primer número: ");
            int numero1 = int.Parse(Console.ReadLine());

            Console.Write("Segundo número: ");
            int numero2 = int.Parse(Console.ReadLine()); //En la version 1.0 los imputs eran string y luego lo convertia a int, aqui el int.parse se hace directo 

            Console.Write("Tercer número: ");
            int numero3 = int.Parse(Console.ReadLine());

            // Calcular la suma
            int suma = numero1 + numero2 + numero3;

            // Calcular el promedio
            double promedio = suma / 3.0;

            // Calcular el producto
            int producto = numero1 * numero2 * numero3;

            // Encontrar el menor número
            int menor = Math.Min(numero1, Math.Min(numero2, numero3));

            // Encontrar el mayor número
            int mayor = Math.Max(numero1, Math.Max(numero2, numero3));

            // Imprimir los resultados
            Console.WriteLine("Suma: " + suma);
            Console.WriteLine("Promedio: " + promedio);
            Console.WriteLine("Producto: " + producto);
            Console.WriteLine("Menor número: " + menor);
            Console.WriteLine("Mayor número: " + mayor);
        }
    }
}
