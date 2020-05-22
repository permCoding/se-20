using System;
using System.Collections.Generic;

namespace step1
{
    class Program
    {
        static void Main()
        {
            int countPoints = 10;
            byte width = 60, height = 25;
            Console.CursorVisible = false; // отключим курсор
            Console.WindowWidth = width; Console.WindowHeight = height;
            Random rnd = new Random();

            List<Point> points = new List<Point>();
            while(points.Count < countPoints)
                points.Add(new Point(rnd.Next(1, width-1), rnd.Next(1, height - 1)));

            foreach (var point in points)
                point.setPoint();

            Console.ReadLine();
        }
    }
}
