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
using GlobalHost.API;

namespace GlobalHost.Visao.Servicos.Funcoes
{
    public partial class Screen_LancarDespesa : UserControl
    {
        Controle_Despesa cd;
        Controle_ContasPagar ccp;
        DataTable dt;
        public Screen_LancarDespesa()
        {
            InitializeComponent();
            cd = new Controle_Despesa();
            ccp = new Controle_ContasPagar();
            dt = new DataTable();
            dt.Columns.Add("descricao",typeof(string));
            dt.Columns.Add("valor", typeof(double));
            dt.Columns.Add("parcelas",typeof(int));
            dt.Columns.Add("tipo", typeof(string));
            dt.Columns.Add("estado", typeof(string));
            dt.Columns.Add("data_emissao", typeof(DateTime));
            dgvDespesas.DataSource = dt;
            btnExcluir.Enabled = false;
            cbbEstado.SelectedIndex = 0;
            Filters.alphanumericField(txtValor);
            Filters.alphanumericField(txtParcelas);
        }
        public void limpaCampos()
        {
            txtDesc.Clear();
            txtDesc.Clear();
            txtParcelas.Clear();
            txtValor.Clear();
            txtTipo.Clear();
            cbbEstado.SelectedIndex = 0;
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja mesmo cancelar o lançamento dessas despesas?","Cancelar Operação",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                limpaCampos();
                dt.Rows.Clear();
                btnOk.Enabled = false;
                btnCancelar.Enabled = false;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            bool res = false;
            for(int i = 0; i < dt.Rows.Count;i++)
            {
                DataRow dr = dt.Rows[i];
                int parcelas = Convert.ToInt32(dr["parcelas"]);
                res = cd.insert(dr["descricao"].ToString(), dr["tipo"].ToString(), dr["estado"].ToString().ToUpper());
                double total = Convert.ToDouble(dr["valor"]), valorP = total / parcelas;
                if (res)
                {
                    DateTime data_e = Convert.ToDateTime(dr["data_emissao"]);
                    int inc = Convert.ToInt16(txtDiasParcela.Text) - 1;
                    DateTime vencimentos = data_e.AddDays(inc);
                    for (int j = 0; j < parcelas; j++)
                    {
                        res = ccp.insert(valorP, dr["tipo"].ToString(), dr["estado"].ToString(), 0, cd.getIdentity(),data_e,vencimentos,Convert.ToDateTime("01/01/1850"),0);
                        vencimentos = vencimentos.AddDays(inc);
                    }
                }
                else
                {
                    MessageBox.Show("Erro durante a gravação!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if(res)
            {
                MessageBox.Show("Gravação feita com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dt.Rows.Clear();
                limpaCampos();
                btnOk.Enabled = false;
                btnCancelar.Enabled = false;
                btnExcluir.Enabled = false;
            }
            else
            {
                limpaCampos();
            }
        }
        public bool checkFields()
        {
            if(txtDesc.Text == string.Empty || txtParcelas.Text == string.Empty || txtTipo.Text == string.Empty || txtValor.Text == string.Empty)
            {
                return false;
            }
            return true;
        }
        private void btnInserir_Click(object sender, EventArgs e)
        {
            DataRow dr = dt.NewRow();
            if(checkFields())
            {
                dr[0] = txtDesc.Text;
                dr[1] = Convert.ToDouble(txtValor.Text);
                dr[2] = Convert.ToInt32(txtParcelas.Text);
                dr[3] = txtTipo.Text.ToUpper();
                dr[4] = cbbEstado.SelectedItem.ToString().ToLower();
                //dgvDespesas.Rows.Add(dr);
                dt.Rows.Add(dr);
                if (dgvDespesas.Rows.Count > 0)
                {
                    btnExcluir.Enabled = true;
                    btnCancelar.Enabled = true;
                    btnOk.Enabled = true;
                }
                limpaCampos();
            }
            else
            {
                MessageBox.Show("Existem campos obrigatórios vazios", "Erro de Campos Vazios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDesc.Focus();
            }
        }

        private void dgvDespesas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja mesmo excluir?","Exclusão",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dt.Rows.RemoveAt(dgvDespesas.CurrentRow.Index);
                if (dt.Rows.Count >0)
                {
                    btnExcluir.Enabled = false;
                    btnOk.Enabled = false;
                }
            }
        }
    }
}
