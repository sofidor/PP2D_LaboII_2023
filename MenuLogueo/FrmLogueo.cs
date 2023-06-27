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
                MessageBox.Show("Se deben completar los campos de correo electrónico y contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Verificar las credenciales del cliente
                bool credencialesClienteValidas = UsuarioDAO.VerificarCredencialesCliente(correo, contrasena);

                if (credencialesClienteValidas)
                {
                    //// Inicio de sesión exitoso
                    //string nombreCliente = UsuarioDAO.ObtenerNombreCliente(correo);
                    //// Las credenciales del cliente son válidas, abrir el formulario de venta
                    //SoundPlayer sonidoLogueo = new SoundPlayer();
                    //sonidoLogueo.SoundLocation = "C:/Users/sofia/Downloads/SonidoInicioDeSesion.wav";
                    //sonidoLogueo.Play();

                    //FrmVenta ventaForm = new FrmVenta(nombreCliente);
                    //ventaForm.Show();
                    //this.Hide();
                    //return;

                    // Inicio de sesión exitoso
                    string nombreCliente = UsuarioDAO.ObtenerNombreCliente(correo);
                    SoundPlayer sonidoLogueo = new SoundPlayer();
                    sonidoLogueo.SoundLocation = "C:/Users/sofia/Downloads/SonidoInicioDeSesion.wav";
                    sonidoLogueo.Play();
                    // Las credenciales del cliente son válidas, mostrar mensaje de bienvenida en un hilo separado
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

                // Verificar las credenciales del vendedor
                bool credencialesVendedorValidas = UsuarioDAO.VerificarCredencialesVendedor(correo, contrasena);

                if (credencialesVendedorValidas)
                {
                    // Las credenciales del vendedor son válidas, abrir el formulario correspondiente
                    SoundPlayer sonidoLogueo = new SoundPlayer();
                    sonidoLogueo.SoundLocation = "C:\\Users\\sofia\\Downloads\\SD_STARTUP_4.wav";
                    sonidoLogueo.Play();
                    // Las credenciales del cliente son válidas, mostrar mensaje de bienvenida en un hilo separado
                    Thread hiloBienvenida = new Thread(() =>
                    {
                        MessageBox.Show("Bienvenido a la moderna" , "Hola de nuevo!", MessageBoxButtons.OK);
                    });
                    hiloBienvenida.Start();

                    Thread.Sleep(4000);

                    FrmHeladera heladeraForm = new FrmHeladera();
                    heladeraForm.Show();
                    this.Hide();
                    return;
                }

                // Las credenciales no corresponden ni a cliente ni a vendedor
                MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión a la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                txtMail.Clear();
                txtPass.Clear();
            }
        }

        private void chBContraseña_CheckedChanged(object sender, EventArgs e)
        {
            if (chBContraseña.Checked)
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
                // Si el usuario hizo clic en la cruz, cerrar la aplicación
                e.Cancel = false; // Permitir el cierre
                Application.Exit(); // Cerrar la aplicación
            }
        }
    }
}