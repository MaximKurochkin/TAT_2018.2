using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_4
{
    /// <summary>
    /// class WorkWithString
    /// removes and adds symbols into string
    /// </summary>
    
    class WorkWithString
    {
        /// <summary>
        /// Method RemoveFromElements
        /// removes part of string
        /// </summary>
        /// <param name="workString">the line 
        /// from which we want to remove element</param>
        /// <param name="currentString">on it we determine the length 
        /// of the segment to be removed from workString </param>
        /// <param name="isClosingTag">does the currentString 
        /// contain a closing tag</param>
        /// <returns>workString without last element</returns>
       
        public StringBuilder RemoveFromElements(StringBuilder workString, string currentString, bool isClosingTag)
        {
            int indOfFirstRemoveSymbol = 0;
            int indOfLastRemoveSymbol = 0;

            //if those variables are true
            //means we found indexes of the part to be deleted
            bool isIndOfFirstRemoveSymbolFind = false;
            bool isIndOfLastRemoveSymbolFind = false;

            for (int i = 0; i < currentString.Length; i++)
            {
                //try to find start of deleted part
                if (currentString[i] == '<')
                {
                    indOfFirstRemoveSymbol = i;
                    isIndOfFirstRemoveSymbolFind = true;
                }
                //try to find finish of deleted part
                if (currentString[i] == '>')
                {
                    // closing tag looks like </somewords>
                    // we need delete one less symbol
                    // because there are '/' in closing tag
                    if (isClosingTag)
                    {
                        indOfLastRemoveSymbol = i;
                        isIndOfLastRemoveSymbolFind = true;
                    }
                    else
                    {
                        indOfLastRemoveSymbol = i + 1;
                        isIndOfLastRemoveSymbolFind = true;
                    }
                }
                if (isIndOfFirstRemoveSymbolFind && isIndOfLastRemoveSymbolFind)
                {
                    break;
                }
            }
            //remove part of the workString
            workString.Remove(workString.Length - (indOfLastRemoveSymbol - indOfFirstRemoveSymbol),
                (indOfLastRemoveSymbol - indOfFirstRemoveSymbol));
            return workString;
        }

        /// <summary>
        /// Method RemoveSpacesAtBeginning
        /// removes spaces at beginning of the string
        /// </summary>
        /// <param name="workString">line from which we delete spaces</param>
        /// <returns>string without spaces at the beginning</returns>
        
        public string RemoveSpacesAtBeginning(string workString)
        {
            StringBuilder suitableString = new StringBuilder();
            suitableString.Append(workString);

            int countOfDeletedSymbols = 0;
            //count the number of spaces 
            //at the beginning of the line
            int indOfStr = 0;
            while (workString[indOfStr] == ' ')
            {
                countOfDeletedSymbols++;
                indOfStr++;
            }

            //remove spaces
            suitableString.Remove(0, countOfDeletedSymbols);
            return suitableString.ToString();
        }

        /// <summary>
        /// Method AppendDash
        /// adds a dash at the end of the line
        /// </summary>
        /// <param name="workString">in this string we need to add dash</param>
        /// <returns>string with adding dash at the end</returns>
        
        public StringBuilder AppendDash (StringBuilder workString)
        {
            workString.Append('-');
            workString.Append('-');
            return workString;
        }
    }
}
