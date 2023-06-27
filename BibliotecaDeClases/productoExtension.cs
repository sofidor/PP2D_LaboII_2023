using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public static class productoExtension
    {
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

        public static bool TieneSuficienteStock(this Producto producto, int cantidadDeseada)
        {
            return producto.StockDisponible >= cantidadDeseada;
        }
    }
}
