using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public static class Carniceria
    {       
        private static List<Producto> listaDeProductos = new List<Producto>();
        private static List<Venta> listaVentas = new List<Venta>(); // Inicializar lista de ventas
        private static List<Cliente> listaDeClientes = new List<Cliente>();

        static Carniceria()
        {                  
            CargarProductos();
            CargarClientes();
        }
        /// <summary>
        /// carga productos a la lista de productos
        /// </summary>
        private static void CargarProductos()
        {
            listaDeProductos.Add(new Producto("Carne picada", "vaca", 0, 2300,0));
            listaDeProductos.Add(new Producto("Milanesas", "pollo", 50, 1300, 0));
            listaDeProductos.Add(new Producto("Milanesas", "vaca", 50, 1300, 0));
            listaDeProductos.Add(new Producto("Chuletas", "cerdo", 75, 2300, 0));
            listaDeProductos.Add(new Producto("Bistec", "vaca", 150, 3000, 0));
            listaDeProductos.Add(new Producto("Chorizo", "cerdo", 50, 1500, 0));
            listaDeProductos.Add(new Producto("Alitas de pollo", "pollo", 60, 1100, 0));
            listaDeProductos.Add(new Producto("Costillas", "cerdo", 100, 2500, 0));
            listaDeProductos.Add(new Producto("Solomillo", "vaca", 200, 4000, 0));
            listaDeProductos.Add(new Producto("Muslos de pollo", "pollo", 70, 1200, 0));
            listaDeProductos.Add(new Producto("Salchichón", "cerdo", 30, 1000, 0));
            listaDeProductos.Add(new Producto("Medallones", "vaca", 30, 1000, 0));
            listaDeProductos.Add(new Producto("Lomo", "vaca", 30, 1000, 0));
            listaDeProductos.Add(new Producto("Cuadrada", "vaca", 30, 1000, 0));
            listaDeProductos.Add(new Producto("Pechito", "cerdo", 30, 1000, 0));
            listaDeProductos.Add(new Producto("Medallones", "pollo", 60, 1100, 0));
        }
        /// <summary>
        /// carga clientes a la lista de clientes
        /// </summary>
        public static void CargarClientes()
        {
            listaDeClientes.Add(new Cliente("lionelMartinez@gmail.com","abc123","Lionel Martinez", 85000, eMetodoPago.MercadoPago));
            listaDeClientes.Add(new Cliente("daniFernandez@gmail.com","dfg234","Daniela Fernandez", 160000, eMetodoPago.Efectivo));
            listaDeClientes.Add(new Cliente("juanigomez@gmail.com","hij456","Juan Ignacio Gomez", 35000, eMetodoPago.TarjetaDeCredito));
            listaDeClientes.Add(new Cliente("jazSerna@gmail.com","klm6789","Jazmin Serna", 85000, eMetodoPago.TarjetaDeCredito));
        }
        /// <summary>
        /// obtiene la lista de productos
        /// </summary>
        /// <returns>la lista de productos</returns>
        public static List<Producto> ObtenerProductos()
        {
            return listaDeProductos;
        }
        /// <summary>
        /// obtiene la lista de clientes
        /// </summary>
        /// <returns>lista de clientes</returns>
        public static List<Cliente> ObtenerClientes()
        {
            return listaDeClientes;
        }
        /// <summary>
        /// agrega un producto nuevo a la lista de productos
        /// </summary>
        /// <param name="nombre">nombre del producto</param>
        /// <param name="tipo">tipo de corte del producto</param>
        /// <param name="stock">stock disponible del producto</param>
        /// <param name="precio">precio por kilo del producto</param>
        /// <param name="cantidadSeleccionada">cantidad a comprar del producto</param>
        public static void AgregarProducto(string nombre, string tipo, int stock, double precio,int cantidadSeleccionada)
        {
            listaDeProductos.Add(new Producto(nombre, tipo, stock, precio, cantidadSeleccionada));
        }
        public static void EliminarProducto(int indice)
        {
            listaDeProductos.RemoveAt(indice);
        }
        /// <summary>
        /// Filtra la lista de los productos segun el tipo de animal , y la retorna
        /// </summary>
        /// <param name="tipoDeAnimal">Tipo de animal </param>
        /// <returns>la lista que coincide con el tipo de animal</returns>
        public static List<Producto> BuscarPorTipoCorte(string tipoDeAnimal)
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
      /// <summary>
      /// obtiene la lista de ventas
      /// </summary>
      /// <returns>lista de ventas</returns>
        public static List<Venta> ObtenerVentas()
        {
            return listaVentas;
        }       
        /// <summary>
        /// agrega una venta a la lista de ventas
        /// </summary>
        /// <param name="venta">venta a agregar</param>
        public static void CargarVenta(Venta venta)
        {
            listaVentas.Add(venta);
        }      

    }
}