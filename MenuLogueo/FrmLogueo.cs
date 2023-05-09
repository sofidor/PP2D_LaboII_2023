using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Media;

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
            txtMail.Text = "cliente@mail.com";
            txtPass.Text = "clave234";
        }
        private void btnLoguearse_Click(object sender, EventArgs e)
        {
            string usuario = this.txtMail.Text;
            string pass = this.txtPass.Text;

            SoundPlayer sonidoLogueo= new SoundPlayer(); //almacena el audio
            sonidoLogueo.SoundLocation = "C:/Users/sofia/Downloads/SonidoInicioDeSesion.wav";
            sonidoLogueo.Play();

            // Verificar si el usuario es un vendedor o un cliente
            if (txtMail.Text == "sergioLopez@gmail.com" && txtPass.Text == "clave123")
            {
                // Si el usuario es un vendedor, abrir el formulario Heladera
                FrmHeladera heladeraForm = new FrmHeladera();
                heladeraForm.Show();
                this.Hide();
            }
            else if (txtMail.Text == "cliente@mail.com" && txtPass.Text == "clave234")
            {
                // Si el usuario es un cliente, abrir el formulario Venta
                FrmVenta ventaForm = new FrmVenta();
                ventaForm.Show();
                this.Hide();
            }
            else
            {
                if (string.IsNullOrWhiteSpace(txtMail.Text) || string.IsNullOrWhiteSpace(txtPass.Text))
                {
                    // Mostrar mensaje de error
                    string mensaje = "Se deben completar los siguientes campos:";
                    if (string.IsNullOrWhiteSpace(txtMail.Text))
                    {
                        mensaje += "\n- Correo Electrónico";
                    }
                    if (string.IsNullOrWhiteSpace(txtPass.Text))
                    {
                        mensaje += "\n- Contraseña";
                    }
                    MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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