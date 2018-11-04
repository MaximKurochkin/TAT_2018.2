using System;


namespace DEV_5
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
        /// <param name="stock">storage in which we keep cars</param>

        public void Execute(Stock stock)
        {
            Console.WriteLine("The count of cars: " + stock.CountAll());
        }
    }
}
