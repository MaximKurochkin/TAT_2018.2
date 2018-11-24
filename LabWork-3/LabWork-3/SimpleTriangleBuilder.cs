using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork_3
{
    class SimpleTriangleBuilder : TriangleBuilder
    {
        public SimpleTriangleBuilder(TriangleBuilder next)
        {
            this.next = next;
        }

        public override Triangle CreateTrianngle(Point point1, Point point2, Point point3)
        {
            bool triangleIsSimple = true;

            Length length = new Length();
            double length1 = length.GetLength(point1, point2);
            double length2 = length.GetLength(point2, point3);
            double length3 = length.GetLength(point3, point1);

            if (point1.x - point2.x < FAULT && point2.x - point3.x < FAULT)
            {
                triangleIsSimple = false;
            }
            if (point1.y - point2.y < FAULT && point2.y - point3.y < FAULT)
            {
                triangleIsSimple = false;
            }

            if (triangleIsSimple == true)
            {
                Console.WriteLine("Simple triangle is created");
                
                return new SimpleTriangle(length1, length2, length3);
            }
            else
            {
                return null;
            }
        }
    }
}
