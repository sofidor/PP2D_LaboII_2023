using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public static class historialVentasDAO
    {
        static string connectionstring;
        static SqlCommand command;
        static SqlConnection connection;

        //ADO
        static historialVentasDAO()
        {
            connectionstring = @"Data Source= SOFIDOR;Initial Catalog=Parcial2_UTN;Integrated Security=True;";
            command = new SqlCommand();
            connection = new SqlConnection(connectionstring);
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;
        }

        public static List<Venta> LeerVentas()
        {
            List<Venta> historial = new List<Venta>();
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM historialDeVentas", connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
;
                    string clienteCompra = reader["Cliente"].ToString();
                    string nombreProducto = reader["nombreProducto"].ToString();
                    string tipoDeAnimal = reader["tipoDeAnimal"].ToString();
                    double precioPorKilo = Convert.ToDouble(reader["precioPorKilo"]);
                    int cantidadSeleccionada = Convert.ToInt32(reader["cantidadSeleccionada"]);

                    historial.Add(new Venta(nombreProducto, tipoDeAnimal,precioPorKilo,cantidadSeleccionada,clienteCompra));
                }

                return historial;
            }
            catch (Exception)
            {
                throw new Exception("Error de conexión a la base de datos");
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
        public static void insertarVentas(List<Venta> ventas)
        {
            try
            {
                connection.Open();

                foreach (Venta venta in ventas)
                {
                    foreach (Producto producto in venta.ProductosVendidos)
                    {
                        command.Parameters.Clear();
                        command.CommandText = "INSERT INTO historialDeVentas (nombreProducto, tipoDeAnimal, precioPorKilo, cantidadSeleccionada, Cliente) VALUES (@Nombre, @Tipo, @Precio, @Cantidad, @Cliente)";

                        command.Parameters.AddWithValue("@Nombre", producto.NombreProducto);
                        command.Parameters.AddWithValue("@Tipo", producto.TipoDeAnimal);
                        command.Parameters.AddWithValue("@Precio", producto.PrecioPorKilo);
                        command.Parameters.AddWithValue("@Cantidad", producto.CantidadSeleccionada);
                        command.Parameters.AddWithValue("@Cliente", venta.ObtenerClienteCompra);

                        command.ExecuteNonQuery();                        
                    }

                }
            }
            catch (Exception)
            {
                throw new Exception("Error de conexión a la base de datos");
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
    }
}
