using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork_3
{
    /// <summary>
    /// Class EquilTriangleBuilder
    /// heir of class TriangleBuilder
    /// creates equilaterial triangle
    /// </summary>
    
    class EquilTriangleBuilder : TriangleBuilder
    {
        /// <summary>
        /// Method EquilTriangleBuilder
        /// create EquilaterialTriangleBuilder
        /// if data is suitable
        /// or transfer data to another Builder
        /// </summary>
        /// <param name="next"> link to the next Builder (SimpleTriangleBuilder)</param>
        
        public EquilTriangleBuilder(TriangleBuilder next)
        {
            this.next = next;
        }

        public override Triangle CreateTrianngle(Point point1, Point point2, Point point3)
        {
            bool triangleIsEquilaterial = false;

            Length length = new Length();
            double length1 = length.GetLength(point1, point2);
            double length2 = length.GetLength(point2, point3);
            double length3 = length.GetLength(point3, point1);

            if (length1 - length2 < FAULT && length2 - length3 < FAULT) triangleIsEquilaterial = true;
            

            if (triangleIsEquilaterial == true)
            {
                Console.WriteLine("Equil triangle is created");
                return new EquilaterialTriangle(length1, length2,length3);
            }
            else
            {
                return next.CreateTrianngle(point1, point2, point3);
            }
        }
    }
}
