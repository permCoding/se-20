using System;
using System.Collections.Generic;

namespace step1
{
    class Point
    {
        public int X;
        public int Y;
        public Point() : this(0, 0)
        {
        }
        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
    }
}
