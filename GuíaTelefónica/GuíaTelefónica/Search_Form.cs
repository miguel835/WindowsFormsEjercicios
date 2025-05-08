using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuíaTelefónica
{
    public partial class Search_Form : Form
    {
        public Search_Form()
        {
            InitializeComponent();
        }
        //Lògica del botón Buscar 
        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "")
            {
                MessageBox.Show("Debes ingresar el ID");
                return;
            }
            //-------------------------------------------
            string ruta = "D:\\tuts\\";
            string t,l;
            //-------------Nombre------------------------
            t = ruta + this.textBox1.Text + "_no.txt";
            if (System.IO.File.Exists(t)==true)
            {
                l = System.IO.File.ReadAllText(t,Encoding.UTF8);
                this.no_textBox2.Text = l;
            }
            //-------------Apellido------------------------
            t = ruta + this.textBox1.Text + "_ap.txt";
            if (System.IO.File.Exists(t) == true)
            {
                l = System.IO.File.ReadAllText(t, Encoding.UTF8);
                this.ap_textBox3.Text = l;
            }
            //-------------Texto------------------------
            t = ruta + this.textBox1.Text + "_tex.txt";
            if (System.IO.File.Exists(t) == true)
            {
                l = System.IO.File.ReadAllText(t, Encoding.UTF8);
                this.text_textBox4.Text = l;
            }
            //-------------Celular------------------------
            t = ruta + this.textBox1.Text + "_cel.txt";
            if (System.IO.File.Exists(t) == true)
            {
                l = System.IO.File.ReadAllText(t, Encoding.UTF8);
                this.cel_textBox5.Text = l;
            }
            //-------------Correo electronico------------------------
            t = ruta + this.textBox1.Text + "_corr.txt";
            if (System.IO.File.Exists(t) == true)
            {
                l = System.IO.File.ReadAllText(t, Encoding.UTF8);
                this.corr_textBox6.Text = l;
            }
            //-------------Dirección------------------------
            t = ruta + this.textBox1.Text + "_dir.txt";
            if (System.IO.File.Exists(t) == true)
            {
                l = System.IO.File.ReadAllText(t, Encoding.UTF8);
                this.dir_textBox7.Text = l;
            }
            //-------------Comentario------------------------
            t = ruta + this.textBox1.Text + "_con.txt";
            if (System.IO.File.Exists(t) == true)
            {
                l = System.IO.File.ReadAllText(t, Encoding.UTF8);
                this.com_textBox8.Text = l;
            }
            //------------Id------------------------------------
            this.id_textBox1.Text = this.textBox1.Text;
        }
    }
}
