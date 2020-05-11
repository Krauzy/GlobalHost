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
            Controle_Despesa.baixa();
        }
    }
}
