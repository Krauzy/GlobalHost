using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace GlobalHost.Visao
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        // Botão Fechar
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
            bt.ForeColor = Color.Black;
        }


        // Botão Minimizar
        private void brMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void brMinimize_MouseEnter(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            bt.BackColor = Color.FromArgb(0,122,204);
            bt.ForeColor = Color.White;
        }

        private void brMinimize_MouseLeave(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            bt.BackColor = Color.White;
            bt.ForeColor = Color.Black;
        }


        //
    }
}
