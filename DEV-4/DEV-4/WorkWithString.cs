using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_4
{
    class WorkWithString
    {
        public StringBuilder RemoveFromElements(StringBuilder workString, string currentString, bool isClosingTag)
        {
            int indOfFirstRemoveSymbol = 0;
            int indOfLastRemoveSymbol = 0;

            bool flag2 = false;
            bool flag1 = false;

            for (int i = 0; i < currentString.Length; i++)
            {
                if (currentString[i] == '<')
                {
                    indOfFirstRemoveSymbol = i;
                    flag1 = true;
                }
                if (currentString[i] == '>')
                {
                    if (isClosingTag)
                    {
                        indOfLastRemoveSymbol = i;
                        flag2 = true;
                    }
                    else
                    {
                        indOfLastRemoveSymbol = i + 1;
                        flag2 = true;
                    }
                }
                if (flag1 && flag2)
                {
                    break;
                }
            }
            workString.Remove(workString.Length - (indOfLastRemoveSymbol - indOfFirstRemoveSymbol),
                (indOfLastRemoveSymbol - indOfFirstRemoveSymbol));
            return workString;
        }

        public string RemoveSpacesAtBeginning(string workString)
        {
            StringBuilder suitableString = new StringBuilder();
            suitableString.Append(workString);

            int countOfDeletedSymbols = 0;
            for (int i = 0; i < workString.Length; i++)
            {
                if (suitableString[i] == ' ')
                {
                    countOfDeletedSymbols++;
                }
                else
                {
                    break;
                }
            }

            suitableString.Remove(0, countOfDeletedSymbols);
            return suitableString.ToString();
        }

        public StringBuilder AppendDash (StringBuilder workString)
        {
            workString.Append('-');
            workString.Append('-');
            return workString;
        }
    }
}
