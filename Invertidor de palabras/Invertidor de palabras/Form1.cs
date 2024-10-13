using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invertidor_de_palabras
{
    public partial class Form1 : Form
    {
        private ListaCaracteres listaCaracteres;

        public Form1()
        {
            InitializeComponent();
            listaCaracteres = new ListaCaracteres();
        }

        // Método para procesar la palabra cuando se hace clic en "Invertir"
        private void btnInvertir_Click(object sender, EventArgs e)
        {
            string palabra = txtPalabra.Text.Trim();

            if (!string.IsNullOrEmpty(palabra))
            {
                // Limpiar la lista de caracteres antes de agregar la nueva palabra
                listaCaracteres = new ListaCaracteres();

                // Agregar cada carácter de la palabra a la lista enlazada
                foreach (char c in palabra)
                {
                    listaCaracteres.AgregarCaracter(c);
                }

                // Invertir la lista de caracteres
                listaCaracteres.Invertir();

                // Mostrar la palabra invertida
                lblResultado.Text = $"Palabra invertida: {listaCaracteres.ObtenerPalabra()}";
            }
            else
            {
                lblResultado.Text = "Por favor, ingrese una palabra válida.";
            }
        }
    }
}
