using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Camara
{
    internal class WebCamara
    {
        //Atributos 
        private FilterInfoCollection filterInfoCollection;
        private VideoCaptureDevice videoCaptureDevice;
        private frmCamara frm;
        private Bitmap imagen;
        //Constructor 
        public WebCamara(frmCamara frmCamara)
        {
            this.frm = frmCamara;
        }
        //Método Detectar camarasS
        public void DetectarAgregarCamara()
        {
            //-------------Detectamos las camaras-----------------
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            //-----------Las agregamos al combobox----------------
            foreach (FilterInfo item in filterInfoCollection)
            {
                frm.cboCamara.Items.Add(item);
            }
            //--------Seleccionamos por defecto el primer item del comboBox---------
            try
            {
                frm.cboCamara.SelectedIndex = 0;
            }
            catch
            {
                //-------Caso en el que no se conecte ninguna webcamara----------
                MessageBox.Show("No se detecto ninguna webcamara conecte una");
                //----En caso de que no haya ninguna camara conectada---------
                if (frm.cboCamara.SelectedIndex == -1)
                {
                    frm.cboCamara.Items.Add("0");
                }
                frm.Close();
            }
            //---------------Inicializamos la instancia-----------------
            videoCaptureDevice = new VideoCaptureDevice();
        }
        //Método IniciarCamara()
        public void IniciarCamara()
        {
            //---------------Inicializamos la instancia-----------------
            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[frm.cboCamara.SelectedIndex].MonikerString);
            //---Agregamos un evento de controlador para actualizar el picturebox con las imagenes que se toman ------------
            videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            //---Iniciamos la webcam---------------------------------
            videoCaptureDevice.Start();
        }
        //Controlador de eventos VideoCaptureDevice_NewFrame
        private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            //--------------Por cada nuevo frame este se actualiza en el picturebox-----------------
            frm.pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
            imagen = (Bitmap)eventArgs.Frame.Clone();
        }
        //Método Tomar foto
        public void TomarFoto()
        {
            //----------Comprobamos si hay una foto anterior----
            string path = Application.ExecutablePath + "\\FotoPerfil.png";
            //----------En caso de encontrarla la borramos 
            if (System.IO.File.Exists(path)) System.IO.File.Delete(path);
            //-----------Verificamos si el Bitmap no esta vacio--------
            if (imagen != null)
            {
                //--------Guardamos la imagen---------
                imagen.Save("FotoPerfil.png", System.Drawing.Imaging.ImageFormat.Png);
                MessageBox.Show("Foto tomada");
            }
            //-----------En el caso de que el Bitmap este lleno---------
            else
            {
                MessageBox.Show("No se pudo tomar la foto");
            }
        }
        //Método TerminarWebCamara
        public void TerminarWebCamara()
        {
            try
            {
                //------------------Validar si hay cámaras disponibles y si se ha seleccionado alguna----------
                if (filterInfoCollection == null || filterInfoCollection.Count == 0 || frm.cboCamara.SelectedIndex < 0)
                {
                    MessageBox.Show("No hay cámara activa para cerrar.");
                    return; //------------No hacemos nada más, evitamos la excepción------------------------
                }

                //----------------Crear el dispositivo solo si todo es válido---------------
                videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[frm.cboCamara.SelectedIndex].MonikerString);

                //---------------------Validamos si el dispositivo está corriendo-----------------
                if (videoCaptureDevice != null && videoCaptureDevice.IsRunning)
                {
                    videoCaptureDevice.SignalToStop();
                    videoCaptureDevice.WaitForStop();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar cerrar la webcam: " + ex.Message);
            }

        }
    }
}
