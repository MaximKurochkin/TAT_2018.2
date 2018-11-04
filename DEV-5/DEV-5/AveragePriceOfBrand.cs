using System;


namespace DEV_5
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
        /// <param name="stock">storage in which we keep cars</param>

        public void Execute(Stock stock)
        {
            Console.WriteLine("Please, enter the name of brand");
            string userInput = Console.ReadLine();
            Console.WriteLine("The average price of brand " + userInput + ": " 
                + stock.AveragePriceOfBrand(userInput) + " $");
        }
    }
}
