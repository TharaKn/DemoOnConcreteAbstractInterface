﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polygons.Library
{
    public class ConcreteRegularPolygon 
    {
        

        public int NumberOfSides { get; set ; }
        public int SideLength { get; set; }

        public ConcreteRegularPolygon(int sides, int length)
        {
            NumberOfSides = sides;
            SideLength = length;
        }

        /// <summary>
        /// Gets perimeter of a polygon
        /// </summary>
        /// <returns></returns>
        public double GetPerimeter()
        {
            return NumberOfSides * SideLength;
        }

        /// <summary>
        /// We cant implement this, because implement depends on number of sides of polygon
        /// Each polygon area calculation is different
        /// </summary>
        /// <returns></returns>
        public virtual double GetArea()
        {
            throw new NotImplementedException();
        }
        
    }
}
