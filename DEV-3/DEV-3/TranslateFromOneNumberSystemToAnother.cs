using System;


namespace DEV_3
{
    // <summary>
    // TranslateFromOneNumberSystemToAnother
    // Translates numeric from one number system
    // to another
    // </summary>
    class TranslateFromOneNumberSystemToAnother
    {
        // entery point into programm
        static void Main(string[] args)
        {
            try
            {
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
