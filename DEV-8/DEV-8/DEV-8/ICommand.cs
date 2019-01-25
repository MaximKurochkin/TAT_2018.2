using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_8
{
    /// <summary>
    /// Interface ICommand
    /// contains method Execute
    /// which will be implemented in the heirs
    /// </summary
    /// <param name="stock">storage in which we keep cars or trucks</param>

    interface ICommand
    {
        void Execute(Stock stock);
    }
}
