using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_8
{
    /// <summary>
    /// Class CountAll
    /// contains interface ICommand
    /// </summary>

    class CountAll : ICommand
    {
        
        /// <summary>
        /// Method Execute
        /// calls method CountAll to perform command "count all"
        /// </summary
        /// <param name="stock">storage in which we keep cars or trucks</param>

        public void Execute(Stock stock)
        {
            if(stock is StockOfCars)
            {
                Console.WriteLine("The count of cars: " + stock.CountAll());
            }
            if (stock is StockOfTrucks)
            {
                Console.WriteLine("The count of trucks: " + stock.CountAll());
            }
        }
    }
}
