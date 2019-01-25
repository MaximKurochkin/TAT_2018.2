using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LabWork_3
{
    /// <summary>
    /// Class Menu
    /// prints form for enter points
    /// and returns array of points
    /// </summary>
    
    class Menu
    {
        /// <summary>
        /// Method GetPoints
        /// prints form for enter points
        /// and returns array of points
        /// </summary>
        /// <returns>array of points</returns>
        public Point[] GetPoints()
        {
            Point[] points;
            points = new Point[3];
            int counter = 0;
            string[] numberOfCoordinate = { "first", "second", "third"};
            // validation string pattern
            // (coordinates can not to contain letters)
            string pattern = @"[a-y]|[A-Y]";

            int amountOfPoints = 3;
            while ( counter != amountOfPoints)
            {
                Console.WriteLine("Please, enter " + numberOfCoordinate[counter] + " coordinate:");
                Console.Write("x=");
                string coordX = Console.ReadLine();
                // coordinate(X) check
                if (Regex.IsMatch(coordX, pattern, RegexOptions.IgnoreCase))
                {
                    throw new Exception("Number contains forbidden symbols!");
                }
                double x = double.Parse(coordX);

                Console.Write("y=");
                string coordY = Console.ReadLine();
                // coordinate(Y) check
                if (Regex.IsMatch(coordX, pattern, RegexOptions.IgnoreCase))
                {
                    throw new Exception("Number contains forbidden symbols!");
                }
                double y = double.Parse(coordX);

                points[counter].x = x;
                points[counter].y = y;
                counter++;
            }      
            
            // if all points placed on the line
            // then we cant create triangle
            if ( ((Math.Abs(points[0].x - points[1].x) < 10E-4) && (Math.Abs(points[0].y - points[1].y) < 10E-4)) ||
                 ((Math.Abs(points[1].x - points[2].x) < 10E-4) && (Math.Abs(points[1].y - points[2].y) < 10E-4)) ||
                 ((Math.Abs(points[2].x - points[0].x) < 10E-4) && (Math.Abs(points[2].y - points[0].y) < 10E-4)))
            {
                throw new Exception("Points should be in different places");
            } 
            return points;
        }

        public void PrintSquare(double square)
        {
            Console.WriteLine("The square of treangel is " + square);
        }
    }
}
