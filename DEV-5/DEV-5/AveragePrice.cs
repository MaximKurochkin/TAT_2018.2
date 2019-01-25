using System;

namespace DEV_5
{
    /// <summary>
    /// Class AveragePrice
    /// contains interface ICommand
    /// </summary>
    
    class AveragePrice : ICommand
    {
        /// <summary>
        /// Method Execute
        /// calls method AveragePrice to perform command "average price"
        /// </summary>
        /// <param name="stock">storage in which we keep cars</param>

        public void Execute(Stock stock)
        {
            Console.WriteLine("Average price of cars: " + stock.AveragePrice() + " $");
        }
    }
}
