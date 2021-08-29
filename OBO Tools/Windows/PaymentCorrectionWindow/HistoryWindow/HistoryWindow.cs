using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OBO_Tools.Windows.PaymentCorrectionWindow.HistoryWindow
{
    public partial class HistoryWindow : Form
    {
        public HistoryWindow()
        {
            InitializeComponent();
        }

        public void ShowWindow()
        {
            HistoryWindowLogic.ShowWindow();
        }

        private void BackBtn(object sender, EventArgs e)
        {
            HistoryWindowLogic.BackBtn();
        }

        private void SearchBtn(object sender, EventArgs e)
        {
            HistoryWindowLogic.SearchBtn();
        }
    }
}
