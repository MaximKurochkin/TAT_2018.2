using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_5
{
    class CountTypes : IComand
    {

        public void Execute(Stock stock)
        {
            Console.WriteLine("The count of brands: " + stock.CountTypes());
        }
    }
}
