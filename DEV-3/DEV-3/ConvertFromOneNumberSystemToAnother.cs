using System;


namespace DEV_3
{
    // <summary>
    // TranslateFromOneNumberSystemToAnother
    // Translates numeric from one number system
    // to another with radix from 2 to 20
    // </summary>
    class ConvertFromOneNumberSystemToAnother
    {
        // entery point into programm
        static void Main(string[] args)
        {
            try
            {
                NumericConverterToNewNumberSystem convertor = new NumericConverterToNewNumberSystem(args[0], args[1]);
                string afterConvertion = convertor.ConvertInto();
                Console.WriteLine(" Your numeric in number system with base 10: " + args[0]);
                Console.WriteLine(" Your nameric in number system with base " + args[1] + ": " + afterConvertion);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
