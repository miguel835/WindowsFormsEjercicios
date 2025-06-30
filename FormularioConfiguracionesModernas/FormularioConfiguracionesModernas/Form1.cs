using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioConfiguracionesModernas
{
    public partial class Form1 : MaterialSkin.Controls.MaterialForm
    {
        //Atributos
        MaterialSkin.MaterialSkinManager sm;
        MaterialSkin.Primary colorPrimario = MaterialSkin.Primary.Blue400;
        MaterialSkin.Primary oscuroPrimario = MaterialSkin.Primary.Blue700;
        MaterialSkin.TextShade colorTexto = MaterialSkin.TextShade.WHITE;
        FormularioConfiguracionesModernas.Mis_clases.Cls_cargador_aspectos mi_clase = new Mis_clases.Cls_cargador_aspectos();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sm = MaterialSkin.MaterialSkinManager.Instance;
            sm.AddFormToManage(this);
            //-----------------------------
            sm.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            //-----------------------------
            sm.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Blue400,
                                                          MaterialSkin.Primary.Blue700,
                                                          MaterialSkin.Primary.Blue100,
                                                          MaterialSkin.Accent.Orange400,
                                                          MaterialSkin.TextShade.WHITE);
            //==========================Cargador de configuración de temas===========================
            //---------Cargar configuraciones---------------
            MaterialSkin.Controls.MaterialRadioButton rb = new MaterialSkin.Controls.MaterialRadioButton();
            //---------Cargar temas-------------------------
            mi_clase.cargadorTemas(rb, rb, sm);
            //-------Restaurar color de temas--------------
            mi_clase.cargadorColoresTemas(ref colorPrimario, ref oscuroPrimario,
                                          rb, rb,
                                          rb, rb,
                                          rb, rb,
                                          rb, rb,
                                          rb, rb,
                                          rb, rb,
                                          rb, rb,
                                          rb, rb,
                                          rb, rb,
                                          rb);
            //--------Restaurar el color del texto-------------------
            mi_clase.cargadorColoresTexto(rb, rb, ref colorTexto);
            //--------------------------
            mi_clase.selectorTemas(colorPrimario, oscuroPrimario, colorTexto, sm);
            //=====================================================================================
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            //FormularioConfiguracionesModernas.Conf_temas f = new Conf_temas(); Es lo mismo
            var f = new Conf_temas();//Es lo mismo que la linea comentada
            f.ShowDialog();
            f.Dispose();//Dispose significa liberar cualquier memoria que pertenezca
            //a este formulario, es decir que luego de que se abra este formulario 
            //La memoria utilizada por él será liberada.
        }
    }
}
