using System;

namespace OBO_Tools.Objects.SettingsObject
{
    class TranslitObject
    {
        public char rusChar;
        public String engChar;

        public TranslitObject(char rusChar, String engChar)
        {
            this.rusChar = rusChar;
            this.engChar = engChar;
        }
    }
}
