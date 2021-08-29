using OBO_Tools.Objects;
using OBO_Tools.Objects.PaymentCorrection;
using System;
using System.Collections.Generic;
using System.Text;

namespace OBO_Tools.Windows.PaymentCorrectionWindow.HistoryWindow.PaymentWindow
{
    class PaymentWindowLogic
    {
        static User user = Program.user;
        static PaymentWindow window = Program.user.paymentWindow;
        static Payment payment;

        public static void ShowWindow(Payment paymentIN)
        {
            window.Show();
            payment = paymentIN;
            LoadData();
        }

        public static void ClosedForm()
        {
            
        }

        public static void BackBtn()
        {
            window.Hide();
            user.historyWindow.ShowWindow();
        }

        public static void LoadData()
        {
            window.TTNumber.Text = payment.TTNumber;
            window.contact.Text = payment.contact;
            window.BCVariantCLB.ClearSelected(); // Необходимо доделать!
            window.correctNumber.Text = payment.correctNumber;
            window.incorrectNumber.Text = payment.incorrectNumber;
            window.paymentSum.Text = payment.paymentSum.ToString();
            window.paymentDate.Text = payment.paymentDate;
            window.fullCorrectionCB.Checked = payment.fullCorrection;
            window.reparationCB.Checked = payment.reparation;
            window.decision.Text = payment.decision;
            window.cashComment.Text = payment.kassaComment;
            window.invoiceComment.Text = payment.reparationComment;
            window.incorrectTicket.Checked = payment.incorrectTicket;
            window.sourceTicket.ClearSelected(); // Необходимо доделать!
            window.correctionSum.Text = payment.correctionSum.ToString();
            window.refusedCorrectionCB.Checked = payment.correctionRefuse;
        }
    }
}
