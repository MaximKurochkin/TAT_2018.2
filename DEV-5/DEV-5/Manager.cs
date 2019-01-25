

namespace DEV_5
{
    /// <summary>
    /// class Manager
    /// invoker of commands
    /// </summary>
    
    class Manager
    {
        //interface of command
        ICommand comand;

        /// <summary>
        /// Method SetCommand
        /// set the command for execution
        /// </summary>
        /// <param name="comand"> user command</param>
        
        public void SetCommand (ICommand comand)
        {
            this.comand = comand;
        }

        /// <summary>
        /// Method CountTypes
        /// causes the command "count types" to be executed
        /// </summary>
        /// <param name="stock">storage in which we keep cars</param>
        
        public void CountTypes(Stock stock)
        {
            comand.Execute(stock);
        }

        /// <summary>
        /// Method CountAll
        /// causes the command "count all" to be executed
        /// </summary>
        /// <param name="stock">storage in which we keep cars</param>
        
        public void CountAll(Stock stock)
        {
            comand.Execute(stock);
        }

        /// <summary>
        /// Method AveragePrice
        /// causes the command "average price" to be executed
        /// </summary>
        /// <param name="stock">storage in which we keep cars</param>

        public void AveragePrice(Stock stock)
        {
            comand.Execute(stock);
        }

        /// <summary>
        /// Method AveragePriceOfBrand
        /// causes the command "average price of brand" to be executed
        /// </summary>
        /// <param name="stock">storage in which we keep cars</param>

        public void AveragePriceOfBrand(Stock stock)
        {
            comand.Execute(stock);
        }

        /// <summary>
        /// Method AddToStock
        /// causes the command "add" to be executed
        /// </summary>
        /// <param name="stock">storage in which we keep cars</param>

        public void AddToStock(Stock stock)
        {
            comand.Execute(stock);
        }

        /// <summary>
        /// Method ContentsOfStock
        /// causes the command "print" to be executed
        /// </summary>
        /// <param name="stock">storage in which we keep cars</param>

        public void ContentsOfStock(Stock stock)
        {
            comand.Execute(stock);
        }
    }
}
