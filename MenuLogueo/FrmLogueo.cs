using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace MenuLogueo
{
    public partial class FrmLogueo : Form
    {
        private const string usuarioVerdad = "sofi@gmail.com";
        private const string passVerdad = "abc123";
        public FrmLogueo()
        {
            InitializeComponent();
            // Asignar valores hardcodeados a los campos de texto
            txtMail.Text = usuarioVerdad;
            txtPass.Text = passVerdad;

            this.MaximizeBox = false; //que no pueda maximizarse
            this.MinimizeBox = false; //que no pueda minimizarse 
            this.FormBorderStyle = FormBorderStyle.FixedDialog; //que no pueda agrandarse desde los lados
        }
        private void btnLoguearse_Click(object sender, EventArgs e)
        {
            string usuario = this.txtMail.Text;
            string pass = this.txtPass.Text;

            string tipoDeUsuario = "";
            if (rbVendedor.Checked)
            {
                tipoDeUsuario = this.rbVendedor.Text;
            }
            else if (rbCliente.Checked)
            {
                tipoDeUsuario = this.rbCliente.Text;
            }

            if (usuario == usuarioVerdad && pass == passVerdad && (tipoDeUsuario == rbVendedor.Text || tipoDeUsuario == rbCliente.Text))
            {
                if (rbVendedor.Checked)
                {
                    // Redirigimos al vendedor a la ventana de la heladera
                    FrmHeladera heladeraForm = new FrmHeladera();
                    heladeraForm.Show();
                }
                else if (rbCliente.Checked)
                {
                    // Redirigimos al cliente a la ventana de la venta
                    //VentaForm ventaForm = new VentaForm();
                    // ventaForm.Show();
                }
                this.Hide();
            }
            else
            {
                if (string.IsNullOrWhiteSpace(txtMail.Text) || string.IsNullOrWhiteSpace(txtPass.Text) || (!rbVendedor.Checked && !rbCliente.Checked))
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
                    if (!rbVendedor.Checked && !rbCliente.Checked)
                    {
                        mensaje += "\n- Tipo de usuario";
                    }
                    MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

    }
}