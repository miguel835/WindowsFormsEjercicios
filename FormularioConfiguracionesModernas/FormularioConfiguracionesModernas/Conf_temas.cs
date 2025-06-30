using FormularioConfiguracionesModernas.Mis_clases;
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
    public partial class Conf_temas : MaterialSkin.Controls.MaterialForm
    {
        //Atributos
        MaterialSkin.MaterialSkinManager sm;
        MaterialSkin.Primary colorPrimario = MaterialSkin.Primary.Blue400;
        MaterialSkin.Primary oscuroPrimario = MaterialSkin.Primary.Blue700;
        MaterialSkin.TextShade colorTexto = MaterialSkin.TextShade.WHITE;
        FormularioConfiguracionesModernas.Mis_clases.Cls_cargador_aspectos mi_clase = new Mis_clases.Cls_cargador_aspectos();


        public Conf_temas()
        {
            InitializeComponent();
        }

        private void Conf_temas_Load(object sender, EventArgs e)
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
            //---------Cargar configuraciones---------------
            //---------Cargar temas-------------------------
            mi_clase.cargadorTemas(claro_rb, oscuro_rb, sm);
            //-------Restaurar color de temas--------------
            mi_clase.cargadorColoresTemas(ref colorPrimario, ref oscuroPrimario,
                                          this.Ambar_rb, this.Azul_rb,
                                          this.Morado_int_rb, this.Rosa_rb,
                                          this.Naranja_int_rb, this.Cian_rb,
                                          this.Indigo_rb, this.Gris_azul_rb,
                                          this.Verde_rb, this.Gris_rb,
                                          this.Rojo_rb, this.Morado_rb,
                                          this.Verde_cla_rb, this.Lima_rb,
                                          this.Verde_azul_rb, this.Marron_rb,
                                          this.Naranja_rb, this.Amarillo_rb,
                                          this.Azul_clar_rb);
            //--------Restaurar el color del texto-------------------
            mi_clase.cargadorColoresTexto(this.color_texto_blanco_rb, this.color_texto_negro_rb, ref colorTexto);
            //--------------------------
            mi_clase.selectorTemas(colorPrimario, oscuroPrimario, colorTexto, sm);
        }

        private void claro_rb_Click(object sender, EventArgs e)
        {
            sm.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            FormularioConfiguracionesModernas.Properties.Settings.Default.tema_claro_rb = this.claro_rb.Checked;
            FormularioConfiguracionesModernas.Properties.Settings.Default.tema_oscuro_rb = this.oscuro_rb.Checked;
            FormularioConfiguracionesModernas.Properties.Settings.Default.Save();
        }

        private void oscuro_rb_Click(object sender, EventArgs e)
        {
            sm.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            FormularioConfiguracionesModernas.Properties.Settings.Default.tema_claro_rb = this.claro_rb.Checked;
            FormularioConfiguracionesModernas.Properties.Settings.Default.tema_oscuro_rb = this.oscuro_rb.Checked;
            FormularioConfiguracionesModernas.Properties.Settings.Default.Save();
        }

        private void Ambar_rb_Click(object sender, EventArgs e)
        {
            //-----------------------------
            colorPrimario = MaterialSkin.Primary.Amber400;
            oscuroPrimario = MaterialSkin.Primary.Amber700;
            colorTexto = MaterialSkin.TextShade.BLACK;
            //--------------------------
            mi_clase.selectorTemas(colorPrimario, oscuroPrimario, colorTexto, sm);
            //------------------
            cargadorTemas();
        }

        private void Azul_rb_Click(object sender, EventArgs e)
        {
            //-----------------------------
            colorPrimario = MaterialSkin.Primary.Blue400;
            oscuroPrimario = MaterialSkin.Primary.Blue700;
            //--------------------------
            mi_clase.selectorTemas(colorPrimario, oscuroPrimario, colorTexto, sm);
            //------------------
            cargadorTemas();
        }

        private void Morado_int_rb_Click(object sender, EventArgs e)
        {
            //-----------------------------
            colorPrimario = MaterialSkin.Primary.DeepPurple400;
            oscuroPrimario = MaterialSkin.Primary.DeepPurple700;
            //--------------------------
            mi_clase.selectorTemas(colorPrimario, oscuroPrimario, colorTexto, sm);
            //------------------
            cargadorTemas();
        }

        private void Rosa_rb_Click(object sender, EventArgs e)
        {
            //-----------------------------
            colorPrimario = MaterialSkin.Primary.Pink400;
            oscuroPrimario = MaterialSkin.Primary.Pink700;
            //--------------------------
            mi_clase.selectorTemas(colorPrimario, oscuroPrimario, colorTexto, sm);
            //------------------
            cargadorTemas();
        }

        private void Cian_rb_Click(object sender, EventArgs e)
        {
            //-----------------------------
            colorPrimario = MaterialSkin.Primary.Cyan400;
            oscuroPrimario = MaterialSkin.Primary.Cyan700;
            //--------------------------
            mi_clase.selectorTemas(colorPrimario, oscuroPrimario, colorTexto, sm);
            //------------------
            cargadorTemas();
        }

        private void Naranja_int_rb_Click(object sender, EventArgs e)
        {
            //-----------------------------
            colorPrimario = MaterialSkin.Primary.DeepOrange400;
            oscuroPrimario = MaterialSkin.Primary.DeepOrange700;
            //--------------------------
            mi_clase.selectorTemas(colorPrimario, oscuroPrimario, colorTexto, sm);
            //------------------
            cargadorTemas();
        }

        private void Indigo_rb_Click(object sender, EventArgs e)
        {
            //-----------------------------
            colorPrimario = MaterialSkin.Primary.Indigo400;
            oscuroPrimario = MaterialSkin.Primary.Indigo700;
            //--------------------------
            mi_clase.selectorTemas(colorPrimario, oscuroPrimario, colorTexto, sm);
            //------------------
            cargadorTemas();
        }

        private void Gris_azul_rb_Click(object sender, EventArgs e)
        {
            //-----------------------------
            colorPrimario = MaterialSkin.Primary.BlueGrey400;
            oscuroPrimario = MaterialSkin.Primary.BlueGrey700;
            //--------------------------
            mi_clase.selectorTemas(colorPrimario, oscuroPrimario, colorTexto, sm);
            //------------------
            cargadorTemas();
        }

        private void Verde_rb_Click(object sender, EventArgs e)
        {
            //-----------------------------
            colorPrimario = MaterialSkin.Primary.Green400;
            oscuroPrimario = MaterialSkin.Primary.Green700;
            //--------------------------
            mi_clase.selectorTemas(colorPrimario, oscuroPrimario, colorTexto, sm);
            //------------------
            cargadorTemas();
        }

        private void Gris_rb_Click(object sender, EventArgs e)
        {
            //-----------------------------
            colorPrimario = MaterialSkin.Primary.Grey400;
            oscuroPrimario = MaterialSkin.Primary.Grey700;
            //--------------------------
            mi_clase.selectorTemas(colorPrimario, oscuroPrimario, colorTexto, sm);
            //------------------
            cargadorTemas();
        }

        private void Rojo_rb_Click(object sender, EventArgs e)
        {
            //-----------------------------
            colorPrimario = MaterialSkin.Primary.Red400;
            oscuroPrimario = MaterialSkin.Primary.Red700;
            //--------------------------
            mi_clase.selectorTemas(colorPrimario, oscuroPrimario, colorTexto, sm);
            //------------------
            cargadorTemas();
        }

        private void Morado_rb_Click(object sender, EventArgs e)
        {
            //-----------------------------
            colorPrimario = MaterialSkin.Primary.Purple400;
            oscuroPrimario = MaterialSkin.Primary.Purple700;
            //--------------------------
            mi_clase.selectorTemas(colorPrimario, oscuroPrimario, colorTexto, sm);
            //------------------
            cargadorTemas();
        }

        private void Verde_cla_rb_Click(object sender, EventArgs e)
        {
            //-----------------------------
            colorPrimario = MaterialSkin.Primary.LightGreen400;
            oscuroPrimario = MaterialSkin.Primary.LightGreen700;
            //--------------------------
            mi_clase.selectorTemas(colorPrimario, oscuroPrimario, colorTexto, sm);
            //------------------
            cargadorTemas();
        }

        private void Lima_rb_Click(object sender, EventArgs e)
        {
            //-----------------------------
            colorPrimario = MaterialSkin.Primary.Lime400;
            oscuroPrimario = MaterialSkin.Primary.Lime700;
            colorTexto = MaterialSkin.TextShade.BLACK;
            //--------------------------
            mi_clase.selectorTemas(colorPrimario, oscuroPrimario, colorTexto, sm);
            //------------------
            cargadorTemas();
        }

        private void Verde_azul_rb_Click(object sender, EventArgs e)
        {
            //-----------------------------
            colorPrimario = MaterialSkin.Primary.Teal400;
            oscuroPrimario = MaterialSkin.Primary.Teal700;
            //--------------------------
            mi_clase.selectorTemas(colorPrimario, oscuroPrimario, colorTexto, sm);
            //------------------
            cargadorTemas();
        }

        private void Marron_rb_Click(object sender, EventArgs e)
        {
            //-----------------------------
            colorPrimario = MaterialSkin.Primary.Brown400;
            oscuroPrimario = MaterialSkin.Primary.Brown700;
            //--------------------------
            mi_clase.selectorTemas(colorPrimario, oscuroPrimario, colorTexto, sm);
            //------------------
            cargadorTemas();
        }

        private void Naranja_rb_Click(object sender, EventArgs e)
        {

            //-----------------------------
            colorPrimario = MaterialSkin.Primary.Orange400;
            oscuroPrimario = MaterialSkin.Primary.Orange700;
            //--------------------------
            mi_clase.selectorTemas(colorPrimario, oscuroPrimario, colorTexto, sm);
            //------------------
            cargadorTemas();
        }

        private void Amarillo_rb_Click(object sender, EventArgs e)
        {

            //-----------------------------
            colorPrimario = MaterialSkin.Primary.Yellow400;
            oscuroPrimario = MaterialSkin.Primary.Yellow700;
            colorTexto = MaterialSkin.TextShade.BLACK;
            //--------------------------
            mi_clase.selectorTemas(colorPrimario, oscuroPrimario, colorTexto, sm);
            //------------------
            cargadorTemas();
        }

        private void Azul_clar_rb_Click(object sender, EventArgs e)
        {
            //-----------------------------
            colorPrimario = MaterialSkin.Primary.LightBlue400;
            oscuroPrimario = MaterialSkin.Primary.LightBlue700;
            //--------------------------
            mi_clase.selectorTemas(colorPrimario, oscuroPrimario, colorTexto, sm);
            //------------------
            cargadorTemas();
        }

        private void color_texto_blanco_rb_Click(object sender, EventArgs e)
        {
            //-------------------
            colorTexto = MaterialSkin.TextShade.WHITE;
            //--------------------------
            mi_clase.selectorTemas(colorPrimario, oscuroPrimario, colorTexto, sm);
            //------------------
            cargadorTemas();
            //-------------------
            FormularioConfiguracionesModernas.Properties.Settings.Default.text_color_white = this.claro_rb.Checked;
            FormularioConfiguracionesModernas.Properties.Settings.Default.text_color_black = this.oscuro_rb.Checked;
            FormularioConfiguracionesModernas.Properties.Settings.Default.Save();
        }

        private void color_texto_negro_rb_Click(object sender, EventArgs e)
        {
            //-------------------
            colorTexto = MaterialSkin.TextShade.BLACK;
            //--------------------------
            mi_clase.selectorTemas(colorPrimario, oscuroPrimario, colorTexto, sm);
            //------------------
            cargadorTemas();
            //------------------
            FormularioConfiguracionesModernas.Properties.Settings.Default.text_color_white = this.claro_rb.Checked;
            FormularioConfiguracionesModernas.Properties.Settings.Default.text_color_black = this.oscuro_rb.Checked;
            FormularioConfiguracionesModernas.Properties.Settings.Default.Save();
        }

        //Método de cargador de temas
        void cargadorTemas()
        {
            //-----------------------------
            FormularioConfiguracionesModernas.Properties.Settings.Default.skin_color_ambar = this.Ambar_rb.Checked;
            FormularioConfiguracionesModernas.Properties.Settings.Default.skin_color_azul = this.Azul_rb.Checked;
            FormularioConfiguracionesModernas.Properties.Settings.Default.skin_color_morado_int = this.Morado_int_rb.Checked;
            FormularioConfiguracionesModernas.Properties.Settings.Default.skin_color_rosa = this.Rosa_rb.Checked;
            FormularioConfiguracionesModernas.Properties.Settings.Default.skin_color_cian = this.Cian_rb.Checked;
            FormularioConfiguracionesModernas.Properties.Settings.Default.skin_color_naranja_int = this.Naranja_int_rb.Checked;
            FormularioConfiguracionesModernas.Properties.Settings.Default.skin_color_indigo = this.Indigo_rb.Checked;
            FormularioConfiguracionesModernas.Properties.Settings.Default.skin_color_gris_azul = this.Gris_azul_rb.Checked;
            FormularioConfiguracionesModernas.Properties.Settings.Default.skin_color_verde = this.Verde_rb.Checked;
            FormularioConfiguracionesModernas.Properties.Settings.Default.skin_color_gris = this.Gris_rb.Checked;
            FormularioConfiguracionesModernas.Properties.Settings.Default.skin_color_rojo = this.Rojo_rb.Checked;
            FormularioConfiguracionesModernas.Properties.Settings.Default.skin_color_morado = this.Morado_rb.Checked;
            FormularioConfiguracionesModernas.Properties.Settings.Default.skin_color_verde_clar = this.Verde_cla_rb.Checked;
            FormularioConfiguracionesModernas.Properties.Settings.Default.skin_color_lima = this.Lima_rb.Checked;
            FormularioConfiguracionesModernas.Properties.Settings.Default.skin_color_verde_azul = this.Verde_azul_rb.Checked;
            FormularioConfiguracionesModernas.Properties.Settings.Default.skin_color_marron = this.Marron_rb.Checked;
            FormularioConfiguracionesModernas.Properties.Settings.Default.skin_color_naranja = this.Naranja_rb.Checked;
            FormularioConfiguracionesModernas.Properties.Settings.Default.skin_color_amarillo = this.Amarillo_rb.Checked;
            FormularioConfiguracionesModernas.Properties.Settings.Default.skin_color_azul_clar = this.Azul_clar_rb.Checked;
            FormularioConfiguracionesModernas.Properties.Settings.Default.Save();
        }
    }
}
