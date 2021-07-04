using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OBO_Tools.Windows.ErrorWindow
{
    public partial class ErrorWindow : Form
    {
        private void initializeForm(object sender, EventArgs e)
        {
            fxErrorText.Text = Program.user.textError;
        }

        public void ShowWindow()
        {
            this.Show();
            fxErrorText.Text = Program.user.textError;
        }

        public ErrorWindow()
        {
            InitializeComponent();
        }

        private void okBtn(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
