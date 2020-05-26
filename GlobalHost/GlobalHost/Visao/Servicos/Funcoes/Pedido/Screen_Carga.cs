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

namespace GlobalHost.Visao.Servicos.Funcoes.Pedido
{
    public partial class Screen_Carga : Form
    {
        private int id;
        private string tipo;
        private string descricao;
        private double peso;
        private string dimensoes;
        private int volume;
        private double valor;
        private double total;

        private bool cancel;

        private double L;
        private double A;
        private double C;

        private int op;

        public static int INSERT = 1;
        public static int UPDATE = 2;
        public static int DELETE = 3;

        public int Id { get => id; set => id = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public double Peso { get => peso; set => peso = value; }
        public string Dimensoes { get => dimensoes; set => dimensoes = value; }
        public int Volume { get => volume; set => volume = value; }
        public double Valor { get => valor; set => valor = value; }
        public double Total { get => total; set => total = value; }
        public bool Cancel { get => cancel; set => cancel = value; }

        public Screen_Carga(int op)
        {
            this.op = op;
            this.cancel = false;
            InitializeComponent();
            cbTipo.DataSource = Controle_TipoCarga.get("");
            cbTipo.DisplayMember = "descricao";
            cbTipo.ValueMember = "id";
            switch(op)
            {
                case 1:
                    this.Text = "Cadastro de Carga";
                    dotID.Visible = false;
                    txtID.Enabled = false;
                    break;

                case 2:
                    this.Text = "Atualização de Carga";
                    break;

                case 3:
                    this.Text = "Remoção de Carga";
                    cbTipo.Enabled = false;
                    dotTipo.Visible = false;
                    txtDesc.Enabled = false;
                    dotDesc.Visible = false;
                    txtPeso.Enabled = false;
                    dotPeso.Visible = false;
                    txtLargura.Enabled = false;
                    dotLargura.Visible = false;
                    txtAltura.Enabled = false;
                    dotAltura.Visible = false;
                    txtComprimento.Enabled = false;
                    dotComprimento.Visible = false;
                    numVolume.Enabled = false;
                    dotVolume.Visible = false;
                    txtValor.Enabled = false;
                    dotValor.Visible = false;
                    break;
            }
        }

        public void load()
        {   
            if(op != INSERT)
                txtID.Text = id.ToString();
            if(op != DELETE)
            {
                txtDesc.Text = descricao;
                txtPeso.Text = peso.ToString();
                string[] str = dimensoes.Split(';');
                txtLargura.Text = str[0];
                txtAltura.Text = str[1];
                txtComprimento.Text = str[2];
                numVolume.Value = volume;
                txtValor.Text = valor.ToString();
                txtTotal.Text = total.ToString();
                cbTipo.SelectedItem = tipo;
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.cancel = true;
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            bool b = false;
            switch(op)
            {
                case 1:
                    if (txtDesc.Text != string.Empty && txtPeso.Text != string.Empty && txtLargura.Text != string.Empty
                        && txtAltura.Text != string.Empty && txtComprimento.Text != string.Empty && txtValor.Text != string.Empty
                        && txtTotal.Text != string.Empty && cbTipo.SelectedItem != null && (numVolume.Value >= 1 && numVolume.Value <= 5000))
                        b = true;
                    break;

                case 2:
                    if (txtID.Text != string.Empty && txtDesc.Text != string.Empty && txtPeso.Text != string.Empty && txtLargura.Text != string.Empty
                        && txtAltura.Text != string.Empty && txtComprimento.Text != string.Empty && txtValor.Text != string.Empty
                        && txtTotal.Text != string.Empty && cbTipo.SelectedItem != null && (numVolume.Value >= 1 && numVolume.Value <= 5000))
                        b = true;
                    break;

                case 3:
                    if (txtID.Text != string.Empty)
                        b = true;
                    break;
            }

            if (b)
            {
                if (op != INSERT)
                    id = Convert.ToInt32(txtID.Text);
                if (op != DELETE)
                {
                    descricao = txtDesc.Text;
                    peso = Convert.ToDouble(txtPeso.Text);
                    dimensoes = txtLargura.Text + ";" + txtAltura.Text + ";" + txtComprimento.Text;
                    volume = Convert.ToInt32(numVolume.Value);
                    valor = Convert.ToDouble(txtValor.Text);
                    total = Convert.ToDouble(txtTotal.Text);
                    tipo = cbTipo.Text;
                }
                this.Close();
            }
            else
                MessageBox.Show("Todos os campos obrigatórios(*) devem estar preenchidos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {
            txtValor.Text = API.Validate.MONEY(txtValor.Text);
            if (txtValor.Text != string.Empty)
            {
                txtTotal.Text = (Convert.ToDouble(txtValor.Text) * Convert.ToInt32(numVolume.Value)).ToString();
            }
        }

        private void numVolume_ValueChanged(object sender, EventArgs e)
        {
            if (txtValor.Text != string.Empty)
            {
                txtTotal.Text = (Convert.ToDouble(txtValor.Text) * Convert.ToInt32(numVolume.Value)).ToString();
            }
        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {
            txtTotal.Text = API.Validate.MONEY(txtTotal.Text);
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

        private void txtPeso_TextChanged(object sender, EventArgs e)
        {
            if (txtPeso.Text != "" && txtPeso.Text[txtPeso.Text.Length - 1] != ',')
            {
                try
                {
                    peso = Convert.ToDouble(txtPeso.Text);
                    txtPeso.Text = "" + peso;
                    txtPeso.Select(txtPeso.Text.Length, 0);
                }
                catch (Exception)
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
    }
}
