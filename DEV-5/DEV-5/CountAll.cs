using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_5
{
    class CountAll : IComand
    {
        public void Execute(Stock stock)
        {
            Console.WriteLine("The count of cars: " + stock.CountAll());
        }
    }
}
