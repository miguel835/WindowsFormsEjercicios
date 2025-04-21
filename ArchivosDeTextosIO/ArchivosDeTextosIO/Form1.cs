using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArchivosDeTextosIO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Botón Guardar
        private void button1_Click(object sender, EventArgs e)
        {
            string text = this.textBox1.Text;
            System.IO.File.WriteAllText("D:\\tuts\\info.txt", text,Encoding.UTF8);
            MessageBox.Show("Información Guardada");
        }
        //Botón Cargar datos
        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = System.IO.File.ReadAllText("D:\\tuts\\info.txt", Encoding.UTF8);
        }
    }
}
