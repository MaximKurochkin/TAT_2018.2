using System.Collections.Generic;
using System.Text;

namespace DEV_6
{
    /// <summary>
    /// class XMLParser
    /// takes the address of XML-file
    /// and parse it into list
    /// </summary>

    class XMLParser
    {
        //addrss of the XML-file
        public string adressOfFile { get; set; }

        /// <summary>
        /// Constructor XMLParser
        /// creates objects XMLParser
        /// </summary>
        /// <param name="AdressOfFile">the address of XML-file</param>

        public XMLParser(string AdressOfFile)
        {
            adressOfFile = AdressOfFile;
        }

        /// <summary>
        /// Method ToParseXML
        /// parses XML-file into list
        /// </summary>
        /// <returns>list with data from  XML-file</returns>

        public List<string> ToParseXML()
        {
            //convert XML-file into array of strings
            ConvertIntoStrings converter = new ConvertIntoStrings(adressOfFile);
            string[] fileInStrings = converter.fileInString;

            //list in which we will keep data from XML-file
            List<string> dataOfXMLFile = new List<string>();

            //index of symbol in string
            int indOfStr = 1;

            //in this string we will keep data from XML-string
            StringBuilder elementOfXML = new StringBuilder();

            //object for work with strings (add symbols, delete...)
            WorkWithString builder = new WorkWithString();

            //start of JSON-file
            dataOfXMLFile.Add("{");

            //start to parse XML-file
            for (int i = 1; i < fileInStrings.Length; i++)
            {
                string str = fileInStrings[i];

                //delete spaces from current string
                string currentString = builder.RemoveSpacesAtBeginning(str);

                // if string contains "<?xml"(XML-document declaration) 
                // or "<!" (comments)
                // then skip this string
                if (currentString.StartsWith("<?xml") || currentString.StartsWith("<!"))
                {
                    continue;
                }

                // if string contains "</"
                // then it is a closing tag
                // and prints "}" into JSON-file
                if (currentString.StartsWith("</"))
                {
                    elementOfXML.Append("}");
                    dataOfXMLFile.Add(elementOfXML.ToString());
                    elementOfXML.Clear();
                    continue;
                }

                // if string contains "<" and "</"
                // then prints into JSON-file next
                // "elementOfXML": "value",
                if (currentString.StartsWith("<") && currentString.Contains("</"))
                {
                    elementOfXML.Append("   ");
                    elementOfXML.Append('"');
                    while (currentString[indOfStr] != '>')
                    {
                        elementOfXML.Append(currentString[indOfStr]);
                        indOfStr++;
                    }
                    elementOfXML.Append('"');
                    elementOfXML.Append(": ");
                    elementOfXML.Append('"');

                    indOfStr++;

                    while (currentString[indOfStr] != '<')
                    {
                        elementOfXML.Append(currentString[indOfStr]);
                        indOfStr++;
                    }
                    elementOfXML.Append('"');
                    elementOfXML.Append(',');
                    dataOfXMLFile.Add(elementOfXML.ToString());
                    elementOfXML.Clear();
                    indOfStr = 1;

                    continue;
                }

                // if string contains only "<elementOfXML>"
                // then bypass the whole block to the end
                if (currentString.StartsWith("<"))
                {
                    elementOfXML.Append("   ");
                    elementOfXML.Append('"');
                    while (currentString[indOfStr] != '>')
                    {
                        elementOfXML.Append(currentString[indOfStr]);
                        indOfStr++;
                    }
                    elementOfXML.Append('"');
                    elementOfXML.Append(": {");
                    dataOfXMLFile.Add(elementOfXML.ToString());
                    indOfStr = 1;
                    elementOfXML.Clear();

                    i++;

                    str = fileInStrings[i];

                    currentString = builder.RemoveSpacesAtBeginning(str);

                    // while did not reach the end of block
                    while (!currentString.StartsWith("</"))
                    {   
                        // if string contains "<" and "</"
                        // then prints into JSON-file next
                        // "elementOfXML": "value",
                        if (currentString.StartsWith("<") && currentString.Contains("</"))
                        {
                            elementOfXML.Append("       ");
                            elementOfXML.Append('"');
                            while (currentString[indOfStr] != '>')
                            {
                                elementOfXML.Append(currentString[indOfStr]);
                                indOfStr++;
                            }
                            elementOfXML.Append('"');
                            elementOfXML.Append(": ");

                            indOfStr++;

                            elementOfXML.Append('"');
                            while (currentString[indOfStr] != '<')
                            {
                                elementOfXML.Append(currentString[indOfStr]);
                                indOfStr++;
                            }
                            elementOfXML.Append('"');
                            elementOfXML.Append(',');
                            dataOfXMLFile.Add(elementOfXML.ToString());
                            elementOfXML.Clear();
                            indOfStr = 1;
                        }
                        i++;

                        str = fileInStrings[i];
                        //delete spaces from current string
                        currentString = builder.RemoveSpacesAtBeginning(str);
                    }
                    
                    // if have reached to the end of block
                    // then print into JSON-file "},"
                    if (currentString.StartsWith("</"))
                    {
                        elementOfXML.Append("   ");
                        elementOfXML.Append("},");
                        dataOfXMLFile.Add(elementOfXML.ToString());
                        elementOfXML.Clear();
                        indOfStr = 1;
                    }
                    continue;
                }
            }
            return dataOfXMLFile;
        }
    }
}

