using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_4
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
            ConvertXMLIntoStrings converter = new ConvertXMLIntoStrings(adressOfFile);
            string[] XMLInStrings = converter.XMLInString;

            //list in which we will keep data from XML-file
            List<string> dataOfXMLFile = new List<string>();

            //index of symbol in string
            int indOfStr = 1;

            //in this string we will keep the way into data
            StringBuilder elementsAndAttributes = new StringBuilder();
            //in this string we will keep value of attributes
            StringBuilder attributesContent = new StringBuilder();

            //does the currentString contain a closing tag
            bool isClosingTag = false;

            //object for work with strings (add symbols, delete...)
            WorkWithString builder = new WorkWithString();

            //start to parse XML-file
            foreach (string str in XMLInStrings)
            {
                //delete spaces from current string
                string currentString = builder.RemoveSpacesAtBeginning(str);

                // if string contains "<?xml"(XML-document declaration) 
                // or "<!" (comments)
                // then skip this string
                if (currentString.StartsWith("<?xml") || currentString.StartsWith("<!"))
                {
                    continue;
                }

                // if string contains closing tag
                // then remove from elementsAndAttributes name of this tag
                if (currentString.StartsWith("</"))
                {
                    isClosingTag = true;

                    elementsAndAttributes = builder.RemoveFromElements(elementsAndAttributes, currentString, isClosingTag);

                    isClosingTag = false;
                    continue;
                }

                // if string contains attribute
                // then add name of this attribute into elementsAndAttributes
                // and add value of this attribute
                // and add elementsAndAttributes and value of attribute
                // into list with data
                if (currentString.StartsWith("<") && currentString.Contains("="))
                {
                    while (currentString[indOfStr] != ' ')
                    {
                        elementsAndAttributes.Append(currentString[indOfStr]);
                        indOfStr++;
                    }

                    indOfStr++;
                    elementsAndAttributes = builder.AppendDash(elementsAndAttributes);
                    attributesContent.Append(elementsAndAttributes);

                    while (currentString[indOfStr] != '>')
                    {
                        if(currentString[indOfStr] == '=')
                        {
                            attributesContent = builder.AppendDash(attributesContent);
                            indOfStr++;
                            continue;
                        }
                        attributesContent.Append(currentString[indOfStr]);
                        indOfStr++;
                    }

                    dataOfXMLFile.Add(attributesContent.ToString());
                    // we added value of attribute int list
                    // now value of attribute is empty
                    attributesContent.Clear();
                    indOfStr = 1;
                    continue;
                }

                // if tring contains nested item
                // then add name of this item into elementsAndAttributes
                // and add value of this item 
                // and add elementsAndAttributes and value of attribute
                // into list with data 
                if (currentString.StartsWith("<") && currentString.Contains("</"))
                {
                    while(currentString[indOfStr] != '>')
                    {
                        elementsAndAttributes.Append(currentString[indOfStr]);
                        indOfStr++;
                    }
                    elementsAndAttributes = builder.AppendDash(elementsAndAttributes);

                    indOfStr++;

                    attributesContent.Append(elementsAndAttributes);

                    while(currentString[indOfStr] != '<')
                    {
                        attributesContent.Append(currentString[indOfStr]);
                        indOfStr++;
                    }

                    dataOfXMLFile.Add(attributesContent.ToString());
                    attributesContent.Clear();

                    elementsAndAttributes = builder.RemoveFromElements(elementsAndAttributes, currentString, isClosingTag);
                    indOfStr = 1;

                    continue;
                }

                // if string contains only name of item
                // then add name of this item into elementsAndAttributes
                if (currentString.StartsWith("<"))
                {
                    while (currentString[indOfStr] != '>')
                    {
                        elementsAndAttributes.Append(currentString[indOfStr]);
                        indOfStr++;
                    }
                    elementsAndAttributes = builder.AppendDash(elementsAndAttributes);
                    indOfStr = 1;
                    continue;
                }
            }
            return dataOfXMLFile;
        }

        /// <summary>
        /// Method PrintList
        /// prints data of list
        /// </summary>
        /// <param name="list">list with data we need to print</param>
        
        public void PrintList(List<string> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
        }
    }
}
