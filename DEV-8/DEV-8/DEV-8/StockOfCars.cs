using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_8
{
    /// <summary>
    /// Class Stock
    /// storage in which we keep cars
    /// </summary>

    class StockOfCars : Stock
    {
        //list with cars
        private List<Car> recordsAboutCars = new List<Car>();

        /// <summary>
        /// Method Stock
        /// constructor for object Stock
        /// which get information from txt-file
        /// </summary>

        public StockOfCars(string addressOfXMLwithCars)
        {
            XMLParser parser = new XMLParser();
            recordsAboutCars = parser.ToParseXMLWithCars(addressOfXMLwithCars);
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
            foreach (Car car in recordsAboutCars)
            {
                if (listOfBrands.Contains(car.Brand))
                {
                    continue;
                }
                else
                {
                    listOfBrands.Add(car.Brand);
                }
            }
            return listOfBrands.Count;
        }

        /// <summary>
        /// Method CountAll
        /// counts all cars in stock
        /// </summary>
        /// <returns>count of cars in stock</returns>

        override public int CountAll()
        {
            int countOfCars = 0;
            foreach (Car car in recordsAboutCars)
            {
                countOfCars += car.Count;
            }
            return countOfCars;
        }

        /// <summary>
        /// Method AveragePrice
        /// counts average price of all cars in stock
        /// </summary>
        /// <returns>average price of all cars in stock</returns>

        override public double AveragePrice()
        {
            double averagePriceOfCars = 0.0;
            int totalCostOfCars = 0;

            foreach (Car car in recordsAboutCars)
            {
                totalCostOfCars += car.Cost * car.Count;
            }
            averagePriceOfCars = totalCostOfCars / CountAll();
            return averagePriceOfCars;
        }

        /// <summary>
        /// Method AveragePriceOfBrand
        /// counts average price of cars with certain brand
        /// </summary>
        /// <param name="brand">brand of car 
        /// average price of which we want to count</param>
        /// <returns>average price of cars with certain brand</returns>

        override public double AveragePriceOfBrand(string brand)
        {
            double averagePriceOfBrand = 0.0;
            int totalCostOfBrand = 0;
            int numberOfCarsOfThisBrand = 0;

            foreach (Car car in recordsAboutCars)
            {
                if (car.Brand == brand)
                {
                    numberOfCarsOfThisBrand += car.Count;
                    totalCostOfBrand += car.Cost * car.Count;
                }
            }
            averagePriceOfBrand = totalCostOfBrand / numberOfCarsOfThisBrand;
            return averagePriceOfBrand;
        }


        /// <summary>
        /// Method AddToStock
        /// adds cars to list
        /// </summary>

        override public void AddToStock()
        {
            string brand = string.Empty;
            string model = string.Empty;
            int count;
            int cost;

            Printer printer = new Printer();

            // reads information about brand of car
            printer.PrintFormForAdd("brand");
            brand = Console.ReadLine();

            // reads information about model of car
            printer.PrintFormForAdd("model");
            model = Console.ReadLine();

            // reads information about count of cars
            printer.PrintFormForAdd("count");
            count = int.Parse(Console.ReadLine());

            // reads information about cost of car
            printer.PrintFormForAdd("cost");
            cost = int.Parse(Console.ReadLine());

            Car car = new Car(brand, model, count, cost);
            // add car into list
            recordsAboutCars.Add(car);

            Console.WriteLine("Car is added");
        }

        /// <summary>
        /// Method PrintList
        /// prints information about all cars in list
        /// </summary>

        override public void PrintList()
        {
            Printer printer = new Printer();
            printer.PrintList(recordsAboutCars);
        }
    }
}
