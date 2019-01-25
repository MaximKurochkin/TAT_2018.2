using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork_3
{
    /// <summary>
    /// Interface ICreate
    /// creates triangles
    /// </summary>
    
    interface ICreate
    {
        /// <summary>
        /// Method CreateTriangle
        /// creates triangles
        /// </summary>
        /// <param name="point1">coordinates of the first point</param>
        /// <param name="point2">coordinates of the second point</param>
        /// <param name="point3">coordinates of the third point</param>
        /// <returns>suitble triangle</returns>
        
        Triangle CreateTrianngle(Point point1, Point point2, Point point3);
    }
}
