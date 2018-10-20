using System;
using System.Collections.Generic;
using System.Text;

namespace DEV_2
{
    //class Transliter translate latin symbols to rus and rus symbols to latin
    public class Transliter
    {
        private int languge = 0; // 0 - rus to latin, 1- latin to rus

        //create dictionary for translate rus symbols to latin
        //use this srtucture becouse russian sounds single characters
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
            {"ъ", "hhh"},
            {"ы", "y"},
            {"ь", "jh"},
            {"э", "e"},
            {"ю", "yu"},
            {"я", "ya"},
        };

        //define the language
        //parameter str - is our string which we need to translate
        public int CheckLanguage(string str)
        {
            // 0 - rus to latin, 1- latin to rus
            if (str[0] >= 'а') languge = 0;
            else languge = 1;
            return languge;
        }

        //in this method we decide how to translate: 
        //from russian to latin or from latin to russian
        //parameter str - is our string which we need to translate
        public string Translate(string str)
        {
            if (CheckLanguage(str) == 0) return TranslitRusToLatin(str);
            else return TranslitLatinToRus(str);
        }

        
        public string TranslitRusToLatin(string str)
        {
            var result = "";
            foreach (var ch in str) 
            {
                var ss = "";
                //if in dictionary there is key with such value we get true
                //and add value from dictionary
                if (translitTableRusToLatin.TryGetValue(ch.ToString(), out ss))
                {
                    result += ss;
                }
                // or add the same symbol
                else result += ch;
            }
            return result;
        }


        public string TranslitLatinToRus(string s)
        {
            StringBuilder sb = new StringBuilder(s.Length);
            int i = 0;
            while (i < s.Length)
            {
                char ch = s[i];
                if (ch == 'j')
                { 
                    i++; 
                    ch = s[i];
                    switch (ch)
                    {
                        //je - ё
                        //js - щ
                        case 'e': sb.Append('ё'); break;
                        case 's':
                            sb.Append('щ');
                            i++; 
                            if (s[i] != 'н') throw new Exception("Illegal transliterated symbol at position " + i);// вариант третьего символа только один
                            break;
                        //jh - ь
                        //ju - ю
                        //ja - я
                        case 'h': sb.Append('ь'); break;
                        case 'u': sb.Append('ю'); break;
                        case 'a': sb.Append('я'); break;
                        default: throw new Exception("Illegal transliterated symbol at position " + i);
                    }
                }
                else if (i + 1 < s.Length && s[i + 1] == 'h' && !(i + 2 < s.Length && s[i + 2] == 'h'))
                {
                    switch (ch)
                    { 
                        case 'z': sb.Append('ж'); break; //zhh - ж
                        case 'k': sb.Append('х'); break; //khh - х
                        case 'c': sb.Append('ч'); break; //chh - ч
                        case 's': sb.Append('ш'); break; //shh - ш
                        case 'e': sb.Append('э'); break; //ehh - э
                        case 'h': sb.Append('ъ'); break; //hhh - ъ
                        case 'i': sb.Append('ы'); break; //ihh - ы
                        default: throw new Exception("Illegal transliterated symbol at position " + i);
                    }
                    i++;
                }
                else
                {
                    switch (ch)
                    {
                        case 'a': sb.Append('а'); break;
                        case 'b': sb.Append('б'); break;
                        case 'v': sb.Append('в'); break;
                        case 'g': sb.Append('г'); break;
                        case 'd': sb.Append('д'); break;
                        case 'e': sb.Append('е'); break;
                        case 'z': sb.Append('з'); break;
                        case 'i': sb.Append('и'); break;
                        case 'y': sb.Append('й'); break;
                        case 'k': sb.Append('к'); break;
                        case 'l': sb.Append('л'); break;
                        case 'm': sb.Append('м'); break;
                        case 'n': sb.Append('н'); break;
                        case 'o': sb.Append('о'); break;
                        case 'p': sb.Append('п'); break;
                        case 'r': sb.Append('р'); break;
                        case 's': sb.Append('с'); break;
                        case 't': sb.Append('т'); break;
                        case 'u': sb.Append('у'); break;
                        case 'f': sb.Append('ф'); break;
                        case 'c': sb.Append('ц'); break;
                        default: sb.Append(ch); break;
                    }
                }

                i++;
            }
            return sb.ToString();
        }
    }
}
