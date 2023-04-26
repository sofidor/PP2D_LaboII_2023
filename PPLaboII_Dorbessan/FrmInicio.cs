using MenuLogueo;
namespace PPLaboII_Dorbessan
{
    public partial class FrmInicio : Form
    {       
        public FrmInicio()
        {
            InitializeComponent();
            this.MaximizeBox = false; //que no pueda maximizarse
            this.MinimizeBox = false; //que no pueda minimizarse 
            this.FormBorderStyle = FormBorderStyle.FixedDialog; //que no pueda agrandarse desde los lados                       
        }

        private void btnVendedor_Click(object sender, EventArgs e) //vendedor
        {           
            FrmLogueo menuLogueo = new FrmLogueo();
            menuLogueo.Show();
            this.Hide();
        }

        private void btnCliente_Click(object sender, EventArgs e) //cliente
        {           
            FrmLogueo menuLogueo = new FrmLogueo();
            menuLogueo.Show();
            this.Hide();
        }

    }
}