using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DEV_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "щетка";
            Transliter translit = new Transliter();
            str = translit.TranslitRusToLatin(str);
            Console.WriteLine(str);
            Console.ReadKey();
        }
    }
}
