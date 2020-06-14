using System;
using System.Windows.Forms;

namespace GlobalHost
{
    static class Program
    {
        public static string Global_User;
        public static int FUNC;
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Program.Global_User = "Admin";
            Program.FUNC = 12;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Visao.Screen_Login());
            Application.Run(new Visao.Menu());
            //API.Boleto.Create(123.56);
        }
    }
}
