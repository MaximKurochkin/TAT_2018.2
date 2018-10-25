using System;

namespace DEV_3
{
    // <summary>
    // ConvertorStrToInt
    // converts string to integer 
    // </summery>

    class ConvertorStringToInt
    {
        // <summery>
        // Method ConvertStrToInt
        // function for convertion string into number
        // </summery>
        // param string str - the string to be converted to an int
        // return param int - the number 
        // obtained by converting a string to a number

        public int ConvertStrToInt (string str)
        {
            return Convert.ToInt32(str);
        }
    }
}
