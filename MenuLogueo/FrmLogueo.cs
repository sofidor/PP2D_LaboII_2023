using System.Windows.Forms;
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

            if (usuario == usuarioVerdad && pass == passVerdad)
            {
                MessageBox.Show("Inicio correctamente");
                this.Hide();
            }
            else
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