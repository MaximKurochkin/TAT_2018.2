using System;
using System.Collections.Generic;


namespace DEV_4
{
    /// <summary>
    /// class GettingDataFromXML
    /// takes the address of XML-file
    /// and parse it into list
    /// </summary>
    
    class GettingDataFromXML
    {
        //entery point
        static void Main(string[] args)
        {
            try
            {
                var xmlParser = new XMLParser(args[0]);
                List<string> parsedResult = xmlParser.ToParseXML();
                xmlParser.PrintList(parsedResult);
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
