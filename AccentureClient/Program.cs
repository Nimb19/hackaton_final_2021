using System;
using System.Windows.Forms;

namespace AccentureClient
{
    static class Program
    {
        /// <summary> Главная точка входа для приложения </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new EntryForm());
        }
    }
}
