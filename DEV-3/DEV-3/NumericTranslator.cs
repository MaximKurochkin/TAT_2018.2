using System;


namespace DEV_3
{
    // <summery>
    // NumericTranslator
    // translates a numeric from one number system
    // to another
    // </summery>

    class NumericTranslator
    {
        // numeric after translation into new number system
        private string numAfterTranslate = "";

        // <summery>
        // Method TranslateInto
        // function for translate a numeric from one number system
        // to another
        // </summery>
        // param string _number - is a numeric, which we need to translate
        // param string _basis - is a base of new number system, 
        // into which we will translate number _number
        public string TranslateInto (string _number, string _basis)
        {
            if (_number == "0") throw new Exception("Please, enter a number.");

            int number = Convert.ToInt32(_number);
            int basis = Convert.ToInt32(_basis);

            // by the condition of the task base can be from 2 - 20
            if (basis > 20 || basis < 2)
                throw new Exception("Please, check the data! The basis can be from 2 to 20.");
            else
            {
                // check if number is negative
                if (number < 0) number = number * (-1);

                // check if number is less than base of new number system
                // if it is true
                // numeric in old number system = numeric in new number system
                if (number < basis) AddSymbol(number);

                // numForDevision - is number, 
                // that we will divide by the base of new number system
                int numForDevision = number;

                //cicle for translate numeric into new number system
                //the result will be written in reverse order
                while (numForDevision >= basis)
                {
                    int resultOfDevision = numForDevision / basis;

                    int residue = numForDevision - basis * resultOfDevision;
                    numAfterTranslate = AddSymbol(residue);

                    if (resultOfDevision < basis) AddSymbol(resultOfDevision);

                    numForDevision = resultOfDevision;
                }
            }
            
            //we need to written symbols of new number in reverse order
            //create object "reverser", which can do this
            StringReverser reverser = new StringReverser();
            string result = reverser.Reverse(numAfterTranslate);

            //if old number was negative, put "-" before new number
            if (_number[0] == '-') result = result.Insert(0, "-");

            return result;
        }

        // <summery>
        // Method AddSymbol
        // function for adding symbols of numeric in new number system
        // </summery>
        // param int symbolOfNumber - one of the characters 
        // that make up the numeric in new number system
        public string AddSymbol (int symbolOfNumber)
        {
            string symbol = "";

            if (symbolOfNumber < 10)
                symbol = symbolOfNumber.ToString();
            else
            {
                switch (symbolOfNumber)
                {
                    case 10: symbol = "A"; break;
                    case 11: symbol = "B"; break;
                    case 12: symbol = "C"; break;
                    case 13: symbol = "D"; break;
                    case 14: symbol = "E"; break;
                    case 15: symbol = "F"; break;
                    case 16: symbol = "G"; break;
                    case 17: symbol = "H"; break;
                    case 18: symbol = "I"; break;
                    case 19: symbol = "J"; break;

                    default: break;
                }
            }
            numAfterTranslate = numAfterTranslate.Insert(numAfterTranslate.Length, symbol);
            return numAfterTranslate;
        }
    }
}
