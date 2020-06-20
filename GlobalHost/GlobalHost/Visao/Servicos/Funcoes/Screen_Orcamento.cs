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
        private int id_trans;
        private int id;

        public Screen_Orcamento()
        {
            con = 0;
            TOTAL = 0;
            taxas = new DataTable();
            taxas.Columns.Add("id", typeof(int));
            taxas.Columns.Add("descricao", typeof(string));
            taxas.Columns.Add("valor", typeof(double));

            InitializeComponent();
            string aux = "autorizado";
            cbPedido.DataSource = Controle_Pedido.get("autorizacao LIKE '%" + aux + "%'");
            cbPedido.DisplayMember = "id";
            cbPedido.ValueMember = "id";
            cbPedido.SelectedIndex = 0;
        }

        private void cbPedido_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbPedido.SelectedItem != null)
            {
                id = Convert.ToInt32(((DataRowView)cbPedido.SelectedValue)["id"]);
                DataTable cargas = Controle_Carga.get("pedido = " + id);
                for (int i = 0; i < cargas.Rows.Count; i++)
                {
                    string str = "- " + cargas.Rows[i]["descricao"].ToString() + " (" + cargas.Rows[i]["volume"].ToString() + ")";
                    listaCargas.Items.Add(str);
                }

                DataTable orc = Controle_Orcamento.get("pedido = " + id);
                if (orc.Rows.Count > 0)
                {
                    int id_orc = Convert.ToInt32(orc.Rows[0]["id"]);
                    taxas = Controle_Taxa.get("orcamento = " + id);
                    taxas.Columns.Remove("orcamento");
                    dgvTaxa.DataSource = taxas;
                    double tot = 0;
                    for(int i = 0; i < dgvTaxa.Rows.Count; i++)
                        tot += Convert.ToDouble(dgvTaxa.Rows[i].Cells[2].Value);
                    lbTotal.Text = "R$ " + tot.ToString();
                }
                else
                {
                    double serv = 0;
                    double tot = 0;
                    for (int i = 0; i < cargas.Rows.Count; i++)
                    {
                        tot += Convert.ToDouble(cargas.Rows[i]["valor"]);
                        serv += (Convert.ToDouble(cargas.Rows[i]["valor"]) * 0.1);
                    }
                    int id_rem = Convert.ToInt32(((Remessa)Controle_Pedido.get("id = " + id).Rows[0]["remessa"]).Id);
                    this.id_trans = Convert.ToInt32(((Transportadora)Controle_Remessa.get("id = " + id_rem).Rows[0]["transportadora"]).Id);
                    double valor_transp = Convert.ToDouble(Controle_Transportadora.get("id = " + id_trans).Rows[0]["valor"]);
                    string nome_trans = Controle_Transportadora.get("id = " + id_trans).Rows[0]["nome"].ToString();
                    string mod = Controle_Pedido.get("id = " + id).Rows[0]["modalidade"].ToString();
                    double exclusiv = 0;
                    if (mod.Equals("Exclusivo"))
                        exclusiv = (valor_transp * 0.2);
                    double importacao = tot * 0.05;
                    double pis = tot * 0.0165;
                    double cofins = tot * 0.076;
                    double dolar = 50 * API.Quot.getDolar();
                    double imposto = 0;
                    if (tot >= dolar)
                        imposto = tot * 0.6;
                    
                    double TOTAL = 0;
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
                    TOTAL += Convert.ToDouble(txtValor.Text);
                    taxas.Rows.Add(linha);
                    lbTotal.Text = "R$ " + TOTAL.ToString();
                    dgvTaxa.DataSource = taxas;
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
                                taxas.Rows[i]["valor"] = Convert.ToDouble(txtID.Text);
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
            dgvTaxa.Rows.Clear();
            taxas.Rows.Clear();
            listaCargas.Items.Clear();
            lbTotal.Text = "-";
            this.con = 0;
        }

        private void btAbrir_Click(object sender, EventArgs e)
        {
            if (dgvTaxa.Rows.Count > 0 && taxas.Rows.Count > 0 && listaCargas.Items.Count > 0)
            {
                if (!Controle_Orcamento.Insert(Convert.ToDouble(lbTotal.Text), DateTime.Now, DateTime.Now.AddDays(7), id, id_trans))
                    MessageBox.Show("Erro ao Orçar pedido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    int max = Controle_Orcamento.MAX();
                    for (int i = 0; i < taxas.Rows.Count; i++)
                        Controle_Taxa.Insert(taxas.Rows[i]["descricao"].ToString(), Convert.ToDouble(taxas.Rows[i]["valor"]), max);                    
                }                
            }
        }
    }
}
