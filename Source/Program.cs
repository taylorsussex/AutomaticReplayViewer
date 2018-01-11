using System;
using System.Windows.Forms;

namespace AutomaticReplayViewer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
		/// TODO
		/// Find a way to allow for updating pointers without having to release a new build
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}