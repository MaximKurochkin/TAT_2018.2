using System;
using System.Collections.Generic;
using System.Text;

namespace DEV_6
{
    /// <summary>
    /// class JSONParser
    /// takes the address of JSON-file
    /// and parse it into list
    /// </summary>

    class JSONParser
    {
        //addrss of the JSON-file
        public string adressOfFile { get; set; }

        /// <summary>
        /// Constructor JSONParser
        /// creates objects JSONParser
        /// </summary>
        /// <param name="AdressOfFile">the address of JSON-file</param>

        public JSONParser(string AdressOfFile)
        {
            adressOfFile = AdressOfFile;
        }

        /// <summary>
        /// Method ToParseJSON
        /// parses JSON-file into list
        /// </summary>
        /// <returns>list with data from  JSON-file</returns>

        public List<string> ToParseJSON()
        {
            //convert JSON-file into array of strings
            ConvertIntoStrings converter = new ConvertIntoStrings(adressOfFile);
            string[] JSONInStrings = converter.fileInString;

            //list in which we will keep data from JSON-file
            List<string> dataOfJSONFile = new List<string>();

            //index of symbol in string
            int indOfStr = 1;

            //in this string we will keep the way into data
            StringBuilder dataOfJSON = new StringBuilder();

            //object for work with strings (add symbols, delete...)
            WorkWithString builder = new WorkWithString();

            //element of JSON-file
            StringBuilder element = new StringBuilder();
            //element inside the block in JSON-file
            StringBuilder nestedElement = new StringBuilder();
            //value of nested element
            StringBuilder value = new StringBuilder();

            //start of XML-file
            dataOfJSONFile.Add("<object>");

            //start to parse JSON-file
            for (int i = 1; i < JSONInStrings.Length; i++)
            {
                string str = JSONInStrings[i];
                //delete spaces from current string
                string currentString = builder.RemoveSpacesAtBeginning(str);

                // if current string contains string field
                // then print into XML-file next
                // <element>value of element</element>
                if (!currentString.Contains("{") && !currentString.Contains("}") && !currentString.Contains("["))
                {
                    dataOfJSON.Append("   ");
                    dataOfJSON.Append('<');

                    while (currentString[indOfStr] != '"')
                    {
                        element.Append(currentString[indOfStr]);
                        indOfStr++;
                    }
                    dataOfJSON.Append(element);
                    dataOfJSON.Append('>');

                    //": " - we need to pass 4 symbols to get value of element
                    indOfStr = indOfStr + 4;

                    while (currentString[indOfStr] != '"')
                    {
                        dataOfJSON.Append(currentString[indOfStr]);
                        indOfStr++;
                    }
                    //prints closing tag
                    dataOfJSON.Append("</");
                    dataOfJSON.Append(element);
                    dataOfJSON.Append(">");

                    dataOfJSONFile.Add(dataOfJSON.ToString());
                    dataOfJSON.Clear();
                    element.Clear();
                    indOfStr = 1;

                    continue;
                }

                // if string contains object
                // then bypass the whole block to the end
                if (currentString.Contains("{"))
                {
                    dataOfJSON.Append("   ");
                    dataOfJSON.Append("<");

                    while (currentString[indOfStr] != '"')
                    {
                        element.Append(currentString[indOfStr]);
                        indOfStr++;
                    }
                    dataOfJSON.Append(element);
                    dataOfJSON.Append(">");
                    dataOfJSONFile.Add(dataOfJSON.ToString());
                    dataOfJSON.Clear();
                    indOfStr = 1;

                    i++;
                    str = JSONInStrings[i];
                    //delete spaces from current string
                    currentString = builder.RemoveSpacesAtBeginning(str);

                    //prints nested elements of object
                    while (!currentString.StartsWith("},"))
                    {
                        if (!currentString.Contains("{"))
                        {
                            dataOfJSON.Append("        ");
                            dataOfJSON.Append('<');

                            while (currentString[indOfStr] != '"')
                            {
                                nestedElement.Append(currentString[indOfStr]);
                                indOfStr++;
                            }
                            dataOfJSON.Append(nestedElement);
                            dataOfJSON.Append('>');

                            indOfStr = indOfStr + 4;

                            while (currentString[indOfStr] != '"')
                            {
                                dataOfJSON.Append(currentString[indOfStr]);
                                indOfStr++;
                            }
                            dataOfJSON.Append("</");
                            dataOfJSON.Append(nestedElement);
                            dataOfJSON.Append(">");

                            dataOfJSONFile.Add(dataOfJSON.ToString());
                            dataOfJSON.Clear();
                            nestedElement.Clear();
                            indOfStr = 1;
                        }
                        i++;

                        str = JSONInStrings[i];
                        //delete spaces from current string
                        currentString = builder.RemoveSpacesAtBeginning(str);
                    }

                    // if we have reached the end of block in JSON-file
                    // then prints closing tag
                    if (currentString.StartsWith("},"))
                    {
                        dataOfJSON.Append("   ");
                        dataOfJSON.Append("</");
                        dataOfJSON.Append(element);
                        dataOfJSON.Append(">");

                        dataOfJSONFile.Add(dataOfJSON.ToString());
                        dataOfJSON.Clear();
                        element.Clear();
                        indOfStr = 1;
                    }
                    continue;
                }

                // if string contains array
                // then bypass the whole block to the end
                if (currentString.Contains("["))
                {
                    //array element name
                    dataOfJSON.Append("   ");
                    dataOfJSON.Append("<");

                    while (currentString[indOfStr] != '"')
                    {
                        element.Append(currentString[indOfStr]);
                        indOfStr++;
                    }
                    dataOfJSON.Append(element);
                    dataOfJSON.Append(">");
                    dataOfJSONFile.Add(dataOfJSON.ToString());
                    dataOfJSON.Clear();

                    i++;
                    str = JSONInStrings[i];
                    //delete spaces from current string
                    currentString = builder.RemoveSpacesAtBeginning(str);
                    indOfStr = 1;
                    nestedElement = element.Remove(element.Length - 1, 1);

                    // until we reach the end of the block
                    // prints elements of array into XML-file
                    while (currentString[indOfStr] != ']')
                    {
                        indOfStr = 1;
                        if (!currentString.Contains("{"))
                        {
                            dataOfJSON.Append("      ");
                            dataOfJSON.Append("<");

                            dataOfJSON.Append(nestedElement);
                            dataOfJSON.Append(">");

                            while (currentString[indOfStr] != '"')
                            {
                                value.Append(currentString[indOfStr]);
                                indOfStr++;
                            }

                            dataOfJSON.Append(value);

                            dataOfJSON.Append("</");
                            dataOfJSON.Append(nestedElement);
                            dataOfJSON.Append(">");

                            dataOfJSONFile.Add(dataOfJSON.ToString());
                            dataOfJSON.Clear();
                            value.Clear();
                        }
                        i++;
                        str = JSONInStrings[i];
                        //delete spaces from current string
                        currentString = builder.RemoveSpacesAtBeginning(str);
                        indOfStr = 0;
                    }

                    // if we have reached the end of array in JSON-file
                    // then prints closing tag
                    if (currentString.StartsWith("]"))
                    {
                        dataOfJSON.Append("  ");
                        dataOfJSON.Append("</");
                        dataOfJSON.Append(element);
                        dataOfJSON.Append("s");
                        dataOfJSON.Append(">");

                        dataOfJSONFile.Add(dataOfJSON.ToString());
                        dataOfJSON.Clear();
                        element.Clear();
                        nestedElement.Clear();
                    }
                    indOfStr = 1;
                    continue;
                }

                // if string contains the end symbol of JSON-file
                // then print closing tag
                if (currentString.StartsWith("}"))
                {
                    dataOfJSON.Append("</object>");
                    dataOfJSONFile.Add(dataOfJSON.ToString());
                    dataOfJSON.Clear();
                }
                indOfStr = 1;
            }
            return dataOfJSONFile;
        }
    }
}
