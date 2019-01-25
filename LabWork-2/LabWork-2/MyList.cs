using System;

namespace LabWork_2
{
    /// <summary>
    /// class MyList
    /// it is a double-linked list created by me
    /// </summary>
    public class MyList
    {
        // first node in list
        MyNode head;

        // last node in list
        MyNode last;

        // count of nodes in list
        int count;

        /// <summary>
        /// Method AddCar
        /// add object Car at the end of the list
        /// </summary>
        /// <param name="car">it is an object Car 
        /// which we want to add into list</param>
        
        public void AddCar(Car car)
        {
            //create a node whith data about car
            MyNode node = new MyNode(car);

            // if list is empty then
            // first element is node which was created
            // else
            // link "next" of the last node in list points to 
            // node which was created
            // and link "previous" of the node which was created 
            // points to last node in list
            if (head == null)
            {
                head = node;
            }
            else
            {
                last.next = node;
                node.previous = last;
            }

            //increase the count of the nodes for one
            count++;
            // now the last node in list
            // is node which was created
            last = node;
        }

        /// <summary>
        /// Method AddHead
        /// adds node to the top of the list
        /// </summary>
        /// <param name="car">it is an object Car 
        /// which we want to add to the top of the list</param>
        
        public void AddHead (Car car)
        {
            // create a node whith data about car
            MyNode node = new MyNode(car);

            // create a buffer node 
            // which keeps data about car int the first node
            MyNode buf = head;
            node.next = buf;
            head = node;
            if (count == 0)
            {
                last = head;
            }
            else
            {
                buf.previous = node;
            }
            count++;
        }

        /// <summary>
        /// Method SearchCar
        /// search cars with the same brand, model or color 
        /// and create new list with those cars
        /// </summary>
        /// <param name="car">object Car
        /// whose data we are looking for matches</param>
        /// <returns>new list with cars 
        /// whose data mathes with desired car</returns>
        
        public MyList SearchCar (Car car)
        {
            //new list with cars we are looking for
            MyList ListOfSearchCar = new MyList();

            //node with data about car which suitable
            MyNode needCar = new MyNode(null);
            needCar = head;

            //until we reach the end of the list
            while ( needCar != null)
            {
                //if car parameters are match up then
                //add this car into new list
                if (needCar.myCar.brand == car.brand || 
                    needCar.myCar.model == car.model ||
                    needCar.myCar.color == car.color)
                {
                    Car searchCar = new Car(needCar.myCar.model, needCar.myCar.brand, needCar.myCar.color);
                    ListOfSearchCar.AddCar(searchCar);
                }
                needCar = needCar.next;
            }
            return ListOfSearchCar;

        }

        /// <summary>
        /// Method PrintAll
        /// prints data about all cars in list
        /// </summary>
        
        public void PrintAll()
        {
            MyNode buf = new MyNode(null);
            buf = head;
            int counter = 1;
            while (buf != null)
            {
                PrintCar(buf, counter);
                counter++;
                buf = buf.next;
            }
        }

        /// <summary>
        /// Method PrintCar
        /// prints data about one car which needed
        /// </summary>
        /// <param name="car">we want 
        /// to print data about this car</param>
        
        public void PrintCar(Car car)
        {
            MyNode needCar = new MyNode(null);
            needCar = head;
            for (int i = 1; i <= count; i++)
            {
                if(needCar.myCar == car)
                {
                    PrintCar(needCar, i);
                    break;
                }
                needCar = needCar.next;
            }
        }

        /// <summary>
        /// Method PrintCar
        /// prints data about car in list
        /// </summary>
        /// <param name="needCar">node which keeps data about car</param>
        /// <param name="number">number of the node in list</param>
        private void PrintCar(MyNode needCar, int number)
        {
            Console.WriteLine("Element " + number + ": " + needCar.myCar.brand
                               + " " + needCar.myCar.model + " " + needCar.myCar.color);
        }
    }
}
