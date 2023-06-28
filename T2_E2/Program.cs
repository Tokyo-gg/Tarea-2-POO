using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;


namespace T2_E2
{ using System;

    public class AgeCalculator //Creamos la clase AgeCalculator que va a calcular la edad 
    {
        public static void CalcularEdad(DateTime fechaNacimiento) //El argumento de la funcion es la fecha de nacimiento, usando DateTime como tipo de dato
        {
            DateTime now = DateTime.Now; //Establecemos la fecha actual
            //Hacemos la resta de la fecha actual con la fecha de nacimiento para obtener la edad
            int años = now.Year - fechaNacimiento.Year;
            int meses = now.Month - fechaNacimiento.Month;
            int dias = now.Day - fechaNacimiento.Day;
            int horas = now.Hour - fechaNacimiento.Hour;
            int minutos = now.Minute - fechaNacimiento.Minute;
            int segundos = now.Second - fechaNacimiento.Second;

            if (meses < 0 || (meses == 0 && now.Day < fechaNacimiento.Day)) //Condicion para saber los años que ha vivido
            {
                años--;
                meses += 12;
            }

            if (dias < 0) //Condicion para saber los meses que ha vivido
            {
                meses--;
                dias += DateTime.DaysInMonth(now.Year, now.Month); //Usamos la funcion DaysInMonth para saber los dias que tiene el mes actual, tomando en cuenta si es año bisiesto o no
            }

            if (horas < 0) //Condicion para saber los dias que ha vivido
            {
                dias--;
                horas += 24;
            }

            if (minutos < 0) //Condicion para saber las horas que ha vivido
            {
                horas--;
                minutos += 60;
            }

            if (segundos < 0) //Condicion para saber los minutos que ha vivido, el restante son los segundos
            {
                minutos--;
                segundos += 60;
            }

            Console.WriteLine($"Edad: {años} años, {meses} meses, {dias} dias, {horas} horas, {minutos} minutos, {segundos} segundos"); //Mostramos la edad
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int dia, mes, año; //Variables para almacenar la fecha de nacimiento
            Console.WriteLine("Introduce tu fecha de nacimiento: ");
            Console.WriteLine("Dia: ");
            dia = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Mes: ");
            mes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Año: ");
            año = Convert.ToInt32(Console.ReadLine());

            DateTime fechaNacimiento = new DateTime(año, mes, dia);//Creamos un objeto de tipo DateTime con la fecha de nacimiento que introdujo el usuario
            AgeCalculator.CalcularEdad(fechaNacimiento);//Llamamos a la funcion CalcularEdad y le pasamos como argumento la fecha de nacimiento
        }
    }
}

