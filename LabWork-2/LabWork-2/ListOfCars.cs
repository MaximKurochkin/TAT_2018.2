using System;


namespace LabWork_2
{
    /// <summary>
    /// Class ListOfCars
    /// In this program was created list MyList
    /// for objects Car
    /// </summary>
 
    class ListOfCars
    {
        // entery point
        static void Main()
        {
            try
            {
                Car number1 = new Car("X5", "BMW", "Black");
                Car number2 = new Car("RX-8", "Mazda", "Red");
                Car number3 = new Car("Enzo", "Ferrari", "Yellow");
                Car number4 = new Car("Corvet", "Chevrolet", "Black");
                Car number5 = new Car("Sandero", "Reno", "Black");
                Car number6 = new Car("Camri", "Toyota", "Green");

                MyList list = new MyList();

                list.AddCar(number1);
                list.AddCar(number2);
                list.AddCar(number3);
                list.AddCar(number4);
                list.AddCar(number5);
                list.AddCar(number6);

                MyList newList = new MyList();
                //searching cars with the same Brand, Model or Color 
                newList = list.SearchCar(number1); 
                newList.PrintAll();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           
            Console.ReadKey();
        }
    }
}
