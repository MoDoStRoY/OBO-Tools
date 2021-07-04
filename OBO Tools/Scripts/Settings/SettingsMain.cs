using OBO_Tools.Objects.SettingsObject;
using System.Collections.Generic;

namespace OBO_Tools.Scripts.Settings
{
    class SettingsMain
    {
        public static List<Translit> initializeListForTranslit()
        {
            List<Translit> result = new List<Translit>()
            {
                new Translit('а', "a"),//
                new Translit('б', "b"),//
                new Translit('в', "v"),//
                new Translit('г', "g"),//
                new Translit('д', "d"),//
                new Translit('е', "e"),//
                new Translit('ё', "e"),//
                new Translit('ж', "zh"),//
                new Translit('з', "z"),//
                new Translit('и', "i"),//
                new Translit('й', ""),//
                new Translit('к', "k"),//
                new Translit('л', "l"),//
                new Translit('м', "m"),//
                new Translit('н', "n"),//
                new Translit('о', "o"),//
                new Translit('п', "p"),//
                new Translit('р', "r"),//
                new Translit('с', "s"),//
                new Translit('т', "t"),//
                new Translit('у', "u"),//
                new Translit('ф', "f"),//
                new Translit('х', "h"),//
                new Translit('ц', "ts"),//
                new Translit('ч', "ch"),//
                new Translit('ш', "sh"),//
                new Translit('щ', "sh"),//
                new Translit('ъ', ""),//
                new Translit('ы', "i"),//??
                new Translit('ь', ""),//
                new Translit('э', "e"),//
                new Translit('ю', "yu"),//
                new Translit('я', "ya"),//
                new Translit(' ', "_")
            };

            return result;
        }
    }
}
