using GlobalHost.API;
using GlobalHost.Controlador;
using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace GlobalHost.Visao
{
    public partial class Param : Form
    {
        private DateTime data;
        private Visao.Menu menu;
        public Param()
        {
            InitializeComponent();
            btOk.Visible = false;
            btCancelar.Visible = false;
            btImage.Location = new Point(btImage.Location.X, picBox.Location.Y + picBox.Size.Height + 6);
            txtImage.Location = new Point(txtImage.Location.X, picBox.Location.Y + picBox.Size.Height + 7);

            ordNome.Visible = false;
            ordRazao.Visible = false;
            ordLogo.Visible = false;
            ordCNPJ.Visible = false;
            ordData.Visible = false;
            ordEndereco.Visible = false;
            ordEmail.Visible = false;
            ordTelefone.Visible = false;
            ordAtividade.Visible = false;
            ordSite.Visible = false;
            ordOrder.Visible = false;

            var t = new Thread(() =>
            {
                init();
            });
            Cursor.Current = Cursors.AppStarting;
            t.Start();
            t.Join();
            Cursor.Current = Cursors.Arrow;
        }

        public void LoadLogo(Visao.Menu menu)
        {
            this.menu = menu;
        }

        private void init()
        {
            txtNome.Visible = false;
            txtRazao.Visible = false;
            txtCnpj.Visible = false;
            dtpDate.Visible = false;
            txtEnd.Visible = false;
            txtEmail.Visible = false;
            txtTel.Visible = false;
            txtEcon.Visible = false;
            txtSite.Visible = false;

            data = Controle_Parametro.get().Data_abertura;

            lbCNPJ.Text = Controle_Parametro.get().Cnpj;
            lbCNPJ.BringToFront();
            lbCNPJ.Visible = true;

            lbAtividade.Text = Controle_Parametro.get().Atividade;
            lbAtividade.BringToFront();
            lbAtividade.Visible = true;

            lbData.Text = this.data.Day + "/" + this.data.Month + "/" + this.data.Year;
            lbData.BringToFront();
            lbData.Visible = true;

            lbEmail.Text = Controle_Parametro.get().Email;
            lbEmail.BringToFront();
            lbEmail.Visible = true;

            lbEndereco.Text = Controle_Parametro.get().Endereco;
            lbEndereco.BringToFront();
            lbEndereco.Visible = true;

            lbNome.Text = Controle_Parametro.get().Nome_fantasia;
            lbNome.BringToFront();
            lbNome.Visible = true;

            lbRazao.Text = Controle_Parametro.get().Razao_social;
            lbRazao.BringToFront();
            lbRazao.Visible = true;

            lbSite.Text = Controle_Parametro.get().Site;
            lbSite.BringToFront();
            lbSite.Visible = true;
            
            lbTelefone.Text = Controle_Parametro.get().Telefone;
            lbTelefone.BringToFront();
            lbTelefone.Visible = true;

            picBox.Image = Controle_Parametro.get().Logo;

            txtImage.Visible = false;
            btImage.Visible = false;
        }

        private void lbSite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(lbSite.Text);
        }

        private void btConfig_Click(object sender, EventArgs e)
        {
            lbNome.Visible = false;
            txtNome.Visible = true;
            txtNome.Text = lbNome.Text;
            txtNome.BringToFront();
            
            lbRazao.Visible = false;
            txtRazao.Visible = true;
            txtRazao.Text = lbRazao.Text;
            txtRazao.BringToFront();

            lbCNPJ.Visible = false;
            txtCnpj.Visible = true;
            txtCnpj.Text = lbCNPJ.Text;
            txtCnpj.BringToFront();
            
            lbData.Visible = false;
            dtpDate.Visible = true;
            dtpDate.Value = this.data;
            dtpDate.BringToFront();
            
            lbEndereco.Visible = false;
            txtEnd.Visible = true;
            txtEnd.Text = lbEndereco.Text;
            txtEnd.BringToFront();
            
            lbEmail.Visible = false;
            txtEmail.Visible = true;
            txtEmail.Text = lbEmail.Text;
            txtEmail.BringToFront();
            
            lbTelefone.Visible = false;
            txtTel.Visible = true;
            txtTel.Text = lbTelefone.Text;
            txtTel.BringToFront();
            
            lbAtividade.Visible = false;
            txtEcon.Visible = true;
            txtEcon.Text = lbAtividade.Text;
            txtEcon.BringToFront();
            
            lbSite.Visible = false;
            txtSite.Visible = true;
            txtSite.Text = lbSite.Text;
            txtSite.BringToFront();
            
            btConfig.Enabled = false;
            btOk.Visible = true;
            btCancelar.Visible = true;

            txtImage.Visible = true;
            btImage.Visible = true;

            ordNome.Visible = true;
            ordRazao.Visible = true;
            ordLogo.Visible = true;
            ordCNPJ.Visible = true;
            ordData.Visible = true;
            ordEndereco.Visible = true;
            ordEmail.Visible = true;
            ordTelefone.Visible = true;
            ordAtividade.Visible = true;
            ordSite.Visible = true;
            ordOrder.Visible = true;
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            if (txtNome.Text != "")
            {
                if (API.Validate.CNPJ(txtCnpj.Text))
                {
                    if (!Controle_Parametro.update(txtNome.Text, txtRazao.Text, txtCnpj.Text, dtpDate.Value, txtEnd.Text, txtEmail.Text, txtSite.Text, txtEcon.Text, "Ativo", txtTel.Text, picBox.Image))
                        MessageBox.Show("Não foi possível efetuar modificação nos parâmetros", "Erro ao atualizar informações", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    init();
                    btConfig.Enabled = true;
                    btOk.Visible = false;
                    btCancelar.Visible = false;

                    ordNome.Visible = false;
                    ordRazao.Visible = false;
                    ordLogo.Visible = false;
                    ordCNPJ.Visible = false;
                    ordData.Visible = false;
                    ordEndereco.Visible = false;
                    ordEmail.Visible = false;
                    ordTelefone.Visible = false;
                    ordAtividade.Visible = false;
                    ordSite.Visible = false;
                    ordOrder.Visible = false;
                }
                else
                    MessageBox.Show("CNPJ Inválido", "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Nome Inválido", "Eroo de validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            this.menu.LoadLogo();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            init();
            btConfig.Enabled = true;
            btOk.Visible = false;
            btCancelar.Visible = false;
            ///////////////////////////////////////
            ordNome.Visible = false;
            ordRazao.Visible = false;
            ordLogo.Visible = false;
            ordCNPJ.Visible = false;
            ordData.Visible = false;
            ordEndereco.Visible = false;
            ordEmail.Visible = false;
            ordTelefone.Visible = false;
            ordAtividade.Visible = false;
            ordSite.Visible = false;
            ordOrder.Visible = false;
        }

        private void btImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.FileName = "";
            open.Title = "Abrir Imagem (200 x 100)";
            open.Filter = "Arquivos de Imagem (*.jpg;*.bmp;*.png)|*.jpg;*.bmp;*.png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Image img = Image.FromFile(open.FileName);
                    if(img.Width <= 200 && img.Height <= 100)
                    {
                        picBox.Image = img;
                        picBox.SizeMode = PictureBoxSizeMode.AutoSize;
                    }
                    else
                    {
                        MessageBox.Show("Imagem muito grande para ser carregada!", "Erro ao carregar imagem!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro ao carregar imagem!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            btImage.Location = new Point(btImage.Location.X, picBox.Location.Y + picBox.Size.Height + 6);
            txtImage.Location = new Point(txtImage.Location.X, picBox.Location.Y + picBox.Size.Height + 7);
            string[] dir = open.FileName.Split('\\');
            txtImage.Text = dir[dir.Length-1];
        }
    }
}