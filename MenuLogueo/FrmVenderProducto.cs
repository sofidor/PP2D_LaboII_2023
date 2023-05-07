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
using static BibliotecaDeClases.Producto;

namespace MenuLogueo
{
    public partial class FrmVenderProducto : Form
    {
        List<Producto> productosSeleccionados = new List<Producto>();
        List<Producto> listaDeProductos;
        List<Venta> ventas = new List<Venta>();
        public FrmVenderProducto()
        {
            InitializeComponent();
            
            this.MaximizeBox = false; //que no pueda maximizarse
            this.MinimizeBox = false; //que no pueda minimizarse 
            this.FormBorderStyle = FormBorderStyle.FixedDialog; //que no pueda agrandarse desde los lados      
            this.FormClosing += new FormClosingEventHandler(FrmVenderProducto_FormClosing);//cerrar form desde la cruz
            dgvProductos.CellBeginEdit += new DataGridViewCellCancelEventHandler(dgvProductos_CellBeginEdit);            
        }

        public void CargarDataGridView(List<Producto> listaDeProductos)
        {
            foreach (Producto producto in listaDeProductos)
            {
                dgvProductos.Rows.Add(producto.NombreProducto, producto.TipoDeAnimal, producto.StockDisponible, producto.PrecioPorKilo, 0);
            }
        }

        private void FrmVenderProducto_Load(object sender, EventArgs e)
        {
            // Obtener la lista de clientes
            List<Cliente> clientes = Carniceria.ObtenerClientes();

            // Agregar los nombres de los clientes al ComboBox
            foreach (Cliente cliente in clientes)
            {
                cbClientes.Items.Add(cliente.NombreCompleto);
            }

            CargarDataGridView(Carniceria.ObtenerProductos());
        }


        private void btnVolver_Click_1(object sender, EventArgs e)
        {
            FrmHeladera heladeraForm = new FrmHeladera();
            heladeraForm.Show();
            this.Hide();
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvProductos.Rows[e.RowIndex];

            // obtener el producto seleccionado
            Producto producto = new Producto(
                 row.Cells["nombreProducto"].Value.ToString(),
                 row.Cells["tipoDeAnimal"].Value.ToString(),
                 Convert.ToInt32(row.Cells["stockDisponible"].Value),
                 Convert.ToDouble(row.Cells["precioPorKilo"].Value),
                   Convert.ToInt32(row.Cells["cantidad"].Value)
             );

            // agregar o eliminar el producto seleccionado o deseleccionado de la lista
            if (row.Selected)
            {
                productosSeleccionados.Add(producto);

            }
            else
            {
                productosSeleccionados.Remove(producto);
            }

            // Actualizar la cantidad seleccionada del producto
            producto.CantidadSeleccionada = Convert.ToInt32(row.Cells["cantidad"].Value);
        }     

        private void btnVender_Click(object sender, EventArgs e)
        {
            DialogResult confirmarVenta;           
            List<Producto> productosVendidos = new List<Producto>(); // Crear una nueva lista para almacenar los productos vendidos
            List<Cliente> clienteAux = new List<Cliente>();

            // Verificar que se ha seleccionado un cliente
            if (cbClientes.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Obtener el cliente seleccionado
            string cliente = cbClientes.SelectedItem.ToString();

            // Verificar que se han seleccionado productos para la venta
            if (productosSeleccionados.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione al menos un producto para la venta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }          

            // Mostrar mensaje de confirmación
            confirmarVenta = MessageBox.Show("¿Desea confirmar la compra?", "Confirmar compra", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmarVenta == DialogResult.Yes) {
                // Disminuir el stock de los productos seleccionados
                foreach (DataGridViewRow row in dgvProductos.SelectedRows)
                {
                    int rowIndex = row.Index;
                    Producto producto = Carniceria.ObtenerProductos()[rowIndex];

                    // Verificar si hay suficiente stock disponible
                    if (producto.StockDisponible == 0)
                    {
                        MessageBox.Show("No hay suficiente stock del producto seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Verificar si se intenta comprar más cantidad de la disponible en stock
                    int cantidadSeleccionada = Convert.ToInt32(row.Cells["Cantidad"].Value);
                    if (cantidadSeleccionada > producto.StockDisponible)
                    {
                        MessageBox.Show("No hay suficiente stock del producto seleccionado para la cantidad deseada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    // Verificar si la cantidad seleccionada es mayor a cero
                    if (cantidadSeleccionada <= 0)
                    {
                        MessageBox.Show("La cantidad seleccionada del producto debe ser mayor a cero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Actualizar el objeto Producto en la lista
                    producto.CantidadSeleccionada = cantidadSeleccionada;
                    producto.StockDisponible -= cantidadSeleccionada;

                    // Actualizar la celda de StockDisponible en el DataGridView
                    DataGridViewCell stockCell = row.Cells["StockDisponible"];
                    stockCell.Value = producto.StockDisponible;

                    // Agregar el producto a la lista de productos comprados
                    productosVendidos.Add(producto);
                }
               
                // Crear un nuevo objeto Venta para el producto vendido y agregarlo a la lista de ventas
                Venta venta = new Venta(productosVendidos);
                Carniceria.CargarVenta(venta);
                // Generar el recibo y mostrarlo en una ventana nueva

                // Obtener el cliente seleccionado del ComboBox
                string clienteSeleccionado = cbClientes.SelectedItem.ToString();

                // Crear una instancia del formulario FrmFacturaDueño y pasar el cliente seleccionado
                FrmFacturaDueño frmFacturaDueño = new FrmFacturaDueño(productosVendidos, clienteSeleccionado);
                frmFacturaDueño.Show();
            }
            else
            {
                MessageBox.Show("Operación cancelada.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }         
        }

        private void dgvProductos_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            // Obtener la columna actual
            DataGridViewColumn column = dgvProductos.Columns[e.ColumnIndex];

            // Verificar si la columna es la columna "cantidad"
            if (column.Name == "cantidad")
            {
                // Permitir la edición de la celda "cantidad"
                e.Cancel = false;
            }
            else
            {
                // Cancelar la edición de cualquier otra celda
                e.Cancel = true;
            }
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            FrmHistorialVentas recibo = new FrmHistorialVentas(ventas);
            recibo.Show();
            this.Hide();
        }

        private void FrmVenderProducto_FormClosing(object sender, FormClosingEventArgs e)
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
