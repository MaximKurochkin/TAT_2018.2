using System;
using System.Collections.Generic;
using System.Linq;


namespace DEV_5
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
        /// <param name="stock">storage in which we keep cars</param>

        public void Execute(Stock stock)
        {
            stock.PrintList();
        }
    }
}
