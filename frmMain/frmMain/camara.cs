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
        private VideoCapture[] capture;
        private Mat Frame;
        public camara()
        {

        }

        public void Inicializar(int Indice,ImageBox imgBox)
        {
            capture[Indice] = new VideoCapture(Indice);
            capture[Indice].ImageGrabbed += CapturarImagen(imgBox,Indice);
            Frame = new Mat();

        }

        private EventHandler CapturarImagen(ImageBox imgBox, int Indice)
        {
            if (capture != null && capture[Indice].Ptr != IntPtr.Zero)
            {
                capture[Indice].Retrieve(Frame, 0);
                imgBox.Image = Frame;
            }
            throw new NotImplementedException();
        }

        public void start(int Indice)
        {
            if (capture[Indice] != null)
            {
                try
                {
                    capture[Indice].Start();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public void stop(int Indice)
        {
            capture[Indice].Stop();
        }

    }
}
