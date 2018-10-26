using System;


namespace DEV_3
{
    // <summery>
    // NumericConverter
    // converts a numeric from one number system
    // to another
    // by the condition of the task radix can be from 2 - 20
    // </summery>

    class NumericConverterToNewNumberSystem
    {
        // numeric after convertion into new number system
        private string numAfterConvert = String.Empty;

        //numeric which we need to convert to new number system
        //it is entered by user
        private string stringOfNumber = String.Empty;

        //radix of new number system
        //it can be from 2 to 20 by the condition of the task
        private string stringOfBasis = String.Empty;

        // <summery>
        // Method NumericConverterToNewNumberSystem
        // is a constructor of class NumericConverterToNewNumberSystem
        // creates a new object NumericConverterToNewNumberSystem
        // </summery>
        // param string number - is a numeric, which we need to convert
        // param string basis - is a radix of new number system, 
        // into which we will convert numeric

        public NumericConverterToNewNumberSystem (string number, string basis)
        {
            stringOfNumber = number;
            stringOfBasis = basis;
        }

        // <summery>
        // Method ConvertInto
        // function for convert a numeric from one number system
        // to another with base from 2 to 20 
        // </summery>
        // return param string numericAfterConvert - is a numeric,
        // which converted from old number system to new

        public string ConvertInto ()
        {
            // Create an object which can convert string into int
            // and converts stringOfNamber and stringOfBasis into int
            ConvertorStringToInt convertor = new ConvertorStringToInt();
            int number = convertor.ConvertStrToInt(stringOfNumber);
            int basis = convertor.ConvertStrToInt(stringOfBasis);

            // by the condition of the task radix can be from 2 to 20
            if (basis > 20 || basis < 2)
            {
                throw new Exception("Please, check the data! The basis can be from 2 to 20.");
            }

            else
            {
                // if number is negative
                // then multiply it by (-1) to become positive
                // so get rid of the character "-" at the beginning of the number
                if (number < 0)
                {
                    number = number * (-1);
                }

                // if number is less than radix of new number system
                // then add symbol into numeric in new number system
                // numeric in old number system = numeric in new number system
                if (number < basis)
                {
                    AddSymbol(number);
                }

                // numForDevision - is number, 
                // that we will divide by the base of new number system
                int numForDevision = number;

                //cicle for convert numeric into new number system
                //the result will be written in reverse order
                while (numForDevision >= basis)
                {
                    int resultOfDevision = numForDevision / basis;
                    int residue = numForDevision - basis * resultOfDevision;
                    numAfterConvert = AddSymbol(residue);

                    if (resultOfDevision < basis)
                    {
                        AddSymbol(resultOfDevision);
                    }
                    numForDevision = resultOfDevision;
                }
            }
            
            //we need to written symbols of new number in reverse order
            //create object "reverser", which can do this
            StringReverser reverser = new StringReverser();
            string numericAfterTranslate = reverser.Reverse(numAfterConvert);

            //if old number was negative, put "-" before new number
            if (stringOfNumber[0] == '-')
            {
                numericAfterTranslate = numericAfterTranslate.Insert(0, "-");
            }

            return numericAfterTranslate;
        }

        // <summery>
        // Method AddSymbol
        // function for adding symbols of numeric in new number system
        // </summery>
        // param int symbolOfNumber - one of the characters 
        // that make up the numeric in new number systemturn
        // return param string numAfterConvert - is a string,
        // into which was added symbol of numeric in new number system

        public string AddSymbol (int symbolOfNumber)
        {
            string symbol = String.Empty;

            // if symbolOfNumber < 10 then
            // converts symbolOfNumber into int
            // because we insert it as a symbol
            // of numeric in new number system
            // else
            // use ASCI-code of symbols A, B, C...I, J
            // to get them like a char then converts it into string
            // and inserts like a symbol of numeric in new number system
            if (symbolOfNumber < 10)
            {
                symbol = symbolOfNumber.ToString();
            } 
            else
            {
                // Symbol   ASCI-code  SymbolOfNumber
                // A        65         10
                // B        66         11
                // C        67         12
                //    .....     ......
                // J        74         19
                //
                // char A = ASCI-code of A - 10 + 10 = 65 (ASCI-code)
                // char B = ASCI-code of B - 10 + 11 = 66
                // char C = ASCI-code of C - 10 + 12 = 67
                // ........
                // char J = ASCI-code of J - 10 + 19 = 74
                char CharSymbolOfNumber = (char)('A' - 10 + symbolOfNumber);
                symbol = CharSymbolOfNumber.ToString();
            }
            numAfterConvert = numAfterConvert.Insert(numAfterConvert.Length, symbol);
            return numAfterConvert;
        }
    }
}
