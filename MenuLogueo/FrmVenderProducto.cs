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
    public delegate void SinStockEventHandler();// lo utilizo para representar mi evento

    public partial class FrmVenderProducto : Form
    {
        List<Producto> productosSeleccionados = new List<Producto>();
        List<Producto> listaDeProductos;
        List<Venta> ventas = new List<Venta>();

        public event SinStockEventHandler SinStockEvent;

        public FrmVenderProducto()
        {
            InitializeComponent();
            this.MaximizeBox = false; //que no pueda maximizarse
            this.MinimizeBox = false; //que no pueda minimizarse 
            this.FormBorderStyle = FormBorderStyle.FixedDialog; //que no pueda agrandarse desde los lados      
            this.FormClosing += new FormClosingEventHandler(FrmVenderProducto_FormClosing);//cerrar form desde la cruz
            dgvProductos.CellBeginEdit += new DataGridViewCellCancelEventHandler(dgvProductos_CellBeginEdit);
            cbClientes.SelectedIndexChanged += new EventHandler(cbClientes_SelectedIndexChanged);
            dgvProductos.CellValidating += new DataGridViewCellValidatingEventHandler(dgvProductos_CellValidating);

            SinStockEvent += MostrarMensajeSinStock;
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
            List<Cliente> clientes = Carniceria.ObtenerClientes();

            foreach (Cliente cliente in clientes)
            {
                cbClientes.Items.Add(cliente.NombreCompleto); //agregar clientes al comboBox
            }

            cbClientes.SelectedIndex = 3;

            // Obtener el cliente seleccionado
            Cliente clienteSeleccionado = Carniceria.ObtenerClientes()[cbClientes.SelectedIndex];

            // Mostrar el monto disponible en el TextBox
            txtMontoCliente.Text = clienteSeleccionado.MontoDisponible.ToString();
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
            if (e.RowIndex >= 0) // asegurarse de que se haga clic en una fila valida
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
        }

        private void cbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbClientes.SelectedIndex >= 0)
            {
                // Obtener el cliente seleccionado
                Cliente clienteSeleccionado = Carniceria.ObtenerClientes()[cbClientes.SelectedIndex];

                // Mostrar el monto disponible en el TextBox
                txtMontoCliente.Text = clienteSeleccionado.MontoDisponible.ToString();
            }
        }

        private double CalcularMontoTotal()
        {
            double montoTotal = 0;
            foreach (DataGridViewRow row in dgvProductos.Rows)
            {
                bool isSelected = row.Selected;
                int cantidadSeleccionada = Convert.ToInt32(row.Cells["cantidad"].Value);
                double precioPorKilo = Convert.ToDouble(row.Cells["PrecioPorKilo"].Value);

                if (isSelected && cantidadSeleccionada > 0)
                {
                    montoTotal += precioPorKilo * cantidadSeleccionada;
                }
            }
            return montoTotal;
        }

        private void MostrarMensajeSinStock()
        {
            MessageBox.Show("No hay stock del producto seleccionado.", "Stock agotado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void dgvProductos_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (dgvProductos.Columns[e.ColumnIndex].Name == "cantidad")
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

        private void btnVender_Click(object sender, EventArgs e)
        {
            DialogResult confirmarVenta;
            Vendedor vendedor = new Vendedor("sergioLopez@gmail.com", "clave123", "Sergio Lopéz");
            List<Producto> productosVendidos = new List<Producto>(); // Crear una nueva lista para almacenar los productos vendidos
            Cliente clienteSeleccionado = Carniceria.ObtenerClientes()[cbClientes.SelectedIndex];// retorna el cliente q le hago clic con todos sus datos                                                                                                
            string clienteSeleccionadoNombre = cbClientes.SelectedItem.ToString();
            string montoCliente = clienteSeleccionado.MontoDisponible.ToString();
            string metodoPago = clienteSeleccionado.MetodoDePago.ToString();
            double precioTotal = CalcularMontoTotal();
            double precioFinal = precioTotal;

            // Verificar que se ha seleccionado un cliente
            if (cbClientes.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verificar que se han seleccionado productos para la venta
            if (productosSeleccionados.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione al menos un producto para la venta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Mostrar mensaje de confirmación
            confirmarVenta = MessageBox.Show("¿Desea confirmar la compra?", "Confirmar compra", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmarVenta == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dgvProductos.SelectedRows)//recorro todas las filas seleccionadas
                {
                    int rowIndex = row.Index;
                    Producto producto = Carniceria.ObtenerProductos()[rowIndex];//obtengo los productos de esa fila

                    if (producto.StockDisponible == 0)
                    {
                        // Invocar el evento SinStockEvent
                        SinStockEvent?.Invoke();
                        return;
                    }

                    // Verificar si se intenta comprar más cantidad de la disponible en stock
                    int cantidadSeleccionada = Convert.ToInt32(row.Cells["cantidad"].Value);
                    producto.CantidadSeleccionada = cantidadSeleccionada; // Asignar la cantidad seleccionada al producto
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
                    // Verificar si el valor total supera el monto a gastar del cliente
                    if (precioTotal > clienteSeleccionado.MontoDisponible)
                    {
                        MessageBox.Show("El valor total de los productos seleccionados supera el monto a gastar del cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    producto.StockDisponible -= cantidadSeleccionada;

                    // Actualizar la celda de StockDisponible en el DataGridView
                    DataGridViewCell stockCell = row.Cells["StockDisponible"];
                    stockCell.Value = producto.StockDisponible;

                    ProductosDAO.ActualizarStockEnBaseDeDatos(producto);

                    // Agregar el producto a la lista de productos vendidos
                    productosVendidos.Add(producto);
                }
                // Restarle el monto gastado
                double nuevoMontoMaximo = clienteSeleccionado.MontoDisponible - precioTotal;
                txtMontoCliente.Text = nuevoMontoMaximo.ToString();

                // Actualizar el monto disponible del cliente en la base de datos
                clienteSeleccionado.MontoDisponible = nuevoMontoMaximo;
                UsuarioDAO.ActualizarMontoDisponible(clienteSeleccionado);


                // Verificar si el cliente tiene el tipo de pago "TarjetaDeCredito"
                if (clienteSeleccionado.MetodoDePago == eMetodoPago.TarjetaDeCredito)
                {
                    // Calcular el aumento del 5% al monto total
                    double aumento = precioTotal * 0.05;
                    precioTotal += aumento;
                }

                // Crear un nuevo objeto Venta para el producto vendido y agregarlo a la lista de ventas
                Venta venta = new Venta(productosVendidos, clienteSeleccionadoNombre);
                Carniceria.CargarVenta(venta);

                //Carniceria.cargarHistorialVentas();

                // Crear una instancia del formulario FrmFacturaDueño y pasar el cliente seleccionado
                FrmFactura frmFacturaDueño = new FrmFactura(productosVendidos, precioTotal, precioFinal, clienteSeleccionadoNombre, metodoPago, vendedor.nombreVendedor);
                frmFacturaDueño.Show();
                Carniceria.CargarHistorial();
            }
            else
            {
                MessageBox.Show("Operación cancelada.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvProductos_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            DataGridViewColumn column = dgvProductos.Columns[e.ColumnIndex]; //obtengo columna

            if (column.Name == "cantidad")
            {
                e.Cancel = false;//permitir la edición de la celda "cantidad"
            }
            else
            {
                e.Cancel = true;//cancelar la edición de cualquier otra celda
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
                //si el usuario hizo clic en la cruz, cerrar la aplicación
                e.Cancel = false;
                Application.Exit();
            }
        }

    }
}
