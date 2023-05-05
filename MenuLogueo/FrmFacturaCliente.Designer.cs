namespace MenuLogueo
{
    partial class FrmFacturaCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFacturaCliente));
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            dgvProductos = new DataGridView();
            nombreProducto = new DataGridViewTextBoxColumn();
            tipoDeAnimal = new DataGridViewTextBoxColumn();
            precioPorKilo = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            lbCliente = new Label();
            lbMontoTotal = new Label();
            lbFecha = new Label();
            lbConsumidor = new Label();
            lbTotal = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Stencil", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(93, 50);
            label2.Name = "label2";
            label2.Size = new Size(234, 40);
            label2.TabIndex = 11;
            label2.Text = "LA MODERNA";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(136, 30);
            label1.Name = "label1";
            label1.Size = new Size(128, 20);
            label1.TabIndex = 10;
            label1.Text = "C A R N I C E R I A";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(10, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(83, 79);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // dgvProductos
            // 
            dgvProductos.AllowUserToDeleteRows = false;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Columns.AddRange(new DataGridViewColumn[] { nombreProducto, tipoDeAnimal, precioPorKilo, Cantidad });
            dgvProductos.Location = new Point(12, 170);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.RowHeadersWidth = 51;
            dgvProductos.RowTemplate.Height = 29;
            dgvProductos.Size = new Size(605, 379);
            dgvProductos.TabIndex = 12;
            // 
            // nombreProducto
            // 
            nombreProducto.HeaderText = "Nombre Producto";
            nombreProducto.MinimumWidth = 6;
            nombreProducto.Name = "nombreProducto";
            nombreProducto.ReadOnly = true;
            nombreProducto.Width = 160;
            // 
            // tipoDeAnimal
            // 
            tipoDeAnimal.HeaderText = "Tipo de carne";
            tipoDeAnimal.MinimumWidth = 6;
            tipoDeAnimal.Name = "tipoDeAnimal";
            tipoDeAnimal.ReadOnly = true;
            tipoDeAnimal.Width = 170;
            // 
            // precioPorKilo
            // 
            precioPorKilo.HeaderText = "Precio";
            precioPorKilo.MinimumWidth = 6;
            precioPorKilo.Name = "precioPorKilo";
            precioPorKilo.ReadOnly = true;
            precioPorKilo.Width = 120;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.MinimumWidth = 6;
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
            Cantidad.Width = 125;
            // 
            // lbCliente
            // 
            lbCliente.AutoSize = true;
            lbCliente.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbCliente.Location = new Point(35, 128);
            lbCliente.Name = "lbCliente";
            lbCliente.Size = new Size(94, 28);
            lbCliente.TabIndex = 13;
            lbCliente.Text = "Nombre:";
            // 
            // lbMontoTotal
            // 
            lbMontoTotal.AutoSize = true;
            lbMontoTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbMontoTotal.Location = new Point(460, 565);
            lbMontoTotal.Name = "lbMontoTotal";
            lbMontoTotal.Size = new Size(0, 28);
            lbMontoTotal.TabIndex = 17;
            // 
            // lbFecha
            // 
            lbFecha.AutoSize = true;
            lbFecha.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbFecha.Location = new Point(412, 22);
            lbFecha.Name = "lbFecha";
            lbFecha.Size = new Size(199, 28);
            lbFecha.TabIndex = 18;
            lbFecha.Text = "FECHA: 07/05/2023";
            // 
            // lbConsumidor
            // 
            lbConsumidor.AutoSize = true;
            lbConsumidor.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbConsumidor.Location = new Point(449, 64);
            lbConsumidor.Name = "lbConsumidor";
            lbConsumidor.Size = new Size(129, 20);
            lbConsumidor.TabIndex = 19;
            lbConsumidor.Text = "Consumidor Final";
            // 
            // lbTotal
            // 
            lbTotal.AutoSize = true;
            lbTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbTotal.Location = new Point(301, 552);
            lbTotal.Name = "lbTotal";
            lbTotal.Size = new Size(133, 28);
            lbTotal.TabIndex = 21;
            lbTotal.Text = "Monto Total:";
            // 
            // FrmFacturaCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(629, 640);
            Controls.Add(lbTotal);
            Controls.Add(lbConsumidor);
            Controls.Add(lbFecha);
            Controls.Add(lbMontoTotal);
            Controls.Add(lbCliente);
            Controls.Add(dgvProductos);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmFacturaCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Factura";
            Load += FrmFactura_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private DataGridView dgvProductos;
        private Label lbCliente;
        private TextBox txtTotal;
        private Label lbMontoTotal;
        private Label lbFecha;
        private Label lbConsumidor;
        private Label lbTotal;
        private DataGridViewTextBoxColumn nombreProducto;
        private DataGridViewTextBoxColumn tipoDeAnimal;
        private DataGridViewTextBoxColumn precioPorKilo;
        private DataGridViewTextBoxColumn Cantidad;
    }
}