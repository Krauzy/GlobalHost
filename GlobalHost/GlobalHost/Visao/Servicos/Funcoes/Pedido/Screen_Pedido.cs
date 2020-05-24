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
    public partial class Screen_Pedido : UserControl
    {
        private bool ins;
        private bool alt;
        private bool exc;

        public Screen_Pedido()
        {
            InitializeComponent();
            cbCliente.DataSource = Controle_Cliente.get("");
            cbCliente.DisplayMember = "nome";
            cbCliente.ValueMember = "id";
            cbCliente.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbCliente.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbCliente.SelectedItem = null;
            cbCliente.Text = string.Empty;
            cbFiltroCarga.SelectedIndex = 0;
            cbFiltroPedido.SelectedIndex = 0;
        }

        private void changebool()
        {
            if (!ins)
            {
                btnInserir.ForeColor = Color.FromArgb(0, 122, 204);
                btnInserir.BackColor = Color.White;
                btnInserir.Image = GlobalHost.Properties.Resources.insert2;
            }
            if (!alt)
            {
                btnAlterar.ForeColor = Color.FromArgb(0, 122, 204);
                btnAlterar.BackColor = Color.White;
                btnAlterar.Image = GlobalHost.Properties.Resources.alterar2;
            }
            if (!exc)
            {
                btnExcluir.ForeColor = Color.FromArgb(0, 122, 204);
                btnExcluir.BackColor = Color.White;
                btnExcluir.Image = GlobalHost.Properties.Resources.lixo2;
            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            btnInserir.ForeColor = Color.White;
            btnInserir.BackColor = Color.FromArgb(0, 122, 204);
            btnInserir.Image = GlobalHost.Properties.Resources.insert;

            txtID.Enabled = false;
            cbCliente.Enabled = true;
            txtOrigem.Enabled = true;
            btOrigem.Enabled = true;
            txtDestino.Enabled = true;
            btDestino.Enabled = true;
            btnOk.Enabled = true;
            btnCancelar.Enabled = true;
            btMais.Enabled = true;
            btMenos.Enabled = true;
            btUpdate.Enabled = true;
            rdExclusivo.Enabled = true;
            rdExpresso.Enabled = true;

            ins = true;
            alt = false;
            exc = false;
            changebool();
            this.ActiveControl = null;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            btnAlterar.ForeColor = Color.White;
            btnAlterar.BackColor = Color.FromArgb(0, 122, 204);
            btnAlterar.Image = GlobalHost.Properties.Resources.alterar;

            txtID.Enabled = true;
            cbCliente.Enabled = true;
            txtOrigem.Enabled = true;
            btOrigem.Enabled = true;
            txtDestino.Enabled = true;
            btDestino.Enabled = true;
            btnOk.Enabled = true;
            btnCancelar.Enabled = true;
            btMais.Enabled = true;
            btMenos.Enabled = true;
            btUpdate.Enabled = true;
            rdExclusivo.Enabled = true;
            rdExpresso.Enabled = true;

            ins = false;
            alt = true;
            exc = false;
            changebool();
            this.ActiveControl = null;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            btnExcluir.ForeColor = Color.White;
            btnExcluir.BackColor = Color.FromArgb(0, 122, 204);
            btnExcluir.Image = GlobalHost.Properties.Resources.lixo;

            txtID.Enabled = true;
            cbCliente.Enabled = false;
            txtOrigem.Enabled = false;
            btOrigem.Enabled = false;
            txtDestino.Enabled = false;
            btDestino.Enabled = false;
            btnOk.Enabled = true;
            btnCancelar.Enabled = true;
            btMais.Enabled = false;
            btMenos.Enabled = false;
            btUpdate.Enabled = false;
            rdExclusivo.Enabled = false;
            rdExpresso.Enabled = false;

            ins = false;
            alt = false;
            exc = true;
            changebool();
            this.ActiveControl = null;
        }

        private void btOrigem_Click(object sender, EventArgs e)
        {
            CEPTool ex = new CEPTool();
            ex.ShowDialog();
            if(!ex.IsCancel)
                txtOrigem.Text = ex.Str;
            ex.Dispose();
            this.ActiveControl = null;
        }

        private void btDestino_Click(object sender, EventArgs e)
        {
            CEPTool ex = new CEPTool();
            ex.ShowDialog();
            if (!ex.IsCancel)
                txtDestino.Text = ex.Str;
            ex.Dispose();
            this.ActiveControl = null;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtID.Enabled = false;
            cbCliente.Enabled = false;
            txtOrigem.Enabled = false;
            btOrigem.Enabled = false;
            txtDestino.Enabled = false;
            btDestino.Enabled = false;
            btnOk.Enabled = false;
            btnCancelar.Enabled = false;
            btMais.Enabled = false;
            btMenos.Enabled = false;
            btUpdate.Enabled = false;
            rdExclusivo.Enabled = false;
            rdExpresso.Enabled = false;

            ins = false;
            alt = false;
            exc = false;
            changebool();
            this.ActiveControl = null;
        }
    }
}
