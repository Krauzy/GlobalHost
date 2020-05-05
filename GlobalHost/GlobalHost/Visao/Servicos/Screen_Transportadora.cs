using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using GlobalHost.Controlador;

namespace GlobalHost.Visao.Servicos
{
    public partial class Screen_Transportadora : UserControl
    {
        private bool ins = false;
        private bool alt = false;
        private bool exc = false;
        private DataTable data;
        private int ID;
        private double V;

        public Screen_Transportadora()
        {
            InitializeComponent();

            cbTipoTransporte.DataSource = Controle_TipoTransporte.get("");
            cbTipoTransporte.DisplayMember = "descricao";
            cbTipoTransporte.ValueMember = "id";

            data = Controle_Transportadora.get("");
            dgvTransportadora.DataSource = data;

            cbFiltro.SelectedIndex = 0;
            cbTipoTransporte.SelectedIndex = 0;
        }

        public void load()
        {
            cbTipoTransporte.DataSource = Controle_TipoTransporte.get("");
            cbTipoTransporte.DisplayMember = "descricao";
            cbTipoTransporte.ValueMember = "id";
            cbTipoTransporte.SelectedIndex = 0;
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            btnInserir.ForeColor = Color.White;
            btnInserir.BackColor = Color.FromArgb(0, 122, 204);
            btnInserir.Image = GlobalHost.Properties.Resources.insert;

            ins = true;
            alt = false;
            exc = false;
            changeBool();

            txtID.Enabled = false;
            txtNome.Enabled = true;
            txtValor.Enabled = true;
            txtContato.Enabled = true;
            txtEndereco.Enabled = true;
            txtTelefone.Enabled = true;
            txtEmail.Enabled = true;
            txtCNPJ.Enabled = true;
            txtNum.Enabled = true;
            cbTipoTransporte.Enabled = true;

            txtID.Text = string.Empty;

            btnOk.Enabled = true;
            btnCancelar.Enabled = true;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            btnAlterar.ForeColor = Color.White;
            btnAlterar.BackColor = Color.FromArgb(0, 122, 204);
            btnAlterar.Image = GlobalHost.Properties.Resources.alterar;

            ins = false;
            alt = true;
            exc = false;
            changeBool();

            txtID.Enabled = true;
            txtNome.Enabled = true;
            txtValor.Enabled = true;
            txtContato.Enabled = true;
            txtEndereco.Enabled = true;
            txtTelefone.Enabled = true;
            txtEmail.Enabled = true;
            txtCNPJ.Enabled = true;
            txtNum.Enabled = true;
            cbTipoTransporte.Enabled = true;

            btnOk.Enabled = true;
            btnCancelar.Enabled = true;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            btnExcluir.ForeColor = Color.White;
            btnExcluir.BackColor = Color.FromArgb(0, 122, 204);
            btnExcluir.Image = GlobalHost.Properties.Resources.lixo;

            ins = false;
            alt = false;
            exc = true;
            changeBool();

            txtID.Enabled = true;
            txtNome.Enabled = false;
            txtValor.Enabled = false;
            txtContato.Enabled = false;
            txtEndereco.Enabled = false;
            txtTelefone.Enabled = false;
            txtEmail.Enabled = false;
            txtCNPJ.Enabled = false;
            txtNum.Enabled = false;
            cbTipoTransporte.Enabled = false;

            txtNome.Text = string.Empty;
            txtValor.Text = string.Empty;
            txtContato.Text = string.Empty;
            txtEndereco.Text = string.Empty;
            txtTelefone.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtCNPJ.Text = string.Empty;
            txtNum.Value = 1;
            cbTipoTransporte.SelectedIndex = 0;

            btnOk.Enabled = true;
            btnCancelar.Enabled = true;
        }

        private void changeBool()
        {
            if (ins == false)
            {
                btnInserir.ForeColor = Color.FromArgb(0, 122, 204);
                btnInserir.BackColor = Color.White;
                btnInserir.Image = GlobalHost.Properties.Resources.insert2;
            }
            if (alt == false)
            {
                btnAlterar.ForeColor = Color.FromArgb(0, 122, 204);
                btnAlterar.BackColor = Color.White;
                btnAlterar.Image = GlobalHost.Properties.Resources.alterar2;
            }
            if (exc == false)
            {
                btnExcluir.ForeColor = Color.FromArgb(0, 122, 204);
                btnExcluir.BackColor = Color.White;
                btnExcluir.Image = GlobalHost.Properties.Resources.lixo2;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            bool result_cnpj = API.Validate.CNPJ(txtCNPJ.Text);
            if(ins == true)
            {
                if(txtNome.Text != string.Empty && txtValor.Text != string.Empty && txtContato.Text != string.Empty 
                    && txtEndereco.Text != string.Empty && txtEmail.Text != string.Empty && txtTelefone.Text != string.Empty
                    && txtCNPJ.Text != string.Empty && txtNum.Value >= 1 && result_cnpj)
                {
                    if(!Controle_Transportadora.insert(txtNome.Text, V, (int)txtNum.Value,txtEndereco.Text, txtContato.Text, txtTelefone.Text, txtEmail.Text, txtCNPJ.Text, (int)cbTipoTransporte.SelectedValue))
                        MessageBox.Show("Falha ao inserir " + txtNome.Text + "!", "Falha de operação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        
                }
            }
            else if(alt == true)
            {
                if (txtID.Text != string.Empty && txtNome.Text != string.Empty && txtValor.Text != string.Empty && txtContato.Text != string.Empty
                    && txtEndereco.Text != string.Empty && txtEmail.Text != string.Empty && txtTelefone.Text != string.Empty
                    && txtCNPJ.Text != string.Empty && txtNum.Value >= 1 && result_cnpj)
                {
                    if (!Controle_Transportadora.update(ID, txtNome.Text, V, (int)txtNum.Value, txtEndereco.Text, txtContato.Text, txtTelefone.Text, txtEmail.Text, txtCNPJ.Text, (int)cbTipoTransporte.SelectedValue))
                        MessageBox.Show("Falha ao alterar " + txtNome.Text + "!", "Falha de operação", MessageBoxButtons.OK, MessageBoxIcon.Error);                        
                }
            }
            else if(exc == true)
            {
                if(txtID.Text != string.Empty)
                {
                    string n = Controle_Transportadora.get(ID).Rows[0]["nome"].ToString();
                    if(!Controle_Transportadora.delete(ID))
                        MessageBox.Show("Falha ao exluir " + txtNome.Text + "!", "Falha de operação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            ins = false;
            alt = false;
            exc = false;
            changeBool();

            txtID.Enabled = false;
            txtNome.Enabled = false;
            txtValor.Enabled = false;
            txtContato.Enabled = false;
            txtEndereco.Enabled = false;
            txtTelefone.Enabled = false;
            txtEmail.Enabled = false;
            txtCNPJ.Enabled = false;
            txtNum.Enabled = false;
            cbTipoTransporte.Enabled = false;

            txtID.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtValor.Text = string.Empty;
            txtContato.Text = string.Empty;
            txtEndereco.Text = string.Empty;
            txtTelefone.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtCNPJ.Text = string.Empty;
            txtNum.Value = 1;
            cbTipoTransporte.SelectedIndex = 0;

            btnOk.Enabled = false;
            btnCancelar.Enabled = false;

            data = Controle_Transportadora.get("");
            dgvTransportadora.DataSource = data;

            this.ActiveControl = null;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ins = false;
            alt = false;
            exc = false;
            changeBool();

            txtID.Enabled = false;
            txtNome.Enabled = false;
            txtValor.Enabled = false;
            txtContato.Enabled = false;
            txtEndereco.Enabled = false;
            txtTelefone.Enabled = false;
            txtEmail.Enabled = false;
            txtCNPJ.Enabled = false;
            txtNum.Enabled = false;
            cbTipoTransporte.Enabled = false;

            txtID.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtValor.Text = string.Empty;
            txtContato.Text = string.Empty;
            txtEndereco.Text = string.Empty;
            txtTelefone.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtCNPJ.Text = string.Empty;
            txtNum.Value = 1;
            cbTipoTransporte.SelectedIndex = 0;

            btnOk.Enabled = false;
            btnCancelar.Enabled = false;

            this.ActiveControl = null;
        }

        private void txtID_TextChanged(object sender, EventArgs e)
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

        private void txtValor_TextChanged(object sender, EventArgs e)
        {
            if (txtValor.Text != "" && txtValor.Text[txtValor.Text.Length - 1] != ',')
            {
                try
                {
                    V = Convert.ToDouble(txtValor.Text);
                    txtValor.Text = "" + V;
                    txtValor.Select(txtValor.Text.Length, 0);
                }
                catch (Exception)
                {
                    txtValor.Text = "" + V;
                    txtValor.Select(txtValor.Text.Length, 0);
                }
            }
        }

        private void txtCNPJ_Click(object sender, EventArgs e)
        {
            txtCNPJ.Select(0, 0);
        }

        private void txtTelefone_Click(object sender, EventArgs e)
        {
            txtTelefone.Select(1, 0);
        }

        private void dgvTransportadora_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvTransportadora.SelectedRows.Count == 1)
            {
                txtID.Text = dgvTransportadora.SelectedRows[0].Cells["id"].Value.ToString();
                txtNome.Text = dgvTransportadora.SelectedRows[0].Cells["nome"].Value.ToString();
                txtValor.Text = dgvTransportadora.SelectedRows[0].Cells["valor"].Value.ToString();
                txtNum.Value = Convert.ToInt32(dgvTransportadora.SelectedRows[0].Cells["max_carga"].Value.ToString());
                txtEndereco.Text = dgvTransportadora.SelectedRows[0].Cells["endereco"].Value.ToString();
                txtContato.Text = dgvTransportadora.SelectedRows[0].Cells["contato"].Value.ToString();
                txtEmail.Text = dgvTransportadora.SelectedRows[0].Cells["email"].Value.ToString();
                txtTelefone.Text = dgvTransportadora.SelectedRows[0].Cells["telefone"].Value.ToString();
                txtCNPJ.Text = dgvTransportadora.SelectedRows[0].Cells["cnpj"].Value.ToString();
                cbTipoTransporte.Text = dgvTransportadora.SelectedRows[0].Cells["tipo"].Value.ToString();
            }
        }

        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if(contextMenuStrip1.Items[0].Selected == true)
            {
                if(dgvTransportadora.SelectedRows.Count == 1)
                {
                    string n = dgvTransportadora.SelectedRows[0].Cells["nome"].Value.ToString();
                    if (!Controle_Transportadora.delete(Convert.ToInt32(dgvTransportadora.SelectedRows[0].Cells["id"].Value.ToString())))
                        MessageBox.Show("Erro ao excluir " + n, "Falha na execução", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            data = Controle_Transportadora.get("");
            dgvTransportadora.DataSource = data;
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
                            data = Controle_Transportadora.get("nome LIKE '%" + txtBusca.Text + "%'");
                            break;

                        case "Valor":
                            data = Controle_Transportadora.get("valor > " + Convert.ToDouble(txtBusca.Text));
                            break;

                        case "Carga Máxima":
                            data = Controle_Transportadora.get("max_carga > " + Convert.ToInt32(txtBusca.Text));
                            break;

                        case "Endereço":
                            data = Controle_Transportadora.get("endereco LIKE '%" + txtBusca.Text + "%'");
                            break;

                        case "Contato":
                            data = Controle_Transportadora.get("contato LIKE '%" + txtBusca.Text + "%'");
                            break;

                        case "Telefone":
                            data = Controle_Transportadora.get("telefone LIKE '%" + txtBusca.Text + "%'");
                            break;

                        case "E-mail":
                            data = Controle_Transportadora.get("email LIKE '%" + txtBusca.Text + "%'");
                            break;
                        
                        case "CNPJ":
                            data = Controle_Transportadora.get("cnpj LIKE '%" + txtBusca.Text + "%'");
                            break;

                        case "Tipo de Transporte":
                            data = Controle_Transportadora.get("");
                            DataTable temp = data.Clone();
                            temp.Clear();
                            foreach (DataRow linha in data.Rows)
                                if (linha["tipo"].ToString().ToUpper().Contains(txtBusca.Text.ToUpper()))
                                    temp.ImportRow(linha);
                            data = temp;
                            temp.Dispose();
                            break;
                    }
                }
                catch (Exception)
                {
                    data = Controle_Transportadora.get("");
                }
            }
            else
                data = Controle_Transportadora.get("");
            dgvTransportadora.DataSource = data;
        }
    }
}
