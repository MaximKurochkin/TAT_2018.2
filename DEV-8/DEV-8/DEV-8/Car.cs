using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_8
{
    /// <summary>
    /// Class Car
    /// contains information about object Car
    /// </summary>

    class Car
    {
        //brand of car
        public string Brand { get; set; }

        //model of car
        public string Model { get; set; }

        //number of cars with same brand and model
        public int Count { get; set; }

        //cost of car
        public int Cost { get; set; }

        /// <summary>
        /// Method Car
        /// it is a constructor without parameters
        /// </summary>

        public Car() { }

        /// <summary>
        /// Method Car
        /// it is a constructor with parameters
        /// </summary>

        public Car(string brand, string model, int count, int cost)
        {
            Brand = brand;
            Model = model;
            Count = count;
            Cost = cost;
        }
    }
}
