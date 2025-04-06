using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumerosMeses
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Lógica para el botón Mostrar nombre
        private void button1_Click(object sender, EventArgs e)
        {
            Int32 nombreMes;
            Int32.TryParse(this.textBox1.Text, out nombreMes);
            string nombre = "Desconocido";
            switch (nombreMes)
            {
                case 1:
                    nombre = "Enero";
                    break;
                case 2:
                    nombre = "Febrero";
                    break;
                case 3:
                    nombre = "Marzo";
                    break;
                case 4:
                    nombre = "Abril";
                    break;
                case 5:
                    nombre = "Mayo";
                    break;
                case 6:
                    nombre = "Junio";
                    break;
                case 7:
                    nombre = "Julio";
                    break;
                case 8:
                    nombre = "Agosto";
                    break;
                case 9:
                    nombre = "Septiembre";
                    break;
                case 10:
                    nombre = "Octubre";
                    break;
                case 11:
                    nombre = "Noviembre";
                    break;
                case 12:
                    nombre = "Diciembre";
                    break;
            }
            label2.Text = "Nombre del mes es: " + nombre;
        }
        //Lógica para el botón Mostrar número de mes
        private void button2_Click(object sender, EventArgs e)
        {
            string numberMonth = this.textBox2.Text;
            string month_num;
            switch (numberMonth)
            {
                case "Enero":
                    month_num = "1";
                    break;
                case "Febrero":
                    month_num = "2";
                    break;
                case "Marzo":
                    month_num = "3";
                    break;
                case "Abril":
                    month_num = "4";
                    break;
                case "Mayo":
                    month_num = "5";
                    break;
                case "Junio":
                    month_num = "6";
                    break;
                case "Julio":
                    month_num = "7";
                    break;
                case "Agosto":
                    month_num = "8";
                    break;
                case "Septiembre":
                    month_num = "9";
                    break;
                case "Octubre":
                    month_num = "10";
                    break;
                case "Noviembre":
                    month_num = "11";
                    break;
                case "Diciembre":
                    month_num = "12";
                    break;
                default:
                    month_num = "No valido";
                    break;
            }
            label3.Text = $"El numero del mes es: {month_num}";
        }
    }
}
