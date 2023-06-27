using System.Text;
using System.Text.Json;
using System.Xml.Serialization;

namespace BibliotecaDeClases
{   
    public class Producto : ISerializa<Producto>, IDeserializa
    {
        private int id;
        private string nombreProducto;
        private string tipoDeAnimal;
        private double precioPorKilo;
        private int stockDisponible;
        private int cantidadSeleccionada;

        public Producto()
        {
        }

        public Producto(int id,string nombreProducto, string tipoDeAnimal, int stockDisponible, double precioPorKilo) :this(nombreProducto,tipoDeAnimal,stockDisponible,precioPorKilo)
        {
            this.id = id;
        }

        public Producto(string nombreProducto, string tipoDeAnimal, int stockDisponible, double precioPorKilo)
        {
            this.nombreProducto = nombreProducto;
            this.tipoDeAnimal = tipoDeAnimal;           
            this.stockDisponible = stockDisponible;
            this.precioPorKilo = precioPorKilo;
            this.cantidadSeleccionada = 0;
        }

        public Producto(string nombreProducto, string tipoDeAnimal, int stockDisponible, double precioPorKilo, int cantidadSeleccionada)
        {
            this.nombreProducto = nombreProducto;
            this.tipoDeAnimal = tipoDeAnimal;
            this.stockDisponible = stockDisponible;
            this.precioPorKilo = precioPorKilo;
            this.cantidadSeleccionada = 0;
        }

        public Producto(string nombreProducto, string tipoDeAnimal,double precioPorKilo, int cantidadSeleccionada)
        {
            this.nombreProducto = nombreProducto;
            this.tipoDeAnimal = tipoDeAnimal;            
            this.precioPorKilo = precioPorKilo;
            this.cantidadSeleccionada = 0;
        }

        public Producto(string nombreProducto, string tipoDeAnimal, decimal precioPorKilo1, int cantidadSeleccionada)
        {
            this.nombreProducto = nombreProducto;
            this.tipoDeAnimal = tipoDeAnimal;
            this.cantidadSeleccionada = cantidadSeleccionada;
        }

        public string NombreProducto
        {
            get { return this.nombreProducto; }
            set { this.nombreProducto = value; }
        }
        public string TipoDeAnimal
        {
            get { return this.tipoDeAnimal; }
            set { this.tipoDeAnimal = value; }
        }

        public double PrecioPorKilo
        {
            get { return this.precioPorKilo; }
            set { this.precioPorKilo = value; }
        }
        public int StockDisponible
        {
            get { return this.stockDisponible; }
            set { this.stockDisponible = value; }
        }

        public int CantidadSeleccionada
        {
            get { return this.cantidadSeleccionada; }
            set { this.cantidadSeleccionada = value; }
        }

        public int Id { get => id; set => id = value; }

        public void SerializarJson(List<Producto> listaASerializar)
        {
            using (StreamWriter sw = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\productosJson.json"))
            {
                string jsonString = JsonSerializer.Serialize(listaASerializar);
                sw.WriteLine(jsonString);
            }
        }

        public void SerializarXml(List<Producto> listaASerializar)
        {
            using (StreamWriter streamWriter = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\productosXml.xml"))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Producto>));
                xmlSerializer.Serialize(streamWriter, listaASerializar);
            }
        }

        public string DeserializarJson()
        {
            using (StreamReader streamReader = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\productosJson.json"))
            {
                string jsonString = streamReader.ReadToEnd();
                List<Producto> productos = JsonSerializer.Deserialize<List<Producto>>(jsonString) as List<Producto>;
                StringBuilder sb = new StringBuilder();

                foreach (Producto item in productos) 
                {
                    sb.AppendLine($"----------{item.NombreProducto}----------");
                    sb.AppendLine($"Id: {item.Id}");
                    sb.AppendLine($"Precio por Kilo: {item.PrecioPorKilo}");
                    sb.AppendLine($"Tipo de corte: {item.TipoDeAnimal}");
                    sb.AppendLine($"Stock disponible: {item.StockDisponible}");
                    sb.AppendLine("");
                }
                return sb.ToString();
             }
        }

        public string DeserializarXml()
        {
            using (StreamReader streamReader = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\productosXml.xml"))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Producto>));
                List<Producto> productos = xmlSerializer.Deserialize(streamReader) as List<Producto>;
                StringBuilder sb = new StringBuilder();

                foreach (Producto item in productos)
                {
                    sb.AppendLine($"----------{item.NombreProducto}----------");
                    sb.AppendLine($"Id: {item.Id}");
                    sb.AppendLine($"Precio por Kilo: {item.PrecioPorKilo}");
                    sb.AppendLine($"Tipo de corte: {item.TipoDeAnimal}");
                    sb.AppendLine($"Stock disponible: {item.StockDisponible}");
                    sb.AppendLine("");
                }

                return sb.ToString();

            }
        }

        public override string ToString()
        {
            return $"Nombre del producto: {nombreProducto}, Tipo de animal: {tipoDeAnimal}, Stock disponible: {stockDisponible}, Precio por kilo: {precioPorKilo}, Cantidad seleccionada: {cantidadSeleccionada}";
        }

    }
}