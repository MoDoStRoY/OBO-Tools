using System;
using System.Collections.Generic;
using System.Text;

namespace OBO_Tools.Scripts.PaymentCorrection
{
    class NormalizeStrings
    {
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

        public static string Contact(string inputString)
        {
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
            }

            return new string(buffer);
        }
    }
}
