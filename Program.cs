using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace ToolBox_Widget
{
    static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string processname = Process.GetCurrentProcess().ProcessName;
            Process[] processesByName = Process.GetProcessesByName(processname);

            if (processesByName.Length > 1)
            {
                MessageBox.Show("Program sadece bir defa çalışabilir.");
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
