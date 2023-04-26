namespace MenuLogueo
{
    partial class FrmLogueo
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogueo));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            txtMail = new TextBox();
            txtPass = new TextBox();
            chBContraseña = new CheckBox();
            btnLoguearse = new Button();
            lbCorreo = new Label();
            gbUsuario = new GroupBox();
            rbCliente = new RadioButton();
            rbVendedor = new RadioButton();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            gbUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(441, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(83, 79);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(567, 34);
            label1.Name = "label1";
            label1.Size = new Size(128, 20);
            label1.TabIndex = 4;
            label1.Text = "C A R N I C E R I A";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Stencil", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(524, 54);
            label2.Name = "label2";
            label2.Size = new Size(234, 40);
            label2.TabIndex = 5;
            label2.Text = "LA MODERNA";
            // 
            // txtMail
            // 
            txtMail.Location = new Point(510, 200);
            txtMail.Name = "txtMail";
            txtMail.PlaceholderText = "Ingrese su mail";
            txtMail.Size = new Size(200, 27);
            txtMail.TabIndex = 6;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(510, 259);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.PlaceholderText = "Ingrese contraseña";
            txtPass.Size = new Size(200, 27);
            txtPass.TabIndex = 7;
            // 
            // chBContraseña
            // 
            chBContraseña.AutoSize = true;
            chBContraseña.BackColor = Color.Transparent;
            chBContraseña.Location = new Point(510, 292);
            chBContraseña.Name = "chBContraseña";
            chBContraseña.Size = new Size(158, 24);
            chBContraseña.TabIndex = 8;
            chBContraseña.Text = "Mostrar contraseña";
            chBContraseña.UseVisualStyleBackColor = false;
            chBContraseña.CheckedChanged += chBContraseña_CheckedChanged;
            // 
            // btnLoguearse
            // 
            btnLoguearse.BackColor = SystemColors.Window;
            btnLoguearse.ForeColor = Color.Black;
            btnLoguearse.Location = new Point(479, 450);
            btnLoguearse.Name = "btnLoguearse";
            btnLoguearse.Size = new Size(279, 41);
            btnLoguearse.TabIndex = 9;
            btnLoguearse.Text = "Iniciar Sesión";
            btnLoguearse.UseVisualStyleBackColor = false;
            btnLoguearse.Click += btnLoguearse_Click;
            // 
            // lbCorreo
            // 
            lbCorreo.AutoSize = true;
            lbCorreo.BackColor = Color.Transparent;
            lbCorreo.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbCorreo.Location = new Point(524, 159);
            lbCorreo.Name = "lbCorreo";
            lbCorreo.Size = new Size(0, 25);
            lbCorreo.TabIndex = 10;
            // 
            // gbUsuario
            // 
            gbUsuario.BackColor = Color.Transparent;
            gbUsuario.Controls.Add(rbCliente);
            gbUsuario.Controls.Add(rbVendedor);
            gbUsuario.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            gbUsuario.Location = new Point(429, 349);
            gbUsuario.Name = "gbUsuario";
            gbUsuario.Size = new Size(377, 69);
            gbUsuario.TabIndex = 12;
            gbUsuario.TabStop = false;
            gbUsuario.Text = "Tipo de Usuario";
            // 
            // rbCliente
            // 
            rbCliente.AutoSize = true;
            rbCliente.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            rbCliente.Location = new Point(220, 38);
            rbCliente.Name = "rbCliente";
            rbCliente.Size = new Size(85, 24);
            rbCliente.TabIndex = 1;
            rbCliente.TabStop = true;
            rbCliente.Text = "CLIENTE";
            rbCliente.UseVisualStyleBackColor = true;
            // 
            // rbVendedor
            // 
            rbVendedor.AutoSize = true;
            rbVendedor.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            rbVendedor.Location = new Point(46, 38);
            rbVendedor.Name = "rbVendedor";
            rbVendedor.Size = new Size(108, 24);
            rbVendedor.TabIndex = 0;
            rbVendedor.TabStop = true;
            rbVendedor.Text = "VENDEDOR";
            rbVendedor.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(530, 144);
            label3.Name = "label3";
            label3.Size = new Size(138, 28);
            label3.TabIndex = 13;
            label3.Text = "Iniciar Sesion";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, -1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(390, 538);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            // 
            // FrmLogueo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(831, 537);
            Controls.Add(pictureBox2);
            Controls.Add(label3);
            Controls.Add(gbUsuario);
            Controls.Add(lbCorreo);
            Controls.Add(btnLoguearse);
            Controls.Add(chBContraseña);
            Controls.Add(txtPass);
            Controls.Add(txtMail);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmLogueo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Iniciar Sesión";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            gbUsuario.ResumeLayout(false);
            gbUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox txtMail;
        private TextBox txtPass;
        private CheckBox chBContraseña;
        private Button btnLoguearse;
        private Label lbCorreo;
        private GroupBox gbUsuario;
        private RadioButton rbCliente;
        private RadioButton rbVendedor;
        private Label label3;
        private PictureBox pictureBox2;
    }
}