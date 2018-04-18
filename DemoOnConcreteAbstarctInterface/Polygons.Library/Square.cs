using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polygons.Library
{
    public class Square : ConcreteRegularPolygon
    {
        public Square(int length): base(4, length) { }

        //No compile time checking if this is not implemented
        public override double GetArea()
        {
            return SideLength * SideLength;
        }        
    }
}
