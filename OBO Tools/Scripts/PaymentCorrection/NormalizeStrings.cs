using OBO_Tools.Windows.PaymentCorrectionWindow;
using System;
using System.Collections.Generic;
using System.Text;

namespace OBO_Tools.Scripts.PaymentCorrection
{
    class NormalizeStrings
    {
        static PaymentCorrectionWindow window = Program.user.paymentCorrectionWindow;

        public static string TTNumber(string inputString)
        {
            char[] buffer = inputString.Trim().ToCharArray();
            char[] TTbuffer = new char[buffer.Length+2];

            if (buffer.Length == 0)
                return "TTXXXXXXXX";

            for (int i = 2; i < TTbuffer.Length; i++)
            {
                TTbuffer[i] = buffer[i-2];
            }

            for (int i = 0; i < 2; i ++)
            {
                if (buffer[i].Equals('Т'))
                    buffer[i] = 'T';
                if (!buffer[i].Equals('T'))
                    TTbuffer[i] = 'T';
            }

            if (TTbuffer[0].Equals('T'))
                return new string(TTbuffer);
            else return new string(buffer);
        }

        public static string Number(string inputString)
        {
            if (String.IsNullOrEmpty(inputString))
                inputString = "7XXXXXXXXXX";

            inputString = FSNumber(inputString);

            char[] buffer = inputString.Trim().ToCharArray();
            char[] plusBuffer = new char[buffer.Length+1];

            for (int i = 1; i < plusBuffer.Length; i++)
            {
                plusBuffer[i] = buffer[i - 1];
            }

            switch (buffer[0])
            {
                case '8':
                    buffer[0] = '7';
                    break;
                case '9':
                    plusBuffer[0] = '7';
                    return new string(plusBuffer);
                case '+':
                    buffer[0] = '7';
                    break;
            }

            return new string(buffer);
        }

        public static string BCVariant()
        {
            if (window.BCVariantCLB.CheckedItems.Count == 0)
            {
                window.BCVariantCLB.SetItemChecked(4, true);
            }

            return window.BCVariantCLB.CheckedItems[0].ToString();
        }

        public static string FSNumber(string inputString)
        {
            if (String.IsNullOrEmpty(inputString))
                inputString = "123456789";

            char[] buffer = inputString.Trim().ToCharArray();
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

        public static double Sum(string inputString)
        {
            if (String.IsNullOrEmpty(inputString))
                inputString = "0000000";

            if (inputString.Contains('.'))
                inputString = inputString.Replace('.', ',');

            char[] buffer = inputString.ToCharArray();
            string result = "";

            for (int i = 0; i < buffer.Length; i++)
            {
                if (buffer[i].Equals('0') || buffer[i].Equals('1') || buffer[i].Equals('2') || buffer[i].Equals('3')
                    || buffer[i].Equals('4') || buffer[i].Equals('5') || buffer[i].Equals('6') || buffer[i].Equals('7')
                    || buffer[i].Equals('8') || buffer[i].Equals('9') || buffer[i].Equals(','))
                {
                    result += buffer[i];
                }
            }

            return Convert.ToDouble(result);
        }

        public static string Date(string inputString)
        {
            if (String.IsNullOrEmpty(inputString))
                inputString = "XX.XX.XXXX";

            return inputString;
        }

        public static string SourceTicket()
        {
            if (window.sourceTicket.CheckedItems.Count == 0)
            {
                window.sourceTicket.SetItemChecked(0, true);
            }

            return window.sourceTicket.CheckedItems[0].ToString();
        }


    }
}
