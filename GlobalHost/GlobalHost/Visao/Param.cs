using GlobalHost.Controlador;
using System;
using System.Windows.Forms;

namespace GlobalHost.Visao
{
    public partial class Param : Form
    {
        public Param()
        {
            InitializeComponent();
            init();
        }

        private void init()
        {
            DateTime data = Controle.getParametro().Data_abertura;
            lbCNPJ.Text = Controle.getParametro().Cnpj;
            lbAtividade.Text = Controle.getParametro().Atividade;
            lbData.Text = data.Day + "/" + data.Month + "/" + data.Year;
            lbEmail.Text = Controle.getParametro().Email;
            lbEndereco.Text = Controle.getParametro().Endereco;
            lbNome.Text = Controle.getParametro().Nome_fantasia;
            lbRazao.Text = Controle.getParametro().Razao_social;
            lbSite.Text = Controle.getParametro().Site;
            lbTelefone.Text = Controle.getParametro().Telefone;
        }

        private void lbSite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(lbSite.Text);
        }
    }
}