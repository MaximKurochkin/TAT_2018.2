using System;
using System.Linq;
using System.Text;


namespace task_1_10._18._2018
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = args[0];
            int sizeOfSequence = 0;
            StringBuilder sequence = new StringBuilder();

            Console.WriteLine(str);

            switch (str.Length)
            {
                case 0:
                    sizeOfSequence = 0;
                    break;

                case 1:
                    sizeOfSequence = 1;
                    break;

                default:

                    for (int i = 1; i < str.Length; i++)
                    {
                        if (i == 1)
                        {
                            sequence.Append(str[i - 1]);
                            sizeOfSequence = 1;
                        }
                        if (str[i] != str[i - 1] && !sequence.ToString().Contains(str[i]))
                        {
                            sequence.Append(str[i]);
                        }
                        else
                        {
                            sizeOfSequence = Math.Max(sequence.Length, sizeOfSequence);
                            sequence.Append(str[i]);
                            sequence = sequence.Remove(0, sequence.ToString().IndexOf(str[i]) + 1);
                        }
                    }
                    if (sizeOfSequence < sequence.Length) sizeOfSequence = sequence.Length;
                    break;
            }
            Console.WriteLine(sizeOfSequence);
            Console.ReadKey();
        }
    }
}
