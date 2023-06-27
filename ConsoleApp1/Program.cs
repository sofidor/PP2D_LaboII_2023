using BibliotecaDeClases;
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Cliente> clientes = UsuarioDAO.Leer();
           
            foreach (Cliente cliente in clientes)
            {
                Console.WriteLine(cliente.ToString());
            }
        }
    }
}