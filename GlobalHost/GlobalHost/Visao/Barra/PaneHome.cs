using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GlobalHost.Controlador;

namespace GlobalHost.Visao
{
    public partial class PaneHome : UserControl
    {
        public PaneHome()
        {
            InitializeComponent();
            picLogo.Image = Controle_Parametro.getLogo();
            lbRazao.Text = Controle_Parametro.get().Razao_social;
        }

        private void panel28_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel39_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel44_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
