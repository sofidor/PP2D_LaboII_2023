using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaDeClases;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace MenuLogueo
{
    public partial class FrmAbrirHeladera : Form
    {
        int posicion;
        List<Producto> listaDeProductos;
        public FrmAbrirHeladera()
        {
            InitializeComponent();
            limpiar();
            this.listaDeProductos = Carniceria.ObtenerProductos();
            this.MaximizeBox = false; //que no pueda maximizarse
            this.MinimizeBox = false; //que no pueda minimizarse 
            this.FormBorderStyle = FormBorderStyle.FixedDialog; //que no pueda agrandarse desde los lados           
            this.FormClosing += new FormClosingEventHandler(FrmAbrirHeladera_FormClosing);//cerrar form desde la cruz
        }

        public void CargarDataGridView(List<Producto> listaDeProductos)
        {
            foreach (Producto producto in listaDeProductos)
            {
                dgvProductos.Rows.Add(producto.NombreProducto, producto.TipoDeAnimal, producto.StockDisponible, producto.PrecioPorKilo, 0);
            }
        }

        private void FrmHeladera_Load(object sender, EventArgs e)
        {
            CargarDataGridView(Carniceria.ObtenerProductos());
        }

        private void limpiar()
        {
            txtProducto.Text = "";
            txtPrecio.Text = "";
            txtDetalle.Text = "";
            txtStock.Text = "";
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dgvProductos_CellClick_1(object sender, DataGridViewCellEventArgs e) //muestra detalles
        {
            // Obtener el índice de la fila seleccionada
            int index = e.RowIndex;

            // Si se ha seleccionado una fila
            if (index >= 0)
            {
                // Obtener los valores de las celdas y asignarlos a los TextBox correspondientes
                DataGridViewRow selectedRow = dgvProductos.Rows[index];

                // Si la celda seleccionada está vacía
                if (selectedRow.Cells[0].Value == null)
                {
                    // Habilitar los campos para ingresar un nuevo producto
                    txtProducto.Enabled = true;
                    txtDetalle.Enabled = true;
                    txtPrecio.Enabled = true;
                    txtStock.Enabled = true;

                    // Limpiar los campos de texto
                    txtProducto.Clear();
                    txtDetalle.Clear();
                    txtPrecio.Clear();
                    txtStock.Clear();

                    // Deshabilitar el botón de modificar
                    btnModificar.Enabled = false;
                    btnAgregar.Enabled = true;

                }
                else // Si la celda seleccionada contiene datos
                {
                    txtProducto.Text = selectedRow.Cells[0].Value.ToString();
                    txtDetalle.Text = selectedRow.Cells[1].Value.ToString();
                    txtStock.Text = selectedRow.Cells[2].Value.ToString();
                    txtPrecio.Text = selectedRow.Cells[3].Value.ToString();

                    // Guardar la posición de la fila seleccionada
                    posicion = index;

                    // Habilitar el botón de modificar
                    btnModificar.Enabled = true;

                    btnAgregar.Enabled = false;

                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            // Obtener los nuevos valores de los controles de edición
            string nuevoNombre = txtProducto.Text;
            string nuvoTipo = txtDetalle.Text;
            double nuevoPrecio = double.Parse(txtPrecio.Text);
            int nuevoStock = int.Parse(txtStock.Text);

            // Obtener la fila seleccionada y el índice correspondiente
            DataGridViewRow filaSeleccionada = dgvProductos.CurrentRow;
            int indiceFilaSeleccionada = filaSeleccionada.Index;

            // Actualizar los datos del producto en la lista
            Producto productoSeleccionado = listaDeProductos[indiceFilaSeleccionada];
            productoSeleccionado.NombreProducto = nuevoNombre;
            productoSeleccionado.TipoDeAnimal = nuvoTipo;
            productoSeleccionado.PrecioPorKilo = nuevoPrecio;
            productoSeleccionado.StockDisponible = nuevoStock;

            // Actualizar los datos en el DataGridView
            filaSeleccionada.Cells["nombreProducto"].Value = nuevoNombre;
            filaSeleccionada.Cells["tipoDeAnimal"].Value = nuvoTipo;
            filaSeleccionada.Cells["precioPorKilo"].Value = nuevoPrecio;
            filaSeleccionada.Cells["stockDisponible"].Value = nuevoStock;

            // Limpiar los controles de edición
            limpiar();

            // Deseleccionar la fila
            dgvProductos.ClearSelection();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string producto, tipo, stock, valor;

            producto = txtProducto.Text;
            tipo = txtDetalle.Text;
            stock = txtStock.Text;
            valor = txtPrecio.Text;

            if (!string.IsNullOrEmpty(producto) && !string.IsNullOrEmpty(tipo) && !string.IsNullOrEmpty(stock) && !string.IsNullOrEmpty(valor))
            {
                // Agregar el nuevo producto a la lista de productos
                Carniceria.AgregarProducto(producto, tipo, int.Parse(stock), double.Parse(valor), 0);

                // Agregar la nueva fila con el índice y los demás datos
                dgvProductos.Rows.Add(producto, tipo, stock, valor);
                limpiar();
                txtProducto.Focus();

                btnModificar.Enabled = false;

                // Deseleccionar la fila
                dgvProductos.ClearSelection();
            }
            else
            {
                MessageBox.Show("Por favor ingrese todos los valores requeridos");
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Obtener el índice de la fila seleccionada
            int indiceFilaSeleccionada = dgvProductos.CurrentRow.Index;

            // Eliminar el producto correspondiente de la lista de productos
            Carniceria.EliminarProducto(indiceFilaSeleccionada);

            // Eliminar la fila correspondiente del DataGridView
            dgvProductos.Rows.RemoveAt(indiceFilaSeleccionada);

            // Limpiar los controles de edición
            limpiar();

            // Deseleccionar la fila
            dgvProductos.ClearSelection();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FrmHeladera heladeraForm = new FrmHeladera();
            heladeraForm.Show();
            this.Hide();
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmAbrirHeladera_FormClosing(object sender, FormClosingEventArgs e)
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
