﻿using GlobalHost.Controlador;
using System;
using System.Drawing;
using System.Text;
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
            Application.Run(new Visao.Screen_Login());

        }
    }
}
