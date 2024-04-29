using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RE29A4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Controlador_Click(object sender, EventArgs e)
        {
            string mensajeError = "";
            bool esValido = true;
            Button boton = (Button)sender;

            try { 
            switch (boton.Text) 
            {
                case "Evaluar":
                    UI.MostrarNegativoPositivo(textBoxEntrada.Text);
                    break;
            }
            }
            catch(Exception error)
            {
                esValido = false;
                mensajeError = error.Message;
            }
            finally
            {
                if (!esValido) UI.MostrarError(mensajeError);
            }
        }

        private void textBoxEntrada_Leave(object sender, EventArgs e)
        {
            try
            {
                Validar.Cadena(textBoxEntrada.Text);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxEntrada.Text = "";
                textBoxEntrada.Focus();
            }
        }
    }
}
