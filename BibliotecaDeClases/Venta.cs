using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BibliotecaDeClases
{
    public class Venta : ISerializa<Venta>
    {
        public string clienteCompra;
        public List<Producto> productosVendidos;

        public Venta()
        {
        }
        public Venta(List<Producto> productosVendidos, string clienteCompra)
        {
            this.productosVendidos = productosVendidos;
            this.clienteCompra = clienteCompra;
        }
        public Venta(string nombreProducto, string tipoDeAnimal, double precioPorKilo, int cantidadSeleccionada, string clienteCompra)
        {
            this.NombreProducto = nombreProducto;
            this.TipoDeAnimal = tipoDeAnimal;
            this.PrecioPorKilo = precioPorKilo;
            this.CantidadSeleccionada = cantidadSeleccionada;
            this.clienteCompra = clienteCompra;

            // Inicializar la lista de productos vendidos
            this.productosVendidos = new List<Producto>();
        }

        public List<Producto> ProductosVendidos
        {
            get { return productosVendidos; }
            set { this.productosVendidos = value; }
        }        

        public string ObtenerClienteCompra
        {
            get { return clienteCompra; }
            set { this.clienteCompra = value; }
        }

        public string NombreProducto { get ; set ; }
        public string? TipoDeAnimal { get; set ; }
        public double PrecioPorKilo { get ; set; }
        public int CantidadSeleccionada { get ; set ; }

        public void SerializarJson(List<Venta> listaASerializar)
        {
            using (StreamWriter sw = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\historialJson.json"))
            {
                string jsonString = JsonSerializer.Serialize(listaASerializar);
                sw.WriteLine(jsonString);
            }
        }

        public void SerializarXml(List<Venta> listaASerializar)
        {
            using (StreamWriter streamWriter = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\historialXml.xml"))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Venta>));
                xmlSerializer.Serialize(streamWriter, listaASerializar);
            }
        }

        public string DeserializarJson()
        {
            using (StreamReader streamReader = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\historialJson.json"))
            {
                string jsonString = streamReader.ReadToEnd();
                List<Venta> historial = JsonSerializer.Deserialize<List<Venta>>(jsonString) as List<Venta>;
                StringBuilder sb = new StringBuilder();

                foreach (Venta item in historial)
                {
                    sb.AppendLine($"----------{item.NombreProducto}----------");
                    sb.AppendLine($"Cantidad Seleccionada: {item.CantidadSeleccionada}");
                    sb.AppendLine($"Precio por Kilo: {item.PrecioPorKilo}");
                    sb.AppendLine($"Tipo de corte: {item.TipoDeAnimal}");
                    sb.AppendLine($"Cliente: {item.ObtenerClienteCompra}");
                    sb.AppendLine("");
                }
                return sb.ToString();
            }
        }

    }
}
