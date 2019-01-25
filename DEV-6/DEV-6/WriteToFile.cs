using System.Collections.Generic;
using System.IO;


namespace DEV_6
{
    /// <summary>
    /// class WriteToFile
    /// writes data to file
    /// </summary>
    class WriteToFile
    {
        // address of the recipient
        public string address { get; set; }

        public WriteToFile (string destinationAddress)
        {
            address = destinationAddress;
        }

        /// <summary>
        /// method WritetoJSON
        /// writes data from list into JSON-file
        /// </summary>
        /// <param name="dataFromXML">list with data from initial file</param>
        public void WriteToJSON (List<string> dataFromXML)
        {
            using (StreamWriter sw = new StreamWriter(address, false, System.Text.Encoding.Default))
            {
                foreach ( string str in dataFromXML)
                {
                    sw.WriteLine(str);
                }
            }
        }

        /// <summary>
        /// method WritetoXML
        /// writes data from list into XML-file
        /// </summary>
        /// <param name="dataFromXML">list with data from initial file</param>
        public void WriteToXML(List<string> dataFromJSON)
        {
            using (StreamWriter sw = new StreamWriter(address, false, System.Text.Encoding.Default))
            {
                foreach (string str in dataFromJSON)
                {
                    sw.WriteLine(str);
                }
            }
        }
    }
}
