using BibliotecaDeClases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuLogueo
{
    public partial class FrmFactura : Form
    {
        List<Producto> productosSeleccionados;
        private double montoTotal;
        private double montoTotalFinal;
        private string nombreCliente;
        private string metodoDePago;
        private string nombreVendedor;

        public FrmFactura(List<Producto> productosSeleccionados, double montoTotal, double montoTotalFinal, string nombreCliente, string metodoDePago, string nombreVendedor)
        {
            InitializeComponent();
            this.productosSeleccionados = productosSeleccionados;
            this.montoTotal = montoTotal;
            this.nombreCliente = nombreCliente;
            this.metodoDePago = metodoDePago;
            this.montoTotalFinal = montoTotalFinal;
            this.nombreVendedor = nombreVendedor;
            CargarDataGridView(productosSeleccionados);

            this.MaximizeBox = false; //que no pueda maximizarse
            this.MinimizeBox = false; //que no pueda minimizarse 
            this.FormBorderStyle = FormBorderStyle.FixedDialog; //que no pueda agrandarse desde los lados      

        }

        public void CargarDataGridView(List<Producto> listaDeProductos)
        {
            foreach (Producto producto in listaDeProductos)
            {
                dgvProductos.Rows.Add(producto.NombreProducto, producto.TipoDeAnimal, producto.PrecioPorKilo, producto.CantidadSeleccionada);
            }
        }

        private void FrmFactura_Load(object sender, EventArgs e)
        {
            lbCliente.Text = nombreCliente;
            lbVendedor.Text = nombreVendedor;
            lbFormaDePago.Text = metodoDePago;
            lbTotalFinal.Text = "Total Final: $" + montoTotal.ToString("0.00");
            lbTotal.Text = "Total: $" + montoTotalFinal.ToString("0.00");

            // Obtener la fecha actual del sistema
            DateTime fechaActual = DateTime.Now;
            lbFechaActual.Text = fechaActual.ToString("dd/MM/yyyy");
        }
    }
}
