using System;
using System.Collections.Generic;
using System.Text;

namespace OBO_Tools.Scripts.Settings
{
    class STGofDealerRequest
    {
        public static String translitRow(String rowOnRus)
        {
            String result = "";
            String[] buffer;
            char[] rowOnRusMas = rowOnRus.ToLower().ToCharArray();

            for (int i = 0; i < rowOnRusMas.Length; i++)
            {
                for(int i1 = 0; i1 < Program.user.listOfChar.Count; i1++)
                {
                    if (rowOnRusMas[i] == Program.user.listOfChar[i1].rusChar)
                        result = result + Program.user.listOfChar[i1].engChar;
                }    
            }

            buffer = result.Split("_");
            result = buffer[1] + "_" + buffer[0] + "@tele2.ru";

            return result;
        }
    }
}
