using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GlobalHost.Visao.Servicos.Gerencia
{
    public partial class Screen_Remessa : UserControl
    {
        public Screen_Remessa()
        {
            InitializeComponent();
            txtID.Enabled = false;

            txtDescricao.Enabled = false;
            txtDestino.Enabled = false;
            txtOrigem.Enabled = false;
            dtpPrevisao.Enabled = false;
            dtpRequerimento.Enabled = false;
            dtpSaida.Enabled = false;
            dgvPedido.Enabled = false;
            


        }

        private void btnInserir_Click(object sender, EventArgs e)
        {

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void btMais_Click(object sender, EventArgs e)
        {

        }

        private void btMenos_Click(object sender, EventArgs e)
        {

        }

        private void btCEPOrigem_Click(object sender, EventArgs e)
        {

        }

        private void btCEPDestino_Click(object sender, EventArgs e)
        {

        }
    }
}
