using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLassWork27._05
{
    public struct Point
    {
        int X;
        int Y;
        int Z;     // + object C

        public Point(int x, int y, int z)  //+ object c
        {
            this.X = x; this.Y = y; this.Z = z;
        }

        public static Point operator + (Point first, Point second)
        {
            return new Point(first.X + second.X, first.Y + first.X, second.X + second.Y);
        }
       
    }
}
