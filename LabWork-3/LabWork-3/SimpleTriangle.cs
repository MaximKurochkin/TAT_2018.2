using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork_3
{
    class SimpleTriangle : Triangle
    {
        double length1;
        double length2;
        double length3;

        public SimpleTriangle(double length1, double length2, double length3)
        {
            this.length1 = length1;
            this.length2 = length2;
            this.length3 = length3;
        }

        override
        public double GetSquare()
        {
            double square = 0;
            double halfOfPerimeter = 0;
            halfOfPerimeter = (length1 + length2 + length3) / 2;
            square = Math.Sqrt(halfOfPerimeter * (halfOfPerimeter - length1) * (halfOfPerimeter - length2) * (halfOfPerimeter - length3));
            return square;
        }
    }
}
