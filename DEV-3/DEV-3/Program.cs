using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                args[0] = "1999";
                args[1] = "9";

                Console.WriteLine(" Your numeric in number system with base 10: " + args[0]);

                NumericTranslator translator = new NumericTranslator();
                string afterTranslate = translator.TranslateInto(args[0], args[1]);

                Console.WriteLine(" Your nameric in number system with base " + args[1] + ": " + afterTranslate);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
