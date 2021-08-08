using OBO_Tools.Objects;
using OBO_Tools.Scripts.PaymentCorrection;
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

        static string TTNumber;
        static string contact;
        static string BCVariantCLB;
        static string correctNumber;
        static string correctFS;
        static string incorrectNumber;
        static double paymentSum;
        static string paymentDate;
        static double correctionSum;
        static string sourceTicket;

        public static void ShowWindow()
        {
            window.Show();
        }

        public static void ClosedForm()
        {
            user.settingsWindow.Dispose();
            Application.Exit();
        }

        public static void BackBtn()
        {
            window.Hide();
            user.mainWindow.ShowWindow();
        }

        public static void GetInfoBtn()
        {
            NormalizeAll();

            GetDecision();
            GetKassaComment();
            GetInvoiceComment();
        }

        public static void GetImportBtn()
        {
            string bufferedData = "";

            try { bufferedData = (string)Clipboard.GetDataObject().GetData(DataFormats.Text);}
            catch { }

            if (!string.IsNullOrEmpty((string)Clipboard.GetDataObject().GetData(DataFormats.Text)))
            {
                try
                {
                    string[] buffer = bufferedData.Split("\n");

                    window.TTNumber.Text = buffer[0];
                    window.contact.Text = buffer[1];
                    window.incorrectNumber.Text = buffer[2];
                    window.correctNumber.Text = buffer[3];
                    window.paymentSum.Text = buffer[4];
                    window.paymentDate.Text = buffer[5];
                }
                catch {}
            }

            GetInfoBtn();
        }

        private static void NormalizeAll()
        {
            TTNumber = NormalizeStrings.TTNumber(window.TTNumber.Text);
            contact = NormalizeStrings.Number(window.contact.Text);
            BCVariantCLB = NormalizeStrings.BCVariant();
            correctNumber = NormalizeStrings.Number(window.correctNumber.Text);
            incorrectNumber = NormalizeStrings.Number(window.incorrectNumber.Text);
            paymentSum = NormalizeStrings.Sum(window.paymentSum.Text);
            paymentDate = NormalizeStrings.Date(window.paymentDate.Text);
            correctionSum = NormalizeStrings.Sum(window.correctionSum.Text);
            sourceTicket = NormalizeStrings.SourceTicket();
        }

        private static void GetDecision()
        {
            string decision = "OBO Tech: ";

            if (window.refusedCorrectionCB.Checked)
            {
                decision += "В корректировке отказано - ХХХХХХХХХХХХХХ" + "\n\n" + "===============================\n\n";
            }
            else
            {
                if (window.fullCorrectionCB.Checked)
                {
                    decision += "Платёж скорректирован в полном объёме - " + paymentSum +
                        " руб. \n\n===============================\n\n";
                }
                else
                {
                    decision += "Платёж скорректирован частично - " + correctionSum +
                        " руб. \n\n===============================\n\n";
                }
            }

            if (window.incorrectTicket.Checked)
            {
                decision += "Решение на первой линии:\n";

                if (sourceTicket.Equals("CRM"))
                {
                    decision += "https://kms.tele2.ru/kms/CM/SCENARIO/VIEW?item_id=22955";
                }
                else
                {
                    decision += "https://kms.tele2.ru/kms/CM/SCENARIO/VIEW?item_id=1175897";
                }

                decision += "\n\nПричинаОшибки\n\n";
            }

            if (BCVariantCLB.Equals("Звонок"))
            {
                decision += "Информация предоставлена.\n\n" + "Способ ОС: звонком на номер " + contact;

                if (window.reparationCB.Checked)
                {
                    decision += "\nКомпенсация: " + (paymentSum - correctionSum) +
                        " руб. на номер " + correctNumber;
                }
            }
            else
            {
                decision += "Способ ОС: " + BCVariantCLB + " на номер " + contact;

                if (window.reparationCB.Checked)
                {
                    decision += "\nКомпенсация: " + (paymentSum - correctionSum) +
                        " руб. на номер " + correctNumber + "\n\n";
                }
                else
                {
                    decision += "\n\n";
                }

                decision += GetAnswer();
            }
            window.decision.Text = decision;
        }

        private static string GetAnswer()
        {
            string answer = "Здравствуйте, меня зовут София, я занималась рассмотрением Вашей заявки " + TTNumber + ". ";

            if (window.refusedCorrectionCB.Checked)
            {
                answer += "К сожалению, выполнить корректировку данного платежа на текущий момент невозможно, т.к. ХХХХХХХХХХХХХХ. " +
                    "Приносим извинения за доставленные неудобства. Надеюсь на Ваше понимание и благодарю за обращение!";
            }
            else
            {
                if (window.fullCorrectionCB.Checked)
                {
                    answer += "Сообщаю, что на номер +" + correctNumber + " перенесён ошибочный платёж на сумму "
                        + paymentSum + " руб. " + "Благодарю за обращение!";
                }
                else
                {
                    if (window.reparationCB.Checked)
                    {
                        answer += "Сообщаю, что платеж поступил на ошибочный номер, и абонент израсходовал часть средств. " +
                            "На номер +" + correctNumber + " перенесен остаток денежных средств в сумме " +
                            correctionSum + " руб. с ошибочного номера. Мы ценим Вас, поэтому дополнительно компенсировали " +
                            NormalizeStrings.Difference(paymentSum, correctionSum) +
                            " руб. В итоге, на Ваш номер возвращено " + paymentSum + " руб. Благодарю за обращение!";
                    }
                    else
                    {
                        answer += "Сообщаю, что платеж поступил на ошибочный номер, и абонент израсходовал часть средств. " +
                            "На номер +" + correctNumber + " перенесен остаток денежных средств в сумме " +
                            correctionSum + " руб. с ошибочного номера. " + "Надеюсь на Ваше понимание и благодарю за обращение!";
                    }
                }
            }

            return answer;
        }

        private static void GetKassaComment()
        {
            string comment = "Корректировка платежа на сумму " + paymentSum + " руб. от " + paymentDate +
                " с номера " + incorrectNumber + " на номер " + correctNumber + ". Всего скорректировано ";

            if (window.fullCorrectionCB.Checked)
            {
                comment += paymentSum + " руб. " + TTNumber;
            }
            else
            {
                comment += correctionSum + " руб. " + TTNumber;
            }

            window.cashComment.Text = comment;
        }

        private static void GetInvoiceComment()
        {
            string comment = "OBO Tech. " + TTNumber + " " + NormalizeStrings.Difference(paymentSum, correctionSum);

            window.invoiceComment.Text = comment;
        }

        public static void ClearAllBtn()
        {
            window.TTNumber.Text = "";
            window.contact.Text = "";
            window.BCVariantCLB.ClearSelected();
            window.correctNumber.Text = "";
            window.incorrectNumber.Text = "";
            window.paymentSum.Text = "";
            window.paymentDate.Text = "";
            window.fullCorrectionCB.Checked = false;
            window.reparationCB.Checked = false;
            window.decision.Text = "";
            window.cashComment.Text = "";
            window.invoiceComment.Text = "";
            window.incorrectTicket.Checked = false;
            window.sourceTicket.ClearSelected();
            window.correctionSum.Text = "";
            window.refusedCorrectionCB.Checked = false;
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

        public static void FullCorrectionCB()
        {
            if (window.fullCorrectionCB.Checked)
            {
                window.reparationCB.Checked = false;
                window.reparationCB.Enabled = false;
                window.correctionSum.Text = "";
                window.correctionSum.Enabled = false;
            }
            else
            {
                window.reparationCB.Enabled = true;
                window.correctionSum.Enabled = true;
            }
        }

        public static void ReparationCB()
        {
            if (window.reparationCB.Checked)
            {
                window.fullCorrectionCB.Checked = false;
                window.fullCorrectionCB.Enabled = false;
            }
            else
            {
                window.fullCorrectionCB.Enabled = true;
            }
        }

        public static void CopyAllBtn()
        {
            Clipboard.SetData(DataFormats.Text, (Object)window.cashComment.Text + "\n\n" + window.invoiceComment.Text 
                + "\n\n" + window.decision.Text);
        }

        public static void RefusedCorrectionCB()
        {
            if (window.refusedCorrectionCB.Checked)
            {
                window.correctNumber.Enabled = false;
                window.incorrectNumber.Enabled = false;
                window.paymentSum.Enabled = false;
                window.paymentDate.Enabled = false;
                window.fullCorrectionCB.Enabled = false;
                window.reparationCB.Enabled = false;
                window.correctionSum.Enabled = false;
                window.correctionSum.Text = "";
                window.reparationCB.Checked = false;
            }
            else
            {
                window.correctNumber.Enabled = true;
                window.incorrectNumber.Enabled = true;
                window.paymentSum.Enabled = true;
                window.paymentDate.Enabled = true;
                window.fullCorrectionCB.Enabled = true;
                window.reparationCB.Enabled = true;
                window.correctionSum.Enabled = true;
            }
        }
    }
}
