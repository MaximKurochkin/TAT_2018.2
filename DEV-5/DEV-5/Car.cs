

namespace DEV_5
{
    /// <summary>
    /// Class Car
    /// contains information about object Car
    /// </summary>

    class Car
    {
        //brand of car
        public string brand { get; set; }

        //model of car
        public string model { get; set; }

        //number of cars with same brand and model
        public int count { get; set; }

        //cost of car
        public int cost { get; set; }

        /// <summary>
        /// Method Car
        /// it is a constructor without parameters
        /// </summary>

        public Car() { }

        /// <summary>
        /// Method Car
        /// it is a constructor with parameters
        /// </summary>

        public Car (string brand, string model, int count, int cost)
        {
            this.brand = brand;
            this.model = model;
            this.count = count;
            this.cost = cost;
        }
    }
}
