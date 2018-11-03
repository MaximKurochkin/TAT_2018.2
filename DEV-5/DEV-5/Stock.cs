using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_5
{
    class Stock
    {
        private List<Car> recordsAboutObject = new List<Car>();

        public Stock()
        {
            ConvertFileIntoStrings converter = new ConvertFileIntoStrings("D:\\MyPrograms\\Courses\\HomeTasks\\DEV-1\\DEV-5\\Cars.txt");
            string[] FileInStrings = converter.FileInStrings;

            int index = 0;

            StringBuilder brand = new StringBuilder();
            StringBuilder model = new StringBuilder();
            StringBuilder count = new StringBuilder();
            StringBuilder cost = new StringBuilder();

            foreach (string currentStr in FileInStrings)
            {

                while (currentStr[index] != ' ')
                {
                    brand.Append(currentStr[index]);
                    index++;
                }

                while (currentStr[index] == ' ')
                {
                    index++;
                }

                while (currentStr[index] != ' ')
                {
                    model.Append(currentStr[index]);
                    index++;
                }

                while (currentStr[index] == ' ')
                {
                    index++;
                }

                while (currentStr[index] != ' ')
                {
                    count.Append(currentStr[index]);
                    index++;
                }

                while (currentStr[index] == ' ')
                {
                    index++;
                }

                while (currentStr[index] != ' ')
                {
                    cost.Append(currentStr[index]);
                    index++;
                }

                Car car = new Car(brand.ToString(), model.ToString(), int.Parse(count.ToString()), int.Parse(cost.ToString()));
                recordsAboutObject.Add(car);

                index = 0;
                brand.Clear();
                model.Clear();
                count.Clear();
                cost.Clear();
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

        public void CountAll()
        {

        }

        public void AveragePrice()
        {

        }

        public void AveragePrice(string type)
        {

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
            foreach (Car car in recordsAboutObject)
            {
                printer.PrintInfAboutCar(car);
            }

        }
    }
}
