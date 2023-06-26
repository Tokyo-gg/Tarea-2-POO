using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;


namespace T2_E2
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculadoraEdad calculadora = new CalculadoraEdad();
            calculadora.Ejecutar();

            Console.ReadLine();
        }
    }

    class CalculadoraEdad
    {
        private DateTime fechaActual;

        public CalculadoraEdad()
        {
            fechaActual = DateTime.Now;
        }

        public void SolicitarFechaNacimiento()
        {
            while (true)
            {
                try
                {
                    Console.Write("Ingrese su fecha de nacimiento (formato: dd/mm/aaaa): ");
                    string fechaNacimientoStr = Console.ReadLine();
                    DateTime fechaNacimiento = DateTime.ParseExact(fechaNacimientoStr, "dd/MM/yyyy", null);
                    FechaNacimiento = fechaNacimiento;
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Formato de fecha incorrecto. Intente nuevamente.");
                }
            }
        }

        public void CalcularEdad()
        {
            TimeSpan edad = fechaActual - FechaNacimiento;
            EdadAnios = edad.Days / 365;
            EdadMeses = edad.Days / 30;
            EdadDias = edad.Days;
            EdadHoras = edad.TotalHours;
            EdadMinutos = edad.TotalMinutes;
            EdadSegundos = edad.TotalSeconds;
        }

        public void ImprimirEdad()
        {
            Console.WriteLine("        Edad");
            Console.WriteLine("Años: " + EdadAnios);
            Console.WriteLine("Meses: " + EdadMeses);
            Console.WriteLine("Días: " + EdadDias);
            Console.WriteLine("Horas: " + EdadHoras);
            Console.WriteLine("Minutos: " + EdadMinutos);
            Console.WriteLine("Segundos: " + EdadSegundos);
        }

        public void Ejecutar()
        {
            SolicitarFechaNacimiento();
            CalcularEdad();
            ImprimirEdad();
        }

        public DateTime FechaNacimiento { get; private set; }
        public int EdadAnios { get; private set; }
        public int EdadMeses { get; private set; }
        public int EdadDias { get; private set; }
        public double EdadHoras { get; private set; }
        public double EdadMinutos { get; private set; }
        public double EdadSegundos { get; private set; }
    }
}
