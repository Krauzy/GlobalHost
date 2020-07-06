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
using GlobalHost.API;
using GlobalHost.Modelo;

namespace GlobalHost.Visao.Servicos.Funcoes
{
    public partial class ScreenRealizarPagamento : UserControl
    {
        Controle_Despesa cd;
        Controle_ContasPagar ccp;
        DataTable dt, notPagas;
        public ScreenRealizarPagamento()
        {
            InitializeComponent();
            cd = new Controle_Despesa();
            ccp = new Controle_ContasPagar();
            carregaCB();
            dgvContas.DataSource = dt;
            notPagas = cd.getNotPagas();
            if(notPagas.Rows.Count == 0)
            {
                cbDespesa.Enabled = false;
                MessageBox.Show("Não existem despesas pendentes para pagamento", "ERRO",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            //txtID.Text = cbDespesa.SelectedValue.ToString();
            //txtValor.Text = sumCol(1).ToString();
            Filters.numericField(txtValor);
            btnOk.Enabled = false;
        }
        public void carregaCB()
        {
            cbDespesa.ValueMember = "id";
            cbDespesa.DisplayMember = "descricao";
            cbDespesa.DataSource = notPagas;
            //cbDespesa.SelectedIndex = 0;
            
            dt = ccp.getListContasByDespesa(Convert.ToInt32(cbDespesa.SelectedValue));
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            bool res = false;//ccp.updateAll(lbAPagar.Items);
            foreach(object o in lbAPagar.Items)
            {
                res = ccp.pay(Convert.ToInt32(o.ToString().Split(',')[0]),Convert.ToDouble(txtValor.Text),Convert.ToDouble(txtAPagar.Text));
                //txtValor.Text = (Convert.ToDouble(txtValor.Text) - Convert.ToDouble(lbAPagar.Items[lbAPagar.Items.IndexOf(o)].ToString().Split(',')[1])).ToString();
            }
            if(res)
            {
                MessageBox.Show("O pagamento foi realizado com sucesso!");
            }
            else
            {
                MessageBox.Show("O pagamento da despesa falhou, tente novamente mais tarde...");
            }
            carregaCB();
            lbAPagar.Items.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataRow dr = cd.get(cbDespesa.SelectedValue).Rows[0];
            string s = txtID.Text + "," + txtValor.Text + "," + dr[2] + "," + dr[3] + "," + txtAPagar.Text;
            lbAPagar.Items.Add(s);
            btnOk.Enabled = true;
            btnRemove.Enabled = true;
        }

        private void cbDespesa_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cbDespesa.Items.Add(ccp.getListaContas(int.Parse(cbDespesa.SelectedValue.ToString())));
            dt = ccp.getListContasByDespesa(Convert.ToInt32(cbDespesa.SelectedValue));
            txtID.Text = cbDespesa.SelectedValue.ToString();
            txtValor.Text = sumCol(1).ToString();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo excluir?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                lbAPagar.Items.Remove(lbAPagar.SelectedItem);
                if (lbAPagar.Items.Count == 0)
                {
                    btnOk.Enabled = false;
                    btnRemove.Enabled = false;
                }

            }   
        }
        public double sumCol(int col)
        {
            double soma = 0;
            for(int i = 0; i < dt.Rows.Count;i++)
            {
                soma += Convert.ToDouble(dt.Rows[i][col]);
            }
            return soma;
        }
        private void dgvContas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = cbDespesa.SelectedValue.ToString() ;//dt.Rows[dgvContas.CurrentRow.Index][0].ToString();
            txtValor.Text = sumCol(1).ToString();
        }
    }
}
