using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodigoDeColoresDeLasResistencias
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }
        //Evento Load 
        private void SplashScreen_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        //Evento Tick del control timer 
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100) {
                progressBar1.Value += 1;
                label3.Text = progressBar1.Value.ToString() + "%";
            }
            else
            {
                timer1.Stop();
                this.Hide();
                Form1 ProgramaPrincipal = new Form1();
                ProgramaPrincipal.Show();
            }
        }
    }
}