using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_8
{
    /// <summary>
    /// Class Stock
    /// it is a parent class
    /// for StoockOfCars and StockOfTrucks
    /// </summary>
    
    abstract class Stock
    {
        //available commands
        abstract public int CountTypes();
        abstract public int CountAll();
        abstract public double AveragePrice();
        abstract public double AveragePriceOfBrand(string brand);
        abstract public void AddToStock();
        abstract public void PrintList();
    }
}
