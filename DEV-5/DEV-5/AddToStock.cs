

namespace DEV_5
{
    /// <summary>
    /// Class AddToStock
    /// contains interface ICommand
    /// </summary>

    class AddToStock : ICommand
    {
        /// <summary>
        /// Method Execute
        /// calls method AddToStock to perform command "add"
        /// </summary>
        /// <param name="stock">storage in which we keep cars</param>

        public void Execute(Stock stock)
        {
            stock.AddToStock();
        }
    }
}
