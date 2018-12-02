using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_8
{
    class StockOfTrucks : Stock
    {
        //list with trucks
        private List<Truck> recordsAboutTrucks = new List<Truck>();

        /// <summary>
        /// Method StockOfTrucks
        /// constructor for object StockOfTrucks
        /// which get information from xml-file
        /// </summary>

        public StockOfTrucks(string addressOfXMLwithTrucks)
        {
            XMLParser parser = new XMLParser();
            recordsAboutTrucks = parser.ToPareXMLWithTrucks(addressOfXMLwithTrucks);
        }

        /// <summary>
        /// Method CountTypes
        /// counts brands in stock
        /// </summary>
        /// <returns>count of brands</returns>

        override public int CountTypes()
        {
            //list which keep name of brands
            List<string> listOfBrands = new List<string>();
            foreach (Truck truck in recordsAboutTrucks)
            {
                if (listOfBrands.Contains(truck.Brand))
                {
                    continue;
                }
                else
                {
                    listOfBrands.Add(truck.Brand);
                }
            }
            return listOfBrands.Count;
        }

        /// <summary>
        /// Method CountAll
        /// counts all trucks in stock
        /// </summary>
        /// <returns>count of trucks in stock</returns>

        override public int CountAll()
        {
            int countOfTrucks = 0;
            foreach (Truck truck in recordsAboutTrucks)
            {
                countOfTrucks += truck.Count;
            }
            return countOfTrucks;
        }

        /// <summary>
        /// Method AveragePrice
        /// counts average price of all trucks in stock
        /// </summary>
        /// <returns>average price of all trucks in stock</returns>

        override public double AveragePrice()
        {
            double averagePriceOfTrucks = 0.0;
            int totalCostOfTrucks = 0;

            foreach (Truck truck in recordsAboutTrucks)
            {
                totalCostOfTrucks += truck.Cost * truck.Count;
            }
            averagePriceOfTrucks = totalCostOfTrucks / CountAll();
            return averagePriceOfTrucks;
        }

        /// <summary>
        /// Method AveragePriceOfBrand
        /// counts average price of trucks with certain brand
        /// </summary>
        /// <param name="brand">brand of truck 
        /// average price of which we want to count</param>
        /// <returns>average price of trucks with certain brand</returns>

        override public double AveragePriceOfBrand(string brand)
        {
            double averagePriceOfBrand = 0.0;
            int totalCostOfBrand = 0;
            int numberOfCarsOfThisBrand = 0;

            foreach (Truck truck in recordsAboutTrucks)
            {
                if (truck.Brand == brand)
                {
                    numberOfCarsOfThisBrand += truck.Count;
                    totalCostOfBrand += truck.Cost * truck.Count;
                }
            }
            averagePriceOfBrand = totalCostOfBrand / numberOfCarsOfThisBrand;
            return averagePriceOfBrand;
        }


        /// <summary>
        /// Method AddToStock
        /// adds trucks to list
        /// </summary>

        override public void AddToStock()
        {
            string brand = string.Empty;
            string model = string.Empty;
            int count;
            int cost;

            Printer printer = new Printer();

            // reads information about brand of truck
            printer.PrintFormForAdd("brand");
            brand = Console.ReadLine();

            // reads information about model of truck
            printer.PrintFormForAdd("model");
            model = Console.ReadLine();

            // reads information about count of trucks
            printer.PrintFormForAdd("count");
            count = int.Parse(Console.ReadLine());

            // reads information about cost of trucks
            printer.PrintFormForAdd("cost");
            cost = int.Parse(Console.ReadLine());

            Truck truck = new Truck(brand, model, count, cost);
            // add truck into list
            recordsAboutTrucks.Add(truck);

            Console.WriteLine("Truck is added");
        }

        /// <summary>
        /// Method PrintList
        /// prints information about all trucks in list
        /// </summary>

        override public void PrintList()
        {
            Printer printer = new Printer();
            printer.PrintList(recordsAboutTrucks);
        }
    }
}
