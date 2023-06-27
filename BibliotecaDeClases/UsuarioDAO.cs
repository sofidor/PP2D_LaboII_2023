using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public static class UsuarioDAO
    {
        static string connectionstring;
        static SqlCommand command;
        static SqlConnection connection;
        static UsuarioDAO() 
        {
            connectionstring = @"Data Source= SOFIDOR;Initial Catalog=Parcial2_UTN;Integrated Security=True;";
            command = new SqlCommand();
            connection = new SqlConnection(connectionstring);
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;
        }

        public static List<Cliente> LeerCliente()
        {
            List<Cliente> clientes = new List<Cliente>();
            try
            {

                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Clientes", connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string mailUsuario = reader["mailUsuario"].ToString();
                    string contraseñaUsuario = reader["contraseñaUsuario"].ToString();
                    string nombreCompleto = reader["nombreCompleto"].ToString();
                    double montoDisponible = Convert.ToDouble(reader["montoDisponible"]);
                    string metodoDePago = reader["metodoDePago"].ToString();                  

                    clientes.Add(new Cliente(mailUsuario, contraseñaUsuario, nombreCompleto, montoDisponible, metodoDePago));
                }

                return clientes;
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
        public static List<Vendedor> LeerVendedor()
        {
            List<Vendedor> vendedores = new List<Vendedor>();
            try
            {

                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Vendedores", connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string mailUsuario = reader["mailUsuario"].ToString();
                    string contraseñaUsuario = reader["contraseñaUsuario"].ToString();
                    string nombreVendedor = reader["nombreVendedor"].ToString();

                    vendedores.Add(new Vendedor(mailUsuario, contraseñaUsuario, nombreVendedor));
                }

                return vendedores;
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
        public static bool VerificarCredencialesCliente(string correo, string contrasena)
        {
            try
            {
                connection.Open();

                SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM Clientes WHERE mailUsuario = @Correo AND contraseñaUsuario = @Contraseña", connection);
                command.Parameters.AddWithValue("@Correo", correo);
                command.Parameters.AddWithValue("@Contraseña", contrasena);

                int count = Convert.ToInt32(command.ExecuteScalar());

                return count > 0;
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
        public static bool VerificarCredencialesVendedor(string correo, string contrasena)
        {
            try
            {
                connection.Open();

                SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM Vendedores WHERE mailUsuario = @Correo AND contraseñaUsuario = @Contraseña", connection);
                command.Parameters.AddWithValue("@Correo", correo);
                command.Parameters.AddWithValue("@Contraseña", contrasena);

                int count = Convert.ToInt32(command.ExecuteScalar());

                return count > 0;
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
        public static void ActualizarMontoDisponible(Cliente cliente)
        {
            try
            {
                connection.Open();

                SqlCommand command = new SqlCommand("UPDATE Clientes SET montoDisponible = @montoDisponible WHERE mailUsuario = @mailUsuario", connection);
                command.Parameters.AddWithValue("@montoDisponible", cliente.MontoDisponible);
                command.Parameters.AddWithValue("@mailUsuario", cliente.MailUsuario);

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
        public static string ObtenerNombreCliente(string mailUsuario)
        {
            try
            {
                connection.Open();

                string nombreCliente = null;

                SqlCommand command = new SqlCommand("SELECT nombreCompleto FROM Clientes WHERE mailUsuario = @mailUsuario", connection);               
                command.Parameters.AddWithValue("@mailUsuario", mailUsuario);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        nombreCliente = reader.GetString(0);
                    }
                }

                return nombreCliente;
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
        public static string ObtenerNombreVendedor(string mailVendedor)
        {
            try
            {
                connection.Open();

                string nombreVendedor = null;

                SqlCommand command = new SqlCommand("SELECT nombreVendedor FROM Vendedores WHERE mailUsuario = @mail", connection);
                command.Parameters.AddWithValue("@mail", mailVendedor);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        nombreVendedor = reader.GetString(0);
                    }
                }

                return nombreVendedor;
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
