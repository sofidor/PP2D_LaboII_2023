using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Venta
    {
        public string clienteCompra;        
        public List<Producto> productosVendidos;
       
        public Venta(List<Producto> productosVendidos, string clienteCompra)
        {
            this.productosVendidos = productosVendidos;
            this.clienteCompra = clienteCompra;
        }

        public List<Producto> ProductosVendidos
        {
            get { return productosVendidos; }
            set { this.productosVendidos = value; }
        }
      
        public string ObtenerClienteCompra
        {
            get { return clienteCompra; }
            set { this.clienteCompra = value; }
        }


    }
}
