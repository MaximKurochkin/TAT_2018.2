using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LabWork_3
{
    /// <summary>
    /// Class RightTriangleBuilder
    /// heir of class TriangleBuilder
    /// creates right triangle
    /// </summary>
    
    class RightTriangleBuilder : TriangleBuilder
    {
        /// <summary>
        /// Method RightTriangleBuilder
        /// create RightTriangleBuilder
        /// if data is suitable
        /// or transfer data to another Builder
        /// </summary>
        /// <param name="next"> link to the next Builder (EquilTriangleBuilder)</param>
        
        public RightTriangleBuilder(TriangleBuilder next)
        {
            this.next = next;
        }

        public override Triangle CreateTrianngle(Point point1, Point point2, Point point3)
        {
            bool triangleIsRight = false;

            Length length = new Length();
            double length1 = length.GetLength(point1, point2);
            double length2 = length.GetLength(point2, point3);
            double length3 = length.GetLength(point3, point1);
            //Console.WriteLine(length1 + " " + length2 + " " + length3);
            if((length1+length2 - length3 < FAULT) || (length2 + length3 - length2 < FAULT) || (length1 + length3 - length2 < FAULT))
            {
                throw new Exception("Triangle doesn't exist");
            }

            if (Math.Pow(length1, 2) + Math.Pow(length2, 2) - Math.Pow(length3, 2) < FAULT)
            {
                triangleIsRight = true;
            }
            if (Math.Pow(length2, 2) + Math.Pow(length3, 2) - Math.Pow(length1, 2) < FAULT)
            {
                triangleIsRight = true;
            }
            if (Math.Pow(length3, 2) + Math.Pow(length1, 2) - Math.Pow(length2, 2) < FAULT )
            {
                triangleIsRight = true;
            }

            if (triangleIsRight == true)
            {
                return new RightTriangle(length1, length2, length3);
            }
            else
            {
                next.CreateTrianngle(point1, point2, point3);
            }
            return null;
        }
    }
}
