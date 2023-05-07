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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
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
            lbFechaActual = new Label();
            lbFecha = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvProductos
            // 
            dgvProductos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Columns.AddRange(new DataGridViewColumn[] { nombreProducto, tipoDeAnimal, precioPorKilo, Cantidad });
            dgvProductos.Location = new Point(22, 187);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.RowHeadersWidth = 51;
            dgvProductos.RowTemplate.Height = 29;
            dgvProductos.Size = new Size(610, 370);
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
            lbCliente.Location = new Point(48, 144);
            lbCliente.Name = "lbCliente";
            lbCliente.Size = new Size(166, 28);
            lbCliente.TabIndex = 14;
            lbCliente.Text = "Nombre Cliente:";
            // 
            // lbClienteSeleccionado
            // 
            lbClienteSeleccionado.AutoSize = true;
            lbClienteSeleccionado.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbClienteSeleccionado.Location = new Point(220, 149);
            lbClienteSeleccionado.Name = "lbClienteSeleccionado";
            lbClienteSeleccionado.Size = new Size(60, 23);
            lbClienteSeleccionado.TabIndex = 15;
            lbClienteSeleccionado.Text = "cliente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Stencil", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(104, 64);
            label2.Name = "label2";
            label2.Size = new Size(234, 40);
            label2.TabIndex = 18;
            label2.Text = "LA MODERNA";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(147, 44);
            label1.Name = "label1";
            label1.Size = new Size(128, 20);
            label1.TabIndex = 17;
            label1.Text = "C A R N I C E R I A";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(21, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(83, 79);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // lbFechaActual
            // 
            lbFechaActual.AutoSize = true;
            lbFechaActual.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbFechaActual.Location = new Point(474, 69);
            lbFechaActual.Name = "lbFechaActual";
            lbFechaActual.Size = new Size(103, 23);
            lbFechaActual.TabIndex = 19;
            lbFechaActual.Text = "FechaActual";
            // 
            // lbFecha
            // 
            lbFecha.AutoSize = true;
            lbFecha.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbFecha.Location = new Point(490, 44);
            lbFecha.Name = "lbFecha";
            lbFecha.Size = new Size(70, 25);
            lbFecha.TabIndex = 20;
            lbFecha.Text = "FECHA:";
            // 
            // FrmFacturaDueño
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OldLace;
            ClientSize = new Size(648, 580);
            Controls.Add(lbFecha);
            Controls.Add(lbFechaActual);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(lbClienteSeleccionado);
            Controls.Add(lbCliente);
            Controls.Add(dgvProductos);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmFacturaDueño";
            StartPosition = FormStartPosition.CenterScreen;
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
        private Label lbClienteSeleccionado;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Label lbFechaActual;
        private Label lbFecha;
        private DataGridViewTextBoxColumn nombreProducto;
        private DataGridViewTextBoxColumn tipoDeAnimal;
        private DataGridViewTextBoxColumn precioPorKilo;
        private DataGridViewTextBoxColumn Cantidad;
    }
}