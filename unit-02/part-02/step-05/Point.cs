using System;
using System.Collections.Generic;

namespace step1
{
    class Point
    {
        private static int index = -1;
        public int id;
        public int X;
        public int Y;
        public Point() : this(0, 0)
        {
        }
        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
            this.id = ++index;
        }
        public void setPoint()
        {
            Console.SetCursorPosition(this.X, this.Y);
            Console.Write('#');
        }
    }
}
