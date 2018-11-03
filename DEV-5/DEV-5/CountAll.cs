using System;


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
