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
        private string nombreCliente;
        public FrmFactura(List<Producto> productosSeleccionados, double montoTotal, string nombreCliente)
        {
            InitializeComponent();
            this.productosSeleccionados = productosSeleccionados;
            this.montoTotal = montoTotal;
            CargarDataGridView(productosSeleccionados);

            this.MaximizeBox = false; //que no pueda maximizarse
            this.MinimizeBox = false; //que no pueda minimizarse 
            this.FormBorderStyle = FormBorderStyle.FixedDialog; //que no pueda agrandarse desde los lados       
            this.nombreCliente = nombreCliente;
        }

        public void CargarDataGridView(List<Producto> listaDeProductos)
        {
            foreach (Producto producto in listaDeProductos)
            {
                dgvProductos.Rows.Add(producto.NombreProducto, producto.TipoDeAnimal, producto.PrecioPorKilo, producto.cantidadSeleccionada);
            }
        }

        private void FrmFactura_Load(object sender, EventArgs e)
        {
            // Mostrar el cliente seleccionado
            if (lbCliente != null)
            {
                lbCliente.Text = nombreCliente;
            }           

            // Mostrar el monto total
            lbTotal.Text = "Monto total: $" + montoTotal.ToString("0.00");

            // Obtener la fecha actual del sistema
            DateTime fechaActual = DateTime.Now;

            // Asignar la fecha al texto del label
            lbFechaActual.Text = fechaActual.ToString("dd/MM/yyyy");
        }
    }
}
