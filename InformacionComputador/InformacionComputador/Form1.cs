/* Crear un programa que permita almacenar la información de un computador. 
El entorno gráfico deberá tener opciones para registrar las partes principales del computador: 
monitor, memoria RAM, Disco duro y procesador. 
Cada parte debe tener sus propiedades específicas. 
El usuario debe poder ingresar o editar las propiedades de cada parte y del computador.
Crear clases usando composición que gestionen estas propiedades.
El entorno gráfico debe ser amigable con el usuario.
Usar controles contenedores para diferenciar entre una parte u otra del computador.*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InformacionComputador
{
    public partial class Form1 : Form
    {
        //Creamos objetos de las clases
        public Computador computador;
        public Monitor monitor;
        public MemoriaRam memoriaRam;
        public DiscoDuro discoDuro;
        public Procesador procesador;
        public Form1()
        {
            InitializeComponent();
        }
        //Lógica para el botón salir
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Evento Load
        private void Form1_Load(object sender, EventArgs e)
        {
            //Inicializamos los objetos
            computador = new Computador();
            monitor = new Monitor();
            memoriaRam = new MemoriaRam();
            discoDuro = new DiscoDuro();
            procesador = new Procesador();
            //Hacemos invisibles los labels al iniciar el programa
            label31.Visible = label32.Visible = label33.Visible = label34.Visible = false;
            label35.Visible = label36.Visible = label37.Visible = label38.Visible = false;
            label39.Visible = label40.Visible = label41.Visible = label42.Visible = false;
            label43.Visible = label44.Visible = label45.Visible = label46.Visible = false;
            label47.Visible = label48.Visible = label49.Visible = label50.Visible = false;
            //Desabilitamos el botón 3 
            button3.Enabled = false;
        }
        //Lógica para el botón de Guardar
        private void button2_Click(object sender, EventArgs e)
        {
            //Almacenamos los datos en los labels 
            computador.Marca = label31.Text = textBox1.Text;
            computador.Modelo = label32.Text = textBox2.Text;
            computador.OS = label33.Text = textBox4.Text;
            computador.Precio = label34.Text = textBox3.Text;
            monitor.tamañoDePantalla = label35.Text = textBox8.Text;
            monitor.resolucion = label36.Text = textBox7.Text;
            monitor.tasaDeRefresco = label37.Text = textBox5.Text;
            monitor.brillo = label38.Text = textBox6.Text;
            discoDuro.capacidad = label39.Text = textBox12.Text;
            discoDuro.interfaz = label40.Text = textBox11.Text;
            discoDuro.velocidadDeLectura = label41.Text = textBox9.Text;
            discoDuro.velocidadDeEscritura = label42.Text = textBox10.Text;
            memoriaRam.capacidad = label43.Text = textBox16.Text;
            memoriaRam.tipo = label44.Text = textBox15.Text;
            memoriaRam.velocidad = label45.Text = textBox13.Text;
            memoriaRam.voltaje = label46.Text = textBox14.Text;
            procesador.Marca = label47.Text = textBox20.Text;
            procesador.Modelo = label48.Text = textBox19.Text;
            procesador.NumeroDeNucleos = label49.Text = textBox17.Text;
            procesador.NumeroDeHilos = label50.Text = textBox18.Text;
            //Hacemos invisibles los labels
            textBox1.Visible = textBox2.Visible = textBox4.Visible = textBox3.Visible = false;
            textBox8.Visible = textBox7.Visible = textBox5.Visible = textBox6.Visible = false;
            textBox12.Visible = textBox11.Visible = textBox9.Visible = textBox10.Visible = false;
            textBox16.Visible = textBox15.Visible = textBox13.Visible = textBox14.Visible = false;
            textBox20.Visible = textBox19.Visible = textBox17.Visible = textBox18.Visible = false;
            //Hacemos visibles los labels 
            label31.Visible = label32.Visible = label33.Visible = label34.Visible = true;
            label35.Visible = label36.Visible = label37.Visible = label38.Visible = true;
            label39.Visible = label40.Visible = label41.Visible = label42.Visible = true;
            label43.Visible = label44.Visible = label45.Visible = label46.Visible = true;
            label47.Visible = label48.Visible = label49.Visible = label50.Visible = true;
            //Habilitamos el botón de Editar
            button3.Enabled = true;
            //Desabilitamos el botón de Guardar 
            button2.Enabled = false;
        }
        //Lógica para el botón de Editar
        private void button3_Click(object sender, EventArgs e)
        {
            //Mostramos los datos al usuario para que pueda editarlos 
            computador.Marca = textBox1.Text = label31.Text;
            computador.Modelo = textBox2.Text = label32.Text;
            computador.OS = textBox4.Text = label33.Text;
            computador.Precio = textBox3.Text = label34.Text;
            monitor.tamañoDePantalla = textBox8.Text = label35.Text;
            monitor.resolucion = textBox7.Text = label36.Text;
            monitor.tasaDeRefresco = textBox5.Text = label37.Text;
            monitor.brillo = textBox6.Text = label38.Text;
            discoDuro.capacidad = textBox12.Text = label39.Text;
            discoDuro.interfaz = textBox11.Text = label40.Text;
            discoDuro.velocidadDeLectura = textBox9.Text = label41.Text;
            discoDuro.velocidadDeEscritura = textBox10.Text = label42.Text;
            memoriaRam.capacidad = textBox16.Text = label43.Text;
            memoriaRam.tipo = textBox15.Text = label44.Text;
            memoriaRam.velocidad = textBox13.Text = label45.Text;
            memoriaRam.voltaje = textBox14.Text = label46.Text;
            procesador.Marca = textBox20.Text = label47.Text;
            procesador.Modelo = textBox19.Text = label48.Text;
            procesador.NumeroDeNucleos = textBox17.Text = label49.Text;
            procesador.NumeroDeHilos = textBox18.Text = label50.Text;
            //Hacemos invisibles los labels
            label31.Visible = label32.Visible = label33.Visible = label34.Visible = false;
            label35.Visible = label36.Visible = label37.Visible = label38.Visible = false;
            label39.Visible = label40.Visible = label41.Visible = label42.Visible = false;
            label43.Visible = label44.Visible = label45.Visible = label46.Visible = false;
            label47.Visible = label48.Visible = label49.Visible = label50.Visible = false;
            //Hacemos visibles los textBox
            textBox1.Visible = textBox2.Visible = textBox4.Visible = textBox3.Visible = true;
            textBox8.Visible = textBox7.Visible = textBox5.Visible = textBox6.Visible = true;
            textBox12.Visible = textBox11.Visible = textBox9.Visible = textBox10.Visible = true;
            textBox16.Visible = textBox15.Visible = textBox13.Visible = textBox14.Visible = true;
            textBox20.Visible = textBox19.Visible = textBox17.Visible = textBox18.Visible = true;
            //Desabilitamos el botón de Editar
            button3.Enabled = false;
            //Habilitamos el botón de Guardar
            button2.Enabled = true;
        }
    }
}
