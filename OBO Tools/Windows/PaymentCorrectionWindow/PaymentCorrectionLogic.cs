using OBO_Tools.Objects;
using System;
using System.Collections.Generic;
using System.Text;

namespace OBO_Tools.Windows.PaymentCorrectionWindow
{
    class PaymentCorrectionLogic
    {
        static User user = Program.user;
        static PaymentCorrectionWindow window = user.paymentCorrectionWindow;

        public static void ShowWindow()
        {
            window.Show();
        }

        public static void GetInfoBtn()
        {
            GetDecision();
        }

        private static void GetDecision()
        {
            String decision = "OBO Tech: ";

            if (window.fullCorrectionCLB.GetItemChecked(0))
            {
                decision += "Платёж скорректирован в полном объёме - " + window.paymentSum.Text + " руб. \n\n ===============================";
            }
            else if (window.fullCorrectionCLB.GetItemChecked(1))
            {
                decision += "Платёж скорректирован частично - " + window.correctionSum.Text + " руб. \n\n ===============================";
            }

            window.decision.Text = decision;

        }
    }
}
