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

namespace GlobalHost.Visao.Servicos.Funcoes
{
    public partial class Screen_AbrirFrete : UserControl
    {
        public Screen_AbrirFrete()
        {
            InitializeComponent();
            cbPedido.DataSource = Controle_Pedido.get("");
            cbPedido.DisplayMember = "id";
            cbPedido.ValueMember = "id";
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            int rem = Convert.ToInt32(Controle_Pedido.get("id = " + cbPedido.Text).Rows[0]["remessa"]);
            //lRemessa.Text = Controle_Remessa;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {

        }
    }
}
