using OBO_Tools.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OBO_Tools
{
    static class Program
    {
        public static User user = new User();
        public static String version = "0.1.6C build 0108212336";

        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(user.mainWindow);
        }
    }
}
