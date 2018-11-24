using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork_3
{
    /// <summary>
    /// Class EntryPoint
    /// entery point into programm,
    /// that calculate square of triangle,
    /// created by user
    /// </summary>
    
    class EntryPoint
    {
        /// <summary>
        /// Method Main
        /// entery point
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            try
            {
                //get points coordinates from user
                Menu menu = new Menu();
                Point[] points = new Point[3];
                points = menu.GetPoints();

                //create suitable triangle and calculate square
                TriangleBuilder triangleBuilder = new RightTriangleBuilder(new EquilTriangleBuilder(new SimpleTriangleBuilder(null)));
                Triangle triangle = triangleBuilder.CreateTrianngle(points[0], points[1], points[2]);
                double square = triangle.GetSquare();
                menu.PrintSquare(square);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
