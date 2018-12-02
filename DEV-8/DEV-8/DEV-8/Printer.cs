using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_8
{
    /// <summary>
    /// class Printer
    /// print some information to the console
    /// </summary>

    class Printer
    {
        /// <summary>
        /// Method PrintMenu
        /// print available commands to the console
        /// </summary>

        public void PrintMenu()
        {
            Console.WriteLine("Enter the comand:");
            Console.WriteLine("add car(truck) - to add record about car");
            Console.WriteLine("count types car(truck) - to know number of car brands");
            Console.WriteLine("count all car(truck) - to know total number of cars");
            Console.WriteLine("average price car(truck) - to know averge cost of the car");
            Console.WriteLine("average price of brand car(truck) - to know average cost of cars of a particular brand");
            Console.WriteLine("print car(truck) - to print list of cars in stock");
            Console.WriteLine("execute - to execute all commands entered");
            Console.WriteLine("? - display a list of available commands");
            Console.WriteLine("exit - exit the program");
        }

        /// <summary>
        /// Method PrintFormForAdd
        /// to print string for getting information about car or truck
        /// </summary>
        /// <param name="paramOfCar">brand, model, count or cost</param>

        public void PrintFormForAdd(string paramOfCar)
        {
            Console.WriteLine("Please, enter a " + paramOfCar);
        }

        /// <summary>
        /// Method PrintInfAboutCar
        /// to print information about car
        /// </summary>
        /// <param name="car">information about this car will be printed</param>

        public void PrintInfAboutCar(Car car)
        {
            Console.WriteLine("Brand: " + car.Brand + "    model: " + car.Model + "   count: " + car.Count + "    cost: " + car.Cost + " $");
        }

        /// <summary>
        /// Method PrintInfAboutTruck
        /// to print information about truck
        /// </summary>
        /// <param name="car">information about this truck will be printed</param>
        
        public void PrintInfAboutTruck(Truck truck)
        {
            Console.WriteLine("Brand: " + truck.Brand + "    model: " + truck.Model + "   count: " + truck.Count + "    cost: " + truck.Cost + " $");
        }

        /// <summary>
        /// Method PrintList
        /// to print information about all cars in stock
        /// </summary>
        /// <param name="records">list with cars</param>

        public void PrintList(List<Car> records)
        {
            Printer printer = new Printer();
            foreach (Car car in records)
            {
                printer.PrintInfAboutCar(car);
            }
        }

        /// <summary>
        /// Method PrintList
        /// to print information about all trucks in stock
        /// </summary>
        /// <param name="records">list with trucks</param>
        
        public void PrintList(List<Truck> records)
        {
            Printer printer = new Printer();
            foreach (Truck truck in records)
            {
                printer.PrintInfAboutTruck(truck);
            }
        }
    }
}
