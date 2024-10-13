using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Palindromo
{
    public partial class Form1 : Form
    {
        private ListaCaracteres listaCaracteres;

        public Form1()
        {
            InitializeComponent();
            listaCaracteres = new ListaCaracteres();
        }

        // Método para verificar si la palabra es un palíndromo
        private void btnVerificar_Click(object sender, EventArgs e)
        {
            string palabra = txtPalabra.Text.Trim().ToLower();  // Convertir la palabra a minúsculas para comparación

            if (!string.IsNullOrEmpty(palabra))
            {
                // Limpiar la lista de caracteres antes de agregar la nueva palabra
                listaCaracteres = new ListaCaracteres();

                // Agregar cada carácter de la palabra a la lista enlazada
                foreach (char c in palabra)
                {
                    listaCaracteres.AgregarCaracter(c);
                }

                // Verificar si la palabra es un palíndromo
                if (listaCaracteres.EsPalindromo())
                {
                    lblResultado.Text = $"La palabra '{palabra}' es un palíndromo.";
                }
                else
                {
                    lblResultado.Text = $"La palabra '{palabra}' no es un palíndromo.";
                }
            }
            else
            {
                lblResultado.Text = "Por favor, ingrese una palabra válida.";
            }
        }
    }
}
