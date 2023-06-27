using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2_E1
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            
            Console.WriteLine("Ingrese tres números enteros:");

            // Leer las tres entradas desde la consola
            Console.Write("Primer número: ");
            string input1 = Console.ReadLine();

            Console.Write("Segundo número: ");
            string input2 = Console.ReadLine();

            Console.Write("Tercer número: ");
            string input3 = Console.ReadLine();

            // Convertir las cadenas de texto en números enteros utilizando int.Parse()
            try
            {
                int num1 = int.Parse(input1);
                int num2 = int.Parse(input2);
                int num3 = int.Parse(input3);           
            }
            catch (FormatException)
            {
                Console.WriteLine("Uno o más valores ingresados no son números enteros válidos.");
            }

            Console.WriteLine("Los 3 numeros son: " + num1 + num2 + num3);
            Console.WriteLine()
        }
    }
}
