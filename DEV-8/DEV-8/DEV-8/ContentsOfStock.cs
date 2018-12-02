using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_8
{
    /// <summary>
    /// Class ContentsOfStock
    /// contains interface ICommand
    /// </summary>

    class ContentsOfStock : ICommand
    {
        /// <summary>
        /// Method Execute
        /// calls method PrintList to perform command "print"
        /// </summary
        /// <param name="stock">storage in which we keep cars or trucks</param>

        public void Execute(Stock stock)
        {
            if (stock is StockOfCars)
            {
                stock.PrintList();
            }
            if (stock is StockOfTrucks)
            {
                stock.PrintList();
            }
        }
    }
}
