using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_2
{
    public class Transliter
    {
        private int languge = 0; // 0 - rus to latin, 1- latin to rus
        Dictionary<string, string> translitTableRusToLatin = new Dictionary<string, string>()
        {
            {"а", "a"},
            {"б", "b"},
            {"в", "v"},
            {"г", "g"},
            {"д", "d"},
            {"е", "e"},
            {"ё", "yo"},
            {"ж", "zh"},
            {"з", "z"},
            {"и", "i"},
            {"й","y"},
            {"к", "k"},
            {"л", "l"},
            {"м", "m"},
            {"н", "n"},
            {"о", "o"},
            {"п", "p"},
            {"р", "r"},
            {"с", "s"},
            {"т", "t"},
            {"у", "u"},
            {"ф", "f"},
            {"х", "kh"},
            {"ц", "ts"},
            {"ч", "ch"},
            {"ш", "sh"},
            {"щ", "sch"},
            {"ъ", ""},
            {"ы", "y"},
            {"ь", ""},
            {"э", "e"},
            {"ю", "yu"},
            {"я", "ya"},
        };

        Dictionary<string, string> translitTableLatinToRus = new Dictionary<string, string>()
        {
            {"a", "а"},
            {"b", "б"},
            {"d", "д"},
            {"e", "e"},
            {"f", "ф"},
            {"g", "г"},
            {"i", "и"},
            {"k", "к"},
            {"l", "л"},
            {"m", "м"},
            {"n", "н"},
            {"o", "о"},
            {"p", "п"},
            {"r", "р"},
            {"s", "с"},
            {"t", "т"},
            {"u", "у"},
            {"v", "в"},
            {"y", "ы"},
            {"z", "з"},
            {"yo", "ё"},
            {"zh", "ж"},
            {"kh", "х"},
            {"ts", "ц"},
            {"ch", "ч"},
            {"sh", "ш"},
            {"sch", "щ"},
            {"yu", "ю"},
            {"ya", "я"},
        };




        public int CheckLanguage(string str)
        {
            if (str[0] >= 'а') languge = 0;
            else languge = 1;
            return languge;
        }
        public string Translate (string str)
        {
            if (CheckLanguage(str) == 0) return TranslitRusToLatin(str);
            else return TranslitLatinToRus(str);
        }

        public string TranslitRusToLatin(string str)
        {
            var result = "";
            // проход по строке для поиска символов подлежащих замене которые находятся в словаре dictionaryChar
            foreach (var ch in str)
            {
                var ss = "";
                // берём каждый символ строки и проверяем его на нахождение его в словаре для замены,
                // если в словаре есть ключ с таким значением то получаем true 
                // и добавляем значение из словаря соответствующее ключу
                if (translitTableRusToLatin.TryGetValue(ch.ToString(), out ss))
                {
                    result += ss;
                }
                // иначе добавляем тот же символ
                else result += ch;
            }
            return result;
        }

        public string TranslitLatinToRus(string str)
        {
            var result = "";
            // проход по строке для поиска символов подлежащих замене которые находятся в словаре dictionaryChar
            foreach (var ch in str)
            {
                var ss = "";
                // берём каждый символ строки и проверяем его на нахождение его в словаре для замены,
                // если в словаре есть ключ с таким значением то получаем true 
                // и добавляем значение из словаря соответствующее ключу
                if (translitTableLatinToRus.TryGetValue(ch.ToString(), out ss))
                {
                    result += ss;
                }
                // иначе добавляем тот же символ
                else result += ch;
            }
            return result;
        }
    }
}
