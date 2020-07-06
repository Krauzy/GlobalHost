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
    public partial class ScreenRealizarPagamento : UserControl
    {
        Controle_Despesa cd;
        Controle_ContasPagar ccp;
        DataTable dt;
        public ScreenRealizarPagamento()
        {
            InitializeComponent();
            cd = new Controle_Despesa();
            ccp = new Controle_ContasPagar();
            cbDespesa.ValueMember = "id";
            cbDespesa.DisplayMember = "descricao";
            dt = cd.get("");
            cbDespesa.DataSource = dt;
            Filters.numericField(txtValor);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            bool res = false;//ccp.updateAll(lbAPagar.Items);
            foreach(object o in lbAPagar.Items)
            {

            }
            if(res)
            {
                MessageBox.Show("O pagamento foi realizado com sucesso!");
            }
            else
            {
                MessageBox.Show("O pagamento da despesa falhou, tente novamente mais tarde...");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lbAPagar.Items.Add(dgvContas.CurrentRow.ToString());
        }

        private void cbDespesa_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cbDespesa.Items.Add(ccp.getListaContas(int.Parse(cbDespesa.SelectedValue.ToString())));
            dt.Rows.Clear();
            dt.Rows.Add(ccp.getListaContas(int.Parse(cbDespesa.SelectedValue.ToString())));
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo excluir?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                lbAPagar.Items.Remove(lbAPagar.SelectedItem);
            }   
        }

        private void dgvContas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dt.Rows[dgvContas.CurrentRow.Index][0].ToString();
            txtValor.Text = dt.Rows[dgvContas.CurrentRow.Index][1].ToString();
        }
    }
}
