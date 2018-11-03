using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_5
{
    class ConvertFileIntoStrings
    {
        public string[] FileInStrings { get; set; }

        public ConvertFileIntoStrings(string FileAddress)
        {
            FileInStrings = System.IO.File.ReadAllLines(FileAddress, Encoding.Default);
        }
    }
}
