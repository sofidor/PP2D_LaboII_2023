﻿using BibliotecaDeClases;
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
        List<Venta> ventas = new List<Venta>();
        public FrmVenta()
        {
            InitializeComponent();
            this.listaDeProductos = Carniceria.ObtenerProductos();
            this.MaximizeBox = false; //que no pueda maximizarse
            this.MinimizeBox = false; //que no pueda minimizarse 
            this.FormBorderStyle = FormBorderStyle.FixedDialog; //que no pueda agrandarse desde los lados  

            this.FormClosing += new FormClosingEventHandler(FrmVenta_FormClosing);//cerrar form desde la cruz
            dgvProductos.CellBeginEdit += new DataGridViewCellCancelEventHandler(dgvProductos_CellBeginEdit); //editar la celda cantidad
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
            // Inicializar el ComboBox con las opciones 
            cmbFormaDePago.Items.Add("Tarjeta de crédito");
            cmbFormaDePago.Items.Add("Tarjeta de debito");
            cmbFormaDePago.Items.Add("Mercado pago");
            cmbFormaDePago.Items.Add("Efectivo");

            // Establecer una opción seleccionada por defecto
            cmbFormaDePago.SelectedIndex = 3;

            cmbTipoDeCorte.Items.Add("vaca");
            cmbTipoDeCorte.Items.Add("cerdo");
            cmbTipoDeCorte.Items.Add("pollo");
            cmbTipoDeCorte.Items.Add("mostrar todo");

            cmbTipoDeCorte.SelectedIndex = 0;

            CargarDataGridView(Carniceria.ObtenerProductos());
        }

        private void dgvProductos_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            // Obtener la columna actual
            DataGridViewColumn column = dgvProductos.Columns[e.ColumnIndex];

            // Verificar si la columna es la columna "cantidad"
            if (column.Name == "Cantidad")
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
        private double CalcularMontoTotal()
        {
            double montoTotal = 0;
            foreach (Producto producto in productosSeleccionados)
            {
                montoTotal += producto.PrecioPorKilo * producto.CantidadSeleccionada;
            }
            return montoTotal;
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            double montoTotal = CalcularMontoTotal();
            DialogResult confirmarVenta;

            // Obtener el monto máximo ingresado por el cliente
            if (!double.TryParse(txtPresupuesoMaximo.Text, out double montoMaximo))
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

                    // Actualizar el objeto Producto en la lista
                    producto.CantidadSeleccionada = cantidadSeleccionada;
                    producto.StockDisponible -= cantidadSeleccionada;

                    // Actualizar la celda de StockDisponible en el DataGridView
                    DataGridViewCell stockCell = row.Cells["StockDisponible"];
                    stockCell.Value = producto.StockDisponible;
                }

                // Verificar que el precio total no supere el monto máximo ingresado por el cliente
                if (montoTotal > montoMaximo) //(double)
                {
                    MessageBox.Show("El precio total de los productos seleccionados supera el monto máximo ingresado por el cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Verificar si se eligió la opción "Tarjeta de crédito"
                if (cmbFormaDePago.SelectedItem.ToString() == "Tarjeta de crédito")
                {
                    // Calcular el recargo del 5%
                    double recargo = montoTotal * 0.05;
                    montoTotal += recargo;
                }
                // Crear un nuevo objeto Venta para el producto vendido y agregarlo a la lista de ventas
                Venta venta = new Venta(productosSeleccionados);
                Carniceria.CargarVenta(venta);
                              
                // Mostrar la factura
                FrmFacturaCliente facturaForm = new FrmFacturaCliente(productosSeleccionados, montoTotal);
                facturaForm.Show();
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
            List<Producto> productosFiltrados = Carniceria.BuscarPorTipoCorte(tipoCorte);

            dgvProductos.Rows.Clear();
            // Asignar la lista temporal al DataGridView para mostrar los productos filtrados
            CargarDataGridView(productosFiltrados);

            // Si la opción seleccionada es "mostrar todo", cargar la lista original y salir del método
            if (cmbTipoDeCorte.SelectedItem.ToString() == "mostrar todo")
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