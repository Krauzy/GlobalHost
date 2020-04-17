using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using GlobalHost.API;
using Tulpep.NotificationWindow;

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
            Application.Run();
            /*
            PDF.Create("200000367421", 1, new DateTime(2020, 2, 14, 9, 12, 0), "CGF2020021400057", 
                "Expressa", "07432182953", "Desembaraçada", "CGF202000011844", new DateTime(2020, 2, 14, 9, 12, 0),
                "07432182953", "0817600 - GRU - AEROPORTO INTERNACIONAL DE SÃO PAULO - SP", 
                "CGF TRANSPORTES INTERNACIONAIS LTDA", "documentos", 5.00, 18, "Não", Dolar.getDolar(), "-", "-", "-", "-",
                "Prepaid", "-", "-", "-", "Não");
            */
        }
    }
}
