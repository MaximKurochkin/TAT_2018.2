using System;


namespace DEV_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //to solve some proplems with translate latin symbols to rus i decide to change same pairs
            //ж - zhh, и - i, х - khh, ц - c, ч - chh, ш - shh, щ - js, ъ - hhh, ы - ihh, ь - jh, э - ehh, ю - ju, я -ja

            //for translate rus symbols to latin i use the table that you recomend
            string str = args[0];
            Transliter translit = new Transliter();
            str = translit.Translate(str);
            Console.WriteLine(str);
            Console.ReadKey();

        }
    }
}
