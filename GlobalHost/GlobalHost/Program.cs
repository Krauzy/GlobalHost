using System;
using System.Windows.Forms;

namespace GlobalHost
{
    static class Program
    {
        public static string Global_User;
        public static int FUNC;
        public static bool admin;
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Program.Global_User = "Admin";
            //Program.FUNC = 12;
            //Program.admin = true;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Visao.Menu());
            Application.Run(new Visao.Screen_Login());
            //API.Boleto.Create(123.56);
        }
    }
}
