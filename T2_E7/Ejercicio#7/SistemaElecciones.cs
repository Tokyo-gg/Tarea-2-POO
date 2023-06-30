using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_7
{
    public class SistemaElecciones
    {
        private int TotalVotos;
        private List<AspiranteElectoral> AspirantesElectorales;

        public SistemaElecciones(int totalVotos, List<AspiranteElectoral> aspirantesElectorales)
        {
            TotalVotos = totalVotos;
            AspirantesElectorales = aspirantesElectorales;
        }

        public int GetTotalVotos()
        {
            return TotalVotos;
        }

        public void SetTotalVotos(int value)
        {
            TotalVotos = value;
        }

        public List<AspiranteElectoral> GetAspirantesElectorales()
        {
            return AspirantesElectorales;
        }

        public void SetAspirantesElectorales(List<AspiranteElectoral> value)
        {
            AspirantesElectorales = value;
        }

        public void AgregarTotalVotos() {
            TotalVotos = 0;
            foreach(AspiranteElectoral aspiranteElectoral in AspirantesElectorales)
            {
                TotalVotos = TotalVotos + aspiranteElectoral.GetNumerodeVotos();
            }
        }
    }
}
