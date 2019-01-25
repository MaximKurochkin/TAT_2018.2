using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_8
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
        /// <param name="stock">storage in which we keep cars or trucks</param>

        public void Execute(Stock stock)
        {
            if (stock is StockOfCars)
            {
                Console.WriteLine("Average price of cars: " + stock.AveragePrice() + " $");
            }
            if (stock is StockOfTrucks)
            {
                Console.WriteLine("Average price of trucks: " + stock.AveragePrice() + " $");
            }
        }
    }
}
