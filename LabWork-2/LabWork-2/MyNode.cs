

namespace LabWork_2
{
    /// <summary>
    /// Class MyNode
    /// it is an element of list in which keeping data about car, 
    /// link to the next element and to the previous element
    /// </summary>
    
     class MyNode
    {
        //method for keeping data about car
        public MyNode (Car car)
        {
            myCar = car;
        }

        //is a data about car which keep in node
        //(getter and setter are created automaticaly)
        public Car myCar { get; set; }

        //link to the previous node
        public MyNode previous { get; set; }

        //link to the next node
        public MyNode next { get; set; }
    }
}

