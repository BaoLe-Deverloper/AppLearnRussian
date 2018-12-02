using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AppLearnRussian
{
    class WinAPI
    {
        public const int Hor_positive = 0X1;
        public const int Hor_Negative = 0x2;
        public const int Ver_positive = 0X4;
        public const int Ver_Negative = 0x8;
        public const int Center = 0x10;
        public const int Blend = 0x80000;

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int AnimateWindow(IntPtr Hwand, int dwtime, int dwFlag);
     

    }
}
