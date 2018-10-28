using System.Text;


namespace DEV_4
{
    /// <summary>
    /// class ConvertXMLIntoStrings
    /// converts data from XML-file
    /// into array of strings
    /// FileAddress - address of XML-file
    /// </summary>
    
    class ConvertXMLIntoStrings
    {
        public string[] XMLInString { get; set; }

        public ConvertXMLIntoStrings(string FileAddress)
        {
            XMLInString = System.IO.File.ReadAllLines(FileAddress, Encoding.Default);
        }
    }
}
