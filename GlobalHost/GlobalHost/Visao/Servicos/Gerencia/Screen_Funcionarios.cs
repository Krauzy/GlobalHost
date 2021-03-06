﻿using System;
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
        private double sal;

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
            checkBox1.Enabled = false;


            dgvFuncionario.DataSource = Controle_Funcionario.get("");
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
            btnInserir.ForeColor = Color.White;
            btnInserir.BackColor = Color.FromArgb(0, 122, 204);
            btnInserir.Image = GlobalHost.Properties.Resources.insert;

            txtID.Enabled = false;
            txtSalario.Enabled = true;
            mtbCPF.Enabled = true;
            txtEmail.Enabled = true;
            txtEndereco.Enabled = true;
            txtNome.Enabled = true;
            txtTelefone.Enabled = true;
            dtpAdmissao.Enabled = true;
            dtpNascimento.Enabled = true;
            txtLogin.Enabled = true;
            mtbSenha.Enabled = true;
            cbNivel.Enabled = true;
            checkBox1.Enabled = true;
            insere = true;
            altera = false;
            exclui = false;
            changeBool();
            btnOk.Enabled = true;
            btnCancelar.Enabled = true;       
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            btnAlterar.ForeColor = Color.White;
            btnAlterar.BackColor = Color.FromArgb(0, 122, 204);
            btnAlterar.Image = GlobalHost.Properties.Resources.alterar;

            txtID.Enabled = true;
            txtSalario.Enabled = true;
            mtbCPF.Enabled = true;
            txtEmail.Enabled = true;
            txtEndereco.Enabled = true;
            txtNome.Enabled = true;
            txtTelefone.Enabled = true;
            dtpAdmissao.Enabled = true;
            dtpNascimento.Enabled = true;
            txtLogin.Enabled = true;
            mtbSenha.Enabled = true;
            cbNivel.Enabled = true;
            checkBox1.Enabled = true;
            insere = false;
            altera = true;
            exclui = false;
            changeBool();
            btnOk.Enabled = true;
            btnCancelar.Enabled = true;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            btnExcluir.ForeColor = Color.White;
            btnExcluir.BackColor = Color.FromArgb(0, 122, 204);
            btnExcluir.Image = GlobalHost.Properties.Resources.lixo;

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
            checkBox1.Enabled = false;
            insere = false;
            altera = false;
            exclui = true;
            changeBool();
            btnOk.Enabled = true;
            btnCancelar.Enabled = true;
        }
        public bool check()
        {
            bool result_CPF = API.Validate.CPF(mtbCPF.Text);
            if (txtNome.Text == string.Empty)
            {
                MessageBox.Show("Campo NOME vazio!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (dtpNascimento.Value >= DateTime.Now)
            {
                MessageBox.Show("Data de NASCIMENTO inválida!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (mtbCPF.Text == string.Empty)
            {
                MessageBox.Show("Campo SENHA vazio!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (!result_CPF)
            {
                MessageBox.Show("CPF INVÁLIDO!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (txtEndereco.Text == string.Empty)
            {
                MessageBox.Show("Campo ENDEREÇO vazio!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (txtTelefone.Text == string.Empty)
            {
                MessageBox.Show("Campo TELEFONE vazio!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (txtEmail.Text == string.Empty)
            {
                MessageBox.Show("Campo E MAIL vazio!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (txtSalario.Text == string.Empty && Convert.ToDouble(txtSalario.Text)>0)
            {
                MessageBox.Show("Campo SALÁRIO vazio!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (dtpAdmissao.Value <= DateTime.Now)
            {
                MessageBox.Show("Data de ADMISSÃO inferior ao dia corrente!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (txtLogin.Text == string.Empty)
            {
                MessageBox.Show("Campo LOGIN vazio!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (mtbSenha.Text == string.Empty)
            {
                MessageBox.Show("Campo SENHA vazio!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (cbNivel.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione seu NÍVEL DE ACESSO!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        public void _default()
        {
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
            checkBox1.Enabled = false;

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
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            int nivel = 0;
            if (cbNivel.SelectedIndex == 1)
                nivel = 1;
            
          
            bool result_CPF = API.Validate.CPF(mtbCPF.Text);
            if (insere == true)
            {
                if(check())
                {
                    if (checkBox1.Enabled)
                    {
                        if (!Controle_Funcionario.insert(txtNome.Text, (DateTime)dtpNascimento.Value, mtbCPF.Text, Convert.ToDouble(txtSalario.Text), txtEndereco.Text, (DateTime)dtpAdmissao.Value, (DateTime)dtpDemissao.Value, txtTelefone.Text, txtEmail.Text, txtLogin.Text, mtbSenha.Text, nivel))
                            MessageBox.Show("Falha ao inserir " + txtNome.Text + "!", "Falha de operação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                            _default();
                    }
                    else
                    {
                        if (!Controle_Funcionario.insertSemDemissao(txtNome.Text, (DateTime)dtpNascimento.Value, mtbCPF.Text, Convert.ToDouble(txtSalario.Text), txtEndereco.Text, (DateTime)dtpAdmissao.Value, txtTelefone.Text, txtEmail.Text, txtLogin.Text, mtbSenha.Text, nivel))
                            MessageBox.Show("Falha ao alterar " + txtNome.Text + "!", "Falha de operação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                            _default();
                    }
                }
            }
            else if (altera == true)
            {
                if(check())
                {
                    if (checkBox1.Enabled)
                    {
                        if (!Controle_Funcionario.update(Convert.ToInt32(txtID.Text), txtNome.Text, (DateTime)dtpNascimento.Value, mtbCPF.Text, Convert.ToDouble(txtSalario.Text), txtEndereco.Text, (DateTime)dtpAdmissao.Value, (DateTime)dtpDemissao.Value, txtTelefone.Text, txtEmail.Text, txtLogin.Text, mtbSenha.Text, nivel))
                            MessageBox.Show("Falha ao alterar " + txtNome.Text + "!", "Falha de operação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                            _default();
                    }
                    else
                    {
                        if (!Controle_Funcionario.updateSemDemissao(Convert.ToInt32(txtID.Text), txtNome.Text, (DateTime)dtpNascimento.Value, mtbCPF.Text, Convert.ToDouble(txtSalario.Text), txtEndereco.Text, (DateTime)dtpAdmissao.Value, txtTelefone.Text, txtEmail.Text, txtLogin.Text, mtbSenha.Text, nivel))
                            MessageBox.Show("Falha ao alterar " + txtNome.Text + "!", "Falha de operação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                            _default();
                    }         
                }
            }
            else if (exclui == true)
            {
                if (txtID.Text != string.Empty)
                {
                    string n = Controle_Funcionario.get(ID).Rows[0]["nome"].ToString();
                    int log = ((Login)Controle_Funcionario.get(ID).Rows[0]["login"]).Id;                
                    if (!Controle_Funcionario.delete(ID))
                        MessageBox.Show("Falha ao exluir " + txtNome.Text + 
                            "! Não pode ser excluido um funcionário que tenha registrado um pedido recentemente!",
                            "Falha de operação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        if(MessageBox.Show("Deseja realmente excluir este funcionário?","ATENÇÃO",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                        {
                           if (!Controle_Login.delete(log))
                               MessageBox.Show("Falha ao exluir " + txtNome.Text + "!", "Falha de operação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                           else
                               _default();
                        }     
                    }
                }
            }
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
            checkBox1.Enabled = false;

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
                txtID.Text = dgvFuncionario.SelectedRows[0].Cells["id"].Value.ToString();
                txtNome.Text = dgvFuncionario.SelectedRows[0].Cells["nome"].Value.ToString();
                dtpNascimento.Value = Convert.ToDateTime(dgvFuncionario.SelectedRows[0].Cells["dtNascimento"].Value);
                mtbCPF.Text = dgvFuncionario.SelectedRows[0].Cells["cpf"].Value.ToString();
                txtSalario.Text = Convert.ToDouble(dgvFuncionario.SelectedRows[0].Cells["salario"].Value).ToString();
                txtEndereco.Text = dgvFuncionario.SelectedRows[0].Cells["endereco"].Value.ToString();
                dtpAdmissao.Value = Convert.ToDateTime(dgvFuncionario.SelectedRows[0].Cells["dtAdmissao"].Value);
                dtpDemissao.Value = Convert.ToDateTime(dgvFuncionario.SelectedRows[0].Cells["dtDemissao"].Value);
                txtTelefone.Text = dgvFuncionario.SelectedRows[0].Cells["telefone"].Value.ToString();
                txtEmail.Text = dgvFuncionario.SelectedRows[0].Cells["email"].Value.ToString();

                int log = ((Login)(Controle_Funcionario.get("id = " + int.Parse(txtID.Text)).Rows[0]["login"])).Id;
                txtLogin.Text = Controle_Login.get(log).Usuario;
                mtbSenha.Text = Controle_Login.get(log).Senha;
                cbNivel.SelectedIndex = Controle_Login.get(log).Nivel;
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

        private void btCEP_Click(object sender, EventArgs e)
        {
            CEPTool ex = new CEPTool();
            ex.ShowDialog();
            if (!ex.IsCancel)
                txtEndereco.Text = ex.Str;
        }

        private void txtSalario_TextChanged(object sender, EventArgs e)
        {
            if (txtSalario.Text != string.Empty)
            {
                txtSalario.Text = API.Validate.MONEY(txtSalario.Text);
                sal = Convert.ToDouble(txtSalario.Text);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            dtpDemissao.Enabled = checkBox1.Checked;
        }
    }    
}
