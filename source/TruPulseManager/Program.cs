using System;
using System.Windows.Forms;

namespace TruPulseManager
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            AppContext.SetSwitch("System.Runtime.Serialization.Formatters.Binary.BinaryFormatter.IsSupported", true);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
