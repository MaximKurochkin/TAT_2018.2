using System;

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
