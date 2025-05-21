using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skin_pro
{
    //Heredamos de MaterialSkin.Controls.MaterialForm porque desde ahí le decimos que aplique
    //el tema que instalamos 
    public partial class Form1 : MaterialSkin.Controls.MaterialForm
    {
        //Instancia de MaterialSkin
        MaterialSkin.MaterialSkinManager skinManager;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {   
            skinManager = MaterialSkin.MaterialSkinManager.Instance; //Definimos el gestor de esquemas
            skinManager.AddFormToManage(this); //Agregar el formulario Form1 al gestor de esquemas
            //Establecemos el tema oscuro al formulario
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            //Establecemos el esquema del color del formulario 
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Orange500,
                                                                   MaterialSkin.Primary.Orange800,
                                                                   MaterialSkin.Primary.Orange300,
                                                                   MaterialSkin.Accent.Green400,
                                                                   MaterialSkin.TextShade.WHITE);
            //Si ejecutas el código hasta esta parte veras que ha cambiado el tema, a la final se trata de ir jugando con los colores que desees 
            //Es mejor obtener el mismo color para tu color primario y para tu color oscuro primario pero siempre con diferentes números
            //En los botones establece la propiedad Primary en True para que el texto de los botones tomen el color del tema
            this.materialSingleLineTextField1.Font = skinManager.ROBOTO_MEDIUM_12;
            this.Text = this.materialLabel1.Font.ToString();
            this.materialRadioButton2.Font = skinManager.ROBOTO_REGULAR_11;
            //Establecemos una fuente de letra aun más personalizada al label 1
            this.materialLabel1.Font = new Font("Segoe UI", 24, FontStyle.Italic);
        }
        //Lógica para el botón Claro
        private void lightButton_Click(object sender, EventArgs e)
        {
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
        }
        //Lógica para el botón Oscuro
        private void darkButton_Click(object sender, EventArgs e)
        {
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
        }
    }
}