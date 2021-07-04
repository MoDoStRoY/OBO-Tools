using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OBO_Tools.Windows.SettingsWindow
{
    public partial class SettingsWindow : Form
    {

        private void initializeForm(object sender, EventArgs e)
        {

        }

        public SettingsWindow()
        {
            InitializeComponent();
        }

        private void closedForm(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        private void dealerRequestBtn(object sender, EventArgs e)
        {
            fxTabControl.SelectedTab = fxTabControl.TabPages["tabPage1"];
        }

        private void imRequestBtn(object sender, EventArgs e)
        {
            fxTabControl.SelectedTab = fxTabControl.TabPages["tabPage2"];
        }

        //**РАЗДЕЛ НАСТРОЕК DEALER REQUEST**//

        private void transformFIOToEmailBtn(object sender, EventArgs e)
        {
            if (Program.user.transformFIOToEmailSTG)
                Program.user.transformFIOToEmailSTG = false;
            else Program.user.transformFIOToEmailSTG = true;
        }

        //**//
    }
}
