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
            string str = "privet";
            Transliter translit = new Transliter();
            str = translit.Translate(str);
            Console.WriteLine(str);

            string str1 = "привет";
            Transliter translit1 = new Transliter();
            str1 = translit1.Translate(str1);
            Console.WriteLine(str1);
            Console.ReadKey();
        }
    }
}
