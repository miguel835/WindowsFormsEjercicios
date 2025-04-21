using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DirectoriosIO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //System.IO.Directory.CreateDirectory("C:\\temp\\" + this.dir_textBox1.Text);
            for (Int32 i = 0; i < 100; i++)
            {
                System.IO.Directory.CreateDirectory("C:\\temp\\"+i.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Boolean respuesta = System.IO.Directory.Exists("C:\\temp\\PRUEBA");
            if (respuesta) { System.IO.Directory.Delete("C:\\temp\\PRUEBA", true); }
            else { MessageBox.Show("Tu carpeta no existe por lo tanto no se puede borrar"); }   
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Boolean respuesta = System.IO.Directory.Exists("C:\\temp\\PRUEBA");
            if (respuesta){MessageBox.Show("Tu carpeta si existe");}
            else { MessageBox.Show("Tu carpeta no existe"); }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.IO.Directory.Move("C:\\temp\\PRUEBA", "C:\\temp\\test\\Prueba");
        }
    }
}