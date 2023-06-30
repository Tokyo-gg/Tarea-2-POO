using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_7
{
    public class AspiranteElectoral
    {
        private int NumerodeVotos;
        private string Nombre;

        public AspiranteElectoral(int numerodeVotos, string nombre)
        {
            NumerodeVotos = numerodeVotos;
            Nombre = nombre;
        }

        public int GetNumerodeVotos()
        {
            return NumerodeVotos;
        }

        public void SetNumerodeVotos(int value)
        {
            NumerodeVotos = value;
        }
        public string GetNombre()
        {
            return Nombre;
        }

        public void SetNombre(string value)
        {
            Nombre = value;
        }

        public void AgregarVoto()
        {
        
            NumerodeVotos = NumerodeVotos+1;
        
        }
    }
}
