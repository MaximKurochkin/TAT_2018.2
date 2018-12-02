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

    class AveragePriceOfBrand : ICommand
    {
        /// <summary>
        /// Method Execute
        /// calls method AveragePriceOfBrand 
        /// to perform command "average price of brand"
        /// </summary
        /// <param name="stock">storage in which we keep cars or trucks</param>

        public void Execute(Stock stock)
        {
            string userInput = string.Empty;
            if (stock is StockOfCars)
            {
                Console.WriteLine("Please, enter the name of car brand");
                userInput = Console.ReadLine();
                Console.WriteLine("The average price of car brand " + userInput + ": "
                    + stock.AveragePriceOfBrand(userInput) + " $");
            }
            if (stock is StockOfTrucks)
            {
                Console.WriteLine("Please, enter the name of truck brand");
                userInput = Console.ReadLine();
                Console.WriteLine("The average price of truck brand " + userInput + ": "
                    + stock.AveragePriceOfBrand(userInput) + " $");
            }
        }
    }
}
