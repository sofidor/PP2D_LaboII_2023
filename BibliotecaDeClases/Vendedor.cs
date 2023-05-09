using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Vendedor : Usuario
    {
        public string nombreVendedor;
        public double montoMaximo;

        public Vendedor(string mailUsuario, string contraseñaUsuario, string nombreVendedor)
        : base(mailUsuario, contraseñaUsuario)
        {
            this.nombreVendedor = nombreVendedor;
        }            

        public string NombreVendedor
        {            
            get {return nombreVendedor; }
        }      
    }
}
