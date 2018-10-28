using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_4
{
    class GettingDataFromXML
    {
        static void Main(string[] args)
        {
            var xmlParser = new XMLParser(args[0]);
            List<string> parsedResult = xmlParser.ToParseXML();
            for (int i = 0; i < parsedResult.Count; i++)
            {
                Console.WriteLine(parsedResult[i]);
            }
            Console.ReadKey();
        }
    }
}
