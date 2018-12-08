using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2
{
    /// <summary>
    /// Class Program
    /// founds ip-adress in input string
    /// </summary>
    
    class Program
    {
        /// <summary>
        /// Method Main
        /// Entery Point
        /// </summary>
        /// <param name="args">input string</param>
        
        static void Main(string[] args)
        {
            FinderOfIPinStr finder = new FinderOfIPinStr();
            List<string> listOfIP = new List<string>();
            listOfIP = finder.GetIPFromStr(args[0]);

            foreach(string ip in listOfIP)
            {
                Console.WriteLine("IP-adress is " +ip);
            }
        }
    }
}
