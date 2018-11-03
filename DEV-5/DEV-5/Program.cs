using System;


namespace DEV_5
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string userInput = string.Empty;
                Printer printer = new Printer();

                Stock stock = new Stock();
                Manager manager = new Manager();

                printer.PrintMenu();

                bool isWork = true;

                while (isWork)
                {
                    userInput = Console.ReadLine();

                    switch (userInput)
                    {
                        case "count types":
                            manager.SetCommand(new CountTypes());
                            manager.CountTypes(stock);
                            break;

                        case "count all":
                            manager.SetCommand(new CountAll());
                            manager.CountAll(stock);
                            break;

                        case "average price":
                            manager.SetCommand(new AveragePrice());
                            manager.AveragePrice(stock);
                            break;

                        case "average price of brand":
                            manager.SetCommand(new AveragePriceOfBrand());
                            manager.AveragePriceOfBrand(stock);
                            break;

                        case "print":
                            manager.SetCommand(new ContentsOfStock());
                            manager.ContentsOfStock(stock);
                            break;

                        case "add":
                            manager.SetCommand(new AddToStock());
                            manager.AddToStock(stock);
                            break;

                        case "?":
                            printer.PrintMenu();
                            break;

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
