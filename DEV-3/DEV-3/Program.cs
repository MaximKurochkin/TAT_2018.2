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
                args[0] = "20";
                args[1] = "19";

                NumericTranslator translator = new NumericTranslator();
                string afterTranslate = translator.TranslateInto(args[0], args[1]);
                Console.WriteLine(afterTranslate);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
