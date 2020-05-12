using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GlobalHost.API;
using GlobalHost.Controlador;
using PdfSharp.Pdf.Filters;

namespace GlobalHost.Visao.Servicos
{
    public partial class Screen_Cliente : Form
    {
        private bool insere = false;
        private bool altera = false;
        private bool exclui = false;
        private DataTable data;
        private int ID;


        public Screen_Cliente()
        {
            InitializeComponent();
            cbFiltro.SelectedIndex = 0;
            txtBusca.Enabled = true;
            mtbCPF_CNPJ.Enabled = false;
            txtEmail.Enabled = false;
            txtEndereco.Enabled = false;
            txtID.Enabled = false;
            txtNome.Enabled = false;
            txtTelefone.Enabled = false;
            //mtbCEP.Enabled = false;
            dtpNascimento.Enabled = false;
        }

        private void changeBool()
        {
            if (insere == false)
            {
                btnInserir.ForeColor = Color.FromArgb(0, 122, 204);
                btnInserir.BackColor = Color.White;
                btnInserir.Image = GlobalHost.Properties.Resources.insert2;
            }
            if (altera == false)
            {
                btnAlterar.ForeColor = Color.FromArgb(0, 122, 204);
                btnAlterar.BackColor = Color.White;
                btnAlterar.Image = GlobalHost.Properties.Resources.alterar2;
            }
            if (exclui == false)
            {
                btnExcluir.ForeColor = Color.FromArgb(0, 122, 204);
                btnExcluir.BackColor = Color.White;
                btnExcluir.Image = GlobalHost.Properties.Resources.lixo2;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (insere == true)
            {
                if (txtNome.Text != string.Empty && mtbCPF_CNPJ.Text != string.Empty && mtbCEP.Text != string.Empty
                    && txtEndereco.Text != string.Empty && txtEmail.Text != string.Empty && txtEmail.Text.Contains("@") && txtTelefone.Text != string.Empty && dtpNascimento.Text != string.Empty)
                {
                    if (!Controle_Cliente.insert(txtNome.Text, txtEndereco.Text,(DateTime)dtpNascimento.Value,mtbCPF_CNPJ.Text, mtbCEP.Text,txtEmail.Text,txtTelefone.Text))
                        MessageBox.Show("Falha ao inserir " + txtNome.Text + "!", "Falha de operação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else MessageBox.Show("Inserção feita com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else MessageBox.Show("Falha, campos inválidos!", "Falha de operação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (altera == true)
            {
                if (txtNome.Text != string.Empty && mtbCPF_CNPJ.Text != string.Empty && mtbCEP.Text != string.Empty
                    && txtEndereco.Text != string.Empty && txtEmail.Text != string.Empty && txtEmail.Text.Contains("@") && txtTelefone.Text != string.Empty && dtpNascimento.Text != string.Empty)
                {
                    if (!Controle_Cliente.update(Convert.ToInt32(txtID.Text), txtNome.Text, txtEndereco.Text, (DateTime)dtpNascimento.Value, mtbCPF_CNPJ.Text, mtbCEP.Text, txtEmail.Text, txtTelefone.Text))
                        MessageBox.Show("Falha ao alterar " + txtNome.Text + "!", "Falha de operação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else MessageBox.Show("Alteração feita com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else MessageBox.Show("Falha, campos inválidos!", "Falha de operação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (exclui == true)
            {
                if (txtID.Text != string.Empty)
                {
                    string n = Controle_Cliente.get(ID).Rows[0]["nome"].ToString();
                    if (!Controle_Cliente.delete(ID))
                        MessageBox.Show("Falha ao exluir " + txtNome.Text + "!", "Falha de operação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else MessageBox.Show("Exclusão feita com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else MessageBox.Show("Falha, campos inválidos!", "Falha de operação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            insere = false;
            altera = false;
            exclui = false;
            changeBool();

            txtID.Enabled = false;
            mtbCPF_CNPJ.Enabled = false;
            txtEmail.Enabled = false;
            txtEndereco.Enabled = false;
            txtNome.Enabled = false;
            txtTelefone.Enabled = false;
            dtpNascimento.Enabled = false;

            txtID.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtEndereco.Text = string.Empty;
            txtTelefone.Text = string.Empty;
            txtEmail.Text = string.Empty;
            mtbCPF_CNPJ.Text = string.Empty;
            txtBusca.Text = string.Empty;

            dtpNascimento.Text = string.Empty;

            btnOk.Enabled = false;
            btnCancelar.Enabled = false;

            data = Controle_Cliente.get("");
            dgvCliente.DataSource = data;

            this.ActiveControl = null;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if(insere == altera == exclui == false)
            {
                if (MessageBox.Show("Deseja mesmo sair?", "SAÍDA", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                    this.Close();
            }
            insere = false;
            altera = false;
            exclui = false;
            changeBool();

            mtbCPF_CNPJ.Enabled = false;
            txtEmail.Enabled = false;
            txtEndereco.Enabled = false;
            txtID.Enabled = false;
            txtNome.Enabled = false;
            txtTelefone.Enabled = false;
            dtpNascimento.Enabled = false;

            txtID.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtEndereco.Text = string.Empty;
            txtTelefone.Text = string.Empty;
            txtEmail.Text = string.Empty;
            mtbCPF_CNPJ.Text = string.Empty;
            txtBusca.Text = string.Empty;

            dtpNascimento.Text = string.Empty;

            btnOk.Enabled = false;
            //btnCancelar.Enabled = false;
            this.ActiveControl = null;
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            txtID.Enabled = false;
            mtbCPF_CNPJ.Enabled = true;
            txtEmail.Enabled = true;
            txtEndereco.Enabled = true;
            txtNome.Enabled = true;
            txtTelefone.Enabled = true;
            dtpNascimento.Enabled = true;

            insere = true;
            altera = false;
            exclui = false;
            changeBool();

            btnOk.Enabled = true;
            btnCancelar.Enabled = true;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            txtID.Enabled = true;
            mtbCPF_CNPJ.Enabled = true;
            txtEmail.Enabled = true;
            txtEndereco.Enabled = true;
            txtNome.Enabled = true;
            txtTelefone.Enabled = true;
            dtpNascimento.Enabled = true;

            insere = false;
            altera = true;
            exclui = false;
            changeBool();

            btnOk.Enabled = true;
            btnCancelar.Enabled = true;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            txtID.Enabled = true;
            mtbCPF_CNPJ.Enabled = false;
            txtEmail.Enabled = false;
            txtEndereco.Enabled = false;
            txtNome.Enabled = false;
            txtTelefone.Enabled = false;
            dtpNascimento.Enabled = false;

            insere = false;
            altera = false;
            exclui = true;
            changeBool();

            btnOk.Enabled = true;
            btnCancelar.Enabled = true;
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            Filters.numericField(txtID);
            if (txtID.Text != "")
            {
                try
                {
                    ID = Convert.ToInt32(txtID.Text);
                    txtID.Select(txtID.Text.Length, 0);
                }
                catch (Exception)
                {
                    txtID.Text = ID.ToString();
                    txtID.Select(txtID.Text.Length, 0);
                }
            }
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            Filters.alphanumericField(txtNome);
        }

        private void mtbCPF_CNPJ_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            Filters.numericField(mtbCPF_CNPJ);
        }

        private void txtEndereco_TextChanged(object sender, EventArgs e)
        {
            //Filters.mixedField(txtEndereco);
        }

        private void txtTelefone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void mtbCEP_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            dgvCliente.Rows.Clear();
            dgvCliente.Rows.Add(Controle_Cliente.get(cbFiltro.SelectedItem.ToString().ToLower() + " = " +txtBusca.Text));
        }
    }
}
