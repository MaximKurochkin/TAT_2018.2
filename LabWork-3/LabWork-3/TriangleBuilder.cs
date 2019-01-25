using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork_3
{
    /// <summary>
    /// Class TriangleBuilder
    /// inherits interface ICreate
    /// it is a parent for RightTriangleBuilder,
    /// EquilTriangleBuilder, SimpleTriangleBuilder
    /// </summary>
    
    abstract class TriangleBuilder : ICreate
    {
        // object reference, which we need to crate
        public TriangleBuilder next;

        //fault 
        public const double FAULT = 10E-5;

        /// <summary>
        /// Method CreateTriangle
        /// implemented in the class heirs
        /// </summary>
        /// <param name="point1">coordinates of the first point</param>
        /// <param name="point2">coordinates of the second point</param>
        /// <param name="poin3">coordinates of the third point</param>
        /// <returns>suitable triangle</returns>
        
        public virtual Triangle CreateTrianngle(Point point1, Point point2, Point poin3)
        { 
            return null;
        }
    }
}
