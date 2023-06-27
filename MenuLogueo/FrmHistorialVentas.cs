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
            ventasRealizadas = historialVentasDAO.LeerVentas();
            this.ventasRealizadas = ventasRealizadas;
            CargarDataGridView(ventasRealizadas);
            this.FormClosing += new FormClosingEventHandler(FrmHistorialVentas_FormClosing);//cerrar form desde la cruz
        }

        private void FrmHistorialVentas_Load(object sender, EventArgs e)
        {
            ;
            btnDeserializarJson.Enabled = false;
        }
        private void CargarDataGridView(List<Venta> ventasRealizadas)
        {
            dgvProductos.Rows.Clear();

            foreach (Venta ventas in ventasRealizadas)
            {
                dgvProductos.Rows.Add(
                    ventas.NombreProducto,
                    ventas.TipoDeAnimal,
                    ventas.PrecioPorKilo,
                    ventas.CantidadSeleccionada,
                    ventas.ObtenerClienteCompra
                );
            }
        }

        private void btnGuardarTxt_Click(object sender, EventArgs e)
        {
            string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string archivoPath = @"\historial_ventas.txt";
            string rutaCompleta = ruta + archivoPath;

            try
            {
                if (!Directory.Exists(ruta))
                {
                    throw new Exception("Error en la ruta del archivo");
                }
                using (StreamWriter sw = new StreamWriter(rutaCompleta, true))
                {
                    sw.WriteLine("Fecha y hora de guardado: " + DateTime.Now.ToString());
                    sw.WriteLine();

                    foreach (DataGridViewRow row in dgvProductos.Rows)
                    {
                        string nombreProducto = row.Cells[0].Value?.ToString();
                        string tipoDeAnimal = row.Cells[1].Value?.ToString();
                        string precioPorKilo = row.Cells[2].Value?.ToString();
                        string cantidadSeleccionada = row.Cells[3].Value?.ToString();
                        string clienteCompra = row.Cells[4].Value?.ToString();

                        sw.WriteLine(" - Nombre: " + nombreProducto);
                        sw.WriteLine("   Tipo de Animal: " + tipoDeAnimal);
                        sw.WriteLine("   Precio por Kilo: " + precioPorKilo);
                        sw.WriteLine("   Cantidad: " + cantidadSeleccionada);
                        sw.WriteLine("   Cliente: " + clienteCompra);
                        sw.WriteLine("--------------------------------------------");
                    }
                }

                MessageBox.Show("Historial de ventas guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error en {rutaCompleta} -  Excepcion generada: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                //si el usuario hizo clic en la cruz, cerrar la aplicación
                e.Cancel = false;
                Application.Exit();
            }
        }

        private void btnSerializarJson_Click(object sender, EventArgs e)
        {
            List<Venta> historial = historialVentasDAO.LeerVentas();
            Venta serializer = new Venta();
            serializer.SerializarJson(historial);
            btnDeserializarJson.Enabled = true;
            MessageBox.Show("El historial se ha serializado correctamente.", "Serialización exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDeserializarJson_Click(object sender, EventArgs e)
        {
            Venta historial = new Venta();
            string historialDeserializados = historial.DeserializarJson();

            FrmDeserializarJsonHistorial formSecundario = new FrmDeserializarJsonHistorial();
            formSecundario.MostrarDatos(historialDeserializados);
            formSecundario.Show();
        }
    }
}
