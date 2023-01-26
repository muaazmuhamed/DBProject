using System;
using System.Windows.Forms;

namespace EmplyeeManagement
{
    internal static class ProgramBase
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new EmplyeeManagement());
            Application.Run(new EmplyeeManagement2());
        }
    }
}