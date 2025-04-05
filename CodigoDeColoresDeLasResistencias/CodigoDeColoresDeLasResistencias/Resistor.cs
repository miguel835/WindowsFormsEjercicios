using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodigoDeColoresDeLasResistencias
{
    public class Resistor
    {
        //Atributos
        private static readonly Dictionary<int, Color> ColoresDeBandasPrincipales = new Dictionary<int, Color>()
        {
            { 0, Color.Black },
            { 1, Color.Brown },
            { 2, Color.Red },
            { 3, Color.Orange },
            { 4, Color.Yellow },
            { 5, Color.Green },
            { 6, Color.Blue },
            { 7, Color.DarkViolet },
            { 8, Color.Gray },
            { 9, Color.White },
            { 10, Color.Gold },
            { 11, Color.Silver }
        };
        private static readonly Dictionary<int, Color> ColoresDeTolerancia = new Dictionary<int, Color>()
        {
            { 0, Color.Brown },
            { 1, Color.Red },
            { 2, Color.Green },
            { 3, Color.Blue },
            { 4, Color.DarkViolet },
            { 5, Color.Gray },
            { 6, Color.Gold },
            { 7, Color.Silver }
        };
        private static readonly Dictionary<int, Color> ColoresDeTemperatura = new Dictionary<int, Color>()
        {
            { 0, Color.Black },
            { 1, Color.Brown },
            { 2, Color.Red },
            { 3, Color.Orange },
            { 4, Color.Yellow },
            { 5, Color.Green },
            { 6, Color.Blue },
            { 7, Color.DarkViolet },
            { 8, Color.Gray }
        };
        private static readonly double[] _valoresMultiplicador = { 1, 10, 100, 1000, 10000, 100000, 1000000, 10000000, 100000000, 1000000000, 0.1, 0.01 };
        private static string[] _tolerancia = { "1", "2", "0.5", "0.25", "0.1", "0.05", "5", "10" };
        private static string[] _temperatura = { "250", "100", "50", "15", "25", "20", "10", "5", "1" };
        //Propiedades
        public int Banda1 { get; set; }
        public int Banda2 { get; set; }
        public int Banda3 { get; set; }
        public int Banda4 { get; set; }
        public int Banda5 { get; set; }
        public int Banda6 { get; set; }
        public bool EsDeTresBandas { get; set; }
        public bool EsDeCuatroBandas { get; set; }
        public bool EsDeCincoBandas { get; set; }
        public bool EsDeSeisBandas { get; set; }
        //Constructores 
        //Constructor para 3 bandas
        public Resistor(int banda1, int banda2, int banda3)
        {
            Banda1 = banda1;
            Banda2 = banda2;
            Banda3 = banda3;
            EsDeTresBandas = true;
            EsDeCuatroBandas = false;
            EsDeCincoBandas = false;
            EsDeSeisBandas = false;
        }
        //Constructor para 4 bandas
        public Resistor(int banda1, int banda2, int banda3, int banda4)
        {
            Banda1 = banda1;
            Banda2 = banda2;
            Banda3 = banda3;
            Banda4 = banda4;
            EsDeTresBandas = false;
            EsDeCuatroBandas = true;
            EsDeCincoBandas = false;
            EsDeSeisBandas = false;
        }
        //Constructor para 5 bandas
        public Resistor(int banda1, int banda2, int banda3, int banda4, int banda5)
        {
            Banda1 = banda1;
            Banda2 = banda2;
            Banda3 = banda3;
            Banda4 = banda4;
            Banda5 = banda5;
            EsDeTresBandas = false;
            EsDeCuatroBandas = false;
            EsDeCincoBandas = true;
            EsDeSeisBandas = false;
        }
        //Constructor para 6 bandas
        public Resistor(int banda1, int banda2, int banda3, int banda4, int banda5, int banda6)
        {
            Banda1 = banda1;
            Banda2 = banda2;
            Banda3 = banda3;
            Banda4 = banda4;
            Banda5 = banda5;
            Banda6 = banda6;
            EsDeTresBandas = false;
            EsDeCuatroBandas = false;
            EsDeCincoBandas = false;
            EsDeSeisBandas = true;
        }
        //Metodos
        public string CalculoDeValores()
        {
            double resultado;
            string unidad = " Ω";
            string resultadoString = string.Empty;

            if (EsDeTresBandas)
            {
                string concatenacionBanda1y2 = $"{Banda1}{Banda2}";
                resultado = int.Parse(concatenacionBanda1y2) * _valoresMultiplicador[Banda3];
                unidad = FormatearUnidades(resultado, unidad);
                resultadoString = $"{unidad}";
            }
            else if (EsDeCuatroBandas){
                string concatenacionBanda1y2 = $"{Banda1}{Banda2}";
                resultado = int.Parse(concatenacionBanda1y2) * _valoresMultiplicador[Banda3];
                unidad = FormatearUnidades(resultado, unidad);
                resultadoString = $"{unidad} ± {_tolerancia[Banda4]}%";
            }
            else if (EsDeCincoBandas)
            {
                string concatenacionBanda12y3 = $"{Banda1}{Banda2}{Banda3}";
                resultado = int.Parse(concatenacionBanda12y3) * _valoresMultiplicador[Banda4];
                unidad = FormatearUnidades(resultado, unidad);
                resultadoString = $"{unidad} ± {_tolerancia[Banda5]}%";
            }
            else if (EsDeSeisBandas)
            {   
                string concatenacionBanda12y3 = $"{Banda1}{Banda2}{Banda3}";
                resultado = int.Parse(concatenacionBanda12y3) * _valoresMultiplicador[Banda4];
                unidad = FormatearUnidades(resultado, unidad);
                resultadoString = $"{unidad} ± {_tolerancia[Banda5]}% {_temperatura[Banda6]} ppm/K";
            }
            return resultadoString;
        }
        public string FormatearUnidades(double resultado, string unidad)
        {
            if (resultado >= 1000 && resultado < 1000000)
            {
                resultado /= 1000;
                unidad = " kΩ";
            }
            else if (resultado >= 1000000 && resultado < 1000000000)
            {
                resultado /= 1000000;
                unidad = " MΩ";
            }
            else if (resultado >= 1000000000)
            {
                resultado /= 1000000000;
                unidad = " GΩ";
            }
            return resultado + unidad; 
        }
        public void DibujarResistor(Graphics g)
        {
            //Definimos colores a usar 
            Color colorGeneralResistor = Color.FromArgb(254, 228, 195);
            Color colorTerminales = Color.FromArgb(105, 105, 105);
            // Creamos un GraphicsPath para el rectángulo redondeado
            GraphicsPath pathResistor = new GraphicsPath();
            int radioRedondeo = 20; // Radio de los bordes redondeados
            Rectangle rectResistor = new Rectangle(200, 100, 350, 100);
            // Añadimos las líneas y arcos para crear las esquinas redondeadas
            pathResistor.AddArc(rectResistor.X, rectResistor.Y, radioRedondeo * 2, radioRedondeo * 2, 180, 90); // Esquina superior izquierda
            pathResistor.AddLine(rectResistor.X + radioRedondeo, rectResistor.Y, rectResistor.X + rectResistor.Width - radioRedondeo, rectResistor.Y); // Línea superior
            pathResistor.AddArc(rectResistor.X + rectResistor.Width - radioRedondeo * 2, rectResistor.Y, radioRedondeo * 2, radioRedondeo * 2, 270, 90); // Esquina superior derecha
            pathResistor.AddLine(rectResistor.X + rectResistor.Width, rectResistor.Y + radioRedondeo, rectResistor.X + rectResistor.Width, rectResistor.Y + rectResistor.Height - radioRedondeo); // Línea derecha
            pathResistor.AddArc(rectResistor.X + rectResistor.Width - radioRedondeo * 2, rectResistor.Y + rectResistor.Height - radioRedondeo * 2, radioRedondeo * 2, radioRedondeo * 2, 0, 90); // Esquina inferior derecha
            pathResistor.AddLine(rectResistor.X + rectResistor.Width - radioRedondeo, rectResistor.Y + rectResistor.Height, rectResistor.X + radioRedondeo, rectResistor.Y + rectResistor.Height); // Línea inferior
            pathResistor.AddArc(rectResistor.X, rectResistor.Y + rectResistor.Height - radioRedondeo * 2, radioRedondeo * 2, radioRedondeo * 2, 90, 90); // Esquina inferior izquierda
            pathResistor.CloseFigure(); // Cerramos el path
            // Rellenamos el rectángulo redondeado
            SolidBrush brocha = new SolidBrush(colorGeneralResistor);
            g.FillPath(brocha, pathResistor);
            // Dibujamos los terminales 
            SolidBrush brochaTerminales = new SolidBrush(colorTerminales);
            g.FillRectangle(brochaTerminales, new Rectangle(100, 135, 101, 25));
            g.FillRectangle(brochaTerminales, new Rectangle(549, 135, 101, 25));
        }
        public SolidBrush ObtenerBrochaParaBandaPrincipales(int indiceBanda)
        {
            if (ColoresDeBandasPrincipales.ContainsKey(indiceBanda))
            {
                return new SolidBrush(ColoresDeBandasPrincipales[indiceBanda]);
            }
            else
            {
                return new SolidBrush(Color.Black); // Color por defecto
            }
        }
        public SolidBrush ObtenerBrochaParaBandaTolerancia(int indiceBanda)
        {
            if (ColoresDeTolerancia.ContainsKey(indiceBanda))
            {
                return new SolidBrush(ColoresDeTolerancia[indiceBanda]);
            }
            else
            {
                return new SolidBrush(Color.Brown); // Color por defecto
            }
        }
        public SolidBrush ObtenerBrochaParaBandaTemperatura(int indiceBanda)
        {
            if (ColoresDeTemperatura.ContainsKey(indiceBanda))
            {
                return new SolidBrush(ColoresDeTemperatura[indiceBanda]);
            }
            else
            {
                return new SolidBrush(Color.Black); // Color por defecto
            }
        }
    }
}
