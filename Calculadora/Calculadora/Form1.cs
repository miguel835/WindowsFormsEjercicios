using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Botón de borrar
        private void button20_Click(object sender, EventArgs e)
        {
            this.numero_principal_label1.ResetText();
        }
        //Botón número 0
        private void button2_Click(object sender, EventArgs e)
        {
            this.numero_principal_label1.Text += "0";
        }
        //Botón número 1
        private void button8_Click(object sender, EventArgs e)
        {
            this.numero_principal_label1.Text += "1";
        }
        //Botón número 2
        private void button7_Click(object sender, EventArgs e)
        {
            this.numero_principal_label1.Text += "2";
        }
        //Botón número 3
        private void button6_Click(object sender, EventArgs e)
        {
            this.numero_principal_label1.Text += "3";
        }
        //Botón número 4
        private void button12_Click(object sender, EventArgs e)
        {
            this.numero_principal_label1.Text += "4";
        }
        //Botón número 5
        private void button11_Click(object sender, EventArgs e)
        {
            this.numero_principal_label1.Text += "5";
        }
        //Botón número 6
        private void button10_Click(object sender, EventArgs e)
        {
            this.numero_principal_label1.Text += "6";
        }
        //Botón número 7
        private void button16_Click(object sender, EventArgs e)
        {
            this.numero_principal_label1.Text += "7";
        }
        //Botón número 8
        private void button15_Click(object sender, EventArgs e)
        {
            this.numero_principal_label1.Text += "8";
        }
        //Botón número 9
        private void button14_Click(object sender, EventArgs e)
        {
            this.numero_principal_label1.Text += "9";
        }
        //Botón ,
        private void button1_Click(object sender, EventArgs e)
        {
            this.numero_principal_label1.Text += ",";
        }
        //Botón operador +
        private void button5_Click(object sender, EventArgs e)
        {
            this.operador_label.Text = "+";
            if (this.numero_principal_label1.Text != "")
            {
                this.primer_numero_label.Text = this.numero_principal_label1.Text;
            }
            this.numero_principal_label1.ResetText();
        }
        //Botón operador -
        private void button9_Click(object sender, EventArgs e)
        {
            this.operador_label.Text = "-";
            if (this.numero_principal_label1.Text != "")
            {
                this.primer_numero_label.Text = this.numero_principal_label1.Text;
            }
            this.numero_principal_label1.ResetText();
        }
        //Botón operador *
        private void button13_Click(object sender, EventArgs e)
        {
            this.operador_label.Text = "*";
            if (this.numero_principal_label1.Text != "")
            {
                this.primer_numero_label.Text = this.numero_principal_label1.Text;
            }
            this.numero_principal_label1.ResetText();
        }
        //Botón operador /
        private void button17_Click(object sender, EventArgs e)
        {
            this.operador_label.Text = "/";
            if (this.numero_principal_label1.Text != "")
            {
                this.primer_numero_label.Text = this.numero_principal_label1.Text;
            }
            this.numero_principal_label1.ResetText();
        }
        //Botón operador =
        private void button4_Click(object sender, EventArgs e)
        {
            decimal primerNumero;
            decimal segundoNumero;
            decimal resultado = 0;
            decimal.TryParse(this.primer_numero_label.Text, out primerNumero);
            decimal.TryParse(this.numero_principal_label1.Text, out segundoNumero);
            if (this.operador_label.Text == "+")
            {
                resultado = primerNumero + segundoNumero;
            }
            if (this.operador_label.Text == "-")
            {
                resultado = primerNumero - segundoNumero;
            }
            if (this.operador_label.Text == "*")
            {
                resultado = primerNumero * segundoNumero;
            }
            if (this.operador_label.Text == "/")
            {
                resultado = primerNumero / segundoNumero;
            }
            this.numero_principal_label1.Text = resultado.ToString();
            this.primer_numero_label.ResetText();
            this.operador_label.ResetText();
        }
        //-----------------------------------------------------------------//
        //                        Eventos de la calculadora                //
        //-----------------------------------------------------------------//
        private void button4_MouseHover(object sender, EventArgs e)
        {
            button4.BackColor = Color.CadetBlue;
        }
        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackColor = Color.White;
        }
        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.BackColor = Color.CadetBlue;
        }
        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.White;
        }
        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.CadetBlue;
        }
        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;
        }
        private void button5_MouseHover(object sender, EventArgs e)
        {
            button5.BackColor = Color.CadetBlue;
        }
        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.BackColor = Color.White;
        }
        private void button6_MouseHover(object sender, EventArgs e)
        {
            button6.BackColor = Color.CadetBlue;
        }
        private void button6_MouseLeave(object sender, EventArgs e)
        {
            button6.BackColor = Color.White;
        }
        private void button7_MouseHover(object sender, EventArgs e)
        {
            button7.BackColor = Color.CadetBlue;
        }
        private void button7_MouseLeave(object sender, EventArgs e)
        {
            button7.BackColor = Color.White;
        }
        private void button8_MouseHover(object sender, EventArgs e)
        {
            button8.BackColor = Color.CadetBlue;
        }
        private void button8_MouseLeave(object sender, EventArgs e)
        {
            button8.BackColor = Color.White;
        }
        private void button9_MouseHover(object sender, EventArgs e)
        {
            button9.BackColor = Color.CadetBlue;
        }
        private void button9_MouseLeave(object sender, EventArgs e)
        {
            button9.BackColor = Color.White;
        }
        private void button10_MouseHover(object sender, EventArgs e)
        {
            button10.BackColor = Color.CadetBlue;
        }
        private void button10_MouseLeave(object sender, EventArgs e)
        {
            button10.BackColor = Color.White;
        }
        private void button11_MouseHover(object sender, EventArgs e)
        {
            button11.BackColor = Color.CadetBlue;
        }
        private void button11_MouseLeave(object sender, EventArgs e)
        {
            button11.BackColor = Color.White;
        }
        private void button12_MouseHover(object sender, EventArgs e)
        {
            button12.BackColor = Color.CadetBlue;
        }
        private void button12_MouseLeave(object sender, EventArgs e)
        {
            button12.BackColor = Color.White;
        }
        private void button13_MouseHover(object sender, EventArgs e)
        {
            button13.BackColor = Color.CadetBlue;
        }
        private void button13_MouseLeave(object sender, EventArgs e)
        {
            button13.BackColor = Color.White;
        }
        private void button14_MouseHover(object sender, EventArgs e)
        {
            button14.BackColor = Color.CadetBlue;
        }
        private void button14_MouseLeave(object sender, EventArgs e)
        {
            button14.BackColor = Color.White;
        }
        private void button15_MouseHover(object sender, EventArgs e)
        {
            button15.BackColor = Color.CadetBlue;
        }
        private void button15_MouseLeave(object sender, EventArgs e)
        {
            button15.BackColor = Color.White;
        }
        private void button16_MouseHover(object sender, EventArgs e)
        {
            button16.BackColor = Color.CadetBlue;
        }
        private void button16_MouseLeave(object sender, EventArgs e)
        {
            button16.BackColor = Color.White;
        }
        private void button17_MouseHover(object sender, EventArgs e)
        {
            button17.BackColor = Color.CadetBlue;
        }
        private void button17_MouseLeave(object sender, EventArgs e)
        {
            button17.BackColor = Color.White;
        }
        private void button20_MouseHover(object sender, EventArgs e)
        {
            button20.BackColor = Color.CadetBlue;
        }
        private void button20_MouseLeave(object sender, EventArgs e)
        {
            button20.BackColor = Color.White;
        }
    }
}