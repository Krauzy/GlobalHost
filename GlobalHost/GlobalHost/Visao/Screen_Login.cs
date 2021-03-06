﻿using GlobalHost.Controlador;
using System;
using System.Drawing;
using System.Threading;
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
            picBox.Image = Controle_Parametro.getLogo();
            PopUp.ContextMenuStrip = LittleMenu;

            this.ActiveControl = btEntrar;
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
                txtSenha.Text = txtSenha.Text.Trim().Replace(" ", "");
                pass = txtSenha.Text;
                txtSenha.Select(txtSenha.Text.Length, 0);
            }
        }

        private void btEye_Click(object sender, EventArgs e)
        {
            if (eye)
            {
                txtSenha.UseSystemPasswordChar = true;
                eye = false;
            }
            else
            {
                txtSenha.UseSystemPasswordChar = false;
                eye = true;
            }
        }

        private void linkFrgtPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Função em obra... previsão [versão 1.0.0]", "Espere", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btEntrar_Click(object sender, EventArgs e)
        {
            if(Controle_Login.check(txtUsuario.Text, txtSenha.Text))
            {
                int lid = Controle_Login.get(txtUsuario.Text);
                Program.Global_User = Controle_Funcionario.get("login = " + lid).Rows[0]["nome"].ToString();
                Program.FUNC = Convert.ToInt32(Controle_Funcionario.get("login = " + lid).Rows[0]["id"]);
                Program.admin = Controle_Login.isAdmin(lid);
                PopUp.ShowBalloonTip(1, "Notificação de Login", "Bem Vindo " + Program.Global_User, ToolTipIcon.Info);
                Visao.Menu ex = new Menu();
                Visible = false;
                ex.ShowDialog();
                Visible = true;
                ex.Dispose();
                //this.Close();
            }
            else
            {
                MessageBox.Show("Usuário ou Senha incorreto(s)", "Erro de login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void itFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
