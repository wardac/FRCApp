using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace FRCApp
{
    class LoginTimeout
    {
        // http://joelabrahamsson.com/detecting-mouse-and-keyboard-input-with-net/
        [DllImport("User32.dll")]
        private static extern bool GetLastInputInfo(ref LASTINPUTINFO plii);

        [StructLayout(LayoutKind.Sequential)]
        internal struct LASTINPUTINFO
        {
            public uint cbSize;
            public uint dwTime;
        }

        public static DateTime LastInputTime()
        {
            DateTime lastInput = DateTime.Now;
            try
            {
                var lastInputInfo = new LASTINPUTINFO();
                lastInputInfo.cbSize = (uint)Marshal.SizeOf(lastInputInfo);

                GetLastInputInfo(ref lastInputInfo);

                lastInput = DateTime.Now.AddMilliseconds(
                    -(Environment.TickCount - (int)lastInputInfo.dwTime));
            }
            catch (Exception)
            {

            }
            return lastInput;
        }
    }
}
