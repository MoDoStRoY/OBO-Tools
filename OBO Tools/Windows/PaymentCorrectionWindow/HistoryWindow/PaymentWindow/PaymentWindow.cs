using OBO_Tools.Objects.PaymentCorrection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OBO_Tools.Windows.PaymentCorrectionWindow.HistoryWindow.PaymentWindow
{
    public partial class PaymentWindow : Form
    {
        public PaymentWindow()
        {
            InitializeComponent();
        }

        public void ShowWindow(Payment paymentIN)
        {
            PaymentWindowLogic.ShowWindow(paymentIN);
        }

        private void BackBtn(object sender, EventArgs e)
        {
            PaymentWindowLogic.BackBtn();
        }
    }
}
