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
            dt.Rows.Add("descricao",typeof(string));
            dt.Rows.Add("valor", typeof(double));
            dt.Rows.Add("parcelas",typeof(int));
            dt.Rows.Add("tipo", typeof(string));
            dt.Rows.Add("estado", typeof(string));
            dgvDespesas.DataSource = dt;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja mesmo cancelar o lançamento dessas despesas?","Cancelar Operação",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                dgvDespesas.Rows.Clear();
                txtDesc.Clear();
                txtParcelas.Clear();
                txtValor.Clear();
                txtTipo.Clear();
                cbbEstado.SelectedIndex = 0;
                dt.Rows.Clear();
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < dt.Rows.Count;i++)
            {
                DataRow dr = dt.Rows[i];
                int parcelas = Convert.ToInt32(dr["parcelas"]);
                bool res = cd.insert(dr["descricao"].ToString(), dr["tipo"].ToString(), dr["estado"].ToString());
                double total = Convert.ToDouble(dr["valor"]), valorP = total / parcelas;
                if(res)
                {
                    for (int j = 0; j < parcelas; j++)
                    {
                        ccp.insert(valorP, dr["tipo"].ToString(), dr["estado"].ToString(), -1, cd.getIdentity());
                    }
                }
            }
            MessageBox.Show("Gravação feita com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            DataRow dr = dt.NewRow();
            dr[0] = txtDesc.Text;
            dr[1] = Convert.ToDouble(txtValor.Text);
            dr[2] = Convert.ToInt32(txtParcelas.Text);
            dr[3] = txtTipo.Text;
            dr[4] = cbbEstado.SelectedValue.ToString();
            dgvDespesas.Rows.Add(dr);
        }

        private void dgvDespesas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja mesmo excluir?","Exclusão",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dt.Rows.RemoveAt(dgvDespesas.CurrentRow.Index);
            }
        }
    }
}
