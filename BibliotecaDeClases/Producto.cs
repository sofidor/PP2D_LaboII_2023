namespace BibliotecaDeClases
{   
    public class Producto
    {
        private string nombreProducto;
        private string tipoDeAnimal;
        private double precioPorKilo;
        private int stockDisponible;
        private int cantidadSeleccionada;

        public Producto(string nombreProducto, string tipoDeAnimal, int stockDisponible, double precioPorKilo, int cantidadSeleccionada)
        {
            this.nombreProducto = nombreProducto;
            this.tipoDeAnimal = tipoDeAnimal;           
            this.stockDisponible = stockDisponible;
            this.precioPorKilo = precioPorKilo;
            this.cantidadSeleccionada = 0;
        }

        public Producto(string nombreProducto, string tipoDeAnimal, double precioPorKilo, int cantidadSeleccionada)
        {
            this.nombreProducto = nombreProducto;
            this.tipoDeAnimal = tipoDeAnimal;          
            this.precioPorKilo = precioPorKilo;
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

    }
}