using System;

namespace DEV_5
{
    class AveragePrice : IComand
    {
        public void Execute(Stock stock)
        {
            Console.WriteLine("Average price of cars: " + stock.AveragePrice());
        }
    }
}
