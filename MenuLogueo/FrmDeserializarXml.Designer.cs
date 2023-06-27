namespace MenuLogueo
{
    partial class FrmDeserializarXml
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDeserializarXml));
            lbDeserializarXml = new Label();
            SuspendLayout();
            // 
            // lbDeserializarXml
            // 
            lbDeserializarXml.AutoSize = true;
            lbDeserializarXml.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbDeserializarXml.Location = new Point(66, 50);
            lbDeserializarXml.Name = "lbDeserializarXml";
            lbDeserializarXml.Size = new Size(87, 20);
            lbDeserializarXml.TabIndex = 0;
            lbDeserializarXml.Text = "deserializar";
            // 
            // FrmDeserializarXml
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(357, 537);
            Controls.Add(lbDeserializarXml);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmDeserializarXml";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Deserializar Xml";
            Load += FrmDeserializarXml_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbDeserializarXml;
    }
}