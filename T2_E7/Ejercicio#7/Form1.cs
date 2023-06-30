using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_7
{
    public partial class FRMPrincipal : Form
    {
        // Creamos tres objetos AspiranteElectoral con sus respectivos nombres
        AspiranteElectoral Aspirante1 = new AspiranteElectoral(0, "Sir Ratius III");
        AspiranteElectoral Aspirante2 = new AspiranteElectoral(0, "Don Doggy");
        AspiranteElectoral Aspirante3 = new AspiranteElectoral(0, "Mr Potato");
        // Creamos una lista de AspiranteElectoral y agregamos los tres objetos creados anteriormente
        List<AspiranteElectoral> listaaspirantes;
        // Creamos un objeto SistemaElecciones con la lista de aspirantes creada anteriormente
        SistemaElecciones SistemaElecciones;

        public FRMPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Mostramos los nombres de los aspirantes en las etiquetas correspondientes
            LBLNombre1.Text = Aspirante1.GetNombre();
            LBLNombre2.Text = Aspirante2.GetNombre();
            LBLNombre3.Text = Aspirante3.GetNombre();
            // Inicializamos la lista de aspirantes y el objeto SistemaElecciones
            listaaspirantes = new List<AspiranteElectoral>() { Aspirante1, Aspirante2, Aspirante3 };
            SistemaElecciones = new SistemaElecciones(0, listaaspirantes);
            // Mostramos los porcentajes de votos iniciales (0%)
            LBLPorcentaje1.Text = "0" + '%';
            LBLPorcentaje2.Text = "0" + '%';
            LBLPorcentaje3.Text = "0" + '%';
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        // Método para actualizar la información en las etiquetas
        public void Actualizar()
        {
            int x, y, z;
            // Mostramos la cantidad de votos de cada aspirante en las etiquetas correspondientes
            LBLVotos1.Text = "Votos: " + Aspirante1.GetNumerodeVotos().ToString();
            LBLVotos2.Text = "Votos: " + Aspirante2.GetNumerodeVotos().ToString();
            LBLVotos3.Text = "Votos: " + Aspirante3.GetNumerodeVotos().ToString();
            // Mostramos el total de votos en la etiqueta correspondiente
            LBLTotalVotos.Text = "Votos Totales: " + SistemaElecciones.GetTotalVotos().ToString();
            // Calculamos y mostramos el porcentaje de votos de cada aspirante en las etiquetas correspondientes
            x = (Aspirante1.GetNumerodeVotos() * 100) / SistemaElecciones.GetTotalVotos();
            LBLPorcentaje1.Text = x.ToString() + '%';
            y = (Aspirante2.GetNumerodeVotos() * 100) / SistemaElecciones.GetTotalVotos();
            LBLPorcentaje2.Text = y.ToString() + '%';
            z = (Aspirante3.GetNumerodeVotos() * 100) / SistemaElecciones.GetTotalVotos();
            LBLPorcentaje3.Text = z.ToString() + '%';
        }

        // Evento para cuando se hace clic en el botón del primer aspirante
        private void BTNParticipante1_Click(object sender, EventArgs e)
        {
            // Agregamos un voto al primer aspirante y al total de votos
            Aspirante1.AgregarVoto();
            SistemaElecciones.AgregarTotalVotos();
            // Actualizamos la información en las etiquetas
            Actualizar();
        }

        // Evento para cuando se hace clic en el botón del segundo aspirante
        private void BTNParticipante2_Click(object sender, EventArgs e)
        {
            // Agregamos un voto al segundo aspirante y al total de votos
            Aspirante2.AgregarVoto();
            SistemaElecciones.AgregarTotalVotos();
            // Actualizamos la información en las etiquetas
            Actualizar();
        }

        // Evento para cuando se hace clic en el botón del tercer aspirante
        private void BTNParticipante3_Click(object sender, EventArgs e)
        {
            // Agregamos un voto al tercer aspirante y al total de votos
            Aspirante3.AgregarVoto();
            SistemaElecciones.AgregarTotalVotos();
            // Actualizamos la información en las etiquetas
            Actualizar();
        }
    }
}