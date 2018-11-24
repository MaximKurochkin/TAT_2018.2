using System;


namespace LabWork_3
{
    class Length
    {
        public double GetLength(Point point1, Point point2)
        {
            double deltaX = point2.x - point1.x;
            double deltaY = point2.y - point1.y;
            double length = Math.Sqrt(Math.Pow(deltaX,2) +Math.Pow(deltaY,2));
            return length;
        }
    }
}
