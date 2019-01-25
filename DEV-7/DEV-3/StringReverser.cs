using System.Linq;

namespace DEV_3
{
    // <summary>
    // StringReverse
    // reverses a string 
    // return param string output - reverce string
    // </summery>
    class StringReverser
    {
        // <summery>
        // Method Reverse
        // function for reversing a string
        // </summery>
        // param string input - string which needed to reverse
        // return param string - reverse string

        public string Reverse (string input)
        {
            string output = new string(input.ToCharArray().Reverse().ToArray());
            return output;
        }
    }
}
