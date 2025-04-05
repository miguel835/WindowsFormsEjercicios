using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class AgregarLibro: Form
    {
        LibroDB libroDB = new LibroDB("localhost:5432", "postgres", "postgres", "el programador pragmatico");
        public AgregarLibro()
        {
            InitializeComponent();
        }
        //Lógica para boton Salir
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Lógica para el botón Guardar
        private void button1_Click(object sender, EventArgs e)
        {
            libroDB.AgregarPersonas(ObtenerData());
            this.Close();
        }
        public List<string> ObtenerData()
        {
            List<string> data = new List<string>
            {
                textBox1.Text,
                textBox2.Text,
                textBox3.Text,
                textBox4.Text
            };
            return data;
        }
    }
}
