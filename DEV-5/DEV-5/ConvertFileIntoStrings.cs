using System.Text;


namespace DEV_5
{
    /// <summary>
    /// class ConvertXMLIntoStrings
    /// converts data from txt-file
    /// into array of strings
    /// FileStrings - array of strings from txt-file.
    /// </summary>
    
    class ConvertFileIntoStrings
    {
        public string[] FileInStrings { get; set; }

        /// <summary>
        /// Method ConvertFileIntoStrings
        /// converts txt-file into array of strings
        /// </summary>
        /// <param name="FileAddress">address of txt-file</param>

        public ConvertFileIntoStrings(string FileAddress)
        {
            FileInStrings = System.IO.File.ReadAllLines(FileAddress, Encoding.Default);
        }
    }
}
