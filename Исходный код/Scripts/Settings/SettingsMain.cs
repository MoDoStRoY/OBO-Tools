using OBO_Tools.Objects.SettingsObject;
using System.Collections.Generic;

namespace OBO_Tools.Scripts.Settings
{
    class SettingsMain
    {
        public static List<TranslitObject> initializeListForTranslit()
        {
            List<TranslitObject> result = new List<TranslitObject>()
            {
                new TranslitObject('а', "a"),//
                new TranslitObject('б', "b"),//
                new TranslitObject('в', "v"),//
                new TranslitObject('г', "g"),//
                new TranslitObject('д', "d"),//
                new TranslitObject('е', "e"),//
                new TranslitObject('ё', "e"),//
                new TranslitObject('ж', "zh"),//
                new TranslitObject('з', "z"),//
                new TranslitObject('и', "i"),//
                new TranslitObject('й', ""),//
                new TranslitObject('к', "k"),//
                new TranslitObject('л', "l"),//
                new TranslitObject('м', "m"),//
                new TranslitObject('н', "n"),//
                new TranslitObject('о', "o"),//
                new TranslitObject('п', "p"),//
                new TranslitObject('р', "r"),//
                new TranslitObject('с', "s"),//
                new TranslitObject('т', "t"),//
                new TranslitObject('у', "u"),//
                new TranslitObject('ф', "f"),//
                new TranslitObject('х', "h"),//
                new TranslitObject('ц', "ts"),//
                new TranslitObject('ч', "ch"),//
                new TranslitObject('ш', "sh"),//
                new TranslitObject('щ', "sh"),//
                new TranslitObject('ъ', ""),//
                new TranslitObject('ы', "i"),//??
                new TranslitObject('ь', ""),//
                new TranslitObject('э', "e"),//
                new TranslitObject('ю', "yu"),//
                new TranslitObject('я', "ya"),//
                new TranslitObject(' ', "_")
            };

            return result;
        }
    }
}
