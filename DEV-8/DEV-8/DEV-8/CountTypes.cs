using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_8
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
        /// <param name="stock">storage in which we keep cars or trucks</param>

        public void Execute(Stock stock)
        {
            if (stock is StockOfCars)
            {
                Console.WriteLine("The count of car brands: " + stock.CountTypes());
            }
            if(stock is StockOfTrucks)
            {
                Console.WriteLine("The count of truck brands: " + stock.CountTypes());
            }
        }
    }
}
