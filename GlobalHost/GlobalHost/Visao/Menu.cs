using GlobalHost.Controlador;
using GlobalHost.Visao.Servicos;
using System;
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
        private bool ger = false;
        private bool fun = false;
        private bool rel = false;

        public Menu()
        {
            InitializeComponent();
            paneMenu.BringToFront();
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

        public void LoadLogo()
        {
            pictureBox1.Image = Controle_Parametro.getLogo();
        }

        private void changeBoolServ()
        {
            if (ger == false)
            {
                btGer.ForeColor = Color.FromArgb(51, 51, 51);
                btGer.BackColor = Color.White;
            }
            if (fun == false)
            {
                btFun.ForeColor = Color.FromArgb(51, 51, 51);
                btFun.BackColor = Color.White;
            }
            if (rel == false)
            {
                btRel.ForeColor = Color.FromArgb(51, 51, 51);
                btRel.BackColor = Color.White;
            }
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
            ScreenSobre.LoadLogo(this);
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
            pnHome.BringToFront();
            paneServ.BringToFront();
            btGer.ForeColor = Color.White;
            btGer.BackColor = Color.FromArgb(0, 122, 204);
            ger = true;
            fun = false;
            rel = false;
            changeBoolServ();
            pnGerenciamento.BringToFront();
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

        private void btGer_Click(object sender, EventArgs e)
        {
            ((Button)sender).ForeColor = Color.White;
            ((Button)sender).BackColor = Color.FromArgb(0, 122, 204);
            ger = true;
            fun = false;
            rel = false;
            changeBoolServ();
            pnGerenciamento.BringToFront();
        }

        private void btFun_Click(object sender, EventArgs e)
        {
            ((Button)sender).ForeColor = Color.White;
            ((Button)sender).BackColor = Color.FromArgb(0, 122, 204);
            ger = false;
            fun = true;
            rel = false;
            changeBoolServ();
            pnFuncoes.BringToFront();
        }

        private void btRel_Click(object sender, EventArgs e)
        {
            ((Button)sender).ForeColor = Color.White;
            ((Button)sender).BackColor = Color.FromArgb(0, 122, 204);
            ger = false;
            fun = false;
            rel = true;
            changeBoolServ();
            pnRelatorios.BringToFront();
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            btHome.ForeColor = Color.White;
            btHome.BackColor = Color.FromArgb(0, 122, 204);
            cot = false;
            home = true;
            ser = false;
            sobre = false;
            changeBool();
            pnHome.BringToFront();
            paneMenu.BringToFront();
        }

        private void btTipoTransporte_Click(object sender, EventArgs e)
        {
            ger = false;
            fun = false;
            rel = false;
            changeBoolServ();
            scrTipo_Transporte.BringToFront();
        }

        private void btTransportadora_Click(object sender, EventArgs e)
        {
            ger = false;
            fun = false;
            rel = false;
            changeBoolServ();
            scrTrans.load();
            scrTrans.BringToFront();
        }

        private void btFuncionario_Click(object sender, EventArgs e)
        {
            ger = false;
            fun = false;
            rel = false;
            changeBoolServ();
            scrFuncionario.BringToFront();
        }

        private void btTipoCarga_Click(object sender, EventArgs e)
        {
            Screen_TipoCarga ex = new Screen_TipoCarga();
            ex.ShowDialog();
        }

        private void btCliente_Click(object sender, EventArgs e)
        {
            Screen_Cliente ex = new Screen_Cliente();
            ex.ShowDialog();
        }

        private void btPedido_Click(object sender, EventArgs e)
        {
            ger = false;
            fun = false;
            rel = false;
            changeBoolServ();
            scrPedido.BringToFront();
        }

        private void btRemessa_Click(object sender, EventArgs e)
        {
            ger = false;
            fun = false;
            rel = false;
            changeBoolServ();
            scrRemessa.BringToFront();
        }
    }
}
