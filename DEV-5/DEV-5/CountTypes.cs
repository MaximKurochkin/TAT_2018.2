using System;

namespace DEV_5
{
    /// <summary>
    /// Class CountTypes
    /// contains interface ICommand
    /// </summary>

    class CountTypes : ICommand
    {
        /// <summary>
        /// Method Execute
        /// calls method CountTypes to perform command "count types"
        /// </summary
        /// <param name="stock">storage in which we keep cars</param>

        public void Execute(Stock stock)
        {
            Console.WriteLine("The count of brands: " + stock.CountTypes());
        }
    }
}
