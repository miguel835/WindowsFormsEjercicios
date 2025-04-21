using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoInformación
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Botón Guardar información
        private void button1_Click(object sender, EventArgs e)
        {
            string fn = "D:\\tuts\\info_" + this.id_textBox1.Text + ".txt";
            if (this.id_textBox1.Text == string.Empty)
            {
                MessageBox.Show("Por favor ingresa tu ID");
                return;
            }
            if (this.full_name_textBox2.Text == string.Empty)
            {
                MessageBox.Show("Por favor ingresa el nombre");
                return;
            }
            System.IO.File.WriteAllText(fn,this.full_name_textBox2.Text, Encoding.UTF8);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string fn = "D:\\tuts\\info_" + this.id_textBox1.Text + ".txt";
            if (this.id_textBox1.Text == string.Empty)
            {
                MessageBox.Show("Por favor ingresa tu ID");
                return;
            }
            //Verificamos si existe el archivo 
            if (System.IO.File.Exists(fn)==false)
            {
                MessageBox.Show("No encontramos el archivo");
                return;
            }
            //Cargamos el archivo en el textbox 
            string resultado = System.IO.File.ReadAllText(fn,Encoding.UTF8);
            this.full_name_textBox2.Text = resultado;
        }
    }
}
