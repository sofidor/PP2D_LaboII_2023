using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public static class ProductosDAO
    {
        static string connectionstring;
        static SqlCommand command;
        static SqlConnection connection;
        
        static ProductosDAO()
        {
            connectionstring = @"Data Source= SOFIDOR;Initial Catalog=Parcial2_UTN;Integrated Security=True;";
            command = new SqlCommand();
            connection = new SqlConnection(connectionstring);
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;
        }

        public static List<Producto> Leer()
        {
            List<Producto> productos = new List<Producto>();
            try {

                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Productos", connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["id"]);
                    string nombreProducto = reader["nombreProducto"].ToString();
                    string tipoDeAnimal = reader["tipoDeAnimal"].ToString();
                    double precioPorKilo = Convert.ToDouble(reader["precioPorKilo"]);
                    int stockDisponible = Convert.ToInt32(reader["stockDisponible"]);                    

                    productos.Add(new Producto(id, nombreProducto, tipoDeAnimal, stockDisponible, precioPorKilo));
                }

                return productos;
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
        public static void Modificar(Producto nuevoProducto)
        {
            try
            {
                command.Parameters.Clear(); // Limpiar parámetros
                connection.Open();
                command.CommandText = "UPDATE Productos SET nombreProducto = @nombreProducto, tipoDeAnimal = @tipoDeAnimal, stockDisponible = @stockDisponible, precioPorKilo = @precioPorKilo WHERE id = @id"; // Consulta parametrizada

                command.Parameters.AddWithValue("@nombreProducto", nuevoProducto.NombreProducto);
                command.Parameters.AddWithValue("@tipoDeAnimal", nuevoProducto.TipoDeAnimal);
                command.Parameters.AddWithValue("@stockDisponible", nuevoProducto.StockDisponible);
                command.Parameters.AddWithValue("@precioPorKilo", nuevoProducto.PrecioPorKilo);
                // command.Parameters.AddWithValue("@cantidadSeleccionada", nuevoProducto.CantidadSeleccionada);
                command.Parameters.AddWithValue("@id", nuevoProducto.Id);
                command.ExecuteNonQuery();
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
        public static void Eliminar(int id)
        {
            try
            {
                connection.Open();
                command.CommandText = "DELETE FROM Productos WHERE id = @id"; // Consulta parametrizada
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();

                // Eliminar el producto de la listaDeProductos
               Producto productoEliminado = Carniceria.ObtenerProductos().Find(p => p.Id == id);
               Carniceria.ObtenerProductos().Remove(productoEliminado);
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
        public static void Guardar(Producto producto)
        {
            try
            {
                connection.Open();
                command.Parameters.Clear(); // Limpiar parámetros   
                command.CommandText = "INSERT INTO Productos (nombreProducto, tipoDeAnimal, stockDisponible, precioPorKilo) VALUES (@nombreProducto, @tipoDeAnimal, @stockDisponible, @precioPorKilo); SELECT SCOPE_IDENTITY();"; // Consulta parametrizada

                command.Parameters.AddWithValue("@nombreProducto", producto.NombreProducto);
                command.Parameters.AddWithValue("@tipoDeAnimal", producto.TipoDeAnimal);
                command.Parameters.AddWithValue("@stockDisponible", producto.StockDisponible);
                command.Parameters.AddWithValue("@precioPorKilo", producto.PrecioPorKilo);

                // Ejecutar la consulta y obtener el nuevo id asignado por la base de datos
                int newId = Convert.ToInt32(command.ExecuteScalar());

                // Asignar el nuevo id al objeto producto
                producto.Id = newId;
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
        public static void ActualizarStockEnBaseDeDatos(Producto producto)
        {
            try
            {
                connection.Open();
                command.Parameters.Clear(); // Limpiar parámetros
                command.CommandText = "UPDATE Productos SET stockDisponible = @stockDisponible WHERE id = @id"; // Consulta parametrizada

                command.Parameters.AddWithValue("@stockDisponible", producto.StockDisponible);
                command.Parameters.AddWithValue("@id", producto.Id);

                command.ExecuteNonQuery();

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

