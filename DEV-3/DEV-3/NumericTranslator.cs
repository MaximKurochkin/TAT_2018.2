﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_3
{
    class NumericTranslator
    {
        private string numAfterTranslate = "";

        public string TranslateInto (string _number, string _basis)
        {
            int number = Convert.ToInt32(_number);
            int basis = Convert.ToInt32(_basis);

            if (_number == "0") throw new Exception("Please, enter a number.");
            if (basis > 20 || basis < 2) throw new Exception("Please, check the data! The basis can be from 2 to 20.");
            else
            {
                int numForDevision = number;
                while (numForDevision >= basis)
                {
                    int resultOfDevision = numForDevision / basis;
                    //if (resultOfDevision < basis) AddSymbol(resultOfDevision);

                    int residue = numForDevision - basis * resultOfDevision;
                    numAfterTranslate = AddSymbol(residue);

                    if (resultOfDevision < basis) AddSymbol(resultOfDevision);

                    numForDevision = resultOfDevision;
                }
            }
            StringReverser reverser = new StringReverser();
            return reverser.Reverse(numAfterTranslate);
        }

        public string AddSymbol (int resultOfDevision)
        {
            string symbol = "";

            if (resultOfDevision < 10)
                symbol = resultOfDevision.ToString();
            else
            {
                switch (resultOfDevision)
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
