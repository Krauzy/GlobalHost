﻿using GlobalHost.Controlador;
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

        public Screen_Carga(int op)
        {
            this.op = op;
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
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
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
                    dimensoes = txtLargura.Text + ";" + txtLargura.Text + ";" + txtComprimento.Text;
                    volume = Convert.ToInt32(numVolume.Value);
                    valor = Convert.ToDouble(txtValor.Text);
                    total = Convert.ToDouble(txtTotal.Text);
                }
                this.Close();
            }
            else
                MessageBox.Show("Todos os campos obrigatórios(*) devem estar preenchidos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
