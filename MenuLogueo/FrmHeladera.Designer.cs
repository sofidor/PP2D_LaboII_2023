namespace MenuLogueo
{
    partial class FrmHeladera
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHeladera));
            btnHeladera = new Button();
            btnVender = new Button();
            btnVolver = new Button();
            SuspendLayout();
            // 
            // btnHeladera
            // 
            btnHeladera.BackColor = Color.SeaShell;
            btnHeladera.FlatStyle = FlatStyle.Flat;
            btnHeladera.Font = new Font("Dubai", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnHeladera.ForeColor = Color.Black;
            btnHeladera.Image = (Image)resources.GetObject("btnHeladera.Image");
            btnHeladera.ImageAlign = ContentAlignment.MiddleLeft;
            btnHeladera.Location = new Point(76, 74);
            btnHeladera.Name = "btnHeladera";
            btnHeladera.Size = new Size(255, 89);
            btnHeladera.TabIndex = 0;
            btnHeladera.Text = "         Ver Heladera";
            btnHeladera.UseVisualStyleBackColor = false;
            btnHeladera.Click += btnHeladera_Click;
            // 
            // btnVender
            // 
            btnVender.BackColor = Color.SeaShell;
            btnVender.FlatStyle = FlatStyle.Flat;
            btnVender.Font = new Font("Dubai", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnVender.ForeColor = Color.Black;
            btnVender.Image = (Image)resources.GetObject("btnVender.Image");
            btnVender.ImageAlign = ContentAlignment.MiddleLeft;
            btnVender.Location = new Point(76, 215);
            btnVender.Name = "btnVender";
            btnVender.Size = new Size(255, 91);
            btnVender.TabIndex = 1;
            btnVender.Text = "Realizar una venta";
            btnVender.TextAlign = ContentAlignment.MiddleRight;
            btnVender.UseVisualStyleBackColor = false;
            btnVender.Click += btnVender_Click;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.SkyBlue;
            btnVolver.Image = (Image)resources.GetObject("btnVolver.Image");
            btnVolver.Location = new Point(302, 340);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(98, 29);
            btnVolver.TabIndex = 13;
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click_1;
            // 
            // FrmHeladera
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(412, 381);
            Controls.Add(btnVolver);
            Controls.Add(btnVender);
            Controls.Add(btnHeladera);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmHeladera";
            StartPosition = FormStartPosition.CenterScreen;
            FormClosing += FrmHeladera_FormClosing;           
            ResumeLayout(false);
        }

        #endregion

        private Button btnHeladera;
        private Button btnVender;
        private Button btnVolver;
    }
}