using System;
using System.Collections.Generic;


namespace DEV_5
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
            Console.WriteLine("add - to add record about car");
            Console.WriteLine("count types - to know number of car brands");
            Console.WriteLine("count all - to know total number of cars");
            Console.WriteLine("average price - to know averge cost of the car");
            Console.WriteLine("average price of brand - to know average cost of cars of a particular brand");
            Console.WriteLine("print - to print list of cars in stock");
            Console.WriteLine("? - display a list of available commands");
            Console.WriteLine("exit - exit the program");
        }

        /// <summary>
        /// Method PrintFormForAddCar
        /// to print string for getting information about car
        /// </summary>
        /// <param name="paramOfCar">brand, model, count or cost</param>

        public void PrintFormForAddCar(string paramOfCar)
        {
            Console.WriteLine("Please, enter a " + paramOfCar);
        }

        /// <summary>
        /// Method PrintInfAboutCar
        /// to print information about car
        /// </summary>
        /// <param name="car">information about this car will be printed</param>

        public void PrintInfAboutCar (Car car)
        {
            Console.WriteLine("Brand: " + car.brand + "    model: " + car.model + "   count: " + car.count + "    cost: " + car.cost + " $");
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
    }
}
