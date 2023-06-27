namespace MenuLogueo
{
    partial class FrmDeserializacionJson
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDeserializacionJson));
            lbDeserializarJson = new Label();
            SuspendLayout();
            // 
            // lbDeserializarJson
            // 
            lbDeserializarJson.AutoSize = true;
            lbDeserializarJson.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbDeserializarJson.Location = new Point(72, 47);
            lbDeserializarJson.Name = "lbDeserializarJson";
            lbDeserializarJson.Size = new Size(110, 20);
            lbDeserializarJson.TabIndex = 0;
            lbDeserializarJson.Text = "deserializacion";
            // 
            // FrmDeserializacionJson
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 510);
            Controls.Add(lbDeserializarJson);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmDeserializacionJson";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Deserializacion Json";
            Load += FrmDeserializacionJson_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbDeserializarJson;
    }
}