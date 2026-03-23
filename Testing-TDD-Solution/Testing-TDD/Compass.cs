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
            //turning Right
         
            if (point == Point.North && direction == Direction.Right)
            {
                return Point.East;
            }
            else if (point == Point.East && direction == Direction.Right)
            {
                return Point.South;
            }
            else if (point == Point.South && direction == Direction.Right)
            {
                return Point.West;
            }
            else if (point == Point.West && direction == Direction.Right)
            {
                return Point.North;

                //turning Left
            }
            else if (point == Point.North && direction == Direction.Left)
            {
                return Point.West;
            }
            else if (point == Point.West && direction == Direction.Left)
            {
                return Point.South;
            }
            else if (point == Point.South && direction == Direction.Left)
            {
                return Point.East;
            }
            else if (point == Point.East && direction == Direction.Left)
            {
                return Point.North;
            }



            return Point.South; //this is just a fallback
            }

        
            

        }
    }

