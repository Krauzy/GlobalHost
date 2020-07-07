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
using GlobalHost.Modelo;

namespace GlobalHost.Visao.Servicos.Funcoes
{
    public partial class Screen_AbrirFrete : UserControl
    {
        public Screen_AbrirFrete()
        {
            InitializeComponent();
            string str = "Orçado";
            DataTable pedidos = Controle_Pedido.get("situacao LIKE '%" + str + "%'");                
            cbPedido.DataSource = pedidos;
            cbPedido.DisplayMember = "id";
            cbPedido.ValueMember = "id";
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            int rem = ((Remessa)(Controle_Pedido.get("id = " + cbPedido.Text).Rows[0]["remessa"])).Id;
            lRemessa.Text = Controle_Remessa.get("id = " + rem).Rows[0]["descricao"].ToString();
            DataTable dtcargas = Controle_Carga.get("pedido = " + cbPedido.Text);
            for(int i = 0; i < dtcargas.Rows.Count; i++)
            {
                string str = "";
                str += "- " + dtcargas.Rows[i]["descricao"].ToString();
                str += " (" + dtcargas.Rows[i]["volume"].ToString() + ")";
                listCargas.Items.Add(str);
            }
            string aux = Controle_Pedido.get("id = " + cbPedido.Text).Rows[0]["origem"].ToString();
            if (aux.Length > 20)
                aux = aux.Substring(0, 17) + "...";
            lOrigem.Text = aux;
            aux = Controle_Pedido.get("id = " + cbPedido.Text).Rows[0]["destino"].ToString();
            if (aux.Length > 20)
                aux = aux.Substring(0, 17) + "...";
            lDestino.Text = aux;
            int trans = ((Transportadora)(Controle_Remessa.get("id = " + rem).Rows[0]["transportadora"])).Id;
            lTransporte.Text = Controle_Transportadora.get("id = " + trans).Rows[0]["nome"].ToString();
            lValorFreteAtual.Text = "0,00";
            lValorFreteFinal.Text = Controle_Orcamento.get("pedido = " + cbPedido.Text).Rows[0]["valor"].ToString();

            lPrevisaoEntrega.Text = Convert.ToDateTime(Controle_Remessa.get("id = " + rem).Rows[0]["previsao_requerida"]).ToShortDateString();
            if (dgvFrete.Rows.Count < 1)
                dgvFrete.Rows.Add();
            dgvFrete.Rows[0].Cells[0].Value = DateTime.Now.ToShortDateString();
            dgvFrete.Rows[0].Cells[1].Value = Controle_Pedido.get("id = " + cbPedido.Text).Rows[0]["situacao"].ToString();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Frete Aberto!", "FRETE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgvFrete.DataSource = Controle_Pedido.get("id = -1");
            lOrigem.Text = "";
            lDestino.Text = "";
            lPrevisaoEntrega.Text = "";
            lRemessa.Text = "";
            lTransporte.Text = "";
            lValorFreteAtual.Text = "";
            lValorFreteFinal.Text = "";
            listCargas.Items.Clear();

            //Fechar Frete
        }
    }
}
