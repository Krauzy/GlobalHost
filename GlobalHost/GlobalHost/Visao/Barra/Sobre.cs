using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GlobalHost.Visao
{
    public partial class Sobre : UserControl
    {
        private Visao.Menu menu;
        public Sobre()
        {
            InitializeComponent();
        }

        public void LoadLogo(Visao.Menu menu)
        {
            this.menu = menu;
        }

        private void linkParametro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Param ex = new Param();
            ex.LoadLogo(this.menu);
            ex.ShowDialog();
        }

    }
}
