using System;
using System.Runtime.InteropServices;

namespace GlobalHost.API
{
    class Animation
    {
        public const int HORIZONTAL_POSITIVO = 0X1;
        public const int HORIZONTAL_NEGATIVO = 0X2;
        public const int VERTICAL_POSITIVO = 0X4;
        public const int VERTICAL_NEGATIVO = 0X8;
        public const int CENTRO = 0X10;
        public const int BLEND = 0X80000;

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int AnimateWindow(IntPtr ponteiro, int tempo, int flag);
        // WinAPI.AnimateWindow(this.Handle, 500, Animation.BLEND);
    }
}
