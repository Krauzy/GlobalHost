using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GlobalHost.Visao
{
    public partial class Screen_Login : Form
    {

        private string user;
        private string pass;
        private bool eye;

        public Screen_Login()
        {
            InitializeComponent();
            user = "";
            pass = "";
            eye = false;
            txtSenha.UseSystemPasswordChar = true;
        }

        private void txtUsuario_Click(object sender, EventArgs e)
        {
            if(user == string.Empty)
            {
                txtUsuario.Text = "";
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if(user == string.Empty)
            {
                txtUsuario.Text = "Usuário";
            }
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            if(txtUsuario.Text != "Usuário")
                user = txtUsuario.Text;
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btClose_MouseEnter(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            bt.BackColor = Color.Red;
            bt.ForeColor = Color.White;
        }

        private void btClose_MouseLeave(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            bt.BackColor = Color.White;
            bt.ForeColor = Color.FromArgb(51, 51, 51);
        }

        private void txtSenha_Click(object sender, EventArgs e)
        {
            if (pass == string.Empty)
            {
                txtSenha.Text = "";
            }
        }

        private void txtSenha_Leave(object sender, EventArgs e)
        {
            if (pass == string.Empty)
            {
                txtSenha.Text = "Senha";
            }
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            if(txtSenha.Text != "Senha")
            {
                pass = txtSenha.Text;
            }
        }

        private void btEye_Click(object sender, EventArgs e)
        {
            if (eye)
                eye = txtSenha.UseSystemPasswordChar = false;
            else
                eye = txtSenha.UseSystemPasswordChar = true;
        }

        private void linkFrgtPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Função em obra... previsão [versão 1.0.0]", "Espere", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btEntrar_Click(object sender, EventArgs e)
        {
            Visao.Menu ex = new Menu();
            Visible = false;
            ex.ShowDialog();
        }
    }
}
