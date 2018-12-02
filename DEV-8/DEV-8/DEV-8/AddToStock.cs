using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_8
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
        /// <param name="stock">storage in which we keep cars or trucks</param>

        public void Execute(Stock stock)
        {
            if (stock is StockOfCars)
            {
                stock.AddToStock();
            }
            if (stock is StockOfTrucks)
            {
                stock.AddToStock();
            }
        }
    }
}
