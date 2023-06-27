using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public abstract class Usuario //la clase "Usuario" es abstracta y no se puede instanciar directamente,
                                  //sino que debe ser heredada por otras clases que definan sus propios atributos y métodos.
    {
        private string mailUsuario;
        private string contraseñaUsuario;

        protected Usuario(string mailUsuario, string contraseñaUsuario)
        {
            this.mailUsuario = mailUsuario;
            this.contraseñaUsuario = contraseñaUsuario;
        }
        public string MailUsuario { get => mailUsuario; set => mailUsuario = value; }
        public string ContraseñaUsuario { get => contraseñaUsuario; set => contraseñaUsuario = value; }
    }
}
