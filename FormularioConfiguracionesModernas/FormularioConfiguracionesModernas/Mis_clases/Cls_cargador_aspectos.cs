using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioConfiguracionesModernas.Mis_clases
{
    internal class Cls_cargador_aspectos
    {
        //Método selector de temas
        public void selectorTemas(MaterialSkin.Primary colorPrimario,
                                  MaterialSkin.Primary oscuroPrimario,
                                  MaterialSkin.TextShade colorTexto,
                                  MaterialSkin.MaterialSkinManager sm)
        {
            sm.ColorScheme = new MaterialSkin.ColorScheme(colorPrimario,
                                                         oscuroPrimario,
                                                         MaterialSkin.Primary.Blue100,
                                                         MaterialSkin.Accent.Orange400,
                                                         colorTexto);
        }

        public void cargadorTemas(MaterialSkin.Controls.MaterialRadioButton claro_rb,
                                  MaterialSkin.Controls.MaterialRadioButton oscuro_rb, 
                                  MaterialSkin.MaterialSkinManager sm)
        {
            //---------Cargar tema-------------------------
            Boolean b;
            b = FormularioConfiguracionesModernas.Properties.Settings.Default.tema_claro_rb;
            if (b == true)
            {
                claro_rb.Checked = true;
                oscuro_rb.Checked = false;
                sm.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            }
            else
            {
                claro_rb.Checked = false;
                oscuro_rb.Checked = true;
                sm.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            }
        }

        public void cargadorColoresTemas(ref MaterialSkin.Primary colorPrimario,
                                         ref MaterialSkin.Primary oscuroPrimario,
                                         MaterialSkin.Controls.MaterialRadioButton Ambar_rb,
                                         MaterialSkin.Controls.MaterialRadioButton Azul_rb,
                                         MaterialSkin.Controls.MaterialRadioButton Morado_int_rb,
                                         MaterialSkin.Controls.MaterialRadioButton Rosa_rb,
                                         MaterialSkin.Controls.MaterialRadioButton Naranja_int_rb,
                                         MaterialSkin.Controls.MaterialRadioButton Cian_rb,
                                         MaterialSkin.Controls.MaterialRadioButton Indigo_rb, 
                                         MaterialSkin.Controls.MaterialRadioButton Gris_azul_rb, 
                                         MaterialSkin.Controls.MaterialRadioButton Verde_rb, 
                                         MaterialSkin.Controls.MaterialRadioButton Gris_rb, 
                                         MaterialSkin.Controls.MaterialRadioButton Rojo_rb, 
                                         MaterialSkin.Controls.MaterialRadioButton Morado_rb, 
                                         MaterialSkin.Controls.MaterialRadioButton Verde_cla_rb, 
                                         MaterialSkin.Controls.MaterialRadioButton Lima_rb, 
                                         MaterialSkin.Controls.MaterialRadioButton Verde_azul_rb, 
                                         MaterialSkin.Controls.MaterialRadioButton Marron_rb,
                                         MaterialSkin.Controls.MaterialRadioButton Naranja_rb, 
                                         MaterialSkin.Controls.MaterialRadioButton Amarillo_rb,
                                         MaterialSkin.Controls.MaterialRadioButton Azul_clar_rb
                                         )
        {
            Boolean b;
            b = FormularioConfiguracionesModernas.Properties.Settings.Default.skin_color_ambar;
            Ambar_rb.Checked = b;
            //-------------------------
            if (b == true)
            {
                colorPrimario = MaterialSkin.Primary.Amber400;
                oscuroPrimario = MaterialSkin.Primary.Amber700;
            }
            //---------------------------
            b = FormularioConfiguracionesModernas.Properties.Settings.Default.skin_color_azul;
            Azul_rb.Checked = b;
            //---------------------------
            if (b == true)
            {
                colorPrimario = MaterialSkin.Primary.Blue400;
                oscuroPrimario = MaterialSkin.Primary.Blue700;
            }
            //--------------------------
            b = FormularioConfiguracionesModernas.Properties.Settings.Default.skin_color_morado_int;
            Morado_int_rb.Checked = b;
            //---------------------------
            if (b == true)
            {
                colorPrimario = MaterialSkin.Primary.DeepPurple400;
                oscuroPrimario = MaterialSkin.Primary.DeepPurple700;
            }
            //-------------------------
            b = FormularioConfiguracionesModernas.Properties.Settings.Default.skin_color_rosa;
            Rosa_rb.Checked = b;
            //---------------------------
            if (b == true)
            {
                colorPrimario = MaterialSkin.Primary.Pink400;
                oscuroPrimario = MaterialSkin.Primary.Pink700;
            }
            //----------------------------
            b = FormularioConfiguracionesModernas.Properties.Settings.Default.skin_color_cian;
            Cian_rb.Checked = b;
            //---------------------------
            if (b == true)
            {
                colorPrimario = MaterialSkin.Primary.Cyan400;
                oscuroPrimario = MaterialSkin.Primary.Cyan700;
            }
            //-----------------------
            b = FormularioConfiguracionesModernas.Properties.Settings.Default.skin_color_naranja_int;
            Naranja_int_rb.Checked = b;
            //---------------------------
            if (b == true)
            {
                colorPrimario = MaterialSkin.Primary.DeepOrange400;
                oscuroPrimario = MaterialSkin.Primary.DeepOrange700;
            }
            //-----------------------
            b = FormularioConfiguracionesModernas.Properties.Settings.Default.skin_color_indigo;
            Indigo_rb.Checked = b;
            //---------------------------
            if (b == true)
            {
                colorPrimario = MaterialSkin.Primary.Indigo400;
                oscuroPrimario = MaterialSkin.Primary.Indigo700;
            }
            //-----------------------
            b = FormularioConfiguracionesModernas.Properties.Settings.Default.skin_color_gris_azul;
            Gris_azul_rb.Checked = b;
            //---------------------------
            if (b == true)
            {
                colorPrimario = MaterialSkin.Primary.BlueGrey400;
                oscuroPrimario = MaterialSkin.Primary.BlueGrey700;
            }
            //-----------------------
            b = FormularioConfiguracionesModernas.Properties.Settings.Default.skin_color_verde;
            Verde_rb.Checked = b;
            //---------------------------
            if (b == true)
            {
                colorPrimario = MaterialSkin.Primary.Green400;
                oscuroPrimario = MaterialSkin.Primary.Green700;
            }
            //-----------------------
            b = FormularioConfiguracionesModernas.Properties.Settings.Default.skin_color_gris;
            Gris_rb.Checked = b;
            //---------------------------
            if (b == true)
            {
                colorPrimario = MaterialSkin.Primary.Grey400;
                oscuroPrimario = MaterialSkin.Primary.Grey700;
            }
            //-----------------------
            b = FormularioConfiguracionesModernas.Properties.Settings.Default.skin_color_rojo;
            Rojo_rb.Checked = b;
            //---------------------------
            if (b == true)
            {
                colorPrimario = MaterialSkin.Primary.Red400;
                oscuroPrimario = MaterialSkin.Primary.Red700;
            }
            //----------------------
            b = FormularioConfiguracionesModernas.Properties.Settings.Default.skin_color_morado;
            Morado_rb.Checked = b;
            //---------------------------
            if (b == true)
            {
                colorPrimario = MaterialSkin.Primary.Purple400;
                oscuroPrimario = MaterialSkin.Primary.Purple700;
            }
            //----------------------
            b = FormularioConfiguracionesModernas.Properties.Settings.Default.skin_color_verde_clar;
            Verde_cla_rb.Checked = b;
            //---------------------------
            if (b == true)
            {
                colorPrimario = MaterialSkin.Primary.LightGreen400;
                oscuroPrimario = MaterialSkin.Primary.LightGreen700;
            }
            //-----------------------
            b = FormularioConfiguracionesModernas.Properties.Settings.Default.skin_color_lima;
            Lima_rb.Checked = b;
            //---------------------------
            if (b == true)
            {
                colorPrimario = MaterialSkin.Primary.Lime400;
                oscuroPrimario = MaterialSkin.Primary.Lime700;
            }
            //----------------------
            b = FormularioConfiguracionesModernas.Properties.Settings.Default.skin_color_verde_azul;
            Verde_azul_rb.Checked = b;
            //---------------------------
            if (b == true)
            {
                colorPrimario = MaterialSkin.Primary.Teal400;
                oscuroPrimario = MaterialSkin.Primary.Teal700;
            }
            //----------------------
            b = FormularioConfiguracionesModernas.Properties.Settings.Default.skin_color_marron;
            Marron_rb.Checked = b;
            //---------------------------
            if (b == true)
            {
                colorPrimario = MaterialSkin.Primary.Brown400;
                oscuroPrimario = MaterialSkin.Primary.Brown700;
            }
            //---------------------
            b = FormularioConfiguracionesModernas.Properties.Settings.Default.skin_color_naranja;
            Naranja_rb.Checked = b;
            //---------------------------
            if (b == true)
            {
                colorPrimario = MaterialSkin.Primary.Orange400;
                oscuroPrimario = MaterialSkin.Primary.Orange700;
            }
            //--------------------
            b = FormularioConfiguracionesModernas.Properties.Settings.Default.skin_color_amarillo;
            Amarillo_rb.Checked = b;
            //---------------------------
            if (b == true)
            {
                colorPrimario = MaterialSkin.Primary.Yellow400;
                oscuroPrimario = MaterialSkin.Primary.Yellow700;
            }
            //--------------------
            b = FormularioConfiguracionesModernas.Properties.Settings.Default.skin_color_azul_clar;
            Azul_clar_rb.Checked = b;
            //---------------------------
            if (b == true)
            {
                colorPrimario = MaterialSkin.Primary.LightBlue400;
                oscuroPrimario = MaterialSkin.Primary.LightBlue700;
            }
        }

        public void cargadorColoresTexto(MaterialSkin.Controls.MaterialRadioButton claro_rb,
                                         MaterialSkin.Controls.MaterialRadioButton oscuro_rb,
                                         ref MaterialSkin.TextShade colorTexto)
        {
            Boolean b;
            b = FormularioConfiguracionesModernas.Properties.Settings.Default.text_color_white;
            claro_rb.Checked = b;
            if (b == true)
            {
                colorTexto = MaterialSkin.TextShade.WHITE;
            }
            b = FormularioConfiguracionesModernas.Properties.Settings.Default.text_color_black;
            oscuro_rb.Checked = b;
            if (b == true)
            {
                colorTexto = MaterialSkin.TextShade.BLACK;
            }
        }
    }
}
