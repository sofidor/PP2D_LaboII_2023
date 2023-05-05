namespace MenuLogueo
{
    partial class FrmFacturaDueño
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFacturaDueño));
            dgvProductos = new DataGridView();
            nombreProducto = new DataGridViewTextBoxColumn();
            tipoDeAnimal = new DataGridViewTextBoxColumn();
            precioPorKilo = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            lbCliente = new Label();
            lbClienteSeleccionado = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvProductos
            // 
            dgvProductos.AllowUserToDeleteRows = false;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Columns.AddRange(new DataGridViewColumn[] { nombreProducto, tipoDeAnimal, precioPorKilo, Cantidad });
            dgvProductos.Location = new Point(32, 231);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.RowHeadersWidth = 51;
            dgvProductos.RowTemplate.Height = 29;
            dgvProductos.Size = new Size(663, 367);
            dgvProductos.TabIndex = 13;
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
            precioPorKilo.Width = 160;
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
            lbCliente.Location = new Point(38, 184);
            lbCliente.Name = "lbCliente";
            lbCliente.Size = new Size(117, 20);
            lbCliente.TabIndex = 14;
            lbCliente.Text = "Nombre Cliente:";
            // 
            // lbClienteSeleccionado
            // 
            lbClienteSeleccionado.AutoSize = true;
            lbClienteSeleccionado.Location = new Point(177, 184);
            lbClienteSeleccionado.Name = "lbClienteSeleccionado";
            lbClienteSeleccionado.Size = new Size(53, 20);
            lbClienteSeleccionado.TabIndex = 15;
            lbClienteSeleccionado.Text = "cliente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Stencil", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(125, 71);
            label2.Name = "label2";
            label2.Size = new Size(234, 40);
            label2.TabIndex = 18;
            label2.Text = "LA MODERNA";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(168, 51);
            label1.Name = "label1";
            label1.Size = new Size(128, 20);
            label1.TabIndex = 17;
            label1.Text = "C A R N I C E R I A";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(42, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(83, 79);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // FrmFacturaDueño
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(724, 620);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(lbClienteSeleccionado);
            Controls.Add(lbCliente);
            Controls.Add(dgvProductos);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmFacturaDueño";
            Text = "Factura Dueño";
            Load += FrmFacturaDueño_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProductos;
        private Label lbCliente;
        private DataGridViewTextBoxColumn nombreProducto;
        private DataGridViewTextBoxColumn tipoDeAnimal;
        private DataGridViewTextBoxColumn precioPorKilo;
        private DataGridViewTextBoxColumn Cantidad;
        private Label lbClienteSeleccionado;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
    }
}