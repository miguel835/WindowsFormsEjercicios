using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Camara
{
    public partial class frmCamara : Form
    {
        WebCamara webCamara;
        public frmCamara()
        {
            InitializeComponent();
            webCamara = new WebCamara(this);
        }

        private void frmCamara_Load(object sender, EventArgs e)
        {
            webCamara.DetectarAgregarCamara();
        }

        private void btnIniciarWebcamara_Click(object sender, EventArgs e)
        {
            webCamara.IniciarCamara();
        }

        private void frmCamara_FormClosing(object sender, FormClosingEventArgs e)
        { 
            webCamara.TerminarWebCamara();  
        }

        private void btnTomarFoto_Click(object sender, EventArgs e)
        {
            webCamara.TomarFoto();
        }
    }
}
