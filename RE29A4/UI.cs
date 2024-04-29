using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RE29A4
{
    public static class UI
    {
        public static void MostrarNegativoPositivo(string cadena)
        {
            if (LogicaNegocio.ValidarPositivo(cadena) == true) MostrarMensaje(cadena, "es positivo");
            else MostrarMensaje(cadena, "es negativo");
                
        }
        private static void MostrarMensaje(string dato, string cadena)
        {
            MessageBox.Show($"{dato} {cadena}", "Positivo o Negativo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void MostrarError(string cadena)
        {
            MessageBox.Show($"Error: {cadena}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
