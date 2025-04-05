/*Crear un programa que permita acceder a una tabla de una base de datos, para ingresar nuevos registros y para 
consultar los datos guardados.
Para realizar este proceso deberá crear una base de datos que almacene información sobre datos de libros de una
biblioteca, tales como nombre del libro, autor, editorial y año de publicación.
Además, se deberá crear el entorno grafico que permita la interacción de los usuarios con la información.
Dentro del código necesario para el acceso a la base de datos se solicita crear una clase que permita 
almacenar nueva información y para consultar la registrada en la base de datos. Esta clase deberá tener
los métodos que permitan almacenar nueva información y consultar información almacenada*/
using Npgsql;
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
    public partial class Form1: Form
    {
        LibroDB libroDB = new LibroDB("localhost:5432","postgres","postgres","el programador pragmatico");
        public Form1()
        {
            InitializeComponent();
        }
        //Evento Load
        private void Form1_Load(object sender, EventArgs e)
        {
            libroDB.CrearTabla();
        }
        //Lógica para botón Agregar libro
        private void button1_Click(object sender, EventArgs e)
        {
            AgregarLibro agregarLibro = new AgregarLibro();
            agregarLibro.ShowDialog();
        }
        //Lógica para el botón Salir
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Lógica para el botón Consultar libros
        private void button2_Click(object sender, EventArgs e)
        {
            libroDB.ConsultarPersonas(this.dataGridView1);
        }
  
    }
}
