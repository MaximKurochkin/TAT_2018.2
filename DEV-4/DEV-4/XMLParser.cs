using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_4
{
    class XMLParser
    {
        public string adressOfFile { get; set; }

        public XMLParser(string AdressOfFile)
        {
            adressOfFile = AdressOfFile;
        }

        public List<string> ToParseXML()
        {
            ConvertXMLIntoStrings converter = new ConvertXMLIntoStrings(adressOfFile);
            string[] XMLInStrings = converter.XMLInString;

            List<string> dataOfXMLFile = new List<string>();

            int indOfStr = 1;

            StringBuilder elementsAndAttributes = new StringBuilder();
            StringBuilder elementContent = new StringBuilder();

            bool isClosingTag = false;

            WorkWithString builder = new WorkWithString();

            foreach (string str in XMLInStrings)
            {
                string currentString = builder.RemoveSpacesAtBeginning(str);

                if (currentString.StartsWith("<?xml") || currentString.StartsWith("<!"))
                {
                    continue;
                }

                if (currentString.StartsWith("</"))
                {
                    isClosingTag = true;

                    elementsAndAttributes = builder.RemoveFromElements(elementsAndAttributes, currentString, isClosingTag);

                    isClosingTag = false;
                    continue;
                }

                if (currentString.StartsWith("<") && currentString.Contains("="))
                {
                    while (currentString[indOfStr] != ' ')
                    {
                        elementsAndAttributes.Append(currentString[indOfStr]);
                        indOfStr++;
                    }

                    indOfStr++;
                    elementsAndAttributes = builder.AppendDash(elementsAndAttributes);
                    elementContent.Append(elementsAndAttributes);

                    while (currentString[indOfStr] != '>')
                    {
                        if(currentString[indOfStr] == '=')
                        {
                            elementContent = builder.AppendDash(elementContent);
                            indOfStr++;
                            continue;
                        }
                        elementContent.Append(currentString[indOfStr]);
                        indOfStr++;
                    }

                    dataOfXMLFile.Add(elementContent.ToString());
                    elementContent.Clear();
                    indOfStr = 1;
                    continue;
                }

                if (currentString.StartsWith("<") && currentString.Contains("</"))
                {
                    while(currentString[indOfStr] != '>')
                    {
                        elementsAndAttributes.Append(currentString[indOfStr]);
                        indOfStr++;
                    }
                    elementsAndAttributes = builder.AppendDash(elementsAndAttributes);

                    indOfStr++;

                    elementContent.Append(elementsAndAttributes);

                    while(currentString[indOfStr] != '<')
                    {
                        elementContent.Append(currentString[indOfStr]);
                        indOfStr++;
                    }

                    dataOfXMLFile.Add(elementContent.ToString());
                    elementContent.Clear();

                    elementsAndAttributes = builder.RemoveFromElements(elementsAndAttributes, currentString, isClosingTag);
                    indOfStr = 1;

                    continue;
                }

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
    }
}
