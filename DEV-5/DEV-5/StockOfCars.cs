using System;


namespace DEV_5
{
    /// <summary>
    /// Class StockOfCars
    /// Allows to add cars to stock
    /// </summary>
    
     
    class StockOfCars
    {
        /// <summary>
        /// Method Main
        /// entery point
        /// </summary>
        
        static void Main()
        {
            try
            {
                string userInput = string.Empty;
                Printer printer = new Printer();

                Stock stock = new Stock();
                Manager manager = new Manager();

                // to print available commands
                printer.PrintMenu();

                // responsible for exiting the program
                bool isWork = true;

                while (isWork)
                {
                    userInput = Console.ReadLine();

                    switch (userInput)
                    {
                        // to know number of car brands
                        case "count types":
                            manager.SetCommand(new CountTypes());
                            manager.CountTypes(stock);
                            break;

                        // to know total number of cars
                        case "count all":
                            manager.SetCommand(new CountAll());
                            manager.CountAll(stock);
                            break;

                        // to know averge cost of the car
                        case "average price":
                            manager.SetCommand(new AveragePrice());
                            manager.AveragePrice(stock);
                            break;

                        //to know average cost of cars of a particular brand
                        case "average price of brand":
                            manager.SetCommand(new AveragePriceOfBrand());
                            manager.AveragePriceOfBrand(stock);
                            break;

                        //to print list of cars in stock
                        case "print":
                            manager.SetCommand(new ContentsOfStock());
                            manager.ContentsOfStock(stock);
                            break;

                        //to add record about car
                        case "add":
                            manager.SetCommand(new AddToStock());
                            manager.AddToStock(stock);
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
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
