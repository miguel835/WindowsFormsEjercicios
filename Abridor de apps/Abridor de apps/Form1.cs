using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abridor_de_apps
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Lógica para el botón Correr calculadora
        private void button1_Click(object sender, EventArgs e)
        {
            //string p = "C:\\Windows\\System32\\calc.exe";
            string p = this.textBox1.Text;
            this.process1.StartInfo.FileName = p;
            this.process1.Start();
        }
        //Lógica para el botón Correr blog de notas
        private void button2_Click(object sender, EventArgs e)
        {
            this.process1.StartInfo.FileName = "C:\\Windows\\System32\\notepad.exe";
            this.process1.Start();
        }
        //Lógica para el botón Correr paint
        private void button3_Click(object sender, EventArgs e)
        {
            this.process1.StartInfo.FileName = "C:\\Windows\\System32\\mspaint.exe";
            this.process1.Start();
        }
    }
}
