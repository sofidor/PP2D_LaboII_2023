using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaDeClases;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace MenuLogueo
{
    public partial class FrmAbrirHeladera : Form
    {
        int posicion; //almacena la posicion de la fila selec
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

        public void CargarDataGridView()
        {            
            dgvProductos.Rows.Clear();
            // Obtener los datos actualizados de la base de datos
            List<Producto> listaDeProductos = Carniceria.ObtenerProductos();
            
            foreach (Producto producto in listaDeProductos)
            {
                dgvProductos.Rows.Add(producto.Id, producto.NombreProducto, producto.TipoDeAnimal, producto.StockDisponible, producto.PrecioPorKilo);
            }
        }
        private void FrmAbrirHeladera_Load(object sender, EventArgs e)
        {
            CargarDataGridView();
            btnDeserializarJson.Enabled = false;
            btnDeserializarXml.Enabled = false;
        }

        private void limpiar()//limpio los campos
        {
            txtProducto.Text = "";
            txtPrecio.Text = "";
            txtDetalle.Text = "";
            txtStock.Text = "";
        }
        private void dgvProductos_CellClick_1(object sender, DataGridViewCellEventArgs e) //muestra detalles
        {
            int index = e.RowIndex;//obtener el índice de la fila seleccionada

            if (index >= 0)
            {
                //obtener los valores de las celdas y asignarlos a los TextBox correspondientes
                DataGridViewRow selectedRow = dgvProductos.Rows[index];

                //si la celda seleccionada está vacía
                if (selectedRow.Cells[0].Value == null)
                {
                    //habilitar los campos para ingresar un nuevo producto
                    txtProducto.Enabled = true;
                    txtDetalle.Enabled = true;
                    txtPrecio.Enabled = true;
                    txtStock.Enabled = true;

                    limpiar();// limpiar los campos de texto

                    btnModificar.Enabled = false; 
                    btnAgregar.Enabled = true;

                }
                else //si la celda seleccionada contiene datos
                {
                    txtProducto.Text = selectedRow.Cells[1].Value.ToString();
                    txtDetalle.Text = selectedRow.Cells[2].Value.ToString();
                    txtStock.Text = selectedRow.Cells[3].Value.ToString();
                    txtPrecio.Text = selectedRow.Cells[4].Value.ToString();

                    posicion = index;//guardar la posición de la fila seleccionada

                    btnModificar.Enabled = true;
                    btnAgregar.Enabled = false;
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {            
            string nuevoNombre = txtProducto.Text;
            string nuevoTipo = txtDetalle.Text;
            double nuevoPrecio = double.Parse(txtPrecio.Text);
            int nuevoStock = int.Parse(txtStock.Text);

            // Obtener la fila seleccionada y el índice correspondiente
            DataGridViewRow filaSeleccionada = dgvProductos.CurrentRow;
            int indiceFilaSeleccionada = filaSeleccionada.Index;

            try
            {               
                DialogResult resultado = MessageBox.Show("¿Desea modificar el producto?", "Confirmar modificación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    // Actualizar los datos del producto en la lista
                    Producto productoSeleccionado = listaDeProductos[indiceFilaSeleccionada];
                    productoSeleccionado.NombreProducto = nuevoNombre;
                    productoSeleccionado.TipoDeAnimal = nuevoTipo;
                    productoSeleccionado.PrecioPorKilo = nuevoPrecio;
                    productoSeleccionado.StockDisponible = nuevoStock;

                    // Llamar al método Modificar de ProductosDAO para actualizar el producto en la base de datos
                    ProductosDAO.Modificar(productoSeleccionado);
                    
                    limpiar();
                    dgvProductos.ClearSelection();

                    MessageBox.Show("El producto ha sido modificado con éxito.", "Modificación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Volver a cargar los datos del SQL en el Data                   
                    CargarDataGridView();
                }
                else
                {
                    MessageBox.Show("Operación cancelada.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string producto = txtProducto.Text;
            string tipo = txtDetalle.Text;
            string stock = txtStock.Text;
            string valor = txtPrecio.Text;

            if (!string.IsNullOrEmpty(producto) && !string.IsNullOrEmpty(tipo) && !string.IsNullOrEmpty(stock) && !string.IsNullOrEmpty(valor))
            {
                if (!EsString(producto))
                {
                    MessageBox.Show("Error en el valor ingresado en el campo Producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!string.Equals(tipo, "pollo", StringComparison.OrdinalIgnoreCase) &&
                 !string.Equals(tipo, "vaca", StringComparison.OrdinalIgnoreCase) &&
                 !string.Equals(tipo, "cerdo", StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Error en el valor ingresado en el campo Tipo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int stockInt;
                if (!int.TryParse(stock, out stockInt))
                {
                    MessageBox.Show("Error en el valor ingresado en el campo Stock", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                float valorFloat;
                if (!float.TryParse(valor, out valorFloat))
                {
                    MessageBox.Show("Error en el valor ingresado en el campo Valor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Crear un nuevo objeto Producto con los datos ingresados
                Producto nuevoProducto = new Producto(producto, tipo, stockInt, valorFloat);

                try
                {                   
                    DialogResult resultado = MessageBox.Show("¿Desea crear el producto?", "Confirmar creación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resultado == DialogResult.Yes)
                    {
                        // Llamar al método Guardar para insertar el nuevo producto en la base de datos
                        ProductosDAO.Guardar(nuevoProducto);

                        // Agregar el nuevo producto a la lista actualizada
                        listaDeProductos.Add(nuevoProducto);
                        limpiar();
                        txtProducto.Focus();

                        btnModificar.Enabled = false;
                        dgvProductos.ClearSelection(); 

                        MessageBox.Show("El producto ha sido agregado con éxito.", "Creación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Volver a cargar los datos del SQL en el Data                        
                        CargarDataGridView();
                    }
                    else
                    {
                        MessageBox.Show("Operación cancelada.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar el producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese todos los valores requeridos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {           
            DataGridViewRow filaSeleccionada = dgvProductos.CurrentRow;

            if (filaSeleccionada != null)
            {
                // Obtener el nombre del producto en la fila seleccionada (asumiendo que está en la segunda columna)               
                int idProducto = Convert.ToInt32(filaSeleccionada.Cells[0].Value);

                try
                {                    
                    DialogResult resultado = MessageBox.Show("¿Desea eliminar el producto?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resultado == DialogResult.Yes)
                    {
                        // Eliminar el producto de la base de datos por nombre
                        ProductosDAO.Eliminar(idProducto);                        
                        limpiar();
                        dgvProductos.ClearSelection();

                        MessageBox.Show("El producto ha sido eliminado con éxito.", "Eliminación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Volver a cargar los datos del SQL en el DataGridView
                        CargarDataGridView();
                    }
                    else
                    {
                        MessageBox.Show("Operación cancelada.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        /// <summary>
        ///  Verifica si el valor es de tipo string y contiene solo letras
        /// </summary>
        /// <param name="valor"></param>
        /// <returns></returns>
        private bool EsString(string valor)
        {            
            return !string.IsNullOrEmpty(valor) && Regex.IsMatch(valor, @"^[a-zA-Z]+$");
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FrmHeladera heladeraForm = new FrmHeladera();
            heladeraForm.Show();
            this.Hide();
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

        private void btnSerializarJson_Click(object sender, EventArgs e)
        {
            List<Producto> listaDeProductos = Carniceria.ObtenerProductos();
            Producto serializer = new Producto();
            serializer.SerializarJson(listaDeProductos);
            btnDeserializarJson.Enabled = true;
            MessageBox.Show("La lista de productos se ha serializado correctamente.", "Serialización exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSerializarXml_Click(object sender, EventArgs e)
        {
            List<Producto> listaDeProductos = Carniceria.ObtenerProductos();
            Producto serializer = new Producto();
            serializer.SerializarXml(listaDeProductos);
            btnDeserializarXml.Enabled = true;
            MessageBox.Show("La lista de productos se ha serializado correctamente.", "Serialización exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDeserializarJson_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();
            string productosDeserializados = producto.DeserializarJson();

            FrmDeserializacionJson formSecundario = new FrmDeserializacionJson();
            formSecundario.MostrarDatos(productosDeserializados);
            formSecundario.Show();
        }

        private void btnDeserializarXml_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();
            string productosDeserializados = producto.DeserializarXml();

            FrmDeserializarXml formSecundario = new FrmDeserializarXml();
            formSecundario.MostrarDatos(productosDeserializados);
            formSecundario.Show();
        }
    }
}
