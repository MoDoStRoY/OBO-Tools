using OBO_Tools.Objects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

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

        public static void ClosedForm()
        {
            Application.Exit();
        }

        public static void BackBtn()
        {
            window.Hide();
            user.mainWindow.ShowWindow();
        }

        public static void GetInfoBtn()
        {
            GetDecision();
            GetKassaComment();
            GetInvoiceComment();
        }

        private static void GetDecision()
        {
            string decision = "OBO Tech: ";

            if (window.fullCorrectionCB.Checked)
            {
                decision += "Платёж скорректирован в полном объёме - " + window.paymentSum.Text + 
                    " руб. \n\n===============================\n\n";
            }
            else
            {
                decision += "Платёж скорректирован частично - " + window.correctionSum.Text + 
                    " руб. \n\n===============================\n\n";
            }

            if (window.incorrectTicket.Checked)
            {
                decision += "Решение на первой линии:\n";

                if (window.sourceTicket.GetItemChecked(0))
                {
                    decision += "https://kms.tele2.ru/kms/CM/SCENARIO/VIEW?item_id=22955";
                }
                else
                {
                    decision += "https://kms.tele2.ru/kms/CM/SCENARIO/VIEW?item_id=1175897";
                }

                decision += "\n\nПричинаОшибки\n\n";
            }

            if (window.BCVariantCLB.CheckedItems[0].ToString().Equals("Звонок"))
            {
                decision += "Информация предоставлена.\n\n" + "Способ ОС: звонком на номер " + window.contact.Text;

                if (window.reparationCB.Checked)
                {
                    decision += "\nКомпенсация: " + (Convert.ToDouble(window.paymentSum.Text) - Convert.ToDouble(window.correctionSum.Text)) +
                        " руб. на номер " + window.correctNumber.Text;
                }
            }
            else
            {
                decision += "Способ ОС: " + window.BCVariantCLB.CheckedItems[0].ToString() + " на номер " + window.contact.Text;

                if (window.reparationCB.Checked)
                {
                    decision += "\nКомпенсация: " + (Convert.ToDouble(window.paymentSum.Text) - Convert.ToDouble(window.correctionSum.Text)) +
                        " руб. на номер " + window.correctNumber.Text + "\n\n";
                }
                else
                {
                    decision += "\n\n";
                }
            }

            decision += GetAnswer();
            window.decision.Text = decision;
        }

        private static string GetAnswer()
        {
            string answer = "Здравствуйте, меня зовут София, я занималась рассмотрением Вашей заявки " + window.TTNumber.Text + ". ";

            if (window.fullCorrectionCB.Checked)
            {
                answer += "Сообщаю, что на номер +" + window.correctNumber.Text + " перенесён ошибочный платёж на сумму " 
                    + window.paymentSum.Text + " руб. " + "Благодарю за обращение!";
            }
            else
            {
                if (window.reparationCB.Checked)
                {
                    answer += "Сообщаю, что платеж поступил на ошибочный номер, и абонент израсходовал часть средств. " +
                        "На номер +" + window.correctNumber.Text + " перенесен остаток денежных средств в сумме " +
                        window.correctionSum.Text + " руб. с ошибочного номера. Мы ценим Вас, поэтому дополнительно компенсировали " + 
                        (Convert.ToDouble(window.paymentSum.Text) - Convert.ToDouble(window.correctionSum.Text)) + 
                        " руб. В итоге, на Ваш номер возвращено " + window.paymentSum.Text + " руб. Благодарю за обращение!";
                }
                else
                {
                    answer += "Сообщаю, что платеж поступил на ошибочный номер, и абонент израсходовал часть средств. " +
                        "На номер +" + window.correctNumber.Text + " перенесен остаток денежных средств в сумме " +
                        window.correctionSum.Text + " руб. с ошибочного номера. " + "Надеюсь на Ваше понимание и благодарю за обращение!";
                }
            }

            return answer;
        }

        private static void GetKassaComment()
        {
            string comment = "Корректировка платежа на сумму " + window.paymentSum.Text + " руб. от " + window.paymentDate.Text +
                " с Л/С " + CorrectionFSNumber(window.incorrectFS.Text) + " на Л/С " + CorrectionFSNumber(window.correctFS.Text) + ". Всего скорректировано ";

            if (window.fullCorrectionCB.Checked)
            {
                comment += window.paymentSum.Text + " руб. " + window.TTNumber.Text;
            }
            else
            {
                comment += window.correctionSum.Text + " руб. " + window.TTNumber.Text;
            }

            window.cashComment.Text = comment;
        }

        private static string CorrectionFSNumber(string FSNumber)
        {
            char[] buffer = FSNumber.ToCharArray();
            string result = "";

            for (int i = 0; i < buffer.Length; i++)
            {
                if (buffer[i].Equals('0') || buffer[i].Equals('1') || buffer[i].Equals('2') || buffer[i].Equals('3')
                    || buffer[i].Equals('4') || buffer[i].Equals('5') || buffer[i].Equals('6') || buffer[i].Equals('7')
                    || buffer[i].Equals('8') || buffer[i].Equals('9'))
                {
                    result += buffer[i];
                }
            }

            return result;
        }

        private static void GetInvoiceComment()
        {
            try { Convert.ToDouble(window.correctionSum.Text); }
            catch { window.correctionSum.Text = "0"; }

            string comment = "OBO Tech. " + window.TTNumber.Text + " " + (Convert.ToDouble(window.paymentSum.Text) -
                Convert.ToDouble(window.correctionSum.Text));

            window.invoiceComment.Text = comment;
        }

        public static void ClearAllBtn()
        {
            window.TTNumber.Text = "";
            window.contact.Text = "";
            window.BCVariantCLB.ClearSelected();
            window.correctNumber.Text = "";
            window.correctFS.Text = "";
            window.incorrectFS.Text = "";
            window.paymentSum.Text = "";
            window.paymentDate.Text = "";
            window.fullCorrectionCB.Checked = false;
            window.reparationCB.Checked = false;
            window.decision.Text = "";
            window.cashComment.Text = "";
            window.invoiceComment.Text = "";
            window.incorrectTicket.Checked = false;
            window.sourceTicket.ClearSelected();
        }

        public static void ClearAllWithoutDateBtn()
        {
            string date = window.paymentDate.Text;

            ClearAllBtn();

            window.paymentDate.Text = date;
        }

        public static void CopyDecisionBtn()
        {
            Clipboard.SetData(DataFormats.Text, (Object)window.decision.Text);
        }

        public static void CopyCashCommentBtn()
        {
            Clipboard.SetData(DataFormats.Text, (Object)window.cashComment.Text);
        }

        public static void CopyInvoiceCommentBtn()
        {
            Clipboard.SetData(DataFormats.Text, (Object)window.invoiceComment.Text);
        }
    }
}
