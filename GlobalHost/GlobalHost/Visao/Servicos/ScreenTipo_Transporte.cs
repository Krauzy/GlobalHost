using GlobalHost.Controlador;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace GlobalHost.Visao.Servicos
{
    public partial class ScreenTipo_Transporte : UserControl
    {
        private bool ins = false;
        private bool alt = false;
        private bool exc = false;
        private string id;
        private double peso;
        private double L;
        private double A;
        private double C;
        private DataTable data;

        public ScreenTipo_Transporte()
        {
            InitializeComponent();
            data = Controle.getTipo_Transporte("");          
            dgvTipo.DataSource = data;
            cbFiltro.SelectedItem = cbFiltro.Items[0];
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
            txtNome.Text = "";
            txtPeso.Text = "";
            txtLargura.Text = "";
            txtAltura.Text = "";
            txtComprimento.Text = "";
            btnOk.Enabled = true;
            btnCancelar.Enabled = true;
        }

        private void changeBool()
        {
            if(ins == false)
            {
                btnInserir.ForeColor = Color.FromArgb(0, 122, 204);
                btnInserir.BackColor = Color.White;
                btnInserir.Image = GlobalHost.Properties.Resources.insert2;
            }
            if(alt == false)
            {
                btnAlterar.ForeColor = Color.FromArgb(0, 122, 204);
                btnAlterar.BackColor = Color.White;
                btnAlterar.Image = GlobalHost.Properties.Resources.alterar2;
            }
            if(exc == false)
            {
                btnExcluir.ForeColor = Color.FromArgb(0, 122, 204);
                btnExcluir.BackColor = Color.White;
                btnExcluir.Image = GlobalHost.Properties.Resources.lixo2;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
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
            btnCancelar.Enabled = false;
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            if(txtID.Text != "")
            {
                try
                {
                    Convert.ToInt32(txtID.Text);
                    id = txtID.Text;
                    txtID.Select(txtID.Text.Length, 0);
                }
                catch (Exception)
                {
                    txtID.Text = id;
                    txtID.Select(txtID.Text.Length, 0);
                }
            }
                
        }

        private void txtPeso_TextChanged(object sender, EventArgs e)
        {
            if(txtPeso.Text != "" && txtPeso.Text[txtPeso.Text.Length-1] != ',')
            {
                try
                {
                    peso = Convert.ToDouble(txtPeso.Text);
                    txtPeso.Text = "" + peso;
                    txtPeso.Select(txtPeso.Text.Length, 0);
                }
                catch(Exception)
                {
                    txtPeso.Text = "" + peso;
                    txtPeso.Select(txtPeso.Text.Length, 0);
                }
            }
        }

        private void txtLargura_TextChanged(object sender, EventArgs e)
        {
            if (txtLargura.Text != "" && txtLargura.Text[txtLargura.Text.Length - 1] != ',')
            {
                try
                {
                    L = Convert.ToDouble(txtLargura.Text);
                    txtLargura.Text = "" + L;
                    txtLargura.Select(txtLargura.Text.Length, 0);
                }
                catch (Exception)
                {
                    txtLargura.Text = "" + L;
                    txtLargura.Select(txtLargura.Text.Length, 0);
                }
            }
        }

        private void txtAltura_TextChanged(object sender, EventArgs e)
        {
            if (txtAltura.Text != "" && txtAltura.Text[txtAltura.Text.Length - 1] != ',')
            {
                try
                {
                    A = Convert.ToDouble(txtAltura.Text);
                    txtAltura.Text = "" + A;
                    txtAltura.Select(txtAltura.Text.Length, 0);
                }
                catch (Exception)
                {
                    txtAltura.Text = "" + A;
                    txtAltura.Select(txtAltura.Text.Length, 0);
                }
            }
        }

        private void txtComprimento_TextChanged(object sender, EventArgs e)
        {
            if (txtComprimento.Text != "" && txtComprimento.Text[txtComprimento.Text.Length - 1] != ',')
            {
                try
                {
                    C = Convert.ToDouble(txtComprimento.Text);
                    txtComprimento.Text = "" + C;
                    txtComprimento.Select(txtComprimento.Text.Length, 0);
                }
                catch (Exception)
                {
                    txtComprimento.Text = "" + C;
                    txtComprimento.Select(txtComprimento.Text.Length, 0);
                }
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Nome: " + txtNome.Text + "\nPeso: " + peso + "\nDimensões: " + L + ";" + A + ";" + C);
            if (ins == true)
            {
                if (txtPeso.Text != "" && txtLargura.Text != "" && txtComprimento.Text != "" && txtAltura.Text != "")
                    if (Controle.Insere_Tipo_Transporte(txtNome.Text, peso, L + ";" + A + ";" + C) == true)
                        MessageBox.Show(txtNome.Text + " inserido com êxito!", "Operação concluída", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    else
                        MessageBox.Show("Falha ao inserir " + txtNome.Text + "!", "Falha de operação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (alt == true)
            {
                if (txtID.Text != "" && txtPeso.Text != "" && txtLargura.Text != "" && txtComprimento.Text != "" && txtAltura.Text != "")
                    if (Controle.Altera_Tipo_Transporte(Convert.ToInt32(txtID.Text), txtNome.Text, peso, L + ";" + A + ";" + C) == true)
                        MessageBox.Show(txtNome.Text + " alterado com êxito!", "Operação concluída", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    else
                        MessageBox.Show("Falha ao alterar " + txtNome.Text + "!", "Falha de operação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (exc == true)
            {
                if (txtID.Text != "")
                {
                    string n = Controle.getTipo_Transporte(Convert.ToInt32(id)).Rows[0]["descricao"].ToString();
                    if (Controle.Remove_Tipo_Transporte(Convert.ToInt32(id)) == true)
                        MessageBox.Show(n + " removido com êxito!", "Operação concluída", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    else
                        MessageBox.Show("Falha ao remover " + n + "!", "Falha de operação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            data = Controle.getTipo_Transporte("");
            dgvTipo.DataSource = data;
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            if (txtBusca.Text != string.Empty)
            {
                switch (cbFiltro.Text)
                {
                    case "ID":
                        data = Controle.getTipo_Transporte("id = " + Convert.ToInt32(txtBusca.Text));
                        break;

                    case "Descrição":
                        data = Controle.getTipo_Transporte("descricao LIKE '%" + txtBusca.Text + "%'");
                        break;

                    case "Peso":
                        data = Controle.getTipo_Transporte("max_peso >= " + Convert.ToInt32(txtBusca.Text));
                        break;

                    case "Dimensão":
                        data = Controle.getTipo_Transporte("dimensoes LIKE '%" + txtBusca.Text + "%'");
                        break;
                }
            }
            else
                data = Controle.getTipo_Transporte("");
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

        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
           if(contextMenuStrip1.Items[0].Selected == true)
           {
                if (dgvTipo.SelectedRows.Count == 1)
                {
                    Controle.Remove_Tipo_Transporte(Convert.ToInt32(dgvTipo.SelectedRows[0].Cells["col_id"].Value.ToString()));
                }
           }
            data = Controle.getTipo_Transporte("");
            dgvTipo.DataSource = data;
        }
    }
}
