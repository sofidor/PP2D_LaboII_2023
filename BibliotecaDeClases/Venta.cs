using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Venta
    {
        private List<Producto> productosVendidos;

        public Venta(List<Producto> productosVendidos)
        {
            this.productosVendidos = productosVendidos;
        }
      

        public List<Producto> ProductosVendidos
        {
            get { return productosVendidos; }
            set { this.productosVendidos = value; }
        }


    }
}
