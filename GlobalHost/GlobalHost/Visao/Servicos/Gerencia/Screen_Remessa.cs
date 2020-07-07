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
        private DataTable DataPedido;
        private int ID;
        private double V;
        public Screen_Remessa()
        {
            InitializeComponent();
            txtID.Enabled = false;
            DataPedido = Controle_Pedido.get("");
            DataPedido.Rows.Clear();
            cbTransportadora.DataSource = Controle_Transportadora.get("");
            cbTransportadora.DisplayMember = "nome";
            cbTransportadora.ValueMember = "id";
            cbFiltroPedido.DataSource = Controle_Pedido.get("remessa is null or remessa = 0");
            cbFiltroPedido.DisplayMember = "nome";
            cbFiltroPedido.ValueMember = "id";
            dgvRemessa.DataSource = Controle_Remessa.get("");
            cbFiltroPedido.SelectedIndex = -1;
            cbTransportadora.SelectedIndex = -1;
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
            btMais.Enabled = true;
            btMenos.Enabled = true;
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
            else if (dtpSaida.Value <= DateTime.Now)
            {
                MessageBox.Show("Data de SAÍDA inferior ao dia corrente!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (dtpPrevisao.Value <= dtpSaida.Value)
            {
                MessageBox.Show("Data de PREVISÃO superior ao dia corrente!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (dtpRequerimento.Value >= dtpSaida.Value)
            {
                MessageBox.Show("Data de REQUERIMENTO superior a data de SAÍDA!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            dgvPedido.DataSource = Controle_Pedido.get("id = -1");
            //dgvPedido.Rows.Clear();
        }


        private void btnInserir_Click(object sender, EventArgs e)
        {
            _default();
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
            btnAlterar.ForeColor = Color.White;
            btnAlterar.BackColor = Color.FromArgb(0, 122, 204);
            btnAlterar.Image = GlobalHost.Properties.Resources.alterar;

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

            btnExcluir.ForeColor = Color.White;
            btnExcluir.BackColor = Color.FromArgb(0, 122, 204);
            btnExcluir.Image = GlobalHost.Properties.Resources.lixo;

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
                    _default();
                }
            }
            else if (alt == true)
            {
                if (check())
                {
                    DataTable dtP = Controle_Pedido.get("remessa = " + txtID.Text);
                    MessageBox.Show("" + dtP.Rows.Count);
                    MessageBox.Show("" + dgvPedido.Rows.Count);
                    for (int i = 0; i < dtP.Rows.Count; i++)
                        Controle_Pedido.SetRemessaID((int)dtP.Rows[i]["id"], 0);
                    for (int i = 0; i < dgvPedido.Rows.Count; i++)
                        Controle_Pedido.UpdateByRemessa((int)dgvPedido.Rows[i].Cells["Pedido_ID"].Value, Convert.ToInt32(txtID.Text));
                    Controle_Remessa.update(Convert.ToInt32(txtID.Text), txtDescricao.Text, txtOrigem.Text, txtDestino.Text, dtpSaida.Value, dtpPrevisao.Value,
                        dtpRequerimento.Value, (int)cbTransportadora.SelectedValue);

                    _default();
                    dgvRemessa.DataSource = Controle_Remessa.get("");
                }
            }
            else if (exc == true)
            {
                
                if(MessageBox.Show("Deseja realmente excluir este pedido?", "ALERTA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    for (int i = 0; i < dgvPedido.Rows.Count; i++)
                        Controle_Pedido.SetRemessaID((int)dgvPedido.Rows[i].Cells["Pedido_ID"].Value, 0);
                    Controle_Remessa.delete(Convert.ToInt32(txtID.Text));
                    dgvRemessa.DataSource = Controle_Remessa.get("");
                }
                else
                    _default();
            }
            //_default();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ins = false;
            alt = false;
            exc = false;
            changeBool();
            _default();
        }

        private void LoadGrid()
        {
            if (dgvPedido.Rows.Count > 0)
                dgvPedido.Rows.Clear();
            for (int i = 0; i < DataPedido.Rows.Count; i++)
            {
                dgvPedido.Rows.Add();
                dgvPedido.Rows[i].Cells["Pedido_ID"].Value = DataPedido.Rows[i]["id"];
                dgvPedido.Rows[i].Cells["Pedido_Data"].Value = DataPedido.Rows[i]["data"];
                dgvPedido.Rows[i].Cells["Pedido_Modalidade"].Value = DataPedido.Rows[i]["modalidade"];
                dgvPedido.Rows[i].Cells["Pedido_Origem"].Value = DataPedido.Rows[i]["origem"];
                dgvPedido.Rows[i].Cells["Pedido_Destino"].Value = DataPedido.Rows[i]["destino"];
                dgvPedido.Rows[i].Cells["Pedido_Despachante"].Value = DataPedido.Rows[i]["despachante"];
                dgvPedido.Rows[i].Cells["Pedido_Situacao"].Value = DataPedido.Rows[i]["situacao"];
                dgvPedido.Rows[i].Cells["Pedido_Cliente"].Value = DataPedido.Rows[i]["cliente"];
                dgvPedido.Rows[i].Cells["Pedido_Funcionario"].Value = DataPedido.Rows[i]["funcionario"];
                dgvPedido.Rows[i].Cells["Pedido_Remessa"].Value = DataPedido.Rows[i]["remessa"];
            }
        }

        private void LoadTable()
        {
            DataPedido.Rows.Clear();
            for (int i = 0; i < dgvPedido.Rows.Count; i++)
            {
                DataRow linha = DataPedido.NewRow();
                linha["id"] = dgvPedido.Rows[i].Cells["Pedido_ID"].Value;
                linha["data"] = dgvPedido.Rows[i].Cells["Pedido_Data"].Value;
                linha["modalidade"] = dgvPedido.Rows[i].Cells["Pedido_Modalidade"].Value;
                linha["origem"] = dgvPedido.Rows[i].Cells["Pedido_Origem"].Value;
                linha["destino"] = dgvPedido.Rows[i].Cells["Pedido_Destino"].Value;
                linha["despachante"] = dgvPedido.Rows[i].Cells["Pedido_Despachante"].Value;
                linha["situacao"] = dgvPedido.Rows[i].Cells["Pedido_Situacao"].Value;
                linha["cliente"] = dgvPedido.Rows[i].Cells["Pedido_Destino"].Value;
                linha["funcionario"] = dgvPedido.Rows[i].Cells["Pedido_Despachante"].Value;
                linha["remessa"] = dgvPedido.Rows[i].Cells["Pedido_Remessa"].Value;
                //linha["tipo"] = Controle_Remessa.get("descricao LIKE '%" + dgvPedido.Rows[i].Cells["P"].Value.ToString() + "%'").Rows[0];
                //DataPedido.Rows.Add(linha);
            }
        }

        private void btMais_Click(object sender, EventArgs e)
        {
            if (cbFiltroPedido.SelectedIndex > -1)
            {
                //dgvPedido.DataSource = Controle_Pedido.get("id = " + Convert.ToInt32(cbFiltroPedido.Text));
                
                DataTable dtMais = Controle_Pedido.get("id = " + Convert.ToInt32(cbFiltroPedido.Text));
                DataRow linha = DataPedido.NewRow();
                linha["id"] = dtMais.Rows[0]["id"];
                linha["data"] = dtMais.Rows[0]["data"];
                linha["modalidade"] = dtMais.Rows[0]["modalidade"];
                linha["origem"] = dtMais.Rows[0]["origem"];
                linha["destino"] = dtMais.Rows[0]["destino"];
                linha["despachante"] = dtMais.Rows[0]["despachante"];
                linha["situacao"] = dtMais.Rows[0]["situacao"];
                linha["cliente"] = dtMais.Rows[0]["cliente"];
                linha["funcionario"] = dtMais.Rows[0]["funcionario"];
                linha["remessa"] = dtMais.Rows[0]["remessa"];
                linha["autorizacao"] = dtMais.Rows[0]["autorizacao"];
                DataPedido.Rows.Add(linha);
                dgvPedido.DataSource = DataPedido;

                //dgvPedido.Rows.Add();
                //dgvPedido.Rows[dgvPedido.Rows.Count - 1].Cells["Pedido_ID"].Value = dtMais.Rows[0]["id"];
                //dgvPedido.Rows[dgvPedido.Rows.Count - 1].Cells["Pedido_Data"].Value = dtMais.Rows[0]["data"];
                //dgvPedido.Rows[dgvPedido.Rows.Count - 1].Cells["Pedido_Modalidade"].Value = dtMais.Rows[0]["modalidade"];
                //dgvPedido.Rows[dgvPedido.Rows.Count - 1].Cells["Pedido_Origem"].Value = dtMais.Rows[0]["origem"];
                //dgvPedido.Rows[dgvPedido.Rows.Count - 1].Cells["Pedido_Destino"].Value = dtMais.Rows[0]["destino"];
                //dgvPedido.Rows[dgvPedido.Rows.Count - 1].Cells["Pedido_Despachante"].Value = dtMais.Rows[0]["despachante"];
                //dgvPedido.Rows[dgvPedido.Rows.Count - 1].Cells["Pedido_Situacao"].Value = dtMais.Rows[0]["situacao"];
                //dgvPedido.Rows[dgvPedido.Rows.Count - 1].Cells["Pedido_Cliente"].Value = dtMais.Rows[0]["cliente"];
                //dgvPedido.Rows[dgvPedido.Rows.Count - 1].Cells["Pedido_Funcionario"].Value = dtMais.Rows[0]["funcionario"];
                //dgvPedido.Rows[dgvPedido.Rows.Count - 1].Cells["Pedido_Remessa"].Value = dtMais.Rows[0]["remessa"];
                //dgvPedido.Rows[dgvPedido.Rows.Count - 1].Cells["Pedido_Autorizacao"].Value = dtMais.Rows[0]["autorizacao"];
                
            }
            else
                MessageBox.Show("Selecione um pedido!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //LoadGrid();
        }

        private void btMenos_Click(object sender, EventArgs e)
        {
            if (dgvPedido.SelectedRows.Count == 1)
            {
                int i = dgvPedido.SelectedRows[0].Index;
                DataPedido.Rows.RemoveAt(i);
                dgvPedido.DataSource = DataPedido;
            }
            else
                MessageBox.Show("Selecione um pedido para ser excluído!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void dgvRemessa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvRemessa.SelectedRows.Count == 1)
            {
                txtID.Text = dgvRemessa.SelectedRows[0].Cells["ID_Remessa"].Value.ToString();
                txtDescricao.Text = dgvRemessa.SelectedRows[0].Cells["Descricao_Remessa"].Value.ToString();
                txtOrigem.Text = dgvRemessa.SelectedRows[0].Cells["Origem_Remessa"].Value.ToString();
                txtDestino.Text = dgvRemessa.SelectedRows[0].Cells["Destino_Remessa"].Value.ToString();
                cbTransportadora.Text = dgvRemessa.SelectedRows[0].Cells["Transportadora_Remessa"].Value.ToString();
                dtpPrevisao.Value = Convert.ToDateTime(dgvRemessa.SelectedRows[0].Cells["PrevisaoRequerida_Remessa"].Value.ToString());
                dtpSaida.Value = Convert.ToDateTime(dgvRemessa.SelectedRows[0].Cells["DataSaida_Remessa"].Value.ToString());
                DataPedido = Controle_Pedido.get("remessa = " + Convert.ToInt32(txtID.Text));
                dgvPedido.DataSource = DataPedido;
            }
        }
    }
}
