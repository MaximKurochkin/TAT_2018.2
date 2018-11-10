using System.Text;

namespace DEV_6
{
    /// <summary>
    /// class WorkWithString
    /// removes and adds symbols into string
    /// </summary>

    class WorkWithString
    { 
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
    }
}

