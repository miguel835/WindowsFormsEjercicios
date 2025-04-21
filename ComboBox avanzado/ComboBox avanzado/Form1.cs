using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBox_avanzado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string t = this.textBox1.Text;
            if (t == string.Empty)
            {
                MessageBox.Show("Ingresa un elemento a añadir");
                return;
            }
            this.comboBox1.Items.Add(t);
            this.label4.Text = this.comboBox1.Items.Count.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.comboBox1.Items.RemoveAt(this.comboBox1.SelectedIndex);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.label2.Text = this.comboBox1.SelectedIndex.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Esta acción es peligrosa desea continuar","",MessageBoxButtons.YesNo);
            if (resultado == DialogResult.No)
            {
                return;
            }
            this.comboBox1.Items.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.label4.Text = this.comboBox1.Items.Count.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Int32 index = this.comboBox2.FindStringExact(this.textBox2.Text);
            if (index == -1)
            {
                MessageBox.Show("Dato no encontrado");
            }
            else
            {
                this.comboBox2.SelectedIndex = index;
            }
        }
    }
}