using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OBO_Tools.Windows.PaymentCorrectionWindow
{
    public partial class PaymentCorrectionWindow : Form
    {
        public PaymentCorrectionWindow()
        {
            InitializeComponent();
        }

        public void ShowWindow()
        {
            PaymentCorrectionLogic.ShowWindow();
        }

        private void GetInfoBtn(object sender, EventArgs e)
        {
            PaymentCorrectionLogic.GetInfoBtn();
        }
    }
}
