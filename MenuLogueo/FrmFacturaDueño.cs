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
    public partial class FrmFacturaDueño : Form
    {
        private Cliente clienteSeleccionado;
        List<Producto> productosSeleccionadosDueño;

        public FrmFacturaDueño(List<Producto> productosSeleccionadosDueño, Cliente clienteSeleccionado)
        {
            InitializeComponent();
            this.productosSeleccionadosDueño = productosSeleccionadosDueño;
            this.clienteSeleccionado = clienteSeleccionado;
            CargarDataGridView(productosSeleccionadosDueño);

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

        private void FrmFacturaDueño_Load(object sender, EventArgs e)
        {
            // Mostrar el cliente seleccionado
            if (clienteSeleccionado != null)
            {
                lbClienteSeleccionado.Text = clienteSeleccionado.NombreCompleto;
            }
        }
    }
}
