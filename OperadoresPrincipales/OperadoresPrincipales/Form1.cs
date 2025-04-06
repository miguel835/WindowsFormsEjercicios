using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OperadoresPrincipales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Lógica para el botón Sumar
        private void button1_Click(object sender, EventArgs e)
        {
            Int32.TryParse(this.textBox1.Text, out Int32 primerNumero);
            Int32.TryParse(this.textBox2.Text, out Int32 segundoNumero);
            Int32 resultado = primerNumero + segundoNumero;
            textBox3.Text = resultado.ToString();
        }
        //Lógica para el botón Restar
        private void button2_Click(object sender, EventArgs e)
        {
            Int32.TryParse(this.textBox1.Text, out Int32 primerNumero);
            Int32.TryParse(this.textBox2.Text, out Int32 segundoNumero);
            Int32 resultado = primerNumero - segundoNumero;
            textBox3.Text = resultado.ToString();
        }
        //Lógica para el botón Multiplicar
        private void button3_Click(object sender, EventArgs e)
        {
            Int32.TryParse(this.textBox1.Text, out Int32 primerNumero);
            Int32.TryParse(this.textBox2.Text, out Int32 segundoNumero);
            Int32 resultado = primerNumero * segundoNumero;
            textBox3.Text = resultado.ToString();
        }
        //Lógica para el botón Dividir
        private void button4_Click(object sender, EventArgs e)
        {
            float.TryParse(this.textBox1.Text, out float primerNumero);
            float.TryParse(this.textBox2.Text, out float segundoNumero);
            float resultado = primerNumero / segundoNumero;
            textBox3.Text = resultado.ToString();
        }
        //Lógica para el botón ¿Es el primer número mayor?
        private void button5_Click(object sender, EventArgs e)
        {
            float.TryParse(this.textBox5.Text, out float primerNumero);
            float.TryParse(this.textBox4.Text, out float segundoNumero);
            if (primerNumero > segundoNumero)
            {
                MessageBox.Show("El primer número es mayor");
            }
            if (primerNumero == segundoNumero)
            {
                MessageBox.Show("Los números son iguales");
            }
            else
            {
                MessageBox.Show("El segundo número es mayor");
            }
        }
        //lógica para el botón ¿El primer número es igual al segundo número?
        private void button6_Click(object sender, EventArgs e)
        {
            float.TryParse(this.textBox5.Text, out float primerNumero);
            float.TryParse(this.textBox4.Text, out float segundoNumero);
            if(primerNumero == segundoNumero)
            {
                MessageBox.Show("Son iguales");
            }
            else
            {
                MessageBox.Show("No son iguales");
            }
        }
    }
}
