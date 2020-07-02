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
        DataTable tabela;
        public ScreenRealizarPagamento()
        {
            InitializeComponent();
            cd = new Controle_Despesa();
            ccp = new Controle_ContasPagar();
            cbDespesa.ValueMember = "id";
            cbDespesa.DisplayMember = "descricao";
            cbDespesa.DataSource = cd.get("");
            //tabela = ccp.getListaContas(int.Parse(cbDespesa.SelectedValue.ToString()))
            Filters.numericField(txtValor);
            Filters.numericField(txtID);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            bool res = ccp.updateAll(lbAPagar.Items,txtValor.Text);
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
            lbAPagar.Items.Add(dgvContas.SelectedRows);
        }

        private void cbDespesa_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<object> l = ccp.getListaContas(int.Parse(cbDespesa.SelectedValue.ToString()));
            dgvContas.Rows.Add(l);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            lbAPagar.Items.Remove(lbAPagar.SelectedItem);
        }

        private void dgvContas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
