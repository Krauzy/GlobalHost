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
using GlobalHost.Modelo;

namespace GlobalHost.Visao.Servicos
{
    public partial class Screen_Funcionarios : UserControl
    {
        private bool insere = false;
        private bool altera = false;
        private bool exclui = false;
        private DataTable data;
        private int ID;
        private double V;

        public Screen_Funcionarios()
        {
            InitializeComponent();
            mtbSenha.UseSystemPasswordChar = true;
            cbFiltro.SelectedIndex = 0;
            cbNivel.SelectedIndex = 0;
            txtSalario.Enabled = false;
            txtBusca.Enabled = true;
            mtbCPF.Enabled = false;
            txtEmail.Enabled = false;
            txtEndereco.Enabled = false;
            txtID.Enabled = false;
            txtNome.Enabled = false;
            txtLogin.Enabled = false;
            mtbSenha.Enabled = false;
            txtTelefone.Enabled = false;
            dtpAdmissao.Enabled = false;
            dtpDemissao.Enabled = false;
            dtpNascimento.Enabled = false;
        }

        public bool validate ()
        {

            return true;
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

        private void btnInserir_Click(object sender, EventArgs e)
        {
            txtID.Enabled = false;
            txtSalario.Enabled = true;
            mtbCPF.Enabled = true;
            txtEmail.Enabled = true;
            txtEndereco.Enabled = true;
            txtNome.Enabled = true;
            txtTelefone.Enabled = true;
            dtpAdmissao.Enabled = true;
            dtpDemissao.Enabled = true;
            dtpNascimento.Enabled = true;
            txtLogin.Enabled = true;
            mtbSenha.Enabled = true;
            cbNivel.Enabled = true;
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
            txtSalario.Enabled = true;
            mtbCPF.Enabled = true;
            txtEmail.Enabled = true;
            txtEndereco.Enabled = true;
            txtNome.Enabled = true;
            txtTelefone.Enabled = true;
            dtpAdmissao.Enabled = true;
            dtpDemissao.Enabled = true;
            dtpNascimento.Enabled = true;
            txtLogin.Enabled = true;
            mtbSenha.Enabled = true;
            cbNivel.Enabled = true;
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
            txtSalario.Enabled = false;
            mtbCPF.Enabled = false;
            txtEmail.Enabled = false;
            txtEndereco.Enabled = false;
            txtNome.Enabled = false;
            txtTelefone.Enabled = false;
            dtpAdmissao.Enabled = false;
            dtpDemissao.Enabled = false;
            dtpNascimento.Enabled = false;
            txtLogin.Enabled = false;
            mtbSenha.Enabled = false;
            cbNivel.Enabled = false;
            insere = false;
            altera = false;
            exclui = true;
            changeBool();
            btnOk.Enabled = true;
            btnCancelar.Enabled = true;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            int nivel = 0;
            if (cbNivel.SelectedIndex == 1)
                nivel = 1;
          
            bool result_CPF = API.Validate.CPF(mtbCPF.Text);
            if (insere == true)
            {
                if (txtNome.Text != string.Empty && mtbCPF.Text != string.Empty && txtSalario.Text != string.Empty
                    && txtEndereco.Text != string.Empty && txtEmail.Text != string.Empty && txtTelefone.Text != string.Empty
                    && dtpAdmissao.Text != string.Empty && dtpDemissao.Text != string.Empty && dtpNascimento.Text != string.Empty && result_CPF && txtLogin.Text != string.Empty && mtbSenha.Text != string.Empty)
                {
                    if (!Controle_Funcionario.insert(txtNome.Text, (DateTime)dtpNascimento.Value, mtbCPF.Text, Convert.ToDouble(txtSalario.Text), txtEndereco.Text, (DateTime)dtpAdmissao.Value, (DateTime)dtpDemissao.Value, txtTelefone.Text, txtEmail.Text, txtLogin.Text, txtSenha.Text, nivel))
                        MessageBox.Show("Falha ao inserir " + txtNome.Text + "!", "Falha de operação", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                    MessageBox.Show("Preencha todos os campos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (altera == true)
            {
                if (txtNome.Text != string.Empty && mtbCPF.Text != string.Empty && txtSalario.Text != string.Empty
                    && txtEndereco.Text != string.Empty && txtEmail.Text != string.Empty && txtTelefone.Text != string.Empty
                    && dtpAdmissao.Text != string.Empty && dtpDemissao.Text != string.Empty && dtpNascimento.Text != string.Empty && result_CPF && txtLogin.Text != string.Empty && mtbSenha.Text != string.Empty)
                {
                    if (!Controle_Funcionario.update(Convert.ToInt32(txtID.Text),txtNome.Text, (DateTime)dtpNascimento.Value, mtbCPF.Text, Convert.ToDouble(txtSalario.Text), txtEndereco.Text, (DateTime)dtpAdmissao.Value, (DateTime)dtpDemissao.Value, txtTelefone.Text, txtEmail.Text, txtLogin.Text, txtSenha.Text, nivel))
                        MessageBox.Show("Falha ao alterar " + txtNome.Text + "!", "Falha de operação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (exclui == true)
            {
                if (txtID.Text != string.Empty)
                {
                    string n = Controle_Funcionario.get(ID).Rows[0]["nome"].ToString();
                    if (!Controle_Funcionario.delete(ID))
                        MessageBox.Show("Falha ao exluir " + txtNome.Text + "!", "Falha de operação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            insere = false;
            altera = false;
            exclui = false;
            changeBool();

            cbFiltro.SelectedIndex = 0;
            cbNivel.SelectedIndex = 0;
            cbNivel.Enabled = false;
           
            txtID.Enabled = false;
            txtSalario.Enabled = false;
            mtbCPF.Enabled = false;
            mtbSenha.Enabled = false;
            txtEmail.Enabled = false;
            txtEndereco.Enabled = false;
            txtNome.Enabled = false;
            txtTelefone.Enabled = false;
            txtLogin.Enabled = false;
            dtpAdmissao.Enabled = false;
            dtpDemissao.Enabled = false;
            dtpNascimento.Enabled = false;

            txtID.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtSalario.Text = string.Empty;
            txtEndereco.Text = string.Empty;
            txtTelefone.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtBusca.Text = string.Empty;
            txtLogin.Text = string.Empty;
            mtbSenha.Text = string.Empty;
            mtbCPF.Text = string.Empty;
            
            dtpAdmissao.Text = string.Empty;
            dtpDemissao.Text = string.Empty;
            dtpNascimento.Text = string.Empty;

            btnOk.Enabled = false;
            btnCancelar.Enabled = false;

            data = Controle_Funcionario.get("");
            dgvFuncionario.DataSource = data;

            this.ActiveControl = null;
        }

        private void txtID_TextChanged_1(object sender, EventArgs e)
        {
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

        private void txtSalario_TextChanged_1(object sender, EventArgs e)
        {
            if (txtSalario.Text != "" && txtSalario.Text[txtSalario.Text.Length - 1] != ',')
            {
                try
                {
                    V = Convert.ToDouble(txtSalario.Text);
                    txtSalario.Text = "" + V;
                    txtSalario.Select(txtSalario.Text.Length, 0);
                }
                catch (Exception)
                {
                    txtSalario.Text = "" + V;
                    txtSalario.Select(txtSalario.Text.Length, 0);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            insere = false;
            altera = false;
            exclui = false;
            changeBool();
            cbNivel.SelectedIndex = 0;
            cbFiltro.SelectedIndex = 0;
            txtSalario.Enabled = false;
            mtbCPF.Enabled = false;
            mtbSenha.Enabled = false;
            txtEmail.Enabled = false;
            txtEndereco.Enabled = false;
            txtID.Enabled = false;
            txtNome.Enabled = false;
            txtTelefone.Enabled = false;
            txtLogin.Enabled = false;
            dtpAdmissao.Enabled = false;
            dtpDemissao.Enabled = false;
            dtpNascimento.Enabled = false;

            txtID.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtSalario.Text = string.Empty;
            txtEndereco.Text = string.Empty;
            txtTelefone.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtLogin.Text = string.Empty;
            mtbSenha.Text = string.Empty;
            mtbCPF.Text = string.Empty;
            txtBusca.Text = string.Empty;

            dtpAdmissao.Text = string.Empty;
            dtpDemissao.Text = string.Empty;
            dtpNascimento.Text = string.Empty;

            btnOk.Enabled = false;
            btnCancelar.Enabled = false;

            this.ActiveControl = null;
        }

        private void dgvFuncionario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvFuncionario.SelectedRows.Count == 1)
            {
                txtID.Text = dgvFuncionario.SelectedRows[0].Cells["ID"].Value.ToString();
                txtNome.Text = dgvFuncionario.SelectedRows[0].Cells["Nome"].Value.ToString();
                dtpNascimento.Value = Convert.ToDateTime(dgvFuncionario.SelectedRows[0].Cells["Data de Nascimento"].Value.ToString());
                mtbCPF.Text = dgvFuncionario.SelectedRows[0].Cells["CPF"].Value.ToString();
                txtSalario.Text = ""+Convert.ToDouble(dgvFuncionario.SelectedRows[0].Cells["Salario"].Value.ToString());
                txtEndereco.Text = dgvFuncionario.SelectedRows[0].Cells["Endereco"].Value.ToString();
                dtpAdmissao.Value = Convert.ToDateTime(dgvFuncionario.SelectedRows[0].Cells["Data de Admissão"].Value.ToString());
                dtpDemissao.Value = Convert.ToDateTime(dgvFuncionario.SelectedRows[0].Cells["Data de Demissão"].Value.ToString());
                txtTelefone.Text = dgvFuncionario.SelectedRows[0].Cells["Telefone"].Value.ToString();
                txtEmail.Text = dgvFuncionario.SelectedRows[0].Cells["E-mail"].Value.ToString();
            }
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            if (txtBusca.Text != string.Empty)
            {
                try
                {
                    switch (cbFiltro.Text)
                    {
                        case "Nome":
                            data = Controle_Funcionario.get("nome LIKE '%" + txtBusca.Text + "%'");
                            break;

                        case "Salario":
                            data = Controle_Funcionario.get("salario > " + Convert.ToDouble(txtBusca.Text));
                            break;

                        case "CPF":
                            data = Controle_Funcionario.get("cpf LIKE '%" + txtBusca.Text + "%'");
                            break;

                        case "Endereço":
                            data = Controle_Funcionario.get("endereco LIKE '%" + txtBusca.Text + "%'");
                            break;

                        case "Telefone":
                            data = Controle_Funcionario.get("telefone LIKE '%" + txtBusca.Text + "%'");
                            break;

                        case "E-mail":
                            data = Controle_Funcionario.get("email LIKE '%" + txtBusca.Text + "%'");
                            break;
                    }
                }
                catch (Exception)
                {
                    data = Controle_Funcionario.get("");
                }
            }
            else
                data = Controle_Funcionario.get("");
            dgvFuncionario.DataSource = data;
        }
    }    
}
