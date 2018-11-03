using System;
using System.Collections.Generic;
using System.Text;

namespace DEV_5
{
    class Stock
    {
        private List<Car> recordsAboutObject = new List<Car>();
        private int index = 0;

        public Stock()
        {
            ConvertFileIntoStrings converter = new ConvertFileIntoStrings("D:\\MyPrograms\\Courses\\HomeTasks\\DEV-1\\DEV-5\\Cars.txt");
            string[] FileInStrings = converter.FileInStrings;

            string brand = string.Empty;
            string model = string.Empty;
            int count = 0;
            int cost = 0;

            foreach (string currentStr in FileInStrings)
            {

                brand = DataReadout(currentStr);

                SkipSpaces(currentStr);

                model = DataReadout(currentStr);

                SkipSpaces(currentStr);

                count = int.Parse(DataReadout(currentStr));

                SkipSpaces(currentStr);

                cost = int.Parse(DataReadout(currentStr));

                Car car = new Car(brand, model, count, cost);
                recordsAboutObject.Add(car);

                index = 0;
            }
        }

        public int CountTypes()
        {
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

        public int CountAll()
        {
            int countOfCars = 0;
            foreach (Car car in recordsAboutObject)
            {
                countOfCars += car.count;
            }
            return countOfCars;
        }

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

        public void AddToStock()
        {
            string brand = string.Empty;
            string model = string.Empty;
            int count;
            int cost;

            Printer printer = new Printer();

            printer.PrintFormForAddCar("brand");
            brand = Console.ReadLine();

            printer.PrintFormForAddCar("model");
            model = Console.ReadLine();

            printer.PrintFormForAddCar("count");
            count = int.Parse(Console.ReadLine());

            printer.PrintFormForAddCar("cost");
            cost = int.Parse(Console.ReadLine());

            Car car = new Car(brand, model, count, cost);
            recordsAboutObject.Add(car);

            Console.WriteLine("Car is added");
        }

        public void PrintList()
        {
            Printer printer = new Printer();
            printer.PrintList(recordsAboutObject);
        }

        private int SkipSpaces(string str)
        {
            while (str[index] == ' ')
            {
                index++;
            }
            return index;
        }

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
