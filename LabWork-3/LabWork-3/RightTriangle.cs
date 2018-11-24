using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork_3
{
    /// <summary>
    /// Class RightTriangle
    /// counts the area og right triangle
    /// </summary>
    
    class RightTriangle : Triangle
    {
        double length1;
        double length2;
        double length3;

        /// <summary>
        /// Method RightTriangle
        /// it is a constructor
        /// </summary>
        /// <param name="length1">length between first point and second</param>
        /// <param name="length2">length between second point and third</param>
        /// <param name="length3">length between first point and third</param>
        
        public RightTriangle(double length1, double length2, double length3)
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
            // Heron's formula for calculating area
            halfOfPerimeter = (length1 + length2 + length3)/2;
            square = Math.Sqrt(halfOfPerimeter * (halfOfPerimeter - length1) * (halfOfPerimeter - length2) * (halfOfPerimeter - length3));
            return square;
        }
    }
}
