using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_TDD
{


    internal class Compass
    {
        public Point CurrentPoint { get; set; }

     

        public static Point Rotate(Point point, Direction direction)
            {
            return Point.South;
            }
    }
}
