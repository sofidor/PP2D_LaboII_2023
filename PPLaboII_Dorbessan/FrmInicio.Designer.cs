namespace PPLaboII_Dorbessan
{
    partial class FrmInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInicio));
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            btnVendedor = new Button();
            btnCliente = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(172, 38);
            label1.Name = "label1";
            label1.Size = new Size(128, 20);
            label1.TabIndex = 0;
            label1.Text = "C A R N I C E R I A";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(127, 58);
            label2.Name = "label2";
            label2.Size = new Size(234, 40);
            label2.TabIndex = 1;
            label2.Text = "LA MODERNA";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(38, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(83, 79);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // btnVendedor
            // 
            btnVendedor.BackColor = Color.SteelBlue;
            btnVendedor.FlatStyle = FlatStyle.Flat;
            btnVendedor.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnVendedor.ForeColor = SystemColors.ActiveCaptionText;
            btnVendedor.Image = (Image)resources.GetObject("btnVendedor.Image");
            btnVendedor.ImageAlign = ContentAlignment.MiddleLeft;
            btnVendedor.Location = new Point(84, 155);
            btnVendedor.Name = "btnVendedor";
            btnVendedor.Size = new Size(243, 76);
            btnVendedor.TabIndex = 3;
            btnVendedor.Text = "VENDEDOR";
            btnVendedor.UseVisualStyleBackColor = false;
            btnVendedor.Click += btnVendedor_Click;
            // 
            // btnCliente
            // 
            btnCliente.BackColor = Color.SteelBlue;
            btnCliente.FlatStyle = FlatStyle.Flat;
            btnCliente.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCliente.Image = (Image)resources.GetObject("btnCliente.Image");
            btnCliente.ImageAlign = ContentAlignment.MiddleLeft;
            btnCliente.Location = new Point(84, 287);
            btnCliente.Name = "btnCliente";
            btnCliente.Size = new Size(243, 76);
            btnCliente.TabIndex = 4;
            btnCliente.Text = "CLIENTE";
            btnCliente.UseVisualStyleBackColor = false;
            btnCliente.Click += btnCliente_Click;
            // 
            // FrmInicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(407, 425);
            Controls.Add(btnCliente);
            Controls.Add(btnVendedor);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.ActiveCaptionText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmInicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bienvenidos!";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private Button btnVendedor;
        private Button btnCliente;
    }
}