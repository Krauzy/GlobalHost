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
        private bool cot = false;
        private bool home = false;
        private bool ser = false;
        private bool sobre = false;

        public Menu()
        {
            InitializeComponent();
            //
            btHome.ForeColor = Color.White;
            btHome.BackColor = Color.FromArgb(0, 122, 204);
            cot = false;
            home = true;
            ser = false;
            sobre = false;
            changeBool();
            pnHome.BringToFront();
            //

        }

        private void changeBool()
        {
            if(cot == false)
            {
                btCot.ForeColor = Color.FromArgb(51,51,51);
                btCot.BackColor = Color.White;
            }
            if (home == false)
            {
                btHome.ForeColor = Color.FromArgb(51, 51, 51);
                btHome.BackColor = Color.White;
            }
            if (ser == false)
            {
                btServ.ForeColor = Color.FromArgb(51, 51, 51);
                btServ.BackColor = Color.White;
            }
            if (sobre == false)
            {
                btSobre.ForeColor = Color.FromArgb(51, 51, 51);
                btSobre.BackColor = Color.White;
            }
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
            bt.ForeColor = Color.FromArgb(51, 51, 51);
        }


        // Botão Minimizar
        private void brMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void brMinimize_MouseEnter(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            bt.BackColor = Color.FromArgb(0, 122, 204);
            bt.ForeColor = Color.White;
        }

        private void brMinimize_MouseLeave(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            bt.BackColor = Color.White;
            bt.ForeColor = Color.FromArgb(51, 51, 51);
        }

        private void btSobre_Click(object sender, EventArgs e)
        {
            ((Button)sender).ForeColor = Color.White;
            ((Button)sender).BackColor = Color.FromArgb(0, 122, 204);
            cot = false;
            home = false;
            ser = false;
            sobre = true;
            changeBool();
            ScreenSobre.BringToFront();
        }

        private void btHome_Click(object sender, EventArgs e)
        {
            ((Button)sender).ForeColor = Color.White;
            ((Button)sender).BackColor = Color.FromArgb(0, 122, 204);
            cot = false;
            home = true;
            ser = false;
            sobre = false;
            changeBool();
            pnHome.BringToFront();
        }

        private void btServ_Click(object sender, EventArgs e)
        {
            ((Button)sender).ForeColor = Color.White;
            ((Button)sender).BackColor = Color.FromArgb(0, 122, 204);
            cot = false;
            home = false;
            ser = true;
            sobre = false;
            changeBool();
        }

        private void btCot_Click(object sender, EventArgs e)
        {
            ((Button)sender).ForeColor = Color.White;
            ((Button)sender).BackColor = Color.FromArgb(0, 122, 204);
            cot = true;
            home = false;
            ser = false;
            sobre = false;
            changeBool();
            ScreenCotacao.BringToFront();
        }

    }
}
