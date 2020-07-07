using GlobalHost.API;
using GlobalHost.Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GlobalHost.Visao.Servicos
{
    public partial class Screen_TipoCarga : Form
    {
        private bool ins = false;
        private bool alt = false;
        private bool exc = false;
        private DataTable data;

        public Screen_TipoCarga()
        {
            InitializeComponent();
            data = Controle_TipoCarga.get("");
            dgvTipo.DataSource = data;
            cbFiltro.SelectedItem = cbFiltro.Items[0];
            Filters.numericField(txtAltura);
            Filters.numericField(txtComprimento);
            Filters.numericField(txtLargura);
            Filters.numericField(txtPeso);
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
            txtPeso.Enabled = true;
            txtLargura.Enabled = true;
            txtAltura.Enabled = true;
            txtComprimento.Enabled = true;
            txtID.Text = "";
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
            txtPeso.Enabled = true;
            txtLargura.Enabled = true;
            txtAltura.Enabled = true;
            txtComprimento.Enabled = true;
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
            txtPeso.Enabled = false;
            txtLargura.Enabled = false;
            txtAltura.Enabled = false;
            txtComprimento.Enabled = false;
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (ins == alt == exc == false)
            {
                if (MessageBox.Show("Deseja mesmo sair?", "SAÍDA", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                    this.Close();
            }
            ins = false;
            alt = false;
            exc = false;
            changeBool();
            txtID.Enabled = false;
            txtNome.Enabled = false;
            txtPeso.Enabled = false;
            txtLargura.Enabled = false;
            txtAltura.Enabled = false;
            txtComprimento.Enabled = false;
            txtID.Text = "";
            txtNome.Text = "";
            txtPeso.Text = "";
            txtLargura.Text = "";
            txtAltura.Text = "";
            txtComprimento.Text = "";
            btnOk.Enabled = false;
            //btnCancelar.Enabled = false;
        }
        public bool checkCamposNumericos()
        {
            return Convert.ToInt32(txtAltura.Text) > 0 && Convert.ToInt32(txtComprimento.Text) > 0 && Convert.ToInt32(txtLargura.Text) > 0 && Convert.ToInt32(txtPeso.Text) > 0;
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            if(checkCamposNumericos())
            {
                if (ins == true)
                {
                    if (txtPeso.Text != "" && txtLargura.Text != "" && txtComprimento.Text != "" && txtAltura.Text != "")
                    {
                        if (!Controle_TipoCarga.insert(txtNome.Text, Convert.ToDouble(txtPeso.Text), txtLargura.Text + ";" + txtAltura.Text + ";" + txtComprimento.Text))
                            MessageBox.Show("Falha ao inserir " + txtNome.Text + "!", "Falha de operação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else MessageBox.Show("Operação feita com sucesso! Inseriu " + txtNome.Text + "!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }
                else if (alt == true)
                {
                    if (txtID.Text != "" && txtPeso.Text != "" && txtLargura.Text != "" && txtComprimento.Text != "" && txtAltura.Text != "")
                    {
                        if (!Controle_TipoCarga.update(Convert.ToInt32(txtID.Text), txtNome.Text, Convert.ToDouble(txtPeso.Text), txtLargura.Text + ";" + txtAltura.Text + ";" + txtComprimento.Text))
                            MessageBox.Show("Falha ao alterar " + txtNome.Text + "!", "Falha de operação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else MessageBox.Show("Operação feita com sucesso! Atualizou " + txtNome.Text + "!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else if (exc == true)
                {
                    if (txtID.Text != "")
                    {
                        string n = Controle_TipoCarga.get(Convert.ToInt32(txtID.Text)).Rows[0]["descricao"].ToString();
                        if (!Controle_TipoCarga.delete(Convert.ToInt32(txtID.Text)))
                            MessageBox.Show("Falha ao remover " + n + "!", "Falha de operação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else MessageBox.Show("Operação feita com sucesso! Apagou " + txtNome.Text + "!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                ins = false;
                alt = false;
                exc = false;
                changeBool();

                txtID.Text = string.Empty;
                txtNome.Text = string.Empty;
                txtPeso.Text = string.Empty;
                txtLargura.Text = string.Empty;
                txtAltura.Text = string.Empty;
                txtComprimento.Text = string.Empty;

                btnOk.Enabled = false;
                btnCancelar.Enabled = false;

                data = Controle_TipoCarga.get("");
                dgvTipo.DataSource = data;
            }
            else
            {
                MessageBox.Show("Existem campos numéricos negativos ou iguais a zero", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            switch (cbFiltro.Text)
            {
                case "Descrição":
                    data = Controle_TipoCarga.get("descricao LIKE '%" + txtBusca.Text + "%'");
                    break;

                case "Peso":
                    data = Controle_TipoCarga.get("peso >= " + Convert.ToInt32(txtBusca.Text));
                    break;

                case "Dimensão":
                    data = Controle_TipoCarga.get("dimensoes LIKE '%" + txtBusca.Text + "%'");
                    break;
            }
            dgvTipo.DataSource = data;
        }

        private void dgvTipo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTipo.SelectedRows.Count == 1)
            {
                txtID.Text = dgvTipo.SelectedRows[0].Cells["col_id"].Value.ToString();
                txtNome.Text = dgvTipo.SelectedRows[0].Cells["col_desc"].Value.ToString();
                txtPeso.Text = dgvTipo.SelectedRows[0].Cells["col_peso"].Value.ToString();
                string[] str = dgvTipo.SelectedRows[0].Cells["col_dim"].Value.ToString().Split(';');
                txtLargura.Text = str.GetValue(0).ToString();
                txtAltura.Text = str.GetValue(1).ToString();
                txtComprimento.Text = str.GetValue(2).ToString();
            }
        }

        private void txtID_TextChanged_1(object sender, EventArgs e)
        {
            Filters.numericField(txtID);
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            Filters.mixedField(txtNome);
        }

        private void txtPeso_TextChanged_1(object sender, EventArgs e)
        {
            Filters.numericField(txtPeso);
        }

        private void txtLargura_TextChanged_1(object sender, EventArgs e)
        {
            Filters.numericField(txtLargura);
        }

        private void txtAltura_TextChanged_1(object sender, EventArgs e)
        {
            Filters.numericField(txtAltura);
        }

        private void txtComprimento_TextChanged_1(object sender, EventArgs e)
        {
            Filters.numericField(txtComprimento);
        }

        private void dgvTipo_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtBusca_TextChanged(null, null);
            if(dgvTipo.SelectedRows.Count >0)
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
