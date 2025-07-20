namespace Camara
{
    partial class frmCamara
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnTomarFoto = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboCamara = new System.Windows.Forms.ComboBox();
            this.btnIniciarWebcamara = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTomarFoto
            // 
            this.btnTomarFoto.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnTomarFoto.Location = new System.Drawing.Point(0, 415);
            this.btnTomarFoto.Name = "btnTomarFoto";
            this.btnTomarFoto.Size = new System.Drawing.Size(410, 23);
            this.btnTomarFoto.TabIndex = 0;
            this.btnTomarFoto.Text = "Tomar foto";
            this.btnTomarFoto.UseVisualStyleBackColor = true;
            this.btnTomarFoto.Click += new System.EventHandler(this.btnTomarFoto_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(12, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(390, 345);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Camara";
            // 
            // cboCamara
            // 
            this.cboCamara.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboCamara.FormattingEnabled = true;
            this.cboCamara.Location = new System.Drawing.Point(80, 10);
            this.cboCamara.Name = "cboCamara";
            this.cboCamara.Size = new System.Drawing.Size(295, 21);
            this.cboCamara.TabIndex = 3;
            // 
            // btnIniciarWebcamara
            // 
            this.btnIniciarWebcamara.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnIniciarWebcamara.Location = new System.Drawing.Point(0, 392);
            this.btnIniciarWebcamara.Name = "btnIniciarWebcamara";
            this.btnIniciarWebcamara.Size = new System.Drawing.Size(410, 23);
            this.btnIniciarWebcamara.TabIndex = 4;
            this.btnIniciarWebcamara.Text = "Iniciar Webcamara";
            this.btnIniciarWebcamara.UseVisualStyleBackColor = true;
            this.btnIniciarWebcamara.Click += new System.EventHandler(this.btnIniciarWebcamara_Click);
            // 
            // frmCamara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 438);
            this.Controls.Add(this.btnIniciarWebcamara);
            this.Controls.Add(this.cboCamara);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnTomarFoto);
            this.Name = "frmCamara";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCamara_FormClosing);
            this.Load += new System.EventHandler(this.frmCamara_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Button btnTomarFoto;
        internal System.Windows.Forms.PictureBox pictureBox1;
        internal System.Windows.Forms.ComboBox cboCamara;
        internal System.Windows.Forms.Button btnIniciarWebcamara;
    }
}

