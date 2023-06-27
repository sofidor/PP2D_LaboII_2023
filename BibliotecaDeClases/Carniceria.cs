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
        private static List<Venta> listaVentas = new List<Venta>(); 
        private static List<Cliente> listaDeClientes = new List<Cliente>();
        private static List<Vendedor> listaDeVendedores = new List<Vendedor>();    

        static Carniceria()
        {                  
            CargarProductos(); //inicializo las listas
            CargarClientes();
            CargarVendedores();           
        }
        /// <summary>
        /// carga productos a la lista de productos
        /// </summary>
        private static void CargarProductos()
        {
            // Obtener la lista de productos
            listaDeProductos = ProductosDAO.Leer();          
        }
        /// <summary>
        /// carga clientes a la lista de clientes
        /// </summary>
        public static void CargarClientes()
        {
            listaDeClientes = UsuarioDAO.LeerCliente();
        }
        /// <summary>
        /// carga los vendedores a la lista de vendedores
        /// </summary>
        public static void CargarVendedores() 
        {
            listaDeVendedores = UsuarioDAO.LeerVendedor();
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
        /// agrega una venta a la lista de ventas
        /// </summary>
        /// <param name="venta">venta a agregar</param>
        public static void CargarVenta(Venta venta)
        {
            listaVentas.Clear();
            listaVentas.Add(venta);
        }
      
        /// <summary>
        /// carga el historial de ventas a la lista de ventas
        /// </summary>
        public static void CargarHistorial()
        {
            historialVentasDAO.insertarVentas(listaVentas);
        }

    }
}