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

        private void ClosedForm(object sender, FormClosedEventArgs e)
        {
            PaymentCorrectionLogic.ClosedForm();
        }

        private void BackBtn(object sender, EventArgs e)
        {
            PaymentCorrectionLogic.BackBtn();
        }

        private void GetInfoBtn(object sender, EventArgs e)
        {
            PaymentCorrectionLogic.GetInfoBtn();
        }

        private void ClearAllBtn(object sender, EventArgs e)
        {
            PaymentCorrectionLogic.ClearAllBtn();
        }

        private void ClearAllWithoutDateBtn(object sender, EventArgs e)
        {
            PaymentCorrectionLogic.ClearAllWithoutDateBtn();
        }

        private void CopyDecisionBtn(object sender, EventArgs e)
        {
            PaymentCorrectionLogic.CopyDecisionBtn();
        }

        private void CopyCashCommentBtn(object sender, EventArgs e)
        {
            PaymentCorrectionLogic.CopyCashCommentBtn();
        }

        private void CopyInvoiceCommentBtn(object sender, EventArgs e)
        {
            PaymentCorrectionLogic.CopyInvoiceCommentBtn();
        }
    }
}
