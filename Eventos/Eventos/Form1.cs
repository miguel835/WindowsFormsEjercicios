using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eventos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tu me presionaste");
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            MessageBox.Show("Me estas redimensionando");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("El formulario se está cargando");
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //MessageBox.Show($"Tu presionaste la tecla {e.KeyCode.ToString()}");
            //this.Text = e.KeyCode.ToString();

            //CUANDO EL USUARIO PRESIONE LA LETRA ESC SE CIERRE EL FORMULARIO
            if (e.KeyCode==Keys.Escape)
            {
                this.Close();
            }
            //CUANDO EL USUARIO PRESIONE F5 llamamos a otro evento
            if (e.KeyCode==Keys.F5)
            {
                button2_Click(sender, e);
            }
            //CUANDO EL USUARIO PRESIONE F4 CAMBIAMOS DE COLOR EL FORMULARIO
            if (e.KeyCode==Keys.F4)
            {
                this.BackColor = Color.GreenYellow;
            }
            if (e.KeyCode == Keys.F3)
            {
                this.BackColor = Color.White;
            }
            switch (e.KeyCode)
            {
                case Keys.F1:
                    MessageBox.Show("Has presionado la tecla F1");
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Datos guardados");
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            this.button3.BackColor = Color.Yellow;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            this.button3.BackColor = Color.Green;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(this.checkBox1.Checked.ToString());
            //if (this.checkBox1.Checked == true)
            //{
            //    MessageBox.Show("Tu me marcaste");
            //}
            //if (this.checkBox1.Checked == false)
            //{
            //    MessageBox.Show("Tu me desmarcaste");
            //}
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            if (this.checkBox1.Checked == true)
            {
                MessageBox.Show("Tu me marcaste");
            }
            if (this.checkBox1.Checked == false)
            {
                MessageBox.Show("Tu me desmarcaste");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.Text = this.textBox1.Text;
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            this.textBox1.BackColor = Color.Teal;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            this.textBox1.BackColor = Color.White;
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            this.textBox2.BackColor = Color.White;

        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            this.textBox2.BackColor = Color.Teal;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //this.textBox1.Text = this.comboBox1.SelectedIndex.ToString();
            //this.textBox2.Text = this.comboBox1.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (this.comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Selecciona primero tu elemento!!!");
                return; //return significa que no continues corriendo este código
                //y sal de este evento
            }
            this.textBox1.Text = this.comboBox1.SelectedIndex.ToString();
            this.textBox2.Text = this.comboBox1.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (this.listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Selecciona primero tu elemento!!!");
                return; //return significa que no continues corriendo este código
                //y sal de este evento
            }
            this.textBox1.Text = this.listBox1.SelectedIndex.ToString();
            this.textBox2.Text = this.listBox1.Text;
        }
    }
}
