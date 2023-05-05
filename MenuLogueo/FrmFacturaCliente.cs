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
    public partial class FrmFacturaCliente : Form
    {
        List<Producto> productosSeleccionados;
        private double montoTotal;
        public FrmFacturaCliente(List<Producto> productosSeleccionados, double montoTotal)
        {
            InitializeComponent();
            this.productosSeleccionados = productosSeleccionados;
            this.montoTotal = montoTotal;
            CargarDataGridView(productosSeleccionados);

            this.MaximizeBox = false; //que no pueda maximizarse
            this.MinimizeBox = false; //que no pueda minimizarse 
            this.FormBorderStyle = FormBorderStyle.FixedDialog; //que no pueda agrandarse desde los lados       
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
            // Mostrar el monto total
            lbTotal.Text = "Monto total: $" + montoTotal.ToString("0.00");
        }
    }
}
