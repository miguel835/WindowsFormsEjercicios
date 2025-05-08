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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Lógica para el botón Registro de datos en el control ToolStrip
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            var rg = new Reg_data();
            rg.MdiParent = this;
            rg.Show();
        }
        //Lógica para el botón Buscar en el control ToolStrip
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            var rg = new Search_Form();
            rg.MdiParent = this;
            rg.Show();
        }
        //Lógica para el botón Calculadora en el control ToolStrip
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.process1.StartInfo.FileName = "C:\\Windows\\System32\\calc.exe";
            this.process1.Start();
        }
        //Lógica para el botón Sobre nosotros en el control ToolStrip
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            var rg = new About_us();
            rg.MdiParent = this;
            rg.Show();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Atajos de teclados 
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F2:
                    toolStripButton1_Click(sender, e);
                    break;
                case Keys.F3:
                    toolStripButton2_Click(sender, e);
                    break;
                case Keys.F4:
                    toolStripButton3_Click(sender,e);
                    break;
                case Keys.F5:
                    toolStripButton4_Click(sender,e);
                    break;
                case Keys.Escape:
                    toolStripButton5_Click(sender,e);
                    break;
            }
        }
    }
}
