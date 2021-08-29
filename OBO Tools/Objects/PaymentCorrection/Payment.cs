using System;
using System.Collections.Generic;
using System.Text;

namespace OBO_Tools.Objects.PaymentCorrection
{
    public class Payment
    {
        public string TTNumber;
        public string contact;
        public string BCVariant;
        public string incorrectNumber;
        public string correctNumber;
        public double paymentSum;
        public string paymentDate;

        public bool fullCorrection;
        public bool reparation;
        public double correctionSum;
        public string sourceTicket;
        public bool incorrectTicket;
        public bool correctionRefuse;

        public string decision;
        public string kassaComment;
        public string reparationComment;

        public Payment(string TTNumber, string contact, string BCVariant, string incorrectNumber, string correctNumber,
            double paymentSum, string paymentDate, bool fullCorrection, bool reparation, double correctionSum, string sourceTicket,
            bool incorrectTicket, bool correctionRefuse, string decision, string kassaComment, string reparationComment)
        {
            this.TTNumber = TTNumber;
            this.contact = contact;
            this.BCVariant = BCVariant;
            this.incorrectNumber = incorrectNumber;
            this.correctNumber = correctNumber;
            this.paymentSum = paymentSum;
            this.paymentDate = paymentDate;
            this.fullCorrection = fullCorrection;
            this.reparation = reparation;
            this.correctionSum = correctionSum;
            this.sourceTicket = sourceTicket;
            this.incorrectTicket = incorrectTicket;
            this.correctionRefuse = correctionRefuse;
            this.decision = decision;
            this.kassaComment = kassaComment;
            this.reparationComment = reparationComment;
        }
    }
}
