using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArchivosIO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.IO.File.Copy("C:\\temp\\Puppy.jpg", "D:\\tuts\\cachorro.jpg", true);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.ShowDialog();
            string nombreArchivo;
            nombreArchivo = this.openFileDialog1.FileName;
            System.IO.File.Copy(nombreArchivo, "D:\\tuts\\cachorro.jpg", true);
        }
        //Botón Cortar cachorro usando openFileDialog
        private void button3_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.ShowDialog();
            string nombreArchivo = this.openFileDialog1.FileName;
            //Verificar si existe el archivo antes de moverlo
            if (System.IO.File.Exists("D:\\tuts\\cachorro.jpg") == true)
            {
                //Borramos el archivo
                System.IO.File.Delete("D:\\tuts\\cachorro.jpg");
            }
            //Luego de borrar el archivo entonces lo movemos
            System.IO.File.Move(nombreArchivo, "D:\\tuts\\cachorro.jpg");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.ShowDialog(); 
            string nombreArchivo = this.openFileDialog1.FileName;
            System.IO.File.Delete(nombreArchivo);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string respuesta = System.IO.File.Exists("C:\\temp\\Puppy.jpg").ToString();
            if(respuesta == "true")
            {
                MessageBox.Show("Hemos encontrado tu archivo");
            }
            else
            {
                MessageBox.Show("No existe tu archivo");
            }
        }
    }
}
