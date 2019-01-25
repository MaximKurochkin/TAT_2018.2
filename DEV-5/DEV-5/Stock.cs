using System;
using System.Collections.Generic;
using System.Text;

namespace DEV_5
{
    /// <summary>
    /// Class Stock
    /// storage in which we keep cars
    /// </summary>
    
    class Stock
    {
        //list with cars
        private List<Car> recordsAboutObject = new List<Car>();

        //index of string from txt-file
        private int index = 0;

        /// <summary>
        /// Method Stock
        /// constructor for object Stock
        /// which get information from txt-file
        /// </summary>
        
        public Stock()
        {
            //converts file-txt into array of string
            ConvertFileIntoStrings converter = new ConvertFileIntoStrings("D:\\MyPrograms\\Courses\\HomeTasks\\DEV-1\\DEV-5\\Cars.txt");
            string[] FileInStrings = converter.FileInStrings;

            string brand = string.Empty;
            string model = string.Empty;
            int count = 0;
            int cost = 0;

            foreach (string currentStr in FileInStrings)
            {
                //reads information about brand of car
                brand = DataReadout(currentStr);

                //skips spaces in string
                SkipSpaces(currentStr);

                //reads information about model of car
                model = DataReadout(currentStr);

                //skips spaces in string
                SkipSpaces(currentStr);

                //reads information about count of cars
                count = int.Parse(DataReadout(currentStr));

                //skips spaces in string
                SkipSpaces(currentStr);

                //reads information about cost of car
                cost = int.Parse(DataReadout(currentStr));

                Car car = new Car(brand, model, count, cost);
                //add car into list
                recordsAboutObject.Add(car);

                index = 0;
            }
        }

        /// <summary>
        /// Method CountTypes
        /// counts brands in stock
        /// </summary>
        /// <returns>count of brands</returns>
        
        public int CountTypes()
        {
            //list which keep name of brands
            List<string> listOfBrands = new List<string>();
            foreach(Car car in recordsAboutObject)
            {
                if (listOfBrands.Contains(car.brand))
                {
                    continue;
                }
                else
                {
                    listOfBrands.Add(car.brand);
                }
            }
            return listOfBrands.Count;
        }

        /// <summary>
        /// Method CountAll
        /// counts all cars in stock
        /// </summary>
        /// <returns>count of cars in stock</returns>
        
        public int CountAll()
        {
            int countOfCars = 0;
            foreach (Car car in recordsAboutObject)
            {
                countOfCars += car.count;
            }
            return countOfCars;
        }

        /// <summary>
        /// Method AveragePrice
        /// counts average price of all cars in stock
        /// </summary>
        /// <returns>average price of all cars in stock</returns>
        
        public double AveragePrice()
        {
            double averagePriceOfCars = 0.0;
            int totalCostOfCars = 0;

            foreach (Car car in recordsAboutObject)
            {
                totalCostOfCars += car.cost;
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
        
        public double AveragePriceOfBrand(string brand)
        {
            double averagePriceOfBrand = 0.0;
            int totalCostOfBrand = 0;
            int numberOfCarsOfThisBrand = 0;

            foreach (Car car in recordsAboutObject)
            {
                if(car.brand == brand)
                {
                    numberOfCarsOfThisBrand += car.count;
                    totalCostOfBrand += car.cost * car.count;
                }
            }
            averagePriceOfBrand = totalCostOfBrand / numberOfCarsOfThisBrand;
            return averagePriceOfBrand;
        }


        /// <summary>
        /// Method AddToStock
        /// adds cars to list
        /// </summary>
        
        public void AddToStock()
        {
            string brand = string.Empty;
            string model = string.Empty;
            int count;
            int cost;

            Printer printer = new Printer();

            // reads information about brand of car
            printer.PrintFormForAddCar("brand");
            brand = Console.ReadLine();

            // reads information about model of car
            printer.PrintFormForAddCar("model");
            model = Console.ReadLine();

            // reads information about count of cars
            printer.PrintFormForAddCar("count");
            count = int.Parse(Console.ReadLine());

            // reads information about cost of car
            printer.PrintFormForAddCar("cost");
            cost = int.Parse(Console.ReadLine());

            Car car = new Car(brand, model, count, cost);
            // add car into list
            recordsAboutObject.Add(car);

            Console.WriteLine("Car is added");
        }

        /// <summary>
        /// Method PrintList
        /// prints information about all cars in list
        /// </summary>
        
        public void PrintList()
        {
            Printer printer = new Printer();
            printer.PrintList(recordsAboutObject);
        }

        /// <summary>
        /// Method SkipSpaces
        /// skips spaces in string
        /// </summary>
        /// <param name="str">string in which we need to skip spaces</param>
        /// <returns>character index that is not a space</returns>

        private int SkipSpaces(string str)
        {
            while (str[index] == ' ')
            {
                index++;
            }
            return index;
        }

        /// <summary>
        /// Method DataReadout
        /// reads data about car
        /// </summary>
        /// <param name="str">sring with information about car</param>
        /// <returns>string with data about car</returns>

        private string DataReadout (string str)
        {
            StringBuilder data = new StringBuilder();
            while (str[index] != ' ')
            {
                data.Append(str[index]);
                index++;
            }
            return data.ToString();
        }
    }
}
