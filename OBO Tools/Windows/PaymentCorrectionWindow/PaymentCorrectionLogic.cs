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
            }
            else
            {
                decision += "Способ ОС: " + window.BCVariantCLB.CheckedItems[0].ToString() + " на номер " + window.contact.Text + "\n\n";
            }

            decision += GetAnswer();
            window.decision.Text = decision;
        }

        private static string GetAnswer()
        {
            string answer = "Здравствуйте, меня зовут Фаррухчон, я занимался рассмотрением Вашей заявки " + window.TTNumber.Text + ".";

            if (window.fullCorrectionCB.Checked)
            {
                answer += "Я сделал всё красиво и скорректировал платёж на сумму " + window.paymentSum.Text + "на номер " + 
                    window.correctNumber.Text + ". Благодарю за обращение!";
            }
            else
            {
                if (window.reparationCB.Checked)
                {
                    answer += "Я сделал всё красиво, но абонент, получивший Ваш платёж скрысил часть денег. Скорректировано " +
                        window.correctionSum.Text + ". Но мы беспезды ценим Вас, поэтому компенсировали " + (Convert.ToInt32(window.paymentSum.Text) - 
                        Convert.ToInt32(window.correctionSum.Text)) + ". Итого на номер " + window.correctNumber.Text +
                        "перенесено " + window.paymentSum.Text + ". Благодарю за обращение!";
                }
                else
                {
                    answer += "Я сделал всё красиво, но абонент, получивший Ваш платёж скрысил часть денег. Скорректировано " +
                        window.correctionSum.Text + ". Итого на номер " + window.correctNumber.Text +
                        "перенесено " + window.correctionSum.Text + ". Надеюсь на Ваше понимание и благодарю за обращение!";
                }
            }

            return answer;
        }

        private static void GetKassaComment()
        {
            string comment = "Корректировка платежа на сумму " + window.paymentSum.Text + " руб. от " + window.paymentDate.Text + 
                " с Л/С " + window.incorrectFS.Text + " на Л/С " + window.correctFS.Text + ". Всего скорректировано " +
                window.correctionSum.Text + " руб. " + window.TTNumber.Text;

            window.cashComment.Text = comment;
        }

        private static void GetInvoiceComment()
        {
            string comment = "OBO Tech. " + window.TTNumber.Text + " " + (Convert.ToInt32(window.paymentSum.Text) -
                Convert.ToInt32(window.correctionSum.Text));

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
