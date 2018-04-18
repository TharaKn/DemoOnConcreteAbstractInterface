using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Polygons.Library;

namespace DemoOnConcreteAbstarctInterface
{
    public class Program
    {
        static void Main(string[] args)
        {
            var Square = new Square(5);
            DisplayPolygon("Square", Square);

            var Triangle = new Triangle(5);
            DisplayPolygon("Triangle", Triangle);

            var Octagon = new Octagon(5);
            DisplayPolygon("Octagon", Octagon);

            Console.ReadLine();
            
            
        }

        public static void DisplayPolygon( String polygonType, dynamic var)
        {
            try
            {
                
                Console.WriteLine("{0} Number of sides {1}",polygonType, var.NumberOfSides );
                Console.WriteLine("{0} Side Length {1}", polygonType, var.SideLength);
                Console.WriteLine("{0} Area {1}", polygonType, var.GetArea());
            }
            catch
            { }
        }
    }
}
