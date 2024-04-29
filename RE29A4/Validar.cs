using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RE29A4
{
    public static class Validar
    {
        public static void Cadena(string cadena)
        {
            if (string.IsNullOrEmpty(cadena)) throw new ArgumentNullException("Cadena Vacía");
            if (cadena.Length > 20) throw new FormatException("la cadena supera el número de caracteres permitido");

        }
    }
}
