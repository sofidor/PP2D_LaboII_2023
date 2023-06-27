using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuLogueo
{
    public partial class FrmDeserializacionJson : Form
    {
        public FrmDeserializacionJson()
        {
            InitializeComponent();
            this.MaximizeBox = false; //que no pueda maximizarse
            this.MinimizeBox = false; //que no pueda minimizarse 
            this.FormBorderStyle = FormBorderStyle.FixedDialog; //que no pueda agrandarse desde los lados            
        }
        private void FrmDeserializacionJson_Load(object sender, EventArgs e)
        {
            this.AutoScroll = true;
        }

        public void MostrarDatos(string datos)
        {
            // Asignar los datos al control Label
            lbDeserializarJson.Text = datos;
        }

    }
}
