using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AñadirElementosAUnComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Lógica para el botón Añadir elementos
        private void button1_Click(object sender, EventArgs e)
        {
            Int32 k;
            for (k = 0; k < 10; k++)
            {
                this.comboBox1.Items.Add(12);
            }
        }
    }
}
