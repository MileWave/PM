using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using MonitorPlatForm.Views;
namespace MonitorPlatForm
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
            Form monitorView = new Form1();

            monitorView.StartPosition = FormStartPosition.CenterScreen;

            Application.Run(monitorView);
            //Application.Run(new Form1());
        }
    }
}
