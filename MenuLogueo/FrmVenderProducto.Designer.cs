namespace MenuLogueo
{
    partial class FrmVenderProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVenderProducto));
            dgvProductos = new DataGridView();
            cbClientes = new ComboBox();
            btnVender = new Button();
            lbCliente = new Label();
            btnVolver = new Button();
            btnVer = new Button();
            nombreProducto = new DataGridViewTextBoxColumn();
            tipoDeAnimal = new DataGridViewTextBoxColumn();
            stockDisponible = new DataGridViewTextBoxColumn();
            precioPorKilo = new DataGridViewTextBoxColumn();
            cantidad = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // dgvProductos
            // 
            dgvProductos.AllowUserToDeleteRows = false;
            dgvProductos.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Columns.AddRange(new DataGridViewColumn[] { nombreProducto, tipoDeAnimal, stockDisponible, precioPorKilo, cantidad });
            dgvProductos.EnableHeadersVisualStyles = false;
            dgvProductos.Location = new Point(12, 31);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvProductos.RowHeadersWidth = 51;
            dgvProductos.RowTemplate.Height = 29;
            dgvProductos.Size = new Size(771, 405);
            dgvProductos.TabIndex = 1;
            dgvProductos.CellBeginEdit += dgvProductos_CellBeginEdit;
            dgvProductos.CellClick += dgvProductos_CellClick;
            // 
            // cbClientes
            // 
            cbClientes.BackColor = SystemColors.ActiveCaption;
            cbClientes.DropDownStyle = ComboBoxStyle.DropDownList;
            cbClientes.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            cbClientes.FormattingEnabled = true;
            cbClientes.Location = new Point(23, 472);
            cbClientes.Name = "cbClientes";
            cbClientes.Size = new Size(187, 28);
            cbClientes.TabIndex = 4;
            // 
            // btnVender
            // 
            btnVender.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnVender.BackColor = Color.DarkSeaGreen;
            btnVender.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnVender.Image = (Image)resources.GetObject("btnVender.Image");
            btnVender.ImageAlign = ContentAlignment.MiddleLeft;
            btnVender.Location = new Point(473, 450);
            btnVender.Name = "btnVender";
            btnVender.Size = new Size(187, 50);
            btnVender.TabIndex = 5;
            btnVender.Text = "Vender";
            btnVender.UseVisualStyleBackColor = false;
            btnVender.Click += btnVender_Click;
            // 
            // lbCliente
            // 
            lbCliente.AutoSize = true;
            lbCliente.BackColor = Color.Transparent;
            lbCliente.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbCliente.Location = new Point(23, 444);
            lbCliente.Name = "lbCliente";
            lbCliente.Size = new Size(76, 25);
            lbCliente.TabIndex = 7;
            lbCliente.Text = "Cliente:";
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.SkyBlue;
            btnVolver.Image = (Image)resources.GetObject("btnVolver.Image");
            btnVolver.Location = new Point(685, 573);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(98, 29);
            btnVolver.TabIndex = 12;
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click_1;
            // 
            // btnVer
            // 
            btnVer.BackColor = SystemColors.ActiveCaption;
            btnVer.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnVer.ForeColor = SystemColors.ActiveCaptionText;
            btnVer.Image = (Image)resources.GetObject("btnVer.Image");
            btnVer.ImageAlign = ContentAlignment.MiddleLeft;
            btnVer.Location = new Point(23, 535);
            btnVer.Name = "btnVer";
            btnVer.Size = new Size(230, 60);
            btnVer.TabIndex = 14;
            btnVer.Text = "Ver Historial Ventas";
            btnVer.UseVisualStyleBackColor = false;
            btnVer.Click += btnVer_Click;
            // 
            // nombreProducto
            // 
            nombreProducto.HeaderText = "Nombre Producto";
            nombreProducto.MinimumWidth = 6;
            nombreProducto.Name = "nombreProducto";
            nombreProducto.Width = 180;
            // 
            // tipoDeAnimal
            // 
            tipoDeAnimal.HeaderText = "Tipo de carne";
            tipoDeAnimal.MinimumWidth = 6;
            tipoDeAnimal.Name = "tipoDeAnimal";
            tipoDeAnimal.Width = 155;
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
            precioPorKilo.HeaderText = "Precio";
            precioPorKilo.MinimumWidth = 6;
            precioPorKilo.Name = "precioPorKilo";
            precioPorKilo.Width = 110;
            // 
            // cantidad
            // 
            cantidad.HeaderText = "Cantidad en Kg";
            cantidad.MinimumWidth = 6;
            cantidad.Name = "cantidad";
            cantidad.Width = 125;
            // 
            // FrmVenderProducto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(795, 614);
            Controls.Add(btnVer);
            Controls.Add(btnVolver);
            Controls.Add(lbCliente);
            Controls.Add(btnVender);
            Controls.Add(cbClientes);
            Controls.Add(dgvProductos);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmVenderProducto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Vender productos";
            FormClosing += FrmVenderProducto_FormClosing;
            Load += FrmVenderProducto_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProductos;
        private ComboBox cbClientes;
        private Button btnVender;
        private Label lbCliente;
        private Button btnVolver;
        private Button btnVer;
        private DataGridViewTextBoxColumn nombreProducto;
        private DataGridViewTextBoxColumn tipoDeAnimal;
        private DataGridViewTextBoxColumn stockDisponible;
        private DataGridViewTextBoxColumn precioPorKilo;
        private DataGridViewTextBoxColumn cantidad;
    }
}