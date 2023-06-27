namespace MenuLogueo
{
    partial class FrmAbrirHeladera
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAbrirHeladera));
            dgvProductos = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            nombreProducto = new DataGridViewTextBoxColumn();
            tipoDeAnimal = new DataGridViewTextBoxColumn();
            stockDisponible = new DataGridViewTextBoxColumn();
            precioPorKilo = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Stock = new DataGridViewTextBoxColumn();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnModificar = new Button();
            lbProducto = new Label();
            lbDetalleProducto = new Label();
            lbPrecio = new Label();
            lbDetalle = new Label();
            txtProducto = new TextBox();
            txtPrecio = new TextBox();
            txtDetalle = new TextBox();
            txtStock = new TextBox();
            lbStock = new Label();
            btnAgregar = new Button();
            btnEliminar = new Button();
            btnVolver = new Button();
            btnSerializarJson = new Button();
            btnSerializarXml = new Button();
            btnDeserializarJson = new Button();
            btnDeserializarXml = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvProductos
            // 
            dgvProductos.AllowUserToDeleteRows = false;
            dgvProductos.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Columns.AddRange(new DataGridViewColumn[] { id, nombreProducto, tipoDeAnimal, stockDisponible, precioPorKilo });
            dgvProductos.EnableHeadersVisualStyles = false;
            dgvProductos.Location = new Point(291, 225);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvProductos.RowHeadersWidth = 51;
            dgvProductos.RowTemplate.Height = 29;
            dgvProductos.Size = new Size(666, 389);
            dgvProductos.TabIndex = 0;
            dgvProductos.CellClick += dgvProductos_CellClick_1;
            // 
            // id
            // 
            id.HeaderText = "Id";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.ReadOnly = true;
            id.Width = 50;
            // 
            // nombreProducto
            // 
            nombreProducto.HeaderText = "Nombre Producto";
            nombreProducto.MinimumWidth = 6;
            nombreProducto.Name = "nombreProducto";
            nombreProducto.ReadOnly = true;
            nombreProducto.Width = 155;
            // 
            // tipoDeAnimal
            // 
            tipoDeAnimal.HeaderText = "Tipo de carne";
            tipoDeAnimal.MinimumWidth = 6;
            tipoDeAnimal.Name = "tipoDeAnimal";
            tipoDeAnimal.ReadOnly = true;
            tipoDeAnimal.Width = 155;
            // 
            // stockDisponible
            // 
            stockDisponible.HeaderText = "Stock disponible";
            stockDisponible.MinimumWidth = 6;
            stockDisponible.Name = "stockDisponible";
            stockDisponible.ReadOnly = true;
            stockDisponible.Width = 157;
            // 
            // precioPorKilo
            // 
            precioPorKilo.HeaderText = "Precio por kg";
            precioPorKilo.MinimumWidth = 6;
            precioPorKilo.Name = "precioPorKilo";
            precioPorKilo.ReadOnly = true;
            precioPorKilo.Width = 125;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.Width = 125;
            // 
            // Stock
            // 
            Stock.HeaderText = "Stock";
            Stock.MinimumWidth = 6;
            Stock.Name = "Stock";
            Stock.Width = 125;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Stencil", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(141, 121);
            label2.Name = "label2";
            label2.Size = new Size(234, 40);
            label2.TabIndex = 8;
            label2.Text = "LA MODERNA";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(184, 101);
            label1.Name = "label1";
            label1.Size = new Size(128, 20);
            label1.TabIndex = 7;
            label1.Text = "C A R N I C E R I A";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 51);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(123, 110);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.Khaki;
            btnModificar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnModificar.ForeColor = SystemColors.Desktop;
            btnModificar.Image = (Image)resources.GetObject("btnModificar.Image");
            btnModificar.ImageAlign = ContentAlignment.MiddleLeft;
            btnModificar.Location = new Point(25, 299);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(218, 49);
            btnModificar.TabIndex = 9;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // lbProducto
            // 
            lbProducto.AutoSize = true;
            lbProducto.BackColor = Color.Transparent;
            lbProducto.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbProducto.ForeColor = SystemColors.ButtonHighlight;
            lbProducto.Location = new Point(441, 87);
            lbProducto.Name = "lbProducto";
            lbProducto.Size = new Size(89, 20);
            lbProducto.TabIndex = 12;
            lbProducto.Text = "PRODUCTO";
            // 
            // lbDetalleProducto
            // 
            lbDetalleProducto.AutoSize = true;
            lbDetalleProducto.BackColor = Color.Transparent;
            lbDetalleProducto.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbDetalleProducto.ForeColor = SystemColors.ControlLightLight;
            lbDetalleProducto.Location = new Point(745, 87);
            lbDetalleProducto.Name = "lbDetalleProducto";
            lbDetalleProducto.Size = new Size(43, 20);
            lbDetalleProducto.TabIndex = 13;
            lbDetalleProducto.Text = "TIPO";
            // 
            // lbPrecio
            // 
            lbPrecio.AutoSize = true;
            lbPrecio.BackColor = Color.Transparent;
            lbPrecio.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbPrecio.ForeColor = SystemColors.ControlLightLight;
            lbPrecio.Location = new Point(441, 155);
            lbPrecio.Name = "lbPrecio";
            lbPrecio.Size = new Size(133, 20);
            lbPrecio.TabIndex = 14;
            lbPrecio.Text = "PRECIO POR KILO";
            // 
            // lbDetalle
            // 
            lbDetalle.AutoSize = true;
            lbDetalle.BackColor = Color.Transparent;
            lbDetalle.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbDetalle.ForeColor = SystemColors.ActiveCaptionText;
            lbDetalle.Location = new Point(511, 24);
            lbDetalle.Name = "lbDetalle";
            lbDetalle.Size = new Size(367, 41);
            lbDetalle.TabIndex = 15;
            lbDetalle.Text = "DETALLE DEL PRODUCTO";
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(441, 110);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(192, 27);
            txtProducto.TabIndex = 18;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(441, 178);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(192, 27);
            txtPrecio.TabIndex = 19;
            // 
            // txtDetalle
            // 
            txtDetalle.Location = new Point(745, 110);
            txtDetalle.Name = "txtDetalle";
            txtDetalle.Size = new Size(192, 27);
            txtDetalle.TabIndex = 20;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(745, 178);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(192, 27);
            txtStock.TabIndex = 21;
            // 
            // lbStock
            // 
            lbStock.AutoSize = true;
            lbStock.BackColor = Color.Transparent;
            lbStock.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbStock.ForeColor = SystemColors.ControlLightLight;
            lbStock.Location = new Point(745, 155);
            lbStock.Name = "lbStock";
            lbStock.Size = new Size(146, 20);
            lbStock.TabIndex = 22;
            lbStock.Text = "STOCK DISPONIBLE";
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.DarkTurquoise;
            btnAgregar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregar.ForeColor = Color.Black;
            btnAgregar.Image = (Image)resources.GetObject("btnAgregar.Image");
            btnAgregar.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgregar.Location = new Point(25, 225);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.RightToLeft = RightToLeft.No;
            btnAgregar.Size = new Size(218, 51);
            btnAgregar.TabIndex = 23;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.RosyBrown;
            btnEliminar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminar.ForeColor = SystemColors.Desktop;
            btnEliminar.Image = (Image)resources.GetObject("btnEliminar.Image");
            btnEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminar.Location = new Point(25, 370);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(218, 48);
            btnEliminar.TabIndex = 25;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.SkyBlue;
            btnVolver.Image = (Image)resources.GetObject("btnVolver.Image");
            btnVolver.Location = new Point(85, 585);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(98, 29);
            btnVolver.TabIndex = 26;
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnSerializarJson
            // 
            btnSerializarJson.BackColor = SystemColors.ButtonShadow;
            btnSerializarJson.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSerializarJson.Location = new Point(12, 446);
            btnSerializarJson.Name = "btnSerializarJson";
            btnSerializarJson.Size = new Size(117, 43);
            btnSerializarJson.TabIndex = 27;
            btnSerializarJson.Text = "Serializar Json";
            btnSerializarJson.UseVisualStyleBackColor = false;
            btnSerializarJson.Click += btnSerializarJson_Click;
            // 
            // btnSerializarXml
            // 
            btnSerializarXml.BackColor = SystemColors.ButtonShadow;
            btnSerializarXml.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSerializarXml.Location = new Point(155, 446);
            btnSerializarXml.Name = "btnSerializarXml";
            btnSerializarXml.Size = new Size(120, 43);
            btnSerializarXml.TabIndex = 28;
            btnSerializarXml.Text = "Serializar Xml";
            btnSerializarXml.UseVisualStyleBackColor = false;
            btnSerializarXml.Click += btnSerializarXml_Click;
            // 
            // btnDeserializarJson
            // 
            btnDeserializarJson.BackColor = SystemColors.ButtonShadow;
            btnDeserializarJson.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDeserializarJson.Location = new Point(12, 510);
            btnDeserializarJson.Name = "btnDeserializarJson";
            btnDeserializarJson.Size = new Size(123, 55);
            btnDeserializarJson.TabIndex = 29;
            btnDeserializarJson.Text = "Deserializar Json";
            btnDeserializarJson.UseVisualStyleBackColor = false;
            btnDeserializarJson.Click += btnDeserializarJson_Click;
            // 
            // btnDeserializarXml
            // 
            btnDeserializarXml.BackColor = SystemColors.ButtonShadow;
            btnDeserializarXml.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDeserializarXml.Location = new Point(155, 510);
            btnDeserializarXml.Name = "btnDeserializarXml";
            btnDeserializarXml.Size = new Size(120, 55);
            btnDeserializarXml.TabIndex = 30;
            btnDeserializarXml.Text = "Deserializar Xml";
            btnDeserializarXml.UseVisualStyleBackColor = false;
            btnDeserializarXml.Click += btnDeserializarXml_Click;
            // 
            // FrmAbrirHeladera
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(964, 627);
            Controls.Add(btnDeserializarXml);
            Controls.Add(btnDeserializarJson);
            Controls.Add(btnSerializarXml);
            Controls.Add(btnSerializarJson);
            Controls.Add(btnVolver);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            Controls.Add(lbStock);
            Controls.Add(txtStock);
            Controls.Add(txtDetalle);
            Controls.Add(txtPrecio);
            Controls.Add(txtProducto);
            Controls.Add(lbDetalle);
            Controls.Add(lbPrecio);
            Controls.Add(lbDetalleProducto);
            Controls.Add(lbProducto);
            Controls.Add(btnModificar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(dgvProductos);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmAbrirHeladera";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ver Productos";
            FormClosing += FrmAbrirHeladera_FormClosing;
            Load += FrmAbrirHeladera_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProductos;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Stock;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Button btnModificar;
        private Label lbProducto;
        private Label lbDetalleProducto;
        private Label lbPrecio;
        private Label lbDetalle;
        private TextBox txtProducto;
        private TextBox txtPrecio;
        private TextBox txtDetalle;
        private TextBox txtStock;
        private Label lbStock;
        private Button btnAgregar;
        private Button btnEliminar;
        private Button btnVolver;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn nombreProducto;
        private DataGridViewTextBoxColumn tipoDeAnimal;
        private DataGridViewTextBoxColumn stockDisponible;
        private DataGridViewTextBoxColumn precioPorKilo;
        private Button btnSerializarJson;
        private Button btnSerializarXml;
        private Button btnDeserializarJson;
        private Button btnDeserializarXml;
    }
}