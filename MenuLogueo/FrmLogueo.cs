using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Media;
using BibliotecaDeClases;
using System.Threading;

namespace MenuLogueo
{
    public partial class FrmLogueo : Form
    {
        public FrmLogueo()
        {
            InitializeComponent();

            this.MaximizeBox = false; //que no pueda maximizarse
            this.MinimizeBox = false; //que no pueda minimizarse 
            this.FormBorderStyle = FormBorderStyle.FixedDialog; //que no pueda agrandarse desde los lados
            this.FormClosing += new FormClosingEventHandler(FrmLogueo_FormClosing);//cerrar form desde la cruz
        }
        private void btnVendedor_Click(object sender, EventArgs e)
        {            
            txtMail.Text = "sergioLopez@gmail.com";
            txtPass.Text = "clave123";
        }
        private void btnCliente_Click(object sender, EventArgs e)
        {
            txtMail.Text = "jazSerna@gmail.com";
            txtPass.Text = "klm6789";
        }
        private void btnLoguearse_Click(object sender, EventArgs e)
        {
            string correo = txtMail.Text;
            string contrasena = txtPass.Text;

            if (string.IsNullOrWhiteSpace(correo) || string.IsNullOrWhiteSpace(contrasena))
            {
                MessageBox.Show("Se deben completar los campos de correo electr�nico y contrase�a", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Verificar datos del cliente
                bool credencialesClienteValidas = UsuarioDAO.VerificarCredencialesCliente(correo, contrasena);

                if (credencialesClienteValidas)
                {                    
                    string nombreCliente = UsuarioDAO.ObtenerNombreCliente(correo);
                    SoundPlayer sonidoLogueo = new SoundPlayer();
                    sonidoLogueo.SoundLocation = "C:/Users/sofia/Downloads/SonidoInicioDeSesion.wav";
                    sonidoLogueo.Play();
                    //si los datos del cliente son v�lidos, mostrar mensaje de bienvenida en un hilo separado
                    Thread hiloBienvenida = new Thread(() =>
                    {
                        MessageBox.Show("Bienvenido, " + nombreCliente, "Hola de nuevo!", MessageBoxButtons.OK);
                    });
                    hiloBienvenida.Start();
                   
                    Thread.Sleep(4000);

                    // Abrir el formulario de venta
                    FrmVenta ventaForm = new FrmVenta(nombreCliente);
                    ventaForm.Show();
                    this.Hide();
                    return;
                }

                // Verificar datos del vendedor
                bool credencialesVendedorValidas = UsuarioDAO.VerificarCredencialesVendedor(correo, contrasena);

                if (credencialesVendedorValidas)
                {
                    string nombreVendedor = UsuarioDAO.ObtenerNombreVendedor(correo);
                    SoundPlayer sonidoLogueo = new SoundPlayer();
                    sonidoLogueo.SoundLocation = "C:\\Users\\sofia\\Downloads\\SD_STARTUP_4.wav";
                    sonidoLogueo.Play();
                    // si los datos del cliente son v�lidos, mostrar mensaje de bienvenida en un hilo separado
                    Thread hiloBienvenida = new Thread(() =>
                    {
                        MessageBox.Show("Bienvenido, " + nombreVendedor , "Hola de nuevo!", MessageBoxButtons.OK);
                    });
                    hiloBienvenida.Start();

                    Thread.Sleep(4000);

                    FrmHeladera heladeraForm = new FrmHeladera();
                    heladeraForm.Show();
                    this.Hide();
                    return;
                }

                // los datos no corresponden ni a cliente ni a vendedor
                MessageBox.Show("Usuario o contrase�a incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexi�n a la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                txtMail.Clear();
                txtPass.Clear();
            }
        }

        private void chBContrase�a_CheckedChanged(object sender, EventArgs e)
        {
            if (chBContrase�a.Checked)
            {
                txtPass.PasswordChar = '\0';
            }
            else
            {
                txtPass.PasswordChar = '*';
            }
        }
        private void FrmLogueo_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // Si el usuario hizo clic en la cruz, cerrar la aplicaci�n
                e.Cancel = false; // Permitir el cierre
                Application.Exit(); // Cerrar la aplicaci�n
            }
        }
    }
}