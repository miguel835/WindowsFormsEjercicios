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
    public partial class Form1 : Form
    {
        //Creamos objetos de la clase Resistor
        private Resistor resistor3Bandas;
        private Resistor resistor4Bandas;
        private Resistor resistor5Bandas;
        private Resistor resistor6Bandas;
        public Form1()
        {
            InitializeComponent();
        }
        //Evento FormClosing
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        //Evento Load del formulario
        private void Form1_Load(object sender, EventArgs e)
        {
            // Inicializamos los objetos tipo Resistor
            resistor3Bandas = new Resistor(0,0,0);
            resistor4Bandas = new Resistor(0,0,0,0); 
            resistor5Bandas = new Resistor(0,0,0,0,0);
            resistor6Bandas = new Resistor(0,0,0,0,0,0);
            comboBox5.SelectedIndex = comboBox6.SelectedIndex = comboBox7.SelectedIndex = 0;
            comboBox1.SelectedIndex = comboBox2.SelectedIndex = comboBox3.SelectedIndex = comboBox4.SelectedIndex = 0;
            comboBox8.SelectedIndex = comboBox9.SelectedIndex = comboBox10.SelectedIndex = comboBox11.SelectedIndex = comboBox12.SelectedIndex = 0;
            comboBox13.SelectedIndex = comboBox14.SelectedIndex = comboBox15.SelectedIndex = comboBox16.SelectedIndex = comboBox17.SelectedIndex = comboBox18.SelectedIndex = 0;
            ActualizarEtiquetasResistencias(); 
        }
        private void ActualizarEtiquetasResistencias()
        {
            label39.Text = resistor3Bandas.CalculoDeValores();
            label24.Text = resistor4Bandas.CalculoDeValores();
            label40.Text = resistor5Bandas.CalculoDeValores();
            label38.Text = resistor6Bandas.CalculoDeValores();
        }
        //**********************************************************************//
        //                      Eventos para dibujar                            //
        //**********************************************************************//
        //Evento Paint para el control Panel para el resistor de 3 bandas 
        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            //Dibujamos el resistor
            resistor3Bandas.DibujarResistor(e.Graphics);
            // Dibujamos las bandas
            Graphics g = e.Graphics;
            g.FillRectangle(resistor3Bandas.ObtenerBrochaParaBandaPrincipales(resistor3Bandas.Banda1), 280, 100, 15, 100);
            g.FillRectangle(resistor3Bandas.ObtenerBrochaParaBandaPrincipales(resistor3Bandas.Banda2), 350, 100, 15, 100);
            g.FillRectangle(resistor3Bandas.ObtenerBrochaParaBandaPrincipales(resistor3Bandas.Banda3), 420, 100, 15, 100);
        }
        //Evento Paint para el control Panel para el resistor de 4 bandas 
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //Dibujamos el resistor 
            resistor4Bandas.DibujarResistor(e.Graphics); 
            // Dibuja las bandas
            Graphics g = e.Graphics;
            g.FillRectangle(resistor4Bandas.ObtenerBrochaParaBandaPrincipales(resistor4Bandas.Banda1), 280, 100, 15, 100);
            g.FillRectangle(resistor4Bandas.ObtenerBrochaParaBandaPrincipales(resistor4Bandas.Banda2), 350, 100, 15, 100);
            g.FillRectangle(resistor4Bandas.ObtenerBrochaParaBandaPrincipales(resistor4Bandas.Banda3), 420, 100, 15, 100);
            g.FillRectangle(resistor4Bandas.ObtenerBrochaParaBandaTolerancia(resistor4Bandas.Banda4), 490, 100, 15, 100);
        }
        //Evento Paint para el control Panel para el resistor de 5 bandas 
        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            //Dibujamos el resistor 
            resistor4Bandas.DibujarResistor(e.Graphics);
            //Dibujamos las bandas
            Graphics g = e.Graphics;
            g.FillRectangle(resistor5Bandas.ObtenerBrochaParaBandaPrincipales(resistor5Bandas.Banda1), 260, 100, 15, 100);
            g.FillRectangle(resistor5Bandas.ObtenerBrochaParaBandaPrincipales(resistor5Bandas.Banda2), 320, 100, 15, 100);
            g.FillRectangle(resistor5Bandas.ObtenerBrochaParaBandaPrincipales(resistor5Bandas.Banda3), 380, 100, 15, 100);
            g.FillRectangle(resistor5Bandas.ObtenerBrochaParaBandaPrincipales(resistor5Bandas.Banda4), 440, 100, 15, 100);
            g.FillRectangle(resistor5Bandas.ObtenerBrochaParaBandaTolerancia(resistor5Bandas.Banda5), 500, 100, 15, 100);
        }
        //Evento Paint para el control Panel para el resistor de 6 bandas 
        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            //Dibujamos el resistor
            resistor6Bandas.DibujarResistor(e.Graphics); 
            //Dibujamos las bandas
            Graphics g = e.Graphics;
            g.FillRectangle(resistor6Bandas.ObtenerBrochaParaBandaPrincipales(resistor6Bandas.Banda1), 250, 100, 15, 100);
            g.FillRectangle(resistor6Bandas.ObtenerBrochaParaBandaPrincipales(resistor6Bandas.Banda2), 300, 100, 15, 100);
            g.FillRectangle(resistor6Bandas.ObtenerBrochaParaBandaPrincipales(resistor6Bandas.Banda3), 350, 100, 15, 100);
            g.FillRectangle(resistor6Bandas.ObtenerBrochaParaBandaPrincipales(resistor6Bandas.Banda4), 400, 100, 15, 100);
            g.FillRectangle(resistor6Bandas.ObtenerBrochaParaBandaTolerancia(resistor6Bandas.Banda5), 450, 100, 15, 100);
            g.FillRectangle(resistor6Bandas.ObtenerBrochaParaBandaTemperatura(resistor6Bandas.Banda6), 500, 100, 15, 100);
        }
        //*****************************************************************************//
        //                   Eventos para los resistores de 3 bandas                    //
        //*****************************************************************************//
        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            resistor3Bandas.Banda1 = comboBox7.SelectedIndex;
            ActualizarEtiquetasResistencias();
            panel2.Invalidate();
        }
        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            resistor3Bandas.Banda2 = comboBox6.SelectedIndex;
            ActualizarEtiquetasResistencias();
            panel2.Invalidate();
        }
        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            resistor3Bandas.Banda3 = comboBox5.SelectedIndex;
            ActualizarEtiquetasResistencias();
            panel2.Invalidate();
        }
        //*****************************************************************************//
        //                   Eventos para los resistores de 4 bandas                    //
        //*****************************************************************************//
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            resistor4Bandas.Banda1 = comboBox1.SelectedIndex;
            ActualizarEtiquetasResistencias();
            panel1.Invalidate();
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            resistor4Bandas.Banda2 = comboBox2.SelectedIndex;
            ActualizarEtiquetasResistencias();
            panel1.Invalidate();
        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            resistor4Bandas.Banda3 = comboBox3.SelectedIndex;
            ActualizarEtiquetasResistencias();
            panel1.Invalidate();
        }
        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            resistor4Bandas.Banda4 = comboBox4.SelectedIndex;
            ActualizarEtiquetasResistencias();
            panel1.Invalidate();
        }
        //*****************************************************************************//
        //                   Eventos para los resistores de 5 bandas                    //
        //*****************************************************************************//
        private void comboBox11_SelectedIndexChanged(object sender, EventArgs e)
        {
            resistor5Bandas.Banda1 = comboBox11.SelectedIndex;
            ActualizarEtiquetasResistencias();
            panel3.Invalidate();
        }
        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {
            resistor5Bandas.Banda2 = comboBox10.SelectedIndex;
            ActualizarEtiquetasResistencias();
            panel3.Invalidate();
        }
        private void comboBox12_SelectedIndexChanged(object sender, EventArgs e)
        {
            resistor5Bandas.Banda3 = comboBox12.SelectedIndex;
            ActualizarEtiquetasResistencias();
            panel3.Invalidate();
        }
        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            resistor5Bandas.Banda4 = comboBox9.SelectedIndex;
            ActualizarEtiquetasResistencias();
            panel3.Invalidate();
        }
        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            resistor5Bandas.Banda5 = comboBox8.SelectedIndex;
            ActualizarEtiquetasResistencias();
            panel3.Invalidate();
        }
        //*****************************************************************************//
        //                   Eventos para los resistores de 6 bandas                    //
        //*****************************************************************************//
        private void comboBox17_SelectedIndexChanged(object sender, EventArgs e)
        {
            resistor6Bandas.Banda1 = comboBox17.SelectedIndex;
            ActualizarEtiquetasResistencias();
            panel4.Invalidate();
        }
        private void comboBox16_SelectedIndexChanged(object sender, EventArgs e)
        {
            resistor6Bandas.Banda2 = comboBox16.SelectedIndex;
            ActualizarEtiquetasResistencias();
            panel4.Invalidate();
        }
        private void comboBox13_SelectedIndexChanged(object sender, EventArgs e)
        {
            resistor6Bandas.Banda3 = comboBox13.SelectedIndex;
            ActualizarEtiquetasResistencias();
            panel4.Invalidate();
        }
        private void comboBox15_SelectedIndexChanged(object sender, EventArgs e)
        {
            resistor6Bandas.Banda4 = comboBox15.SelectedIndex;
            ActualizarEtiquetasResistencias();
            panel4.Invalidate();
        }
        private void comboBox14_SelectedIndexChanged(object sender, EventArgs e)
        {
            resistor6Bandas.Banda5 = comboBox14.SelectedIndex;
            ActualizarEtiquetasResistencias();
            panel4.Invalidate();
        }
        private void comboBox18_SelectedIndexChanged(object sender, EventArgs e)
        {
            resistor6Bandas.Banda6 = comboBox18.SelectedIndex;
            ActualizarEtiquetasResistencias();
            panel4.Invalidate();
        }
    }
}
