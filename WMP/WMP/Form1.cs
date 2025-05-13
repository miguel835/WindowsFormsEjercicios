using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WMP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Lógica para el botón Cargar 
        private void button1_Click(object sender, EventArgs e)
        {
            //Evitamos que se reproduzca automaticamente 
            axWindowsMediaPlayer1.settings.autoStart = false;
            //Cargamos un archivo para reproducirlo 
            this.axWindowsMediaPlayer1.URL = "D:\\tuts\\Joan Sebastian  Ojitos De Golondrina  Letra.mp3";
        
        }
        //Lógica para el botón Reproducir 
        private void button2_Click(object sender, EventArgs e)
        {
            this.axWindowsMediaPlayer1.Ctlcontrols.play();
        }
        //Lógica para el botón Parar
        private void button3_Click(object sender, EventArgs e)
        {
            this.axWindowsMediaPlayer1.Ctlcontrols.pause();
        }
        //Lógica para el botón Detener 
        private void button4_Click(object sender, EventArgs e)
        {
            this.axWindowsMediaPlayer1.Ctlcontrols.stop();
        }
    }
}
