using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDI_proyecto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Instanciamos el formulario Backup
            Backup backup = new Backup();
            backup.MdiParent = this;
            backup.BackColor = Color.Tomato;
            backup.ShowIcon = false;
            backup.MinimizeBox = false;
            backup.MaximizeBox = false;
            //----------------------------------
            backup.version_label2.Text = "2000";
            backup.version_label2.BackColor = Color.Chocolate;
            //----------------------------------
            backup.Show(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Configuraciones configuraciones = new Configuraciones();
            configuraciones.MdiParent = this;
            configuraciones.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Backup backup = new Backup();
            //backup.MdiParent = this;
            backup.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Configuraciones configuraciones = new Configuraciones();
            //configuraciones.MdiParent = this;
            configuraciones.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MDI_proyecto.my_forms.test_form test_Form = new MDI_proyecto.my_forms.test_form();
            test_Form.MdiParent = this;
            test_Form.Show();
        }
    }
}
