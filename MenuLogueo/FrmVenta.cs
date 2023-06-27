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
    public partial class FrmVenta : Form
    {
        List<Producto> productosSeleccionados = new List<Producto>();
        List<Producto> listaDeProductos;        
        private string nombreCliente;

        public FrmVenta(string nombreCliente)
        {
            InitializeComponent();
            listaDeProductos = Carniceria.ObtenerProductos();
            CargarDataGridView(listaDeProductos);
            this.MaximizeBox = false; //que no pueda maximizarse
            this.MinimizeBox = false; //que no pueda minimizarse 
            this.FormBorderStyle = FormBorderStyle.FixedDialog; //que no pueda agrandarse desde los lados
            this.FormClosing += new FormClosingEventHandler(FrmVenta_FormClosing);//cerrar form desde la cruz
            dgvProductos.CellBeginEdit += new DataGridViewCellCancelEventHandler(dgvProductos_CellBeginEdit); //editar la celda cantidad
            dgvProductos.CellValidating += new DataGridViewCellValidatingEventHandler(dgvProductos_CellValidating);
            this.nombreCliente = nombreCliente;
            txtNombreCliente.Text = nombreCliente;
        }

        public void CargarDataGridView(List<Producto> listaDeProductos)
        {
            foreach (Producto producto in listaDeProductos)
            {
                dgvProductos.Rows.Add(producto.NombreProducto, producto.TipoDeAnimal, producto.StockDisponible, producto.PrecioPorKilo, 0);
            }
        }

        private void FrmVenta_Load(object sender, EventArgs e)
        {
            cmbFormaDePago.Items.Add("Tarjeta de crédito");
            cmbFormaDePago.Items.Add("Tarjeta de debito");
            cmbFormaDePago.Items.Add("Mercado pago");
            cmbFormaDePago.Items.Add("Efectivo");

            cmbFormaDePago.SelectedIndex = 3;// Establecer una opción seleccionada por defecto

            cmbTipoDeCorte.Items.Add("vaca");
            cmbTipoDeCorte.Items.Add("cerdo");
            cmbTipoDeCorte.Items.Add("pollo");
            cmbTipoDeCorte.Items.Add("Mostrar todo");

            cmbTipoDeCorte.SelectedIndex = 3;
        }

        private void dgvProductos_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            DataGridViewColumn column = dgvProductos.Columns[e.ColumnIndex];//obtener la columna actual

            if (column.Name == "Cantidad")
            {
                e.Cancel = false; // Permitir la edición de la celda "cantidad"
            }
            else
            {
                e.Cancel = true;// Cancelar la edición de cualquier otra celda
            }
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // asegurarse de que se haga clic en una fila valida
            {
                DataGridViewRow row = this.dgvProductos.Rows[e.RowIndex];
                // obtener el producto seleccionado
                Producto producto = new Producto(
                     row.Cells["nombreProducto"].Value.ToString(),
                     row.Cells["tipoDeAnimal"].Value.ToString(),
                     Convert.ToInt32(row.Cells["stockDisponible"].Value),
                     Convert.ToDouble(row.Cells["precioPorKilo"].Value),
                     Convert.ToInt32(row.Cells["Cantidad"].Value)
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
                producto.CantidadSeleccionada = Convert.ToInt32(row.Cells["Cantidad"].Value);
            }
        }
        //calcula el total de la compra
        private double CalcularMontoTotal()
        {
            double montoTotal = 0;
            foreach (DataGridViewRow row in dgvProductos.Rows)
            {
                bool isSelected = row.Selected;
                int cantidadSeleccionada = Convert.ToInt32(row.Cells["Cantidad"].Value);
                double precioPorKilo = Convert.ToDouble(row.Cells["PrecioPorKilo"].Value);

                if (isSelected && cantidadSeleccionada > 0)
                {
                    montoTotal += precioPorKilo * cantidadSeleccionada;
                }
            }
            return montoTotal;
        }
        private void dgvProductos_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (dgvProductos.Columns[e.ColumnIndex].Name == "Cantidad")
            {
                string cantidad = e.FormattedValue.ToString();
                int cantidadSeleccionada;

                if (!int.TryParse(cantidad, out cantidadSeleccionada) || cantidadSeleccionada < 0)
                {
                    MessageBox.Show("La cantidad seleccionada debe ser un número entero mayor a cero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }
            }
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            double montoTotal = CalcularMontoTotal();
            string nombrecliente = txtNombreCliente.Text;
            string metodoDePago = cmbFormaDePago.SelectedItem.ToString();
            double montoFinal = montoTotal; //por defecto inicia en monto total
            DialogResult confirmarVenta;
            List<Producto> productosComprados = new List<Producto>();  // Crear una nueva lista para almacenar los productos comprados

            if (!Cliente.ValidarNombre(nombrecliente))
            {
                MessageBox.Show("Por favor, ingrese un nombre válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Obtener el monto máximo ingresado por el cliente
            if (!double.TryParse(txtMontoIngresado.Text, out double montoMaximo))
            {
                MessageBox.Show("Por favor, ingrese un valor numérico válido para el monto máximo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verificar que haya al menos un producto seleccionado
            if (productosSeleccionados.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione al menos un producto antes de continuar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Mostrar mensaje de confirmación
            confirmarVenta = MessageBox.Show("¿Desea confirmar la compra?", "Confirmar compra", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmarVenta == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dgvProductos.SelectedRows) //recorro todas las filas seleccionadas
                {
                    int rowIndex = row.Index;
                    Producto producto = Carniceria.ObtenerProductos()[rowIndex];//obtengo los productos de esa fila

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

                    // Verificar que el precio total no supere el monto máximo ingresado por el cliente
                    if (montoTotal > montoMaximo)
                    {
                        MessageBox.Show("El precio total de los productos seleccionados supera el monto máximo ingresado por el cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Actualizar la cantidad seleccionada del producto
                    producto.CantidadSeleccionada = cantidadSeleccionada;
                    producto.StockDisponible -= cantidadSeleccionada;// Restar la cantidad seleccionada del stock disponible

                    // Actualizar la celda de StockDisponible en el DataGridView
                    DataGridViewCell stockCell = row.Cells["StockDisponible"];
                    stockCell.Value = producto.StockDisponible;

                    ProductosDAO.ActualizarStockEnBaseDeDatos(producto);

                    // Agregar el producto a la lista de productos comprados
                   productosComprados.Add(producto);
                }

                // Restarle el monto gastado
                double nuevoMontoMaximo = montoMaximo - montoTotal;

                // Actualizar el campo con el nuevo valor
                txtMontoIngresado.Text = nuevoMontoMaximo.ToString();

                // Verificar si se eligió la opción "Tarjeta de crédito"
                if (cmbFormaDePago.SelectedItem.ToString() == "Tarjeta de crédito")
                {
                    // Calcular el recargo del 5%
                    double recargo = montoTotal * 0.05;
                    montoTotal += recargo;

                }                

                // Mostrar la factura
                FrmFactura facturaForm = new FrmFactura(productosComprados, montoTotal, montoFinal, nombrecliente, metodoDePago, "La moderna");
                facturaForm.Show();

                // Crear un nuevo objeto Venta para el producto vendido y agregarlo a la lista de ventas
                Venta venta = new Venta(productosComprados, nombrecliente);
                Carniceria.CargarVenta(venta);

                Carniceria.CargarDBHistorial();

            }
            else
            {
                MessageBox.Show("Operación cancelada.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FrmLogueo logueo = new FrmLogueo();
            logueo.Show();
            this.Hide();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Obtener el tipo de corte seleccionado en el ComboBox
            string tipoCorte = cmbTipoDeCorte.SelectedItem.ToString();

            // Filtrar los productos por tipo de corte utilizando el método BuscarPorTipoCorte
            List<Producto> productosFiltrados = listaDeProductos.BuscarPorTipoCorte(tipoCorte);

            dgvProductos.Rows.Clear();
            // Asignar la lista temporal al DataGridView para mostrar los productos filtrados
            CargarDataGridView(productosFiltrados);

            // Si la opción seleccionada es "mostrar todo", cargar la lista original y salir del método
            if (cmbTipoDeCorte.SelectedItem.ToString() == "Mostrar todo")
            {
                CargarDataGridView(listaDeProductos);
                return;
            }
        }

        private void FrmVenta_FormClosing(object sender, FormClosingEventArgs e)
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
