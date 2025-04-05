using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EdadUserBasadoEnFechaNacimiento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Lógica para el botón calcular edad
        private void button1_Click(object sender, EventArgs e)
        {
            Int32 añoNacimientoUsuario;
            Int32.TryParse(this.textBox1.Text,out añoNacimientoUsuario);
            Int32 edad;
            Int32 añoActual;
            añoActual = DateTime.Now.Year;
            edad = añoActual - añoNacimientoUsuario;
            //MessageBox.Show(edad.ToString());
            if (edad > 30)
            {
                MessageBox.Show("Eres de mediana edad");
            }
            if (edad < 30)
            {
                MessageBox.Show("Eres joven");
            }
            if (edad == 30)
            {
                MessageBox.Show("Yo no se quien eres tu!!!!");
            }
            //else
            //{
            //    MessageBox.Show("Eres joven");
            //}
        }
    }
}
