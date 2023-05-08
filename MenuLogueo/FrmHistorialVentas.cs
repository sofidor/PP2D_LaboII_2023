using BibliotecaDeClases;
using System;
using System.Collections;
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
    public partial class FrmHistorialVentas : Form
    {
        public List<Venta> ventasRealizadas = new List<Venta>();
        public FrmHistorialVentas(List<Venta> ventasRealizadas)
        {
            InitializeComponent();
            this.ventasRealizadas = ventasRealizadas;
            CargarDataGridView(ventasRealizadas);

            this.FormClosing += new FormClosingEventHandler(FrmHistorialVentas_FormClosing);//cerrar form desde la cruz
        }

        private void CargarDataGridView(List<Venta> ventasRealizadas)
        {
            // Limpiar el DataGridView
            dgvProductos.Rows.Clear();

            // Obtener la lista de ventas
            List<Venta> listaVentas = Carniceria.ObtenerVentas();

            // Recorrer la lista de ventas y agregar los productos al DataGridView
            foreach (Venta venta in listaVentas)
            {
                foreach (Producto producto in venta.ProductosVendidos)
                {
                    dgvProductos.Rows.Add(
                        producto.NombreProducto,
                        producto.TipoDeAnimal,
                        producto.PrecioPorKilo,
                        producto.CantidadSeleccionada,
                        venta.clienteCompra
                    );
                }
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FrmVenderProducto venderProducto = new();
            venderProducto.Show();
            this.Hide();
        }

        private void FrmHistorialVentas_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (e.CloseReason == CloseReason.UserClosing)
            {
                // El usuario hizo clic en la cruz, cerrar la aplicación
                e.Cancel = false; // Permitir el cierre
                Application.Exit(); // Cerrar la aplicación
            }
        }

    }
}
