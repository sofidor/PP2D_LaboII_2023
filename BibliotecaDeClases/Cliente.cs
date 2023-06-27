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
        private string metodoPago;

        public Cliente(string mailUsuario, string contraseñaUsuario, string nombreCompleto, double montoDisponible , eMetodoPago metodoDePago)
             : base(mailUsuario, contraseñaUsuario)
        {
            this.nombreCompleto = nombreCompleto;
            this.montoDisponible = montoDisponible;
            this.metodoDePago = metodoDePago;
        }

        public Cliente(string mailUsuario, string contraseñaUsuario, string nombreCompleto, double montoDisponible, string metodoPago)
     : base(mailUsuario, contraseñaUsuario)
        {
            this.nombreCompleto = nombreCompleto;
            this.montoDisponible = montoDisponible;
            this.metodoPago = metodoPago;
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

        public string  MetodoPago
        {
            get { return metodoPago; }
        }

        public override string ToString()
        {
            return $"Mail: {NombreCompleto}, pass: {ContraseñaUsuario}, nombre: {NombreCompleto}, monto: {MontoDisponible}, metodo pago: {MetodoPago}";
        }
    }
}

