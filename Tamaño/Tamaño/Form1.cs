using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tamaño
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgrandar_Click(object sender, EventArgs e)
        {
            //-----Cambiamos el tamaño del formulario---------------
            Int32 altura;
            altura = this.Size.Height;
            this.Size = new Size(700, altura);
        }

        private void btnAchicar_Click(object sender, EventArgs e)
        {
            //-----Volvemos al formulario a su tamaño original-------
            Int32 altura;
            altura = this.Size.Height;
            this.Size = new Size(457,altura);
        }

        private void btnAgrandarImagen_Click(object sender, EventArgs e)
        {
            //----------Incrementamos la imagen-------
            this.pictureBox1.Size = new Size(this.pictureBox1.Width + 10, this.pictureBox1.Height + 10);
        }

        private void btnReducirImagen_Click(object sender, EventArgs e)
        {
            //----------Reducimos la imagen-------
            this.pictureBox1.Size = new Size(this.pictureBox1.Width - 10, this.pictureBox1.Height - 10);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //this.pictureBox1.Location = new Point(200, 200);
            this.pictureBox1.Location = new Point(this.pictureBox1.Location.X+10, this.pictureBox1.Location.Y);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.pictureBox1.Location = new Point(this.pictureBox1.Location.X-10,this.pictureBox1.Location.Y);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            //----Mandamos la posicion del mouse al titulo del formulario------------
            this.Text = e.X.ToString() + ";" + e.Y.ToString();
            //-----Movemos el pictureBox de acuerdo a la posición del mouse----------
            this.pictureBox1.Location = new Point(e.X, e.Y);
            //-----Puedes intentarlo con cualquier control
        }
    }
}
