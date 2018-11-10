using System;
using System.Collections.Generic;


namespace DEV_6
{
    class ConversionJsonXml
    {
        static void Main(string[] args)
        {
            try
            {
                var xmlParser = new XMLParser(args[0]);
                List<string> parsedResult = xmlParser.ToParseXML();

                WriteToFile writer = new WriteToFile();
                writer.WriteToJSON(parsedResult);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
