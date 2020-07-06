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
using GlobalHost.Modelo;

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
            cbDespesa.DataSource = cd.get("");
            cbDespesa.SelectedIndex = 0;
            dt = ccp.getListContasByDespesa(Convert.ToInt32(cbDespesa.SelectedValue));
            Filters.numericField(txtValor);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            bool res = false;//ccp.updateAll(lbAPagar.Items);
            foreach(object o in lbAPagar.Items)
            {
                ccp.pay(Convert.ToInt32(o.ToString().Split(',')[0]),Convert.ToInt32(cbDespesa.SelectedValue),Convert.ToDouble(txtValor.Text));
                txtValor.Text = (Convert.ToDouble(txtValor.Text) - Convert.ToDouble(lbAPagar.Items[lbAPagar.Items.IndexOf(o)].ToString().Split(',')[1])).ToString();
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
            if(dt != null)
            {
                dt.Rows.Clear();
                dt.Rows.Add(ccp.getListaContas(int.Parse(cbDespesa.SelectedValue.ToString())));
            }
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
