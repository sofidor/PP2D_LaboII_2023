namespace MenuLogueo
{
    partial class FrmFactura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFactura));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
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
            lbNombreVendedor = new Label();
            lbTotal = new Label();
            lbFechaActual = new Label();
            lbNombre = new Label();
            lbTotalFinal = new Label();
            lbTipoDePago = new Label();
            lbFormaDePago = new Label();
            lbVendedor = new Label();
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
            dgvProductos.Location = new Point(12, 207);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.RowHeadersWidth = 51;
            dgvProductos.RowTemplate.Height = 29;
            dgvProductos.Size = new Size(605, 386);
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
            lbCliente.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbCliente.Location = new Point(101, 131);
            lbCliente.Name = "lbCliente";
            lbCliente.Size = new Size(78, 25);
            lbCliente.TabIndex = 13;
            lbCliente.Text = "nombre";
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
            lbFecha.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbFecha.Location = new Point(442, 30);
            lbFecha.Name = "lbFecha";
            lbFecha.Size = new Size(74, 25);
            lbFecha.TabIndex = 18;
            lbFecha.Text = "FECHA:";
            // 
            // lbNombreVendedor
            // 
            lbNombreVendedor.AutoSize = true;
            lbNombreVendedor.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbNombreVendedor.Location = new Point(10, 631);
            lbNombreVendedor.Name = "lbNombreVendedor";
            lbNombreVendedor.Size = new Size(81, 20);
            lbNombreVendedor.TabIndex = 19;
            lbNombreVendedor.Text = "Vendedor:";
            // 
            // lbTotal
            // 
            lbTotal.AutoSize = true;
            lbTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbTotal.Location = new Point(339, 596);
            lbTotal.Name = "lbTotal";
            lbTotal.Size = new Size(115, 28);
            lbTotal.TabIndex = 21;
            lbTotal.Text = "Total Final:";
            // 
            // lbFechaActual
            // 
            lbFechaActual.AutoSize = true;
            lbFechaActual.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbFechaActual.Location = new Point(428, 55);
            lbFechaActual.Name = "lbFechaActual";
            lbFechaActual.Size = new Size(100, 23);
            lbFechaActual.TabIndex = 22;
            lbFechaActual.Text = "fechaActual";
            // 
            // lbNombre
            // 
            lbNombre.AutoSize = true;
            lbNombre.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbNombre.Location = new Point(12, 128);
            lbNombre.Name = "lbNombre";
            lbNombre.Size = new Size(83, 28);
            lbNombre.TabIndex = 23;
            lbNombre.Text = "Cliente:";
            // 
            // lbTotalFinal
            // 
            lbTotalFinal.AutoSize = true;
            lbTotalFinal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbTotalFinal.Location = new Point(339, 625);
            lbTotalFinal.Name = "lbTotalFinal";
            lbTotalFinal.Size = new Size(64, 28);
            lbTotalFinal.TabIndex = 24;
            lbTotalFinal.Text = "Total:";
            // 
            // lbTipoDePago
            // 
            lbTipoDePago.AutoSize = true;
            lbTipoDePago.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbTipoDePago.Location = new Point(12, 167);
            lbTipoDePago.Name = "lbTipoDePago";
            lbTipoDePago.Size = new Size(173, 28);
            lbTipoDePago.TabIndex = 25;
            lbTipoDePago.Text = "Metodo de pago:";
            // 
            // lbFormaDePago
            // 
            lbFormaDePago.AutoSize = true;
            lbFormaDePago.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbFormaDePago.Location = new Point(182, 170);
            lbFormaDePago.Name = "lbFormaDePago";
            lbFormaDePago.Size = new Size(119, 25);
            lbFormaDePago.TabIndex = 26;
            lbFormaDePago.Text = "metodoPago";
            // 
            // lbVendedor
            // 
            lbVendedor.AutoSize = true;
            lbVendedor.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbVendedor.Location = new Point(93, 632);
            lbVendedor.Name = "lbVendedor";
            lbVendedor.Size = new Size(130, 20);
            lbVendedor.TabIndex = 27;
            lbVendedor.Text = "nombreVendedor";
            // 
            // FrmFactura
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OldLace;
            ClientSize = new Size(625, 655);
            Controls.Add(lbVendedor);
            Controls.Add(lbFormaDePago);
            Controls.Add(lbTipoDePago);
            Controls.Add(lbTotalFinal);
            Controls.Add(lbNombre);
            Controls.Add(lbFechaActual);
            Controls.Add(lbTotal);
            Controls.Add(lbNombreVendedor);
            Controls.Add(lbFecha);
            Controls.Add(lbMontoTotal);
            Controls.Add(lbCliente);
            Controls.Add(dgvProductos);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmFactura";
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
        private Label lbNombreVendedor;
        private Label lbTotal;
        private DataGridViewTextBoxColumn nombreProducto;
        private DataGridViewTextBoxColumn tipoDeAnimal;
        private DataGridViewTextBoxColumn precioPorKilo;
        private DataGridViewTextBoxColumn Cantidad;
        private Label lbFechaActual;
        private Label lbNombre;
        private Label lbTotalFinal;
        private Label lbTipoDePago;
        private Label lbFormaDePago;
        private Label lbVendedor;
    }
}