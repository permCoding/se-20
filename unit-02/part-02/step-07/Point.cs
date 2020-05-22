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
        public int shiftY;
        public Point() : this(0, 0, 0)
        {
        }
        public Point(int x, int y, int shY)
        {
            this.X = x;
            this.Y = y;
            this.shiftY = shY;
            this.id = ++index;
        }
        public void SetPoint()
        {
            Console.SetCursorPosition(this.X, this.Y);
            Console.Write('#');
        }
        public void MovePoint(int height)
        {
            this.Y += this.shiftY;
            if (this.Y == 0) this.shiftY = +1;
            if (this.Y == height-1) this.shiftY = -1;
            SetPoint();
        }
    }
}
