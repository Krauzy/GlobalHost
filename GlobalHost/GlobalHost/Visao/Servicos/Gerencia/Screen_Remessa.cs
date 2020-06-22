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

namespace GlobalHost.Visao.Servicos.Gerencia
{
    public partial class Screen_Remessa : UserControl
    {
        private bool ins = false;
        private bool alt = false;
        private bool exc = false;
        private DataTable data;
        private int ID;
        private double V;
        public Screen_Remessa()
        {
            InitializeComponent();
            txtID.Enabled = false;

            cbTransportadora.DataSource = Controle_Transportadora.get("");
            cbTransportadora.DisplayMember = "nome";
            cbTransportadora.ValueMember = "id";
            cbFiltroPedido.DataSource = Controle_Pedido.get("");
            cbFiltroPedido.DisplayMember = "nome";
            cbFiltroPedido.ValueMember = "id";
            dgvRemessa.DataSource = Controle_Remessa.get("");

            //cbTransportadora.SelectedValue


            gbPedido.Enabled = false;
            gbRemessa.Enabled = false;
            //txtDescricao.Enabled = false;
            //txtDestino.Enabled = false;
            //txtOrigem.Enabled = false;
            //cbTransportadora.Enabled = false;
            //dtpPrevisao.Enabled = false;
            //dtpRequerimento.Enabled = false;
            //dtpSaida.Enabled = false;
            //btCEPDestino.Enabled = false;
            //btCEPOrigem.Enabled = false;
        }

        private void changeBool()
        {
            if (ins == false)
            {
                btnInserir.ForeColor = Color.FromArgb(0, 122, 204);
                btnInserir.BackColor = Color.White;
                btnInserir.Image = GlobalHost.Properties.Resources.insert2;
            }
            if (alt == false)
            {
                btnAlterar.ForeColor = Color.FromArgb(0, 122, 204);
                btnAlterar.BackColor = Color.White;
                btnAlterar.Image = GlobalHost.Properties.Resources.alterar2;
            }
            if (exc == false)
            {
                btnExcluir.ForeColor = Color.FromArgb(0, 122, 204);
                btnExcluir.BackColor = Color.White;
                btnExcluir.Image = GlobalHost.Properties.Resources.lixo2;
            }
        }

        public void edition()
        {
            gbPedido.Enabled = true;
            gbRemessa.Enabled = true;
            //txtDescricao.Enabled = true;
            //txtDestino.Enabled = true;
            //txtOrigem.Enabled = true;
            //cbTransportadora.Enabled = true;
            //dtpPrevisao.Enabled = true;
            //dtpRequerimento.Enabled = true;
            //dtpSaida.Enabled = true;
            //gbPedido.Enabled = true;
            //btCEPDestino.Enabled = true;
            //btCEPOrigem.Enabled = true;
            btnOk.Enabled = true;
            btnCancelar.Enabled = true;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnInserir.Enabled = false;
        }

        public bool check()
        {

            if (txtDescricao.Text == string.Empty)
            {
                MessageBox.Show("Campo DESCRIÇÃO vazio!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (txtDestino.Text == string.Empty)
            {
                MessageBox.Show("Campo DESTINO vazio!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (txtOrigem.Text == string.Empty)
            {
                MessageBox.Show("Campo ORIGEM vazio!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (dtpSaida.Value < DateTime.Now)
            {
                MessageBox.Show("Data de SAÍDA inferior ao dia corrente!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (dtpPrevisao.Value <= DateTime.Now)
            {
                MessageBox.Show("Data de PREVISÃO inferior ao dia corrente!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (dtpRequerimento.Value <= DateTime.Now)
            {
                MessageBox.Show("Data de REQUERIMENTO inferior ao dia corrente!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (dtpSaida.Value > dtpPrevisao.Value)
            {
                MessageBox.Show("Data de SAÍDA não pode ser maior que a data de PREVISÃO!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (dgvPedido.Rows.Count < 0)
            {
                MessageBox.Show("A remessa deve conter pelo menos um pedido!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public void _default()
        {
            gbPedido.Enabled = false;
            gbRemessa.Enabled = false;
            btnOk.Enabled = false;
            btnCancelar.Enabled = false;
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
            btnInserir.Enabled = true;
            txtBusca.Text = string.Empty;
            txtDescricao.Text = string.Empty;
            txtDestino.Text = string.Empty;
            txtID.Text = string.Empty;
            txtOrigem.Text = string.Empty;
            cbFiltro.SelectedIndex = -1;
            cbFiltroPedido.SelectedIndex = -1;
            cbTransportadora.SelectedIndex = -1;
            dtpPrevisao.Value = DateTime.Now;
            dtpRequerimento.Value = DateTime.Now;
            dtpSaida.Value = DateTime.Now;
        }


        private void btnInserir_Click(object sender, EventArgs e)
        {
            btnInserir.ForeColor = Color.White;
            btnInserir.BackColor = Color.FromArgb(0, 122, 204);
            btnInserir.Image = GlobalHost.Properties.Resources.insert;

            ins = true;
            alt = false;
            exc = false;

            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            changeBool();
            edition();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            btnInserir.ForeColor = Color.White;
            btnInserir.BackColor = Color.FromArgb(0, 122, 204);
            btnInserir.Image = GlobalHost.Properties.Resources.insert;

            ins = false;
            alt = true;
            exc = false;

            btnExcluir.Enabled = false;
            btnInserir.Enabled = false;
            changeBool();
            edition();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            btnInserir.ForeColor = Color.White;
            btnInserir.BackColor = Color.FromArgb(0, 122, 204);
            btnInserir.Image = GlobalHost.Properties.Resources.insert;

            ins = false;
            alt = false;
            exc = true;

            btnAlterar.Enabled = false;
            btnInserir.Enabled = false;
            changeBool();
            edition();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {

            if (ins == true)
            {
                if (check())
                {
                    Controle_Remessa.insert(txtDescricao.Text, txtOrigem.Text, txtDestino.Text, dtpSaida.Value, dtpPrevisao.Value,
                        dtpRequerimento.Value, (int)cbTransportadora.SelectedValue);
                    for (int i = 0; i < dgvPedido.Rows.Count; i++)
                        Controle_Pedido.UpdateByRemessa((int)dgvPedido.Rows[i].Cells["Pedido_ID"].Value, Controle_Remessa.MAX());
                    dgvRemessa.DataSource = Controle_Remessa.get("");
                }
            }
            else if (alt == true)
            {
                if (check())
                {
                    Controle_Remessa.update(Convert.ToInt32(txtID.Text), txtDescricao.Text, txtOrigem.Text, txtDestino.Text, dtpSaida.Value, dtpPrevisao.Value,
                        dtpRequerimento.Value, (int)cbTransportadora.SelectedValue);
                    for (int i = 0; i < dgvPedido.Rows.Count; i++)
                        Controle_Pedido.UpdateByRemessa((int)dgvPedido.Rows[i].Cells["Pedido_ID"].Value, Convert.ToInt32(txtID.Text));
                    dgvRemessa.DataSource = Controle_Remessa.get("");
                }
            }
            else if (exc == true)
            {
                Controle_Remessa.delete(Convert.ToInt32(txtID.Text));
                for (int i = 0; i < dgvPedido.Rows.Count; i++)
                    Controle_Pedido.UpdateByRemessa((int)dgvPedido.Rows[i].Cells["Pedido_ID"].Value, -1);
                dgvRemessa.DataSource = Controle_Remessa.get("");
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            changeBool();
            _default();           
        }

        private void btMais_Click(object sender, EventArgs e)
        {

        }

        private void btMenos_Click(object sender, EventArgs e)
        {

        }

        private void btCEPOrigem_Click(object sender, EventArgs e)
        {
            CEPTool ex = new CEPTool();
            ex.ShowDialog();
            if (!ex.IsCancel)
                txtOrigem.Text = ex.Str;
        }

        private void btCEPDestino_Click(object sender, EventArgs e)
        {
            CEPTool ex = new CEPTool();
            ex.ShowDialog();
            if (!ex.IsCancel)
                txtDestino.Text = ex.Str;
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            if (txtBusca.Text != string.Empty)
            {
                try
                {
                    switch (cbFiltro.Text)
                    {
                        case "Descrição":
                            data = Controle_Remessa.get("descricao LIKE '%" + txtBusca.Text + "%'");
                            break;

                        case "Origem":
                            data = Controle_Remessa.get("origem LIKE '%" + txtBusca.Text + "%'");
                            break;

                        case "Destino":
                            data = Controle_Remessa.get("destino LIKE '%" + txtBusca.Text + "%'");
                            break;

                        case "Data de Saída":
                            data = Controle_Remessa.get("data_saida <= " + Convert.ToDateTime(txtBusca.Text));
                            break;

                        case "Previsão Requerida":
                            data = Controle_Remessa.get("previsao_requerida <= " + Convert.ToDateTime(txtBusca.Text));
                            break;

                        case "Data Requerida":
                            data = Controle_Remessa.get("data_requerida <= " + Convert.ToDateTime(txtBusca.Text));
                            break;

                            //case "Tipo de Transporte":
                            //    data = Controle_Remessa.get("");
                            //    DataTable temp = data.Clone();
                            //    temp.Clear();
                            //    foreach (DataRow linha in data.Rows)
                            //        if (linha["tipo"].ToString().ToUpper().Contains(txtBusca.Text.ToUpper()))
                            //            temp.ImportRow(linha);
                            //    data = temp;
                            //    temp.Dispose();
                            //    break;
                    }
                }
                catch (Exception)
                {
                    data = Controle_Remessa.get("");
                }
            }
            else
                data = Controle_Remessa.get("");
            dgvRemessa.DataSource = data;
        }
    }
}
