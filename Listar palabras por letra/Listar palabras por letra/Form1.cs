using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Listar_palabras_por_letra
{
    public partial class Form1 : Form
    {
        private ListaPorLetra listaPorLetra;

        public Form1()
        {
            InitializeComponent();
            listaPorLetra = new ListaPorLetra();
        }

        // Método para agregar una palabra cuando se hace clic en el botón "Agregar"
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string palabra = txtPalabra.Text.Trim();

            if (!string.IsNullOrEmpty(palabra))
            {
                listaPorLetra.AgregarPalabra(palabra);
                lblStatus.Text = $"Palabra '{palabra}' agregada.";
                ActualizarListaPalabras();
            }
            else
            {
                lblStatus.Text = "Por favor, ingrese una palabra válida.";
            }
        }

        // Método para actualizar la lista de palabras clasificadas por letra
        private void ActualizarListaPalabras()
        {
            lstPalabras.Items.Clear();
            string palabrasClasificadas = listaPorLetra.MostrarPalabrasPorLetra();
            lstPalabras.Items.AddRange(palabrasClasificadas.Split('\n'));
        }
    }
}
