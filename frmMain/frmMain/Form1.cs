using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV.UI;

namespace frmMain
{
    public partial class frmMain : Form
    {
        camara ca1 = new camara();
        camara ca2 = new camara();
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            ca1.Inicializar(1,imgBox1);
            ca2.Inicializar(0, imgBox2);
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            ca1.start();
            ca2.start();
        }
    }
}
