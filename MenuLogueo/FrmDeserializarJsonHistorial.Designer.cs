namespace MenuLogueo
{
    partial class FrmDeserializarJsonHistorial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDeserializarJsonHistorial));
            lbDeserializarJson = new Label();
            SuspendLayout();
            // 
            // lbDeserializarJson
            // 
            lbDeserializarJson.AutoSize = true;
            lbDeserializarJson.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbDeserializarJson.Location = new Point(60, 56);
            lbDeserializarJson.Name = "lbDeserializarJson";
            lbDeserializarJson.Size = new Size(110, 20);
            lbDeserializarJson.TabIndex = 1;
            lbDeserializarJson.Text = "deserializacion";
            // 
            // FrmDeserializarJsonHistorial
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(406, 554);
            Controls.Add(lbDeserializarJson);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmDeserializarJsonHistorial";
            Text = "Deserializar Json Historial";
            Load += FrmDeserializarJsonHistorial_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbDeserializarJson;
    }
}