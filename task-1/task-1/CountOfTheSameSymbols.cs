using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
    /// <summary>
    /// Class CountOfTheSameSymbols
    /// prints count of the same symbols in user string
    /// </summary>
    
    class CountOfTheSameSymbols
    {
        //user string
        public string Str { get; set; }

        /// <summary>
        /// Method CountOfTheSameSymbols
        /// constructor
        /// </summary>
        /// <param name="str">input string</param>
        
        public CountOfTheSameSymbols(string str)
        {
            Str = str;
        }

        /// <summary>
        /// Method PrintCountOfTheSameSymbols
        /// prints count of the same symbols in user string
        /// </summary>
        
        public void PrintCountOfTheSameSymbols()
        {
            int count = 0;
            char currentSymbol;
            List<char> symbolsOfStr = new List<char>();

            for (int i = 0; i < Str.Length; i++)
            {
                currentSymbol = Str[i];
                if (symbolsOfStr.Contains(currentSymbol))
                {
                    continue;
                }
                else
                {
                    symbolsOfStr.Add(currentSymbol);
                    count = GetCountOfSymbol(currentSymbol);
                    Console.WriteLine("Count of symbol " + Str[i] + ": " + count);
                }
            }
        }

        /// <summary>
        /// Method GetCountOfSymbol
        /// returns count of symbol in string
        /// </summary>
        /// <param name="symb"> count of this symbol will be returned</param>
        /// <returns>count of symbol</returns>
        
        private int GetCountOfSymbol(char symb)
        {
            int countOfSymbol = 0;
            for (int i = 0; i < Str.Length; i++)
            {
                if(symb == Str[i])
                {
                    countOfSymbol++;
                }
            }
            return countOfSymbol;
        }
    }
}
