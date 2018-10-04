using Emgu.CV;
using System.Windows.Forms;
using Emgu.CV.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmMain
{
    class camara
    {
        private VideoCapture capture;
        private Mat Frame;
        ImageBox imgBox1;
        private int Indice1 = 0;
        public camara()
        {

        }

        public void Inicializar(int Indice,ImageBox imgBox)
        {
         
            Indice1 = Indice;
            imgBox1 = imgBox;
            capture = new VideoCapture(Indice);
            capture.ImageGrabbed += CapturarImagen;
            Frame = new Mat();

        }

        private void CapturarImagen(object sender, EventArgs e)
        {
            if (capture != null && capture.Ptr != IntPtr.Zero)
            {
                capture.Retrieve(Frame, Indice1);
                imgBox1.Image = Frame;
            }
            
        }

        public void start()
        {
            if (capture != null)
            {
                try
                {
                    capture.Start();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public void stop()
        {
            capture.Stop();
        }

    }
}
