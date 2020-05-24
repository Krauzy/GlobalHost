using GlobalHost.Controlador;
using GlobalHost.Visao.Servicos.Funcoes.Pedido;
using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GlobalHost
{
    static class Program
    {
        public static string Global_User;
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Global_User = "";
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Visao.Screen_Login());
            //Application.Run(new Visao.Menu());
            Application.Run(new Screen_Carga(Screen_Carga.INSERT));
        }
    }
}
