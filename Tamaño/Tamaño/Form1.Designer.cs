namespace Tamaño
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnAchicar = new System.Windows.Forms.Button();
            this.btnAgrandar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAgrandarImagen = new System.Windows.Forms.Button();
            this.btnReducirImagen = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAchicar
            // 
            this.btnAchicar.Location = new System.Drawing.Point(32, 342);
            this.btnAchicar.Name = "btnAchicar";
            this.btnAchicar.Size = new System.Drawing.Size(136, 47);
            this.btnAchicar.TabIndex = 0;
            this.btnAchicar.Text = "<<";
            this.btnAchicar.UseVisualStyleBackColor = true;
            this.btnAchicar.Click += new System.EventHandler(this.btnAchicar_Click);
            // 
            // btnAgrandar
            // 
            this.btnAgrandar.Location = new System.Drawing.Point(194, 342);
            this.btnAgrandar.Name = "btnAgrandar";
            this.btnAgrandar.Size = new System.Drawing.Size(136, 47);
            this.btnAgrandar.TabIndex = 1;
            this.btnAgrandar.Text = ">>";
            this.btnAgrandar.UseVisualStyleBackColor = true;
            this.btnAgrandar.Click += new System.EventHandler(this.btnAgrandar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(194, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(190, 201);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnAgrandarImagen
            // 
            this.btnAgrandarImagen.Image = ((System.Drawing.Image)(resources.GetObject("btnAgrandarImagen.Image")));
            this.btnAgrandarImagen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgrandarImagen.Location = new System.Drawing.Point(12, 43);
            this.btnAgrandarImagen.Name = "btnAgrandarImagen";
            this.btnAgrandarImagen.Size = new System.Drawing.Size(135, 56);
            this.btnAgrandarImagen.TabIndex = 3;
            this.btnAgrandarImagen.Text = "Agrandar imagen";
            this.btnAgrandarImagen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgrandarImagen.UseVisualStyleBackColor = true;
            this.btnAgrandarImagen.Click += new System.EventHandler(this.btnAgrandarImagen_Click);
            // 
            // btnReducirImagen
            // 
            this.btnReducirImagen.Image = ((System.Drawing.Image)(resources.GetObject("btnReducirImagen.Image")));
            this.btnReducirImagen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReducirImagen.Location = new System.Drawing.Point(12, 120);
            this.btnReducirImagen.Name = "btnReducirImagen";
            this.btnReducirImagen.Size = new System.Drawing.Size(135, 56);
            this.btnReducirImagen.TabIndex = 4;
            this.btnReducirImagen.Text = "Reducir imagen";
            this.btnReducirImagen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReducirImagen.UseVisualStyleBackColor = true;
            this.btnReducirImagen.Click += new System.EventHandler(this.btnReducirImagen_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 47);
            this.button1.TabIndex = 6;
            this.button1.Text = "Localizacion -";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(194, 273);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 47);
            this.button2.TabIndex = 5;
            this.button2.Text = "Localizacion +";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 401);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnReducirImagen);
            this.Controls.Add(this.btnAgrandarImagen);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAgrandar);
            this.Controls.Add(this.btnAchicar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAchicar;
        private System.Windows.Forms.Button btnAgrandar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAgrandarImagen;
        private System.Windows.Forms.Button btnReducirImagen;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

