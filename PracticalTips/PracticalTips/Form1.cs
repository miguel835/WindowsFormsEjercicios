using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticalTips
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = Application.StartupPath;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string fn;
            fn = Application.StartupPath + "\\calc.exe";
            this.process1.StartInfo.FileName = fn;
            if(System.IO.File.Exists(fn) == true)
            {
                this.process1.Start();
            }
            else
            {
                MessageBox.Show("No se pudo encontrar la calculadora");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string fn;
            fn = Application.StartupPath + "\\data\\pro\\calc.exe";
            this.process1.StartInfo.FileName = fn;
            if (System.IO.File.Exists(fn) == true)
            {
                this.process1.Start();
            }
            else
            {
                MessageBox.Show("No se pudo encontrar la calculadora");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string fn;
            fn = Application.StartupPath + "\\data\\pics\\fox.jpeg";
            this.pictureBox1.Image = Image.FromFile(fn);

        }
    }
}
