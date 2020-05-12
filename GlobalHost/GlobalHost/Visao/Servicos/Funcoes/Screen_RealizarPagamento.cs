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
    public partial class Screen_RealizarPagamento : UserControl
    {
        public Screen_RealizarPagamento()
        {
            InitializeComponent();
        }

        private void btPagar_Click(object sender, EventArgs e)
        {
            //Controle_Despesa.baixa();
            Controle_Despesa.baixa(clbPagar.Items);
        }

        private void btRight_Click(object sender, EventArgs e)
        {
            if(clbDespesas.SelectedItems.Count > 0)
            {
                clbPagar.Items.Add(clbDespesas.SelectedItems);
                clbDespesas.Items.Remove(clbDespesas.SelectedItems);
                btLeft.Enabled = true;
            }
            if (clbDespesas.Items.Count == 0)
                btRight.Enabled = false;
            else clbDespesas.Enabled = true;

        }

        private void Screen_RealizarPagamento_Load(object sender, EventArgs e)
        {

        }

        private void btLeft_Click(object sender, EventArgs e)
        {
            if(clbPagar.SelectedItems.Count > 0)
            {
                clbDespesas.Items.Add(clbPagar.SelectedItems);
                clbPagar.Items.Remove(clbPagar.SelectedItems);
                btRight.Enabled = true;
            }
            if (clbPagar.Items.Count == 0)
                btLeft.Enabled = false;
            else clbPagar.Enabled = true;
        }
    }
}
