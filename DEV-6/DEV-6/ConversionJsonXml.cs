using System;
using System.Collections.Generic;


namespace DEV_6
{
    /// <summary>
    /// class ConversionJsonXml
    /// converts JSON--XML and XMl--JSON
    /// </summary>
    class ConversionJsonXml
    {
        /// <summary>
        /// method Main
        /// entery point
        /// </summary>
        /// <param name="args">args[0] - sender address
        ///                    args[1] - destination address
        ///                    args[2] - type of initial file</param>
        static void Main(string[] args)
        {
            try
            {
                if(args[2] == "xml")
                {
                    var xmlParser = new XMLParser(args[0]);
                    List<string> parsedResult = xmlParser.ToParseXML();

                    WriteToFile writer = new WriteToFile(args[1]);
                    writer.WriteToJSON(parsedResult);
                }
                else
                {
                    JSONParser jsonParser = new JSONParser(args[0]);
                    List<string> parsedResult = jsonParser.ToParseJSON();

                    WriteToFile writer = new WriteToFile(args[1]);
                    writer.WriteToXML(parsedResult);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
