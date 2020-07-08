using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using GlobalHost.Controlador;
using GlobalHost.Visao.Servicos.Funcoes.Pedido;

namespace GlobalHost.Visao.Servicos.Funcoes
{
    public partial class Screen_Pedido : UserControl
    {
        private bool ins;
        private bool alt;
        private bool exc;

        private int aux;

        private int id;

        private int cont;
        private DataTable DataCarga;

        public Screen_Pedido()
        {
            id = 0;
            aux = 0;
            InitializeComponent();
            cont = 0;
            cbCliente.DataSource = Controle_Cliente.get("");
            cbCliente.DisplayMember = "nome";
            cbCliente.ValueMember = "id";
            cbCliente.Text = string.Empty;
            cbFiltroCarga.SelectedIndex = 0;
            cbFiltroPedido.SelectedIndex = 0;
            dgvPedido.DataSource = Controle_Pedido.get("");

            DataCarga = new DataTable();
            DataCarga.Columns.Add("id", typeof(int));
            DataCarga.Columns.Add("descricao", typeof(string));
            DataCarga.Columns.Add("volume", typeof(int));
            DataCarga.Columns.Add("peso", typeof(double));
            DataCarga.Columns.Add("dimensoes", typeof(string));
            DataCarga.Columns.Add("valor_unitario", typeof(double));
            DataCarga.Columns.Add("valor", typeof(double));
            DataCarga.Columns.Add("tipo", typeof(string));

            dotOrder.Visible = false;
            dotID.Visible = false;
            dotCliente.Visible = false;
            dotDestino.Visible = false;
            dotModalidade.Visible = false;
            dotOrigem.Visible = false;
        }

        private void changebool()
        {
            if (!ins)
            {
                btnInserir.ForeColor = Color.FromArgb(0, 122, 204);
                btnInserir.BackColor = Color.White;
                btnInserir.Image = GlobalHost.Properties.Resources.insert2;
            }
            if (!alt)
            {
                btnAlterar.ForeColor = Color.FromArgb(0, 122, 204);
                btnAlterar.BackColor = Color.White;
                btnAlterar.Image = GlobalHost.Properties.Resources.alterar2;
            }
            if (!exc)
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
            txtID.Text = string.Empty;
            cbCliente.Enabled = true;
            txtOrigem.Enabled = true;
            btOrigem.Enabled = true;
            txtDestino.Enabled = true;
            btDestino.Enabled = true;
            btnOk.Enabled = true;
            btnCancelar.Enabled = true;
            btMais.Enabled = true;
            btMenos.Enabled = true;
            btUpdate.Enabled = true;
            rdExclusivo.Enabled = true;
            rdExpresso.Enabled = true;

            dotOrder.Visible = true;
            dotID.Visible = false;
            dotCliente.Visible = true;
            dotDestino.Visible = true;
            dotModalidade.Visible = true;
            dotOrigem.Visible = true;

            ins = true;
            alt = false;
            exc = false;
            changebool();
            this.ActiveControl = null;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            btnAlterar.ForeColor = Color.White;
            btnAlterar.BackColor = Color.FromArgb(0, 122, 204);
            btnAlterar.Image = GlobalHost.Properties.Resources.alterar;

            txtID.Enabled = true;
            cbCliente.Enabled = true;
            txtOrigem.Enabled = true;
            btOrigem.Enabled = true;
            txtDestino.Enabled = true;
            btDestino.Enabled = true;
            btnOk.Enabled = true;
            btnCancelar.Enabled = true;
            btMais.Enabled = true;
            btMenos.Enabled = true;
            btUpdate.Enabled = true;
            rdExclusivo.Enabled = true;
            rdExpresso.Enabled = true;

            dotOrder.Visible = true;
            dotID.Visible = true;
            dotCliente.Visible = true;
            dotDestino.Visible = true;
            dotModalidade.Visible = true;
            dotOrigem.Visible = true;

            ins = false;
            alt = true;
            exc = false;
            changebool();
            this.ActiveControl = null;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            btnExcluir.ForeColor = Color.White;
            btnExcluir.BackColor = Color.FromArgb(0, 122, 204);
            btnExcluir.Image = GlobalHost.Properties.Resources.lixo;

            txtID.Enabled = true;
            cbCliente.Enabled = false;
            cbCliente.SelectedItem = null;
            cbCliente.Text = string.Empty;
            txtOrigem.Enabled = false;
            txtOrigem.Text = string.Empty;
            btOrigem.Enabled = false;
            txtDestino.Enabled = false;
            txtDestino.Text = string.Empty;
            btDestino.Enabled = false;
            btnOk.Enabled = true;
            btnCancelar.Enabled = true;
            btMais.Enabled = false;
            btMenos.Enabled = false;
            btUpdate.Enabled = false;
            rdExclusivo.Enabled = false;
            rdExpresso.Enabled = false;
            //dgvCarga.Rows.Clear();

            dotOrder.Visible = true;
            dotID.Visible = true;
            dotCliente.Visible = false;
            dotDestino.Visible = false;
            dotModalidade.Visible = false;
            dotOrigem.Visible = false;

            ins = false;
            alt = false;
            exc = true;
            changebool();
            this.ActiveControl = null;
        }

        private void btOrigem_Click(object sender, EventArgs e)
        {
            CEPTool ex = new CEPTool();
            ex.ShowDialog();
            if(!ex.IsCancel)
                txtOrigem.Text = ex.Str;
            ex.Dispose();
            this.ActiveControl = null;
        }

        private void btDestino_Click(object sender, EventArgs e)
        {
            CEPTool ex = new CEPTool();
            ex.ShowDialog();
            if (!ex.IsCancel)
                txtDestino.Text = ex.Str;
            ex.Dispose();
            this.ActiveControl = null;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtID.Enabled = false;
            txtID.Text = string.Empty;
            cbCliente.Enabled = false;
            cbCliente.SelectedItem = null;
            cbCliente.SelectedText = string.Empty;
            cbCliente.Text = string.Empty;
            txtOrigem.Enabled = false;
            txtOrigem.Text = string.Empty;
            btOrigem.Enabled = false;
            txtDestino.Enabled = false;
            txtDestino.Text = string.Empty;
            btDestino.Enabled = false;
            btnOk.Enabled = false;
            btnCancelar.Enabled = false;
            btMais.Enabled = false;
            btMenos.Enabled = false;
            btUpdate.Enabled = false;
            rdExclusivo.Enabled = false;
            rdExpresso.Enabled = false;

            dotOrder.Visible = false;
            dotID.Visible = false;
            dotCliente.Visible = false;
            dotDestino.Visible = false;
            dotModalidade.Visible = false;
            dotOrigem.Visible = false;

            dgvCarga.Rows.Clear();

            ins = false;
            alt = false;
            exc = false;
            changebool();
            this.ActiveControl = null;
        }

        private void LoadTable()
        {
            DataCarga.Rows.Clear();
            for (int i = 0; i < dgvCarga.Rows.Count; i++)
            {
                DataRow linha = DataCarga.NewRow();
                linha["id"] = dgvCarga.Rows[i].Cells["Carga_ID"].Value;
                linha["descricao"] = dgvCarga.Rows[i].Cells["Carga_Descricao"].Value;
                linha["volume"] = dgvCarga.Rows[i].Cells["Carga_Volume"].Value;
                linha["peso"] = dgvCarga.Rows[i].Cells["Carga_Peso"].Value;
                linha["dimensoes"] = dgvCarga.Rows[i].Cells["Carga_Dimensoes"].Value;
                linha["valor_unitario"] = dgvCarga.Rows[i].Cells["Carga_ValorUnit"].Value;
                linha["valor"] = dgvCarga.Rows[i].Cells["Carga_Valor"].Value;
                linha["tipo"] = dgvCarga.Rows[i].Cells["Carga_Tipo"].Value.ToString();//Controle_TipoCarga.get("descricao LIKE '%" + dgvCarga.Rows[i].Cells["Carga_Tipo"].Value.ToString() + "%'").Rows[0];
                DataCarga.Rows.Add(linha);
            }
        }

        private void LoadGrid()
        {
            if(dgvCarga.Rows.Count > 0)
                dgvCarga.Rows.Clear();
            for (int i = 0; i < DataCarga.Rows.Count; i++)
            {
                dgvCarga.Rows.Add();
                dgvCarga.Rows[i].Cells["Carga_ID"].Value = DataCarga.Rows[i]["id"];
                dgvCarga.Rows[i].Cells["Carga_Descricao"].Value = DataCarga.Rows[i]["descricao"];
                dgvCarga.Rows[i].Cells["Carga_Volume"].Value = DataCarga.Rows[i]["volume"];
                dgvCarga.Rows[i].Cells["Carga_Peso"].Value = DataCarga.Rows[i]["peso"];
                dgvCarga.Rows[i].Cells["Carga_Dimensoes"].Value = DataCarga.Rows[i]["dimensoes"];
                dgvCarga.Rows[i].Cells["Carga_ValorUnit"].Value = DataCarga.Rows[i]["valor_unitario"];
                dgvCarga.Rows[i].Cells["Carga_Valor"].Value = DataCarga.Rows[i]["valor"];
                dgvCarga.Rows[i].Cells["Carga_Tipo"].Value = DataCarga.Rows[i]["tipo"];
            }
        }

        private void btMais_Click(object sender, EventArgs e)
        {
            if (aux == 0)
            {
                DataCarga.Rows.Clear();
                aux++;
            }                
            LoadGrid();
            Screen_Carga ex = new Screen_Carga(Screen_Carga.INSERT);
            ex.ShowDialog();
            if(!ex.Cancel)
            {
                dgvCarga.Rows.Add(cont++, ex.Descricao, ex.Volume, ex.Peso, ex.Dimensoes, ex.Valor, ex.Total, ex.Tipo);
                LoadTable();
            }                
            ex.Dispose();
            
        }

        private void btMenos_Click(object sender, EventArgs e)
        {
            //LoadGrid();
            if (dgvCarga.SelectedRows.Count == 1)
            {
                if(MessageBox.Show("Deseja realmente exluir " + dgvCarga.SelectedRows[0].Cells["Carga_Descricao"].Value.ToString() + "?", "Exluir carga", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    dgvCarga.Rows.Remove(dgvCarga.SelectedRows[0]);
            }
            LoadTable();
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            LoadGrid();
            if (dgvCarga.SelectedRows.Count == 1)
            {
                Screen_Carga ex = new Screen_Carga(Screen_Carga.UPDATE);
                ex.Id = Convert.ToInt32(dgvCarga.SelectedRows[0].Cells["Carga_ID"].Value);
                ex.Descricao = dgvCarga.SelectedRows[0].Cells["Carga_Descricao"].Value.ToString();
                ex.Volume = Convert.ToInt32(dgvCarga.SelectedRows[0].Cells["Carga_Volume"].Value);
                ex.Peso = Convert.ToDouble(dgvCarga.SelectedRows[0].Cells["Carga_Peso"].Value);
                ex.Dimensoes = dgvCarga.SelectedRows[0].Cells["Carga_Dimensoes"].Value.ToString();
                ex.Valor = Convert.ToDouble(dgvCarga.SelectedRows[0].Cells["Carga_ValorUnit"].Value);
                ex.Total = Convert.ToDouble(dgvCarga.SelectedRows[0].Cells["Carga_Valor"].Value);
                ex.Tipo = dgvCarga.SelectedRows[0].Cells["Carga_Tipo"].Value.ToString();
                ex.load();
                ex.ShowDialog();
                if (!ex.Cancel)
                {
                    dgvCarga.SelectedRows[0].Cells["Carga_ID"].Value = ex.Id;
                    dgvCarga.SelectedRows[0].Cells["Carga_Descricao"].Value = ex.Descricao;
                    dgvCarga.SelectedRows[0].Cells["Carga_Volume"].Value = ex.Volume;
                    dgvCarga.SelectedRows[0].Cells["Carga_Peso"].Value = ex.Peso;
                    dgvCarga.SelectedRows[0].Cells["Carga_Dimensoes"].Value = ex.Dimensoes;
                    dgvCarga.SelectedRows[0].Cells["Carga_ValorUnit"].Value = ex.Valor;
                    dgvCarga.SelectedRows[0].Cells["Carga_Valor"].Value = ex.Total;
                    dgvCarga.SelectedRows[0].Cells["Carga_Tipo"].Value = ex.Tipo;
                }
            }
            LoadTable();
        }

        private void MenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (dgvCarga.SelectedRows.Count == 1)
            {
                if (MenuStrip.Items[0].Pressed)
                {
                    if (MessageBox.Show("Deseja realmente exluir " + dgvCarga.SelectedRows[0].Cells["Carga_Descricao"].Value.ToString() + "?", "Exluir carga", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        dgvCarga.Rows.Remove(dgvCarga.SelectedRows[0]);
                    LoadTable();
                }
                if (MenuStrip.Items[1].Pressed)
                {
                    LoadGrid();
                    Screen_Carga ex = new Screen_Carga(Screen_Carga.UPDATE);
                    ex.Id = Convert.ToInt32(dgvCarga.SelectedRows[0].Cells["Carga_ID"].Value);
                    ex.Descricao = dgvCarga.SelectedRows[0].Cells["Carga_Descricao"].Value.ToString();
                    ex.Volume = Convert.ToInt32(dgvCarga.SelectedRows[0].Cells["Carga_Volume"].Value);
                    ex.Peso = Convert.ToDouble(dgvCarga.SelectedRows[0].Cells["Carga_Peso"].Value);
                    ex.Dimensoes = dgvCarga.SelectedRows[0].Cells["Carga_Dimensoes"].Value.ToString();
                    ex.Valor = Convert.ToDouble(dgvCarga.SelectedRows[0].Cells["Carga_ValorUnit"].Value);
                    ex.Total = Convert.ToDouble(dgvCarga.SelectedRows[0].Cells["Carga_Valor"].Value);
                    ex.Tipo = dgvCarga.SelectedRows[0].Cells["Carga_Tipo"].Value.ToString();
                    ex.load();
                    ex.ShowDialog();
                    if (!ex.Cancel)
                    {
                        dgvCarga.SelectedRows[0].Cells["Carga_ID"].Value = ex.Id;
                        dgvCarga.SelectedRows[0].Cells["Carga_Descricao"].Value = ex.Descricao;
                        dgvCarga.SelectedRows[0].Cells["Carga_Volume"].Value = ex.Volume;
                        dgvCarga.SelectedRows[0].Cells["Carga_Peso"].Value = ex.Peso;
                        dgvCarga.SelectedRows[0].Cells["Carga_Dimensoes"].Value = ex.Dimensoes;
                        dgvCarga.SelectedRows[0].Cells["Carga_ValorUnit"].Value = ex.Valor;
                        dgvCarga.SelectedRows[0].Cells["Carga_Valor"].Value = ex.Total;
                        dgvCarga.SelectedRows[0].Cells["Carga_Tipo"].Value = ex.Tipo;
                    }
                    LoadTable();
                }
            } 
        }

        private void txtCarga_TextChanged(object sender, EventArgs e)
        {
            if (txtCarga.Text != string.Empty)
            {
                try
                {
                    switch (cbFiltroCarga.Text)
                    {
                        case "Descrição":
                            dgvCarga.Rows.Clear();
                            for (int i = 0; i < DataCarga.Rows.Count; i++)
                            {
                                if (DataCarga.Rows[i]["descricao"].ToString().ToLower().Contains(txtCarga.Text.ToLower()))
                                {
                                    dgvCarga.Rows.Add();
                                    dgvCarga.Rows[i].Cells["Carga_ID"].Value = DataCarga.Rows[i]["id"];
                                    dgvCarga.Rows[i].Cells["Carga_Descricao"].Value = DataCarga.Rows[i]["descricao"];
                                    dgvCarga.Rows[i].Cells["Carga_Volume"].Value = DataCarga.Rows[i]["volume"];
                                    dgvCarga.Rows[i].Cells["Carga_Peso"].Value = DataCarga.Rows[i]["peso"];
                                    dgvCarga.Rows[i].Cells["Carga_Dimensoes"].Value = DataCarga.Rows[i]["dimensoes"];
                                    dgvCarga.Rows[i].Cells["Carga_ValorUnit"].Value = DataCarga.Rows[i]["valor_unitario"];
                                    dgvCarga.Rows[i].Cells["Carga_Valor"].Value = DataCarga.Rows[i]["valor"];
                                    dgvCarga.Rows[i].Cells["Carga_Tipo"].Value = DataCarga.Rows[i]["tipo"];
                                }
                            }
                            break;

                        case "Volume":
                            dgvCarga.Rows.Clear();
                            for (int i = 0; i < DataCarga.Rows.Count; i++)
                            {
                                if (Convert.ToInt32(DataCarga.Rows[i]["volume"]) >= Convert.ToInt32(txtCarga.Text))
                                {
                                    dgvCarga.Rows.Add();
                                    dgvCarga.Rows[i].Cells["Carga_ID"].Value = DataCarga.Rows[i]["id"];
                                    dgvCarga.Rows[i].Cells["Carga_Descricao"].Value = DataCarga.Rows[i]["descricao"];
                                    dgvCarga.Rows[i].Cells["Carga_Volume"].Value = DataCarga.Rows[i]["volume"];
                                    dgvCarga.Rows[i].Cells["Carga_Peso"].Value = DataCarga.Rows[i]["peso"];
                                    dgvCarga.Rows[i].Cells["Carga_Dimensoes"].Value = DataCarga.Rows[i]["dimensoes"];
                                    dgvCarga.Rows[i].Cells["Carga_ValorUnit"].Value = DataCarga.Rows[i]["valor_unitario"];
                                    dgvCarga.Rows[i].Cells["Carga_Valor"].Value = DataCarga.Rows[i]["valor"];
                                    dgvCarga.Rows[i].Cells["Carga_Tipo"].Value = DataCarga.Rows[i]["tipo"];
                                }
                            }
                            break;

                        case "Peso":
                            dgvCarga.Rows.Clear();
                            for (int i = 0; i < DataCarga.Rows.Count; i++)
                            {
                                if (Convert.ToDouble(DataCarga.Rows[i]["peso"]) >= Convert.ToDouble(txtCarga.Text))
                                {
                                    dgvCarga.Rows.Add();
                                    dgvCarga.Rows[i].Cells["Carga_ID"].Value = DataCarga.Rows[i]["id"];
                                    dgvCarga.Rows[i].Cells["Carga_Descricao"].Value = DataCarga.Rows[i]["descricao"];
                                    dgvCarga.Rows[i].Cells["Carga_Volume"].Value = DataCarga.Rows[i]["volume"];
                                    dgvCarga.Rows[i].Cells["Carga_Peso"].Value = DataCarga.Rows[i]["peso"];
                                    dgvCarga.Rows[i].Cells["Carga_Dimensoes"].Value = DataCarga.Rows[i]["dimensoes"];
                                    dgvCarga.Rows[i].Cells["Carga_ValorUnit"].Value = DataCarga.Rows[i]["valor_unitario"];
                                    dgvCarga.Rows[i].Cells["Carga_Valor"].Value = DataCarga.Rows[i]["valor"];
                                    dgvCarga.Rows[i].Cells["Carga_Tipo"].Value = DataCarga.Rows[i]["tipo"];
                                }
                            }
                            break;

                        case "Dimensões":
                            dgvCarga.Rows.Clear();
                            for (int i = 0; i < DataCarga.Rows.Count; i++)
                            {
                                if (DataCarga.Rows[i]["dimensoes"].ToString().ToLower().Contains(txtCarga.Text.ToLower()))
                                {
                                    dgvCarga.Rows.Add();
                                    dgvCarga.Rows[i].Cells["Carga_ID"].Value = DataCarga.Rows[i]["id"];
                                    dgvCarga.Rows[i].Cells["Carga_Descricao"].Value = DataCarga.Rows[i]["descricao"];
                                    dgvCarga.Rows[i].Cells["Carga_Volume"].Value = DataCarga.Rows[i]["volume"];
                                    dgvCarga.Rows[i].Cells["Carga_Peso"].Value = DataCarga.Rows[i]["peso"];
                                    dgvCarga.Rows[i].Cells["Carga_Dimensoes"].Value = DataCarga.Rows[i]["dimensoes"];
                                    dgvCarga.Rows[i].Cells["Carga_ValorUnit"].Value = DataCarga.Rows[i]["valor_unitario"];
                                    dgvCarga.Rows[i].Cells["Carga_Valor"].Value = DataCarga.Rows[i]["valor"];
                                    dgvCarga.Rows[i].Cells["Carga_Tipo"].Value = DataCarga.Rows[i]["tipo"];
                                }
                            }
                            break;

                        case "Valor Unitário":
                            dgvCarga.Rows.Clear();
                            for (int i = 0; i < DataCarga.Rows.Count; i++)
                            {
                                if (Convert.ToDouble(DataCarga.Rows[i]["valor_unitario"]) >= Convert.ToDouble(txtCarga.Text))
                                {
                                    dgvCarga.Rows.Add();
                                    dgvCarga.Rows[i].Cells["Carga_ID"].Value = DataCarga.Rows[i]["id"];
                                    dgvCarga.Rows[i].Cells["Carga_Descricao"].Value = DataCarga.Rows[i]["descricao"];
                                    dgvCarga.Rows[i].Cells["Carga_Volume"].Value = DataCarga.Rows[i]["volume"];
                                    dgvCarga.Rows[i].Cells["Carga_Peso"].Value = DataCarga.Rows[i]["peso"];
                                    dgvCarga.Rows[i].Cells["Carga_Dimensoes"].Value = DataCarga.Rows[i]["dimensoes"];
                                    dgvCarga.Rows[i].Cells["Carga_ValorUnit"].Value = DataCarga.Rows[i]["valor_unitario"];
                                    dgvCarga.Rows[i].Cells["Carga_Valor"].Value = DataCarga.Rows[i]["valor"];
                                    dgvCarga.Rows[i].Cells["Carga_Tipo"].Value = DataCarga.Rows[i]["tipo"];
                                }
                            }
                            break;

                        case "Valor":
                            dgvCarga.Rows.Clear();
                            for (int i = 0; i < DataCarga.Rows.Count; i++)
                            {
                                if (Convert.ToDouble(DataCarga.Rows[i]["valor"]) >= Convert.ToDouble(txtCarga.Text))
                                {
                                    dgvCarga.Rows.Add();
                                    dgvCarga.Rows[i].Cells["Carga_ID"].Value = DataCarga.Rows[i]["id"];
                                    dgvCarga.Rows[i].Cells["Carga_Descricao"].Value = DataCarga.Rows[i]["descricao"];
                                    dgvCarga.Rows[i].Cells["Carga_Volume"].Value = DataCarga.Rows[i]["volume"];
                                    dgvCarga.Rows[i].Cells["Carga_Peso"].Value = DataCarga.Rows[i]["peso"];
                                    dgvCarga.Rows[i].Cells["Carga_Dimensoes"].Value = DataCarga.Rows[i]["dimensoes"];
                                    dgvCarga.Rows[i].Cells["Carga_ValorUnit"].Value = DataCarga.Rows[i]["valor_unitario"];
                                    dgvCarga.Rows[i].Cells["Carga_Valor"].Value = DataCarga.Rows[i]["valor"];
                                    dgvCarga.Rows[i].Cells["Carga_Tipo"].Value = DataCarga.Rows[i]["tipo"];
                                }
                            }
                            break;

                        case "Tipo":
                            dgvCarga.Rows.Clear();
                            for (int i = 0; i < DataCarga.Rows.Count; i++)
                            {
                                if (DataCarga.Rows[i]["tipo"].ToString().ToLower().Contains(txtCarga.Text.ToLower()))
                                {
                                    dgvCarga.Rows.Add();
                                    dgvCarga.Rows[i].Cells["Carga_ID"].Value = DataCarga.Rows[i]["id"];
                                    dgvCarga.Rows[i].Cells["Carga_Descricao"].Value = DataCarga.Rows[i]["descricao"];
                                    dgvCarga.Rows[i].Cells["Carga_Volume"].Value = DataCarga.Rows[i]["volume"];
                                    dgvCarga.Rows[i].Cells["Carga_Peso"].Value = DataCarga.Rows[i]["peso"];
                                    dgvCarga.Rows[i].Cells["Carga_Dimensoes"].Value = DataCarga.Rows[i]["dimensoes"];
                                    dgvCarga.Rows[i].Cells["Carga_ValorUnit"].Value = DataCarga.Rows[i]["valor_unitario"];
                                    dgvCarga.Rows[i].Cells["Carga_Valor"].Value = DataCarga.Rows[i]["valor"];
                                    dgvCarga.Rows[i].Cells["Carga_Tipo"].Value = DataCarga.Rows[i]["tipo"];
                                }
                            }
                            break;
                    }
                }
                catch { /*MessageBox.Show("error");*/ }
            }
            else
                LoadGrid();        
        }

        private void dgvCarga_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCarga.SelectedRows.Count == 1)
            {
                LoadGrid();
                Screen_Carga ex = new Screen_Carga(Screen_Carga.UPDATE);
                ex.Id = Convert.ToInt32(dgvCarga.SelectedRows[0].Cells["Carga_ID"].Value);
                ex.Descricao = dgvCarga.SelectedRows[0].Cells["Carga_Descricao"].Value.ToString();
                ex.Volume = Convert.ToInt32(dgvCarga.SelectedRows[0].Cells["Carga_Volume"].Value);
                ex.Peso = Convert.ToDouble(dgvCarga.SelectedRows[0].Cells["Carga_Peso"].Value);
                ex.Dimensoes = dgvCarga.SelectedRows[0].Cells["Carga_Dimensoes"].Value.ToString();
                ex.Valor = Convert.ToDouble(dgvCarga.SelectedRows[0].Cells["Carga_ValorUnit"].Value);
                ex.Total = Convert.ToDouble(dgvCarga.SelectedRows[0].Cells["Carga_Valor"].Value);
                ex.Tipo = dgvCarga.SelectedRows[0].Cells["Carga_Tipo"].Value.ToString();
                ex.load();
                ex.ShowDialog();
                if (!ex.Cancel)
                {
                    dgvCarga.SelectedRows[0].Cells["Carga_ID"].Value = ex.Id;
                    dgvCarga.SelectedRows[0].Cells["Carga_Descricao"].Value = ex.Descricao;
                    dgvCarga.SelectedRows[0].Cells["Carga_Volume"].Value = ex.Volume;
                    dgvCarga.SelectedRows[0].Cells["Carga_Peso"].Value = ex.Peso;
                    dgvCarga.SelectedRows[0].Cells["Carga_Dimensoes"].Value = ex.Dimensoes; 
                    dgvCarga.SelectedRows[0].Cells["Carga_ValorUnit"].Value = ex.Valor;
                    dgvCarga.SelectedRows[0].Cells["Carga_Valor"].Value = ex.Total;
                    dgvCarga.SelectedRows[0].Cells["Carga_Tipo"].Value = ex.Tipo;
                }
                LoadTable();
            }
        }

        private void Clear()
        {
            txtID.Enabled = false;
            txtID.Text = string.Empty;
            cbCliente.Enabled = false;
            cbCliente.SelectedItem = null;
            cbCliente.SelectedText = string.Empty;
            cbCliente.Text = string.Empty;
            txtOrigem.Enabled = false;
            txtOrigem.Text = string.Empty;
            btOrigem.Enabled = false;
            txtDestino.Enabled = false;
            txtDestino.Text = string.Empty;
            btDestino.Enabled = false;
            btnOk.Enabled = true;
            btnCancelar.Enabled = true;
            btMais.Enabled = false;
            btMenos.Enabled = false;
            btUpdate.Enabled = false;
            rdExclusivo.Enabled = false;
            rdExpresso.Enabled = false;
            dgvCarga.Rows.Clear();

            dotOrder.Visible = false;
            dotID.Visible = false;
            dotCliente.Visible = false;
            dotDestino.Visible = false;
            dotModalidade.Visible = false;
            dotOrigem.Visible = false;

            ins = false;
            alt = false;
            exc = false;
            changebool();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (ins == true)
            {
                if (cbCliente.Text != string.Empty && txtOrigem.Text != string.Empty && txtDestino.Text != string.Empty)
                {
                    if (dgvCarga.Rows.Count > 0)
                    {
                        string n;
                        if (rdExpresso.Checked)
                            n = "Expresso";
                        else
                            n = "Exclusivo";
                        
                        if (!Controle_Pedido.Insert(DateTime.Now.Date, n, txtOrigem.Text, txtDestino.Text, Controle_Parametro.get().Razao_social, "Em espera", (int)Controle_Cliente.get(cbCliente.Text).Rows[0]["id"], Program.FUNC))
                            MessageBox.Show("Pedido não efetuado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                        {
                            int i = 0;
                            for (i = 0; i < dgvCarga.Rows.Count; i++)
                            {
                                Controle_Carga.Insert(dgvCarga.Rows[i].Cells["Carga_Descricao"].Value.ToString(),
                                                        Convert.ToInt32(dgvCarga.Rows[i].Cells["Carga_Volume"].Value),
                                                        Convert.ToDouble(dgvCarga.Rows[i].Cells["Carga_Peso"].Value),
                                                        dgvCarga.Rows[i].Cells["Carga_Dimensoes"].Value.ToString(),
                                                        Convert.ToDouble(dgvCarga.Rows[i].Cells["Carga_ValorUnit"].Value.ToString()),
                                                        Convert.ToDouble(dgvCarga.Rows[i].Cells["Carga_Valor"].Value.ToString()),
                                                        dgvCarga.Rows[i].Cells["Carga_Tipo"].Value.ToString(),
                                                        Controle_Pedido.MAX());
                            }
                            Clear();
                            aux = 0;
                        }
                    }
                    else
                        MessageBox.Show("Deve ter ao menos uma carga cadastrada no pedido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Todos os campos obrigatórios(*) devem estar preenchidos e válidos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if(alt == true)
            {
                if (txtID.Text != string.Empty && cbCliente.Text != string.Empty && txtOrigem.Text != string.Empty && txtDestino.Text != string.Empty)
                {
                    if (dgvCarga.Rows.Count > 0)
                    {
                        string n;
                        if (rdExpresso.Checked)
                            n = "Expresso";
                        else
                            n = "Exclusivo";
                        if (Controle_Pedido.get("id = " + txtID.Text).Rows[0]["remessa"].ToString() == "")
                        {
                            if (!Controle_Pedido.Update(id, DateTime.Now.Date, n, txtOrigem.Text, txtDestino.Text, Controle_Parametro.get().Razao_social, "Em espera", (int)Controle_Cliente.get(cbCliente.Text).Rows[0]["id"], Program.FUNC))
                                MessageBox.Show("Pedido não atualizado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            else
                            {
                                Controle_Carga.DeleteByPedido(id);
                                int i = 0;
                                for (i = 0; i < dgvCarga.Rows.Count; i++)
                                {
                                    Controle_Carga.Insert(dgvCarga.Rows[i].Cells["Carga_Descricao"].Value.ToString(),
                                                            Convert.ToInt32(dgvCarga.Rows[i].Cells["Carga_Volume"].Value),
                                                            Convert.ToDouble(dgvCarga.Rows[i].Cells["Carga_Peso"].Value),
                                                            dgvCarga.Rows[i].Cells["Carga_Dimensoes"].Value.ToString(),
                                                            Convert.ToDouble(dgvCarga.Rows[i].Cells["Carga_ValorUnit"].Value.ToString()),
                                                            Convert.ToDouble(dgvCarga.Rows[i].Cells["Carga_Valor"].Value.ToString()),
                                                            dgvCarga.Rows[i].Cells["Carga_Tipo"].Value.ToString(), id);
                                }
                                Clear();
                                aux = 0;
                            }
                        }
                        else
                            MessageBox.Show("Erro ao alterar pedido [" + txtID.Text + "]!\nNão é possível excluir um pedido que já está dentro de uma remessa!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        
                    }
                    else
                        MessageBox.Show("Deve ter ao menos uma carga no pedido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Todos os campos obrigatórios(*) devem estar preenchidos e válidos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if(exc == true)
            {
                if(txtID.Text != string.Empty)
                {
                    if(Controle_Pedido.get("id = " + txtID.Text).Rows[0]["remessa"].ToString() == "") 
                    {
                        if (Controle_Pedido.get("id = " + txtID.Text).Rows.Count > 0)
                        {
                            if (MessageBox.Show("Deseja realmente excluir o pedido (" + txtID.Text + ")?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                if (!Controle_Pedido.Delete(Convert.ToInt32(txtID.Text)))
                                    MessageBox.Show("Pedido não excluído!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                else
                                {
                                    Clear();
                                    aux = 0;
                                }                                   
                        }
                    }
                    else
                        MessageBox.Show("Erro ao alterar pedido [" + txtID.Text + "]!\nNão é possível excluir um pedido que já está dentro de uma remessa!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            dgvPedido.DataSource = Controle_Pedido.get("");
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            if (txtID.Text != "")
            {
                try
                {
                    id = Convert.ToInt32(txtID.Text);
                    txtID.Select(txtID.Text.Length, 0);
                }
                catch (Exception)
                {
                    txtID.Text = id.ToString();
                    txtID.Select(txtID.Text.Length, 0);
                }
            }
        }

        private void txtBuscarPedido_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscarPedido.Text != string.Empty)
            {
                switch(cbFiltroPedido.Text)
                {
                    case "Data":
                        dgvPedido.DataSource = Controle_Pedido.get("data = " + txtBuscarPedido.Text);
                        break;
                    case "Modalidade":
                        dgvPedido.DataSource = Controle_Pedido.get("modalidade LIKE '%" + txtBuscarPedido.Text + "%'");
                        break;

                    case "Origem":
                        dgvPedido.DataSource = Controle_Pedido.get("origem LIKE '%" + txtBuscarPedido.Text + "%'");
                        break;

                    case "Destino":
                        dgvPedido.DataSource = Controle_Pedido.get("destino LIKE '%" + txtBuscarPedido.Text + "%'");
                        break;

                    case "Despachante":
                        dgvPedido.DataSource = Controle_Pedido.get("despachante LIKE '%" + txtBuscarPedido.Text + "%'");
                        break;

                    case "Situação":
                        dgvPedido.DataSource = Controle_Pedido.get("situacao LIKE '%" + txtBuscarPedido.Text + "%'");
                        break;

                    case "Autorização":
                        dgvPedido.DataSource = Controle_Pedido.get("autorizacao LIKE '%" + txtBuscarPedido.Text + "%'");
                        break;
                }
            }
            else
                dgvPedido.DataSource = Controle_Pedido.get("");
        }

        private void dgvPedido_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvPedido.SelectedRows.Count == 1)
            {
                txtID.Text = dgvPedido.SelectedRows[0].Cells["Pedido_ID"].Value.ToString();
                cbCliente.Text = dgvPedido.SelectedRows[0].Cells["Pedido_Cliente"].Value.ToString();           
                txtOrigem.Text = dgvPedido.SelectedRows[0].Cells["Pedido_Origem"].Value.ToString();
                txtDestino.Text = dgvPedido.SelectedRows[0].Cells["Pedido_Destino"].Value.ToString();
                if (dgvPedido.SelectedRows[0].Cells["Pedido_Modalidade"].Value.ToString() == "Expresso")
                {
                    rdExpresso.Checked = true;
                    rdExclusivo.Checked = false;
                }
                else
                {
                    rdExpresso.Checked = false;
                    rdExclusivo.Checked = true;
                }

                DataCarga = Controle_Carga.get("pedido = " + Convert.ToInt32(txtID.Text));
                LoadGrid();
            }
        }
    }
}
