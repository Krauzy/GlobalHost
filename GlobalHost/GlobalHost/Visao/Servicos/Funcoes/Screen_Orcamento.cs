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

        public Screen_Orcamento()
        {
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
                int id = Convert.ToInt32(((DataRowView)cbPedido.SelectedValue)["id"]);
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
                    int id_trans = Convert.ToInt32(((Transportadora)Controle_Remessa.get("id = " + id_rem).Rows[0]["transportadora"]).Id);
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
                    int con = 0;
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
    }
}
