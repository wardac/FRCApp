using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FRCApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            System.Timers.Timer timer = new System.Timers.Timer(1000);
            timer.Elapsed += ((o, e) => { if (LoginTimeout.LastInputTime() < DateTime.Now.AddMinutes(-30)) { Application.Exit(); } });
            loginForm login = new loginForm(timer);
            login.Show();
            Application.Run();
            
        }
    }
}
