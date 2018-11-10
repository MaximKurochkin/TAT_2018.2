using System.Text;


namespace DEV_6
{
    /// <summary>
    /// class ConvertXMLIntoStrings
    /// converts data from XML-file
    /// into array of strings
    /// FileAddress - address of XML-file
    /// </summary>

    class ConvertIntoStrings
    {
        public string[] fileInString { get; set; }

        public ConvertIntoStrings(string FileAddress)
        {
            fileInString = System.IO.File.ReadAllLines(FileAddress, Encoding.Default);
        }
    }
}
