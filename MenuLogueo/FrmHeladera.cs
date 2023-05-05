using System;
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
    public partial class FrmHeladera : Form
    {
        public FrmHeladera()
        {
            InitializeComponent();
            this.MaximizeBox = false; //que no pueda maximizarse
            this.MinimizeBox = false; //que no pueda minimizarse 
            this.FormBorderStyle = FormBorderStyle.FixedDialog; //que no pueda agrandarse desde los lados
            this.FormClosing += new FormClosingEventHandler(FrmHeladera_FormClosing);//cerrar form desde la cruz
        }

        private void btnHeladera_Click(object sender, EventArgs e)
        {
            FrmAbrirHeladera heladera = new FrmAbrirHeladera();
            heladera.Show();
            this.Hide();
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            FrmVenderProducto venderProducto = new FrmVenderProducto();
            venderProducto.Show();
            this.Hide();
        }
               

        private void FrmHeladera_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // El usuario hizo clic en la cruz, cerrar la aplicación
                e.Cancel = false; // Permitir el cierre
                Application.Exit(); // Cerrar la aplicación
            }
        }

        private void btnVolver_Click_1(object sender, EventArgs e)
        {
            FrmLogueo logueo = new FrmLogueo();
            logueo.Show();
            this.Hide();
        }
    }
}
