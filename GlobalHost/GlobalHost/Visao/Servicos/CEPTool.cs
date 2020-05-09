using GlobalHost.API;
using System;
using System.Threading;
using System.Windows.Forms;

namespace GlobalHost.Visao.Servicos
{
    public partial class CEPTool : Form
    {
        private string str;
        private bool isCancel;
        private int num;
        private string cep;

        public string Str { get => str;}
        public bool IsCancel { get => isCancel;}

        public CEPTool()
        {
            InitializeComponent();
            str = "";
        }

        private void txtCEP_TextChanged(object sender, EventArgs e)
        {
            string cep = txtCEP.Text.Trim().Replace(".", "").Replace(",", "").Replace("-", "");
            if (cep.Length == 8 && API.Validate.CEP(cep))
            {
                API.CEP CEP = null;
                var t = new Thread(() =>
                {
                    CEP = new CEP(cep);
                });
                Cursor.Current = Cursors.AppStarting;
                t.Start();
                t.Join();
                Cursor.Current = Cursors.Arrow;
                txtBairro.Text = CEP.Bairro;
                txtCidade.Text = CEP.Localidade;
                txtLog.Text = CEP.Logradouro;
                txtUF.Text = CEP.Uf;
                this.cep = cep;
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            str = "";
            isCancel = true;
            this.Close();
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            if(txtBairro.Text != string.Empty && txtCidade.Text != string.Empty && txtLog.Text != string.Empty && txtUF.Text != string.Empty)
            {
                if (txtNum.Text == string.Empty)
                    str = txtLog.Text + " - " + txtBairro.Text + " - " + txtCidade.Text + " - " + txtUF.Text + " - " + this.cep + " - BRASIL";
                else
                    str = txtLog.Text + " - " + txtNum.Text + " - " + txtBairro.Text + " - " + txtCidade.Text + " - " + txtUF.Text + " - " + this.cep + " - BRASIL";

                this.Close();
                isCancel = false;
            }
            else
            {
                MessageBox.Show("Digite o CEP!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtNum_TextChanged(object sender, EventArgs e)
        {
            if (txtNum.Text != "")
            {
                try
                {
                    num = Convert.ToInt32(txtNum.Text);
                    txtNum.Select(txtNum.Text.Length, 0);
                }
                catch (Exception)
                {
                    txtNum.Text = num.ToString();
                    txtNum.Select(txtNum.Text.Length, 0);
                }
            }
        }
    }
}
