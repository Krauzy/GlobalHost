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
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja mesmo cancelar o lançamento dessas despesas?","Cancelar Operação",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                dgvDespesas.Rows.Clear();
                txtDesc.Clear();
                txtParcelas.Clear();
                txtValor.Clear();
                dt.Rows.Clear();
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {

        }
    }
}
