using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_5
{
    class Printer
    {
        public void PrintMenu()
        {
            Console.WriteLine("Enter the comand:");
            Console.WriteLine("add - to add record about car");
            Console.WriteLine("count types - to know number of car brands");
            Console.WriteLine("count all - to know total number of cars");
            Console.WriteLine("average price - to know averge cost of the car");
            Console.WriteLine("average price: - to know average cost of cars of a particular brand");
        }

        public void PrintFormForAddCar(string paramOfCar)
        {
            Console.WriteLine("Please, enter a " + paramOfCar);
        }

        public void PrintInfAboutCar (Car car)
        {
            Console.WriteLine("Brand: " + car.brand + "    model: " + car.model + "   count: " + car.count + "    cost: " + car.cost + " $");
        }

        public void PrintList(List<Car> records)
        {
            Printer printer = new Printer();
            foreach (Car car in records)
            {
                printer.PrintInfAboutCar(car);
            }
        }
    }
}
