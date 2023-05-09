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
        protected string mailUsuario;
        protected string contraseñaUsuario;

        protected Usuario(string nombreUsuario, string contraseñaUsuario)
        {
            this.mailUsuario = nombreUsuario;
            this.contraseñaUsuario = contraseñaUsuario;
        }

        public string NombreUsuario
        {
            get { return this.mailUsuario; }
        }
    }
}
