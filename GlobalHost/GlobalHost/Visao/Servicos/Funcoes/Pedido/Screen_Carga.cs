using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GlobalHost.Visao.Servicos.Funcoes.Pedido
{
    public partial class Screen_Carga : Form
    {
        public static int INSERT = 1;
        public static int UPDATE = 2;
        public static int DELETE = 3;
        public Screen_Carga(int op)
        {
            InitializeComponent();
            if (op == INSERT)
                this.Text = "Cadastro de Carga";
            if (op == UPDATE)
                this.Text = "Atualização de Carga";
            if (op == DELETE)
                this.Text = "Remoção de Carga";
        }
    }
}
