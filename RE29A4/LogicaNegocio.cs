using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RE29A4
{
    public static class LogicaNegocio
    {
        public static bool ValidarPositivo(string cadenaNum)
        {

            bool valido;
            float num = Convert.ToSingle(cadenaNum);

            if (num > 0) valido = true;
            else valido = false;

            return valido;
        }
    }
}
