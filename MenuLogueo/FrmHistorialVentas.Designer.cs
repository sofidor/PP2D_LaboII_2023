namespace MenuLogueo
{
    partial class FrmHistorialVentas
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHistorialVentas));
            dgvProductos = new DataGridView();
            nombreProducto = new DataGridViewTextBoxColumn();
            tipoDeAnimal = new DataGridViewTextBoxColumn();
            precioPorKilo = new DataGridViewTextBoxColumn();
            cantidadSeleccionada = new DataGridViewTextBoxColumn();
            Cliente = new DataGridViewTextBoxColumn();
            btnVolver = new Button();
            lbHistorial = new Label();
            lbHistorialVentas = new Label();
            btnGuardarTxt = new Button();
            btnSerializarJson = new Button();
            btnDeserializarJson = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // dgvProductos
            // 
            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.AllowUserToDeleteRows = false;
            dgvProductos.BackgroundColor = Color.White;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Columns.AddRange(new DataGridViewColumn[] { nombreProducto, tipoDeAnimal, precioPorKilo, cantidadSeleccionada, Cliente });
            dgvProductos.EnableHeadersVisualStyles = false;
            dgvProductos.Location = new Point(12, 83);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvProductos.RowHeadersWidth = 51;
            dgvProductos.RowTemplate.Height = 29;
            dgvProductos.Size = new Size(735, 447);
            dgvProductos.TabIndex = 2;
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
            // precioPorKilo
            // 
            precioPorKilo.HeaderText = "Precio";
            precioPorKilo.MinimumWidth = 6;
            precioPorKilo.Name = "precioPorKilo";
            precioPorKilo.ReadOnly = true;
            precioPorKilo.Width = 125;
            // 
            // cantidadSeleccionada
            // 
            cantidadSeleccionada.HeaderText = "Cantidad";
            cantidadSeleccionada.MinimumWidth = 6;
            cantidadSeleccionada.Name = "cantidadSeleccionada";
            cantidadSeleccionada.ReadOnly = true;
            cantidadSeleccionada.Width = 125;
            // 
            // Cliente
            // 
            Cliente.HeaderText = "Cliente";
            Cliente.MinimumWidth = 6;
            Cliente.Name = "Cliente";
            Cliente.ReadOnly = true;
            Cliente.Width = 125;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.SkyBlue;
            btnVolver.Image = (Image)resources.GetObject("btnVolver.Image");
            btnVolver.Location = new Point(649, 545);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(98, 29);
            btnVolver.TabIndex = 27;
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // lbHistorial
            // 
            lbHistorial.AutoSize = true;
            lbHistorial.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbHistorial.ForeColor = Color.Transparent;
            lbHistorial.Location = new Point(70, 26);
            lbHistorial.Name = "lbHistorial";
            lbHistorial.Size = new Size(0, 38);
            lbHistorial.TabIndex = 28;
            // 
            // lbHistorialVentas
            // 
            lbHistorialVentas.AutoSize = true;
            lbHistorialVentas.BackColor = Color.Transparent;
            lbHistorialVentas.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbHistorialVentas.ForeColor = SystemColors.ButtonHighlight;
            lbHistorialVentas.Location = new Point(219, 26);
            lbHistorialVentas.Name = "lbHistorialVentas";
            lbHistorialVentas.Size = new Size(330, 41);
            lbHistorialVentas.TabIndex = 29;
            lbHistorialVentas.Text = "HISTORIAL DE VENTAS";
            // 
            // btnGuardarTxt
            // 
            btnGuardarTxt.BackColor = SystemColors.ActiveCaption;
            btnGuardarTxt.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardarTxt.Location = new Point(34, 545);
            btnGuardarTxt.Name = "btnGuardarTxt";
            btnGuardarTxt.Size = new Size(151, 42);
            btnGuardarTxt.TabIndex = 30;
            btnGuardarTxt.Text = "Guardar en txt";
            btnGuardarTxt.UseVisualStyleBackColor = false;
            btnGuardarTxt.Click += btnGuardarTxt_Click;
            // 
            // btnSerializarJson
            // 
            btnSerializarJson.BackColor = SystemColors.ActiveCaption;
            btnSerializarJson.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSerializarJson.Location = new Point(219, 545);
            btnSerializarJson.Name = "btnSerializarJson";
            btnSerializarJson.Size = new Size(151, 42);
            btnSerializarJson.TabIndex = 31;
            btnSerializarJson.Text = "Serializar Json";
            btnSerializarJson.UseVisualStyleBackColor = false;
            btnSerializarJson.Click += btnSerializarJson_Click;
            // 
            // btnDeserializarJson
            // 
            btnDeserializarJson.BackColor = SystemColors.ActiveCaption;
            btnDeserializarJson.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDeserializarJson.Location = new Point(398, 545);
            btnDeserializarJson.Name = "btnDeserializarJson";
            btnDeserializarJson.Size = new Size(151, 42);
            btnDeserializarJson.TabIndex = 32;
            btnDeserializarJson.Text = "Deserializar Json";
            btnDeserializarJson.UseVisualStyleBackColor = false;
            btnDeserializarJson.Click += btnDeserializarJson_Click;
            // 
            // FrmHistorialVentas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(757, 598);
            Controls.Add(btnDeserializarJson);
            Controls.Add(btnSerializarJson);
            Controls.Add(btnGuardarTxt);
            Controls.Add(lbHistorialVentas);
            Controls.Add(lbHistorial);
            Controls.Add(btnVolver);
            Controls.Add(dgvProductos);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmHistorialVentas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Historial de ventas";
            FormClosing += FrmHistorialVentas_FormClosing;
            Load += FrmHistorialVentas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProductos;
        private Button btnVolver;
        private Label lbHistorial;
        private Label lbHistorialVentas;
        private DataGridViewTextBoxColumn nombreProducto;
        private DataGridViewTextBoxColumn tipoDeAnimal;
        private DataGridViewTextBoxColumn precioPorKilo;
        private DataGridViewTextBoxColumn cantidadSeleccionada;
        private DataGridViewTextBoxColumn Cliente;
        private Button btnGuardarTxt;
        private Button btnSerializarJson;
        private Button btnDeserializarJson;
    }
}