using Newtonsoft.Json;
using OBO_Tools.Objects;
using OBO_Tools.Objects.PaymentCorrection;
using OBO_Tools.Windows.PaymentCorrectionWindow;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace OBO_Tools.Scripts.PaymentCorrection
{
    class JSON
    {
        static User user = Program.user;

        public static void SerializePayment()
        {
            string TTNumber = PaymentCorrectionLogic.TTNumber;
            string contact = PaymentCorrectionLogic.contact;
            string BCVariant = PaymentCorrectionLogic.BCVariantCLB;
            string incorrectNumber = PaymentCorrectionLogic.incorrectNumber;
            string correctNumber = PaymentCorrectionLogic.correctNumber;
            double paymentSum = PaymentCorrectionLogic.paymentSum;
            string paymentDate = PaymentCorrectionLogic.paymentDate;
            bool fullCorrection = user.paymentCorrectionWindow.fullCorrectionCB.Checked;
            bool reparation = user.paymentCorrectionWindow.reparationCB.Checked;
            double correctionSum = PaymentCorrectionLogic.correctionSum;
            string sourceTicket = PaymentCorrectionLogic.sourceTicket;
            bool incorrectTicket = user.paymentCorrectionWindow.incorrectTicket.Checked;
            bool correctionRefuse = user.paymentCorrectionWindow.refusedCorrectionCB.Checked;
            string decision = user.paymentCorrectionWindow.decision.Text;
            string kassaComment = user.paymentCorrectionWindow.cashComment.Text;
            string reparationComment = user.paymentCorrectionWindow.invoiceComment.Text;
            
            Program.user.paymentList.Add(new Payment(TTNumber, contact, BCVariant, incorrectNumber, correctNumber,
            paymentSum, paymentDate, fullCorrection, reparation, correctionSum, sourceTicket,
            incorrectTicket, correctionRefuse, decision, kassaComment, reparationComment));

            File.WriteAllText(Path.GetFullPath("SavedData/HistoryCorrection.txt"), JsonConvert.SerializeObject(Program.user.paymentList));
        }

        public static List<Payment> DeserializePayment()
        {
            try { return JsonConvert.DeserializeObject<List<Payment>>(File.ReadAllText(Path.GetFullPath("SavedData/HistoryCorrection.txt"))); }
            catch { return new List<Payment>(); }
        }
    }
}
