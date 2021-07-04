using System;

namespace OBO_Tools.Objects.SettingsObject
{
    class Translit
    {
        public char rusChar;
        public String engChar;

        public Translit(char rusChar, String engChar)
        {
            this.rusChar = rusChar;
            this.engChar = engChar;
        }
    }
}
