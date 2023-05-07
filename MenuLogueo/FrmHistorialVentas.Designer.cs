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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHistorialVentas));
            dgvProductos = new DataGridView();
            nombreProducto = new DataGridViewTextBoxColumn();
            tipoDeAnimal = new DataGridViewTextBoxColumn();
            precioPorKilo = new DataGridViewTextBoxColumn();
            cantidadSeleccionada = new DataGridViewTextBoxColumn();
            btnVolver = new Button();
            lbHistorial = new Label();
            lbHistorialVentas = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
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
            dgvProductos.Columns.AddRange(new DataGridViewColumn[] { nombreProducto, tipoDeAnimal, precioPorKilo, cantidadSeleccionada });
            dgvProductos.EnableHeadersVisualStyles = false;
            dgvProductos.Location = new Point(41, 98);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvProductos.RowHeadersWidth = 51;
            dgvProductos.RowTemplate.Height = 29;
            dgvProductos.Size = new Size(610, 368);
            dgvProductos.TabIndex = 2;
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
            tipoDeAnimal.Width = 155;
            // 
            // precioPorKilo
            // 
            precioPorKilo.HeaderText = "Precio";
            precioPorKilo.MinimumWidth = 6;
            precioPorKilo.Name = "precioPorKilo";
            precioPorKilo.Width = 125;
            // 
            // cantidadSeleccionada
            // 
            cantidadSeleccionada.HeaderText = "Cantidad";
            cantidadSeleccionada.MinimumWidth = 6;
            cantidadSeleccionada.Name = "cantidadSeleccionada";
            cantidadSeleccionada.Width = 125;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.SkyBlue;
            btnVolver.Image = (Image)resources.GetObject("btnVolver.Image");
            btnVolver.Location = new Point(577, 486);
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
            lbHistorialVentas.Location = new Point(165, 23);
            lbHistorialVentas.Name = "lbHistorialVentas";
            lbHistorialVentas.Size = new Size(330, 41);
            lbHistorialVentas.TabIndex = 29;
            lbHistorialVentas.Text = "HISTORIAL DE VENTAS";
            // 
            // FrmHistorialVentas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(696, 527);
            Controls.Add(lbHistorialVentas);
            Controls.Add(lbHistorial);
            Controls.Add(btnVolver);
            Controls.Add(dgvProductos);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmHistorialVentas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Historial de ventas";
            FormClosing += FrmHistorialVentas_FormClosing;
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProductos;
        private DataGridViewTextBoxColumn nombreProducto;
        private DataGridViewTextBoxColumn tipoDeAnimal;
        private DataGridViewTextBoxColumn precioPorKilo;
        private DataGridViewTextBoxColumn cantidadSeleccionada;
        private Button btnVolver;
        private Label lbHistorial;
        private Label lbHistorialVentas;
    }
}