using OBO_Tools.Scripts;
using OBO_Tools.Scripts.DealerRequest;
using OBO_Tools.Scripts.Settings;
using OBO_Tools.Windows.MainWindow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OBO_Tools
{

    public partial class MainWindow : Form
    {

        //**ОСНОВНЫЕ ЭЛЕМЕНТЫ И МЕТОДЫ ИНТЕРФЕЙСА**//
        private void InitializeForm(object sender, EventArgs e)
        {
            MainWindowLogic.InitializeForm();
        }

        public void ShowWindow()
        {
            MainWindowLogic.ShowWindow();
        }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void SettingsBtn(object sender, EventArgs e)
        {
            MainWindowLogic.SettingsBtn();
        }

        //**//

        //**КНОПКИ ПЕРЕКЛЮЧЕНИЯ ИНТЕРФЕЙСОВ**//

        private void DealerRequestBtn(object sender, EventArgs e)
        {
            MainWindowLogic.DealerRequestBtn();
        }

        private void PaymentCorrectionBtn(object sender, EventArgs e)
        {
            MainWindowLogic.PaymentCorrectionBtn();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //**//

    }
}
