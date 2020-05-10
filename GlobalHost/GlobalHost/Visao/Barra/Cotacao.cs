using System;
using System.Drawing;
using System.Windows.Forms;
using GlobalHost.API;

namespace GlobalHost.Visao
{
    public partial class Cotacao : UserControl
    {
        public Cotacao()
        {
            InitializeComponent();
        }

        private void Cotacao_Load(object sender, EventArgs e)
        {
            double moeda = Quot.getDolar();
            if (moeda < 5)
                lbDolarResult.ForeColor = Color.Green;
            else
                lbDolarResult.ForeColor = Color.Red;
            lbDolarResult.Text = "USD $" + moeda.ToString();

            moeda = Quot.getEuro();
            if (moeda < 6)
                lbEuroResult.ForeColor = Color.Green;
            else
                lbEuroResult.ForeColor = Color.Red;
            lbEuroResult.Text = "€" + moeda.ToString();

            moeda = Quot.getLibra();
            if (moeda < 6)
                lbLibraResult.ForeColor = Color.Green;
            else
                lbLibraResult.ForeColor = Color.Red;
            lbLibraResult.Text = "£" + moeda.ToString();

            moeda = Quot.getIene();
            if (moeda < 0.042)
                lbIeneResult.ForeColor = Color.Green;
            else
                lbIeneResult.ForeColor = Color.Red;
            lbIeneResult.Text = "¥" + moeda.ToString();

            moeda = Quot.getDolarCanadense();
            if (moeda < 4)
                lbDolarCanResult.ForeColor = Color.Green;
            else
                lbDolarCanResult.ForeColor = Color.Red;
            lbDolarCanResult.Text = "CAD $" + moeda.ToString();
        }
     
        private void bcbLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.bcb.gov.br/");
        }

        
    }
}
