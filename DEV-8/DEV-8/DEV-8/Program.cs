using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_8
{
    /// <summary>
    /// Class StockOfCars
    /// Allows to add cars to stock
    /// </summary>


    class Program
    {
        /// <summary>
        /// Method Main
        /// entery point
        /// </summary>

        static void Main(string[] args)
        {
            try
            {
                //creates stock of cars and stock of trucks
                StockOfCars stockOfCars = new StockOfCars(args[0]);
                StockOfTrucks stockOfTrucks = new StockOfTrucks(args[1]);

                Menu menu = new Menu();
                menu.CallMenu(stockOfCars, stockOfTrucks);          
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
