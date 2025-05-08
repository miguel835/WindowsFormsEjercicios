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
    public partial class Reg_data : Form
    {
        public Reg_data()
        {
            InitializeComponent();
        }
        //Lógica para el evento Click del botón Nuevo dato
        private void newButton_Click(object sender, EventArgs e)
        {
            this.newButton.Enabled = false;
            this.saveButton.Enabled = true;
            //------------------------------
            this.Info_gbox.Enabled = true;
            //--------Limpiar Textboxs------
            this.id_textBox1.ResetText();
            this.no_textBox2.ResetText();
            this.ap_textBox3.ResetText();
            this.text_textBox4.ResetText();
            this.cel_textBox5.ResetText();
            this.corr_textBox6.ResetText();
            this.dir_textBox7.ResetText();
            this.com_textBox8.ResetText();
            //------------------------------

        }
        //Lógica para el evento Click del botón Guardar cambios 
        private void saveButton_Click(object sender, EventArgs e)
        {
            if (this.id_textBox1.Text == "")
            {
                MessageBox.Show("Debes ingresar el ID");
                return;
            }
            this.newButton.Enabled = true;
            this.saveButton.Enabled = false;
            //--------------------------------
            this.Info_gbox.Enabled = false;
            //-------------------------------
            string ruta = "D:\\tuts\\";
            string t;
            //-------Nombre------------------
            t = ruta + this.id_textBox1.Text + "_no.txt";
            System.IO.File.WriteAllText(t,this.no_textBox2.Text, Encoding.UTF8);
            //-------Apellido----------------
            t = ruta + this.id_textBox1.Text + "_ap.txt";
            System.IO.File.WriteAllText(t, this.ap_textBox3.Text, Encoding.UTF8);
            //-------Texto----------------
            t = ruta + this.id_textBox1.Text + "_tex.txt";
            System.IO.File.WriteAllText(t, this.text_textBox4.Text, Encoding.UTF8);
            //-----Celular---------------
            t = ruta + this.id_textBox1.Text + "_cel.txt";
            System.IO.File.WriteAllText(t, this.cel_textBox5.Text, Encoding.UTF8);
            //-----Correo electrónico----------------
            t = ruta + this.id_textBox1.Text + "_corr.txt";
            System.IO.File.WriteAllText(t, this.corr_textBox6.Text, Encoding.UTF8);
            //-------Dirección----------------
            t = ruta + this.id_textBox1.Text + "_dir.txt";
            System.IO.File.WriteAllText(t, this.dir_textBox7.Text, Encoding.UTF8);
            //------Comentario---------------
            t = ruta + this.id_textBox1.Text + "_con.txt";
            System.IO.File.WriteAllText(t, this.com_textBox8.Text, Encoding.UTF8);
            MessageBox.Show("Data guardada");
        }
        //Evento Load del formulario
        private void Reg_data_Load(object sender, EventArgs e)
        {
            this.Info_gbox.Enabled = false;
        }
    }
}
