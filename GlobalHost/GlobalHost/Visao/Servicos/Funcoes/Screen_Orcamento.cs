using System;
using System.Data;
using System.Windows.Forms;
using GlobalHost.Controlador;
using GlobalHost.Modelo;

namespace GlobalHost.Visao.Servicos.Funcoes
{
    public partial class Screen_Orcamento : UserControl
    {
        private DataTable taxas;
        private int con;
        private double TOTAL;
        private DataTable cargas;
        private int id;
        private int new_id;
        private int teste;

        public Screen_Orcamento ()
        {
            con = 0;
            teste = 0;
            TOTAL = 0;
            taxas = new DataTable();
            taxas.Columns.Add("id", typeof(int));
            taxas.Columns.Add("descricao", typeof(string));
            taxas.Columns.Add("valor", typeof(double));

            InitializeComponent();
            string aux = "autorizado";
            cbPedido.DataSource = Controle_Pedido.get("autorizacao LIKE '%" + aux + "%' AND remessa is null");
            cbPedido.DisplayMember = "id";
            cbPedido.ValueMember = "id";
            try { cbPedido.SelectedIndex = 0; } catch { }
            

            cbTransp.DataSource = Controle_Transportadora.get("");
            cbTransp.DisplayMember = "nome";
            cbTransp.ValueMember = "id";
            cbTransp.SelectedIndex = 0;
        }

        public void Load()
        {
            string aux = "autorizado";
            cbPedido.DataSource = Controle_Pedido.get("autorizacao LIKE '%" + aux + "%' AND remessa is null");
            cbPedido.DisplayMember = "id";
            cbPedido.ValueMember = "id";
            try { cbPedido.SelectedIndex = 0; } catch { }

            cbTransp.DataSource = Controle_Transportadora.get("");
            cbTransp.DisplayMember = "nome";
            cbTransp.ValueMember = "id";
            try { cbTransp.SelectedIndex = 0; } catch { }
        }

        private void todo()
        {
            cbTransp.Enabled = true;
            lbValHead.Visible = false;
            lbVal.Visible = false;
            lbVal.Text = string.Empty;
            btAbrir.Enabled = true;
            btCancelar.Enabled = true;
            lbValCabec.Visible = true;
            dtpVencimento.Visible = true;
            gbTab.Enabled = true;
            double serv = 0;
            double tot = 0;
            for (int i = 0; i < cargas.Rows.Count; i++)
            {
                tot += Convert.ToDouble(cargas.Rows[i]["valor"]);
                serv += (Convert.ToDouble(cargas.Rows[i]["valor"]) * 0.1);
            }
            double valor_transp = Convert.ToDouble(Controle_Transportadora.get(Convert.ToInt32(cbTransp.SelectedValue)).Rows[0]["valor"]);
            string nome_trans = Controle_Transportadora.get("id = " + cbTransp.SelectedValue.ToString()).Rows[0]["nome"].ToString();
            string mod = Controle_Pedido.get("id = " + id).Rows[0]["modalidade"].ToString();
            double exclusiv = 0;
            if (mod.Equals("Exclusivo"))
                exclusiv = (int)(valor_transp / 10);
            double importacao = (int)(tot * 0.05);
            double pis = tot * 0.0165;
            double cofins = tot * 0.076;
            double dolar = 50 * API.Quot.getDolar();
            double imposto = 0;
            if (tot >= dolar)
                imposto = tot * 0.6;
            DataRow linha_serv = taxas.NewRow();
            linha_serv["id"] = con++;
            linha_serv["descricao"] = "Taxa de Serviço - R$";
            linha_serv["valor"] = serv;
            TOTAL += serv;
            taxas.Rows.Add(linha_serv);
            if (mod.Equals("Exclusivo"))
            {
                DataRow linha_excl = taxas.NewRow();
                linha_excl["id"] = con++;
                linha_excl["descricao"] = "Taxa de Pedido Exclusivo - R$";
                linha_excl["valor"] = exclusiv;
                TOTAL += exclusiv;
                taxas.Rows.Add(linha_excl);
            }
            DataRow linha_trans = taxas.NewRow();
            linha_trans["id"] = con++;
            linha_trans["descricao"] = "Taxa de Transporte (" + nome_trans + ") - R$";
            linha_trans["valor"] = valor_transp;
            TOTAL += valor_transp;
            taxas.Rows.Add(linha_trans);

            DataRow linha_imp = taxas.NewRow();
            linha_imp["id"] = con++;
            linha_imp["descricao"] = "Taxa de Importação - R$";
            linha_imp["valor"] = importacao;
            TOTAL += importacao;
            taxas.Rows.Add(linha_imp);

            DataRow linha_confins = taxas.NewRow();
            linha_confins["id"] = con++;
            linha_confins["descricao"] = "COFINS - R$";
            linha_confins["valor"] = cofins;
            TOTAL += cofins;
            taxas.Rows.Add(linha_confins);

            DataRow linha_pis = taxas.NewRow();
            linha_pis["id"] = con++;
            linha_pis["descricao"] = "PIS/PASEP - R$";
            linha_pis["valor"] = pis;
            TOTAL += pis;
            taxas.Rows.Add(linha_pis);

            DataRow linha_alf = taxas.NewRow();
            linha_alf["id"] = con++;
            linha_alf["descricao"] = "Taxa Alfandegária - R$";
            linha_alf["valor"] = imposto;
            TOTAL += imposto;
            taxas.Rows.Add(linha_alf);

            lbTotal.Text = "R$ " + TOTAL.ToString();
            dgvTaxa.DataSource = taxas;
        }

        private void cbPedido_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(teste.ToString());
            teste++;
            if(cbPedido.SelectedItem != null && teste > 2)
            {
                con = 1;
                TOTAL = 0;
                listaCargas.Items.Clear();
                taxas.Rows.Clear();
                dgvTaxa.DataSource = taxas;
                try
                {
                    id = Convert.ToInt32(((DataRowView)cbPedido.SelectedValue)["id"]);
                }
                catch
                {
                    id = Convert.ToInt32(cbPedido.SelectedValue);
                }
                cargas = Controle_Carga.get("pedido = " + id);
                for (int i = 0; i < cargas.Rows.Count; i++)
                {
                    string str = "- " + cargas.Rows[i]["descricao"].ToString() + " (" + cargas.Rows[i]["volume"].ToString() + ")";
                    listaCargas.Items.Add(str);
                }
                DataTable orc = Controle_Orcamento.get("pedido = " + id);
                if (orc.Rows.Count > 0)
                {
                    int id_orc = Convert.ToInt32(orc.Rows[0]["id"]);
                    taxas = Controle_Taxa.get("orcamento = " + id_orc);
                    taxas.Columns.Remove("orcamento");
                    dgvTaxa.DataSource = taxas;
                    for (int i = 0; i < taxas.Rows.Count; i++)
                    {
                        TOTAL += Convert.ToDouble(taxas.Rows[i]["valor"]);
                    }
                    lbTotal.Text = TOTAL.ToString();
                    btAbrir.Enabled = false;
                    btCancelar.Enabled = false;
                    lbValCabec.Visible = false;
                    dtpVencimento.Visible = false;
                    gbTab.Enabled = false;
                    lbValHead.Visible = true;
                    lbVal.Visible = true;
                    cbTransp.Enabled = false;
                    lbVal.Text = Convert.ToDateTime(Controle_Orcamento.get(id_orc).Rows[0]["validade"]).ToShortDateString();
                } 
                else 
                { 
                    todo(); 
                }
                cargas.Dispose();
                orc.Dispose();
            }            
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            if (txtDesc.Text != string.Empty)
            {
                if (txtValor.Text != string.Empty)
                {
                    DataRow linha = taxas.NewRow();
                    linha["id"] = con++;
                    linha["descricao"] = txtDesc.Text;
                    linha["valor"] = Convert.ToDouble(txtValor.Text);
                    TOTAL += Convert.ToDouble(linha["valor"]);
                    taxas.Rows.Add(linha);
                    lbTotal.Text = "R$ " + TOTAL.ToString();
                    dgvTaxa.DataSource = taxas;
                    ////////////////
                    txtID.Text = string.Empty;
                    txtValor.Text = string.Empty;
                    txtDesc.Text = string.Empty;
                }
                else
                    MessageBox.Show("Valor deve ser válido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Descrição deve ser válida!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);       
        }

        private void btAtualizar_Click(object sender, EventArgs e)
        {
            if (txtID.Text != string.Empty)
            {
                if (txtDesc.Text != string.Empty)
                {
                    if (txtValor.Text != string.Empty)
                    {
                        for (int i = 0; i < taxas.Rows.Count; i++)
                        {
                            if (Convert.ToInt32(taxas.Rows[i]["id"]) == Convert.ToInt32(txtID.Text))
                            {
                                taxas.Rows[i]["descricao"] = txtDesc.Text;
                                TOTAL -= Convert.ToDouble(taxas.Rows[i]["valor"]);
                                taxas.Rows[i]["valor"] = Convert.ToDouble(txtValor.Text);
                                TOTAL += Convert.ToDouble(taxas.Rows[i]["valor"]);
                                lbTotal.Text = "R$ " + TOTAL;
                                ////////////////
                                txtID.Text = string.Empty;
                                txtValor.Text = string.Empty;
                                txtDesc.Text = string.Empty;
                            }
                        }
                    }
                    else
                        MessageBox.Show("Valor deve ser válido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Descrição deve ser válida!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("ID deve ser válida!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            cbPedido.SelectedItem = null;
            taxas.Rows.Clear();
            dgvTaxa.DataSource = taxas;
            listaCargas.Items.Clear();
            lbTotal.Text = "-";
            this.con = 0;            
        }

        private void btAbrir_Click(object sender, EventArgs e)
        {
            if (dtpVencimento.Value > DateTime.Now)
            {
                if (dgvTaxa.Rows.Count > 0 && taxas.Rows.Count > 0 && listaCargas.Items.Count > 0)
                {
                    if (!Controle_Orcamento.Insert(TOTAL, DateTime.Now, dtpVencimento.Value, id, (int)cbTransp.SelectedValue))
                        MessageBox.Show("Erro ao Orçar pedido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        //MessageBox.Show("");
                        int max = Controle_Orcamento.MAX();
                        try
                        {
                            for (int i = 0; i < taxas.Rows.Count; i++)
                                Controle_Taxa.Insert(taxas.Rows[i]["descricao"].ToString(), Convert.ToDouble(taxas.Rows[i]["valor"]), max);
                            try
                            {
                                id = Convert.ToInt32(((DataRowView)cbPedido.SelectedValue)["id"]);
                            }
                            catch
                            {
                                id = Convert.ToInt32(cbPedido.SelectedValue);
                            }
                            Controle_Pedido.UpdateSituacao(id, "Orçado");
                            ///////////////////////
                            this.con = 0;
                            //////////////////////
                            btAbrir.Enabled = false;
                            btCancelar.Enabled = false;
                            lbValCabec.Visible = false;
                            dtpVencimento.Visible = false;
                            gbTab.Enabled = false;
                            lbValHead.Visible = true;
                            lbVal.Visible = true;
                            lbVal.Text = Convert.ToDateTime(Controle_Orcamento.get(Controle_Orcamento.MAX()).Rows[0]["validade"]).ToShortDateString();
                            MessageBox.Show("Orçamento feito com Sucesso!\nFrete do Pedido já disponível para abertura (Consulte 'Abrir Frete')\nA aprovação do Orçamento expira " + lbVal.Text, "Orçado com Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            Controle_Orcamento.Delete(max);
                        }
                    }
                }
                else
                    MessageBox.Show("Não é possível fazer um orçamento vazio!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Data de Vencimento deve não pode ser na data de hoje ou anteriores!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ToolMS_dgvPedido_Exluir_Click(object sender, EventArgs e)
        {
            if(dgvTaxa.SelectedRows.Count == 1)
            {
                int aux_id = dgvTaxa.SelectedRows[0].Index;
                taxas.Rows.RemoveAt(aux_id);
                dgvTaxa.DataSource = taxas;
            }
        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {
            if (txtValor.Text != string.Empty)
            {
                txtValor.Text = API.Validate.MONEY(txtValor.Text);
            }
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            if (txtID.Text != "")
            {
                try
                {
                    new_id = Convert.ToInt32(txtID.Text);
                    txtID.Select(txtID.Text.Length, 0);
                }
                catch (Exception)
                {
                    txtID.Text = new_id.ToString();
                    txtID.Select(txtID.Text.Length, 0);
                }
            }
        }

        private void dgvTaxa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTaxa.SelectedRows.Count == 1)
            {
                int aux = dgvTaxa.SelectedRows[0].Index;
                txtID.Text = taxas.Rows[aux]["id"].ToString();
                txtDesc.Text = taxas.Rows[aux]["descricao"].ToString();
                txtValor.Text = taxas.Rows[aux]["valor"].ToString();
            }
        }

        private void dtpVencimento_ValueChanged(object sender, EventArgs e)
        {
            if(dtpVencimento.Value < DateTime.Now)
            {
                MessageBox.Show("Data de Vencimento do Orçamento não pode ser anterior ao dia de hoje!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpVencimento.Value = DateTime.Now;
            }
        }
    }
}
