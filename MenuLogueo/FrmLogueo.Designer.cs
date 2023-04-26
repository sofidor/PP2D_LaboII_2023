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
            lbPass = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(49, 22);
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
            label1.Location = new Point(189, 34);
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
            label2.Location = new Point(138, 54);
            label2.Name = "label2";
            label2.Size = new Size(234, 40);
            label2.TabIndex = 5;
            label2.Text = "LA MODERNA";
            // 
            // txtMail
            // 
            txtMail.Location = new Point(115, 186);
            txtMail.Name = "txtMail";
            txtMail.PlaceholderText = "Ingrese mail";
            txtMail.Size = new Size(200, 27);
            txtMail.TabIndex = 6;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(115, 272);
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
            chBContraseña.Location = new Point(115, 305);
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
            btnLoguearse.Location = new Point(78, 370);
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
            lbCorreo.Location = new Point(129, 145);
            lbCorreo.Name = "lbCorreo";
            lbCorreo.Size = new Size(169, 25);
            lbCorreo.TabIndex = 10;
            lbCorreo.Text = "Correo Electrónico";
            // 
            // lbPass
            // 
            lbPass.AutoSize = true;
            lbPass.BackColor = Color.Transparent;
            lbPass.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbPass.Location = new Point(165, 240);
            lbPass.Name = "lbPass";
            lbPass.Size = new Size(108, 25);
            lbPass.TabIndex = 11;
            lbPass.Text = "Contraseña";
            // 
            // FrmLogueo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(414, 470);
            Controls.Add(lbPass);
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
        private Label lbPass;
    }
}