using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_5
{
    class Car
    {
        public string brand { get; set; }
        public string model { get; set; }
        public int count { get; set; }
        public int cost { get; set; }

        public Car() { }

        public Car (string brand, string model, int count, int cost)
        {
            this.brand = brand;
            this.model = model;
            this.count = count;
            this.cost = cost;
        }
    }
}
