using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_4
{
    class ConvertXMLIntoStrings
    {
        public string[] XMLInString { get; set; }

        public ConvertXMLIntoStrings(string FileAdress)
        {
            XMLInString = System.IO.File.ReadAllLines(FileAdress, Encoding.Default);
        }
    }
}
