using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_8
{
    class Truck
    {
        //brand of truck
        public string Brand { get; set; }

        //model of truck
        public string Model { get; set; }

        //number of trucks with same brand and model
        public int Count { get; set; }

        //cost of truck
        public int Cost { get; set; }

        /// <summary>
        /// Method Truck
        /// it is a constructor without parameters
        /// </summary>

        public Truck() { }

        /// <summary>
        /// Method Truck
        /// it is a constructor with parameters
        /// </summary>

        public Truck(string brand, string model, int count, int cost)
        {
            Brand = brand;
            Model = model;
            Count = count;
            Cost = cost;
        }
    }
}
