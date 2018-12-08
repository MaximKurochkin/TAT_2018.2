using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
    /// <summary>
    /// Class Program
    /// prints count of the same sumbols in user string
    /// </summary>
    
    class Program
    {
        /// <summary>
        /// Method Main
        /// entery point
        /// </summary>
        /// <param name="args">user string</param>
    
        static void Main(string[] args)
        {
            CountOfTheSameSymbols count = new CountOfTheSameSymbols(args[0]);
            count.PrintCountOfTheSameSymbols();

        }
    }
}
