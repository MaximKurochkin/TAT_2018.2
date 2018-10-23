using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_3
{
    class StringReverser
    {
        public string Reverse (string input)
        {
            string output = new string(input.ToCharArray().Reverse().ToArray());
            return output;
        }
    }
}
