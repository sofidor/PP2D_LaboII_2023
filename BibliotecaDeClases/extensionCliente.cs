using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public static class extensionCliente
    {
        /// <summary>
        /// valida si un nombre contiene solo letras
        /// </summary>
        /// <param name="nombre">nombre que se valida</param>
        /// <returns>retorna true si el nombre cumple o false si no lo hace</returns>
        public static bool EsNombreValido(this string nombre)
        {
            Regex regex = new Regex("^[a-zA-Z ]+$");
            return regex.IsMatch(nombre);
        }

    }
}
