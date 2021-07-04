using OBO_Tools.Objects;
using OBO_Tools.Scripts.Settings;
using System;
using System.Collections.Generic;
using System.Text;

namespace OBO_Tools.Windows.MainWindow
{
    class MainWindowLogic
    {
        static User user = Program.user;

        //**ОСНОВНЫЕ ЭЛЕМЕНТЫ И МЕТОДЫ ИНТЕРФЕЙСА**//
        public static void InitializeForm()
        {
            user.mainWindow.fxVersion.Text = "OBO Tools v." + Program.version;
            Program.user.listOfChar = SettingsMain.initializeListForTranslit();
        }

        public static void ShowWindow()
        {
            user.mainWindow.Show();
        }

        public static void SettingsBtn()
        {
            Program.user.settingsWindow.Show();
        }

        //**//

        //**КНОПКИ ПЕРЕКЛЮЧЕНИЯ ИНТЕРФЕЙСОВ**//

        public static void DealerRequestBtn()
        {
            user.mainWindow.Hide();
            user.dealerRequestWindow.ShowWindow();
        }

        public static void PaymentCorrectionBtn()
        {
            user.mainWindow.Hide();
            user.paymentCorrectionWindow.ShowWindow();
        }

        //**//
    }
}
