using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_TDD
{


    public class Compass
    {
        public Compass(Point point)
        {

        }


        public Point CurrentPoint { get; set; }

        public Point Rotate(Point point, Direction direction)
            {

            if(point == Point.North && direction == Direction.Right)
            {
                return Point.East;
            }


            return Point.South; //this is just a fallback
            }
    }
}
