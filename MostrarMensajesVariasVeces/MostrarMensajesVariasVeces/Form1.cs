using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MostrarMensajesVariasVeces
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Int32 i;
            for (i = 0; i < 30; i++)
            {
                MessageBox.Show("Yo soy un bucle for: mi numero es " + i.ToString());
            }
        }
    }
}
