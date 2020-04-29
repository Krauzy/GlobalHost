using GlobalHost.Controlador;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GlobalHost
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Visao.Menu());
            //OpenFileDialog open = new OpenFileDialog();
            //if (open.ShowDialog() == DialogResult.OK)
            //{
            //    Image img = Image.FromFile(open.FileName);
            //    Controle_Parametro.update("Cgf Global", "Cgf Transportes Internacionais Ltda", "04.180.453/0001-06", new DateTime(2000, 12, 1), "R Candido Vale, 188, Fundos186, Tatuape, Sao Paulo, SP, CEP 03068-010, Brasil", "cyamada@cgfglobal.com.br", "https://cgfglobal.com.br/", "Serviços de malote não realizados pelo Correio Nacional - CNAE 5320201", "Ativo", "(11) 2091-1444", img);
            //}
            
        }
    }
}
