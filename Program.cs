using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2eje1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3,suma,producto;

            Console.WriteLine("Ingrese un Entero:");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese un Entero:");
            n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese un Entero:");
            n3 = int.Parse(Console.ReadLine()); 

            //suma de los tres enteros
            suma=n1+n2+n3;
            Console.WriteLine("la Suma es:" +suma);

            //promedio de los tres enteros
            double promedio = Convert.ToDouble(suma)/3;
            promedio = Math.Round(promedio, 2);
            Console.WriteLine("El Promedio es:" + promedio);

            //producto de los tres enteros
            producto = n1 * n2 * n3;
            Console.WriteLine("El Producto es: " + producto);

            //numero mayor y menor de los tres enteros
            int mayor, menor;
           
            mayor = n1;
            if(mayor<n2) mayor = n2;
            if(mayor<n3) mayor = n3;
            
            menor = n1;
            if (menor > n2) menor = n2;
            if (menor > n3 ) menor = n3;

            Console.WriteLine("El menor de los tres enteros es: " + menor);
            Console.WriteLine("El mayor de los tres enteros es: " + mayor);

            Console.ReadLine();
        }

    }



}
