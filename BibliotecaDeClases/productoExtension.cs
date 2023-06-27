using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public static class productoExtension
    {
        /// <summary>
        /// Filtra la lista de los productos segun el tipo de animal , y la retorna
        /// </summary>
        /// <param name="tipoDeAnimal">Tipo de animal </param>
        /// <returns>la lista que coincide con el tipo de animal</returns>
        public static List<Producto> BuscarPorTipoCorte(this List<Producto> listaDeProductos, string tipoDeAnimal)
        {
            List<Producto> lista = new List<Producto>();

            foreach (Producto item in listaDeProductos)
            {
                if (item.TipoDeAnimal.Equals(tipoDeAnimal))
                {
                    lista.Add(item);
                }
            }
            return lista;
        }

    }
}
