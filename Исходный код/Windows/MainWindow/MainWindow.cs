using OBO_Tools.Scripts;
using OBO_Tools.Scripts.DealerRequest;
using OBO_Tools.Scripts.Settings;
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
        private void initializeForm(object sender, EventArgs e)
        {
            fxVersion.Text = "OBO Tools v." + Program.version;
            Program.user.listOfChar = SettingsMain.initializeListForTranslit();
        }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void settingsBtn(object sender, EventArgs e)
        {
            Program.user.settingsWindow.Show();
        }

        private void aboutBtn(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages["tabPage1"];
        }

        //**//

        //**КНОПКИ ПЕРЕКЛЮЧЕНИЯ ИНТЕРФЕЙСОВ**//

        private void dealerRequestBtn(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages["tabPage2"];
        }

        //**//

        //**ИНТЕРФЕЙС DEALER REQUEST**//
        private void loadContactsBtn(object sender, EventArgs e)
        {
            DealerRequestController.loadContactsBtn();
        }

        private void loadCheckListBtn(object sender, EventArgs e)
        {
            DealerRequestController.loadCheckListBtn();
        }

        private void getRequestBtn(object sender, EventArgs e)
        {
            DealerRequestController.getRequestBtn();
        }

        private void needAnswerBtn(object sender, EventArgs e)
        {
            DealerRequestController.needAnswerBtn();
        }

        private void changeCodeOfPointBtn(object sender, EventArgs e)
        {
            DealerRequestController.changeCodeOfPointBtn();
        }

        private void copyRtfTextBtn(object sender, EventArgs e)
        {
            DealerRequestController.copyRtfTextBtn();
        }

        //**//
    }
}
