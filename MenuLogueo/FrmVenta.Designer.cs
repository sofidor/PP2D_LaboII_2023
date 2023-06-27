namespace MenuLogueo
{
    partial class FrmVenta
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVenta));
            dgvProductos = new DataGridView();
            nombreProducto = new DataGridViewTextBoxColumn();
            tipoDeAnimal = new DataGridViewTextBoxColumn();
            stockDisponible = new DataGridViewTextBoxColumn();
            precioPorKilo = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            txtNombreCliente = new TextBox();
            lbMontoMaximo = new Label();
            btnComprar = new Button();
            btnVolver = new Button();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            cmbFormaDePago = new ComboBox();
            lbMetodoPago = new Label();
            lbBscar = new Label();
            btnBuscar = new Button();
            cmbTipoDeCorte = new ComboBox();
            pictureBox2 = new PictureBox();
            lbNombreCliente = new Label();
            txtMontoIngresado = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // dgvProductos
            // 
            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.AllowUserToDeleteRows = false;
            dgvProductos.AllowUserToResizeColumns = false;
            dgvProductos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.SelectionBackColor = Color.MistyRose;
            dgvProductos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvProductos.BackgroundColor = Color.White;
            dgvProductos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvProductos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Peru;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.SandyBrown;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvProductos.ColumnHeadersHeight = 29;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvProductos.Columns.AddRange(new DataGridViewColumn[] { nombreProducto, tipoDeAnimal, stockDisponible, precioPorKilo, Cantidad });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = Color.PeachPuff;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvProductos.DefaultCellStyle = dataGridViewCellStyle4;
            dgvProductos.Location = new Point(12, 331);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvProductos.RowHeadersWidth = 51;
            dgvProductos.RowTemplate.Height = 29;
            dgvProductos.Size = new Size(720, 383);
            dgvProductos.TabIndex = 1;
            dgvProductos.CellBeginEdit += dgvProductos_CellBeginEdit;
            dgvProductos.CellClick += dgvProductos_CellClick;
            dgvProductos.CellValidating += dgvProductos_CellValidating;
            // 
            // nombreProducto
            // 
            nombreProducto.HeaderText = "Nombre Producto";
            nombreProducto.MinimumWidth = 6;
            nombreProducto.Name = "nombreProducto";
            nombreProducto.Width = 155;
            // 
            // tipoDeAnimal
            // 
            tipoDeAnimal.HeaderText = "Tipo de carne";
            tipoDeAnimal.MinimumWidth = 6;
            tipoDeAnimal.Name = "tipoDeAnimal";
            tipoDeAnimal.Width = 150;
            // 
            // stockDisponible
            // 
            stockDisponible.HeaderText = "Stock disponible";
            stockDisponible.MinimumWidth = 6;
            stockDisponible.Name = "stockDisponible";
            stockDisponible.Width = 157;
            // 
            // precioPorKilo
            // 
            dataGridViewCellStyle3.NullValue = null;
            precioPorKilo.DefaultCellStyle = dataGridViewCellStyle3;
            precioPorKilo.HeaderText = "Precio";
            precioPorKilo.MinimumWidth = 6;
            precioPorKilo.Name = "precioPorKilo";
            precioPorKilo.Width = 105;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad en Kg";
            Cantidad.MinimumWidth = 6;
            Cantidad.Name = "Cantidad";
            Cantidad.Resizable = DataGridViewTriState.True;
            Cantidad.Width = 125;
            // 
            // txtNombreCliente
            // 
            txtNombreCliente.Location = new Point(208, 189);
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.Size = new Size(170, 27);
            txtNombreCliente.TabIndex = 2;
            // 
            // lbMontoMaximo
            // 
            lbMontoMaximo.AutoSize = true;
            lbMontoMaximo.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbMontoMaximo.Location = new Point(28, 145);
            lbMontoMaximo.Name = "lbMontoMaximo";
            lbMontoMaximo.Size = new Size(260, 23);
            lbMontoMaximo.TabIndex = 3;
            lbMontoMaximo.Text = "Ingrese monto maximo a gastar:";
            // 
            // btnComprar
            // 
            btnComprar.BackColor = Color.Peru;
            btnComprar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnComprar.ForeColor = Color.White;
            btnComprar.Location = new Point(273, 734);
            btnComprar.Name = "btnComprar";
            btnComprar.Size = new Size(225, 59);
            btnComprar.TabIndex = 4;
            btnComprar.Text = "Comprar";
            btnComprar.UseVisualStyleBackColor = false;
            btnComprar.Click += btnComprar_Click;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.SkyBlue;
            btnVolver.Image = (Image)resources.GetObject("btnVolver.Image");
            btnVolver.Location = new Point(608, 807);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(103, 30);
            btnVolver.TabIndex = 5;
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Stencil", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(291, 59);
            label2.Name = "label2";
            label2.Size = new Size(234, 40);
            label2.TabIndex = 8;
            label2.Text = "LA MODERNA";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(334, 39);
            label1.Name = "label1";
            label1.Size = new Size(128, 20);
            label1.TabIndex = 7;
            label1.Text = "C A R N I C E R I A";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(208, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(83, 79);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // cmbFormaDePago
            // 
            cmbFormaDePago.BackColor = Color.Peru;
            cmbFormaDePago.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFormaDePago.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            cmbFormaDePago.ForeColor = Color.White;
            cmbFormaDePago.FormattingEnabled = true;
            cmbFormaDePago.Location = new Point(239, 236);
            cmbFormaDePago.Name = "cmbFormaDePago";
            cmbFormaDePago.Size = new Size(151, 28);
            cmbFormaDePago.TabIndex = 9;
            // 
            // lbMetodoPago
            // 
            lbMetodoPago.AutoSize = true;
            lbMetodoPago.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbMetodoPago.Location = new Point(28, 237);
            lbMetodoPago.Name = "lbMetodoPago";
            lbMetodoPago.Size = new Size(189, 23);
            lbMetodoPago.TabIndex = 10;
            lbMetodoPago.Text = "Ingrese forma de pago:";
            // 
            // lbBscar
            // 
            lbBscar.AutoSize = true;
            lbBscar.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbBscar.Location = new Point(28, 282);
            lbBscar.Name = "lbBscar";
            lbBscar.Size = new Size(201, 46);
            lbBscar.TabIndex = 12;
            lbBscar.Text = "Buscar por tipo de carne:\r\n\r\n";
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.Peru;
            btnBuscar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(413, 282);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(94, 29);
            btnBuscar.TabIndex = 14;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // cmbTipoDeCorte
            // 
            cmbTipoDeCorte.BackColor = Color.Peru;
            cmbTipoDeCorte.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoDeCorte.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            cmbTipoDeCorte.ForeColor = Color.White;
            cmbTipoDeCorte.FormattingEnabled = true;
            cmbTipoDeCorte.Location = new Point(239, 281);
            cmbTipoDeCorte.Name = "cmbTipoDeCorte";
            cmbTipoDeCorte.Size = new Size(151, 28);
            cmbTipoDeCorte.TabIndex = 15;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(571, 106);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(120, 143);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            // 
            // lbNombreCliente
            // 
            lbNombreCliente.AutoSize = true;
            lbNombreCliente.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbNombreCliente.Location = new Point(28, 189);
            lbNombreCliente.Name = "lbNombreCliente";
            lbNombreCliente.Size = new Size(157, 23);
            lbNombreCliente.TabIndex = 17;
            lbNombreCliente.Text = "Ingrese su nombre:";
            // 
            // txtMontoIngresado
            // 
            txtMontoIngresado.Location = new Point(305, 144);
            txtMontoIngresado.Name = "txtMontoIngresado";
            txtMontoIngresado.Size = new Size(170, 27);
            txtMontoIngresado.TabIndex = 18;
            // 
            // FrmVenta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(746, 849);
            Controls.Add(txtMontoIngresado);
            Controls.Add(lbNombreCliente);
            Controls.Add(pictureBox2);
            Controls.Add(cmbTipoDeCorte);
            Controls.Add(btnBuscar);
            Controls.Add(lbBscar);
            Controls.Add(lbMetodoPago);
            Controls.Add(cmbFormaDePago);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(btnVolver);
            Controls.Add(btnComprar);
            Controls.Add(lbMontoMaximo);
            Controls.Add(txtNombreCliente);
            Controls.Add(dgvProductos);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmVenta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Comprar productos";
            FormClosing += FrmVenta_FormClosing;
            Load += FrmVenta_Load;           
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProductos;
        private TextBox txtNombreCliente;
        private Label lbMontoMaximo;
        private Button btnComprar;
        private Button btnVolver;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private ComboBox cmbFormaDePago;
        private Label lbMetodoPago;
        private Label lbBscar;
        private Button btnBuscar;
        private ComboBox cmbTipoDeCorte;
        private PictureBox pictureBox2;
        private Label lbNombreCliente;
        private TextBox txtMontoIngresado;
        private DataGridViewTextBoxColumn nombreProducto;
        private DataGridViewTextBoxColumn tipoDeAnimal;
        private DataGridViewTextBoxColumn stockDisponible;
        private DataGridViewTextBoxColumn precioPorKilo;
        private DataGridViewTextBoxColumn Cantidad;
    }
}