using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_8
{
    /// <summary>
    /// Class Menu
    /// print information on console
    /// and gets commands from user
    /// </summary>
    
    class Menu
    {
        /// <summary>
        /// Method CallMenu
        /// print menu on console
        /// and gets commands from user
        /// </summary>
        /// <param name="stockOfCars">stock with cars</param>
        /// <param name="stockOfTrucks">strick with trucks</param>
        
        public void CallMenu (StockOfCars stockOfCars, StockOfTrucks stockOfTrucks)
        {
            string userInput = string.Empty;
            Printer printer = new Printer();
            //create a list with commands called
            List<ICommand> commandsForCars = new List<ICommand>();
            List<ICommand> commandsForTrucks = new List<ICommand>();
            ICommand command;

            // to print available commands
            printer.PrintMenu();

            // responsible for exiting the program
            bool isWork = true;

            while (isWork)
            {
                userInput = Console.ReadLine();

                switch (userInput)
                {
                    //to execute all commands called
                    case "execute":
                        foreach (ICommand com in commandsForCars)
                        {
                            com.Execute(stockOfCars);
                        }
                        foreach (ICommand com in commandsForTrucks)
                        {
                            com.Execute(stockOfTrucks);
                        }
                        commandsForCars.Clear();
                        commandsForTrucks.Clear();
                        break;
                    // to know number of car brands
                    case "count types car":
                        command = new CountTypes();
                        commandsForCars.Add(command);
                        break;

                    // to know total number of cars
                    case "count all car":
                        command = new CountAll();
                        commandsForCars.Add(command);
                        break;

                    // to know averge cost of the car
                    case "average price car":
                        command = new AveragePrice();
                        commandsForCars.Add(command);
                        break;

                    //to know average cost of cars of a particular brand
                    case "average price of brand car":
                        command = new AveragePriceOfBrand();
                        commandsForCars.Add(command);
                        break;

                    //to print list of cars in stock
                    case "print car":
                        command = new ContentsOfStock();
                        commandsForCars.Add(command);
                        break;

                    //to add record about car
                    case "add car":
                        command = new AddToStock();
                        commandsForCars.Add(command);
                        break;

                    // to know number of truck brands
                    case "count types truck":
                        command = new CountTypes();
                        commandsForTrucks.Add(command);
                        break;

                    // to know total number of trucks
                    case "count all truck":
                        //manager.SetCommand(new CountAll());
                        //manager.CountAll(stockOfTrucks);
                        command = new CountAll();
                        commandsForTrucks.Add(command);
                        break;

                    // to know averge cost of the truck
                    case "average price truck":
                        command = new AveragePrice();
                        commandsForTrucks.Add(command);
                        break;

                    //to know average cost of trucks of a particular brand
                    case "average price of brand truck":
                        command = new AveragePriceOfBrand();
                        commandsForTrucks.Add(command);
                        break;

                    //to print list of trucks in stock
                    case "print truck":
                        command = new ContentsOfStock();
                        commandsForTrucks.Add(command);
                        break;

                    //to add record about truck
                    case "add truck":
                        command = new AddToStock();
                        commandsForTrucks.Add(command);
                        break;

                    //display a list of available commands
                    case "?":
                        printer.PrintMenu();
                        break;

                    //exit the program
                    case "exit":
                        isWork = false;
                        break;

                    default:
                        Console.WriteLine("Command doesn't exist or entered incorrectly");
                        Console.WriteLine("Please, try again");
                        break;
                }
            }
        }
    }
}
