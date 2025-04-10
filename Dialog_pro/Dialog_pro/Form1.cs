using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dialog_pro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Lógica para el botón Cambiar color de fondo 
        private void button1_Click(object sender, EventArgs e)
        {
            this.colorDialog1.ShowDialog();
            this.BackColor = this.colorDialog1.Color;
            this.button1.ForeColor = this.colorDialog1.Color;
        }
        //Lógica para el botón Explorador de carpetas
        private void button2_Click(object sender, EventArgs e)
        {
            this.folderBrowserDialog1.ShowDialog();
            string fn = this.folderBrowserDialog1.SelectedPath;
            if (fn == string.Empty)
            {
                MessageBox.Show("Por favor selecciona tu carpeta");
            }
            else
            {
                this.textBox1.Text = fn;
            }
        }
        //Lógica para el botón Fuentes
        private void button3_Click(object sender, EventArgs e)
        {
            this.fontDialog1.ShowDialog();
            //this.button3.Font = this.fontDialog1.Font;
            this.Font = this.fontDialog1.Font;
            this.textBox2.Text = this.fontDialog1.Font.ToString();
        }
        //Lógica para el botón Navegar
        private void button4_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.ShowDialog();
            string nombreArchivo = this.openFileDialog1.FileName;
            this.pictureBox1.Image = Image.FromFile(nombreArchivo);
        }
        //Lógica para el botón Guardar como
        private void button5_Click(object sender, EventArgs e)
        {
            this.saveFileDialog1.ShowDialog();
            string nombreArchivo = this.saveFileDialog1.FileName;
            this.textBox3.Text = nombreArchivo;
        }
    }
}