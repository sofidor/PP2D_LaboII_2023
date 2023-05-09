using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public enum eMetodoPago //lo pueden utilizar diferentes clases 
    {
        TarjetaDeCredito,
        Efectivo,
        MercadoPago,
        TarjetaDebito
    }

    public class Cliente : Usuario
    {
        private string nombreCompleto;
        private double montoDisponible;
        private eMetodoPago metodoDePago;

        public Cliente(string mailUsuario, string contraseñaUsuario, string nombreCompleto, double montoDisponible , eMetodoPago metodoDePago)
             : base(mailUsuario, contraseñaUsuario)
        {
            this.nombreCompleto = nombreCompleto;
            this.montoDisponible = montoDisponible;
            this.metodoDePago = metodoDePago;
        }
        public string NombreCompleto
        {
            get { return nombreCompleto; }
        }
        public double MontoDisponible
        {
            get { return montoDisponible; }

            set 
            {
                if (montoDisponible > 0)
                {
                    montoDisponible = value;
                }
                else 
                {
                    montoDisponible = 0;
                }
            }
        }
        public eMetodoPago MetodoDePago
        {
            get { return metodoDePago; }
        }
        /// <summary>
        /// valida si un nombre contiene solo letras
        /// </summary>
        /// <param name="nombre">nombre que se valida</param>
        /// <returns>retorna true si el nombre cumple o false si no lo hace</returns>
        public static bool ValidarNombre(string nombre)
        {            
            Regex regex = new Regex("^[a-zA-Z]+$");            
            return regex.IsMatch(nombre);
        }
    }
}

