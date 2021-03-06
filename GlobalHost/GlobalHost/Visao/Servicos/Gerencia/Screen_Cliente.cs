﻿using System;
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

        public bool checkFields()
        {
            return (txtNome.Text != string.Empty && 
                     mtbCPF_CNPJ.Text != string.Empty && 
                     mtbCEP.Text != string.Empty && 
                     txtEndereco.Text != string.Empty && 
                     
                     txtEmail.Text != string.Empty && 
                     txtEmail.Text.Contains("@") && 
                     txtTelefone.Text != string.Empty && 
                     dtpNascimento.Value != null);
        }
        public void liberaCampos(string funcao)
        {
            switch(funcao)
            {
                case "insert":
                    mtbCPF_CNPJ.Enabled = true;
                    mtbCEP.Enabled = true;
                    txtEmail.Enabled = true;
                    txtEndereco.Enabled = true;
                    txtNome.Enabled = true;
                    txtTelefone.Enabled = true;
                    txtNum.Enabled = true;
                    txtBairro.Enabled = true;
                    dtpNascimento.Enabled = true;
                    break;
                case "delete":
                    liberaCampos("idle");
                    break;
                case "update":
                    liberaCampos("insert");
                    break;
                case "idle":
                    mtbCEP.Enabled = false;
                    mtbCPF_CNPJ.Enabled = false;
                    txtEmail.Enabled = false;
                    txtEndereco.Enabled = false;
                    txtNome.Enabled = false;
                    txtTelefone.Enabled = false;
                    txtNum.Enabled = false;
                    txtBairro.Enabled = false;
                    dtpNascimento.Enabled = false;
                    break;
            }
        }
        public Screen_Cliente()
        {
            InitializeComponent();
            cbFiltro.SelectedIndex = 0;
            liberaCampos("idle");
            data = Controle_Cliente.get("");
            dgvCliente.DataSource = data;
            rbCPF.Checked = true;
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
        public string getFullAddress()
        {
            return txtEndereco.Text + ", " + txtBairro.Text + ", N° " + txtNum.Text;
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (insere)
            {
                if (checkFields())
                {
                    if (!Controle_Cliente.insert(txtNome.Text, getFullAddress(), (DateTime)dtpNascimento.Value, mtbCPF_CNPJ.Text, mtbCEP.Text, txtEmail.Text, txtTelefone.Text))
                        MessageBox.Show("Falha ao inserir " + txtNome.Text + "!", "Falha de operação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        MessageBox.Show("Inserido com sucesso!", "Operação sem falhas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtID.Text = string.Empty;
                    txtNome.Text = string.Empty;
                    txtEndereco.Text = string.Empty;
                    txtTelefone.Text = string.Empty;
                    txtEmail.Text = string.Empty;
                    mtbCPF_CNPJ.Text = string.Empty;
                    txtBusca.Text = string.Empty;
                    txtNum.Enabled = false;
                    txtBairro.Enabled = false;
                    dtpNascimento.Text = string.Empty;
                    liberaCampos("idle");
                }
                else
                {
                    MessageBox.Show("Existe algum campo inválido!", "Campo com erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else if (altera)
            {
                if (checkFields())
                {
                    if (!Controle_Cliente.update(Convert.ToInt32(txtID.Text), txtNome.Text, getFullAddress(), (DateTime)dtpNascimento.Value, mtbCPF_CNPJ.Text, mtbCEP.Text, txtEmail.Text, txtTelefone.Text))
                        MessageBox.Show("Falha ao alterar " + txtNome.Text + "!", "Falha de operação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        MessageBox.Show("Alterado com sucesso!", "Operação sem falhas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtID.Text = string.Empty;
                        txtNome.Text = string.Empty;
                        txtEndereco.Text = string.Empty;
                        txtTelefone.Text = string.Empty;
                        txtEmail.Text = string.Empty;
                        mtbCPF_CNPJ.Text = string.Empty;
                        txtBusca.Text = string.Empty;
                        txtNum.Enabled = false;
                        txtBairro.Enabled = false;
                        dtpNascimento.Text = string.Empty;
                        liberaCampos("idle");
                    }
                }
            }
            else if (exclui)
            {
                if (txtID.Text != string.Empty)
                {
                    //string n = Controle_Cliente.get(ID).Rows[0]["nome"].ToString();
                    ID = Convert.ToInt32(txtID.Text);
                    try
                    {
                        if (!Controle_Cliente.delete(ID))
                            MessageBox.Show("Falha ao exluir " + txtNome.Text + "!", "Falha de operação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                            MessageBox.Show("Excluído com sucesso!", "Operação sem falhas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtID.Text = string.Empty;
                        txtNome.Text = string.Empty;
                        txtEndereco.Text = string.Empty;
                        txtTelefone.Text = string.Empty;
                        txtEmail.Text = string.Empty;
                        mtbCPF_CNPJ.Text = string.Empty;
                        txtBusca.Text = string.Empty;
                        txtNum.Enabled = false;
                        txtBairro.Enabled = false;
                        dtpNascimento.Text = string.Empty;
                        liberaCampos("idle");
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Existem pedidos ligadas a este cliente, não é possível excluir", "Erro de Chave Estrangeira", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            insere = false;
            altera = false;
            exclui = false;
            changeBool();
            

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

            liberaCampos("idle");

            txtID.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtEndereco.Text = string.Empty;
            txtTelefone.Text = string.Empty;
            txtEmail.Text = string.Empty;
            mtbCPF_CNPJ.Text = string.Empty;
            txtBusca.Text = string.Empty;
            txtNum.Text = string.Empty;
            txtBairro.Text = string.Empty ;
            dtpNascimento.Text = string.Empty;

            btnOk.Enabled = false;
            //btnCancelar.Enabled = false;
            this.ActiveControl = null;
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            liberaCampos("insert");

            insere = true;
            altera = false;
            exclui = false;
            changeBool();

            btnOk.Enabled = true;
            btnCancelar.Enabled = true;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            liberaCampos("update");

            insere = false;
            altera = true;
            exclui = false;
            changeBool();

            btnOk.Enabled = true;
            btnCancelar.Enabled = true;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            liberaCampos("delete");

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
            Filters.mixedField(txtEndereco);
        }

        private void txtTelefone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            Filters.numericField(txtTelefone);
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void mtbCEP_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            Filters.numericField(mtbCEP);
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            string s = "";
            switch(cbFiltro.Text)
            {
                case "Nome":s = "nome";
                    break;
                case "Endereço":s = "endereco";
                    break;
                case "Telefone":s = "telefone";
                    break;
                case "E-mail":s = "email";
                    break;
                case "CPF/CNPJ":s = "cpf_cnpj";
                    break;
            }
            dgvCliente.DataSource = Controle_Cliente.getByFilter(s,txtBusca.Text);
        }

        private void dgvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataRow dr = data.Rows[dgvCliente.CurrentRow.Index];
            txtID.Text = dr["id"].ToString() ;
            txtNome.Text = dr["nome"].ToString();
            dtpNascimento.Value = Convert.ToDateTime(dr["dtnascimento"].ToString());
            mtbCPF_CNPJ.Text = dr["cpf_cnpj"].ToString();
            txtEndereco.Text = dr["endereco"].ToString().Split(',')[0];
            txtBairro.Text = dr["endereco"].ToString().Split(',')[1];
            txtNum.Text = dr["endereco"].ToString().Split(',')[2];
            txtTelefone.Text = dr["telefone"].ToString();
            txtEmail.Text = dr["email"].ToString();
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
        }

        private void rbCPF_CheckedChanged(object sender, EventArgs e)
        {
            rbCNPJ.Checked = false;
            mtbCPF_CNPJ.Mask = "000.000.000-00";
        }

        private void rbCNPJ_CheckedChanged(object sender, EventArgs e)
        {
            rbCPF.Checked = false;
            mtbCPF_CNPJ.Mask = "00.000.000/0000-00";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //txtBusca_TextChanged(null, null);
            if(dgvCliente.SelectedRows.Count >0)
            {
                btnAlterar.Enabled = true;
                btnExcluir.Enabled = true;
            }
            else
            {
                btnAlterar.Enabled = false;
                btnExcluir.Enabled = false;
            }
        }
    }
}
