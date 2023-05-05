using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Vendedor : Usuario
    {        
        private List<Producto> productos;
        private double montoMaximo;

        public Vendedor(string mailUsuario, string contraseñaUsuario, List<Producto> productos, double montoMaximo)
        : base(mailUsuario, contraseñaUsuario)
        {
            this.productos = productos;
            this.montoMaximo = montoMaximo;
        }

        // Propiedades
        public List<Producto> Productos
        {
            get { return productos; }
            set { productos = value; }
        }

        public double MontoMaximo
        {
            get { return montoMaximo; }
            set { montoMaximo = value; }
        }

      
    }
}
